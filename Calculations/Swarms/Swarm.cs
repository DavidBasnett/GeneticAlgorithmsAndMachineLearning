using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Calculations
{
    public abstract class Swarm
    {
        private System.Threading.Timer _timer;
        protected Image _image;
        protected List<Particle> _particles = new List<Particle>();
        private readonly object particleLock = new object();
        private float _bagLeft, _bagTop, _bagWidth, _bagHeight;
        protected Random _random = new Random();
        protected float _randomStepSize = 1.0F;

        public event EventHandler ImageUpdated;
        public Image Image { get { return _image; } }

        public void OnImageUpdated()
        {
            if (ImageUpdated != null) { ImageUpdated(this, null); }
        }

        public Swarm(Image image)
        {
            _image = image;
            _bagLeft = _image.Width / 3;
            _bagTop = _image.Height / 3;
            _bagWidth = _image.Width / 3;
            _bagHeight = _image.Height / 3;
            _randomStepSize = 0.02F * Math.Min(image.Width, image.Height);
        }
        public void Start()
        {
            _particles.Clear();
            Initialise();
            _timer = new System.Threading.Timer(Update, null, 100, 100);
        }
        protected abstract void Initialise();

        public void Stop()
        {
            _timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
        }
        public void AddParticle()
        {
            var particle = CreateNewParticle();
            lock (particleLock)
            {
                _particles.Add(particle);
            }
        }
        protected abstract Particle CreateNewParticle();

        private void Update(object state)
        {
            lock (particleLock)
            {
                MoveParticles();
                DrawParticles();
                if (ShouldStop())
                {
                    Stop();
                }
            }
        }

        protected abstract bool ShouldStop();

        protected abstract void MoveParticles();

        private void DrawParticles()
        {
            using (var graphics = Graphics.FromImage(_image))
            {
                graphics.Clear(Color.White);
                graphics.FillRectangle(new SolidBrush(Color.Gray), _bagLeft, _bagTop, _bagWidth, _bagHeight);
                foreach (var particle in _particles)
                {
                    graphics.DrawRectangle(new Pen(Color.Black), particle.X, particle.Y, 4, 4);
                }
            }
            OnImageUpdated();
        }

        protected bool HasEscaped(Particle particle)
        {
            var bagBottom = _bagTop + _bagHeight;
            var bagRight = _bagLeft + _bagWidth;
            return !((particle.X > _bagLeft) && (particle.X < bagRight) &&
                (particle.Y > _bagTop) && (particle.Y < bagBottom));
        }

        protected internal class Particle
        {
            internal float X { get; set; }
            internal float Y { get; set; }
            internal Location Best { get; set; }
            internal Velocity Velocity { get; set; }

            internal Particle(float x, float y)
            {
                X = x;
                Y = y;
                Best = new Location(x, y);
                Velocity = new Velocity(0, 0);
            }
        }
    }
}
