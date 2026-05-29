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
            if (string.IsNullOrWhiteSpace(contractorName))
            {
                MessageBox.Show("Please enter the contractor's name.");
            }
            if (string.IsNullOrWhiteSpace(hoursWorked))
            {
                MessageBox.Show("Please enter the number of hours worked.");
            }
            else if (!double.TryParse(hoursWorked, out double hours))
            {
                MessageBox.Show("Please enter a valid number (letters and special characters are not allowed).");
            }
            else if (hours < 0)
            {
                MessageBox.Show("Please enter a positive number of hours worked.");
            }
            else if (string.IsNullOrWhiteSpace(numberOfDependents))
            {
                MessageBox.Show("Please enter the number of dependents.");
            }
            else if (!int.TryParse(numberOfDependents, out int dependents))
            {
                MessageBox.Show("Please enter a valid number (letters and special characters are not allowed).");
            }
            else if (dependents < 0)
            {
                MessageBox.Show("Please enter a positive number of dependents.");
            }
            else
            {
                //Calculating the hourly rateh
                //Hourly Rate = R150.00
                double hourlyRateDbl = 150.00;
                //Calculating the gross pay
                //Gross Pay = Hours Worked * Hourly Rate
                double grossPayDbl = Convert.ToDouble(hoursWorked) * hourlyRateDbl;
                //Calculating the PAYE deduction
                //(Grosspay - (gross pay * 0.0575 * Number of Dependents)) * 25%
                double payeDeductionDbl = (grossPayDbl - (grossPayDbl * 0.0575 * Convert.ToDouble(numberOfDependents))) * 0.25;
                //Calculating the UIF deduction
                //1% of the gross pay
                double uifDeductionDbl = grossPayDbl * 0.01;
                //Calculating the membership fee
                //13% of gross pay
                double membershipFeeDbl = grossPayDbl * 0.13;
                //Calculating the total deductions
                //Total Deductions = PAYE Deduction + UIF Deduction + Membership Fee
                double totalDeductionsDbl = payeDeductionDbl + uifDeductionDbl + membershipFeeDbl;
                //Calculating the net pay
                //Net Pay = Gross Pay - Total Deductions
                double netPayDbl = grossPayDbl - totalDeductionsDbl;
                //Display the calculated values in the text boxes
                txtBoxGrossPay.Text = grossPayDbl.ToString("C", new CultureInfo("en-ZA"));
                txtBoxPayeDeduction.Text = payeDeductionDbl.ToString("C", new CultureInfo("en-ZA"));
                txtBoxUifDecudtion.Text = uifDeductionDbl.ToString("C", new CultureInfo("en-ZA"));
                txtBoxMembershipFee.Text = membershipFeeDbl.ToString("C", new CultureInfo("en-ZA"));
                txtBoxTotalDeductions.Text = totalDeductionsDbl.ToString("C", new CultureInfo("en-ZA"));
                txtBoxNetPay.Text = netPayDbl.ToString("C", new CultureInfo("en-ZA"));
            }
        }
    }
}