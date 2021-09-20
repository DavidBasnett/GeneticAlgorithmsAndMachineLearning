using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.CellularAutomata
{
    public class LangtonsAnt : World
    {
        private int _antX;
        private int _antY;
        private Direction _antDirection;
        public LangtonsAnt(int width, int height, bool wrap) : base(width, height, wrap)
        {
            _antX = (int)Math.Floor(width / 2.0);
            _antY = (int)Math.Floor(height / 2.0);
            _antDirection = Direction.Up;
        }

        protected override void UpdateCells()
        {
            /*Christopher Langton, an artificial life researcher, developed a two-dimensional automaton.
             * Langton’s CA has an artificial ant on a grid.
             * The ant walks around, coloring squares as it moves. 
             * The ant moves forward to one of the four neighboring squares: 
             * left, right, up, or down.
             * Two rules govern the ant’s behavior:
                On a white square, turn clockwise.
                On a black square, turn counter-clockwise.*/
            if (IsAlive(_antX, _antY))
            {
                TurnCounterClockwise();
            }
            else
            {
                TurnClockwise();
            }
            if (MoveAnt())
            { 
                ChangeAntCell();
            }
        }

        private void TurnCounterClockwise()
        {
            switch (_antDirection)
            {
                case Direction.Up:
                    _antDirection = Direction.Left;
                    break;
                case Direction.Down:
                    _antDirection = Direction.Right;
                    break;
                case Direction.Right:
                    _antDirection = Direction.Up;
                    break;
                case Direction.Left:
                    _antDirection = Direction.Down;
                    break;
            }
        }

        private void TurnClockwise()
        {
            switch (_antDirection)
            {
                case Direction.Up:
                    _antDirection = Direction.Right;
                    break;
                case Direction.Down:
                    _antDirection = Direction.Left;
                    break;
                case Direction.Right:
                    _antDirection = Direction.Down;
                    break;
                case Direction.Left:
                    _antDirection = Direction.Up;
                    break;
            }
        }

        private bool MoveAnt()
        {
            switch (_antDirection)
            {
                case Direction.Up:
                    _antY++;
                    break;
                case Direction.Down:
                    _antY--;
                    break;
                case Direction.Right:
                    _antX++;
                    break;
                case Direction.Left:
                    _antX--;
                    break;
            }
            if (_antX <= 0 || _antX >= _width || _antY <= 0 || _antY >= _height)
            {
                Stop();
                return false;
            }
            return true;
        }

        private void ChangeAntCell()
        {
            _state[_antX, _antY] = !_state[_antX, _antY];
        }
        private enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }
    }
}
