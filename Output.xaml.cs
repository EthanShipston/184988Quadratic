using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _184988Quadratic
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Output : Window
    {
        public Output()
        {
            InitializeComponent();
        }

        public void drawGrid(double a, double b, double c, double rootpos1, double rootpos2)
        {
            canvas.Children.Clear();

            Line xline = new Line();
            xline.Stroke = Brushes.Black;
            xline.X1 = 0;
            xline.X2 = canvas.Width;
            xline.Y1 = canvas.Height / 2;
            xline.Y2 = canvas.Height / 2;
            canvas.Children.Add(xline);

            Line yline = new Line();
            yline.Stroke = Brushes.Black;
            yline.Y1 = 0;
            yline.Y2 = canvas.Height;
            yline.X1 = canvas.Width / 2;
            yline.X2 = canvas.Width / 2;
            canvas.Children.Add(yline);

            
            int num = -(500 / 2);
            int ii = 0;
            for (int i = 0; i < 500; i++)
            {
                Line lineseg = new Line();

                double y = (a * Math.Pow(num, 2)) + (b * num) + c;
                lineseg.X1 = ii;
                lineseg.Y1 = y + (canvas.Height / 2);
                num++;
                ii++;

                y = (a * Math.Pow(num, 2)) + (b * num) + c;
                lineseg.X2 = ii;
                lineseg.Y2 = y + (canvas.Height / 2);
                lineseg.Stroke = Brushes.Blue;
                canvas.Children.Add(lineseg);
            }

            Ellipse dot1 = new Ellipse();
            dot1.Height = 4;
            dot1.Width = 4;
            dot1.Fill = Brushes.Red;
            Canvas.SetTop(dot1, (canvas.Height / 2) - (dot1.Width / 2));
            Canvas.SetLeft(dot1, ((canvas.Width / 2) + rootpos1) - (dot1.Width / 2));
            canvas.Children.Add(dot1);

            Ellipse dot2 = new Ellipse();
            dot2.Height = 4;
            dot2.Width = 4;
            dot2.Fill = Brushes.Red;
            Canvas.SetTop(dot2, (canvas.Height / 2) - (dot2.Width / 2));
            Canvas.SetLeft(dot2, ((canvas.Width / 2) + rootpos2) - (dot2.Width / 2));
            canvas.Children.Add(dot2);
        }
    }
}
