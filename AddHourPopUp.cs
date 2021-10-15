using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBET
{
    public partial class AddHourPopUp : Form
    {
        public int goal;
        public int actual;
        public int variance;
        public string sequence;
        public int scrap;
        public int downtime;
        public string downtimeReason;
        public string scrapReason;

        public AddHourPopUp(int goal, int actual,string sequence, int scrap, int downtime, string scrapReason, string downtimeReason)
        {
            InitializeComponent();

            this.goal = goal;
            this.actual = actual;
            this.sequence = sequence;
            this.scrap = scrap;
            this.downtime = downtime;
            this.downtimeReason = downtimeReason;
            this.scrapReason = scrapReason;

            goalTxtBox.Value = goal;
            actualTxtBox.Value = actual;
            seqTxtBox.Text = sequence;
            scrapTxtBox.Value = scrap;
            downTxtBox.Value = downtime;
            scrapReasonTxtBox.Text = scrapReason;
            downtimeReasonTxtBox.Text = downtimeReason;

        }

        /// <summary>
        /// CANCEL BTN
        /// </summary>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// SUB BTN
        /// </summary>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(scrap > 0 && scrapReasonTxtBox.Text == "")
            {
                scrapReasonTxtBox.BackColor = Color.Tomato;
            } else if (downtime > 0 && downtimeReasonTxtBox.Text == "")
            {
                downtimeReasonTxtBox.BackColor = Color.Tomato;
            } else
            {
                this.variance = actual - goal;
                this.DialogResult = DialogResult.OK;
            }

           
        }
        

        /// <summary>
        /// DOWNTIME MENU
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            downtimeReason = button.Text;
            downtimeReasonTxtBox.Text = downtimeReason;
            downtimeReasonTxtBox.BackColor = SystemColors.Control;
        }

        /// <summary>
        /// SCRAP MENU
        /// </summary>
        private void button36_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            scrapReason = button.Text;
            scrapReasonTxtBox.Text = scrapReason;
            scrapReasonTxtBox.BackColor = SystemColors.Control;
        }

        /// <summary>
        /// CLEAR REASONS
        /// </summary>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            downtimeReasonTxtBox.Text = "";
            scrapReasonTxtBox.Text = "";
        }

        /// <summary>
        /// HOUR FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goalTxtBox_ValueChanged(object sender, EventArgs e)
        {
            goal = Convert.ToInt32(goalTxtBox.Value);
        }

        private void actualTxtBox_ValueChanged(object sender, EventArgs e)
        {
            actual = Convert.ToInt32(actualTxtBox.Value);
        }

        private void seqTxtBox_TextChanged(object sender, EventArgs e)
        {
            sequence = seqTxtBox.Text;
        }

        private void scrapTxtBox_ValueChanged(object sender, EventArgs e)
        {
            scrap = Convert.ToInt32(scrapTxtBox.Value);
        }

        private void downTxtBox_ValueChanged(object sender, EventArgs e)
        {
            downtime = Convert.ToInt32(downTxtBox.Value);
        }
    }
}
