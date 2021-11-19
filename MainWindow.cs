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
using ClosedXML.Excel;
using System.Globalization;
using System.Data.SqlClient;

namespace PBET
{
    public partial class MainWindow : Form
    {
        //INIT
        private DataTable hoursTable;
        private DataTable cartsTable;

        //HOUR POPUP TEMPS
        private int goalHourTemp = 0;
        private string seqHourTemp = "";

        //CART POPUP TEMPS
        private string colorCartTemp = "";

        //TESTING CHECK
        private bool appTesting = Convert.ToBoolean(Settings.Default["Testing"]);
        bool touch = Convert.ToBoolean(Settings.Default["Touch"]);

        //Data for each of the data grid views on the main screen
        List<string> hoursColStrings = new List<string> { "Hour", "Goal", "Actual", "Variance", "Part Number", "Scrap", "Downtime", "Scrap Reason", "Downtime Reason" };
        List<string> cartColStrings = new List<string> { "Time In", "Part Description", "Part Sequence", "Quantity", "Color", "Rework" };

        //CONSTRUCTOR
        public MainWindow()
        {
            InitializeComponent();
            FormStyles();
            //Grab the machine name from the settings
            //at the start of the application
            //you can edit this setting using the admin panel in settings
            machineNameLbl.Text = Settings.Default["Machine"].ToString();

            //Datagridview table inits
            this.hoursTable = new DataTable("hoursTable");
            this.cartsTable = new DataTable("cartsTable");

            //Loop through each string and assign each column, data type included
            //HOURS
            for(int i = 0; i < hoursColStrings.Count; i++)
            {
                DataColumn hourCol;

                //Some of the strings represent different data types
                //Depending on the strings, strings and doubles
                if(hoursColStrings[i] == "Goal" || hoursColStrings[i] == "Actual" || hoursColStrings[i] == "Variance" || hoursColStrings[i] == "Scrap" || hoursColStrings[i] == "Downtime")
                {
                    hourCol = new DataColumn(hoursColStrings[i], typeof(double));
                } else
                {
                    hourCol = new DataColumn(hoursColStrings[i], typeof(string));
                }
                
                //Finally add the column
                this.hoursTable.Columns.Add(hourCol);
            }

            //Loop through each string and assign each column, data type included
            //CARTS
            for (int i = 0; i < cartColStrings.Count; i++)
            {
                DataColumn cartCol;

                //Some of the strings represent different data types
                //Depending on the strings, strings, double and bool for
                //the rework check boxes
                if (cartColStrings[i] == "Rework")
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

                //Finally add the column
                this.cartsTable.Columns.Add(cartCol);
            }

            //After the columns are created 
            //Attempt to retrieve data if any
            //from the temp data data files
            this.hoursTable.ReadXml("temp1.xml");
            this.cartsTable.ReadXml("temp2.xml");

            //Finally assign the datagridview data source to the
            //data grid view to visualize the data
            this.dataGridView1.DataSource = this.hoursTable;
            this.dataGridView2.DataSource = this.cartsTable;

            //This prevents the columns from being sorted by the users
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //This prevents the columns from being sorted by the users
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {   
            //When the application is closing
            //save the data to the temp files
            this.hoursTable.WriteXml("temp1.xml");
            this.cartsTable.WriteXml("temp2.xml");
        }

        //Calculates the data grid view tables
        //and displays the computed values
        //in the summary section
        private void calcSummaryLabels()
        {
            double performance = 0.0;
            double availability = 0.0;
            double quality = 0.0;
            double oee = 0.0;

            //HOUR SUMMARY
            hrLbl.Text = dataGridView1.RowCount.ToString();
            goalLbl.Text = tableComputedSum(hoursTable, "Goal");
            actualLbl.Text = tableComputedSum(hoursTable, "Actual");
            varLbl.Text = tableComputedSum(hoursTable, "Variance");
            scrapLbl.Text = tableComputedSum(hoursTable, "Scrap");
            downtimeLbl.Text = tableComputedSum(hoursTable, "Downtime");

            //CART SUMMARY
            cartsLbl.Text = dataGridView2.RowCount.ToString();
            quantityLbl.Text = cartsTable.Compute("Sum(Quantity)", "").ToString();
            reworkLbl.Text = cartsTable.Select("Rework = True").Count().ToString();

            //CALC OEE
            double goal = Convert.ToInt32(goalLbl.Text);
            double actual = Convert.ToInt32(actualLbl.Text);
            double downtime = Convert.ToInt32(downtimeLbl.Text);
            double scrap = Convert.ToInt32(scrapLbl.Text);

            if(goal > 0)
            {
                performance = (actual / goal) * 100.0;
                availability = (1.0 - (downtime / 480.0)) * 100.0;

                perfLbl.Text = String.Format("{0:F2}%", performance);
                availLbl.Text = String.Format("{0:F2}%", availability);

                if (scrap > 0)
                {
                    quality = (1.0 - (scrap / actual)) * 100.0;
                    oee = ((quality / 100.0) * (performance / 100.0) * (availability / 100.0)) * 100.0;

                    qualLbl.Text = String.Format("{0:F2}%", quality);
                    oeeLbl.Text = String.Format("{0:F2}%", oee);
                }
                else
                {
                    qualLbl.Text = "0";
                    oeeLbl.Text = "0";
                }
            } else
            {
                perfLbl.Text = "0";
                availLbl.Text = "0";
                qualLbl.Text = "0";
                oeeLbl.Text = "0";
            }
        }

        /// <summary>
        /// GEN RANDOM 4
        /// </summary>
        private int GenerateCode()
        {
            int min = 1000;
            int max = 9999;

            Random rdm = new Random();
            return rdm.Next(min, max);
        }

        /// <summary>
        /// RETURNS THE WEEK OF CURRENT YEAR
        /// </summary>
        private int weekOfYearNum()
        {
            var date = DateTime.Now;
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            int weekOfYear = myCal.GetWeekOfYear(date, myCWR, myFirstDOW);
            return weekOfYear;
        }

        //BS function that returns 0 to avoid crashes
        private string tableComputedSum(DataTable table, string val)
        {
            string stringSum = table.Compute($"Sum({val})", string.Empty).ToString() ?? "0";

            if(stringSum == "" || stringSum == string.Empty){
                stringSum = "0";
            }

            return stringSum;
        }

        //Style of the column grid view headers
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
            AddHourPopUp addHourPopUp = new AddHourPopUp(goalHourTemp, 0, seqHourTemp, 0, 0, "", "");

            if(addHourPopUp.ShowDialog(this) == DialogResult.OK)
            {
                //Backup the temps
                goalHourTemp = addHourPopUp.goal;
                seqHourTemp = addHourPopUp.sequence;

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
            
            int shiftNum;
            string machine = Settings.Default["Machine"].ToString().ToUpper();
            SubmitPopUp submitPopUp = new SubmitPopUp(touch: touch);

            if (submitPopUp.ShowDialog(this) == DialogResult.OK)
            {
                shiftNum = submitPopUp.shift;

                var date = DateTime.Now;

                var workbook = new XLWorkbook();

                workbook.Worksheets.Add(hoursTable, "HRxHR Parts");
                workbook.Worksheets.Add(cartsTable, "HRxHR Carts");


                //Try for network
                try
                {
                    workbook.SaveAs($@"\\hail\Shared\Pace Board\PaceboardData\BV\Week-{weekOfYearNum() - 1}\{date.DayOfWeek}\Shift-{shiftNum}\SHIFT-{shiftNum}-{machine}-{date.ToString(@"MM-dd-yy")}-#ID-{GenerateCode().ToString()}.xlsx");
                    
                    //SQL TEST
                    using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=samtah\sqlexpress;Initial Catalog=PBET_DB;Integrated Security=True"))
                    {
                        sqlConnection.Open();
                        if (machine == "TEST" || machine == "MAINLINE" || machine == "SPOVEN 1" || machine == "SPOVEN 2" || machine == "SPOVEN 3")
                        {
                            for (int row = 0; row < hoursTable.Rows.Count; row++)
                            {
                                using (SqlCommand sqlCommand = new SqlCommand("spInsertPaintlineHours", sqlConnection))
                                {
                                    sqlCommand.CommandType = CommandType.StoredProcedure;
                                    sqlCommand.Parameters.Add("@SHIFT", SqlDbType.Int).Value = shiftNum;
                                    sqlCommand.Parameters.Add("@MACHINE", SqlDbType.VarChar).Value = machine;
                                    sqlCommand.Parameters.Add("@TIMESTAMP", SqlDbType.Date).Value = date.Date;
                                    sqlCommand.Parameters.Add("@HOUR", SqlDbType.VarChar).Value = hoursTable.Rows[row]["Hour"];
                                    sqlCommand.Parameters.Add("@GOAL", SqlDbType.Int).Value = hoursTable.Rows[row]["Goal"];
                                    sqlCommand.Parameters.Add("@ACTUAL", SqlDbType.Int).Value = hoursTable.Rows[row]["Actual"];
                                    sqlCommand.Parameters.Add("@VARIANCE", SqlDbType.Int).Value = hoursTable.Rows[row]["Variance"];
                                    sqlCommand.Parameters.Add("@PARTNUMBER", SqlDbType.VarChar).Value = hoursTable.Rows[row]["Part Number"];
                                    sqlCommand.Parameters.Add("@SCRAP", SqlDbType.Int).Value = hoursTable.Rows[row]["Scrap"];
                                    sqlCommand.Parameters.Add("@DOWNTIME", SqlDbType.Int).Value = hoursTable.Rows[row]["Downtime"];
                                    sqlCommand.Parameters.Add("@SCRAPREASON", SqlDbType.VarChar).Value = hoursTable.Rows[row]["Scrap Reason"];
                                    sqlCommand.Parameters.Add("@DOWNTIMEREASON", SqlDbType.VarChar).Value = hoursTable.Rows[row]["Downtime Reason"];
                                    sqlCommand.ExecuteNonQuery();
                                }
                            }

                            for (int row = 0; row < cartsTable.Rows.Count; row++)
                            {
                                using (SqlCommand sqlCommand = new SqlCommand("spInsertPaintlineCarts", sqlConnection))
                                {
                                    sqlCommand.CommandType = CommandType.StoredProcedure;
                                    sqlCommand.Parameters.Add("@SHIFT", SqlDbType.Int).Value = shiftNum;
                                    sqlCommand.Parameters.Add("@MACHINE", SqlDbType.VarChar).Value = machine;
                                    sqlCommand.Parameters.Add("@TIMESTAMP", SqlDbType.Date).Value = date.Date;
                                    sqlCommand.Parameters.Add("@TIMEIN", SqlDbType.VarChar).Value = cartsTable.Rows[row]["Time In"];
                                    sqlCommand.Parameters.Add("@PARTDESCRIPTION", SqlDbType.VarChar).Value = cartsTable.Rows[row]["Part Description"];
                                    sqlCommand.Parameters.Add("@PARTSEQUENCE", SqlDbType.VarChar).Value = cartsTable.Rows[row]["Part Sequence"];
                                    sqlCommand.Parameters.Add("@QUANTITY", SqlDbType.Int).Value = cartsTable.Rows[row]["Quantity"];
                                    sqlCommand.Parameters.Add("@COLOR", SqlDbType.VarChar).Value = cartsTable.Rows[row]["Color"];
                                    sqlCommand.Parameters.Add("@REWORK", SqlDbType.Bit).Value = Convert.ToByte(cartsTable.Rows[row]["Rework"]);
                                    sqlCommand.ExecuteNonQuery();
                                }

                            }
                        }
                        sqlConnection.Close();
                    }

                    //CLEAR EVERYTHING
                    //DONE WITH SHIFT
                    hoursTable.Clear();
                    cartsTable.Clear();
                    hoursTable.WriteXml("temp1.xml");
                    cartsTable.WriteXml("temp2.xml");

                    //RESET TEMPS
                    goalHourTemp = 0;
                    seqHourTemp = "";
                    colorCartTemp = "";
                }
                catch (Exception error)
                {
                    //FAIL
                    //LOCAL SAVE
                    MessageBox.Show("ERROR: Network down, please report to supervisor immediately. Data saved to local folder.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(error);

                    //ERROR SAVING
                    workbook.SaveAs($@"C:\PBET-Backup\Week-{weekOfYearNum() - 1}\{date.DayOfWeek}\Shift-{shiftNum}\SHIFT-{shiftNum}-{machine}-{date.ToString(@"MM-dd-yy")}-#ID-{GenerateCode().ToString()}.xlsx");
                }
            }
            else
            {
                //Cancel
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //UPDATE SUMMARY
            calcSummaryLabels();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //UPDATE SUMMARY
            calcSummaryLabels();
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //UPDATE SUMMARY
            calcSummaryLabels();
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //UPDATE SUMMARY
            calcSummaryLabels();
        }

        /// <summary>
        /// DELETE ROW BUTTONS
        /// </summary>
        private void deleteHourRowBtn_Click(object sender, EventArgs e)
        {
            deleteRowConfirm(dataGridView1);
        }
        private void deleteCartRowBtn_Click(object sender, EventArgs e)
        {
            deleteRowConfirm(dataGridView2);
        }

        /// <summary>
        /// EDIT ROWS IN HOUR DATA GRID
        /// </summary>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //This prevents users from editing the headers
            //in the columns which crashes the application
            if (e.RowIndex == -1)
                return;

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
            AddCartPopUp addCartPopUp = new AddCartPopUp("", "", 0, colorCartTemp, false);

            if (addCartPopUp.ShowDialog(this) == DialogResult.OK)
            {
                //Backup color temp
                colorCartTemp = addCartPopUp.partColor;  

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

        /// <summary>
        /// EDIT ROWS IN CART DATA GRID
        /// </summary>
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //This prevents users from editing the headers
            //in the columns which crashes the application
            if (e.RowIndex == -1)
                return;

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

        //This displays a confirmation box 
        //when the user deletes a row
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

        //This displays an admin panel
        //used for changing app settings
        //needs admin password
        private void adminPanelBtn_Click(object sender, EventArgs e)
        {
            AdminPopUp adminPopUp = new AdminPopUp(touch: touch);

            if (adminPopUp.ShowDialog(this) == DialogResult.OK)
            {
                machineNameLbl.Text = adminPopUp.machineName;
                touch = adminPopUp.touch;
            }
            else
            {
                //Cancel
            }
        }

        private void autoSaveTimer_Tick(object sender, EventArgs e)
        {
            //SAVE every 20min
            this.hoursTable.WriteXml("temp1.xml");
            this.cartsTable.WriteXml("temp2.xml");
        }
    }


}
