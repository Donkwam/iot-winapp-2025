using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace cnrkgksmsrj
{
    public partial class FrmMain : Form
    {
        private List<Transaction> transactions = new(); // 거래 내역 저장 리스트
        private DataTable table = new(); // DataGridView에 표시할 테이블

        public FrmMain()
        {
            InitializeComponent();
            btnAdd.Click += btnAdd_Click; // 이벤트 연결
            InitializeDataGridView();     // 테이블 초기화
        }

        // 거래 내역 데이터 모델
        private class Transaction
        {
            public DateTime Date { get; set; }
            public string Description { get; set; }
            public int Amount { get; set; }
            public string Type { get; set; }
        }

        // DataGridView 설정
        private void InitializeDataGridView()
        {
            // 컬럼 생성
            table.Columns.Add("날짜", typeof(string));
            table.Columns.Add("항목", typeof(string));
            table.Columns.Add("금액", typeof(string));
            table.Columns.Add("구분", typeof(string));


            dgvRecords.DataSource = table;
            dgvRecords.AllowUserToResizeColumns = false;
            dgvRecords.AllowUserToResizeRows = false;
            dgvRecords.ReadOnly = true;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // 열 너비 자동 비율 맞춤
            dgvRecords.BorderStyle = BorderStyle.FixedSingle;                      // 테두리 한 줄
            dgvRecords.CellBorderStyle = DataGridViewCellBorderStyle.Single;       // 셀 구분선 한 줄
            dgvRecords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // 헤더 경계선
            dgvRecords.RowHeadersVisible = false;
            dgvRecords.AllowUserToAddRows = false;
        }

        // '추가' 버튼 클릭 시
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

            // 거래 추가
            var t = new Transaction
            {
                Date = dateTimePicker1.Value.Date,
                Description = TxtItem.Text.Trim(),
                Amount = amount,
                Type = type
            };
            transactions.Add(t);

            // UI 초기화
            TxtItem.Clear();
            TxtPrice.Clear();
            CmbType.SelectedIndex = 0;

            UpdateDisplay();
        }

        // 테이블 및 합계 업데이트
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

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            

        }

        private void SaveFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*"; // 파일 형식 설정
                sfd.DefaultExt = "txt"; // 기본 확장자

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName; // 사용자가 선택한 파일 경로
                    File.WriteAllText(filePath, label1.Text + label2.Text + label3.Text); // 파일에 내용 저장
                }
            }
        }
        private void MstSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("저장하시것습니까?","저장",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SaveFile();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MstExit_Click(object sender, EventArgs e)
        {

        }

    }
}
