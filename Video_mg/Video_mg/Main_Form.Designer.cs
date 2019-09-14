namespace Video_mg
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_lent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_vmg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_mmg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_search = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_voption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_support = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Lent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_VMG = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_MMG = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Search = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_VOption = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_file,
            this.toolStripMenuItem_lent,
            this.toolStripMenuItem_vmg,
            this.toolStripMenuItem_mmg,
            this.toolStripMenuItem_search,
            this.toolStripMenuItem_voption,
            this.toolStripMenuItem_support});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_file
            // 
            this.toolStripMenuItem_file.Name = "toolStripMenuItem_file";
            this.toolStripMenuItem_file.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem_file.Text = "파일";
            // 
            // toolStripMenuItem_lent
            // 
            this.toolStripMenuItem_lent.Name = "toolStripMenuItem_lent";
            this.toolStripMenuItem_lent.Size = new System.Drawing.Size(139, 24);
            this.toolStripMenuItem_lent.Text = "비디오 대여/반납";
            // 
            // toolStripMenuItem_vmg
            // 
            this.toolStripMenuItem_vmg.Name = "toolStripMenuItem_vmg";
            this.toolStripMenuItem_vmg.Size = new System.Drawing.Size(98, 24);
            this.toolStripMenuItem_vmg.Text = "비디오관리";
            // 
            // toolStripMenuItem_mmg
            // 
            this.toolStripMenuItem_mmg.Name = "toolStripMenuItem_mmg";
            this.toolStripMenuItem_mmg.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem_mmg.Text = "고객관리";
            // 
            // toolStripMenuItem_search
            // 
            this.toolStripMenuItem_search.Name = "toolStripMenuItem_search";
            this.toolStripMenuItem_search.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem_search.Text = "정보조회";
            // 
            // toolStripMenuItem_voption
            // 
            this.toolStripMenuItem_voption.Name = "toolStripMenuItem_voption";
            this.toolStripMenuItem_voption.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem_voption.Text = "환경설정";
            // 
            // toolStripMenuItem_support
            // 
            this.toolStripMenuItem_support.Name = "toolStripMenuItem_support";
            this.toolStripMenuItem_support.Size = new System.Drawing.Size(68, 24);
            this.toolStripMenuItem_support.Text = "도움말";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Lent,
            this.toolStripSeparator1,
            this.toolStripButton_VMG,
            this.toolStripButton_MMG,
            this.toolStripButton_Search,
            this.toolStripSeparator2,
            this.toolStripButton_VOption});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1482, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Lent
            // 
            this.toolStripButton_Lent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Lent.Image")));
            this.toolStripButton_Lent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Lent.Name = "toolStripButton_Lent";
            this.toolStripButton_Lent.Size = new System.Drawing.Size(79, 44);
            this.toolStripButton_Lent.Text = "대여/반납";
            this.toolStripButton_Lent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Lent.Click += new System.EventHandler(this.ToolStripButton_Lent_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButton_VMG
            // 
            this.toolStripButton_VMG.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_VMG.Image")));
            this.toolStripButton_VMG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_VMG.Name = "toolStripButton_VMG";
            this.toolStripButton_VMG.Size = new System.Drawing.Size(93, 44);
            this.toolStripButton_VMG.Text = "비디오 관리";
            this.toolStripButton_VMG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton_MMG
            // 
            this.toolStripButton_MMG.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_MMG.Image")));
            this.toolStripButton_MMG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_MMG.Name = "toolStripButton_MMG";
            this.toolStripButton_MMG.Size = new System.Drawing.Size(78, 44);
            this.toolStripButton_MMG.Text = "고객 관리";
            this.toolStripButton_MMG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton_Search
            // 
            this.toolStripButton_Search.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Search.Image")));
            this.toolStripButton_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Search.Name = "toolStripButton_Search";
            this.toolStripButton_Search.Size = new System.Drawing.Size(78, 44);
            this.toolStripButton_Search.Text = "정보 조회";
            this.toolStripButton_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButton_VOption
            // 
            this.toolStripButton_VOption.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_VOption.Image")));
            this.toolStripButton_VOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_VOption.Name = "toolStripButton_VOption";
            this.toolStripButton_VOption.Size = new System.Drawing.Size(78, 44);
            this.toolStripButton_VOption.Text = "환경 설정";
            this.toolStripButton_VOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "비디오 관리 프로그램";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_file;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_lent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_vmg;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_mmg;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_search;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_voption;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_support;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Lent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_VMG;
        private System.Windows.Forms.ToolStripButton toolStripButton_MMG;
        private System.Windows.Forms.ToolStripButton toolStripButton_Search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_VOption;
    }
}

