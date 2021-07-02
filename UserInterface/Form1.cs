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
        #region Escape
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
        #endregion

        private void buttonDecision1_Click(object sender, EventArgs e)
        {
            var data = new List<PositionData> {
                new PositionData(0, 0, false),
                new PositionData(1, 0, false),
                new PositionData(0, 1, true),
                new PositionData(1, 1, true) };

            CreateTreeAndShowRules(data);
        }

        private void CreateTreeAndShowRules(List<PositionData> data)
        {
            var labels = new List<string> { "X", "Y", "Out" };
            var decisionTree = new DecisionTree<bool>();
            var classifier = decisionTree.CreateTree(data, labels);
            textBoxDecision.Text = decisionTree.AsRules(classifier, labels);
        }

        private void buttonDecision2_Click(object sender, EventArgs e)
        {
            var data = new List<PositionData> {
                new PositionData(0, 0, false),
                new PositionData(-1, 0, true),
                new PositionData(1, 0, true),
                new PositionData(0, -1, true),
                new PositionData(0, 1, true) };

            CreateTreeAndShowRules(data);
        }

        private void buttonDecisionEscape_Click(object sender, EventArgs e)
        {
            var data = _escape.DrawRandomSpirangles();
            CreateTreeAndShowRules(data);
        }
    }
}
