
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDownEscape = new System.Windows.Forms.NumericUpDown();
            this.buttonDrawTriangles = new System.Windows.Forms.Button();
            this.buttonSpirangles = new System.Windows.Forms.Button();
            this.labelEscapeNumber = new System.Windows.Forms.Label();
            this.buttonDrawDragon = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageEscape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEscape)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEscape);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEscape)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEscape;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxEscape;
        private System.Windows.Forms.Button buttonDrawLine;
        private System.Windows.Forms.Button buttonDrawSquares;
        private System.Windows.Forms.NumericUpDown numericUpDownEscape;
        private System.Windows.Forms.Button buttonDrawTriangles;
        private System.Windows.Forms.Label labelEscapeNumber;
        private System.Windows.Forms.Button buttonSpirangles;
        private System.Windows.Forms.Button buttonDrawDragon;
    }
}

