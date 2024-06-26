﻿using System;
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
using System.Windows.Forms.DataVisualization.Charting;
using Calculations.CellularAutomata;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        private readonly Escape _escape = new Escape();
        private Swarm _swarm;
        private AntColonyOptimisation _aco;
        private World _world;

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

        private void buttonRunGA_Click(object sender, EventArgs e)
        {
            var cannon = new GeneticAlgorithmCannon();
            var results = cannon.Run();
            DisplayCannonResults(results.initial, cannon, chartGAInitial, labelGAInitial);
            DisplayCannonResults(results.final, cannon, chartGAFinal, labelGAFinal);
        }
        private void DisplayCannonResults(List<GeneticAlgorithmCannon.Attempt> attempts, GeneticAlgorithmCannon cannon, Chart chart, Label label)
        {
            chart.Series.Clear();
            chart.Annotations.Clear();
            //would be nice to add the bag to the chart here, but that's fiddly. 
            var escaped = 0;
            foreach (var attempt in attempts)
            {
                var result = cannon.Launch(attempt);
                var series = new Series
                {
                    ChartType = SeriesChartType.Line
                };
                foreach (var point in result)
                {
                    series.Points.AddXY(point.X, point.Y);
                }
                //future - set the point symbol based on escaped or not.
                chart.Series.Add(series);
                if (cannon.Escaped(attempt))
                {
                    escaped++;
                }
            }
            chart.ChartAreas[0].RecalculateAxesScale();
            label.Text = $"Escaped {escaped} of {attempts.Count}";
        }

        private void buttonStartKnnSwarm_Click(object sender, EventArgs e)
        {
            if (_swarm != null)
            {
                _swarm.Stop();
            }

            GivePictureBoxBitmap(pictureBoxSwarm);
            _swarm = new KnnSwarm(pictureBoxSwarm.Image);
            _swarm.ImageUpdated += _swarm_ImageUpdated;
            _swarm.Start();
        }
        private void buttonAddParticle_Click(object sender, EventArgs e)
        {
            if (_swarm != null)
            { _swarm.AddParticle(); }
        }
        private void _swarm_ImageUpdated(object sender, EventArgs e)
        {
            UpdateSwarmPictureBox();
        }
        private void UpdateSwarmPictureBox()
        {
            if (pictureBoxSwarm.InvokeRequired)
            {
                pictureBoxSwarm.Invoke(new Action(() => UpdateSwarmPictureBox()));
                return;
            }
            pictureBoxSwarm.Image = _swarm.Image;
        }
        private void buttonStopSwarm_Click(object sender, EventArgs e)
        {
            if (_swarm != null)
            { _swarm.Stop(); }
        }

        private void buttonStartPSO_Click(object sender, EventArgs e)
        {
            if (_swarm != null)
            {
                _swarm.Stop();
            }

            GivePictureBoxBitmap(pictureBoxSwarm);
            _swarm = new PSO(pictureBoxSwarm.Image);
            _swarm.ImageUpdated += _swarm_ImageUpdated;
            _swarm.Start();
        }

        private void buttonStartACO_Click(object sender, EventArgs e)
        {
            if (_aco != null)
            {
                _aco.Stop();
            }

            GivePictureBoxBitmap(pictureBoxACO);
            _aco = new AntColonyOptimisation(pictureBoxACO.Image) { MiddleStart = checkBoxAcoStartInMiddle.Checked};
            _aco.ImageUpdated += _aco_ImageUpdated;
            _aco.Start();
        }

        private void _aco_ImageUpdated(object sender, EventArgs e)
        {
            UpdateACOImage();
        }
        private void UpdateACOImage()
        {
            if (pictureBoxACO.InvokeRequired)
            {
                pictureBoxACO.Invoke(new Action(() => UpdateACOImage()));
                return;
            }
            pictureBoxACO.Image = _aco.Image;
        }
        private void buttonStopACO_Click(object sender, EventArgs e)
        {
            if (_aco != null)
            {
                _aco.Stop();
            }
        }

        private void buttonStartLangtonsAnt_Click(object sender, EventArgs e)
        {
            if (_world != null)
            {
                _world.Stop();
            }

            GivePictureBoxBitmap(pictureBoxCellularAutomata);
            _world = new LangtonsAnt(100,100, false);
            _world.Start(pictureBoxCellularAutomata.Image);
            _world.ImageUpdated += CellularAutomata_ImageUpdated;
        }

        private void CellularAutomata_ImageUpdated(object sender, EventArgs e)
        {
            UpdateCellularAutomataImage();
        }
        private void UpdateCellularAutomataImage()
        {
            if (pictureBoxCellularAutomata.InvokeRequired)
            {
                pictureBoxACO.Invoke(new Action(() => UpdateCellularAutomataImage()));
                return;
            }
            pictureBoxCellularAutomata.Image = _world.Image;
        }

        private void GivePictureBoxBitmap(PictureBox pictureBox)
        {
            pictureBox.Image = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
        }

        private void buttonStopCellularAutomata_Click(object sender, EventArgs e)
        {
            if (_world != null)
            {
                _world.Stop();
            }
        }

        private void buttonGameOfLife_Click(object sender, EventArgs e)
        {
            if (_world != null)
            {
                _world.Stop();
            }

            GivePictureBoxBitmap(pictureBoxCellularAutomata);
            _world = new GameOfLife(100,100, true);
            _world.InitialiseWithRandomState(50,50, 800);
            _world.Start(pictureBoxCellularAutomata.Image);
            _world.ImageUpdated += CellularAutomata_ImageUpdated;
        }

        private void buttonGACAOneMax_Click(object sender, EventArgs e)
        {
            RunGACA(new Calculations.GACA.StaticRule());
        }

        private void RunGACA(Calculations.GACA.Rule rule)
        {
            var optimiser = new Calculations.GACA.Algorithm();
            var result = optimiser.Optimise(rule,
                numberOfWorlds : 100,
                mutationRate : 0.10,
                epochs : 40,
                updates : 10,
                middle : false,
                target : true);
            GivePictureBoxBitmap(pictureBoxGACA);
            result.Draw(pictureBoxGACA.Image);
        }

        private void buttonECARule_Click(object sender, EventArgs e)
        {
            RunGACA(new Calculations.GACA.ECARule((byte)numericUpDownECARuleNumber.Value));
        }

        private void buttonDeamRule_Click(object sender, EventArgs e)
        {
            RunGACA(new Calculations.GACA.DreamRule());
        }
    }
}
