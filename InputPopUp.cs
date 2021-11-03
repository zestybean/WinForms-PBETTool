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
    public partial class InputPopUp : Form
    {
        bool numOnly = false;

        public int numReturn = 0;
        public string textReturn = "";

        public InputPopUp(bool numOnly)
        {
            InitializeComponent();
            this.numOnly = numOnly;
        }

        /// <summary>
        /// DIGIT INPUT
        /// </summary>
        private void numInput(object sender, EventArgs e)
        {
            Button inputButton = sender as Button;

            inputTxtBox.Text += inputButton.Text;

            if (numOnly)
            {
                if (inputTxtBox.Text == string.Empty)
                {
                    numReturn = 0;
                }
                else
                {
                    numReturn = Convert.ToInt32(inputTxtBox.Text);
                }
            }
        }
        
        /// <summary>
        /// TEXT INPUT
        /// </summary>
        private void textInput(object sender, EventArgs e)
        {
            if (numOnly)
            {
                return;
            }

            Button inputButton = sender as Button;

            inputTxtBox.Text += inputButton.Text;

            textReturn = inputTxtBox.Text;
        }

        /// <summary>
        /// CLEAR AND BACKSPACE
        /// </summary>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            inputTxtBox.Text = "";
        }
        //BACKSPACE
        private void backBtn_Click(object sender, EventArgs e)
        {
            if(inputTxtBox.Text == String.Empty)
            {
                return;
            } else
            {
                inputTxtBox.Text = inputTxtBox.Text.Remove(inputTxtBox.Text.Length - 1);
            }
        }

        /// <summary>
        /// SUB AND CANCEL
        /// </summary>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
