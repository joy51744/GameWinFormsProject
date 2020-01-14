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
    public partial class Memory : Form
    {
        private Random random = new Random();

        private List<string> icons = new List<string>()
        {
            "!","!","N","N",",",",","k","k",
            "b","b","v","v","w","w","z","z"
        };

        private Label firstclicked, secondclicked;

        public Memory()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (firstclicked != null && secondclicked != null)
            {
                return;
            }

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
            {
                return;
            }

            if (clickedLabel.ForeColor == Color.Black)
            {
                return;
            }

            if (firstclicked == null)
            {
                firstclicked = clickedLabel;
                firstclicked.ForeColor = Color.Black;
                return;
            }

            secondclicked = clickedLabel;
            secondclicked.ForeColor = Color.Black;

            CheckForWinner();

            if (firstclicked.Text == secondclicked.Text)
            {
                firstclicked = null;
                secondclicked = null;
            }
            else
                timer1.Start();
        }

        private void CheckForWinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                {
                    return;
                }

                MessageBox.Show("You matched all the icons! Congrats!");

                GameMainForm main = new GameMainForm();
                this.Close();
                main.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstclicked.ForeColor = firstclicked.BackColor;
            secondclicked.ForeColor = secondclicked.BackColor;

            firstclicked = null;
            secondclicked = null;
        }

        private void AssignIconsToSquares()
        {
            Label label;
            int randomNumber;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                {
                    continue;
                }

                randomNumber = random.Next(0, icons.Count);
                label1.Text = icons[randomNumber];

                icons.RemoveAt(randomNumber);
            }
        }
    }
}