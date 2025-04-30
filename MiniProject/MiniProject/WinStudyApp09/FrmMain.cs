using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WinStudyApp09
{
    public partial class FrmMain : Form
    {
        private DataTable table;

        public FrmMain()
        {
            InitializeComponent();
            InitializeBudgetTable();
        }

        private void InitializeBudgetTable()
        {
            table = new DataTable();
            table.Columns.Add("날짜", typeof(DateTime));
            table.Columns.Add("항목", typeof(string));
            table.Columns.Add("금액", typeof(int));
            table.Columns.Add("구분", typeof(string));
            dgvRecords.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("항목을 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAmount.Text, out int amount))
            {
                MessageBox.Show("금액을 숫자로 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            table.Rows.Add(dtpDate.Value.Date, txtDescription.Text, amount, cmbType.SelectedItem.ToString());
            UpdateSummary();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtDescription.Clear();
            txtAmount.Clear();
            cmbType.SelectedIndex = 0;
            txtDescription.Focus();
        }

        private void UpdateSummary()
        {
            int income = 0, expense = 0;

            foreach (DataRow row in table.Rows)
            {
                int amt = Convert.ToInt32(row["금액"]);
                string type = row["구분"].ToString();

                if (type == "수입")
                    income += amt;
                else if (type == "지출")
                    expense += amt;
            }

            lblIncome.Text = $"총 수입: {income}원";
            lblExpense.Text = $"총 지출: {expense}원";
            lblBalance.Text = $"잔액: {income - expense}원";
        }
    }
}
