namespace IViews
{
    public interface IView
    {
        public event  void button2_Click(object sender, EventArgs e)

        bool CurrentPlayer { get; set; }
        void IsValid(bool value);

    }
}
