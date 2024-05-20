namespace КГ__1_лаба
{
    public partial class Form1 : Form
    {
        private Arc arc;
        public Form1()
        {
            InitializeComponent();
            int x = int.Parse(coordinatesCenterX.Text);
            int y = int.Parse(coordinatesCenterY.Text);
            double angleStart = double.Parse(arcAngleStart.Text);
            double angleEnd = double.Parse(arcAngleEnd.Text);
            int thickness = thicknessTrackBar.Value;
            arc = new Arc(x, y, radiusTrackBar.Value, angleStart, angleEnd, Color.Blue, thickness);
        }


        private void arcPictureBox_Paint(object sender, PaintEventArgs e)
        {
            arc.Draw(e.Graphics);
        }

        private void radiusTrackBar_Scroll(object sender, EventArgs e)
        {
            arc.Radius = radiusTrackBar.Value;
            PaintArc();
        }

        private void coordinatesCenterX_TextChanged(object sender, EventArgs e)
        {
            arc.X0 = int.Parse(coordinatesCenterX.Text);
            PaintArc();
        }

        private void coordinatesCenterY_TextChanged(object sender, EventArgs e)
        {
            arc.Y0 = int.Parse(coordinatesCenterY.Text);
            PaintArc();
        }

        private void arcAngleStart_TextChanged(object sender, EventArgs e)
        {
            arc.StartAngle = double.Parse(arcAngleStart.Text);
            PaintArc();
        }

        private void arcAngleEnd_TextChanged(object sender, EventArgs e)
        {
            arc.EndAngle = double.Parse(arcAngleEnd.Text);
            PaintArc();
        }

        private void thicknessTrackBar_Scroll(object sender, EventArgs e)
        {
            arc.Thickness = thicknessTrackBar.Value;
            PaintArc();
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialogArc.ShowDialog() == DialogResult.Cancel)
                return;
            arc.Color = colorDialogArc.Color;
            PaintArc();
        }
        private void changeColorButton_Click(object sender, EventArgs e)
        {
            arc.Color = ((Button)sender).BackColor;
            PaintArc();
        }

        private void PaintArc()
        {
            Graphics g = arcPictureBox.CreateGraphics();
            g.Clear(Color.White);
            arc.Draw(g);
        }
    }
}
