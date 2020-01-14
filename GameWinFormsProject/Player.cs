using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWinFormsProject
{
    internal class Player
    {
        public static int ShowFist(string fist)
        {
            switch (fist)
            {
                case "石頭": return 1;
                case "剪刀": return 2;
                case "布": return 3;
                default: return 0;
            }
        }
    }
}