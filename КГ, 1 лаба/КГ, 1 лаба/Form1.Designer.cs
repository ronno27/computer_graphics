namespace КГ__1_лаба
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
            arcPictureBox = new PictureBox();
            panel1 = new Panel();
            panel6 = new Panel();
            redColorButton = new Button();
            greenColorButton = new Button();
            blueColorButton = new Button();
            blackColorButton = new Button();
            selectColorButton = new Button();
            label9 = new Label();
            panel5 = new Panel();
            thicknessTrackBar = new TrackBar();
            label8 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            coordinatesCenterY = new TextBox();
            coordinatesCenterX = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            arcAngleEnd = new TextBox();
            arcAngleStart = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            radiusTrackBar = new TrackBar();
            label1 = new Label();
            colorDialogArc = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)arcPictureBox).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thicknessTrackBar).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radiusTrackBar).BeginInit();
            SuspendLayout();
            // 
            // arcPictureBox
            // 
            arcPictureBox.BorderStyle = BorderStyle.FixedSingle;
            arcPictureBox.Location = new Point(12, 12);
            arcPictureBox.Name = "arcPictureBox";
            arcPictureBox.Size = new Size(530, 439);
            arcPictureBox.TabIndex = 0;
            arcPictureBox.TabStop = false;
            arcPictureBox.Paint += arcPictureBox_Paint;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(564, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 439);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(redColorButton);
            panel6.Controls.Add(greenColorButton);
            panel6.Controls.Add(blueColorButton);
            panel6.Controls.Add(blackColorButton);
            panel6.Controls.Add(selectColorButton);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(14, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(363, 150);
            panel6.TabIndex = 6;
            // 
            // redColorButton
            // 
            redColorButton.BackColor = Color.Red;
            redColorButton.Location = new Point(59, 87);
            redColorButton.Name = "redColorButton";
            redColorButton.Size = new Size(50, 50);
            redColorButton.TabIndex = 5;
            redColorButton.UseVisualStyleBackColor = false;
            redColorButton.Click += changeColorButton_Click;
            // 
            // greenColorButton
            // 
            greenColorButton.BackColor = Color.FromArgb(0, 192, 0);
            greenColorButton.Location = new Point(59, 31);
            greenColorButton.Name = "greenColorButton";
            greenColorButton.Size = new Size(50, 50);
            greenColorButton.TabIndex = 4;
            greenColorButton.UseVisualStyleBackColor = false;
            greenColorButton.Click += changeColorButton_Click;
            // 
            // blueColorButton
            // 
            blueColorButton.BackColor = Color.FromArgb(0, 0, 192);
            blueColorButton.Location = new Point(4, 87);
            blueColorButton.Name = "blueColorButton";
            blueColorButton.Size = new Size(50, 50);
            blueColorButton.TabIndex = 3;
            blueColorButton.UseVisualStyleBackColor = false;
            blueColorButton.Click += changeColorButton_Click;
            // 
            // blackColorButton
            // 
            blackColorButton.BackColor = Color.Black;
            blackColorButton.Location = new Point(3, 31);
            blackColorButton.Name = "blackColorButton";
            blackColorButton.Size = new Size(50, 50);
            blackColorButton.TabIndex = 2;
            blackColorButton.UseVisualStyleBackColor = false;
            blackColorButton.Click += changeColorButton_Click;
            // 
            // selectColorButton
            // 
            selectColorButton.Location = new Point(205, 49);
            selectColorButton.Name = "selectColorButton";
            selectColorButton.Size = new Size(140, 71);
            selectColorButton.TabIndex = 1;
            selectColorButton.Text = "Выбрать цвет";
            selectColorButton.UseVisualStyleBackColor = true;
            selectColorButton.Click += selectColorButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(166, 12);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 0;
            label9.Text = "Цвет";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(thicknessTrackBar);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(206, 321);
            panel5.Name = "panel5";
            panel5.Size = new Size(171, 100);
            panel5.TabIndex = 5;
            // 
            // thicknessTrackBar
            // 
            thicknessTrackBar.Location = new Point(3, 41);
            thicknessTrackBar.Maximum = 5;
            thicknessTrackBar.Minimum = 1;
            thicknessTrackBar.Name = "thicknessTrackBar";
            thicknessTrackBar.Size = new Size(162, 45);
            thicknessTrackBar.SmallChange = 5;
            thicknessTrackBar.TabIndex = 0;
            thicknessTrackBar.Value = 3;
            thicknessTrackBar.Scroll += thicknessTrackBar_Scroll;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 11);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 1;
            label8.Text = "Толщина дуги";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(coordinatesCenterY);
            panel4.Controls.Add(coordinatesCenterX);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(206, 159);
            panel4.Name = "panel4";
            panel4.Size = new Size(171, 140);
            panel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 90);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 4;
            label4.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 49);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 3;
            label3.Text = "X";
            // 
            // coordinatesCenterY
            // 
            coordinatesCenterY.Location = new Point(33, 87);
            coordinatesCenterY.Name = "coordinatesCenterY";
            coordinatesCenterY.Size = new Size(120, 23);
            coordinatesCenterY.TabIndex = 2;
            coordinatesCenterY.Text = "100";
            coordinatesCenterY.TextChanged += coordinatesCenterY_TextChanged;
            // 
            // coordinatesCenterX
            // 
            coordinatesCenterX.Location = new Point(33, 46);
            coordinatesCenterX.Name = "coordinatesCenterX";
            coordinatesCenterX.Size = new Size(120, 23);
            coordinatesCenterX.TabIndex = 1;
            coordinatesCenterX.Text = "100";
            coordinatesCenterX.TextChanged += coordinatesCenterX_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 16);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 0;
            label2.Text = "Координаты центра";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(arcAngleEnd);
            panel3.Controls.Add(arcAngleStart);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(14, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(171, 140);
            panel3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 88);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Конец";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 47);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 8;
            label6.Text = "Начало";
            // 
            // arcAngleEnd
            // 
            arcAngleEnd.Location = new Point(68, 85);
            arcAngleEnd.Name = "arcAngleEnd";
            arcAngleEnd.Size = new Size(85, 23);
            arcAngleEnd.TabIndex = 7;
            arcAngleEnd.Text = "90";
            arcAngleEnd.TextChanged += arcAngleEnd_TextChanged;
            // 
            // arcAngleStart
            // 
            arcAngleStart.Location = new Point(68, 44);
            arcAngleStart.Name = "arcAngleStart";
            arcAngleStart.Size = new Size(85, 23);
            arcAngleStart.TabIndex = 6;
            arcAngleStart.Text = "-90";
            arcAngleStart.TextChanged += arcAngleStart_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 12);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 5;
            label7.Text = "Углы дуги";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(radiusTrackBar);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(14, 321);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 100);
            panel2.TabIndex = 2;
            // 
            // radiusTrackBar
            // 
            radiusTrackBar.Location = new Point(3, 41);
            radiusTrackBar.Maximum = 100;
            radiusTrackBar.Minimum = 10;
            radiusTrackBar.Name = "radiusTrackBar";
            radiusTrackBar.Size = new Size(162, 45);
            radiusTrackBar.SmallChange = 5;
            radiusTrackBar.TabIndex = 0;
            radiusTrackBar.Value = 50;
            radiusTrackBar.Scroll += radiusTrackBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 11);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "Радиус окружности";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 463);
            Controls.Add(panel1);
            Controls.Add(arcPictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)arcPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)thicknessTrackBar).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radiusTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox arcPictureBox;
        private Panel panel1;
        private Panel panel2;
        private TrackBar radiusTrackBar;
        private Label label1;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private TextBox coordinatesCenterY;
        private TextBox coordinatesCenterX;
        private Label label2;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private TextBox arcAngleEnd;
        private TextBox arcAngleStart;
        private Label label7;
        private Panel panel5;
        private TrackBar thicknessTrackBar;
        private Label label8;
        private ColorDialog colorDialogArc;
        private Panel panel6;
        private Button selectColorButton;
        private Label label9;
        private Button greenColorButton;
        private Button blueColorButton;
        private Button blackColorButton;
        private Button redColorButton;
    }
}
