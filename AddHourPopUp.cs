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
        string downtimeReason = "";
        string scrapReason = "";

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
            this.DialogResult = DialogResult.OK;
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            downtimeReasonTxtBox.Text = "";
            scrapReasonTxtBox.Text = "";
        }
    }
}
