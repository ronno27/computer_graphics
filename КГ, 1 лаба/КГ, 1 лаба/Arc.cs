using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КГ__1_лаба
{
    public class Arc
    {
        public int X0 { get; set; }
        public int Y0 { get; set; }
        public int Radius { get; set; }
        public double StartAngle { get; set; }
        public double EndAngle { get; set; }
        public Color Color { get; set; }
        public int Thickness { get; set; }
        public Arc(int x0, int y0, int radius, double startAngle, double endAngle, Color color, int thickness)
        {
            X0 = x0;
            Y0 = y0;
            Radius = radius;
            StartAngle = startAngle;
            EndAngle = endAngle;
            Color = color;
            Thickness = thickness;
        }

        public void Draw(Graphics g)
        {
            DrawCircleArc(g, X0, Y0, Radius, StartAngle, EndAngle, Color, Thickness);
        }


        private void DrawCircleArc(Graphics g, int x0, int y0, int radius, double startAngle, double endAngle, Color color, int thickness)
        {
            int x = radius;
            int y = 0;
            int radiusError = 1 - x;

            while (x >= y)
            {
                PlotArcPoints(g, x0, y0, x, y, startAngle, endAngle, color, thickness);

                y++;
                if (radiusError < 0)
                {
                    radiusError += 2 * y + 1;
                }
                else
                {
                    x--;
                    radiusError += 2 * (y - x + 1);
                }
            }
        }

        private void PlotArcPoints(Graphics g, int x0, int y0, int x, int y, double startAngle, double endAngle, Color color, int thickness)
        {
            CheckAndPlot(g, x0, y0, x0 + x, y0 + y, startAngle, endAngle, color, thickness);
            CheckAndPlot(g, x0, y0, x0 + y, y0 + x, startAngle, endAngle, color, thickness);
            CheckAndPlot(g, x0, y0, x0 - y, y0 + x, startAngle, endAngle, color, thickness);
            CheckAndPlot(g, x0, y0, x0 - x, y0 + y, startAngle, endAngle, color, thickness);
            CheckAndPlot(g, x0, y0, x0 - x, y0 - y, startAngle, endAngle, color, thickness);
            CheckAndPlot(g, x0, y0, x0 - y, y0 - x, startAngle, endAngle, color, thickness);
            CheckAndPlot(g, x0, y0, x0 + y, y0 - x, startAngle, endAngle, color, thickness);
            CheckAndPlot(g, x0, y0, x0 + x, y0 - y, startAngle, endAngle, color, thickness);
        }

        private void CheckAndPlot(Graphics g, int x0, int y0, int x, int y, double startAngle, double endAngle, Color color, int thickness)
        {
            double angle = Math.Atan2(y - y0, x - x0) * 180 / Math.PI;
            while (angle < 0)
            {
                angle += 360;
            }

            while (startAngle < 0)
            {
                startAngle += 360;
            }
            while (endAngle < 0)
            {
                endAngle += 360;
            }

            bool isInArc;
            if (startAngle > endAngle)
            {
                isInArc = (angle >= startAngle || angle <= endAngle);
            }
            else
            {
                isInArc = (angle >= startAngle && angle <= endAngle);
            }

            if (isInArc)
            {
                int start_x = x - thickness / 2;
                int start_y = y - thickness / 2;
                for (int i = 0; i < thickness; ++i)
                {
                    for(int j = 0; j < thickness; ++j)
                    {
                        g.FillRectangle(new SolidBrush(color), start_x + i, start_y + j, 1, 1);
                    }
                }
            }
        }
    }
}
