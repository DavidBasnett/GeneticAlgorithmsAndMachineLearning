using Nakov.TurtleGraphics;

namespace Calculations
{
    public class LSystem
    {
        private int _length = 12;

        private void X(int depth)
        {
            if (depth > 0) { L("X+YF+", depth); }
        }
        private void Y(int depth)
        {
            if (depth > 0) { L("-FX-Y", depth); }
        }
        private void L(string code, int depth)
        {
            foreach (var character in code)
            {
                if (character == '-') { Turtle.Rotate(-90); }
                if (character == '+') { Turtle.Rotate(90); }
                if (character == 'X') { X(depth - 1); }
                if (character == 'Y') { Y(depth - 1); }
                if (character == 'F') { Turtle.Forward(_length); }
            }
        }
        public void Dragon()
        {
            ResetTurtle();
            _length = 12;
            Turtle.PenColor = System.Drawing.Color.Blue;
            X(10);
        }

        private void ResetTurtle()
        {
            Turtle.PenUp();
            Turtle.MoveTo(0, 0);
            Turtle.Angle = 0;
            Turtle.PenSize = 1;
            Turtle.PenDown();
        }
    }
}
