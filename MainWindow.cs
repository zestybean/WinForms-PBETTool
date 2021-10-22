﻿using System;
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

            machineNameLbl.Text = Settings.Default["Machine"].ToString();

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
                else if (cartColStrings[i] == "Quantity")
                {
                    cartCol = new DataColumn(cartColStrings[i], typeof(double));
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

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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


        //THIS IS FOR EDITING CELLS 
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

        /// <summary>
        /// ADD CART BUTTON
        /// </summary>
        private void addCartBtn_Click(object sender, EventArgs e)
        {
            AddCartPopUp addCartPopUp = new AddCartPopUp("", "", 0, "", false);

            if (addCartPopUp.ShowDialog(this) == DialogResult.OK)
            {
                cartsTable.Rows.Add(DateTime.Now.ToString("HH:mm tt"), addCartPopUp.partDescription, addCartPopUp.partNumber, addCartPopUp.partQuantity, addCartPopUp.partColor, addCartPopUp.partRework);
            }
            else
            {
                //Cancel
            }

            //Destroy pop up
            addCartPopUp.Dispose();
        }

        /// <summary>
        /// CLEAR CART BUTTON
        /// </summary>
        private void clearCartBtn_Click(object sender, EventArgs e)
        {
            cartsTable.Rows.Add(DateTime.Now.ToString("HH:mm tt"), "Clear", "Clear", 0, "Clear", false);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //WORKS
            string description = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            string sequence = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            int quantity = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[3].Value);
            string color = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            bool rework = Convert.ToBoolean(this.dataGridView2.CurrentRow.Cells[5].Value);

            AddCartPopUp addHourPopUp = new AddCartPopUp(description, sequence, quantity, color, rework);

            if (addHourPopUp.ShowDialog(this) == DialogResult.OK)
            {
                //"Time In", "Part Description", "Part Sequence", "Quantity", "Color", "Rework"
                cartsTable.Rows[e.RowIndex]["Part Description"] = addHourPopUp.partDescription;
                cartsTable.Rows[e.RowIndex]["Part Sequence"] = addHourPopUp.partNumber;
                cartsTable.Rows[e.RowIndex]["Quantity"] = addHourPopUp.partQuantity;
                cartsTable.Rows[e.RowIndex]["Color"] = addHourPopUp.partColor;
                cartsTable.Rows[e.RowIndex]["Rework"] = addHourPopUp.partRework;

                calcSummaryLabels();

            }
            else
            {
                //Cancel
            }
        }

        private void deleteRowConfirm(DataGridView gridView)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete selected rows?", "DELETE ROW", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                //Yes
                foreach (DataGridViewRow row in gridView.SelectedRows)
                {
                    gridView.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                //No
            }
        }

        private void adminPanelBtn_Click(object sender, EventArgs e)
        {
            AdminPopUp adminPopUp = new AdminPopUp();

            if (adminPopUp.ShowDialog(this) == DialogResult.OK)
            {
                machineNameLbl.Text = adminPopUp.machineName;
            }
            else
            {
                //Cancel
            }
        }
        
        private void deleteHourRowBtn_Click(object sender, EventArgs e)
        {
            deleteRowConfirm(dataGridView1);
        }
        private void deleteCartRowBtn_Click(object sender, EventArgs e)
        {
            deleteRowConfirm(dataGridView2);
        }

    }


}
