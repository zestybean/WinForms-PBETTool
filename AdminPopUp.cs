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
        public bool touch = false;

        string password = "";

        public AdminPopUp(bool touch)
        {
            InitializeComponent();

            this.touch = touch;

            machineTxtBox.Text = Settings.Default["Machine"].ToString();
            touchCheckBox.Checked = touch;
           
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
        private void submitBtn_Click(object sender, EventArgs e)
        {
            errorLbl.Visible = false;

            if(password == "adminPBET")
            {
                Settings.Default["Machine"] = machineName;
                Settings.Default["Touch"] = touch;
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

        /// <summary>
        /// TOGGLE APP TOUCH
        /// </summary>
        private void touchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            touch = touchCheckBox.Checked;
        }
    }
}
