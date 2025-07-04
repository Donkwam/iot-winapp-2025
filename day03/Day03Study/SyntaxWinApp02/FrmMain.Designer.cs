﻿namespace SyntaxWinApp02
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BtnCheck = new Button();
            ImlForm = new ImageList(components);
            label1 = new Label();
            CboDivision = new ComboBox();
            PicComputer = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PicComputer).BeginInit();
            SuspendLayout();
            // 
            // BtnCheck
            // 
            BtnCheck.BackColor = SystemColors.ButtonHighlight;
            BtnCheck.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCheck.ImageIndex = 0;
            BtnCheck.ImageList = ImlForm;
            BtnCheck.Location = new Point(472, 259);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Padding = new Padding(10, 0, 0, 0);
            BtnCheck.Size = new Size(100, 40);
            BtnCheck.TabIndex = 0;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = false;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // ImlForm
            // 
            ImlForm.ColorDepth = ColorDepth.Depth32Bit;
            ImlForm.ImageStream = (ImageListStreamer)resources.GetObject("ImlForm.ImageStream");
            ImlForm.TransparentColor = Color.Transparent;
            ImlForm.Images.SetKeyName(0, "check.png");
            ImlForm.Images.SetKeyName(1, "plus.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 15);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "종류";
            // 
            // CboDivision
            // 
            CboDivision.FormattingEnabled = true;
            CboDivision.Items.AddRange(new object[] { "Computer", "Notbook", "Server" });
            CboDivision.Location = new Point(451, 12);
            CboDivision.Name = "CboDivision";
            CboDivision.Size = new Size(121, 23);
            CboDivision.TabIndex = 2;
            // 
            // PicComputer
            // 
            PicComputer.BorderStyle = BorderStyle.FixedSingle;
            PicComputer.Location = new Point(12, 12);
            PicComputer.Name = "PicComputer";
            PicComputer.Size = new Size(287, 287);
            PicComputer.SizeMode = PictureBoxSizeMode.StretchImage;
            PicComputer.TabIndex = 3;
            PicComputer.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 1;
            button1.ImageList = ImlForm;
            button1.Location = new Point(366, 259);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(100, 40);
            button1.TabIndex = 4;
            button1.Text = "복사";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(button1);
            Controls.Add(PicComputer);
            Controls.Add(CboDivision);
            Controls.Add(label1);
            Controls.Add(BtnCheck);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱02";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)PicComputer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCheck;
        private ImageList ImlForm;
        private Label label1;
        private ComboBox CboDivision;
        private PictureBox PicComputer;
        private Button button1;
    }
}
