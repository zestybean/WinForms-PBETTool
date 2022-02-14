
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.areaNameLbl = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.adminPanelBtn = new System.Windows.Forms.Button();
            this.machineNameLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteHourRowBtn = new System.Windows.Forms.Button();
            this.deleteCartRowBtn = new System.Windows.Forms.Button();
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
            this.btnLamp = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.downtimeLbl = new System.Windows.Forms.Label();
            this.scrapLbl = new System.Windows.Forms.Label();
            this.varLbl = new System.Windows.Forms.Label();
            this.actualLbl = new System.Windows.Forms.Label();
            this.goalLbl = new System.Windows.Forms.Label();
            this.hrLbl = new System.Windows.Forms.Label();
            this.oeeLbl = new System.Windows.Forms.Label();
            this.qualLbl = new System.Windows.Forms.Label();
            this.perfLbl = new System.Windows.Forms.Label();
            this.availLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reworkLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.cartsLbl = new System.Windows.Forms.Label();
            this.autoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.performanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 38;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 18);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(965, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1483, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "CK TECHNOLOGIES\r\nPACE BOARD ENTRY TOOL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.areaNameLbl);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.adminPanelBtn);
            this.panel1.Controls.Add(this.machineNameLbl);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1483, 70);
            this.panel1.TabIndex = 4;
            // 
            // areaNameLbl
            // 
            this.areaNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.areaNameLbl.AutoSize = true;
            this.areaNameLbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaNameLbl.ForeColor = System.Drawing.Color.White;
            this.areaNameLbl.Location = new System.Drawing.Point(1234, 7);
            this.areaNameLbl.Name = "areaNameLbl";
            this.areaNameLbl.Size = new System.Drawing.Size(53, 29);
            this.areaNameLbl.TabIndex = 17;
            this.areaNameLbl.Text = "Test";
            this.areaNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1173, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 29);
            this.label18.TabIndex = 16;
            this.label18.Text = "Area:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminPanelBtn
            // 
            this.adminPanelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminPanelBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.adminPanelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminPanelBtn.BackgroundImage")));
            this.adminPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminPanelBtn.Location = new System.Drawing.Point(1444, 7);
            this.adminPanelBtn.Name = "adminPanelBtn";
            this.adminPanelBtn.Size = new System.Drawing.Size(37, 33);
            this.adminPanelBtn.TabIndex = 2;
            this.adminPanelBtn.UseVisualStyleBackColor = false;
            this.adminPanelBtn.Click += new System.EventHandler(this.adminPanelBtn_Click);
            // 
            // machineNameLbl
            // 
            this.machineNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.machineNameLbl.AutoSize = true;
            this.machineNameLbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineNameLbl.ForeColor = System.Drawing.Color.White;
            this.machineNameLbl.Location = new System.Drawing.Point(1234, 39);
            this.machineNameLbl.Name = "machineNameLbl";
            this.machineNameLbl.Size = new System.Drawing.Size(53, 29);
            this.machineNameLbl.TabIndex = 15;
            this.machineNameLbl.Text = "Test";
            this.machineNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1134, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "Machine:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBET.Properties.Resources.ckt_logo_white300;
            this.pictureBox1.Location = new System.Drawing.Point(0, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 61);
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
            this.panel2.Controls.Add(this.deleteHourRowBtn);
            this.panel2.Controls.Add(this.deleteCartRowBtn);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(10, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1463, 440);
            this.panel2.TabIndex = 5;
            // 
            // deleteHourRowBtn
            // 
            this.deleteHourRowBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteHourRowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteHourRowBtn.BackgroundImage")));
            this.deleteHourRowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteHourRowBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.deleteHourRowBtn.FlatAppearance.BorderSize = 2;
            this.deleteHourRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteHourRowBtn.Location = new System.Drawing.Point(12, 18);
            this.deleteHourRowBtn.Name = "deleteHourRowBtn";
            this.deleteHourRowBtn.Size = new System.Drawing.Size(38, 38);
            this.deleteHourRowBtn.TabIndex = 17;
            this.deleteHourRowBtn.UseVisualStyleBackColor = false;
            this.deleteHourRowBtn.Click += new System.EventHandler(this.deleteHourRowBtn_Click);
            // 
            // deleteCartRowBtn
            // 
            this.deleteCartRowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCartRowBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteCartRowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteCartRowBtn.BackgroundImage")));
            this.deleteCartRowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteCartRowBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.deleteCartRowBtn.FlatAppearance.BorderSize = 2;
            this.deleteCartRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCartRowBtn.Location = new System.Drawing.Point(982, 18);
            this.deleteCartRowBtn.Name = "deleteCartRowBtn";
            this.deleteCartRowBtn.Size = new System.Drawing.Size(38, 38);
            this.deleteCartRowBtn.TabIndex = 16;
            this.deleteCartRowBtn.UseVisualStyleBackColor = false;
            this.deleteCartRowBtn.Click += new System.EventHandler(this.deleteCartRowBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(980, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(469, 403);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded);
            this.dataGridView2.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView2_RowsRemoved);
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
            this.addHourBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addHourBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.addHourBtn.FlatAppearance.BorderSize = 3;
            this.addHourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addHourBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.addHourBtn.ForeColor = System.Drawing.Color.White;
            this.addHourBtn.Location = new System.Drawing.Point(10, 524);
            this.addHourBtn.Name = "addHourBtn";
            this.addHourBtn.Size = new System.Drawing.Size(577, 47);
            this.addHourBtn.TabIndex = 6;
            this.addHourBtn.Text = "Add Hour";
            this.addHourBtn.UseVisualStyleBackColor = false;
            this.addHourBtn.Click += new System.EventHandler(this.addHourBtn_Click);
            // 
            // addCartBtn
            // 
            this.addCartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addCartBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addCartBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.addCartBtn.FlatAppearance.BorderSize = 3;
            this.addCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCartBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.addCartBtn.ForeColor = System.Drawing.Color.White;
            this.addCartBtn.Location = new System.Drawing.Point(992, 524);
            this.addCartBtn.Name = "addCartBtn";
            this.addCartBtn.Size = new System.Drawing.Size(222, 47);
            this.addCartBtn.TabIndex = 7;
            this.addCartBtn.Text = "Add Cart";
            this.addCartBtn.UseVisualStyleBackColor = false;
            this.addCartBtn.Click += new System.EventHandler(this.addCartBtn_Click);
            // 
            // clearCartBtn
            // 
            this.clearCartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCartBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.clearCartBtn.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.clearCartBtn.FlatAppearance.BorderSize = 3;
            this.clearCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearCartBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.clearCartBtn.ForeColor = System.Drawing.Color.White;
            this.clearCartBtn.Location = new System.Drawing.Point(1251, 524);
            this.clearCartBtn.Name = "clearCartBtn";
            this.clearCartBtn.Size = new System.Drawing.Size(222, 47);
            this.clearCartBtn.TabIndex = 8;
            this.clearCartBtn.Text = "Clear Cart";
            this.clearCartBtn.UseVisualStyleBackColor = false;
            this.clearCartBtn.Click += new System.EventHandler(this.clearCartBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.submitBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.submitBtn.FlatAppearance.BorderSize = 3;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(1251, 841);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(222, 47);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnLamp);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.downtimeLbl);
            this.panel3.Controls.Add(this.scrapLbl);
            this.panel3.Controls.Add(this.varLbl);
            this.panel3.Controls.Add(this.actualLbl);
            this.panel3.Controls.Add(this.goalLbl);
            this.panel3.Controls.Add(this.hrLbl);
            this.panel3.Controls.Add(this.oeeLbl);
            this.panel3.Controls.Add(this.qualLbl);
            this.panel3.Controls.Add(this.perfLbl);
            this.panel3.Controls.Add(this.availLbl);
            this.panel3.Location = new System.Drawing.Point(10, 576);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 228);
            this.panel3.TabIndex = 2;
            // 
            // btnLamp
            // 
            this.btnLamp.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLamp.Enabled = false;
            this.btnLamp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamp.ForeColor = System.Drawing.Color.White;
            this.btnLamp.Location = new System.Drawing.Point(3, 196);
            this.btnLamp.Name = "btnLamp";
            this.btnLamp.Size = new System.Drawing.Size(569, 27);
            this.btnLamp.TabIndex = 21;
            this.btnLamp.Text = "Production: Good";
            this.btnLamp.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(482, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 27);
            this.label17.TabIndex = 16;
            this.label17.Text = "OEE";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(339, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 27);
            this.label16.TabIndex = 15;
            this.label16.Text = "Quality";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(180, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 27);
            this.label15.TabIndex = 14;
            this.label15.Text = "Performance";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(43, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 27);
            this.label12.TabIndex = 13;
            this.label12.Text = "Availability";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(423, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Downtime";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(355, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Scrap";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(259, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Variance";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(180, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Actual";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(116, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Goal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hours";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hour Summary:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downtimeLbl
            // 
            this.downtimeLbl.AutoSize = true;
            this.downtimeLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.downtimeLbl.ForeColor = System.Drawing.Color.White;
            this.downtimeLbl.Location = new System.Drawing.Point(423, 68);
            this.downtimeLbl.Name = "downtimeLbl";
            this.downtimeLbl.Size = new System.Drawing.Size(23, 27);
            this.downtimeLbl.TabIndex = 12;
            this.downtimeLbl.Text = "0";
            this.downtimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrapLbl
            // 
            this.scrapLbl.AutoSize = true;
            this.scrapLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.scrapLbl.ForeColor = System.Drawing.Color.White;
            this.scrapLbl.Location = new System.Drawing.Point(355, 68);
            this.scrapLbl.Name = "scrapLbl";
            this.scrapLbl.Size = new System.Drawing.Size(23, 27);
            this.scrapLbl.TabIndex = 11;
            this.scrapLbl.Text = "0";
            this.scrapLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // varLbl
            // 
            this.varLbl.AutoSize = true;
            this.varLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.varLbl.ForeColor = System.Drawing.Color.White;
            this.varLbl.Location = new System.Drawing.Point(259, 68);
            this.varLbl.Name = "varLbl";
            this.varLbl.Size = new System.Drawing.Size(23, 27);
            this.varLbl.TabIndex = 10;
            this.varLbl.Text = "0";
            this.varLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actualLbl
            // 
            this.actualLbl.AutoSize = true;
            this.actualLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.actualLbl.ForeColor = System.Drawing.Color.White;
            this.actualLbl.Location = new System.Drawing.Point(180, 68);
            this.actualLbl.Name = "actualLbl";
            this.actualLbl.Size = new System.Drawing.Size(23, 27);
            this.actualLbl.TabIndex = 9;
            this.actualLbl.Text = "0";
            this.actualLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goalLbl
            // 
            this.goalLbl.AutoSize = true;
            this.goalLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.goalLbl.ForeColor = System.Drawing.Color.White;
            this.goalLbl.Location = new System.Drawing.Point(116, 68);
            this.goalLbl.Name = "goalLbl";
            this.goalLbl.Size = new System.Drawing.Size(23, 27);
            this.goalLbl.TabIndex = 8;
            this.goalLbl.Text = "0";
            this.goalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hrLbl
            // 
            this.hrLbl.AutoSize = true;
            this.hrLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.hrLbl.ForeColor = System.Drawing.Color.White;
            this.hrLbl.Location = new System.Drawing.Point(43, 68);
            this.hrLbl.Name = "hrLbl";
            this.hrLbl.Size = new System.Drawing.Size(23, 27);
            this.hrLbl.TabIndex = 7;
            this.hrLbl.Text = "0";
            this.hrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oeeLbl
            // 
            this.oeeLbl.AutoSize = true;
            this.oeeLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.oeeLbl.ForeColor = System.Drawing.Color.White;
            this.oeeLbl.Location = new System.Drawing.Point(482, 155);
            this.oeeLbl.Name = "oeeLbl";
            this.oeeLbl.Size = new System.Drawing.Size(23, 27);
            this.oeeLbl.TabIndex = 20;
            this.oeeLbl.Text = "0";
            this.oeeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qualLbl
            // 
            this.qualLbl.AutoSize = true;
            this.qualLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.qualLbl.ForeColor = System.Drawing.Color.White;
            this.qualLbl.Location = new System.Drawing.Point(339, 155);
            this.qualLbl.Name = "qualLbl";
            this.qualLbl.Size = new System.Drawing.Size(23, 27);
            this.qualLbl.TabIndex = 19;
            this.qualLbl.Text = "0";
            this.qualLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // perfLbl
            // 
            this.perfLbl.AutoSize = true;
            this.perfLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.perfLbl.ForeColor = System.Drawing.Color.White;
            this.perfLbl.Location = new System.Drawing.Point(180, 155);
            this.perfLbl.Name = "perfLbl";
            this.perfLbl.Size = new System.Drawing.Size(23, 27);
            this.perfLbl.TabIndex = 18;
            this.perfLbl.Text = "0";
            this.perfLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availLbl
            // 
            this.availLbl.AutoSize = true;
            this.availLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.availLbl.ForeColor = System.Drawing.Color.White;
            this.availLbl.Location = new System.Drawing.Point(43, 155);
            this.availLbl.Name = "availLbl";
            this.availLbl.Size = new System.Drawing.Size(23, 27);
            this.availLbl.TabIndex = 17;
            this.availLbl.Text = "0";
            this.availLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.reworkLbl);
            this.panel4.Controls.Add(this.quantityLbl);
            this.panel4.Controls.Add(this.cartsLbl);
            this.panel4.Location = new System.Drawing.Point(992, 576);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(481, 121);
            this.panel4.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(300, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 27);
            this.label14.TabIndex = 15;
            this.label14.Text = "Rework";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(201, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 27);
            this.label13.TabIndex = 14;
            this.label13.Text = "Quantity";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(119, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 27);
            this.label11.TabIndex = 13;
            this.label11.Text = "Carts";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cart Summary:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reworkLbl
            // 
            this.reworkLbl.AutoSize = true;
            this.reworkLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.reworkLbl.ForeColor = System.Drawing.Color.White;
            this.reworkLbl.Location = new System.Drawing.Point(300, 68);
            this.reworkLbl.Name = "reworkLbl";
            this.reworkLbl.Size = new System.Drawing.Size(23, 27);
            this.reworkLbl.TabIndex = 17;
            this.reworkLbl.Text = "0";
            this.reworkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.quantityLbl.ForeColor = System.Drawing.Color.White;
            this.quantityLbl.Location = new System.Drawing.Point(201, 68);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(23, 27);
            this.quantityLbl.TabIndex = 16;
            this.quantityLbl.Text = "0";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartsLbl
            // 
            this.cartsLbl.AutoSize = true;
            this.cartsLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.cartsLbl.ForeColor = System.Drawing.Color.White;
            this.cartsLbl.Location = new System.Drawing.Point(119, 68);
            this.cartsLbl.Name = "cartsLbl";
            this.cartsLbl.Size = new System.Drawing.Size(23, 27);
            this.cartsLbl.TabIndex = 13;
            this.cartsLbl.Text = "0";
            this.cartsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoSaveTimer
            // 
            this.autoSaveTimer.Interval = 5000;
            this.autoSaveTimer.Tick += new System.EventHandler(this.autoSaveTimer_Tick);
            // 
            // performanceChart
            // 
            this.performanceChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.performanceChart.BackColor = System.Drawing.SystemColors.Highlight;
            this.performanceChart.BorderlineColor = System.Drawing.Color.Black;
            this.performanceChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DottedGrid;
            chartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.BackImageTransparentColor = System.Drawing.SystemColors.GradientActiveCaption;
            chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.performanceChart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.performanceChart.Legends.Add(legend1);
            this.performanceChart.Location = new System.Drawing.Point(593, 524);
            this.performanceChart.Name = "performanceChart";
            this.performanceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Goal";
            this.performanceChart.Series.Add(series1);
            this.performanceChart.Size = new System.Drawing.Size(393, 280);
            this.performanceChart.TabIndex = 11;
            this.performanceChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Performance Metric";
            this.performanceChart.Titles.Add(title1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 899);
            this.Controls.Add(this.performanceChart);
            this.Controls.Add(this.panel4);
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
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceChart)).EndInit();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label machineNameLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button adminPanelBtn;
        private System.Windows.Forms.Button deleteCartRowBtn;
        private System.Windows.Forms.Button deleteHourRowBtn;
        private System.Windows.Forms.Label cartsLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label reworkLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label oeeLbl;
        private System.Windows.Forms.Label qualLbl;
        private System.Windows.Forms.Label perfLbl;
        private System.Windows.Forms.Label availLbl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer autoSaveTimer;
        private System.Windows.Forms.Label areaNameLbl;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnLamp;
        private System.Windows.Forms.DataVisualization.Charting.Chart performanceChart;
    }
}

