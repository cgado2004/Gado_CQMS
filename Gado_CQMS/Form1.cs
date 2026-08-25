using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gado_CQMS
{
    public partial class Form1 : Form
    {
        private int queueCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboPatientType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Patient Type." ,"Validation Error.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAge.Text) ||
                    !int.TryParse(txtAge.Text, out int age)
                    || age <= 0) 
                    {
                MessageBox.Show("Please enter a valid age.", "Validation Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            queueCounter++;
            string queueNumber ="Q" + queueCounter.ToString("D3");

            string priority = "";
            string PatientType = cboPatientType.SelectedItem.ToString();

            switch (PatientType)
            {
                case "Emergency":
                    priority = "EMERGENCY";
                    break;
                case "Senior":
                    priority = "SENIOR";
                    break;
                case "Pregnant":
                    priority = "PRIORITY";
                    break;
                case "Regular":
                    priority = "REGULAR";
                    break;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtReason.Clear();
            cboPatientType.SelectedIndex = -1;

            lblPatientType.Text = "";
            lblQueueNumber.Text = "";
            lblPriority.Text = "";
        }
    }
}
