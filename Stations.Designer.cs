namespace ProjFinal
{
    partial class Stations
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
            this.components = new System.ComponentModel.Container();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.locTB = new System.Windows.Forms.Label();
            this.statNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statIDTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(260, 346);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 61);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(179, 346);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 61);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(98, 346);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 61);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 261);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(278, 26);
            this.textBox3.TabIndex = 19;
            this.textBox3.Leave += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // locTB
            // 
            this.locTB.AutoSize = true;
            this.locTB.Location = new System.Drawing.Point(24, 238);
            this.locTB.Name = "locTB";
            this.locTB.Size = new System.Drawing.Size(70, 20);
            this.locTB.TabIndex = 18;
            this.locTB.Text = "Location";
            // 
            // statNameTB
            // 
            this.statNameTB.Location = new System.Drawing.Point(28, 197);
            this.statNameTB.Name = "statNameTB";
            this.statNameTB.Size = new System.Drawing.Size(278, 26);
            this.statNameTB.TabIndex = 17;
            this.statNameTB.Leave += new System.EventHandler(this.statNameTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "StationName";
            // 
            // statIDTB
            // 
            this.statIDTB.Location = new System.Drawing.Point(28, 132);
            this.statIDTB.Name = "statIDTB";
            this.statIDTB.Size = new System.Drawing.Size(278, 26);
            this.statIDTB.TabIndex = 15;
            this.statIDTB.Leave += new System.EventHandler(this.statIDTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "StationID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Manage Stations";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 63);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Train Station Management System (Admin)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 15);
            this.panel2.TabIndex = 22;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjFinal.Properties.Resources.train_icon1;
            this.pictureBox2.Location = new System.Drawing.Point(245, 434);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 71);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjFinal.Properties.Resources.schedule_icon_again;
            this.pictureBox1.Location = new System.Drawing.Point(10, 434);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 71);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Manage Train";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Manage Schedule";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(545, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(460, 457);
            this.dataGridView1.TabIndex = 34;
            // 
            // Stations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.locTB);
            this.Controls.Add(this.statNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statIDTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Stations";
            this.Text = "Stations";
            this.Load += new System.EventHandler(this.Stations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label locTB;
        private System.Windows.Forms.TextBox statNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox statIDTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}