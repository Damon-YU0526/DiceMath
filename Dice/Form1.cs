using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Sum = 0; //Using Globe variable so that its value can be shared by both events

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random seed = new Random(); //generate a random number as seed so that two numbers will be different
            int Dice1 = seed.Next(6) + 1; //Since C# counts number from 0, it needs to plus 1 in order to start from 1.

            lb1Dice1.Text = Dice1.ToString(); //In order to display integer number in the label, it needs to be converted to string data type.

            pbxDice1.Image = Image.FromFile("DieSide" + Dice1.ToString() + ".gif");


            int Dice2 = seed.Next(6) + 1; //Since C# counts number from 0, it needs to plus 1 in order to start from 1.

            lb1Dice2.Text = Dice2.ToString(); //In order to display integer number in the label, it needs to be converted to string data type.

            pbxDice2.Image = Image.FromFile("DieSide" + Dice2.ToString() + ".gif");


            Sum = Dice1 + Dice2; //Prepare the Sume result by computer
            txtAnswer.Text = ""; //Clean the answer box
            txtAnswer.Focus();   //set Cursor on
        }
        int crrectCount = 0, totalCount = 0;
        private void btnAnswer_Click(object sender, EventArgs e)
        { //Sicne Sum is a Globe variable, its value from previous eventcan be used here 
            //receive submitted answer by learner and converted it into an integer
            int Answer = int.Parse(txtAnswer.Text);

            if (Sum == Answer) //compairing the prepaired Sum result by computer to submitted Answer from learner
            {
                crrectCount = crrectCount + 1;
                MessageBox.Show("Well done!");
            }
            else
            {
                MessageBox.Show("Try again!");
            }

            totalCount = totalCount + 1;

            lblTotal.Text = totalCount.ToString();
            lblCorrect.Text = crrectCount.ToString();
        }
    }
}
