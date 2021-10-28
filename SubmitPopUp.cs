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
    public partial class SubmitPopUp : Form
    {
        public string operatorName = "";
        public int shift = 0;
        public string codeString = "";
        

        int code = 0;

        public SubmitPopUp()
        {
            InitializeComponent();
            code = GenerateCode();
            codeLbl.Text = code.ToString();
        }

        private void opTxtBox_TextChanged(object sender, EventArgs e)
        {
            opTxtBox.BackColor = Color.White;
            this.operatorName = opTxtBox.Text;
        }

        private void shiftTxtBox_ValueChanged(object sender, EventArgs e)
        {
            shiftTxtBox.BackColor = Color.White;
            this.shift = Convert.ToInt32(shiftTxtBox.Value);
        }

        private void codeTxtBox_TextChanged(object sender, EventArgs e)
        {
            errorLbl.Visible = false;
            this.codeString = codeTxtBox.Text;
        }

        private int GenerateCode()
        {
            int min = 1000;
            int max = 9999;

            Random rdm = new Random();
            return rdm.Next(min, max);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(operatorName == string.Empty)
            {
                opTxtBox.BackColor = Color.Tomato;
                return;
            }

            if(shift < 1)
            {
                shiftTxtBox.BackColor = Color.Tomato;
                return;
            }

            if(codeString != codeLbl.Text)
            {
                errorLbl.Visible = true;
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
