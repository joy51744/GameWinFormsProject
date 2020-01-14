using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWinFormsProject
{
    internal class Computer
    {
        public string Fist { get; set; }

        public int ShowFist()
        {
            Random random = new Random();
            int fist = random.Next(1, 4);
            switch (fist)
            {
                case 1: Fist = "石頭"; break;
                case 2: Fist = "剪刀"; break;
                case 3: Fist = "布"; break;
            }
            return fist;
        }
    }
}