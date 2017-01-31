namespace EPIC_Leave_form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Dc_print = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.datecurrent = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datereturn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // datecurrent
            // 
            this.datecurrent.CustomFormat = "dd/MM/yyyy";
            this.datecurrent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datecurrent.Location = new System.Drawing.Point(90, 57);
            this.datecurrent.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.datecurrent.Name = "datecurrent";
            this.datecurrent.Size = new System.Drawing.Size(87, 20);
            this.datecurrent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            // 
            // txtdep
            // 
            this.txtdep.Location = new System.Drawing.Point(90, 125);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(167, 20);
            this.txtdep.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(90, 23);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(453, 20);
            this.txtname.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsub);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txttp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.datecurrent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdep);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 203);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General information";
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(90, 167);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(453, 20);
            this.txtsub.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Substitute";
            // 
            // txttp
            // 
            this.txttp.Location = new System.Drawing.Point(90, 91);
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(167, 20);
            this.txttp.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "T.P Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdays);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbtype);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leave information";
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(107, 57);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(100, 20);
            this.txtdays.TabIndex = 7;
            this.txtdays.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type of leave";
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Casual",
            "Medical",
            "No pay",
            "Other",
            "Annual",
            "Lieu"});
            this.cmbtype.Location = new System.Drawing.Point(107, 23);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(121, 21);
            this.cmbtype.TabIndex = 6;
            this.cmbtype.Text = "Casual";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datereturn);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.datefrom);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(269, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Leave duration";
            // 
            // datereturn
            // 
            this.datereturn.CustomFormat = "dd/MM/yyyy";
            this.datereturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datereturn.Location = new System.Drawing.Point(76, 57);
            this.datereturn.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.datereturn.Name = "datereturn";
            this.datereturn.Size = new System.Drawing.Size(87, 20);
            this.datereturn.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Return";
            // 
            // datefrom
            // 
            this.datefrom.CustomFormat = "dd/MM/yyyy";
            this.datefrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datefrom.Location = new System.Drawing.Point(76, 24);
            this.datefrom.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(87, 20);
            this.datefrom.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "From";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Print leave form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPIC Leave form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument Dc_print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DateTimePicker datecurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker datereturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

