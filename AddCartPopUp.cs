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
    public partial class AddCartPopUp : Form
    {
        public string partDescription;
        public string partNumber;
        public int partQuantity;
        public string partColor;
        public bool partRework;

        bool touch;

        public AddCartPopUp(string partDescription, string partNumber, int partQuantity, string partColor, bool partRework, bool touch)
        {
            InitializeComponent();

            if (touch)
            {
                quantityTxtBox.Controls[0].Enabled = false;
            }

            this.partDescription = partDescription;
            this.partNumber = partNumber;
            this.partQuantity = partQuantity;
            this.partColor = partColor;
            this.partRework = partRework;

            this.touch = touch;

            partDescTxtBox.Text = partDescription;
            seqTxtBox.Text = partNumber;
            quantityTxtBox.Value = partQuantity;
            colorTxtBox.Text = partColor;
            reworkChkBox.Checked = partRework;
        }

        private void partDescriptionBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            partDescription = button.Text;
            partDescTxtBox.Text = partDescription;
            partDescTxtBox.BackColor = SystemColors.Control;

            if (partDescription == "HZ Bumper Fender Robot")
            {
                quantityTxtBox.Value = 10;
            }
            else if (partDescription == "HZ Bumper Robot")
            {
                quantityTxtBox.Value = 6;
            }
            else if (partDescription == "HZ Skirt Robot")
            {
                quantityTxtBox.Value = 5;
            }
            else if (partDescription == "MLU Fairing Robot")
            {
                quantityTxtBox.Value = 4;
            }
            else if (partDescription == "MLU Bumper Robot")
            {
                quantityTxtBox.Value = 2;
            }
            else
            {
                quantityTxtBox.Value = 0;
            }
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
            if(partDescription == string.Empty)
            {
                partDescTxtBox.BackColor = Color.Tomato;
                return;
            } if (quantityTxtBox.Value < 1)
            {
                quantityTxtBox.BackColor = Color.Tomato;
                return;
            }  if (partColor == string.Empty)
            {
                colorTxtBox.BackColor = Color.Tomato;
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// CART FORM
        /// </summary>
        private void partDescTxtBox_TextChanged(object sender, EventArgs e)
        {

            this.partDescription = partDescTxtBox.Text;
        }

        private void seqTxtBox_TextChanged(object sender, EventArgs e)
        {
            this.partNumber = seqTxtBox.Text;
        }

        private void quantityTxtBox_ValueChanged(object sender, EventArgs e)
        {
            quantityTxtBox.BackColor = Color.White;
            this.partQuantity = Convert.ToInt32(quantityTxtBox.Value);
        }

        private void colorTxtBox_TextChanged(object sender, EventArgs e)
        {
            colorTxtBox.BackColor = Color.White;
            this.partColor = colorTxtBox.Text;
        }

        private void reworkChkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.partRework = reworkChkBox.Checked;
        }

        private void numUpDownEnter(object sender, EventArgs e)
        {
            if (sender is NumericUpDown)
            {
                (sender as NumericUpDown).Select(0, (sender as NumericUpDown).Text.Length);
            }

            //RETURN IF TOUCH IS DISABLED
            if (!touch)
            {
                return;
            }

            NumInputPopUp input = new NumInputPopUp();

            if (input.ShowDialog(this) == DialogResult.OK)
            {
                if (sender is NumericUpDown)
                {
                    if (input.numReturn > (sender as NumericUpDown).Maximum)
                    {
                        (sender as NumericUpDown).Value = (sender as NumericUpDown).Maximum;
                        return;
                    }

                    (sender as NumericUpDown).Value = input.numReturn;
                }

            }
            else
            {
                //Cancel
            }
        }

        private void TxtBoxClicked(object sender, EventArgs e)
        {
            //RETURN IF TOUCH IS DISABLED
            if (!touch)
            {
                return;
            }

            TextInputPopUp input = new TextInputPopUp();

            if (input.ShowDialog(this) == DialogResult.OK)
            {
                if(sender is TextBox)
                {
                    (sender as TextBox).Text = input.textReturn;
                }
                
            }
            else
            {
                //Cancel
            }
        }
    }

   
}
