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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lotOutBtn
            // 
            this.lotOutBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotOutBtn.ForeColor = System.Drawing.Color.Red;
            this.lotOutBtn.Location = new System.Drawing.Point(0, 3);
            this.lotOutBtn.Name = "lotOutBtn";
            this.lotOutBtn.Size = new System.Drawing.Size(161, 48);
            this.lotOutBtn.TabIndex = 0;
            this.lotOutBtn.Text = "Logout";
            this.lotOutBtn.UseVisualStyleBackColor = true;
            this.lotOutBtn.Click += new System.EventHandler(this.lotOutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.Red;
            this.settingsBtn.Location = new System.Drawing.Point(0, 3);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(161, 48);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
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
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(235, 111);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(152, 29);
            this.comboBox.TabIndex = 4;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(167, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Select a train number to book";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BookBtn
            // 
            this.BookBtn.BackColor = System.Drawing.Color.Red;
            this.BookBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.BookBtn.Location = new System.Drawing.Point(235, 160);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(152, 40);
            this.BookBtn.TabIndex = 6;
            this.BookBtn.Text = "Book";
            this.BookBtn.UseVisualStyleBackColor = false;
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
            this.bookingInfo.Location = new System.Drawing.Point(445, 54);
            this.bookingInfo.Name = "bookingInfo";
            this.bookingInfo.Size = new System.Drawing.Size(352, 384);
            this.bookingInfo.TabIndex = 7;
            this.bookingInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkBooking
            // 
            this.checkBooking.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBooking.Location = new System.Drawing.Point(235, 220);
            this.checkBooking.Name = "checkBooking";
            this.checkBooking.Size = new System.Drawing.Size(152, 26);
            this.checkBooking.TabIndex = 8;
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
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(161, 88);
            this.panel1.TabIndex = 0;
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
            this.panel4.Controls.Add(this.settingsBtn);
            this.panel4.Location = new System.Drawing.Point(3, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 54);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lotOutBtn);
            this.panel5.Location = new System.Drawing.Point(3, 277);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 54);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(167, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(633, 54);
            this.panel6.TabIndex = 10;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.checkBooking);
            this.Controls.Add(this.bookingInfo);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Booking";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
    }
}