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
    }
}
