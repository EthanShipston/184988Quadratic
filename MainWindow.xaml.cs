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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _184988Quadratic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
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

            
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtA.Text, out double a);
            double.TryParse(txtB.Text, out double b);
            double.TryParse(txtC.Text, out double c);

            double rootpos1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            double rootpos2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            Point[] points = new Point[3];
            points[0].X = rootpos1;
            points[0].Y = canvas.Height / 2;
            points[1].X = rootpos2;
            points[1].Y = canvas.Height / 2;
            points[2].X = canvas.Width / 2;
            points[2].Y = c;

            txtOutput.Text = rootpos1.ToString() + " " + rootpos2.ToString();

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

            PathGeometry curve = new PathGeometry();
            
            Graphics
        }

    }
}
