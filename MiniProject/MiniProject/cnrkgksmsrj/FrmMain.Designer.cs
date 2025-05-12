namespace cnrkgksmsrj
{
    partial class FrmMain
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
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            dgvRecords = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CmbType = new ComboBox();
            btnAdd = new Button();
            TxtPrice = new TextBox();
            TxtItem = new TextBox();
            menuStrip1 = new MenuStrip();
            MstObject = new ToolStripMenuItem();
            MstSave = new ToolStripMenuItem();
            MstRoad = new ToolStripMenuItem();
            MstExit = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvRecords);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CmbType);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(TxtPrice);
            groupBox1.Controls.Add(TxtItem);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 220);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "정산";
            // 
            // dgvRecords
            // 
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(6, 50);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ScrollBars = ScrollBars.Vertical;
            dgvRecords.Size = new Size(548, 148);
            dgvRecords.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 202);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "총 잔액 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 202);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "총 지출 : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 202);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "총 수입 : ";
            // 
            // CmbType
            // 
            CmbType.FormattingEnabled = true;
            CmbType.Items.AddRange(new object[] { "수입", "지출" });
            CmbType.Location = new Point(393, 23);
            CmbType.Name = "CmbType";
            CmbType.Size = new Size(80, 23);
            CmbType.TabIndex = 4;
            CmbType.Text = "수입";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(479, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(202, 22);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.PlaceholderText = "금액";
            TxtPrice.Size = new Size(92, 23);
            TxtPrice.TabIndex = 3;
            // 
            // TxtItem
            // 
            TxtItem.Location = new Point(6, 23);
            TxtItem.Name = "TxtItem";
            TxtItem.PlaceholderText = "항목";
            TxtItem.Size = new Size(169, 23);
            TxtItem.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MstObject });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // MstObject
            // 
            MstObject.DropDownItems.AddRange(new ToolStripItem[] { MstSave, MstRoad, MstExit });
            MstObject.Name = "MstObject";
            MstObject.Size = new Size(43, 20);
            MstObject.Text = "파일";
            // 
            // MstSave
            // 
            MstSave.Name = "MstSave";
            MstSave.Size = new Size(139, 22);
            MstSave.Text = "저장(&S)";
            MstSave.Click += MstSave_Click;
            // 
            // MstRoad
            // 
            MstRoad.Name = "MstRoad";
            MstRoad.Size = new Size(139, 22);
            MstRoad.Text = "불러오기(&O)";
            // 
            // MstExit
            // 
            MstExit.Name = "MstExit";
            MstExit.Size = new Size(139, 22);
            MstExit.Text = "종료(&X)";
            MstExit.Click += MstExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 289);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(121, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "가계부";
            FormClosing += FrmMain_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private ComboBox CmbType;
        private Button btnAdd;
        private TextBox TxtPrice;
        private TextBox TxtItem;
        private Label label3;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MstObject;
        private StatusStrip statusStrip1;
        private DataGridView dgvRecords;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem MstSave;
        private ToolStripMenuItem MstRoad;
        private ToolStripMenuItem MstExit;
    }
}
