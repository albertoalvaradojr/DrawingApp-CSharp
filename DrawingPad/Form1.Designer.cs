namespace DrawingPad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Canvas = new Panel();
            penSize = new TrackBar();
            panel1 = new Panel();
            blackBox = new PictureBox();
            greyBox = new PictureBox();
            pinkBox = new PictureBox();
            lightBlueBox = new PictureBox();
            blueBox = new PictureBox();
            yellowBox = new PictureBox();
            greenBox = new PictureBox();
            redBox = new PictureBox();
            Canvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)penSize).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blackBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greyBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pinkBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lightBlueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellowBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redBox).BeginInit();
            SuspendLayout();
            // 
            // Canvas
            // 
            Canvas.AutoSize = true;
            Canvas.BackColor = SystemColors.ControlDarkDark;
            Canvas.Controls.Add(penSize);
            Canvas.Controls.Add(panel1);
            Canvas.Dock = DockStyle.Fill;
            Canvas.Location = new Point(0, 0);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(702, 560);
            Canvas.TabIndex = 0;
            Canvas.MouseDown += Canvas_MouseDown;
            Canvas.MouseMove += Canvas_MouseMove;
            Canvas.MouseUp += Canvas_MouseUp;
            // 
            // penSize
            // 
            penSize.BackColor = SystemColors.ControlDarkDark;
            penSize.Location = new Point(146, 12);
            penSize.Minimum = 1;
            penSize.Name = "penSize";
            penSize.Size = new Size(104, 45);
            penSize.TabIndex = 1;
            penSize.Value = 1;
            penSize.Scroll += penSize_Scroll;
            penSize.ValueChanged += penSize_ValueChanged;
            penSize.MouseDown += penSize_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(blackBox);
            panel1.Controls.Add(greyBox);
            panel1.Controls.Add(pinkBox);
            panel1.Controls.Add(lightBlueBox);
            panel1.Controls.Add(blueBox);
            panel1.Controls.Add(yellowBox);
            panel1.Controls.Add(greenBox);
            panel1.Controls.Add(redBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 66);
            panel1.TabIndex = 0;
            // 
            // blackBox
            // 
            blackBox.BackColor = SystemColors.ActiveCaptionText;
            blackBox.Location = new Point(99, 35);
            blackBox.Name = "blackBox";
            blackBox.Size = new Size(26, 26);
            blackBox.TabIndex = 8;
            blackBox.TabStop = false;
            blackBox.Click += blackBox_Click;
            // 
            // greyBox
            // 
            greyBox.BackColor = Color.LightGray;
            greyBox.Location = new Point(67, 35);
            greyBox.Name = "greyBox";
            greyBox.Size = new Size(26, 26);
            greyBox.TabIndex = 7;
            greyBox.TabStop = false;
            greyBox.Click += greyBox_Click;
            // 
            // pinkBox
            // 
            pinkBox.BackColor = Color.Magenta;
            pinkBox.Location = new Point(35, 35);
            pinkBox.Name = "pinkBox";
            pinkBox.Size = new Size(26, 26);
            pinkBox.TabIndex = 6;
            pinkBox.TabStop = false;
            pinkBox.Click += pinkBox_Click;
            // 
            // lightBlueBox
            // 
            lightBlueBox.BackColor = Color.SkyBlue;
            lightBlueBox.Location = new Point(3, 35);
            lightBlueBox.Name = "lightBlueBox";
            lightBlueBox.Size = new Size(26, 26);
            lightBlueBox.TabIndex = 5;
            lightBlueBox.TabStop = false;
            lightBlueBox.Click += lightBlueBox_Click;
            // 
            // blueBox
            // 
            blueBox.BackColor = Color.Blue;
            blueBox.Location = new Point(99, 3);
            blueBox.Name = "blueBox";
            blueBox.Size = new Size(26, 26);
            blueBox.TabIndex = 4;
            blueBox.TabStop = false;
            blueBox.Click += blueBox_Click;
            // 
            // yellowBox
            // 
            yellowBox.BackColor = Color.Yellow;
            yellowBox.Location = new Point(67, 3);
            yellowBox.Name = "yellowBox";
            yellowBox.Size = new Size(26, 26);
            yellowBox.TabIndex = 3;
            yellowBox.TabStop = false;
            yellowBox.Click += yellowBox_Click;
            // 
            // greenBox
            // 
            greenBox.BackColor = Color.LimeGreen;
            greenBox.Location = new Point(35, 3);
            greenBox.Name = "greenBox";
            greenBox.Size = new Size(26, 26);
            greenBox.TabIndex = 2;
            greenBox.TabStop = false;
            greenBox.Click += greenBox_Click;
            // 
            // redBox
            // 
            redBox.BackColor = Color.Red;
            redBox.Location = new Point(3, 3);
            redBox.Name = "redBox";
            redBox.Size = new Size(26, 26);
            redBox.TabIndex = 1;
            redBox.TabStop = false;
            redBox.Click += redBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 560);
            Controls.Add(Canvas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Canvas.ResumeLayout(false);
            Canvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)penSize).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)blackBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)greyBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pinkBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lightBlueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellowBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)redBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Canvas;
        private Panel panel1;
        private PictureBox blueBox;
        private PictureBox yellowBox;
        private PictureBox greenBox;
        private PictureBox redBox;
        private PictureBox blackBox;
        private PictureBox greyBox;
        private PictureBox pinkBox;
        private PictureBox lightBlueBox;
        private TrackBar penSize;
    }
}