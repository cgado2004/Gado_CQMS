namespace Gado_CQMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.cboPatientType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddToQueue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblQueueNumber = new System.Windows.Forms.TextBox();
            this.lblPatientType = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLINIC QUEUE MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(54, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(308, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(424, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reason";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 98);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(349, 98);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(56, 20);
            this.txtAge.TabIndex = 5;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(484, 98);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(294, 20);
            this.txtReason.TabIndex = 6;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // cboPatientType
            // 
            this.cboPatientType.FormattingEnabled = true;
            this.cboPatientType.Items.AddRange(new object[] {
            "EMERGENCY",
            "SENIOR PRIORITY",
            "PRIORITY",
            "REGULAR"});
            this.cboPatientType.Location = new System.Drawing.Point(114, 132);
            this.cboPatientType.Name = "cboPatientType";
            this.cboPatientType.Size = new System.Drawing.Size(121, 21);
            this.cboPatientType.TabIndex = 7;
            this.cboPatientType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // btnAddToQueue
            // 
            this.btnAddToQueue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddToQueue.Location = new System.Drawing.Point(168, 201);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(100, 48);
            this.btnAddToQueue.TabIndex = 9;
            this.btnAddToQueue.Text = "ADD";
            this.btnAddToQueue.UseVisualStyleBackColor = false;
            this.btnAddToQueue.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(503, 201);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 48);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblQueueNumber
            // 
            this.lblQueueNumber.Location = new System.Drawing.Point(81, 291);
            this.lblQueueNumber.Multiline = true;
            this.lblQueueNumber.Name = "lblQueueNumber";
            this.lblQueueNumber.Size = new System.Drawing.Size(154, 38);
            this.lblQueueNumber.TabIndex = 11;
            // 
            // lblPatientType
            // 
            this.lblPatientType.Location = new System.Drawing.Point(300, 291);
            this.lblPatientType.Multiline = true;
            this.lblPatientType.Name = "lblPatientType";
            this.lblPatientType.Size = new System.Drawing.Size(154, 38);
            this.lblPatientType.TabIndex = 12;
            // 
            // lblPriority
            // 
            this.lblPriority.Location = new System.Drawing.Point(547, 291);
            this.lblPriority.Multiline = true;
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(154, 38);
            this.lblPriority.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(111, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Queue Number";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(327, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "PatientType";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(579, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Priority";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblPatientType);
            this.Controls.Add(this.lblQueueNumber);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddToQueue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboPatientType);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.ComboBox cboPatientType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddToQueue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox lblQueueNumber;
        private System.Windows.Forms.TextBox lblPatientType;
        private System.Windows.Forms.TextBox lblPriority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

