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
        Output output = new Output();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtA.Text, out double a);
            double.TryParse(txtB.Text, out double b);
            double.TryParse(txtC.Text, out double c);

            double rootpos1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            double rootpos2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            txtOutput.Text = rootpos1.ToString() + " " + rootpos2.ToString();
            output.drawGrid(a, b, c, rootpos1, rootpos2);
            output.Visibility = Visibility.Visible;
        }

    }
}
