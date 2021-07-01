using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculations
{
    public class Escape
    {
        private Random _random = new Random();

        private void DrawBag()
        {
            Turtle.Rotate(90);
            Turtle.ShowTurtle = true;
            Turtle.PenColor = System.Drawing.Color.Brown;
            Turtle.PenSize = 5;
            Turtle.PenUp();
            Turtle.MoveTo(-35, 35);
            Turtle.PenDown();
            Turtle.Rotate(90);
            Turtle.Forward(70);
            Turtle.Rotate(-90);
            Turtle.Forward(70);
            Turtle.Rotate(-90);
            Turtle.Forward(70);
        }
        public void Initialise()
        {
            DrawBag();
            Turtle.PenUp();
            Turtle.MoveTo(0, 0);
            Turtle.Angle = 90;
            Turtle.PenSize = 1;
            Turtle.PenDown();
        }

        public bool IsEscaped(float X, float Y)
        {
            return (X < -35 || X > 35) || (Y < -35 || Y > 35);
        }

        public void DrawLine()
        {
            var angle = 0;
            var step = 5;
            while (!IsEscaped(Turtle.X, Turtle.Y))
            {
                Turtle.Rotate(-angle);
                Turtle.Forward(step);
            }
        }

        public List<PositionData> DrawSquares(int numberToDraw)
        {
            var positions = new List<PositionData>();
            for (var i = 1; i <= numberToDraw; i++)
            {
                Turtle.PenUp();
                Turtle.MoveTo(-i, -i);
                Turtle.PenDown();
                positions.AddRange(DrawSquare(i * 2));
            }
            return positions;
        }

        private List<PositionData> DrawSquare(float size)
        {
            var corners = new List<PositionData>();
            for (var i = 0; i < 4; i++)
            {
                Turtle.Forward(size);
                Turtle.Rotate(-90);
                StorePositionData(corners);
            }
            return corners;
        }

        private void StorePositionData(List<PositionData> positions)
        {
            positions.Add(new PositionData { X = Turtle.X, Y = Turtle.Y, IsEscaped = IsEscaped(Turtle.X, Turtle.Y) });
        }

        public void DrawTriangles(int numberToDraw)
        {
            for (var i = 1; i <= numberToDraw; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(120);
            }

        }
        private List<PositionData> DrawSpiralUntilEscaped()
        {
            Turtle.PenUp();
            Turtle.MoveTo(0,0);
            Turtle.Rotate(_random.Next(0, 360));
            Turtle.PenDown();

            var length = 0;
            var turn = 360 / _random.Next(1, 10);
            var positions = new List<PositionData>();
            StorePositionData(positions);
            while (!positions.Any(p => p.IsEscaped))
            {
                length++;
                Turtle.Forward(length * 5);
                Turtle.Rotate(turn);
                StorePositionData(positions);
            }
            return positions;
        }
        public List<PositionData> DrawRandomSpirangles()
        {
            var positions = new List<PositionData>();
            for (var i = 0; i < 10; i++)
            {
                positions.AddRange(DrawSpiralUntilEscaped());
            }
            return positions;
        }
    }
}
