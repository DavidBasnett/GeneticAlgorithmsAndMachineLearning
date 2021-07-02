
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEscape = new System.Windows.Forms.TabPage();
            this.buttonDrawSquares = new System.Windows.Forms.Button();
            this.pictureBoxEscape = new System.Windows.Forms.PictureBox();
            this.buttonDrawLine = new System.Windows.Forms.Button();
            this.tabPageDecisionTree = new System.Windows.Forms.TabPage();
            this.numericUpDownEscape = new System.Windows.Forms.NumericUpDown();
            this.buttonDrawTriangles = new System.Windows.Forms.Button();
            this.buttonSpirangles = new System.Windows.Forms.Button();
            this.labelEscapeNumber = new System.Windows.Forms.Label();
            this.buttonDrawDragon = new System.Windows.Forms.Button();
            this.buttonDecision1 = new System.Windows.Forms.Button();
            this.textBoxDecision = new System.Windows.Forms.TextBox();
            this.buttonDecision2 = new System.Windows.Forms.Button();
            this.buttonDecisionEscape = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageEscape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscape)).BeginInit();
            this.tabPageDecisionTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEscape)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEscape);
            this.tabControl1.Controls.Add(this.tabPageDecisionTree);
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
            // labelEscapeNumber
            // 
            this.labelEscapeNumber.AutoSize = true;
            this.labelEscapeNumber.Location = new System.Drawing.Point(8, 123);
            this.labelEscapeNumber.Name = "labelEscapeNumber";
            this.labelEscapeNumber.Size = new System.Drawing.Size(88, 13);
            this.labelEscapeNumber.TabIndex = 6;
            this.labelEscapeNumber.Text = "Number To Draw";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscape)).EndInit();
            this.tabPageDecisionTree.ResumeLayout(false);
            this.tabPageDecisionTree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEscape)).EndInit();
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
    }
}

