﻿namespace SyntaxWinApp03
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
            BtnSave = new Button();
            BtnLoad = new Button();
            RtbNote = new RichTextBox();
            BtnRed = new Button();
            BtnBold = new Button();
            DlgOpen = new OpenFileDialog();
            DlgSave = new SaveFileDialog();
            DlgColor = new ColorDialog();
            SuspendLayout();
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.images;
            BtnSave.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold);
            BtnSave.ForeColor = SystemColors.ControlLightLight;
            BtnSave.Location = new Point(366, 251);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 28);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnLoad
            // 
            BtnLoad.BackgroundImage = Properties.Resources.images;
            BtnLoad.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold);
            BtnLoad.ForeColor = SystemColors.ControlLightLight;
            BtnLoad.Location = new Point(472, 251);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(100, 28);
            BtnLoad.TabIndex = 0;
            BtnLoad.Text = "읽기";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // RtbNote
            // 
            RtbNote.Font = new Font("나눔고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
            RtbNote.ForeColor = Color.MidnightBlue;
            RtbNote.Location = new Point(12, 11);
            RtbNote.Name = "RtbNote";
            RtbNote.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            RtbNote.Size = new Size(560, 235);
            RtbNote.TabIndex = 1;
            RtbNote.Text = "";
            RtbNote.WordWrap = false;
            // 
            // BtnRed
            // 
            BtnRed.BackColor = Color.Red;
            BtnRed.ForeColor = Color.Red;
            BtnRed.Location = new Point(296, 251);
            BtnRed.Name = "BtnRed";
            BtnRed.Size = new Size(28, 28);
            BtnRed.TabIndex = 2;
            BtnRed.Text = "R";
            BtnRed.UseVisualStyleBackColor = false;
            BtnRed.Click += BtnRed_Click;
            // 
            // BtnBold
            // 
            BtnBold.BackColor = SystemColors.ControlLight;
            BtnBold.ForeColor = Color.Blue;
            BtnBold.Location = new Point(332, 251);
            BtnBold.Name = "BtnBold";
            BtnBold.Size = new Size(28, 28);
            BtnBold.TabIndex = 2;
            BtnBold.Text = "B";
            BtnBold.UseVisualStyleBackColor = false;
            BtnBold.Click += BtnBold_Click;
            // 
            // DlgOpen
            // 
            DlgOpen.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.space;
            ClientSize = new Size(584, 290);
            Controls.Add(BtnBold);
            Controls.Add(BtnRed);
            Controls.Add(RtbNote);
            Controls.Add(BtnLoad);
            Controls.Add(BtnSave);
            Font = new Font("나눔고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "파일IO 윈앱";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSave;
        private Button BtnLoad;
        private RichTextBox RtbNote;
        private Button BtnRed;
        private Button BtnBold;
        private OpenFileDialog DlgOpen;
        private SaveFileDialog DlgSave;
        private ColorDialog DlgColor;
    }
}
