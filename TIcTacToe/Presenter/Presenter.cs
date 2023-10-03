using Models;
using IViews;
using IPlayer;

namespace Presenter
{
    public class Presenter
    {
        private IModel Model;
        private IView View;
        private IPlayerComputer? pc = null;


        public Presenter(IModel Model, IView View) 
        {
            this.Model = Model;
            this.View = View;
        }


    }
}