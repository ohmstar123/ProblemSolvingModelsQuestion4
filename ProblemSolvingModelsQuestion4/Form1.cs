using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProblemSolvingModelsQuestion4
{
    public partial class outputLabel : Form
    {
        public outputLabel()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            BackColor = Color.Black;

            Refresh();
            Thread.Sleep(3000);
            Refresh();

            label1.Text = "You";
            continueButton.Visible = true;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            //"You should not have done that"
            //Put delay of 1 second between each word

            Refresh();
            Thread.Sleep(1000);
            label1.Text = "You should";

            Refresh();
            Thread.Sleep(1000);
            label1.Text = "You should not";

            Refresh();
            Thread.Sleep(1000);
            label1.Text = "You should not have";

            Refresh();
            Thread.Sleep(1000);
            label1.Text = "You should not have done";

            Refresh();
            Thread.Sleep(1000);
            label1.Text = "You should not have done that";

            Refresh();
            Thread.Sleep(2500);

            this.Close();
        }
    }
}
