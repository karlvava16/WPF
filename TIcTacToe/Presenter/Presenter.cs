using Models;
using IViews;
using IPlayer;

namespace Prsntr
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
            View.SetButtons(SetButtons);
        }

  

        public void SetButtons(int i, int j, bool player)
        {
            Model[i,j] = player;
            if(Model.PlayerWin == null && Model.GameStatus == true)
            {
                View.End("Ничья");
                Model.Restart();
            }
            else if (Model.PlayerWin == false && Model.GameStatus == true)
            {
                View.End("Победил X");
                Model.Restart();
            }
            else if (Model.PlayerWin == true && Model.GameStatus == true)
            {
                View.End("Победли O");
                Model.Restart();
            }
        }
    }
}