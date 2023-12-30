namespace Login
{
    partial class DiagnosisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiagnosisIDtxt = new System.Windows.Forms.TextBox();
            this.PatientNametxt = new System.Windows.Forms.TextBox();
            this.PatIdbox = new System.Windows.Forms.ComboBox();
            this.Symptomstxt = new System.Windows.Forms.TextBox();
            this.Diagnosistxt = new System.Windows.Forms.TextBox();
            this.Medicinestxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.diagnosisSummary = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Diagnosislbl = new System.Windows.Forms.Label();
            this.Medicineslbl = new System.Windows.Forms.Label();
            this.Symptomslbl = new System.Windows.Forms.Label();
            this.Patientlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Patient_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Patient_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Symptoms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diagnosis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medicines = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Printbtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.diagnosisSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 149);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(468, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNA HOSPITAL SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(588, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIAGNOSIS";
            // 
            // DiagnosisIDtxt
            // 
            this.DiagnosisIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DiagnosisIDtxt.Location = new System.Drawing.Point(98, 224);
            this.DiagnosisIDtxt.Multiline = true;
            this.DiagnosisIDtxt.Name = "DiagnosisIDtxt";
            this.DiagnosisIDtxt.Size = new System.Drawing.Size(178, 30);
            this.DiagnosisIDtxt.TabIndex = 6;
            this.DiagnosisIDtxt.Text = "DiagnosisId";
            // 
            // PatientNametxt
            // 
            this.PatientNametxt.Enabled = false;
            this.PatientNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatientNametxt.Location = new System.Drawing.Point(98, 345);
            this.PatientNametxt.Multiline = true;
            this.PatientNametxt.Name = "PatientNametxt";
            this.PatientNametxt.Size = new System.Drawing.Size(178, 30);
            this.PatientNametxt.TabIndex = 7;
            this.PatientNametxt.Text = "PatientName";
            // 
            // PatIdbox
            // 
            this.PatIdbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatIdbox.FormattingEnabled = true;
            this.PatIdbox.Location = new System.Drawing.Point(98, 286);
            this.PatIdbox.Name = "PatIdbox";
            this.PatIdbox.Size = new System.Drawing.Size(178, 28);
            this.PatIdbox.TabIndex = 8;
            this.PatIdbox.Text = "PatientId";
            this.PatIdbox.SelectionChangeCommitted += new System.EventHandler(this.PatIdbox_SelectionChangeCommitted);
            // 
            // Symptomstxt
            // 
            this.Symptomstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Symptomstxt.Location = new System.Drawing.Point(364, 224);
            this.Symptomstxt.Multiline = true;
            this.Symptomstxt.Name = "Symptomstxt";
            this.Symptomstxt.Size = new System.Drawing.Size(178, 30);
            this.Symptomstxt.TabIndex = 9;
            this.Symptomstxt.Text = "Symptoms";
            // 
            // Diagnosistxt
            // 
            this.Diagnosistxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Diagnosistxt.Location = new System.Drawing.Point(364, 286);
            this.Diagnosistxt.Multiline = true;
            this.Diagnosistxt.Name = "Diagnosistxt";
            this.Diagnosistxt.Size = new System.Drawing.Size(178, 30);
            this.Diagnosistxt.TabIndex = 10;
            this.Diagnosistxt.Text = "Diagnosis";
            // 
            // Medicinestxt
            // 
            this.Medicinestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Medicinestxt.Location = new System.Drawing.Point(364, 345);
            this.Medicinestxt.Multiline = true;
            this.Medicinestxt.Name = "Medicinestxt";
            this.Medicinestxt.Size = new System.Drawing.Size(178, 30);
            this.Medicinestxt.TabIndex = 11;
            this.Medicinestxt.Text = "Medicines";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(156, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(335, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(156, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(335, 508);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 36);
            this.button4.TabIndex = 15;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // diagnosisSummary
            // 
            this.diagnosisSummary.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.diagnosisSummary.Controls.Add(this.label8);
            this.diagnosisSummary.Controls.Add(this.label7);
            this.diagnosisSummary.Controls.Add(this.label6);
            this.diagnosisSummary.Controls.Add(this.label5);
            this.diagnosisSummary.Controls.Add(this.label4);
            this.diagnosisSummary.Controls.Add(this.Diagnosislbl);
            this.diagnosisSummary.Controls.Add(this.Medicineslbl);
            this.diagnosisSummary.Controls.Add(this.Symptomslbl);
            this.diagnosisSummary.Controls.Add(this.Patientlbl);
            this.diagnosisSummary.Controls.Add(this.label3);
            this.diagnosisSummary.Location = new System.Drawing.Point(605, 165);
            this.diagnosisSummary.Name = "diagnosisSummary";
            this.diagnosisSummary.Size = new System.Drawing.Size(753, 497);
            this.diagnosisSummary.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(269, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "DNA Hospital";
            // 
            // Diagnosislbl
            // 
            this.Diagnosislbl.AutoSize = true;
            this.Diagnosislbl.BackColor = System.Drawing.Color.Transparent;
            this.Diagnosislbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Diagnosislbl.ForeColor = System.Drawing.Color.Black;
            this.Diagnosislbl.Location = new System.Drawing.Point(253, 323);
            this.Diagnosislbl.Name = "Diagnosislbl";
            this.Diagnosislbl.Size = new System.Drawing.Size(129, 29);
            this.Diagnosislbl.TabIndex = 49;
            this.Diagnosislbl.Text = "Diagnosis";
            // 
            // Medicineslbl
            // 
            this.Medicineslbl.AutoSize = true;
            this.Medicineslbl.BackColor = System.Drawing.Color.Transparent;
            this.Medicineslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Medicineslbl.ForeColor = System.Drawing.Color.Black;
            this.Medicineslbl.Location = new System.Drawing.Point(251, 258);
            this.Medicineslbl.Name = "Medicineslbl";
            this.Medicineslbl.Size = new System.Drawing.Size(133, 29);
            this.Medicineslbl.TabIndex = 48;
            this.Medicineslbl.Text = "Medicines";
            // 
            // Symptomslbl
            // 
            this.Symptomslbl.AutoSize = true;
            this.Symptomslbl.BackColor = System.Drawing.Color.Transparent;
            this.Symptomslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Symptomslbl.ForeColor = System.Drawing.Color.Black;
            this.Symptomslbl.Location = new System.Drawing.Point(249, 192);
            this.Symptomslbl.Name = "Symptomslbl";
            this.Symptomslbl.Size = new System.Drawing.Size(134, 29);
            this.Symptomslbl.TabIndex = 47;
            this.Symptomslbl.Text = "Symptoms";
            // 
            // Patientlbl
            // 
            this.Patientlbl.AutoSize = true;
            this.Patientlbl.BackColor = System.Drawing.Color.Transparent;
            this.Patientlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Patientlbl.ForeColor = System.Drawing.Color.Black;
            this.Patientlbl.Location = new System.Drawing.Point(249, 123);
            this.Patientlbl.Name = "Patientlbl";
            this.Patientlbl.Size = new System.Drawing.Size(163, 29);
            this.Patientlbl.TabIndex = 46;
            this.Patientlbl.Text = "PatientName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(158, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 36);
            this.label3.TabIndex = 45;
            this.label3.Text = "DIAGNOSIS SUMMARY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(544, 746);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(325, 42);
            this.label11.TabIndex = 38;
            this.label11.Text = "DIAGNOSIS LIST";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Patient_ID,
            this.Patient_Name,
            this.Symptoms,
            this.Diagnosis,
            this.Medicines});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(98, 791);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1259, 283);
            this.listView1.TabIndex = 39;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 77;
            // 
            // Patient_ID
            // 
            this.Patient_ID.Text = "Patient_ID";
            this.Patient_ID.Width = 82;
            // 
            // Patient_Name
            // 
            this.Patient_Name.Text = "Patient_Name";
            this.Patient_Name.Width = 234;
            // 
            // Symptoms
            // 
            this.Symptoms.Text = "Symptoms";
            this.Symptoms.Width = 228;
            // 
            // Diagnosis
            // 
            this.Diagnosis.Text = "Diagnosis";
            this.Diagnosis.Width = 252;
            // 
            // Medicines
            // 
            this.Medicines.Text = "Medicines";
            this.Medicines.Width = 264;
            // 
            // Printbtn
            // 
            this.Printbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Printbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Printbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Printbtn.Location = new System.Drawing.Point(897, 668);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(120, 36);
            this.Printbtn.TabIndex = 40;
            this.Printbtn.Text = "Print";
            this.Printbtn.UseVisualStyleBackColor = false;
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(55, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 29);
            this.label8.TabIndex = 56;
            this.label8.Text = "Diagnosis :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(55, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 29);
            this.label7.TabIndex = 55;
            this.label7.Text = "Medicines :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(55, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 54;
            this.label6.Text = "Symptoms :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(55, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Patient Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1430, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 36);
            this.label9.TabIndex = 53;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1516, 1102);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.diagnosisSummary);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Medicinestxt);
            this.Controls.Add(this.Diagnosistxt);
            this.Controls.Add(this.Symptomstxt);
            this.Controls.Add(this.PatIdbox);
            this.Controls.Add(this.PatientNametxt);
            this.Controls.Add(this.DiagnosisIDtxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.diagnosisSummary.ResumeLayout(false);
            this.diagnosisSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DiagnosisIDtxt;
        private System.Windows.Forms.TextBox PatientNametxt;
        private System.Windows.Forms.ComboBox PatIdbox;
        private System.Windows.Forms.TextBox Symptomstxt;
        private System.Windows.Forms.TextBox Diagnosistxt;
        private System.Windows.Forms.TextBox Medicinestxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel diagnosisSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Diagnosislbl;
        private System.Windows.Forms.Label Medicineslbl;
        private System.Windows.Forms.Label Symptomslbl;
        private System.Windows.Forms.Label Patientlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Patient_ID;
        private System.Windows.Forms.ColumnHeader Patient_Name;
        private System.Windows.Forms.ColumnHeader Symptoms;
        private System.Windows.Forms.ColumnHeader Diagnosis;
        private System.Windows.Forms.ColumnHeader Medicines;
        private System.Windows.Forms.Button Printbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
    }
}