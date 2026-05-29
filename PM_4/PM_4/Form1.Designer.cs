namespace PM_4
{
    partial class frmMTCPS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtBoxContractorName = new TextBox();
            btnCalcNetPay = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblContractorName = new Label();
            lblHoursWorked = new Label();
            lblNumberOfDependents = new Label();
            txtBoxHoursWorked = new TextBox();
            txtBoxNumberOfDependents = new TextBox();
            lblGrossPay = new Label();
            lblPayeDeduction = new Label();
            lblUifDeduction = new Label();
            lblMembershipFee = new Label();
            lblTotalDeductions = new Label();
            lblNetPay = new Label();
            txtBoxGrossPay = new TextBox();
            txtBoxPayeDeduction = new TextBox();
            txtBoxUifDecudtion = new TextBox();
            txtBoxMembershipFee = new TextBox();
            txtBoxTotalDeductions = new TextBox();
            txtBoxNetPay = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(116, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mzansi Tech Contractors";
            // 
            // txtBoxContractorName
            // 
            txtBoxContractorName.Location = new Point(225, 124);
            txtBoxContractorName.Name = "txtBoxContractorName";
            txtBoxContractorName.Size = new Size(171, 23);
            txtBoxContractorName.TabIndex = 1;
            // 
            // btnCalcNetPay
            // 
            btnCalcNetPay.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCalcNetPay.Location = new Point(85, 347);
            btnCalcNetPay.Name = "btnCalcNetPay";
            btnCalcNetPay.Size = new Size(106, 39);
            btnCalcNetPay.TabIndex = 2;
            btnCalcNetPay.Text = "Calculate Net Pay";
            btnCalcNetPay.UseVisualStyleBackColor = true;
            btnCalcNetPay.Click += btnCalcNetPay_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnReset.Location = new Point(225, 347);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 39);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(321, 347);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 39);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblContractorName
            // 
            lblContractorName.AutoSize = true;
            lblContractorName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContractorName.ForeColor = SystemColors.ControlLightLight;
            lblContractorName.Location = new Point(67, 127);
            lblContractorName.Name = "lblContractorName";
            lblContractorName.Size = new Size(103, 15);
            lblContractorName.TabIndex = 5;
            lblContractorName.Text = "Contractor Name";
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoursWorked.ForeColor = SystemColors.ControlLightLight;
            lblHoursWorked.Location = new Point(67, 193);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(88, 15);
            lblHoursWorked.TabIndex = 6;
            lblHoursWorked.Text = "Hours Worked";
            // 
            // lblNumberOfDependents
            // 
            lblNumberOfDependents.AutoSize = true;
            lblNumberOfDependents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfDependents.ForeColor = SystemColors.ControlLightLight;
            lblNumberOfDependents.Location = new Point(67, 263);
            lblNumberOfDependents.Name = "lblNumberOfDependents";
            lblNumberOfDependents.Size = new Size(139, 15);
            lblNumberOfDependents.TabIndex = 7;
            lblNumberOfDependents.Text = "Number of Dependents";
            // 
            // txtBoxHoursWorked
            // 
            txtBoxHoursWorked.Location = new Point(225, 190);
            txtBoxHoursWorked.Name = "txtBoxHoursWorked";
            txtBoxHoursWorked.Size = new Size(171, 23);
            txtBoxHoursWorked.TabIndex = 8;
            // 
            // txtBoxNumberOfDependents
            // 
            txtBoxNumberOfDependents.Location = new Point(225, 260);
            txtBoxNumberOfDependents.Name = "txtBoxNumberOfDependents";
            txtBoxNumberOfDependents.Size = new Size(171, 23);
            txtBoxNumberOfDependents.TabIndex = 9;
            // 
            // lblGrossPay
            // 
            lblGrossPay.AutoSize = true;
            lblGrossPay.ForeColor = SystemColors.ControlLightLight;
            lblGrossPay.Location = new Point(496, 124);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(61, 15);
            lblGrossPay.TabIndex = 10;
            lblGrossPay.Text = "Gross Pay:";
            // 
            // lblPayeDeduction
            // 
            lblPayeDeduction.AutoSize = true;
            lblPayeDeduction.ForeColor = SystemColors.ControlLightLight;
            lblPayeDeduction.Location = new Point(463, 160);
            lblPayeDeduction.Name = "lblPayeDeduction";
            lblPayeDeduction.Size = new Size(94, 15);
            lblPayeDeduction.TabIndex = 11;
            lblPayeDeduction.Text = "PAYE Deduction:";
            // 
            // lblUifDeduction
            // 
            lblUifDeduction.AutoSize = true;
            lblUifDeduction.ForeColor = SystemColors.ControlLightLight;
            lblUifDeduction.Location = new Point(472, 193);
            lblUifDeduction.Name = "lblUifDeduction";
            lblUifDeduction.Size = new Size(85, 15);
            lblUifDeduction.TabIndex = 12;
            lblUifDeduction.Text = "UIF Deduction:";
            // 
            // lblMembershipFee
            // 
            lblMembershipFee.AutoSize = true;
            lblMembershipFee.ForeColor = SystemColors.ControlLightLight;
            lblMembershipFee.Location = new Point(459, 226);
            lblMembershipFee.Name = "lblMembershipFee";
            lblMembershipFee.Size = new Size(98, 15);
            lblMembershipFee.TabIndex = 13;
            lblMembershipFee.Text = "Membership Fee:";
            // 
            // lblTotalDeductions
            // 
            lblTotalDeductions.AutoSize = true;
            lblTotalDeductions.ForeColor = SystemColors.ControlLightLight;
            lblTotalDeductions.Location = new Point(458, 263);
            lblTotalDeductions.Name = "lblTotalDeductions";
            lblTotalDeductions.Size = new Size(99, 15);
            lblTotalDeductions.TabIndex = 14;
            lblTotalDeductions.Text = "Total Deductions:";
            // 
            // lblNetPay
            // 
            lblNetPay.AutoSize = true;
            lblNetPay.ForeColor = SystemColors.ControlLightLight;
            lblNetPay.Location = new Point(506, 302);
            lblNetPay.Name = "lblNetPay";
            lblNetPay.Size = new Size(51, 15);
            lblNetPay.TabIndex = 15;
            lblNetPay.Text = "Net Pay:";
            // 
            // txtBoxGrossPay
            // 
            txtBoxGrossPay.Location = new Point(593, 121);
            txtBoxGrossPay.Name = "txtBoxGrossPay";
            txtBoxGrossPay.Size = new Size(116, 23);
            txtBoxGrossPay.TabIndex = 16;
            // 
            // txtBoxPayeDeduction
            // 
            txtBoxPayeDeduction.Location = new Point(593, 157);
            txtBoxPayeDeduction.Name = "txtBoxPayeDeduction";
            txtBoxPayeDeduction.Size = new Size(116, 23);
            txtBoxPayeDeduction.TabIndex = 17;
            // 
            // txtBoxUifDecudtion
            // 
            txtBoxUifDecudtion.Location = new Point(593, 190);
            txtBoxUifDecudtion.Name = "txtBoxUifDecudtion";
            txtBoxUifDecudtion.Size = new Size(116, 23);
            txtBoxUifDecudtion.TabIndex = 18;
            // 
            // txtBoxMembershipFee
            // 
            txtBoxMembershipFee.Location = new Point(593, 223);
            txtBoxMembershipFee.Name = "txtBoxMembershipFee";
            txtBoxMembershipFee.Size = new Size(116, 23);
            txtBoxMembershipFee.TabIndex = 19;
            // 
            // txtBoxTotalDeductions
            // 
            txtBoxTotalDeductions.Location = new Point(593, 260);
            txtBoxTotalDeductions.Name = "txtBoxTotalDeductions";
            txtBoxTotalDeductions.Size = new Size(116, 23);
            txtBoxTotalDeductions.TabIndex = 20;
            // 
            // txtBoxNetPay
            // 
            txtBoxNetPay.Location = new Point(593, 299);
            txtBoxNetPay.Name = "txtBoxNetPay";
            txtBoxNetPay.Size = new Size(116, 23);
            txtBoxNetPay.TabIndex = 21;
            // 
            // frmMTCPS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxNetPay);
            Controls.Add(txtBoxTotalDeductions);
            Controls.Add(txtBoxMembershipFee);
            Controls.Add(txtBoxUifDecudtion);
            Controls.Add(txtBoxPayeDeduction);
            Controls.Add(txtBoxGrossPay);
            Controls.Add(lblNetPay);
            Controls.Add(lblTotalDeductions);
            Controls.Add(lblMembershipFee);
            Controls.Add(lblUifDeduction);
            Controls.Add(lblPayeDeduction);
            Controls.Add(lblGrossPay);
            Controls.Add(txtBoxNumberOfDependents);
            Controls.Add(txtBoxHoursWorked);
            Controls.Add(lblNumberOfDependents);
            Controls.Add(lblHoursWorked);
            Controls.Add(lblContractorName);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCalcNetPay);
            Controls.Add(txtBoxContractorName);
            Controls.Add(lblTitle);
            Name = "frmMTCPS";
            Text = "Mzansi Tech Contractors Payroll System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtBoxContractorName;
        private Button btnCalcNetPay;
        private Button btnReset;
        private Button btnExit;
        private Label lblContractorName;
        private Label lblHoursWorked;
        private Label lblNumberOfDependents;
        private TextBox txtBoxHoursWorked;
        private TextBox txtBoxNumberOfDependents;
        private Label lblGrossPay;
        private Label lblPayeDeduction;
        private Label lblUifDeduction;
        private Label lblMembershipFee;
        private Label lblTotalDeductions;
        private Label lblNetPay;
        private TextBox txtBoxGrossPay;
        private TextBox txtBoxPayeDeduction;
        private TextBox txtBoxUifDecudtion;
        private TextBox txtBoxMembershipFee;
        private TextBox txtBoxTotalDeductions;
        private TextBox txtBoxNetPay;
    }
}
