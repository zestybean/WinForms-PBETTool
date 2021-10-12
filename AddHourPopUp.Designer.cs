
namespace PBET
{
    partial class AddHourPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.seqTxtBox = new System.Windows.Forms.TextBox();
            this.commentTxtBox = new System.Windows.Forms.TextBox();
            this.goalTxtBox = new System.Windows.Forms.NumericUpDown();
            this.actualTxtBox = new System.Windows.Forms.NumericUpDown();
            this.scrapTxtBox = new System.Windows.Forms.NumericUpDown();
            this.downTxtBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtReasonBtn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goalTxtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualTxtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrapTxtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downTxtBox)).BeginInit();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(563, 371);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(259, 54);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.Tomato;
            this.cancelBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(10, 371);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(259, 54);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // seqTxtBox
            // 
            this.seqTxtBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seqTxtBox.Location = new System.Drawing.Point(164, 69);
            this.seqTxtBox.Name = "seqTxtBox";
            this.seqTxtBox.Size = new System.Drawing.Size(239, 33);
            this.seqTxtBox.TabIndex = 3;
            // 
            // commentTxtBox
            // 
            this.commentTxtBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commentTxtBox.Location = new System.Drawing.Point(583, 70);
            this.commentTxtBox.Name = "commentTxtBox";
            this.commentTxtBox.Size = new System.Drawing.Size(239, 33);
            this.commentTxtBox.TabIndex = 6;
            // 
            // goalTxtBox
            // 
            this.goalTxtBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goalTxtBox.Location = new System.Drawing.Point(10, 72);
            this.goalTxtBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.goalTxtBox.Name = "goalTxtBox";
            this.goalTxtBox.Size = new System.Drawing.Size(71, 31);
            this.goalTxtBox.TabIndex = 1;
            this.goalTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // actualTxtBox
            // 
            this.actualTxtBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actualTxtBox.Location = new System.Drawing.Point(87, 72);
            this.actualTxtBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.actualTxtBox.Name = "actualTxtBox";
            this.actualTxtBox.Size = new System.Drawing.Size(71, 31);
            this.actualTxtBox.TabIndex = 2;
            this.actualTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scrapTxtBox
            // 
            this.scrapTxtBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scrapTxtBox.Location = new System.Drawing.Point(409, 70);
            this.scrapTxtBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.scrapTxtBox.Name = "scrapTxtBox";
            this.scrapTxtBox.Size = new System.Drawing.Size(71, 31);
            this.scrapTxtBox.TabIndex = 4;
            this.scrapTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // downTxtBox
            // 
            this.downTxtBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downTxtBox.Location = new System.Drawing.Point(486, 71);
            this.downTxtBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.downTxtBox.Name = "downTxtBox";
            this.downTxtBox.Size = new System.Drawing.Size(71, 31);
            this.downTxtBox.TabIndex = 5;
            this.downTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Goal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(164, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sequence/Part Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(409, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Scrap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(485, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 46);
            this.label5.TabIndex = 23;
            this.label5.Text = "Downtime\r\n(Minutes)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(583, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 46);
            this.label6.TabIndex = 24;
            this.label6.Text = "Comments/Downtime\r\nReason\r\n";
            // 
            // dtReasonBtn1
            // 
            this.dtReasonBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtReasonBtn1.BackColor = System.Drawing.SystemColors.Highlight;
            this.dtReasonBtn1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtReasonBtn1.ForeColor = System.Drawing.Color.White;
            this.dtReasonBtn1.Location = new System.Drawing.Point(288, 191);
            this.dtReasonBtn1.Name = "dtReasonBtn1";
            this.dtReasonBtn1.Size = new System.Drawing.Size(259, 54);
            this.dtReasonBtn1.TabIndex = 25;
            this.dtReasonBtn1.Text = "Submit\r\n";
            this.dtReasonBtn1.UseVisualStyleBackColor = false;
            // 
            // AddHourPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 437);
            this.ControlBox = false;
            this.Controls.Add(this.dtReasonBtn1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downTxtBox);
            this.Controls.Add(this.scrapTxtBox);
            this.Controls.Add(this.actualTxtBox);
            this.Controls.Add(this.goalTxtBox);
            this.Controls.Add(this.commentTxtBox);
            this.Controls.Add(this.seqTxtBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddHourPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Pace Board Hour";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.goalTxtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualTxtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrapTxtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downTxtBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox seqTxtBox;
        private System.Windows.Forms.TextBox commentTxtBox;
        private System.Windows.Forms.NumericUpDown goalTxtBox;
        private System.Windows.Forms.NumericUpDown actualTxtBox;
        private System.Windows.Forms.NumericUpDown scrapTxtBox;
        private System.Windows.Forms.NumericUpDown downTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dtReasonBtn1;
    }
}