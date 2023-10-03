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

namespace SecondTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string Password = "51234";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Click_Num(object sender, EventArgs e)
        {
            text.Text += ((Button)sender).Content;
        }
        public void Click_Clear(object sender, EventArgs e)
        {
            text.Text = "";
        }
        public void Click_Open(object sender, EventArgs e)
        {
            if(Password == text.Text)
            {
                MessageBox.Show("Сейф окрыт!");
            }
            else
            {
                MessageBox.Show("Сейф закрыт!");
            }
        }
    }
}
