using System;
using System.Windows.Forms;

namespace Gado_CQMS
{
    public partial class Form1 : Form
    {
        // Form-level queue counter. All patient types share ONE queue sequence.
        private int queueCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // ADD TO QUEUE process
        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            // 1. Validate that a Patient Type is selected.
            if (cboPatientType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Patient Type.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2. Validate Age: not empty, must be a number, and must be greater than 0.
            int age;
            if (string.IsNullOrWhiteSpace(txtAge.Text) ||
                !int.TryParse(txtAge.Text, out age) ||
                age <= 0)
            {
                MessageBox.Show("Please enter a valid age.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 3. Generate the next queue number from the single shared sequence.
            queueCounter = queueCounter + 1;
            string queueNumber = "Q" + queueCounter.ToString("D3");

            // 4. Determine the priority from the selected Patient Type.
            string patientType = cboPatientType.SelectedItem.ToString();
            string priority;

            if (patientType == "Emergency")
            {
                priority = "EMERGENCY";
            }
            else if (patientType == "Senior")
            {
                priority = "SENIOR PRIORITY";
            }
            else if (patientType == "Pregnant")
            {
                priority = "PRIORITY";
            }
            else
            {
                priority = "REGULAR";
            }

            // 5. Output the queue number, patient type, and priority.
            lblQueueNumber.Text = queueNumber;
            lblPatientType.Text = patientType;
            lblPriority.Text = priority;
        }

        // CLEAR process
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtReason.Clear();
            cboPatientType.SelectedIndex = -1;

            lblQueueNumber.Text = "";
            lblPatientType.Text = "";
            lblPriority.Text = "";
        }
    }
}
