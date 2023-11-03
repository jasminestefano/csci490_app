namespace AppGui
{
    partial class HomeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMenu));
            this.logOutBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.bookTicketBtn = new System.Windows.Forms.Button();
            this.viewScheduleBtn = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.infoList = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.infoList)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.Red;
            this.logOutBtn.Location = new System.Drawing.Point(-3, 3);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(164, 48);
            this.logOutBtn.TabIndex = 0;
            this.logOutBtn.Text = "Logout";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.Color.Red;
            this.settingBtn.Location = new System.Drawing.Point(0, 3);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(161, 48);
            this.settingBtn.TabIndex = 1;
            this.settingBtn.Text = "Settings";
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // bookTicketBtn
            // 
            this.bookTicketBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTicketBtn.ForeColor = System.Drawing.Color.Red;
            this.bookTicketBtn.Location = new System.Drawing.Point(0, 3);
            this.bookTicketBtn.Name = "bookTicketBtn";
            this.bookTicketBtn.Size = new System.Drawing.Size(161, 48);
            this.bookTicketBtn.TabIndex = 2;
            this.bookTicketBtn.Text = "Book Tickets";
            this.bookTicketBtn.UseVisualStyleBackColor = true;
            this.bookTicketBtn.Click += new System.EventHandler(this.bookTicketBtn_Click);
            // 
            // viewScheduleBtn
            // 
            this.viewScheduleBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewScheduleBtn.ForeColor = System.Drawing.Color.Red;
            this.viewScheduleBtn.Location = new System.Drawing.Point(0, 3);
            this.viewScheduleBtn.Name = "viewScheduleBtn";
            this.viewScheduleBtn.Size = new System.Drawing.Size(161, 48);
            this.viewScheduleBtn.TabIndex = 3;
            this.viewScheduleBtn.Text = "View Schedule";
            this.viewScheduleBtn.UseVisualStyleBackColor = true;
            this.viewScheduleBtn.Click += new System.EventHandler(this.viewScheduleBtn_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // infoList
            // 
            this.infoList.AllowUserToOrderColumns = true;
            this.infoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoList.Location = new System.Drawing.Point(173, 60);
            this.infoList.Name = "infoList";
            this.infoList.Size = new System.Drawing.Size(615, 378);
            this.infoList.TabIndex = 4;
            this.infoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infoList_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(167, 450);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bookTicketBtn);
            this.panel2.Location = new System.Drawing.Point(3, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 54);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.viewScheduleBtn);
            this.panel3.Location = new System.Drawing.Point(3, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 54);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.settingBtn);
            this.panel4.Location = new System.Drawing.Point(3, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 54);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.logOutBtn);
            this.panel5.Location = new System.Drawing.Point(3, 277);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 54);
            this.panel5.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 88);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(167, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(633, 54);
            this.panel6.TabIndex = 11;
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.infoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomeMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoList)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button bookTicketBtn;
        private System.Windows.Forms.Button viewScheduleBtn;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView infoList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
    }
}