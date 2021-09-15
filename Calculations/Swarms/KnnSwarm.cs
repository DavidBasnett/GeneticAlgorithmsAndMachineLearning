using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Calculations
{
    public class KnnSwarm : Swarm
    {

        public KnnSwarm(Image image) : base(image) { }

        protected override void Initialise()
        {
            AddParticle();
            AddParticle();
        }

        protected override Particle CreateNewParticle()
        {
            return new Particle(_image.Width / 2, _image.Height / 2);
        }

        protected override void MoveParticles()
        {
            foreach (var particle in _particles)
            {
                Move(particle);
            }
        }

        private void Move(Particle particle)
        {
            //first a small random move as before​
            particle.X += _randomStepSize * (float)(_random.NextDouble() - 0.5);
            particle.Y += _randomStepSize * (float)(_random.NextDouble() - 0.5);

            var k = Math.Min(5, _particles.Count - 1); //experiment at will​
            var nearestNeighbours = KthNearestNeighbours(_particles, particle, k);
            if (!nearestNeighbours.Any()) { return; }

            var centroid = FindCentroid(nearestNeighbours);
            particle.X += (float)((centroid.X - particle.X) * (_random.NextDouble() - 0.5));
            particle.Y += (float)((centroid.Y - particle.Y) * (_random.NextDouble() - 0.5));
        }
        protected override bool ShouldStop()
        {
            return _particles.Any(particle => HasEscaped(particle));
        }

        private List<Particle> KthNearestNeighbours(List<Particle> items, Particle item, int k)
        {
            var particlesByDistance = new SortedList<double, Particle>();
            for (var i = 0; i < items.Count; i++)
            {
                var neighbour = items[i];
                if (neighbour == item) { continue; }
                var distance = EuclideanDistance(item, neighbour);
                particlesByDistance.Add(distance, neighbour);
            }
            return particlesByDistance.Take(k).Select(kvp => kvp.Value).ToList();
        }

        private double EuclideanDistance(Particle item, Particle neighbour)
        {
            return Math.Sqrt(Math.Pow(item.X - neighbour.X, 2) + Math.Pow(item.Y - neighbour.Y, 2));
        }

        private Particle FindCentroid(List<Particle> items)
        {
            if (items.Count == 0) { return new Particle(0, 0); }
            var xSum = items.Sum(particle => particle.X);
            var ySum = items.Sum(particle => particle.Y);
            return new Particle(xSum / items.Count, ySum / items.Count);
        }

    }
}
