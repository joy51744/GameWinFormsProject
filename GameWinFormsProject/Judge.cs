using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWinFormsProject
{
    internal class Judge
    {
        public enum RESULT
        {
            玩家赢,
            電腦赢,
            平手,
        }

        public static RESULT WhoWin(int PlayerNum, int ComputerNum)
        {
            int result = PlayerNum - ComputerNum;
            if (result == -1 || result == 2)
            {
                return RESULT.玩家赢;
            }
            else if (result == 0)
            {
                return RESULT.平手;
            }
            else
            {
                return RESULT.電腦赢;
            }
        }
    }
}