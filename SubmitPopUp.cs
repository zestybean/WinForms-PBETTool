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


        bool touch = false;
        int code = 0;

        public SubmitPopUp(bool touch)
        {
            InitializeComponent();

            if (touch)
            {
                shiftTxtBox.Controls[0].Enabled = false;
            }

            code = GenerateCode();
            codeLbl.Text = code.ToString();
            this.touch = touch;
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
        /// <summary>
        /// TESTING
        /// </summary>
        //IF TOUCH IS ENABLED
        private void opTxtBox_Click(object sender, EventArgs e)
        {
            //RETURN IF TOUCH IS DISABLED
            if (!touch)
            {
                return;
            }

            TextInputPopUp input = new TextInputPopUp();

            if (input.ShowDialog(this) == DialogResult.OK)
            {
                opTxtBox.Text = input.textReturn;
            }
            else
            {
                //Cancel
            }
        }

        private void shiftTxtBox_Click(object sender, EventArgs e)
        {
            //RETURN IF TOUCH IS DISABLED
            if (!touch)
            {
                return;
            }

            NumInputPopUp input = new NumInputPopUp();

            if (input.ShowDialog(this) == DialogResult.OK)
            {
                if (input.numReturn > shiftTxtBox.Maximum)
                {
                    shiftTxtBox.Value = shiftTxtBox.Maximum;
                    return;
                }

                shiftTxtBox.Value = input.numReturn;
            }
            else
            {
                //Cancel
            }
        }

        private void codeTxtBox_Click(object sender, EventArgs e)
        {
            //RETURN IF TOUCH IS DISABLED
            if (!touch)
            {
                return;
            }

            TextInputPopUp input = new TextInputPopUp();

            if (input.ShowDialog(this) == DialogResult.OK)
            {
                codeTxtBox.Text = input.textReturn;
            }
            else
            {
                //Cancel
            }
        }

    }
}
