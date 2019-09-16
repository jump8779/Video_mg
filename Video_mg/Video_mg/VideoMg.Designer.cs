namespace Video_mg
{
    partial class VideoMg
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
            this.GB_videoinfo = new System.Windows.Forms.GroupBox();
            this.lblvcode = new System.Windows.Forms.Label();
            this.lblgenre = new System.Windows.Forms.Label();
            this.lblsubject = new System.Windows.Forms.Label();
            this.lblact = new System.Windows.Forms.Label();
            this.lbldirect = new System.Windows.Forms.Label();
            this.lblcompany = new System.Windows.Forms.Label();
            this.lbloutdate = new System.Windows.Forms.Label();
            this.TBvcode = new System.Windows.Forms.TextBox();
            this.TBgenre = new System.Windows.Forms.TextBox();
            this.TBsubject = new System.Windows.Forms.TextBox();
            this.TBact = new System.Windows.Forms.TextBox();
            this.TBdirect = new System.Windows.Forms.TextBox();
            this.TBcompany = new System.Windows.Forms.TextBox();
            this.DPoutdate = new System.Windows.Forms.DateTimePicker();
            this.bt_vinsert = new System.Windows.Forms.Button();
            this.bt_vsave = new System.Windows.Forms.Button();
            this.bt_vdelete = new System.Windows.Forms.Button();
            this.bt_vcancel = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.lblvcount = new System.Windows.Forms.Label();
            this.lbl_allvcount = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.dgVideo = new System.Windows.Forms.DataGridView();
            this.GB_videoinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_videoinfo
            // 
            this.GB_videoinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_videoinfo.Controls.Add(this.DPoutdate);
            this.GB_videoinfo.Controls.Add(this.TBcompany);
            this.GB_videoinfo.Controls.Add(this.TBdirect);
            this.GB_videoinfo.Controls.Add(this.TBact);
            this.GB_videoinfo.Controls.Add(this.TBsubject);
            this.GB_videoinfo.Controls.Add(this.TBgenre);
            this.GB_videoinfo.Controls.Add(this.TBvcode);
            this.GB_videoinfo.Controls.Add(this.lbloutdate);
            this.GB_videoinfo.Controls.Add(this.lblcompany);
            this.GB_videoinfo.Controls.Add(this.lbldirect);
            this.GB_videoinfo.Controls.Add(this.lblact);
            this.GB_videoinfo.Controls.Add(this.lblsubject);
            this.GB_videoinfo.Controls.Add(this.lblgenre);
            this.GB_videoinfo.Controls.Add(this.lblvcode);
            this.GB_videoinfo.Location = new System.Drawing.Point(13, 13);
            this.GB_videoinfo.Name = "GB_videoinfo";
            this.GB_videoinfo.Size = new System.Drawing.Size(792, 186);
            this.GB_videoinfo.TabIndex = 0;
            this.GB_videoinfo.TabStop = false;
            this.GB_videoinfo.Text = "비디오 정보";
            // 
            // lblvcode
            // 
            this.lblvcode.AutoSize = true;
            this.lblvcode.Location = new System.Drawing.Point(20, 30);
            this.lblvcode.Name = "lblvcode";
            this.lblvcode.Size = new System.Drawing.Size(97, 15);
            this.lblvcode.TabIndex = 0;
            this.lblvcode.Text = "비디오 코드 :";
            // 
            // lblgenre
            // 
            this.lblgenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgenre.AutoSize = true;
            this.lblgenre.Location = new System.Drawing.Point(429, 30);
            this.lblgenre.Name = "lblgenre";
            this.lblgenre.Size = new System.Drawing.Size(47, 15);
            this.lblgenre.TabIndex = 1;
            this.lblgenre.Text = "장르 :";
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Location = new System.Drawing.Point(70, 68);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(47, 15);
            this.lblsubject.TabIndex = 2;
            this.lblsubject.Text = "제목 :";
            // 
            // lblact
            // 
            this.lblact.AutoSize = true;
            this.lblact.Location = new System.Drawing.Point(35, 107);
            this.lblact.Name = "lblact";
            this.lblact.Size = new System.Drawing.Size(82, 15);
            this.lblact.TabIndex = 3;
            this.lblact.Text = "주연 배우 :";
            // 
            // lbldirect
            // 
            this.lbldirect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldirect.AutoSize = true;
            this.lbldirect.Location = new System.Drawing.Point(429, 107);
            this.lbldirect.Name = "lbldirect";
            this.lbldirect.Size = new System.Drawing.Size(47, 15);
            this.lbldirect.TabIndex = 4;
            this.lbldirect.Text = "감독 :";
            // 
            // lblcompany
            // 
            this.lblcompany.AutoSize = true;
            this.lblcompany.Location = new System.Drawing.Point(15, 146);
            this.lblcompany.Name = "lblcompany";
            this.lblcompany.Size = new System.Drawing.Size(102, 15);
            this.lblcompany.TabIndex = 5;
            this.lblcompany.Text = "제작 및 배급 :";
            // 
            // lbloutdate
            // 
            this.lbloutdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbloutdate.AutoSize = true;
            this.lbloutdate.Location = new System.Drawing.Point(414, 146);
            this.lbloutdate.Name = "lbloutdate";
            this.lbloutdate.Size = new System.Drawing.Size(62, 15);
            this.lbloutdate.TabIndex = 6;
            this.lbloutdate.Text = "출시일 :";
            // 
            // TBvcode
            // 
            this.TBvcode.Location = new System.Drawing.Point(118, 26);
            this.TBvcode.Name = "TBvcode";
            this.TBvcode.Size = new System.Drawing.Size(275, 25);
            this.TBvcode.TabIndex = 7;
            // 
            // TBgenre
            // 
            this.TBgenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBgenre.Location = new System.Drawing.Point(477, 26);
            this.TBgenre.Name = "TBgenre";
            this.TBgenre.Size = new System.Drawing.Size(275, 25);
            this.TBgenre.TabIndex = 7;
            // 
            // TBsubject
            // 
            this.TBsubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBsubject.Location = new System.Drawing.Point(118, 64);
            this.TBsubject.Name = "TBsubject";
            this.TBsubject.Size = new System.Drawing.Size(634, 25);
            this.TBsubject.TabIndex = 7;
            // 
            // TBact
            // 
            this.TBact.Location = new System.Drawing.Point(118, 103);
            this.TBact.Name = "TBact";
            this.TBact.Size = new System.Drawing.Size(275, 25);
            this.TBact.TabIndex = 7;
            // 
            // TBdirect
            // 
            this.TBdirect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBdirect.Location = new System.Drawing.Point(477, 103);
            this.TBdirect.Name = "TBdirect";
            this.TBdirect.Size = new System.Drawing.Size(275, 25);
            this.TBdirect.TabIndex = 7;
            // 
            // TBcompany
            // 
            this.TBcompany.Location = new System.Drawing.Point(118, 142);
            this.TBcompany.Name = "TBcompany";
            this.TBcompany.Size = new System.Drawing.Size(275, 25);
            this.TBcompany.TabIndex = 7;
            // 
            // DPoutdate
            // 
            this.DPoutdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DPoutdate.Font = new System.Drawing.Font("굴림", 9F);
            this.DPoutdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPoutdate.Location = new System.Drawing.Point(477, 142);
            this.DPoutdate.Name = "DPoutdate";
            this.DPoutdate.Size = new System.Drawing.Size(275, 25);
            this.DPoutdate.TabIndex = 8;
            // 
            // bt_vinsert
            // 
            this.bt_vinsert.Location = new System.Drawing.Point(13, 216);
            this.bt_vinsert.Name = "bt_vinsert";
            this.bt_vinsert.Size = new System.Drawing.Size(99, 34);
            this.bt_vinsert.TabIndex = 1;
            this.bt_vinsert.Text = "추가";
            this.bt_vinsert.UseVisualStyleBackColor = true;
            // 
            // bt_vsave
            // 
            this.bt_vsave.Location = new System.Drawing.Point(118, 216);
            this.bt_vsave.Name = "bt_vsave";
            this.bt_vsave.Size = new System.Drawing.Size(99, 34);
            this.bt_vsave.TabIndex = 1;
            this.bt_vsave.Text = "저장";
            this.bt_vsave.UseVisualStyleBackColor = true;
            // 
            // bt_vdelete
            // 
            this.bt_vdelete.Location = new System.Drawing.Point(223, 216);
            this.bt_vdelete.Name = "bt_vdelete";
            this.bt_vdelete.Size = new System.Drawing.Size(99, 34);
            this.bt_vdelete.TabIndex = 1;
            this.bt_vdelete.Text = "삭제";
            this.bt_vdelete.UseVisualStyleBackColor = true;
            // 
            // bt_vcancel
            // 
            this.bt_vcancel.Location = new System.Drawing.Point(328, 216);
            this.bt_vcancel.Name = "bt_vcancel";
            this.bt_vcancel.Size = new System.Drawing.Size(99, 34);
            this.bt_vcancel.TabIndex = 1;
            this.bt_vcancel.Text = "취소";
            this.bt_vcancel.UseVisualStyleBackColor = true;
            // 
            // bt_exit
            // 
            this.bt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exit.Location = new System.Drawing.Point(706, 216);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(99, 34);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "나가기";
            this.bt_exit.UseVisualStyleBackColor = true;
            // 
            // lblvcount
            // 
            this.lblvcount.AutoSize = true;
            this.lblvcount.Location = new System.Drawing.Point(12, 275);
            this.lblvcount.Name = "lblvcount";
            this.lblvcount.Size = new System.Drawing.Size(117, 15);
            this.lblvcount.TabIndex = 2;
            this.lblvcount.Text = "전체 비디오 수 :";
            // 
            // lbl_allvcount
            // 
            this.lbl_allvcount.BackColor = System.Drawing.Color.Black;
            this.lbl_allvcount.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_allvcount.ForeColor = System.Drawing.Color.White;
            this.lbl_allvcount.Location = new System.Drawing.Point(131, 269);
            this.lbl_allvcount.Name = "lbl_allvcount";
            this.lbl_allvcount.Size = new System.Drawing.Size(67, 29);
            this.lbl_allvcount.TabIndex = 3;
            this.lbl_allvcount.Text = "0 개";
            this.lbl_allvcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(204, 269);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(106, 29);
            this.bt_update.TabIndex = 4;
            this.bt_update.Text = "목록 저장";
            this.bt_update.UseVisualStyleBackColor = true;
            // 
            // dgVideo
            // 
            this.dgVideo.AllowUserToAddRows = false;
            this.dgVideo.AllowUserToDeleteRows = false;
            this.dgVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVideo.Location = new System.Drawing.Point(13, 307);
            this.dgVideo.Name = "dgVideo";
            this.dgVideo.ReadOnly = true;
            this.dgVideo.RowHeadersWidth = 51;
            this.dgVideo.RowTemplate.Height = 27;
            this.dgVideo.Size = new System.Drawing.Size(792, 234);
            this.dgVideo.TabIndex = 5;
            // 
            // VideoMg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 553);
            this.Controls.Add(this.dgVideo);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.lbl_allvcount);
            this.Controls.Add(this.lblvcount);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_vcancel);
            this.Controls.Add(this.bt_vdelete);
            this.Controls.Add(this.bt_vsave);
            this.Controls.Add(this.bt_vinsert);
            this.Controls.Add(this.GB_videoinfo);
            this.MinimumSize = new System.Drawing.Size(835, 600);
            this.Name = "VideoMg";
            this.Text = "비디오 정보";
            this.GB_videoinfo.ResumeLayout(false);
            this.GB_videoinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_videoinfo;
        private System.Windows.Forms.Label lbloutdate;
        private System.Windows.Forms.Label lblcompany;
        private System.Windows.Forms.Label lbldirect;
        private System.Windows.Forms.Label lblact;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.Label lblgenre;
        private System.Windows.Forms.Label lblvcode;
        private System.Windows.Forms.DateTimePicker DPoutdate;
        private System.Windows.Forms.TextBox TBcompany;
        private System.Windows.Forms.TextBox TBdirect;
        private System.Windows.Forms.TextBox TBact;
        private System.Windows.Forms.TextBox TBsubject;
        private System.Windows.Forms.TextBox TBgenre;
        private System.Windows.Forms.TextBox TBvcode;
        private System.Windows.Forms.Button bt_vinsert;
        private System.Windows.Forms.Button bt_vsave;
        private System.Windows.Forms.Button bt_vdelete;
        private System.Windows.Forms.Button bt_vcancel;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label lblvcount;
        private System.Windows.Forms.Label lbl_allvcount;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.DataGridView dgVideo;
    }
}