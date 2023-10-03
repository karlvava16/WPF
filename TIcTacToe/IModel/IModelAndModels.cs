namespace Models
{
    public interface IModel
    {
        bool? PlayerWin { get; set; }
        bool GameStatus { get; set; }

        void Restart();
        void Update();
    }

    public class TicTacToe : IModel
    {
        public bool? PlayerWin { get; set; }
        public bool GameStatus { get; set; }

        bool?[,] arrValue = new bool?[3, 3];

        public bool? this[int i, int j]
        {
            get { return arrValue[i, j]; }
            set
            {
                if (this[i, j] != null && value != null)
                {
                    arrValue[i, j] = value;
                    Update();
                }
            }
        }

        public void Restart()
        {
            for (int i = 0; i < arrValue.GetLength(0); i++)
            {
                for (int j = 0; j < arrValue.GetLength(1); j++)
                {
                    arrValue[i, j] = null;
                }
            }
            PlayerWin = null;
            GameStatus = false;
        }

        // Method to check game results
        public void Update()
        {
            // Check diagonals
            if (arrValue[0, 0] != null && arrValue[0, 0] == arrValue[1, 1] && arrValue[0, 0] == arrValue[2, 2])
            {
                GameStatus = true; // Game is over
                PlayerWin = arrValue[0, 0]; // Winner
                return;
            }

            if (arrValue[0, 2] != null && arrValue[0, 2] == arrValue[1, 1] && arrValue[0, 2] == arrValue[2, 0])
            {
                GameStatus = true; // Game is over
                PlayerWin = arrValue[0, 2]; // Winner
                return;
            }

            // Check rows, columns, and diagonals
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (arrValue[i, 0] != null && arrValue[i, 0] == arrValue[i, 1] && arrValue[i, 0] == arrValue[i, 2])
                {
                    GameStatus = true; // Game is over
                    PlayerWin = arrValue[i, 0]; // Winner
                    return;
                }

                // Check columns
                if (arrValue[0, i] != null && arrValue[0, i] == arrValue[1, i] && arrValue[0, i] == arrValue[2, i])
                {
                    GameStatus = true; // Game is over
                    PlayerWin = arrValue[0, i]; // Winner
                    return;
                }
            }

            // Check for a tie
            bool isTie = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arrValue[i, j] == null)
                    {
                        isTie = false;
                        break;
                    }
                }
            }

            if (isTie)
            {
                GameStatus = true; // Game is over as a tie
                PlayerWin = null; // No winner
            }
        }

    }
}