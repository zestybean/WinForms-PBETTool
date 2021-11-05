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
    public partial class TextInputPopUp : Form
    {
        public string textReturn = "";

        public TextInputPopUp()
        {
            InitializeComponent();
           
        }

        /// <summary>
        /// DIGIT INPUT
        /// </summary>
        private void numInput(object sender, EventArgs e)
        {
            Button inputButton = sender as Button;

            inputTxtBox.Text += inputButton.Text;

            textReturn = inputTxtBox.Text;
        }
        
        /// <summary>
        /// TEXT INPUT
        /// </summary>
        private void textInput(object sender, EventArgs e)
        {

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
