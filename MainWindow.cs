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
    public partial class MainWindow : Form
    {
        private DataTable hoursTable;
        private DataTable cartsTable;

        List<string> hoursColStrings = new List<string> { "Hour", "Goal", "Actual", "Variance", "Part Number", "Scrap", "Downtime", "Scrap Reason", "Downtime Reason" };
        List<string> cartColStrings = new List<string> { "Time In", "Part Description", "Part Sequence", "Quantity", "Color", "Rework" };

        public MainWindow()
        {
            InitializeComponent();
            FormStyles();

            this.hoursTable = new DataTable("hoursTable");
            this.cartsTable = new DataTable("cartsTable");

            for(int i = 0; i < hoursColStrings.Count; i++)
            {
                DataColumn hourCol;

                if(hoursColStrings[i] == "Goal" || hoursColStrings[i] == "Actual" || hoursColStrings[i] == "Variance" || hoursColStrings[i] == "Scrap" || hoursColStrings[i] == "Downtime")
                {
                    hourCol = new DataColumn(hoursColStrings[i], typeof(double));
                } else
                {
                    hourCol = new DataColumn(hoursColStrings[i], typeof(string));
                }

                
                this.hoursTable.Columns.Add(hourCol);
            }

            for (int i = 0; i < cartColStrings.Count; i++)
            {
                DataColumn cartCol;

                if(cartColStrings[i] == "Rework")
                {
                     cartCol = new DataColumn(cartColStrings[i], typeof(bool));
                }
                else
                {
                     cartCol = new DataColumn(cartColStrings[i], typeof(string));
                }
                
                this.cartsTable.Columns.Add(cartCol);
            }

            this.hoursTable.ReadXml("temp1.xml");
            this.cartsTable.ReadXml("temp2.xml");

            this.dataGridView1.DataSource = this.hoursTable;
            this.dataGridView2.DataSource = this.cartsTable;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {   
            this.hoursTable.WriteXml("temp1.xml");
            this.cartsTable.WriteXml("temp2.xml");
        }

        private void calcSummaryLabels()
        {
            hrLbl.Text = dataGridView1.RowCount.ToString();
            goalLbl.Text = hoursTable.Compute("Sum(Goal)", "").ToString();
            actualLbl.Text = hoursTable.Compute("Sum(Actual)", "").ToString();
            varLbl.Text = hoursTable.Compute("Sum(Variance)", "").ToString();
            scrapLbl.Text = hoursTable.Compute("Sum(Scrap)", "").ToString();
            downtimeLbl.Text = hoursTable.Compute("Sum(Downtime)", "").ToString();
        }
      

        private void FormStyles()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView2.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Bold);
        }

        /// <summary>
        /// ADD HOUR BUTTON 
        /// </summary>
        private void addHourBtn_Click(object sender, EventArgs e)
        {
            AddHourPopUp addHourPopUp = new AddHourPopUp(0, 0, "", 0, 0, "", "");

            if(addHourPopUp.ShowDialog(this) == DialogResult.OK)
            {
                //"Hour", "Goal" , "Actual", "Variance", "Part Number", "Scrap", "Downtime (Minutes)", "Scrap Reason", "Downtime Reason"
                hoursTable.Rows.Add(DateTime.Now.ToString("HH:mm tt"), addHourPopUp.goal, addHourPopUp.actual, addHourPopUp.variance, addHourPopUp.sequence, 
                    addHourPopUp.scrap, addHourPopUp.downtime, addHourPopUp.scrapReason, addHourPopUp.downtimeReason);
            } else
            {
                //Cancel
            }
            
            //Destroy pop up
            addHourPopUp.Dispose();
        }

        /// <summary>
        /// SUBMIT  BUTTON
        /// </summary>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            hoursTable.Clear();
            cartsTable.Clear();
            hoursTable.WriteXml("temp1.xml");
            cartsTable.WriteXml("temp2.xml");
        }

        /// <summary>
        /// CLEAR CART BUTTON
        /// </summary>
        private void clearCartBtn_Click(object sender, EventArgs e)
        {
            cartsTable.Rows.Add("Clear", "Clear", "Clear", "Clear", 0, false);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //THIS IS TO SUM IN THE SUMMARY
            calcSummaryLabels();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //THIS IS TO SUM IN THE SUMMARY
            calcSummaryLabels();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //WORKS
            int goal = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[1].Value);
            int actual = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[2].Value);
            string sequence = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            int scrap = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[5].Value);
            int downtime = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[6].Value);
            string scrapReason = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string downtimeReason = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();

            AddHourPopUp addHourPopUp = new AddHourPopUp(goal, actual, sequence, scrap, downtime, scrapReason, downtimeReason);

            if (addHourPopUp.ShowDialog(this) == DialogResult.OK)
            {
                //"Hour", "Goal" , "Actual", "Variance", "Part Number", "Scrap", "Downtime (Minutes)", "Scrap Reason", "Downtime Reason"
                hoursTable.Rows[e.RowIndex]["Goal"] = addHourPopUp.goal;
                hoursTable.Rows[e.RowIndex]["Actual"] = addHourPopUp.actual;
                hoursTable.Rows[e.RowIndex]["Variance"] = addHourPopUp.variance;
                hoursTable.Rows[e.RowIndex]["Part Number"] = addHourPopUp.sequence;
                hoursTable.Rows[e.RowIndex]["Scrap"] = addHourPopUp.scrap;
                hoursTable.Rows[e.RowIndex]["Downtime"] = addHourPopUp.downtime;
                hoursTable.Rows[e.RowIndex]["Scrap Reason"] = addHourPopUp.scrapReason;
                hoursTable.Rows[e.RowIndex]["Downtime Reason"] = addHourPopUp.downtimeReason;

                calcSummaryLabels();

            }
            else
            {
                //Cancel
            }
        }

        
    }

    
}
