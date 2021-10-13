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
        public int goal = 0;
        public int actual = 0;
        public string sequence = "";
        public int scrap = 0;
        public int downtime = 0;
        public string downtimeReason = "";
        public string scrapReason = "";

        public AddHourPopUp()
        {
            InitializeComponent();
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
            if(scrap > 0 && downtimeReasonTxtBox.Text == "")
            {
                downtimeReasonTxtBox.BackColor = Color.Red;
            } else
            {
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
        }

        /// <summary>
        /// SCRAP MENU
        /// </summary>
        private void button36_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            scrapReason = button.Text;
            scrapReasonTxtBox.Text = scrapReason;
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
