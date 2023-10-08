namespace IViews
{
    public delegate void PressedButton(int i, int j, bool value);

    public interface IView
    {
        event PressedButton Buttons;
        void SetButtons(PressedButton b);
        bool CurrentPlayer { get; set; }
        void IsValid(bool value);
        void End(string text);
        void Restart();
    }
}
