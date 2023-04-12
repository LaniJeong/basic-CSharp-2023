namespace wf11_mditest
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MniForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MniForm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MniAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniForm1,
            this.MniForm2,
            this.MniExit});
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vToolStripMenuItem.Text = "파일(&F)";
            // 
            // MniForm1
            // 
            this.MniForm1.Name = "MniForm1";
            this.MniForm1.Size = new System.Drawing.Size(180, 22);
            this.MniForm1.Text = "폼1(&R)";
            this.MniForm1.Click += new System.EventHandler(this.MniForm1_Click);
            // 
            // MniForm2
            // 
            this.MniForm2.Name = "MniForm2";
            this.MniForm2.Size = new System.Drawing.Size(180, 22);
            this.MniForm2.Text = "폼2(&T)";
            this.MniForm2.Click += new System.EventHandler(this.MniForm2_Click);
            // 
            // MniExit
            // 
            this.MniExit.Name = "MniExit";
            this.MniExit.Size = new System.Drawing.Size(180, 22);
            this.MniExit.Text = "끝내기(&X)";
            this.MniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniAbout});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // MniAbout
            // 
            this.MniAbout.Name = "MniAbout";
            this.MniAbout.Size = new System.Drawing.Size(180, 22);
            this.MniAbout.Text = "이 프로그램(&A)";
            this.MniAbout.Click += new System.EventHandler(this.MniAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MniForm1;
        private System.Windows.Forms.ToolStripMenuItem MniForm2;
        private System.Windows.Forms.ToolStripMenuItem MniExit;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MniAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

