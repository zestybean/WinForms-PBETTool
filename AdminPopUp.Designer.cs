
namespace PBET
{
    partial class AdminPopUp
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
            this.label10 = new System.Windows.Forms.Label();
            this.machineTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.appTestingChkBox = new System.Windows.Forms.CheckBox();
            this.touchCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(117, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Machine:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // machineTxtBox
            // 
            this.machineTxtBox.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.machineTxtBox.Location = new System.Drawing.Point(223, 68);
            this.machineTxtBox.Name = "machineTxtBox";
            this.machineTxtBox.Size = new System.Drawing.Size(205, 33);
            this.machineTxtBox.TabIndex = 16;
            this.machineTxtBox.TextChanged += new System.EventHandler(this.machineTxtBox_TextChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.Tomato;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.cancelBtn.FlatAppearance.BorderSize = 3;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(10, 260);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(222, 47);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.submitBtn.FlatAppearance.BorderSize = 3;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(368, 260);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(222, 47);
            this.submitBtn.TabIndex = 18;
            this.submitBtn.Text = "Save";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(220, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Application Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(105, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passwordTxtBox.Location = new System.Drawing.Point(220, 199);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(205, 33);
            this.passwordTxtBox.TabIndex = 21;
            this.passwordTxtBox.UseSystemPasswordChar = true;
            this.passwordTxtBox.TextChanged += new System.EventHandler(this.passwordTxtBox_TextChanged);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(220, 184);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(37, 14);
            this.errorLbl.TabIndex = 22;
            this.errorLbl.Text = "label3";
            this.errorLbl.Visible = false;
            // 
            // appTestingChkBox
            // 
            this.appTestingChkBox.AutoSize = true;
            this.appTestingChkBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTestingChkBox.Location = new System.Drawing.Point(223, 107);
            this.appTestingChkBox.Name = "appTestingChkBox";
            this.appTestingChkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.appTestingChkBox.Size = new System.Drawing.Size(165, 23);
            this.appTestingChkBox.TabIndex = 24;
            this.appTestingChkBox.Text = ": Application Testing";
            this.appTestingChkBox.UseVisualStyleBackColor = true;
            // 
            // touchCheckBox
            // 
            this.touchCheckBox.AutoSize = true;
            this.touchCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touchCheckBox.Location = new System.Drawing.Point(223, 136);
            this.touchCheckBox.Name = "touchCheckBox";
            this.touchCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.touchCheckBox.Size = new System.Drawing.Size(136, 23);
            this.touchCheckBox.TabIndex = 25;
            this.touchCheckBox.Text = ": Touch Enabled";
            this.touchCheckBox.UseVisualStyleBackColor = true;
            this.touchCheckBox.CheckedChanged += new System.EventHandler(this.touchCheckBox_CheckedChanged);
            // 
            // AdminPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 317);
            this.ControlBox = false;
            this.Controls.Add(this.touchCheckBox);
            this.Controls.Add(this.appTestingChkBox);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.machineTxtBox);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox machineTxtBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.CheckBox appTestingChkBox;
        private System.Windows.Forms.CheckBox touchCheckBox;
    }
}