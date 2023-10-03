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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MatrixCalculate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Calc(object sender, EventArgs e)
        {
            double determinant = 0;
            try
            {
                double a = Convert.ToDouble(f_1_1.Text);
                double b = Convert.ToDouble(f_1_2.Text);
                double c = Convert.ToDouble(f_1_3.Text);
                double d = Convert.ToDouble(f_2_1.Text);
                double E = Convert.ToDouble(f_2_2.Text);
                double f = Convert.ToDouble(f_2_3.Text);
                double g = Convert.ToDouble(f_3_1.Text);
                double h = Convert.ToDouble(f_3_2.Text);
                double i = Convert.ToDouble(f_3_3.Text);

                determinant = a * (E * i - f * h) - b * (d * i - f * g) + c * (d * h - E * g);
                determinant = Math.Round(determinant, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста введите значения матрицы");
                return;
            }

            value.Content = determinant;
        }
    }
}
