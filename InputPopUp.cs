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
        public InputPopUp()
        {
            InitializeComponent();
        }

        private void numInput(object sender, EventArgs e)
        {
            Button inputButton = sender as Button;

            inputTxtBox.Text += inputButton.Text; 
        }
    }
}
