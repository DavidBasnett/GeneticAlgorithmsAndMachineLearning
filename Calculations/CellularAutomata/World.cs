using System;
using System.Drawing;

namespace Calculations.CellularAutomata
{
    public abstract class World
    {
        protected readonly int _width;
        protected readonly int _height;
        protected readonly bool[,] _state;
        protected readonly bool _wrap;
        private readonly Random _random = new Random();
        private System.Threading.Timer _timer;
        private Image _image;
        private float _cellScale;

        public Image Image { get { return _image; } }
        public event EventHandler ImageUpdated;
        public void OnImageUpdated()
        {
            if (ImageUpdated != null) { ImageUpdated(this, null); }
        }

        public World(int width, int height, bool wrap)
        {
            _width = width;
            _height = height;
            _wrap = wrap;
            _state = new bool[width, height];
        }
        public void Start(Image image)
        {
            _image = image;
            _cellScale = Math.Min((float)_image.Width / _width, (float)_image.Height / _height);

            _timer = new System.Threading.Timer(Update, null, 100, 100);
        }
        public void Stop()
        {
            _timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
        }

        public void InitialiseWithRandomState(int fillWidth, int fillHeight, int number)
        {
            if (number > fillWidth * fillHeight)
            {
                throw new ArgumentException("fill rectangle is not big enought to contain that many points");
            }

            var fill = new bool[fillWidth * fillHeight];
            for (int i = 0; i < number; i++) { fill[i] = true; }
            KnuthShuffle(fill);
            var xfillStart = (int)(Math.Floor((_width - fillWidth) / 2.0));
            var yfillStart = (int)(Math.Floor((_height - fillHeight) / 2.0));

            for (int i = 0; i < fill.Length; i++)
            {
                if (fill[i])
                {
                    var x = xfillStart + i % fillWidth;
                    var y = yfillStart + i / fillWidth;
                    Spark(x, y);
                }
            }
        }

        private void Update(object state)
        {
            UpdateCells();
            Draw();
        }

        protected abstract void UpdateCells();

        private void Draw()
        {
            var brush = new SolidBrush(Color.Cyan);
            using (var graphics = Graphics.FromImage(_image))
            {
                graphics.Clear(Color.White);
                for (int x = 0; x < _width; x++)
                {
                    for (int y = 0; y < _height; y++)
                    {
                        if (IsAlive(x, y))
                        {
                            graphics.FillEllipse(brush, x * _cellScale, y * _cellScale, _cellScale, _cellScale);
                        }
                    }
                }
            }
            OnImageUpdated();
        }

        public bool IsAlive(int x, int y)
        {
            return _state[x, y];
        }

        public void Spark(int x, int y)
        {
            if (IsAlive(x, y))
            {
                throw new InvalidOperationException("Cell already alive");
            }
            _state[x, y] = true;
        }

        private void KnuthShuffle<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = _random.Next(i, array.Length); // Don't select from the entire array on subsequent loops
                T temp = array[i]; array[i] = array[j]; array[j] = temp;
            }
        }
    }
}
