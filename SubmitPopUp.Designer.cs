
namespace PBET
{
    partial class SubmitPopUp
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
            this.label5 = new System.Windows.Forms.Label();
            this.opTxtBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.codeTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shiftTxtBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.codeLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTxtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(119, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 54;
            this.label5.Text = "Operator";
            // 
            // opTxtBox
            // 
            this.opTxtBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opTxtBox.Location = new System.Drawing.Point(119, 102);
            this.opTxtBox.Margin = new System.Windows.Forms.Padding(0);
            this.opTxtBox.Name = "opTxtBox";
            this.opTxtBox.Size = new System.Drawing.Size(239, 33);
            this.opTxtBox.TabIndex = 1;
            this.opTxtBox.TextChanged += new System.EventHandler(this.opTxtBox_TextChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.submitBtn.FlatAppearance.BorderSize = 3;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(315, 384);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(169, 54);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.Tomato;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.cancelBtn.FlatAppearance.BorderSize = 3;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(12, 384);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(169, 54);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // codeTxtBox
            // 
            this.codeTxtBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codeTxtBox.Location = new System.Drawing.Point(119, 308);
            this.codeTxtBox.Margin = new System.Windows.Forms.Padding(0);
            this.codeTxtBox.Name = "codeTxtBox";
            this.codeTxtBox.Size = new System.Drawing.Size(239, 33);
            this.codeTxtBox.TabIndex = 3;
            this.codeTxtBox.TextChanged += new System.EventHandler(this.codeTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "Enter Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "Shift";
            // 
            // shiftTxtBox
            // 
            this.shiftTxtBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shiftTxtBox.Location = new System.Drawing.Point(119, 171);
            this.shiftTxtBox.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.shiftTxtBox.Name = "shiftTxtBox";
            this.shiftTxtBox.Size = new System.Drawing.Size(71, 31);
            this.shiftTxtBox.TabIndex = 2;
            this.shiftTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shiftTxtBox.ValueChanged += new System.EventHandler(this.shiftTxtBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(119, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Code:";
            // 
            // codeLbl
            // 
            this.codeLbl.AutoSize = true;
            this.codeLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.codeLbl.Location = new System.Drawing.Point(174, 233);
            this.codeLbl.Margin = new System.Windows.Forms.Padding(0);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(50, 23);
            this.codeLbl.TabIndex = 67;
            this.codeLbl.Text = "1111";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = global::PBET.Properties.Resources.ckt_logo_white300;
            this.pictureBox1.Location = new System.Drawing.Point(-29, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(219, 292);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(131, 14);
            this.errorLbl.TabIndex = 69;
            this.errorLbl.Text = "Error: Code is not correct.";
            this.errorLbl.Visible = false;
            // 
            // SubmitPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.ControlBox = false;
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.codeLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shiftTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.opTxtBox);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubmitPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End of Shift Submit Form";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.shiftTxtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox opTxtBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox codeTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown shiftTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label errorLbl;
    }
}