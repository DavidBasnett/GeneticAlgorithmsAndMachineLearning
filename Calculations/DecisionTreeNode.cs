using System.Collections.Generic;

namespace Calculations
{
    public class DecisionTreeNode<C>
    {
        private readonly string _name;
        private readonly C _category;
        private readonly Dictionary<double, DecisionTreeNode<C>> _childNodes = new Dictionary<double, DecisionTreeNode<C>>();
        private readonly bool _isLeaf;

        public string Name { get { return _name; } }
        public C Category { get { return _category; } }
        public Dictionary<double, DecisionTreeNode<C>> ChildNodes { get { return _childNodes; } }
        public bool IsLeaf { get { return _isLeaf; } }

        public DecisionTreeNode(string name)
        {
            _name = name;
        }
        private DecisionTreeNode(C category)
        {
            _category = category;
            _isLeaf = true;
        }
        
        public static DecisionTreeNode<C> Leaf(C category)
        {
            return new DecisionTreeNode<C>(category);
        }
        public void AddChild(double classValue, DecisionTreeNode<C> child)
        {
            _childNodes.Add(classValue, child);
        }
    }
}
