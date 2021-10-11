
namespace PBET
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHourBtn = new System.Windows.Forms.Button();
            this.addCartBtn = new System.Windows.Forms.Button();
            this.clearCartBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.downtimeLbl = new System.Windows.Forms.Label();
            this.scrapLbl = new System.Windows.Forms.Label();
            this.varLbl = new System.Windows.Forms.Label();
            this.actualLbl = new System.Windows.Forms.Label();
            this.goalLbl = new System.Windows.Forms.Label();
            this.hrLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(659, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1264, 81);
            this.label1.TabIndex = 2;
            this.label1.Text = "CK TECHNOLOGIES\r\nPACE BOARD ENTRY TOOL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 81);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBET.Properties.Resources.ckt_logo_white300;
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(12, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 507);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(677, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(547, 465);
            this.dataGridView2.TabIndex = 1;
            // 
            // Hour
            // 
            this.Hour.HeaderText = "Hour";
            this.Hour.Name = "Hour";
            // 
            // Goal
            // 
            this.Goal.HeaderText = "Goal";
            this.Goal.Name = "Goal";
            // 
            // Actual
            // 
            this.Actual.HeaderText = "Actual";
            this.Actual.Name = "Actual";
            // 
            // Variance
            // 
            this.Variance.HeaderText = "Variance";
            this.Variance.Name = "Variance";
            // 
            // addHourBtn
            // 
            this.addHourBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addHourBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addHourBtn.ForeColor = System.Drawing.Color.White;
            this.addHourBtn.Location = new System.Drawing.Point(12, 605);
            this.addHourBtn.Name = "addHourBtn";
            this.addHourBtn.Size = new System.Drawing.Size(673, 54);
            this.addHourBtn.TabIndex = 6;
            this.addHourBtn.Text = "Add Hour";
            this.addHourBtn.UseVisualStyleBackColor = false;
            this.addHourBtn.Click += new System.EventHandler(this.addHourBtn_Click);
            // 
            // addCartBtn
            // 
            this.addCartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addCartBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addCartBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addCartBtn.ForeColor = System.Drawing.Color.White;
            this.addCartBtn.Location = new System.Drawing.Point(691, 605);
            this.addCartBtn.Name = "addCartBtn";
            this.addCartBtn.Size = new System.Drawing.Size(259, 54);
            this.addCartBtn.TabIndex = 7;
            this.addCartBtn.Text = "Add Cart";
            this.addCartBtn.UseVisualStyleBackColor = false;
            // 
            // clearCartBtn
            // 
            this.clearCartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCartBtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.clearCartBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearCartBtn.ForeColor = System.Drawing.Color.White;
            this.clearCartBtn.Location = new System.Drawing.Point(993, 605);
            this.clearCartBtn.Name = "clearCartBtn";
            this.clearCartBtn.Size = new System.Drawing.Size(259, 54);
            this.clearCartBtn.TabIndex = 8;
            this.clearCartBtn.Text = "Clear Cart";
            this.clearCartBtn.UseVisualStyleBackColor = false;
            this.clearCartBtn.Click += new System.EventHandler(this.clearCartBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(993, 875);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(259, 54);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.downtimeLbl);
            this.panel3.Controls.Add(this.scrapLbl);
            this.panel3.Controls.Add(this.varLbl);
            this.panel3.Controls.Add(this.actualLbl);
            this.panel3.Controls.Add(this.goalLbl);
            this.panel3.Controls.Add(this.hrLbl);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 728);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 201);
            this.panel3.TabIndex = 2;
            // 
            // downtimeLbl
            // 
            this.downtimeLbl.AutoSize = true;
            this.downtimeLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.downtimeLbl.ForeColor = System.Drawing.Color.White;
            this.downtimeLbl.Location = new System.Drawing.Point(493, 79);
            this.downtimeLbl.Name = "downtimeLbl";
            this.downtimeLbl.Size = new System.Drawing.Size(19, 27);
            this.downtimeLbl.TabIndex = 12;
            this.downtimeLbl.Text = "-";
            this.downtimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrapLbl
            // 
            this.scrapLbl.AutoSize = true;
            this.scrapLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scrapLbl.ForeColor = System.Drawing.Color.White;
            this.scrapLbl.Location = new System.Drawing.Point(414, 79);
            this.scrapLbl.Name = "scrapLbl";
            this.scrapLbl.Size = new System.Drawing.Size(19, 27);
            this.scrapLbl.TabIndex = 11;
            this.scrapLbl.Text = "-";
            this.scrapLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // varLbl
            // 
            this.varLbl.AutoSize = true;
            this.varLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.varLbl.ForeColor = System.Drawing.Color.White;
            this.varLbl.Location = new System.Drawing.Point(302, 79);
            this.varLbl.Name = "varLbl";
            this.varLbl.Size = new System.Drawing.Size(19, 27);
            this.varLbl.TabIndex = 10;
            this.varLbl.Text = "-";
            this.varLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actualLbl
            // 
            this.actualLbl.AutoSize = true;
            this.actualLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.actualLbl.ForeColor = System.Drawing.Color.White;
            this.actualLbl.Location = new System.Drawing.Point(210, 79);
            this.actualLbl.Name = "actualLbl";
            this.actualLbl.Size = new System.Drawing.Size(19, 27);
            this.actualLbl.TabIndex = 9;
            this.actualLbl.Text = "-";
            this.actualLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goalLbl
            // 
            this.goalLbl.AutoSize = true;
            this.goalLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goalLbl.ForeColor = System.Drawing.Color.White;
            this.goalLbl.Location = new System.Drawing.Point(135, 79);
            this.goalLbl.Name = "goalLbl";
            this.goalLbl.Size = new System.Drawing.Size(19, 27);
            this.goalLbl.TabIndex = 8;
            this.goalLbl.Text = "-";
            this.goalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hrLbl
            // 
            this.hrLbl.AutoSize = true;
            this.hrLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hrLbl.ForeColor = System.Drawing.Color.White;
            this.hrLbl.Location = new System.Drawing.Point(50, 79);
            this.hrLbl.Name = "hrLbl";
            this.hrLbl.Size = new System.Drawing.Size(19, 27);
            this.hrLbl.TabIndex = 7;
            this.hrLbl.Text = "-";
            this.hrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(493, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Downtime";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(414, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Scrap";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(302, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Variance";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(210, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Actual";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(135, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Goal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hours";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Summary:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 941);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.clearCartBtn);
            this.Controls.Add(this.addCartBtn);
            this.Controls.Add(this.addHourBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variance;
        private System.Windows.Forms.Button addHourBtn;
        private System.Windows.Forms.Button addCartBtn;
        private System.Windows.Forms.Button clearCartBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label downtimeLbl;
        private System.Windows.Forms.Label scrapLbl;
        private System.Windows.Forms.Label varLbl;
        private System.Windows.Forms.Label actualLbl;
        private System.Windows.Forms.Label goalLbl;
        private System.Windows.Forms.Label hrLbl;
    }
}

