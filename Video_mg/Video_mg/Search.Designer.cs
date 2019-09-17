namespace Video_mg
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GB_searchinfo = new System.Windows.Forms.GroupBox();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.lblgenre = new System.Windows.Forms.Label();
            this.lblsinbun = new System.Windows.Forms.Label();
            this.TBgenre = new System.Windows.Forms.TextBox();
            this.TBsinbun = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.GB_searchinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_searchinfo
            // 
            this.GB_searchinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_searchinfo.Controls.Add(this.bt_exit);
            this.GB_searchinfo.Controls.Add(this.bt_search);
            this.GB_searchinfo.Controls.Add(this.TBsinbun);
            this.GB_searchinfo.Controls.Add(this.TBgenre);
            this.GB_searchinfo.Controls.Add(this.lblsinbun);
            this.GB_searchinfo.Controls.Add(this.lblgenre);
            this.GB_searchinfo.Controls.Add(this.rb_3);
            this.GB_searchinfo.Controls.Add(this.rb_2);
            this.GB_searchinfo.Controls.Add(this.rb_1);
            this.GB_searchinfo.Location = new System.Drawing.Point(13, 13);
            this.GB_searchinfo.Name = "GB_searchinfo";
            this.GB_searchinfo.Size = new System.Drawing.Size(994, 116);
            this.GB_searchinfo.TabIndex = 0;
            this.GB_searchinfo.TabStop = false;
            this.GB_searchinfo.Text = "조회 정보";
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(34, 34);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(143, 19);
            this.rb_1.TabIndex = 0;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "비디오 대여 순위";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(221, 34);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(138, 19);
            this.rb_2.TabIndex = 1;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "대여중인 비디오";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(34, 75);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(128, 19);
            this.rb_3.TabIndex = 2;
            this.rb_3.TabStop = true;
            this.rb_3.Text = "고객 대여 순위";
            this.rb_3.UseVisualStyleBackColor = true;
            // 
            // lblgenre
            // 
            this.lblgenre.AutoSize = true;
            this.lblgenre.Location = new System.Drawing.Point(440, 37);
            this.lblgenre.Name = "lblgenre";
            this.lblgenre.Size = new System.Drawing.Size(47, 15);
            this.lblgenre.TabIndex = 3;
            this.lblgenre.Text = "장르 :";
            // 
            // lblsinbun
            // 
            this.lblsinbun.AutoSize = true;
            this.lblsinbun.Location = new System.Drawing.Point(405, 77);
            this.lblsinbun.Name = "lblsinbun";
            this.lblsinbun.Size = new System.Drawing.Size(82, 15);
            this.lblsinbun.TabIndex = 4;
            this.lblsinbun.Text = "고객 신분 :";
            // 
            // TBgenre
            // 
            this.TBgenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBgenre.Location = new System.Drawing.Point(490, 33);
            this.TBgenre.Name = "TBgenre";
            this.TBgenre.Size = new System.Drawing.Size(133, 25);
            this.TBgenre.TabIndex = 5;
            // 
            // TBsinbun
            // 
            this.TBsinbun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBsinbun.Location = new System.Drawing.Point(490, 73);
            this.TBsinbun.Name = "TBsinbun";
            this.TBsinbun.Size = new System.Drawing.Size(133, 25);
            this.TBsinbun.TabIndex = 5;
            // 
            // bt_search
            // 
            this.bt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_search.Location = new System.Drawing.Point(680, 33);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(134, 65);
            this.bt_search.TabIndex = 6;
            this.bt_search.Text = "검색";
            this.bt_search.UseVisualStyleBackColor = true;
            // 
            // bt_exit
            // 
            this.bt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exit.Location = new System.Drawing.Point(841, 33);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(134, 65);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.Text = "나가기";
            this.bt_exit.UseVisualStyleBackColor = true;
            // 
            // dgSearch
            // 
            this.dgSearch.AllowUserToAddRows = false;
            this.dgSearch.AllowUserToDeleteRows = false;
            this.dgSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(13, 136);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.ReadOnly = true;
            this.dgSearch.RowHeadersWidth = 51;
            this.dgSearch.RowTemplate.Height = 27;
            this.dgSearch.Size = new System.Drawing.Size(994, 444);
            this.dgSearch.TabIndex = 1;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 592);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.GB_searchinfo);
            this.MinimumSize = new System.Drawing.Size(1037, 639);
            this.Name = "Search";
            this.Text = "비디오 조회 관리";
            this.GB_searchinfo.ResumeLayout(false);
            this.GB_searchinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_searchinfo;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox TBsinbun;
        private System.Windows.Forms.TextBox TBgenre;
        private System.Windows.Forms.Label lblsinbun;
        private System.Windows.Forms.Label lblgenre;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.DataGridView dgSearch;
    }
}