using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Calculations
{
    public class AntColonyOptimisation
    {
        private const int NumberOfAnts = 25;
        private const double Rho = 0.25;
        private const double Alpha = 1.0;
        private const double Beta = 3.0;
        private const float GridSize = 50.0F;

        private System.Threading.Timer _timer;
        protected Image _image;
        private int _iteration = 0;
        private List<Pheromone> _pheromones;
        private float _scale, _edge;
        private int _height, _width;
        private Random _random = new Random();
        private List<List<Position>> _paths;
        private object _updateLock = new object();

        public event EventHandler ImageUpdated;
        public Image Image { get { return _image; } }
        public bool MiddleStart { get; set; } = false;

        public void OnImageUpdated()
        {
            if (ImageUpdated != null) { ImageUpdated(this, null); }
        }

        public AntColonyOptimisation(Image image)
        {
            _image = image;
        }
        public void Start()
        {
            Initialise();
            _timer = new System.Threading.Timer(Update, null, 100, 100);
        }
        public void Stop()
        {
            _timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
        }

        private void Initialise()
        {
            _iteration = 0;
            _pheromones = new List<Pheromone> { };
            _scale = Math.Min(Image.Height, Image.Width) / GridSize;
            _edge = _scale / 10;
            _height = (int)(Image.Height / _scale);
            _width = (int)((Image.Width - 2 * _edge) / _scale);

            _paths = MakePaths();
            Update(null);
            Draw();
        }

        private Position StartPosition()
        {
            if (MiddleStart)
            {
                return new Position((int)Math.Floor(_width / 2.0), 0);
            }
            else
            {
                return new Position((int)(_random.NextDouble() * (_width + 1)), 0);
            }
        }

        private List<Position> RandomPath()
        {
            //assume we start at the bottom, if we get to the top we are out.
            var path = new List<Position>();
            var position = StartPosition();
            path.Add(position);

            while (position.Y < _height)
            {
                position = NextPosition(position, path);
                path.Add(position);
            }

            return path;
        }

        private List<List<Position>> MakePaths()
        {
            var paths = new List<List<Position>>();
            for (int i = 0; i < NumberOfAnts; i++)
            {
                paths.Add(RandomPath());
            }
            return paths;
        }

        private List<Position> PossibleNextPositions(Position position)
        {
            var possiblePositions = new List<Position>()
            { new Position (position.X - 1, position.Y - 1),
            new Position (position.X , position.Y - 1),
            new Position (position.X + 1, position.Y - 1),
            new Position (position.X - 1, position.Y ),
            new Position (position.X , position.Y ),
            new Position (position.X + 1, position.Y ),
            new Position (position.X - 1, position.Y + 1),
            new Position (position.X , position.Y + 1),
            new Position (position.X + 1, position.Y + 1)};

            return possiblePositions.Where(pos => pos.X >= 0 && pos.X <= _width && pos.Y >= 0).ToList();
        }

        private bool Contains(Position position, List<Position> path)
        {
            return path.Any(pos => pos.X == position.X && pos.Y == position.Y);
        }

        private List<Position> AllowedNextPositions(Position Position, List<Position> path)
        {
            var possible = PossibleNextPositions(Position);
            var allowed = possible.Where(pos => !Contains(pos, path)).ToList();
            if (!allowed.Any())
            { allowed = possible; }
            return allowed;
        }

        private Position NextPosition(Position Position, List<Position> path)
        {
            var allowed = AllowedNextPositions(Position, path);
            var index = (int)Math.Floor(_random.NextDouble() * allowed.Count);
            return allowed[index];
        }

        private void Draw()
        {
            using (var graphics = Graphics.FromImage(_image))
            {
                graphics.Clear(Color.White);
                graphics.FillRectangle(new SolidBrush(Color.Gray), _edge, _scale, _image.Width - 2 * _edge, _image.Height - _scale);
                // draw best and worst paths only ?
                var best = _paths.OrderBy(path => TotalLength(path)).First();
                var worst = _paths.OrderBy(path => TotalLength(path)).Last();
                DrawPath(graphics, best, Color.Green);
                DrawPath(graphics, worst, Color.Red);
            }
            OnImageUpdated();
        }
        private void DrawPath(Graphics graphics, List<Position> path, Color lineColour)
        {
            if (!path.Any()) { return; }

            var x = new Func<Position, float>(pos => _edge + pos.X * _scale);
            var y = new Func<Position, float>(pos => _image.Height - pos.Y * _scale);

            var points = path.Select(pos => new PointF(x(pos), y(pos))).ToArray();

            graphics.DrawLines(new Pen(new SolidBrush(lineColour), 5.0F), points);
        }

        private void Update(object state)
        {
            if (_iteration == 50) { Stop(); }
            lock (_updateLock)
            {
                Draw();
                UpdatePheromonesAndPaths();
                _paths.Clear();
                for (int i = 0; i < NumberOfAnts; i++)
                {
                    _paths.Add(PheremonePath());
                }
                _iteration++;
            }
        }

        private void UpdatePheromonesAndPaths()
        {
            Evaporate();
            _paths.ForEach(path => AddNewPheromones(path));
        }

        private void Evaporate()
        {
            for (int index = 0; index < _pheromones.Count; index++)
            {
                _pheromones[index].Weight *= (1 - Rho);
            }
        }

        private void AddNewPheromones(List<Position> path)
        {
            var Q = 2 * _height;
            var L = Q / TotalLength(path);

            path.ForEach(pos =>
            {
                var pheromoneToUpdate = PheromoneAt(pos);
                if (pheromoneToUpdate != null)
                {
                    pheromoneToUpdate.Weight += L;
                }
                else
                {
                    _pheromones.Add(new Pheromone(pos.X, pos.Y, L));
                }
            });
        }

        private Pheromone PheromoneAt(Position pos)
        {
            return _pheromones.FirstOrDefault(pheremone => pos.X == pheremone.X && pos.Y == pheremone.Y);
        }

        private double EuclideanDistance(Position first, Position second)
        {
            return Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2));
        }

        private double TotalLength(List<Position> path)
        {
            var length = 0.0;
            for (int i = 1; i < path.Count; i++)
            {
                length += EuclideanDistance(path[i - 1], path[i]);
            }
            return length;
        }

        private List<Position> PheremonePath()
        {
            var path = new List<Position>();
            var pos = StartPosition();
            path.Add(pos);
            while (pos.Y < _height)
            {
                var moves = AllowedNextPositions(pos, path);
                pos = RouletteWheelChoice(moves);
                path.Add(pos);
            }
            return path;
        }

        private double TauEta(double pheromone, double y)
        {
            return Math.Pow(pheromone, Alpha) * Math.Pow(y, Beta);
        }

        private List<double> PartialSum(List<Position> moves)
        {
            var total = 0.0;
            var cumulative = new List<double>() { total };
            for (int index = 0; index < moves.Count; index++)
            {
                var pheremone = PheromoneAt(moves[index]);
                if (pheremone != null)
                {
                    total += TauEta(pheremone.Weight, pheremone.Y);
                }
                cumulative.Add(total);
            }
            return cumulative;
        }

        private Position RouletteWheelChoice(List<Position> moves)
        {
            var cumulative = PartialSum(moves);
            var total = cumulative.Last();
            var p = _random.NextDouble() * total;

            for (int i = 0; i < cumulative.Count - 1; i++)
            {
                if (cumulative[i] < p && p <= cumulative[i + 1])
                {
                    return moves[i];
                }
            }
            return moves[(int)Math.Floor(_random.NextDouble() * moves.Count)];
        }

        private class Pheromone
        {
            internal int X { get; set; }
            internal int Y { get; set; }
            internal double Weight { get; set; }

            public Pheromone(int x, int y, double weight)
            {
                X = x;
                Y = y;
                Weight = weight;
            }
            public override string ToString()
            {
                return $"({X},{Y}) = {Weight}";
            }
        }
        private class Position
        {
            internal int X { get; set; }
            internal int Y { get; set; }

            internal Position(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"({X},{Y})";
            }
        }
    }
}
