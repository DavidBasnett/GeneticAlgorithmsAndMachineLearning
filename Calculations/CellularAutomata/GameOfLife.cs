using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.CellularAutomata
{
    public class GameOfLife : World
    {
        public GameOfLife(int width, int height, bool wrap) : base(width, height, wrap) { }

        protected override void UpdateCells()
        {
            var newState = new bool[_width, _height];
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    newState[x, y] = FindCellNewState(x, y);
                }
            }
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    _state[x, y] = newState[x, y];
                }
            }
        }

        private bool FindCellNewState(int x, int y)
        {
            int liveNeighbours = 0;
            if (_wrap)
            {
                WalkNeighboursWithWrapping(x, y, (nx, ny) => liveNeighbours += IsAlive(nx, ny) ? 1 : 0);
            }
            else
            {
                WalkNeighbours(x, y, (nx, ny) => liveNeighbours += IsAlive(nx, ny) ? 1 : 0);
            }
            if (IsAlive(x, y))
            {
                return liveNeighbours == 2 || liveNeighbours == 3;
            }
            else
            {
                return liveNeighbours == 3;
            }
        }

        private void WalkNeighbours(int x, int y, Action<int, int> action)
        {
            if (y > 0)
            {
                if (x > 0) { action(x - 1, y - 1); }
                action(x, y - 1);
                if (x < _width - 1) { action(x + 1, y - 1); }
            }
            if (x > 0) { action(x - 1, y); }
            if (x < _width - 1) { action(x + 1, y); }
            if (y < _height - 1)
            {
                if (x > 0) { action(x - 1, y + 1); }
                action(x, y + 1);
                if (x < _width - 1) { action(x + 1, y + 1); }
            }
        }
        private void WalkNeighboursWithWrapping(int x, int y, Action<int, int> action)
        {
            var row = y > 0 ? y - 1 : _height - 1;
            action(x > 0 ? x - 1 : _width - 1, row);
            action(x, row);
            action(x < _width - 1 ? x + 1 : 0, row);
            row = y;
            action(x > 0 ? x - 1 : _width - 1, row);
            action(x, row);
            action(x < _width - 1 ? x + 1 : 0, row);
            row = y < _height - 1 ? y + 1 : 0;
            action(x > 0 ? x - 1 : _width - 1, row);
            action(x, row);
            action(x < _width - 1 ? x + 1 : 0, row);
        }

    }
}
