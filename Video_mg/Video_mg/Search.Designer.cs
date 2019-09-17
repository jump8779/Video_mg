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
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.TBsinbun = new System.Windows.Forms.TextBox();
            this.TBgenre = new System.Windows.Forms.TextBox();
            this.lblsinbun = new System.Windows.Forms.Label();
            this.lblgenre = new System.Windows.Forms.Label();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // bt_exit
            // 
            this.bt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exit.Location = new System.Drawing.Point(841, 33);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(134, 65);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.Text = "나가기";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.Bt_exit_Click);
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
            this.bt_search.Click += new System.EventHandler(this.Bt_search_Click);
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
            // TBgenre
            // 
            this.TBgenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBgenre.Location = new System.Drawing.Point(490, 33);
            this.TBgenre.Name = "TBgenre";
            this.TBgenre.Size = new System.Drawing.Size(133, 25);
            this.TBgenre.TabIndex = 5;
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
            // lblgenre
            // 
            this.lblgenre.AutoSize = true;
            this.lblgenre.Location = new System.Drawing.Point(440, 37);
            this.lblgenre.Name = "lblgenre";
            this.lblgenre.Size = new System.Drawing.Size(47, 15);
            this.lblgenre.TabIndex = 3;
            this.lblgenre.Text = "장르 :";
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
            this.rb_3.CheckedChanged += new System.EventHandler(this.Rb_3_CheckedChanged);
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
            this.rb_2.CheckedChanged += new System.EventHandler(this.Rb_2_CheckedChanged);
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
            this.rb_1.CheckedChanged += new System.EventHandler(this.Rb_1_CheckedChanged);
            // 
            // dgSearch
            // 
            this.dgSearch.AllowUserToAddRows = false;
            this.dgSearch.AllowUserToDeleteRows = false;
            this.dgSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgSearch.Location = new System.Drawing.Point(13, 136);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.ReadOnly = true;
            this.dgSearch.RowHeadersWidth = 51;
            this.dgSearch.RowTemplate.Height = 27;
            this.dgSearch.Size = new System.Drawing.Size(994, 444);
            this.dgSearch.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 125;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 592);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.GB_searchinfo);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}