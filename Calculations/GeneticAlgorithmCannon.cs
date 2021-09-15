using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculations
{
    public class GeneticAlgorithmCannon
    {
        public const double Gravity = 9.81;
        public const double MutationChance = 0.1;

        public int Items { get; set; } = 12;
        public int Epochs { get; set; } = 10;
        public double Width { get; set; } = 10.0;
        public double Height { get; set; } = 5.0;

        private Random _random = new Random();

        public (List<Attempt> initial, List<Attempt> final) Run()
        {
            var generation = RandomTries(Items);
            var initial = generation;
            for (int epoch = 0; epoch < Epochs; epoch++)
            {
                generation = Crossover(generation, Width);
                Mutate(generation);
            }
            return (initial, generation);
        }

        private List<Attempt> RandomTries(int numberOfTries)
        {
            var tries = new List<Attempt>();
            for (int i = 0; i < numberOfTries; i++)
            {
                tries.Add(new Attempt() { Theta = _random.NextDouble() * Math.PI, Velocity = _random.NextDouble() * 20 });
            }
            return tries;
        }

        private List<Attempt> Crossover(List<Attempt> generation, double width)
        {
            var choices = Selection(generation, width);
            var nextGeneration = new List<Attempt>();
            for (int i = 0; i < generation.Count; i++)
            {
                var mum = generation[Choose(choices)];
                var dad = generation[Choose(choices)];
                nextGeneration.Add(Breed(mum, dad));
            }
            return nextGeneration;
        }

        private List<double> Selection(List<Attempt> generation, double width)
        {
            var results = generation.Select(g => HitCoordinate(g, width));
            return CumulativeProbabilities(results.Select(r => r.Y).ToList());
        }

        private Coordinate HitCoordinate(Attempt attempt, double width)
        {
            var x = 0.5 * width;
            var xHit = width;
            if (attempt.Theta > Math.PI / 2)
            {
                x = -x;
                xHit = 0;
            }
            var time = x / (attempt.Velocity * Math.Cos(attempt.Theta));
            var y = attempt.Velocity * time * Math.Sin(attempt.Theta) - 0.5 * Gravity * time * time;
            if (y < 0.0) { y = 0.0; }
            return new Coordinate() { X = xHit, Y = y };
        }

        public bool Escaped(Attempt attempt)
        {
            var hit = HitCoordinate(attempt, Width);
            return (hit.X == 0.0 || hit.X == Width) && (hit.Y > Height);
        }

        private List<double> CumulativeProbabilities(List<double> results)
        {
            if(results.All(r => r==0.0))
            {
                //if they are all rubbish, make them all equally probable
                return Enumerable.Range(1, results.Count).Select(p => (double)p).ToList();
            }
            var cumulativeTotals = new List<double>();
            var total = 0.0;
            results.ForEach(result =>
            {
                total += result;
                cumulativeTotals.Add(total);
            });
            return cumulativeTotals;
        }

        private int Choose(List<double> choices)
        {
            var p = _random.NextDouble() * choices.Last();
            for (int i = 0; i < choices.Count; i++)
            {
                if (choices[i] >= p)
                {
                    return i;
                }
            }
            return choices.Count - 1;
        }

        private Attempt Breed(Attempt mum, Attempt dad)
        {
            return new Attempt() { Theta = mum.Theta, Velocity = dad.Velocity };
        }

        private void Mutate(List<Attempt> generation)
        {
            for (int i = 0; i < generation.Count; i++)
            {
                if (_random.NextDouble() < MutationChance)
                {
                    var newTheta = generation[i].Theta + (-10.0 + 20.0 * _random.NextDouble()) * Math.PI / 180.0;
                    if (0 < newTheta  && newTheta  < 2 * Math.PI)
                    {
                        generation[i].Theta = newTheta;
                    }
                }
                if (_random.NextDouble() < MutationChance)
                {
                    generation[i].Velocity *= (0.9 + 0.2 * _random.NextDouble());
                }
            }
        }

        public List<Coordinate> Launch(Attempt attempt)
        {
            var hit = HitCoordinate(attempt, Width);
            var good = Escaped(attempt);
            var result = new List<Coordinate>();
            result.Add(new Coordinate() { X = Width / 2.0, Y = 0 });
            for (int i = 0; i < 20; i++)
            {
                var time = i * 0.2;
                var x = Width / 2.0 + attempt.Velocity * time * Math.Cos(attempt.Theta);
                var y = attempt.Velocity * time * Math.Sin(attempt.Theta) - 0.5 * Gravity * time * time;
                if (y < 0.0) { y = 0.0; }
                if (!good && !(0 < x && x < Width))
                {
                    result.Add(hit);
                    break;
                }
                result.Add(new Coordinate() { X = x, Y = y });
            }
            return result;
        }
        
        public class Attempt
        {
            public double Theta { get; set; }
            public double Velocity { get; set; }
        }

        public class Coordinate
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}
