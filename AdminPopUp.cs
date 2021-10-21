using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBET.Properties;

namespace PBET
{
    public partial class AdminPopUp : Form
    {
        public string machineName = "";
        string password = "";

        public AdminPopUp()
        {
            InitializeComponent();

            machineTxtBox.Text = Settings.Default["Machine"].ToString();
        }

        /// <summary>
        /// CANCEL BUTTON
        /// </summary>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// SAVE BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            errorLbl.Visible = false;

            if(password == "adminPBET")
            {
                Settings.Default["Machine"] = machineName;
                Settings.Default.Save();

                this.DialogResult = DialogResult.OK;
            } else
            {
                errorLbl.Text = "Invalid password";
                errorLbl.Visible = true;
            }
        }

        /// <summary>
        /// MACHINE TXT
        /// </summary>
        private void machineTxtBox_TextChanged(object sender, EventArgs e)
        {
            machineName = machineTxtBox.Text;
        }

        /// <summary>
        /// PASSWORD TXT
        /// </summary>
        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {
            password = passwordTxtBox.Text;
        }

        
    }
}
