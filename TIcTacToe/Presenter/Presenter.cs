using Models;
using IViews;

namespace Presenter
{
    public class Presenter
    {
        private IModel Model;
        private IView View;

        public Presenter(IModel Model, IView View) 
        {
            this.Model = Model;
            this.View = View;
        }
    }
}