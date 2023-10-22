using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Game;
using static System.Formats.Asn1.AsnWriter;

namespace SixteenButtons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> buttons;
        Game_SixteenButtons game;
        TimeSpan CurrentTime;
       
        public MainWindow()
        {
            InitializeComponent();
            game = new Game_SixteenButtons();
            buttons = new List<Button>();
            buttons.Add(Button00);
            buttons.Add(Button01);
            buttons.Add(Button02);
            buttons.Add(Button03);
            buttons.Add(Button10);
            buttons.Add(Button11);
            buttons.Add(Button12);
            buttons.Add(Button13);
            buttons.Add(Button20);
            buttons.Add(Button21);
            buttons.Add(Button22);
            buttons.Add(Button23);
            buttons.Add(Button30);
            buttons.Add(Button31);
            buttons.Add(Button32);
            buttons.Add(Button33);

            IsDisabled(true);
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
             Button clickedButton = (Button)sender;
            int clickedValue = Convert.ToInt32(clickedButton.Content);

            if (game.GetValue(clickedValue))
            {
                clickedButton.IsEnabled = false; // Disable the button
                CorrectNumbers.Items.Add(clickedValue);
            }
            else
            {
                CurrentTime = CurrentTime.Subtract(new TimeSpan(0, 0, 5));
                prog_bar.Value = CurrentTime.TotalSeconds;

            }

        }

        void IsDisabled(bool value)
        {
            for (int i = 0; i < buttons.Count; i++) 
            {
                buttons[i].IsEnabled = !value;
            }
        }

        private void NewGame(object sender, RoutedEventArgs e)
        {
            int[] temp = game.NewGame();
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Content = Convert.ToString(temp[i]);
            }
            prog_bar.Maximum = game.TimeSec.TotalSeconds;
            prog_bar.Value = game.TimeSec.TotalSeconds;
            CurrentTime = game.TimeSec;
            game.GameStatus = 1;
            IsDisabled(false);

        }
    }
}
