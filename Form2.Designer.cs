namespace MainProj
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.createTrain_TrainIDtb = new System.Windows.Forms.TextBox();
            this.createTrain_TrainNotb = new System.Windows.Forms.TextBox();
            this.createTrain_DeptTimetb = new System.Windows.Forms.TextBox();
            this.createTrain_ArrTimetb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createTrain_DeptStaIDtb = new System.Windows.Forms.TextBox();
            this.createTrain_ArrStaIDtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create New Train";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create New Station";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 72);
            this.button3.TabIndex = 2;
            this.button3.Text = "Create New Schedule";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // createTrain_TrainIDtb
            // 
            this.createTrain_TrainIDtb.Location = new System.Drawing.Point(171, 111);
            this.createTrain_TrainIDtb.Name = "createTrain_TrainIDtb";
            this.createTrain_TrainIDtb.Size = new System.Drawing.Size(100, 26);
            this.createTrain_TrainIDtb.TabIndex = 3;
            this.createTrain_TrainIDtb.Leave += new System.EventHandler(this.createTrain_TrainIDtb_TextChanged);
            // 
            // createTrain_TrainNotb
            // 
            this.createTrain_TrainNotb.Location = new System.Drawing.Point(299, 111);
            this.createTrain_TrainNotb.Name = "createTrain_TrainNotb";
            this.createTrain_TrainNotb.Size = new System.Drawing.Size(100, 26);
            this.createTrain_TrainNotb.TabIndex = 4;
            this.createTrain_TrainNotb.Leave += new System.EventHandler(this.createTrain_TrainNotb_TextChanged);
            // 
            // createTrain_DeptTimetb
            // 
            this.createTrain_DeptTimetb.Location = new System.Drawing.Point(813, 111);
            this.createTrain_DeptTimetb.Name = "createTrain_DeptTimetb";
            this.createTrain_DeptTimetb.Size = new System.Drawing.Size(100, 26);
            this.createTrain_DeptTimetb.TabIndex = 7;
            this.createTrain_DeptTimetb.Leave += new System.EventHandler(this.createTrain_DeptTimetb_TextChanged);
            // 
            // createTrain_ArrTimetb
            // 
            this.createTrain_ArrTimetb.Location = new System.Drawing.Point(968, 111);
            this.createTrain_ArrTimetb.Name = "createTrain_ArrTimetb";
            this.createTrain_ArrTimetb.Size = new System.Drawing.Size(100, 26);
            this.createTrain_ArrTimetb.TabIndex = 8;
            this.createTrain_ArrTimetb.Leave += new System.EventHandler(this.createTrain_ArrTimetb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "TrainID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "TrainNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "DepartureStationID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "ArrivalStationID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(809, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "DepartureTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(964, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "ArrivalTime";
            // 
            // createTrain_DeptStaIDtb
            // 
            this.createTrain_DeptStaIDtb.Location = new System.Drawing.Point(449, 111);
            this.createTrain_DeptStaIDtb.Name = "createTrain_DeptStaIDtb";
            this.createTrain_DeptStaIDtb.Size = new System.Drawing.Size(145, 26);
            this.createTrain_DeptStaIDtb.TabIndex = 15;
            this.createTrain_DeptStaIDtb.Leave += new System.EventHandler(this.createTrain_DeptStaIDtb_TextChanged);
            // 
            // createTrain_ArrStaIDtb
            // 
            this.createTrain_ArrStaIDtb.Location = new System.Drawing.Point(645, 111);
            this.createTrain_ArrStaIDtb.Name = "createTrain_ArrStaIDtb";
            this.createTrain_ArrStaIDtb.Size = new System.Drawing.Size(116, 26);
            this.createTrain_ArrStaIDtb.TabIndex = 16;
            this.createTrain_ArrStaIDtb.Leave += new System.EventHandler(this.createTrain_ArrStaIDtb_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.createTrain_ArrStaIDtb);
            this.Controls.Add(this.createTrain_DeptStaIDtb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createTrain_ArrTimetb);
            this.Controls.Add(this.createTrain_DeptTimetb);
            this.Controls.Add(this.createTrain_TrainNotb);
            this.Controls.Add(this.createTrain_TrainIDtb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox createTrain_TrainIDtb;
        private System.Windows.Forms.TextBox createTrain_TrainNotb;
        private System.Windows.Forms.TextBox createTrain_DeptTimetb;
        private System.Windows.Forms.TextBox createTrain_ArrTimetb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox createTrain_DeptStaIDtb;
        private System.Windows.Forms.TextBox createTrain_ArrStaIDtb;
    }
}