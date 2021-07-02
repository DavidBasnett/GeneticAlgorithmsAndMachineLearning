using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculations
{
    public class DecisionTree<C>
    {
        /*FUTURE
        Currently this is using "exact" matching only.
        Since we are assuming double values for the features, we could allow in-exact matching when building the tree
        Or prune the nodes after building the tree, so that instead of rules like
        if x = 0.134 then 
        we'd get if x is between 0 and 1 then*/

        public DecisionTreeNode<C> CreateTree(IEnumerable<ICategorisedValue<C>> data, List<string> featureLabels)
        {
            var leaf = PotentialLeafNode(data);
            var category = leaf.Key;
            var count = leaf.Value;
            if (count == data.Count())
            {
                return DecisionTreeNode<C>.Leaf(category);
            }
            var feature = BestFeatureForSplit(data);
            var featureLabel = featureLabels[feature];
            var node = new DecisionTreeNode<C>(featureLabel);
            var classes = data.Select(d => d.Value[feature]).Distinct();
            foreach (var c in classes)
            {
                var partitionedData = data.Where(d => d.Value[feature] == c);
                node.AddChild(c, CreateTree(partitionedData, featureLabels));
            }
            return node;
        }

        public C Classify(DecisionTreeNode<C> node, List<string> featureLabels, List<double> data)
        {
            if (node.IsLeaf) { return node.Category; }
            var index = featureLabels.IndexOf(node.Name);
            foreach (var kvp in node.ChildNodes)
            {
                if (data[index] == kvp.Key)
                {
                    if (kvp.Value.IsLeaf)
                    {
                        return kvp.Value.Category;
                    }
                    return Classify(kvp.Value, featureLabels, data);
                }
            }
            throw new InvalidOperationException("Data cannot be categorised");
        }

        public string AsRules(DecisionTreeNode<C> node, List<string> featureLabels, int indent = 0)
        {
            var spaceIndent = string.Concat(Enumerable.Repeat(" ", indent));
            var stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append(spaceIndent);
            var index = featureLabels.IndexOf(node.Name);
            foreach (var kvp in node.ChildNodes)
            {
                stringBuilder.Append($"if {featureLabels[index]} = {kvp.Key}");

                if (kvp.Value.IsLeaf)
                {
                    stringBuilder.Append($" then {kvp.Value.Category}");
                    if (indent == 0) { stringBuilder.Append($".{Environment.NewLine }"); } else { stringBuilder.Append(", "); }
                }
                else
                {
                    stringBuilder.Append($":{Environment.NewLine}{spaceIndent}{AsRules(kvp.Value, featureLabels, indent + 1)}");
                }
            }
            stringBuilder.Append(Environment.NewLine);
            var rules = stringBuilder.ToString();
            return rules.TrimEnd(new char[] { ',', ' ' });
        }

        public (double minX, double minY, double maxX, double maxY) FindEdges(DecisionTreeNode<C> node, List<string> featureLabels, List<double> X, List<double> Y, C interior)
        {
            X.Sort();
            Y.Sort();
            var diagonals = X.Intersect(Y).Distinct().ToList();
            diagonals.Sort();
            var L = diagonals.Select(d => Classify(node, featureLabels, new List<double> { d,d})).ToList();
            var low = L.IndexOf(interior);
            var minX = X[low];
            var minY = Y[low];
            var high = L.LastIndexOf(interior);
            var maxX = X[high];
            var maxY = Y[high];

            return (minX, minY, maxX, maxY);
        }

        private KeyValuePair<C, int> PotentialLeafNode(IEnumerable<ICategorisedValue<C>> data)
        {
            var frequency = Counter(data);
            var highestFrequency = frequency.Max(kvp => kvp.Value);
            return frequency.First(kvp => kvp.Value == highestFrequency);
        }
        private int BestFeatureForSplit(IEnumerable<ICategorisedValue<C>> data)
        {
            var baseline = Entrophy(data);
            var features = data.First().Value.Count();
            var informationGain = Enumerable.Range(0, features ).Select(f => baseline - FeatureEntrophy(data, f)).ToList();
            var bestGain = informationGain.Max();
            var bestFeature = informationGain.IndexOf(bestGain);
            return bestFeature;
        }
        private double FeatureEntrophy(IEnumerable<ICategorisedValue<C>> data, int feature)
        {
            return data.Select(d => d.Value[feature]).Sum(v => FeatureEntrophyForValue(data, feature, v));
        }
        private double FeatureEntrophyForValue(IEnumerable<ICategorisedValue<C>> data, int feature, double value)
        {
            var partitionedData = data.Where(d => d.Value[feature] == value);
            var proportion = (double)partitionedData.Count() / data.Count();
            return proportion * Entrophy(partitionedData);
        }
        private double Entrophy(IEnumerable<ICategorisedValue<C>> data)
        {
            var frequency = Counter(data);
            return frequency.Values.Sum(count =>
            {
                var ratio = (double)count / data.Count();
                return -1 * ratio * Math.Log(ratio, 2);
            }
            );
        }
        private Dictionary<C, int> Counter(IEnumerable<ICategorisedValue<C>> data)
        {
            var categories = data.Select(cv => cv.Category).Distinct();
            var counts = new Dictionary<C, int>();
            foreach (var category in categories)
            {
                counts.Add(category, data.Count(cv => cv.Category.Equals(category)));
            }
            return counts;
        }
    }
}
