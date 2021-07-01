using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;
using Calculations;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        private readonly Escape _escape = new Escape();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            ResetDisplay();
            _escape.DrawLine();
        }

        private void buttonDrawSquares_Click(object sender, EventArgs e)
        {
            ResetDisplay();
            _escape.DrawSquares((int)numericUpDownEscape.Value);
        }

        private void buttonDrawTriangles_Click(object sender, EventArgs e)
        {
            ResetDisplay();
            _escape.DrawTriangles((int)numericUpDownEscape.Value);
        }

       private void buttonSpirangles_Click(object sender, EventArgs e)
        {
            ResetDisplay();
            _escape.DrawRandomSpirangles();
        }

        private void ResetDisplay()
        {
            pictureBoxEscape.Image = null;
            Turtle.Init(pictureBoxEscape);
            _escape.Initialise();
        }

        private void buttonDrawDragon_Click(object sender, EventArgs e)
        {
            pictureBoxEscape.Image = null;
            Turtle.Init(pictureBoxEscape);
            new LSystem().Dragon();
        }
    }
}
