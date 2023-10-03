namespace IPlayer
{
    public interface IPlayerComputer
    {
        bool PlayerValue();
        void MakeChoise(ref bool?[,] temp);
    }

    public class PlayerComputerDumb : IPlayerComputer
    {
        protected bool playerValue;

        public PlayerComputerDumb(bool playerValue)
        {
            this.playerValue = playerValue;
        }

        public bool PlayerValue() { return playerValue; }

        public void MakeChoise(ref bool?[,] temp)
        {
            Random random = new Random();
            int first, second;

            while (true)
            {
                first = random.Next(0, temp.GetLength(0));
                second = random.Next(0, temp.GetLength(1));

                if (temp[first,second] == null) 
                {
                    temp[first,second] = playerValue;
                }
                return;
            }
        }
    }

}