using IViews;


namespace TIcTacToe
{


    public partial class Form1 : Form, IView
    {
        int status;
        public bool CurrentPlayer { get; set; }

        public event PressedButton? Buttons;

        int Status
        {
            get { return status; }
            set
            {
                status = value;
                if (status == 0)
                {
                    button1.Text = "Начать";
                    Restart();
                    IsValid(false);
                }
                else if (status == 1)
                {
                    button1.Text = "Закончить";
                    Restart();
                    IsValid(true);
                }
            }
        }

        public Form1()
        {
            CurrentPlayer = true;
            InitializeComponent();
            IsValid(false);
        }

        public Form1(PressedButton b) : this()
        {
            Buttons += new PressedButton(b);
        }

        public void End(string text)
        {
            DialogResult result = MessageBox.Show(text + "\nИграть еще раз?", text, MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Cancel)
            {
                Close();
            }
            else
            {
                Status = 0;
            }
        }

        public void Restart()
        {
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
        }

        public void SetButtons(PressedButton b)
        {
            Buttons += new PressedButton(b);
        }

        public void IsValid(bool value)
        {
            button2.Enabled = value;
            button3.Enabled = value;
            button4.Enabled = value;
            button5.Enabled = value;
            button6.Enabled = value;
            button7.Enabled = value;
            button8.Enabled = value;
            button9.Enabled = value;
            button10.Enabled = value;
            radioButton1.Enabled = !value;
            radioButton2.Enabled = !value;
            radioButton3.Enabled = !value;
            radioButton4.Enabled = !value;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button2.Text = "X";
            else
                button2.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button2.Enabled = false;
            Buttons.Invoke(0, 0, CurrentPlayer);
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button3.Text = "X";
            else
                button3.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button3.Enabled = false;
            Buttons.Invoke(0, 1, CurrentPlayer);
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button4.Text = "X";
            else
                button4.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button4.Enabled = false;
            Buttons.Invoke(0, 2, CurrentPlayer);
        }

        public void button5_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button5.Text = "X";
            else
                button5.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button5.Enabled = false;
            Buttons.Invoke(1, 0, CurrentPlayer);
        }

        public void button6_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button6.Text = "X";
            else
                button6.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button6.Enabled = false;
            Buttons.Invoke(1, 1, CurrentPlayer);

        }

        public void button7_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button7.Text = "X";
            else
                button7.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button7.Enabled = false;
            Buttons.Invoke(1, 2, CurrentPlayer);
        }

        public void button8_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button8.Text = "X";
            else
                button8.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button8.Enabled = false;
            Buttons.Invoke(2, 0, CurrentPlayer);
        }

        public void button9_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button9.Text = "X";
            else
                button9.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button9.Enabled = false;
            Buttons.Invoke(2, 1, CurrentPlayer);
        }

        public void button10_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button10.Text = "X";
            else
                button10.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button10.Enabled = false;
            Buttons.Invoke(2, 2, CurrentPlayer);
        }

      
        public void button1_Click(object sender, EventArgs e)
        {
            if (Status == 0)
            {
                Status = 1;
            }
            else
            {
                Status = 2;
            }
        }
    }
}