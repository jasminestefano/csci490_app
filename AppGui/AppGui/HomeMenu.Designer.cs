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
            this.logOutBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.bookTicketBtn = new System.Windows.Forms.Button();
            this.viewScheduleBtn = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.infoList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.infoList)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(0, 338);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(116, 109);
            this.logOutBtn.TabIndex = 0;
            this.logOutBtn.Text = "Logout";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.Location = new System.Drawing.Point(0, 226);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(116, 106);
            this.settingBtn.TabIndex = 1;
            this.settingBtn.Text = "Settings";
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // bookTicketBtn
            // 
            this.bookTicketBtn.Location = new System.Drawing.Point(0, 5);
            this.bookTicketBtn.Name = "bookTicketBtn";
            this.bookTicketBtn.Size = new System.Drawing.Size(116, 99);
            this.bookTicketBtn.TabIndex = 2;
            this.bookTicketBtn.Text = "Book Tickets";
            this.bookTicketBtn.UseVisualStyleBackColor = true;
            this.bookTicketBtn.Click += new System.EventHandler(this.bookTicketBtn_Click);
            // 
            // viewScheduleBtn
            // 
            this.viewScheduleBtn.Location = new System.Drawing.Point(0, 110);
            this.viewScheduleBtn.Name = "viewScheduleBtn";
            this.viewScheduleBtn.Size = new System.Drawing.Size(116, 110);
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
            this.infoList.Location = new System.Drawing.Point(122, 12);
            this.infoList.Name = "infoList";
            this.infoList.Size = new System.Drawing.Size(666, 426);
            this.infoList.TabIndex = 4;
            this.infoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infoList_CellContentClick);
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoList);
            this.Controls.Add(this.viewScheduleBtn);
            this.Controls.Add(this.bookTicketBtn);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.logOutBtn);
            this.Name = "HomeMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomeMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button bookTicketBtn;
        private System.Windows.Forms.Button viewScheduleBtn;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView infoList;
    }
}