using System.Globalization;

namespace PM_4
{
    public partial class frmMTCPS : Form
    {
        public frmMTCPS()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Add Function to close the pragram
            this.Close();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clear the text boxes for the input values
            txtBoxContractorName.Clear();
            txtBoxHoursWorked.Clear();
            txtBoxNumberOfDependents.Clear();
            // Clear the text boxes for the calculated values
            txtBoxGrossPay.Clear();
            txtBoxPayeDeduction.Clear();
            txtBoxUifDecudtion.Clear();
            txtBoxMembershipFee.Clear();
            txtBoxTotalDeductions.Clear();
            txtBoxNetPay.Clear();
        }
        private void btnCalcNetPay_Click(object sender, EventArgs e)
        {
            //Declare variables for the input values
            string contractorName = txtBoxContractorName.Text;
            string hoursWorked = txtBoxHoursWorked.Text;
            string numberOfDependents = txtBoxNumberOfDependents.Text;
            //Check if any of the input values are empty and display a message box if they are
            // Validate contractor name
            if (string.IsNullOrWhiteSpace(contractorName))
            {
                MessageBox.Show("Please enter the contractor's name.");
                return;
            }
            else if (!contractorName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Please enter a valid name (only letters and spaces are allowed).");
                return;
            }

            // Validate hours worked
            if (string.IsNullOrWhiteSpace(hoursWorked))
            {
                MessageBox.Show("Please enter the number of hours worked.");
                return;
            }
            else if (!double.TryParse(hoursWorked, out double hours))
            {
                MessageBox.Show("Please enter a valid number (letters and special characters are not allowed).");
                return;
            }
            else if (hours < 0)
            {
                MessageBox.Show("Please enter a positive number of hours worked.");
                return;
            }

            // Validate number of dependents
            if (string.IsNullOrWhiteSpace(numberOfDependents))
            {
                MessageBox.Show("Please enter the number of dependents.");
                return;
            }
            else if (!int.TryParse(numberOfDependents, out int dependents))
            {
                MessageBox.Show("Please enter a valid number (letters and special characters are not allowed).");
                return;
            }
            else if (dependents < 0)
            {
                MessageBox.Show("Please enter a positive number of dependents.");
                return;
            }

            // All validations passed - Calculate payroll
            double hourlyRateDbl = 150.00;
            double grossPayDbl = double.Parse(hoursWorked) * hourlyRateDbl;
            double payeDeductionDbl = (grossPayDbl - (grossPayDbl * 0.0575 * Convert.ToDouble(numberOfDependents))) * 0.25;
            double uifDeductionDbl = grossPayDbl * 0.01;
            double membershipFeeDbl = grossPayDbl * 0.13;
            double totalDeductionsDbl = payeDeductionDbl + uifDeductionDbl + membershipFeeDbl;
            double netPayDbl = grossPayDbl - totalDeductionsDbl;

            // Display the calculated values in the text boxes
            txtBoxGrossPay.Text = grossPayDbl.ToString("C", new CultureInfo("en-ZA"));
            txtBoxPayeDeduction.Text = payeDeductionDbl.ToString("C", new CultureInfo("en-ZA"));
            txtBoxUifDecudtion.Text = uifDeductionDbl.ToString("C", new CultureInfo("en-ZA"));
            txtBoxMembershipFee.Text = membershipFeeDbl.ToString("C", new CultureInfo("en-ZA"));
            txtBoxTotalDeductions.Text = totalDeductionsDbl.ToString("C", new CultureInfo("en-ZA"));
            txtBoxNetPay.Text = netPayDbl.ToString("C", new CultureInfo("en-ZA"));
        }
    }
}