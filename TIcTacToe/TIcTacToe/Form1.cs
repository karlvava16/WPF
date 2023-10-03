using IViews;

namespace TIcTacToe
{
    public partial class Form1 : Form, IView
    {
        int Status;
        public bool CurrentPlayer { get; set; }
        public Form1()
        {
            CurrentPlayer = true;
            InitializeComponent();
            IsValid(false);
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
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if(CurrentPlayer)
                button2.Text = "X";
            else
                button2.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button2.Enabled = false;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button2.Text = "X";
            else
                button2.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button2.Enabled = false;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button2.Text = "X";
            else
                button2.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button2.Enabled = false;
        }

        public void button5_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button2.Text = "X";
            else
                button2.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button2.Enabled = false;
        }

        public void button6_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button2.Text = "X";
            else
                button2.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button2.Enabled = false;
        }

        public void button7_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button2.Text = "X";
            else
                button2.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button2.Enabled = false;
        }

        public void button8_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button2.Text = "X";
            else
                button2.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button2.Enabled = false;
        }

        public void button9_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button2.Text = "X";
            else
                button2.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button2.Enabled = false;
        }

        public void button10_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button2.Text = "X";
            else
                button2.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button2.Enabled = false;
        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (CurrentPlayer)
                button2.Text = "X";
            else
                button2.Text = "O";
            CurrentPlayer = !CurrentPlayer;
            button2.Enabled = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if(Status == 0)
            {
                Status = 1;
                IsValid(true);
            }
        }
    }
}