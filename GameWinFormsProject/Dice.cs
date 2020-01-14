using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameWinFormsProject
{
    public partial class Dice : Form
    {
        private int dice1, dice2, sum, toMon, putMon, i = 5, j = 2;

        private void timer3_Tick(object sender, EventArgs e)
        {
            i--;
            label3.Text = "還有" + Convert.ToString(i) + "秒鐘";
            if (i == 0)
            {
                GameMainForm main = new GameMainForm();
                this.Visible = false;
                main.Show();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            j--;
            if (j == 0)
            {
                label3.Text = "你沒錢了，抱歉！";
                timer3.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            sum = 0;
            sum = dice1 + dice2;
            if (radioButton1.Checked == true)
            {
                if (sum > 6) label1.Text = "大，玩家勝";
                else
                {
                    label1.Text = "小，莊家勝";
                    putMon = -putMon;
                }
                toMon += putMon;
                textBox2.Text = Convert.ToString(toMon);

                if (!(toMon > 0))
                {
                    j = 2;
                    timer4.Enabled = true;
                }
            }
            else
            {
                if (sum <= 6) label1.Text = "小，玩家勝";
                else
                {
                    label3.Text = "大，莊家勝";
                    putMon = -putMon;
                }
                toMon += putMon;
                textBox2.Text = Convert.ToString(toMon);

                if (!(toMon > 0))
                {
                    j = 2;
                    timer4.Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            dice1 = randomNumber.Next(1, 7);
            dice2 = randomNumber.Next(1, 7);
            displayDice(pictureBox1, dice1);
            displayDice(pictureBox2, dice2);
        }

        public Dice()
        {
            InitializeComponent();
            displayDice(pictureBox1, 1);
            displayDice(pictureBox2, 1);
            toMon = 100;
            textBox2.Text = Convert.ToString(toMon);
        }

        private void displayDice(PictureBox imgDice, int face)
        {
            imgDice.Image = Image.FromFile(
             Directory.GetCurrentDirectory() +
              "\\picture\\" + face + ".jpg");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            GameMainForm main = new GameMainForm();
            this.Visible = false;
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") label3.Text = "您還沒下注，請下注";
            else
            {
                putMon = Convert.ToInt32(textBox1.Text);
                if (putMon > toMon) label3.Text = "您下的注過大，餘額不足，\r\n請重新下注";
                else
                {
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                }
            }
        }
    }
}