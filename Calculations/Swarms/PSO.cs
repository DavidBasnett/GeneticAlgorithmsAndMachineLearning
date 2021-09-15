using System.Drawing;
using System.Linq;

namespace Calculations
{
    public class PSO : Swarm
    {
        private int _epoch;
        private Location _bestGlobal;
        private float _inertiaWeight = 0.9F;
        private float _personalWeight = 0.5F;
        private float _swarmWeight = 0.5F;

        public PSO(Image image) : base(image) { }

        protected override void Initialise()
        {
            for (int i = 0; i < 20; i++)
            {
                AddParticle();
            }
            _epoch = 0;
            _bestGlobal = _particles.First().Best;
        }

        protected override Particle CreateNewParticle()
        {
            var x = _random.Next((int)(_image.Width * 0.1), (int)(_image.Width * 0.9));
            var y = _image.Height / 2;

            return new Particle(x, y)
            {
                Best = new Location(x, y),
                Velocity = new Velocity(_random.Next(-5, 5), _random.Next(0, 5))
            };
        }

        protected override void MoveParticles()
        {
            _epoch += 1;
            foreach (var particle in _particles)
            {
                Move(particle);
            }
            UpdateBestGlobal();
        }
        private void UpdateBestGlobal()
        {
            foreach (var particle in _particles)
            {
                particle.Best = particle.Y < particle.Best.Y ? new Location(particle.X, particle.Y) : particle.Best;
            }
            var bestParticle = _particles.OrderBy(particle => particle.Best.Y).First();
            _bestGlobal = bestParticle.Y < _bestGlobal.Y ? bestParticle.Best : _bestGlobal;
        }

        private void Move(Particle particle)
        {
            var random1 = _random.Next(0, 5);
            var random2 = _random.Next(0, 5);
            var movementX = (_inertiaWeight * particle.Velocity.X)
                + (_personalWeight * random1 * (particle.Best.X - particle.X))
                + (_swarmWeight * random2 * (_bestGlobal.X - particle.X));
            var movementY = (_inertiaWeight * particle.Velocity.Y)
                + (_personalWeight * random1 * (particle.Best.Y - particle.Y))
                + (_swarmWeight * random2 * (_bestGlobal.Y - particle.Y));
            var shouldUpdateVelocity = true;
            var newX = particle.X + movementX;
            if (newX < 0)
            { particle.X = 0; shouldUpdateVelocity = false; }
            else if (newX > _image.Width)
            { particle.X = _image.Width; shouldUpdateVelocity = false; }
            else
            {
                particle.X = newX;
            }
            var newY = particle.Y + movementY;
            if (newY < 0)
            { particle.Y = 0; shouldUpdateVelocity = false; }
            else if (newY > _image.Width)
            { particle.Y = _image.Width; shouldUpdateVelocity = false; }
            else
            {
                particle.Y = newY;
            }
            if (shouldUpdateVelocity)
            {
                particle.Velocity = new Velocity(movementX, movementY);
            }
        }

        protected override bool ShouldStop()
        {
            return _epoch > 40;
        }

    }
}
