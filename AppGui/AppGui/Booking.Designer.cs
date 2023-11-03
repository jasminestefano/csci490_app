namespace AppGui
{
    partial class Booking
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
            this.lotOutBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.bookTicketBtn = new System.Windows.Forms.Button();
            this.viewScheduleBtn = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BookBtn = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.bookingInfo = new System.Windows.Forms.DataGridView();
            this.checkBooking = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lotOutBtn
            // 
            this.lotOutBtn.Location = new System.Drawing.Point(0, 338);
            this.lotOutBtn.Name = "lotOutBtn";
            this.lotOutBtn.Size = new System.Drawing.Size(116, 109);
            this.lotOutBtn.TabIndex = 0;
            this.lotOutBtn.Text = "Logout";
            this.lotOutBtn.UseVisualStyleBackColor = true;
            this.lotOutBtn.Click += new System.EventHandler(this.lotOutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(0, 226);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(116, 106);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
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
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(135, 71);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(123, 21);
            this.comboBox.TabIndex = 4;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Select a train number to book";
            // 
            // BookBtn
            // 
            this.BookBtn.Location = new System.Drawing.Point(264, 69);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(75, 23);
            this.BookBtn.TabIndex = 6;
            this.BookBtn.Text = "Book";
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // bookingInfo
            // 
            this.bookingInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingInfo.Location = new System.Drawing.Point(451, 12);
            this.bookingInfo.Name = "bookingInfo";
            this.bookingInfo.Size = new System.Drawing.Size(337, 408);
            this.bookingInfo.TabIndex = 7;
            this.bookingInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkBooking
            // 
            this.checkBooking.Location = new System.Drawing.Point(345, 71);
            this.checkBooking.Name = "checkBooking";
            this.checkBooking.Size = new System.Drawing.Size(100, 20);
            this.checkBooking.TabIndex = 8;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBooking);
            this.Controls.Add(this.bookingInfo);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.viewScheduleBtn);
            this.Controls.Add(this.bookTicketBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.lotOutBtn);
            this.Name = "Booking";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lotOutBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button bookTicketBtn;
        private System.Windows.Forms.Button viewScheduleBtn;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BookBtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridView bookingInfo;
        private System.Windows.Forms.TextBox checkBooking;
    }
}