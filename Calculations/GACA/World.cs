using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System;

namespace Calculations.GACA
{
    public class World
    {
        protected readonly int _height;
        protected readonly bool _wrap;
        private readonly List<Row> _history = new List<Row>();
        private Row _row;
        private readonly Rule _rule;

        public World(Rule rule, Row startingRow, int height)
        {
            _rule = rule;
            _height = height;
            Reset(startingRow);
        }

        public int Height { get { return _height; } }
        public int Width { get { return _history[0].Cells.Length; } }
        public Row State { get { return _row; } }
        public Row StartState { get { return _history[0]; } }

        public void Reset(Row newStartingRow)
        {
            _row = newStartingRow;
            _history.Clear();
            _history.Add(_row);
            Run();
        }
        public void Run()
        {
            while (_history.Count() < _height )
            {
                _row = _rule.Apply(_row);
                _history.Add(_row);
            }
        }

        public void Draw(Image image)
        {
            var cellScale = Math.Min((float)image.Width / Width, (float)image.Height / Height);

            var brush = new SolidBrush(Color.Cyan);
            using (var graphics = Graphics.FromImage(image))
            {
                graphics.Clear(Color.White);
                for (int x = 0; x < Width; x++)
                {
                    for (int y = 0; y < Height; y++)
                    {
                        if (_history[y].Cells[x])
                        {
                            graphics.FillEllipse(brush, x * cellScale, y * cellScale, cellScale, cellScale);
                        }
                    }
                }
            }
        }
    }
}
