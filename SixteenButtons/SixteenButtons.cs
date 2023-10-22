using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Game_SixteenButtons
    {
        protected List<int> values = new List<int>();
        public int Min { get; set; }
        public int Max { get; set; }
        public TimeSpan TimeSec { get; set; }
        protected Random random = new Random();
        public int GameStatus { get; set; }

        public Game_SixteenButtons() 
        {
            Min = 0;
            Max = 100;
            TimeSec = new TimeSpan(0,1,0);
            GameStatus = 0;
        }

        public int[] NewGame()
        {
            int temp = -1;
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    while(true)
                    {
                        temp = random.Next(Min, Max);
                        if (!values.Contains(temp))
                            break;
                    }

                    values.Add(temp);
                }
            }
            GameStatus = 1;
            int[] list = values.ToArray();
            values.Sort();
            return list.ToArray();
        }

        public bool GetValue(int value)
        {
            if (values[0] == value)
            {
                values.Remove(value);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
