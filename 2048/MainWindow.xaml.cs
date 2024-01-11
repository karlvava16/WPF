using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace _2048
{
    public partial class MainWindow : Window
    {
        private int[,] board = new int[4, 4]; // Represents the game board
        public SolidColorBrush[] solidBrush { get; set; }

        private int score = 0;
        public int Score { get { return score; } }

        //public bool IsPossible { get; set; }



        public MainWindow()
        {
            InitializeComponent();

            solidBrush = new SolidColorBrush[12];

            solidBrush[0] = new SolidColorBrush(Colors.LightGray); // Серый (фон)
            solidBrush[1] = new SolidColorBrush(Color.FromRgb(238, 228, 218)); // Бежевый (плитки с числом 2)
            solidBrush[2] = new SolidColorBrush(Color.FromRgb(237, 224, 200)); // Оранжевый (плитки с числом 4)
            solidBrush[3] = new SolidColorBrush(Color.FromRgb(242, 177, 121)); // Красный (плитки с числом 8)
            solidBrush[4] = new SolidColorBrush(Color.FromRgb(245, 149, 99));  // Светло-фиолетовый (плитки с числом 16)
            solidBrush[5] = new SolidColorBrush(Color.FromRgb(246, 124, 95));  // Синий (плитки с числом 32)
            solidBrush[6] = new SolidColorBrush(Color.FromRgb(124, 252, 0));  // Салатовый (плитки с числом 64)
            solidBrush[7] = new SolidColorBrush(Color.FromRgb(178, 34, 34));  // Коричневый (плитки с числом 128)
            solidBrush[8] = new SolidColorBrush(Color.FromRgb(139, 69, 19));  // Темно-коричневый (плитки с числом 256)
            solidBrush[9] = new SolidColorBrush(Color.FromRgb(0, 128, 0));    // Темно-зеленый (плитки с числом 512)
            solidBrush[10] = new SolidColorBrush(Color.FromRgb(128, 0, 128)); // Фиолетовый (плитки с числом 1024)
            solidBrush[11] = new SolidColorBrush(Color.FromRgb(0, 0, 128));

            InitializeGame();

        }

        private void InitializeGame()
        {
            // Initialize the game board
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    board[i, j] = 0;
                }
            }


            // Add two initial tiles to the board
            AddNewTile();
            AddNewTile();

            // Update the UI to reflect the initial state
            UpdateUI();
        }

        private void AddNewTile()
        {
            // Adds a new tile (2 or 4) to a random empty cell on the board
            Random rand = new Random();
            int value = rand.Next(1, 3) * 2; // Either 2 or 4

            int row, col;
            do
            {
                row = rand.Next(0, 4);
                col = rand.Next(0, 4);
            } while (board[row, col] != 0);

            board[row, col] = value;
        }

        private void Restart(object sender, RoutedEventArgs e)
        {
            InitializeGame();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (!CheckForPossibility())
            {  return; }

            // Handle key events (left, right, up, down)
            switch (e.Key)
            {
                case Key.Left:
                    HandleKeyPress(Key.Left);
                    break;
                case Key.Right:
                    HandleKeyPress(Key.Right);
                    break;
                case Key.Up:
                    HandleKeyPress(Key.Up);
                    break;
                case Key.Down:
                    HandleKeyPress(Key.Down);
                    break;
            }

            // Add a new tile after each move
            AddNewTile();

            // Update the UI
            UpdateUI();
        }

        private void UpdateUI()
        {

            // Update the UI based on the current state of the game board
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string buttonName = $"Button{i}{j}";
                    Button button = (Button)FindName(buttonName);

                    if (board[i, j] == 0)
                    {
                        button.Content = "";
                        button.Background = solidBrush[0];

                    }
                    else
                    {
                        button.Content = board[i, j].ToString();
                        switch (button.Content)
                        {

                            case "2":
                                button.Background = solidBrush[1]; break;
                            case "4":
                                button.Background = solidBrush[2]; break;
                            case "8":
                                button.Background = solidBrush[3]; break;
                            case "16":
                                button.Background = solidBrush[4]; break;
                            case "32":
                                button.Background = solidBrush[5]; break;
                            case "64":
                                button.Background = solidBrush[6]; break;
                            case "128":
                                button.Background = solidBrush[7]; break;
                            case "256":
                                button.Background = solidBrush[8]; break;
                            case "512":
                                button.Background = solidBrush[9]; break;
                            case "1024":
                                button.Background = solidBrush[10]; break;
                            case "2048":
                                button.Background = solidBrush[11]; break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private bool CheckForPossibility()
        {
            if (!CanMoveLeft() && !CanMoveRight() && !CanMoveDown() && !CanMoveUp())
            {
                MessageBoxResult res = MessageBox.Show("You lose", "Restart?", MessageBoxButton.OKCancel);
                if (res == MessageBoxResult.OK)
                {
                    Restart(this, new RoutedEventArgs());
                    return false;
                }
                else
                {
                    this.Close();
                }
            }
            return true;
        }

            private void HandleKeyPress(Key key)
        {
            if (key == Key.Left)
            {


                for (int j = 0; j < 4; j++)
                {


                    for (int i = 1, k = 0; i <= 3; i++)
                    {
                        if (board[j, k] != board[j, i] && board[j, i] != 0)
                        {
                            k++;

                        }

                        else if (board[j, k] == board[j, i])
                        {
                            board[j, k] += board[j, i];
                            board[j, i] = 0;
                            k++;
                        }


                    }
                }


                for (int j = 0; j < 4; j++)
                {
                    for (int i = 1, k = 0; i <= 3; i++)
                    {
                        if (board[j, k] == 0)
                        {
                            for (int z = k; z < 4; z++)
                            {
                                if (board[j, z] != 0)
                                {
                                    board[j, k] = board[j, z];
                                    board[j, z] = 0;
                                    k++;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            k++;
                        }
                    }
                }

                
            }

            else if (key == Key.Right)
            {

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 2, k = 3; i >= 0; i--)
                    {
                        if (board[j, k] != board[j, i] && board[j, i] != 0)
                        {
                            k--;
                        }
                        else if (board[j, k] == board[j, i])
                        {
                            board[j, k] += board[j, i];
                            board[j, i] = 0;
                            k--;
                        }
                    }
                }

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 2, k = 3; i >= 0; i--)
                    {
                        if (board[j, k] == 0)
                        {
                            for (int z = k; z >= 0; z--)
                            {
                                if (board[j, z] != 0)
                                {
                                    board[j, k] = board[j, z];
                                    board[j, z] = 0;
                                    k--;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            k--;
                        }
                    }
                }

               
            }

            else if (key == Key.Up)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 1, k = 0; i <= 3; i++)
                    {
                        if (board[k, j] != board[i, j] && board[i, j] != 0)
                        {
                            k++;
                        }
                        else if (board[k, j] == board[i, j])
                        {
                            board[k, j] += board[i, j];
                            board[i, j] = 0;
                            k++;
                        }
                    }
                }

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 1, k = 0; i <= 3; i++)
                    {
                        if (board[k, j] == 0)
                        {
                            for (int z = k; z < 4; z++)
                            {
                                if (board[z, j] != 0)
                                {
                                    board[k, j] = board[z, j];
                                    board[z, j] = 0;
                                    k++;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            k++;
                        }
                    }
                }

                
            }

            else if (key == Key.Down)
            {

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 2, k = 3; i >= 0; i--)
                    {
                        if (board[k, j] != board[i, j] && board[i, j] != 0)
                        {
                            k--;
                        }
                        else if (board[k, j] == board[i, j])
                        {
                            board[k, j] += board[i, j];
                            board[i, j] = 0;
                            k--;
                        }
                    }
                }

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 2, k = 3; i >= 0; i--)
                    {
                        if (board[k, j] == 0)
                        {
                            for (int z = k; z >= 0; z--)
                            {
                                if (board[z, j] != 0)
                                {
                                    board[k, j] = board[z, j];
                                    board[z, j] = 0;
                                    k--;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            k--;
                        }
                    }
                }

               
            }
        }


        //left
        private bool CanMoveLeft()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 1, k = 0; i <= 3; i++)
                {
                    if (board[j, k] != board[j, i] && board[j, i] != 0)
                    {
                        k++;
                        //IsPossible = false;

                    }

                    else if (board[j, k] == board[j, i])
                    {
                        //IsPossible = true;

                        return true;
                    }


                }
            }
            return false;
        }

        //right
        private bool CanMoveRight()
        {

            for (int j = 0; j < 4; j++)
            {


                for (int i = 2, k = 3; i >= 0; i--)
                {
                    if (board[j, k] != board[j, i] && board[j, i] != 0)
                    {
                        k--;
                        //IsPossible = false;

                    }

                    else if (board[j, k] == board[j, i])
                    {

                        k--;
                        //IsPossible = true;
                        return true;
                    }


                }
            }
            return false;
        }

        //up
        private bool CanMoveUp()
        {
            for (int j = 0; j < 4; j++)
            {


                for (int i = 1, k = 0; i <= 3; i++)
                {
                    if (board[k, j] != board[i, j] && board[i, j] != 0)
                    {
                        k++;
                        //IsPossible = false;

                    }

                    else if (board[k, j] == board[i, j])
                    {


                        k++;
                        //IsPossible = true;
                        return true;
                    }


                }
            }

            return false;
        }


        //down
        private bool CanMoveDown()
        {

            for (int j = 0; j < 4; j++)
            {


                for (int i = 2, k = 3; i >= 0; i--)
                {
                    if (board[k, j] != board[i, j] && board[i, j] != 0)
                    {
                        k--;
                        //IsPossible = false;

                    }

                    else if (board[k, j] == board[i, j])
                    {

                        k--;
                        //IsPossible = true;
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
