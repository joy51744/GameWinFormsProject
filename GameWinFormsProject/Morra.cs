using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWinFormsProject
{
    public partial class Morra : Form
    {
        private static int playerWinTomes = 0;  //玩家贏次數

        private static int gameTimes = 0; //總共次數
        private static int tieTimes = 0; //平手次數

        public Morra()
        {
            InitializeComponent();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            String fist = "石頭";
            Game(fist);
        }

        private void Game(string fist)
        {
            gameTimes++;
            lbPlayer.Text = fist;
            int playerNum = Player.ShowFist(fist);
            Computer computer = new Computer();
            int computerNum = computer.ShowFist();
            lbComputer.Text = computer.Fist;
            Judge.RESULT result = Judge.WhoWin(playerNum, computerNum);
            lbJudge.Text = result.ToString();

            if (result == Judge.RESULT.玩家赢)
            {
                playerWinTomes++;
                MessageBox.Show("恭喜，您已經贏了" + playerWinTomes + "場比賽！" + "共進行了" + gameTimes + "場比賽！");
            }
            else if (result == Judge.RESULT.平手)
            {
                tieTimes++;
            }
            lbStatistics.Text = "統計訊息： \n\n1.您贏了" + playerWinTomes + "場比賽！\n\n" +
                "2.平手了" + tieTimes + "次;\n\n" +
                "3.輸掉了" + (gameTimes - playerWinTomes - tieTimes) + "場比賽; \n\n" +
                "4.共進行了" + gameTimes + "場比賽！ \n\n";
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            String fist = "剪刀";
            Game(fist);
        }

        private void btnCloth_Click(object sender, EventArgs e)
        {
            String fist = "布";
            Game(fist);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            GameMainForm main = new GameMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}