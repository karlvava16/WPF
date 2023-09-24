namespace IViews
{
    public interface IView
    {
        bool Player { get; set; }
        void IsValid(bool value);
    }
}
