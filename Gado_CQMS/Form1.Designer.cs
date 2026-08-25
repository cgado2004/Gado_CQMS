namespace Gado_CQMS
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cboPatientType = new System.Windows.Forms.ComboBox();
            this.btnAddToQueue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTicketHeader = new System.Windows.Forms.Label();
            this.lblQueueNumberHeader = new System.Windows.Forms.Label();
            this.lblPatientTypeHeader = new System.Windows.Forms.Label();
            this.lblPriorityHeader = new System.Windows.Forms.Label();
            this.lblQueueNumber = new System.Windows.Forms.Label();
            this.lblPatientType = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(70, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(660, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "CLINIC QUEUE MANAGEMENT SYSTEM";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelSubtitle.Location = new System.Drawing.Point(70, 55);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(660, 20);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Barangay Apokon, Tagum City, Davao del Norte";
            this.labelSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(60, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Patient Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(185, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 26);
            this.txtName.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(470, 110);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(60, 23);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age:";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(520, 108);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 26);
            this.txtAge.TabIndex = 5;
            // 
            // lblReason
            // 
            this.lblReason.Location = new System.Drawing.Point(60, 155);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(150, 23);
            this.lblReason.TabIndex = 6;
            this.lblReason.Text = "Reason for Visit:";
            this.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(185, 153);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(435, 26);
            this.txtReason.TabIndex = 7;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(60, 200);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(150, 23);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Patient Type:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboPatientType
            // 
            this.cboPatientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatientType.FormattingEnabled = true;
            this.cboPatientType.Items.AddRange(new object[] {
            "Emergency",
            "Senior",
            "Pregnant",
            "Regular"});
            this.cboPatientType.Location = new System.Drawing.Point(185, 198);
            this.cboPatientType.Name = "cboPatientType";
            this.cboPatientType.Size = new System.Drawing.Size(200, 28);
            this.cboPatientType.TabIndex = 9;
            // 
            // btnAddToQueue
            // 
            this.btnAddToQueue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddToQueue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToQueue.Location = new System.Drawing.Point(185, 250);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(180, 45);
            this.btnAddToQueue.TabIndex = 10;
            this.btnAddToQueue.Text = "ADD TO QUEUE";
            this.btnAddToQueue.UseVisualStyleBackColor = false;
            this.btnAddToQueue.Click += new System.EventHandler(this.btnAddToQueue_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(410, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 45);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTicketHeader
            // 
            this.lblTicketHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketHeader.Location = new System.Drawing.Point(60, 320);
            this.lblTicketHeader.Name = "lblTicketHeader";
            this.lblTicketHeader.Size = new System.Drawing.Size(680, 24);
            this.lblTicketHeader.TabIndex = 12;
            this.lblTicketHeader.Text = "QUEUE TICKET";
            this.lblTicketHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQueueNumberHeader
            // 
            this.lblQueueNumberHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueNumberHeader.Location = new System.Drawing.Point(60, 355);
            this.lblQueueNumberHeader.Name = "lblQueueNumberHeader";
            this.lblQueueNumberHeader.Size = new System.Drawing.Size(200, 23);
            this.lblQueueNumberHeader.TabIndex = 13;
            this.lblQueueNumberHeader.Text = "QUEUE NUMBER";
            this.lblQueueNumberHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPatientTypeHeader
            // 
            this.lblPatientTypeHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientTypeHeader.Location = new System.Drawing.Point(300, 355);
            this.lblPatientTypeHeader.Name = "lblPatientTypeHeader";
            this.lblPatientTypeHeader.Size = new System.Drawing.Size(200, 23);
            this.lblPatientTypeHeader.TabIndex = 14;
            this.lblPatientTypeHeader.Text = "PATIENT TYPE";
            this.lblPatientTypeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriorityHeader
            // 
            this.lblPriorityHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityHeader.Location = new System.Drawing.Point(540, 355);
            this.lblPriorityHeader.Name = "lblPriorityHeader";
            this.lblPriorityHeader.Size = new System.Drawing.Size(200, 23);
            this.lblPriorityHeader.TabIndex = 15;
            this.lblPriorityHeader.Text = "PRIORITY";
            this.lblPriorityHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueueNumber
            // 
            this.lblQueueNumber.BackColor = System.Drawing.Color.White;
            this.lblQueueNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQueueNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueNumber.Location = new System.Drawing.Point(60, 390);
            this.lblQueueNumber.Name = "lblQueueNumber";
            this.lblQueueNumber.Size = new System.Drawing.Size(200, 55);
            this.lblQueueNumber.TabIndex = 16;
            this.lblQueueNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPatientType
            // 
            this.lblPatientType.BackColor = System.Drawing.Color.White;
            this.lblPatientType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPatientType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientType.Location = new System.Drawing.Point(300, 390);
            this.lblPatientType.Name = "lblPatientType";
            this.lblPatientType.Size = new System.Drawing.Size(200, 55);
            this.lblPatientType.TabIndex = 17;
            this.lblPatientType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriority
            // 
            this.lblPriority.BackColor = System.Drawing.Color.White;
            this.lblPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(540, 390);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(200, 55);
            this.lblPriority.TabIndex = 18;
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblPatientType);
            this.Controls.Add(this.lblQueueNumber);
            this.Controls.Add(this.lblPriorityHeader);
            this.Controls.Add(this.lblPatientTypeHeader);
            this.Controls.Add(this.lblQueueNumberHeader);
            this.Controls.Add(this.lblTicketHeader);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddToQueue);
            this.Controls.Add(this.cboPatientType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Queue Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboPatientType;
        private System.Windows.Forms.Button btnAddToQueue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTicketHeader;
        private System.Windows.Forms.Label lblQueueNumberHeader;
        private System.Windows.Forms.Label lblPatientTypeHeader;
        private System.Windows.Forms.Label lblPriorityHeader;
        private System.Windows.Forms.Label lblQueueNumber;
        private System.Windows.Forms.Label lblPatientType;
        private System.Windows.Forms.Label lblPriority;
    }
}
