using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace cnrkgksmsrj
{
    public partial class FrmMain : Form
    {
        private List<Transaction> transactions = new();
        private DataTable table = new();

        public FrmMain()
        {
            InitializeComponent();
            btnAdd.Click += btnAdd_Click;
            MstRoad.Click += MstRoad_Click;
            InitializeDataGridView();
        }

        private class Transaction
        {
            public DateTime Date { get; set; }
            public string Description { get; set; }
            public int Amount { get; set; }
            public string Type { get; set; }
        }

        private void InitializeDataGridView()
        {
            table.Columns.Add("날짜", typeof(string));
            table.Columns.Add("항목", typeof(string));
            table.Columns.Add("금액", typeof(string));
            table.Columns.Add("구분", typeof(string));

            dgvRecords.DataSource = table;
            dgvRecords.AllowUserToResizeColumns = false;
            dgvRecords.AllowUserToResizeRows = false;
            dgvRecords.ReadOnly = true;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecords.BorderStyle = BorderStyle.FixedSingle;
            dgvRecords.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvRecords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvRecords.RowHeadersVisible = false;
            dgvRecords.AllowUserToAddRows = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtItem.Text))
            {
                MessageBox.Show("항목을 입력하세요.");
                return;
            }

            if (!int.TryParse(TxtPrice.Text, out int amount))
            {
                MessageBox.Show("금액을 숫자로 입력하세요.");
                return;
            }

            string type = CmbType.SelectedItem?.ToString() ?? "수입";

            var t = new Transaction
            {
                Date = dateTimePicker1.Value.Date,
                Description = TxtItem.Text.Trim(),
                Amount = amount,
                Type = type
            };
            transactions.Add(t);

            TxtItem.Clear();
            TxtPrice.Clear();
            CmbType.SelectedIndex = 0;

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            int income = 0;
            int expense = 0;
            table.Rows.Clear();

            foreach (var t in transactions)
            {
                string formattedAmount = $"{t.Amount:N0}원";

                table.Rows.Add(
                    t.Date.ToString("yyyy-MM-dd"),
                    t.Description,
                    formattedAmount,
                    t.Type
                );

                if (t.Type == "수입") income += t.Amount;
                else if (t.Type == "지출") expense += t.Amount;
            }

            label1.Text = $"총 수입 : {income:N0}원";
            label2.Text = $"총 지출 : {expense:N0}원";
            label3.Text = $"총 잔액 : {(income - expense):N0}원";
        }

        private void SaveFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
                sfd.DefaultExt = "txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var lines = transactions.Select(t =>
                        $"{t.Date:yyyy-MM-dd}|{t.Description}|{t.Amount}|{t.Type}");

                    File.WriteAllLines(sfd.FileName, lines);
                }
            }
        }

        private void LoadFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(ofd.FileName);

                    transactions.Clear();

                    foreach (string line in lines)
                    {
                        var parts = line.Split('|');
                        if (parts.Length == 4 &&
                            DateTime.TryParse(parts[0], out DateTime date) &&
                            int.TryParse(parts[2], out int amount))
                        {
                            transactions.Add(new Transaction
                            {
                                Date = date,
                                Description = parts[1],
                                Amount = amount,
                                Type = parts[3]
                            });
                        }
                    }

                    UpdateDisplay();
                }
            }
        }

        private void MstSave_Click(object sender, EventArgs e)
        {
            SaveFile(); 
        }


        private void MstRoad_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("파일을 불러오시겠습니까?", "불러오기", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadFile();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void MstExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
