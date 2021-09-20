
namespace UserInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEscape = new System.Windows.Forms.TabPage();
            this.buttonDrawDragon = new System.Windows.Forms.Button();
            this.labelEscapeNumber = new System.Windows.Forms.Label();
            this.buttonSpirangles = new System.Windows.Forms.Button();
            this.buttonDrawTriangles = new System.Windows.Forms.Button();
            this.numericUpDownEscape = new System.Windows.Forms.NumericUpDown();
            this.buttonDrawSquares = new System.Windows.Forms.Button();
            this.pictureBoxEscape = new System.Windows.Forms.PictureBox();
            this.buttonDrawLine = new System.Windows.Forms.Button();
            this.tabPageDecisionTree = new System.Windows.Forms.TabPage();
            this.buttonDecisionEscape = new System.Windows.Forms.Button();
            this.buttonDecision2 = new System.Windows.Forms.Button();
            this.textBoxDecision = new System.Windows.Forms.TextBox();
            this.buttonDecision1 = new System.Windows.Forms.Button();
            this.tabPageCannon = new System.Windows.Forms.TabPage();
            this.splitContainerGAResults = new System.Windows.Forms.SplitContainer();
            this.labelGAInitial = new System.Windows.Forms.Label();
            this.chartGAInitial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelGAFinal = new System.Windows.Forms.Label();
            this.chartGAFinal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRunGA = new System.Windows.Forms.Button();
            this.tabPageSwarm = new System.Windows.Forms.TabPage();
            this.buttonStartPSO = new System.Windows.Forms.Button();
            this.buttonAddParticle = new System.Windows.Forms.Button();
            this.buttonStopSwarm = new System.Windows.Forms.Button();
            this.pictureBoxSwarm = new System.Windows.Forms.PictureBox();
            this.buttonStartKnnSwarm = new System.Windows.Forms.Button();
            this.tabPageAnts = new System.Windows.Forms.TabPage();
            this.checkBoxAcoStartInMiddle = new System.Windows.Forms.CheckBox();
            this.buttonStopACO = new System.Windows.Forms.Button();
            this.pictureBoxACO = new System.Windows.Forms.PictureBox();
            this.buttonStartACO = new System.Windows.Forms.Button();
            this.tabPageCellularAutomata = new System.Windows.Forms.TabPage();
            this.buttonGameOfLife = new System.Windows.Forms.Button();
            this.buttonStopCellularAutomata = new System.Windows.Forms.Button();
            this.pictureBoxCellularAutomata = new System.Windows.Forms.PictureBox();
            this.buttonStartLangtonsAnt = new System.Windows.Forms.Button();
            this.tabPageGACA = new System.Windows.Forms.TabPage();
            this.pictureBoxGACA = new System.Windows.Forms.PictureBox();
            this.buttonGACAOneMax = new System.Windows.Forms.Button();
            this.buttonECARule = new System.Windows.Forms.Button();
            this.numericUpDownECARuleNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonDeamRule = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageEscape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEscape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscape)).BeginInit();
            this.tabPageDecisionTree.SuspendLayout();
            this.tabPageCannon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGAResults)).BeginInit();
            this.splitContainerGAResults.Panel1.SuspendLayout();
            this.splitContainerGAResults.Panel2.SuspendLayout();
            this.splitContainerGAResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGAInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGAFinal)).BeginInit();
            this.tabPageSwarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwarm)).BeginInit();
            this.tabPageAnts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxACO)).BeginInit();
            this.tabPageCellularAutomata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCellularAutomata)).BeginInit();
            this.tabPageGACA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGACA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownECARuleNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEscape);
            this.tabControl1.Controls.Add(this.tabPageDecisionTree);
            this.tabControl1.Controls.Add(this.tabPageCannon);
            this.tabControl1.Controls.Add(this.tabPageSwarm);
            this.tabControl1.Controls.Add(this.tabPageAnts);
            this.tabControl1.Controls.Add(this.tabPageCellularAutomata);
            this.tabControl1.Controls.Add(this.tabPageGACA);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEscape
            // 
            this.tabPageEscape.Controls.Add(this.buttonDrawDragon);
            this.tabPageEscape.Controls.Add(this.labelEscapeNumber);
            this.tabPageEscape.Controls.Add(this.buttonSpirangles);
            this.tabPageEscape.Controls.Add(this.buttonDrawTriangles);
            this.tabPageEscape.Controls.Add(this.numericUpDownEscape);
            this.tabPageEscape.Controls.Add(this.buttonDrawSquares);
            this.tabPageEscape.Controls.Add(this.pictureBoxEscape);
            this.tabPageEscape.Controls.Add(this.buttonDrawLine);
            this.tabPageEscape.Location = new System.Drawing.Point(4, 22);
            this.tabPageEscape.Name = "tabPageEscape";
            this.tabPageEscape.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEscape.Size = new System.Drawing.Size(792, 424);
            this.tabPageEscape.TabIndex = 0;
            this.tabPageEscape.Text = "Escape";
            this.tabPageEscape.UseVisualStyleBackColor = true;
            // 
            // buttonDrawDragon
            // 
            this.buttonDrawDragon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDrawDragon.Location = new System.Drawing.Point(8, 393);
            this.buttonDrawDragon.Name = "buttonDrawDragon";
            this.buttonDrawDragon.Size = new System.Drawing.Size(98, 23);
            this.buttonDrawDragon.TabIndex = 7;
            this.buttonDrawDragon.Text = "L System Dragon";
            this.buttonDrawDragon.UseVisualStyleBackColor = true;
            this.buttonDrawDragon.Click += new System.EventHandler(this.buttonDrawDragon_Click);
            // 
            // labelEscapeNumber
            // 
            this.labelEscapeNumber.AutoSize = true;
            this.labelEscapeNumber.Location = new System.Drawing.Point(8, 123);
            this.labelEscapeNumber.Name = "labelEscapeNumber";
            this.labelEscapeNumber.Size = new System.Drawing.Size(88, 13);
            this.labelEscapeNumber.TabIndex = 6;
            this.labelEscapeNumber.Text = "Number To Draw";
            // 
            // buttonSpirangles
            // 
            this.buttonSpirangles.Location = new System.Drawing.Point(8, 93);
            this.buttonSpirangles.Name = "buttonSpirangles";
            this.buttonSpirangles.Size = new System.Drawing.Size(98, 23);
            this.buttonSpirangles.TabIndex = 5;
            this.buttonSpirangles.Text = "Draw Spirangles";
            this.buttonSpirangles.UseVisualStyleBackColor = true;
            this.buttonSpirangles.Click += new System.EventHandler(this.buttonSpirangles_Click);
            // 
            // buttonDrawTriangles
            // 
            this.buttonDrawTriangles.Location = new System.Drawing.Point(8, 64);
            this.buttonDrawTriangles.Name = "buttonDrawTriangles";
            this.buttonDrawTriangles.Size = new System.Drawing.Size(98, 23);
            this.buttonDrawTriangles.TabIndex = 4;
            this.buttonDrawTriangles.Text = "Draw Triangles";
            this.buttonDrawTriangles.UseVisualStyleBackColor = true;
            this.buttonDrawTriangles.Click += new System.EventHandler(this.buttonDrawTriangles_Click);
            // 
            // numericUpDownEscape
            // 
            this.numericUpDownEscape.Location = new System.Drawing.Point(8, 139);
            this.numericUpDownEscape.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEscape.Name = "numericUpDownEscape";
            this.numericUpDownEscape.Size = new System.Drawing.Size(98, 20);
            this.numericUpDownEscape.TabIndex = 3;
            this.numericUpDownEscape.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonDrawSquares
            // 
            this.buttonDrawSquares.Location = new System.Drawing.Point(8, 35);
            this.buttonDrawSquares.Name = "buttonDrawSquares";
            this.buttonDrawSquares.Size = new System.Drawing.Size(98, 23);
            this.buttonDrawSquares.TabIndex = 2;
            this.buttonDrawSquares.Text = "Draw Squares";
            this.buttonDrawSquares.UseVisualStyleBackColor = true;
            this.buttonDrawSquares.Click += new System.EventHandler(this.buttonDrawSquares_Click);
            // 
            // pictureBoxEscape
            // 
            this.pictureBoxEscape.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEscape.Location = new System.Drawing.Point(112, 6);
            this.pictureBoxEscape.Name = "pictureBoxEscape";
            this.pictureBoxEscape.Size = new System.Drawing.Size(674, 410);
            this.pictureBoxEscape.TabIndex = 1;
            this.pictureBoxEscape.TabStop = false;
            // 
            // buttonDrawLine
            // 
            this.buttonDrawLine.Location = new System.Drawing.Point(8, 6);
            this.buttonDrawLine.Name = "buttonDrawLine";
            this.buttonDrawLine.Size = new System.Drawing.Size(98, 23);
            this.buttonDrawLine.TabIndex = 0;
            this.buttonDrawLine.Text = "Draw line";
            this.buttonDrawLine.UseVisualStyleBackColor = true;
            this.buttonDrawLine.Click += new System.EventHandler(this.buttonDrawLine_Click);
            // 
            // tabPageDecisionTree
            // 
            this.tabPageDecisionTree.Controls.Add(this.buttonDecisionEscape);
            this.tabPageDecisionTree.Controls.Add(this.buttonDecision2);
            this.tabPageDecisionTree.Controls.Add(this.textBoxDecision);
            this.tabPageDecisionTree.Controls.Add(this.buttonDecision1);
            this.tabPageDecisionTree.Location = new System.Drawing.Point(4, 22);
            this.tabPageDecisionTree.Name = "tabPageDecisionTree";
            this.tabPageDecisionTree.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDecisionTree.Size = new System.Drawing.Size(792, 424);
            this.tabPageDecisionTree.TabIndex = 1;
            this.tabPageDecisionTree.Text = "Decision Tree";
            this.tabPageDecisionTree.UseVisualStyleBackColor = true;
            // 
            // buttonDecisionEscape
            // 
            this.buttonDecisionEscape.Location = new System.Drawing.Point(8, 64);
            this.buttonDecisionEscape.Name = "buttonDecisionEscape";
            this.buttonDecisionEscape.Size = new System.Drawing.Size(89, 23);
            this.buttonDecisionEscape.TabIndex = 3;
            this.buttonDecisionEscape.Text = "From Escape";
            this.buttonDecisionEscape.UseVisualStyleBackColor = true;
            this.buttonDecisionEscape.Click += new System.EventHandler(this.buttonDecisionEscape_Click);
            // 
            // buttonDecision2
            // 
            this.buttonDecision2.Location = new System.Drawing.Point(8, 35);
            this.buttonDecision2.Name = "buttonDecision2";
            this.buttonDecision2.Size = new System.Drawing.Size(89, 23);
            this.buttonDecision2.TabIndex = 2;
            this.buttonDecision2.Text = "Example 2";
            this.buttonDecision2.UseVisualStyleBackColor = true;
            this.buttonDecision2.Click += new System.EventHandler(this.buttonDecision2_Click);
            // 
            // textBoxDecision
            // 
            this.textBoxDecision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDecision.Location = new System.Drawing.Point(103, 3);
            this.textBoxDecision.Multiline = true;
            this.textBoxDecision.Name = "textBoxDecision";
            this.textBoxDecision.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDecision.Size = new System.Drawing.Size(681, 413);
            this.textBoxDecision.TabIndex = 1;
            // 
            // buttonDecision1
            // 
            this.buttonDecision1.Location = new System.Drawing.Point(8, 6);
            this.buttonDecision1.Name = "buttonDecision1";
            this.buttonDecision1.Size = new System.Drawing.Size(89, 23);
            this.buttonDecision1.TabIndex = 0;
            this.buttonDecision1.Text = "Example 1";
            this.buttonDecision1.UseVisualStyleBackColor = true;
            this.buttonDecision1.Click += new System.EventHandler(this.buttonDecision1_Click);
            // 
            // tabPageCannon
            // 
            this.tabPageCannon.Controls.Add(this.splitContainerGAResults);
            this.tabPageCannon.Controls.Add(this.buttonRunGA);
            this.tabPageCannon.Location = new System.Drawing.Point(4, 22);
            this.tabPageCannon.Name = "tabPageCannon";
            this.tabPageCannon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCannon.Size = new System.Drawing.Size(792, 424);
            this.tabPageCannon.TabIndex = 2;
            this.tabPageCannon.Text = "GA Cannon";
            this.tabPageCannon.UseVisualStyleBackColor = true;
            // 
            // splitContainerGAResults
            // 
            this.splitContainerGAResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerGAResults.Location = new System.Drawing.Point(8, 35);
            this.splitContainerGAResults.Name = "splitContainerGAResults";
            this.splitContainerGAResults.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerGAResults.Panel1
            // 
            this.splitContainerGAResults.Panel1.Controls.Add(this.labelGAInitial);
            this.splitContainerGAResults.Panel1.Controls.Add(this.chartGAInitial);
            // 
            // splitContainerGAResults.Panel2
            // 
            this.splitContainerGAResults.Panel2.Controls.Add(this.labelGAFinal);
            this.splitContainerGAResults.Panel2.Controls.Add(this.chartGAFinal);
            this.splitContainerGAResults.Size = new System.Drawing.Size(776, 381);
            this.splitContainerGAResults.SplitterDistance = 192;
            this.splitContainerGAResults.TabIndex = 1;
            // 
            // labelGAInitial
            // 
            this.labelGAInitial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGAInitial.Location = new System.Drawing.Point(3, 164);
            this.labelGAInitial.Name = "labelGAInitial";
            this.labelGAInitial.Size = new System.Drawing.Size(770, 23);
            this.labelGAInitial.TabIndex = 1;
            this.labelGAInitial.Text = "label1";
            // 
            // chartGAInitial
            // 
            this.chartGAInitial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartGAInitial.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGAInitial.Legends.Add(legend1);
            this.chartGAInitial.Location = new System.Drawing.Point(3, 3);
            this.chartGAInitial.Name = "chartGAInitial";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGAInitial.Series.Add(series1);
            this.chartGAInitial.Size = new System.Drawing.Size(770, 158);
            this.chartGAInitial.TabIndex = 0;
            this.chartGAInitial.Text = "chart1";
            // 
            // labelGAFinal
            // 
            this.labelGAFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGAFinal.Location = new System.Drawing.Point(3, 161);
            this.labelGAFinal.Name = "labelGAFinal";
            this.labelGAFinal.Size = new System.Drawing.Size(770, 23);
            this.labelGAFinal.TabIndex = 3;
            this.labelGAFinal.Text = "label1";
            // 
            // chartGAFinal
            // 
            this.chartGAFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartGAFinal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGAFinal.Legends.Add(legend2);
            this.chartGAFinal.Location = new System.Drawing.Point(3, 0);
            this.chartGAFinal.Name = "chartGAFinal";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGAFinal.Series.Add(series2);
            this.chartGAFinal.Size = new System.Drawing.Size(770, 158);
            this.chartGAFinal.TabIndex = 2;
            this.chartGAFinal.Text = "chart1";
            // 
            // buttonRunGA
            // 
            this.buttonRunGA.Location = new System.Drawing.Point(8, 6);
            this.buttonRunGA.Name = "buttonRunGA";
            this.buttonRunGA.Size = new System.Drawing.Size(127, 23);
            this.buttonRunGA.TabIndex = 0;
            this.buttonRunGA.Text = "Run Genetic Algorithm";
            this.buttonRunGA.UseVisualStyleBackColor = true;
            this.buttonRunGA.Click += new System.EventHandler(this.buttonRunGA_Click);
            // 
            // tabPageSwarm
            // 
            this.tabPageSwarm.Controls.Add(this.buttonStartPSO);
            this.tabPageSwarm.Controls.Add(this.buttonAddParticle);
            this.tabPageSwarm.Controls.Add(this.buttonStopSwarm);
            this.tabPageSwarm.Controls.Add(this.pictureBoxSwarm);
            this.tabPageSwarm.Controls.Add(this.buttonStartKnnSwarm);
            this.tabPageSwarm.Location = new System.Drawing.Point(4, 22);
            this.tabPageSwarm.Name = "tabPageSwarm";
            this.tabPageSwarm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSwarm.Size = new System.Drawing.Size(792, 424);
            this.tabPageSwarm.TabIndex = 3;
            this.tabPageSwarm.Text = "Swarm";
            this.tabPageSwarm.UseVisualStyleBackColor = true;
            // 
            // buttonStartPSO
            // 
            this.buttonStartPSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartPSO.Location = new System.Drawing.Point(709, 11);
            this.buttonStartPSO.Name = "buttonStartPSO";
            this.buttonStartPSO.Size = new System.Drawing.Size(75, 23);
            this.buttonStartPSO.TabIndex = 4;
            this.buttonStartPSO.Text = "Start PSO";
            this.buttonStartPSO.UseVisualStyleBackColor = true;
            this.buttonStartPSO.Click += new System.EventHandler(this.buttonStartPSO_Click);
            // 
            // buttonAddParticle
            // 
            this.buttonAddParticle.Location = new System.Drawing.Point(89, 11);
            this.buttonAddParticle.Name = "buttonAddParticle";
            this.buttonAddParticle.Size = new System.Drawing.Size(75, 23);
            this.buttonAddParticle.TabIndex = 3;
            this.buttonAddParticle.Text = "Add particle";
            this.buttonAddParticle.UseVisualStyleBackColor = true;
            this.buttonAddParticle.Click += new System.EventHandler(this.buttonAddParticle_Click);
            // 
            // buttonStopSwarm
            // 
            this.buttonStopSwarm.Location = new System.Drawing.Point(170, 11);
            this.buttonStopSwarm.Name = "buttonStopSwarm";
            this.buttonStopSwarm.Size = new System.Drawing.Size(75, 23);
            this.buttonStopSwarm.TabIndex = 2;
            this.buttonStopSwarm.Text = "Stop";
            this.buttonStopSwarm.UseVisualStyleBackColor = true;
            this.buttonStopSwarm.Click += new System.EventHandler(this.buttonStopSwarm_Click);
            // 
            // pictureBoxSwarm
            // 
            this.pictureBoxSwarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSwarm.Location = new System.Drawing.Point(8, 40);
            this.pictureBoxSwarm.Name = "pictureBoxSwarm";
            this.pictureBoxSwarm.Size = new System.Drawing.Size(778, 376);
            this.pictureBoxSwarm.TabIndex = 1;
            this.pictureBoxSwarm.TabStop = false;
            // 
            // buttonStartKnnSwarm
            // 
            this.buttonStartKnnSwarm.Location = new System.Drawing.Point(8, 11);
            this.buttonStartKnnSwarm.Name = "buttonStartKnnSwarm";
            this.buttonStartKnnSwarm.Size = new System.Drawing.Size(75, 23);
            this.buttonStartKnnSwarm.TabIndex = 0;
            this.buttonStartKnnSwarm.Text = "Start KNN";
            this.buttonStartKnnSwarm.UseVisualStyleBackColor = true;
            this.buttonStartKnnSwarm.Click += new System.EventHandler(this.buttonStartKnnSwarm_Click);
            // 
            // tabPageAnts
            // 
            this.tabPageAnts.Controls.Add(this.checkBoxAcoStartInMiddle);
            this.tabPageAnts.Controls.Add(this.buttonStopACO);
            this.tabPageAnts.Controls.Add(this.pictureBoxACO);
            this.tabPageAnts.Controls.Add(this.buttonStartACO);
            this.tabPageAnts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnts.Name = "tabPageAnts";
            this.tabPageAnts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnts.Size = new System.Drawing.Size(792, 424);
            this.tabPageAnts.TabIndex = 4;
            this.tabPageAnts.Text = "Ants";
            this.tabPageAnts.UseVisualStyleBackColor = true;
            // 
            // checkBoxAcoStartInMiddle
            // 
            this.checkBoxAcoStartInMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAcoStartInMiddle.AutoSize = true;
            this.checkBoxAcoStartInMiddle.Location = new System.Drawing.Point(690, 10);
            this.checkBoxAcoStartInMiddle.Name = "checkBoxAcoStartInMiddle";
            this.checkBoxAcoStartInMiddle.Size = new System.Drawing.Size(94, 17);
            this.checkBoxAcoStartInMiddle.TabIndex = 5;
            this.checkBoxAcoStartInMiddle.Text = "Start In Middle";
            this.checkBoxAcoStartInMiddle.UseVisualStyleBackColor = true;
            // 
            // buttonStopACO
            // 
            this.buttonStopACO.Location = new System.Drawing.Point(88, 10);
            this.buttonStopACO.Name = "buttonStopACO";
            this.buttonStopACO.Size = new System.Drawing.Size(75, 23);
            this.buttonStopACO.TabIndex = 4;
            this.buttonStopACO.Text = "Stop";
            this.buttonStopACO.UseVisualStyleBackColor = true;
            this.buttonStopACO.Click += new System.EventHandler(this.buttonStopACO_Click);
            // 
            // pictureBoxACO
            // 
            this.pictureBoxACO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxACO.Location = new System.Drawing.Point(7, 39);
            this.pictureBoxACO.Name = "pictureBoxACO";
            this.pictureBoxACO.Size = new System.Drawing.Size(778, 376);
            this.pictureBoxACO.TabIndex = 3;
            this.pictureBoxACO.TabStop = false;
            // 
            // buttonStartACO
            // 
            this.buttonStartACO.Location = new System.Drawing.Point(7, 10);
            this.buttonStartACO.Name = "buttonStartACO";
            this.buttonStartACO.Size = new System.Drawing.Size(75, 23);
            this.buttonStartACO.TabIndex = 2;
            this.buttonStartACO.Text = "Start ACO";
            this.buttonStartACO.UseVisualStyleBackColor = true;
            this.buttonStartACO.Click += new System.EventHandler(this.buttonStartACO_Click);
            // 
            // tabPageCellularAutomata
            // 
            this.tabPageCellularAutomata.Controls.Add(this.buttonGameOfLife);
            this.tabPageCellularAutomata.Controls.Add(this.buttonStopCellularAutomata);
            this.tabPageCellularAutomata.Controls.Add(this.pictureBoxCellularAutomata);
            this.tabPageCellularAutomata.Controls.Add(this.buttonStartLangtonsAnt);
            this.tabPageCellularAutomata.Location = new System.Drawing.Point(4, 22);
            this.tabPageCellularAutomata.Name = "tabPageCellularAutomata";
            this.tabPageCellularAutomata.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCellularAutomata.Size = new System.Drawing.Size(792, 424);
            this.tabPageCellularAutomata.TabIndex = 5;
            this.tabPageCellularAutomata.Text = "Cellular Automata";
            this.tabPageCellularAutomata.UseVisualStyleBackColor = true;
            // 
            // buttonGameOfLife
            // 
            this.buttonGameOfLife.Location = new System.Drawing.Point(107, 10);
            this.buttonGameOfLife.Name = "buttonGameOfLife";
            this.buttonGameOfLife.Size = new System.Drawing.Size(94, 23);
            this.buttonGameOfLife.TabIndex = 7;
            this.buttonGameOfLife.Text = "Game Of Life";
            this.buttonGameOfLife.UseVisualStyleBackColor = true;
            this.buttonGameOfLife.Click += new System.EventHandler(this.buttonGameOfLife_Click);
            // 
            // buttonStopCellularAutomata
            // 
            this.buttonStopCellularAutomata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopCellularAutomata.Location = new System.Drawing.Point(709, 10);
            this.buttonStopCellularAutomata.Name = "buttonStopCellularAutomata";
            this.buttonStopCellularAutomata.Size = new System.Drawing.Size(75, 23);
            this.buttonStopCellularAutomata.TabIndex = 6;
            this.buttonStopCellularAutomata.Text = "Stop";
            this.buttonStopCellularAutomata.UseVisualStyleBackColor = true;
            this.buttonStopCellularAutomata.Click += new System.EventHandler(this.buttonStopCellularAutomata_Click);
            // 
            // pictureBoxCellularAutomata
            // 
            this.pictureBoxCellularAutomata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCellularAutomata.Location = new System.Drawing.Point(7, 39);
            this.pictureBoxCellularAutomata.Name = "pictureBoxCellularAutomata";
            this.pictureBoxCellularAutomata.Size = new System.Drawing.Size(778, 376);
            this.pictureBoxCellularAutomata.TabIndex = 5;
            this.pictureBoxCellularAutomata.TabStop = false;
            // 
            // buttonStartLangtonsAnt
            // 
            this.buttonStartLangtonsAnt.Location = new System.Drawing.Point(7, 10);
            this.buttonStartLangtonsAnt.Name = "buttonStartLangtonsAnt";
            this.buttonStartLangtonsAnt.Size = new System.Drawing.Size(94, 23);
            this.buttonStartLangtonsAnt.TabIndex = 4;
            this.buttonStartLangtonsAnt.Text = "Langtons Ant";
            this.buttonStartLangtonsAnt.UseVisualStyleBackColor = true;
            this.buttonStartLangtonsAnt.Click += new System.EventHandler(this.buttonStartLangtonsAnt_Click);
            // 
            // tabPageGACA
            // 
            this.tabPageGACA.Controls.Add(this.buttonDeamRule);
            this.tabPageGACA.Controls.Add(this.numericUpDownECARuleNumber);
            this.tabPageGACA.Controls.Add(this.buttonECARule);
            this.tabPageGACA.Controls.Add(this.pictureBoxGACA);
            this.tabPageGACA.Controls.Add(this.buttonGACAOneMax);
            this.tabPageGACA.Location = new System.Drawing.Point(4, 22);
            this.tabPageGACA.Name = "tabPageGACA";
            this.tabPageGACA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGACA.Size = new System.Drawing.Size(792, 424);
            this.tabPageGACA.TabIndex = 6;
            this.tabPageGACA.Text = "GACA";
            this.tabPageGACA.UseVisualStyleBackColor = true;
            // 
            // pictureBoxGACA
            // 
            this.pictureBoxGACA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGACA.Location = new System.Drawing.Point(7, 39);
            this.pictureBoxGACA.Name = "pictureBoxGACA";
            this.pictureBoxGACA.Size = new System.Drawing.Size(778, 376);
            this.pictureBoxGACA.TabIndex = 7;
            this.pictureBoxGACA.TabStop = false;
            // 
            // buttonGACAOneMax
            // 
            this.buttonGACAOneMax.Location = new System.Drawing.Point(7, 10);
            this.buttonGACAOneMax.Name = "buttonGACAOneMax";
            this.buttonGACAOneMax.Size = new System.Drawing.Size(67, 23);
            this.buttonGACAOneMax.TabIndex = 6;
            this.buttonGACAOneMax.Text = "One Max";
            this.buttonGACAOneMax.UseVisualStyleBackColor = true;
            this.buttonGACAOneMax.Click += new System.EventHandler(this.buttonGACAOneMax_Click);
            // 
            // buttonECARule
            // 
            this.buttonECARule.Location = new System.Drawing.Point(80, 10);
            this.buttonECARule.Name = "buttonECARule";
            this.buttonECARule.Size = new System.Drawing.Size(67, 23);
            this.buttonECARule.TabIndex = 8;
            this.buttonECARule.Text = "ECARule";
            this.buttonECARule.UseVisualStyleBackColor = true;
            this.buttonECARule.Click += new System.EventHandler(this.buttonECARule_Click);
            // 
            // numericUpDownECARuleNumber
            // 
            this.numericUpDownECARuleNumber.Location = new System.Drawing.Point(153, 10);
            this.numericUpDownECARuleNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownECARuleNumber.Name = "numericUpDownECARuleNumber";
            this.numericUpDownECARuleNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownECARuleNumber.TabIndex = 9;
            // 
            // buttonDeamRule
            // 
            this.buttonDeamRule.Location = new System.Drawing.Point(279, 10);
            this.buttonDeamRule.Name = "buttonDeamRule";
            this.buttonDeamRule.Size = new System.Drawing.Size(67, 23);
            this.buttonDeamRule.TabIndex = 10;
            this.buttonDeamRule.Text = "Dream";
            this.buttonDeamRule.UseVisualStyleBackColor = true;
            this.buttonDeamRule.Click += new System.EventHandler(this.buttonDeamRule_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEscape.ResumeLayout(false);
            this.tabPageEscape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEscape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscape)).EndInit();
            this.tabPageDecisionTree.ResumeLayout(false);
            this.tabPageDecisionTree.PerformLayout();
            this.tabPageCannon.ResumeLayout(false);
            this.splitContainerGAResults.Panel1.ResumeLayout(false);
            this.splitContainerGAResults.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGAResults)).EndInit();
            this.splitContainerGAResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGAInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGAFinal)).EndInit();
            this.tabPageSwarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwarm)).EndInit();
            this.tabPageAnts.ResumeLayout(false);
            this.tabPageAnts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxACO)).EndInit();
            this.tabPageCellularAutomata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCellularAutomata)).EndInit();
            this.tabPageGACA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGACA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownECARuleNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEscape;
        private System.Windows.Forms.TabPage tabPageDecisionTree;
        private System.Windows.Forms.PictureBox pictureBoxEscape;
        private System.Windows.Forms.Button buttonDrawLine;
        private System.Windows.Forms.Button buttonDrawSquares;
        private System.Windows.Forms.NumericUpDown numericUpDownEscape;
        private System.Windows.Forms.Button buttonDrawTriangles;
        private System.Windows.Forms.Label labelEscapeNumber;
        private System.Windows.Forms.Button buttonSpirangles;
        private System.Windows.Forms.Button buttonDrawDragon;
        private System.Windows.Forms.TextBox textBoxDecision;
        private System.Windows.Forms.Button buttonDecision1;
        private System.Windows.Forms.Button buttonDecision2;
        private System.Windows.Forms.Button buttonDecisionEscape;
        private System.Windows.Forms.TabPage tabPageCannon;
        private System.Windows.Forms.SplitContainer splitContainerGAResults;
        private System.Windows.Forms.Label labelGAInitial;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGAInitial;
        private System.Windows.Forms.Label labelGAFinal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGAFinal;
        private System.Windows.Forms.Button buttonRunGA;
        private System.Windows.Forms.TabPage tabPageSwarm;
        private System.Windows.Forms.Button buttonStopSwarm;
        private System.Windows.Forms.PictureBox pictureBoxSwarm;
        private System.Windows.Forms.Button buttonStartKnnSwarm;
        private System.Windows.Forms.Button buttonAddParticle;
        private System.Windows.Forms.Button buttonStartPSO;
        private System.Windows.Forms.TabPage tabPageAnts;
        private System.Windows.Forms.Button buttonStopACO;
        private System.Windows.Forms.PictureBox pictureBoxACO;
        private System.Windows.Forms.Button buttonStartACO;
        private System.Windows.Forms.CheckBox checkBoxAcoStartInMiddle;
        private System.Windows.Forms.TabPage tabPageCellularAutomata;
        private System.Windows.Forms.PictureBox pictureBoxCellularAutomata;
        private System.Windows.Forms.Button buttonStartLangtonsAnt;
        private System.Windows.Forms.Button buttonStopCellularAutomata;
        private System.Windows.Forms.Button buttonGameOfLife;
        private System.Windows.Forms.TabPage tabPageGACA;
        private System.Windows.Forms.PictureBox pictureBoxGACA;
        private System.Windows.Forms.Button buttonGACAOneMax;
        private System.Windows.Forms.NumericUpDown numericUpDownECARuleNumber;
        private System.Windows.Forms.Button buttonECARule;
        private System.Windows.Forms.Button buttonDeamRule;
    }
}

