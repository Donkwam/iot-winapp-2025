namespace WinStudyApp09
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label lblBalance;

        /// <summary>
        /// 리소스를 정리합니다.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dtpDate = new DateTimePicker();
            txtDescription = new TextBox();
            txtAmount = new TextBox();
            cmbType = new ComboBox();
            btnAdd = new Button();
            dgvRecords = new DataGridView();
            lblIncome = new Label();
            lblExpense = new Label();
            lblBalance = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(20, 20);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 60);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "항목";
            txtDescription.Size = new Size(200, 23);
            txtDescription.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(240, 60);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "금액";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 2;
            // 
            // cmbType
            // 
            cmbType.Items.AddRange(new object[] { "수입", "지출" });
            cmbType.Location = new Point(360, 60);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(80, 23);
            cmbType.TabIndex = 3;
            cmbType.Text = "수입";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(460, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(60, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "추가";
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.Location = new Point(20, 100);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.ScrollBars = ScrollBars.Vertical;
            dgvRecords.Size = new Size(500, 200);
            dgvRecords.TabIndex = 5;
            // 
            // lblIncome
            // 
            lblIncome.Location = new Point(20, 310);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(150, 23);
            lblIncome.TabIndex = 6;
            lblIncome.Text = "총 수입: 0원";
            // 
            // lblExpense
            // 
            lblExpense.Location = new Point(180, 310);
            lblExpense.Name = "lblExpense";
            lblExpense.Size = new Size(150, 23);
            lblExpense.TabIndex = 7;
            lblExpense.Text = "총 지출: 0원";
            // 
            // lblBalance
            // 
            lblBalance.Location = new Point(340, 310);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(180, 23);
            lblBalance.TabIndex = 8;
            lblBalance.Text = "잔액: 0원";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 360);
            Controls.Add(dtpDate);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(cmbType);
            Controls.Add(btnAdd);
            Controls.Add(dgvRecords);
            Controls.Add(lblIncome);
            Controls.Add(lblExpense);
            Controls.Add(lblBalance);
            Name = "FrmMain";
            Text = "가계부";
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
