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
    public partial class GuessNumber : Form
    {
        private int guess, count, min, max;

        private void buttonOk_Click(object sender, EventArgs e)
        {
            count += 1;
            int myguess = 0;
            try
            {
                myguess = int.Parse(txtGuess.Text); //判斷輸入職
            }
            catch
            {
                MessageBox.Show(" == 請輸入數字！！！ ==");
            }

            if (myguess >= 1 && myguess < 100)
            {
                if (myguess == guess)
                {
                    MessageBox.Show(" == 恭喜！你猜對了 ==");
                    buttonOk.Enabled = false;
                }
                else if (myguess > guess)
                {
                    max = myguess; //將輸入值取代最大值
                    MessageBox.Show(" == 再小一點！==");
                }
                else if (myguess < guess)
                {
                    min = myguess; //將輸入值取代最小值
                    MessageBox.Show(" == 再大一點！==");
                }
            }
            else
            {
                MessageBox.Show(" == 請輸入提示範圍內的數字.. ==");
            }

            labelMessage.Text = " == 共猜了" + count + "次.. ";
            labelTitle.Text = min + "< ? <" + max;
        }

        private void buttonAgain_Click(object sender, EventArgs e)
        {
            GuessNumber_Load(sender, e);
        }

        private void GuessNumber_Load(object sender, EventArgs e)
        {
            Random r = new Random(); //產生亂數物件 r
            guess = r.Next(1, 100);  //產生1-99亂數當被猜樹置入guess
            min = 0;
            max = 100;
            count = 0;
            labelTitle.Text = min + " < ? < " + max;
            labelMessage.Text = "共猜了" + count + "次";
            buttonOk.Enabled = true;
            textBoxGuess.Text = "";
        }

        public GuessNumber()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            GameMainForm main = new GameMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}