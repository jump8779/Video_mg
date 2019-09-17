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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoMg));
            this.GB_videoinfo = new System.Windows.Forms.GroupBox();
            this.DPoutdate = new System.Windows.Forms.DateTimePicker();
            this.TBcompany = new System.Windows.Forms.TextBox();
            this.TBdirect = new System.Windows.Forms.TextBox();
            this.TBact = new System.Windows.Forms.TextBox();
            this.TBsubject = new System.Windows.Forms.TextBox();
            this.TBgenre = new System.Windows.Forms.TextBox();
            this.TBvcode = new System.Windows.Forms.TextBox();
            this.lbloutdate = new System.Windows.Forms.Label();
            this.lblcompany = new System.Windows.Forms.Label();
            this.lbldirect = new System.Windows.Forms.Label();
            this.lblact = new System.Windows.Forms.Label();
            this.lblsubject = new System.Windows.Forms.Label();
            this.lblgenre = new System.Windows.Forms.Label();
            this.lblvcode = new System.Windows.Forms.Label();
            this.bt_vinsert = new System.Windows.Forms.Button();
            this.bt_vsave = new System.Windows.Forms.Button();
            this.bt_vdelete = new System.Windows.Forms.Button();
            this.bt_vcancel = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.lblvcount = new System.Windows.Forms.Label();
            this.lbl_allvcount = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.dgVideo = new System.Windows.Forms.DataGridView();
            this.dS_videomg1 = new Video_mg.DS_videomg();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.GB_videoinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_videomg1)).BeginInit();
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
            // DPoutdate
            // 
            this.DPoutdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DPoutdate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dS_videomg1, "videomg.out_date", true));
            this.DPoutdate.Font = new System.Drawing.Font("굴림", 9F);
            this.DPoutdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPoutdate.Location = new System.Drawing.Point(477, 142);
            this.DPoutdate.Name = "DPoutdate";
            this.DPoutdate.Size = new System.Drawing.Size(275, 25);
            this.DPoutdate.TabIndex = 8;
            // 
            // TBcompany
            // 
            this.TBcompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "videomg.company", true));
            this.TBcompany.Location = new System.Drawing.Point(118, 142);
            this.TBcompany.Name = "TBcompany";
            this.TBcompany.Size = new System.Drawing.Size(275, 25);
            this.TBcompany.TabIndex = 7;
            // 
            // TBdirect
            // 
            this.TBdirect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBdirect.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "videomg.direct", true));
            this.TBdirect.Location = new System.Drawing.Point(477, 103);
            this.TBdirect.Name = "TBdirect";
            this.TBdirect.Size = new System.Drawing.Size(275, 25);
            this.TBdirect.TabIndex = 7;
            // 
            // TBact
            // 
            this.TBact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "videomg.act", true));
            this.TBact.Location = new System.Drawing.Point(118, 103);
            this.TBact.Name = "TBact";
            this.TBact.Size = new System.Drawing.Size(275, 25);
            this.TBact.TabIndex = 7;
            // 
            // TBsubject
            // 
            this.TBsubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBsubject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "videomg._subject", true));
            this.TBsubject.Location = new System.Drawing.Point(118, 64);
            this.TBsubject.Name = "TBsubject";
            this.TBsubject.Size = new System.Drawing.Size(634, 25);
            this.TBsubject.TabIndex = 7;
            // 
            // TBgenre
            // 
            this.TBgenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBgenre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "videomg.genre", true));
            this.TBgenre.Location = new System.Drawing.Point(477, 26);
            this.TBgenre.Name = "TBgenre";
            this.TBgenre.Size = new System.Drawing.Size(275, 25);
            this.TBgenre.TabIndex = 7;
            // 
            // TBvcode
            // 
            this.TBvcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "videomg.vcode", true));
            this.TBvcode.Location = new System.Drawing.Point(118, 26);
            this.TBvcode.MaxLength = 13;
            this.TBvcode.Name = "TBvcode";
            this.TBvcode.Size = new System.Drawing.Size(275, 25);
            this.TBvcode.TabIndex = 7;
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
            // lblcompany
            // 
            this.lblcompany.AutoSize = true;
            this.lblcompany.Location = new System.Drawing.Point(15, 146);
            this.lblcompany.Name = "lblcompany";
            this.lblcompany.Size = new System.Drawing.Size(102, 15);
            this.lblcompany.TabIndex = 5;
            this.lblcompany.Text = "제작 및 배급 :";
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
            // lblact
            // 
            this.lblact.AutoSize = true;
            this.lblact.Location = new System.Drawing.Point(35, 107);
            this.lblact.Name = "lblact";
            this.lblact.Size = new System.Drawing.Size(82, 15);
            this.lblact.TabIndex = 3;
            this.lblact.Text = "주연 배우 :";
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
            // lblvcode
            // 
            this.lblvcode.AutoSize = true;
            this.lblvcode.Location = new System.Drawing.Point(20, 30);
            this.lblvcode.Name = "lblvcode";
            this.lblvcode.Size = new System.Drawing.Size(97, 15);
            this.lblvcode.TabIndex = 0;
            this.lblvcode.Text = "비디오 코드 :";
            // 
            // bt_vinsert
            // 
            this.bt_vinsert.Location = new System.Drawing.Point(13, 216);
            this.bt_vinsert.Name = "bt_vinsert";
            this.bt_vinsert.Size = new System.Drawing.Size(99, 34);
            this.bt_vinsert.TabIndex = 1;
            this.bt_vinsert.Text = "추가";
            this.bt_vinsert.UseVisualStyleBackColor = true;
            this.bt_vinsert.Click += new System.EventHandler(this.Bt_vinsert_Click);
            // 
            // bt_vsave
            // 
            this.bt_vsave.Location = new System.Drawing.Point(118, 216);
            this.bt_vsave.Name = "bt_vsave";
            this.bt_vsave.Size = new System.Drawing.Size(99, 34);
            this.bt_vsave.TabIndex = 1;
            this.bt_vsave.Text = "저장";
            this.bt_vsave.UseVisualStyleBackColor = true;
            this.bt_vsave.Click += new System.EventHandler(this.Bt_vsave_Click);
            // 
            // bt_vdelete
            // 
            this.bt_vdelete.Location = new System.Drawing.Point(223, 216);
            this.bt_vdelete.Name = "bt_vdelete";
            this.bt_vdelete.Size = new System.Drawing.Size(99, 34);
            this.bt_vdelete.TabIndex = 1;
            this.bt_vdelete.Text = "삭제";
            this.bt_vdelete.UseVisualStyleBackColor = true;
            this.bt_vdelete.Click += new System.EventHandler(this.Bt_vdelete_Click);
            // 
            // bt_vcancel
            // 
            this.bt_vcancel.Location = new System.Drawing.Point(328, 216);
            this.bt_vcancel.Name = "bt_vcancel";
            this.bt_vcancel.Size = new System.Drawing.Size(99, 34);
            this.bt_vcancel.TabIndex = 1;
            this.bt_vcancel.Text = "취소";
            this.bt_vcancel.UseVisualStyleBackColor = true;
            this.bt_vcancel.Click += new System.EventHandler(this.Bt_vcancel_Click);
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
            this.bt_exit.Click += new System.EventHandler(this.Bt_exit_Click);
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
            this.bt_update.Click += new System.EventHandler(this.Bt_update_Click);
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
            this.dgVideo.CurrentCellChanged += new System.EventHandler(this.DgVideo_CurrentCellChanged);
            // 
            // dS_videomg1
            // 
            this.dS_videomg1.DataSetName = "DS_videomg";
            this.dS_videomg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT videomg.*\r\nFROM  videomg";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@vcode", System.Data.SqlDbType.VarChar, 0, "vcode"),
            new System.Data.SqlClient.SqlParameter("@genre", System.Data.SqlDbType.VarChar, 0, "genre"),
            new System.Data.SqlClient.SqlParameter("@_subject", System.Data.SqlDbType.VarChar, 0, "_subject"),
            new System.Data.SqlClient.SqlParameter("@act", System.Data.SqlDbType.VarChar, 0, "act"),
            new System.Data.SqlClient.SqlParameter("@direct", System.Data.SqlDbType.VarChar, 0, "direct"),
            new System.Data.SqlClient.SqlParameter("@company", System.Data.SqlDbType.VarChar, 0, "company"),
            new System.Data.SqlClient.SqlParameter("@out_date", System.Data.SqlDbType.VarChar, 0, "out_date")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@vcode", System.Data.SqlDbType.VarChar, 0, "vcode"),
            new System.Data.SqlClient.SqlParameter("@genre", System.Data.SqlDbType.VarChar, 0, "genre"),
            new System.Data.SqlClient.SqlParameter("@_subject", System.Data.SqlDbType.VarChar, 0, "_subject"),
            new System.Data.SqlClient.SqlParameter("@act", System.Data.SqlDbType.VarChar, 0, "act"),
            new System.Data.SqlClient.SqlParameter("@direct", System.Data.SqlDbType.VarChar, 0, "direct"),
            new System.Data.SqlClient.SqlParameter("@company", System.Data.SqlDbType.VarChar, 0, "company"),
            new System.Data.SqlClient.SqlParameter("@out_date", System.Data.SqlDbType.VarChar, 0, "out_date"),
            new System.Data.SqlClient.SqlParameter("@Original_vcode", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "vcode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_genre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "genre", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_genre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "genre", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original__subject", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "_subject", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_act", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "act", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_act", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "act", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_direct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "direct", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_direct", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "direct", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_company", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "company", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_company", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "company", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_out_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "out_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_out_date", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "out_date", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_vcode", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "vcode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_genre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "genre", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_genre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "genre", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original__subject", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "_subject", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_act", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "act", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_act", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "act", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_direct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "direct", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_direct", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "direct", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_company", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "company", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_company", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "company", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_out_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "out_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_out_date", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "out_date", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "videomg", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("vcode", "vcode"),
                        new System.Data.Common.DataColumnMapping("genre", "genre"),
                        new System.Data.Common.DataColumnMapping("_subject", "_subject"),
                        new System.Data.Common.DataColumnMapping("act", "act"),
                        new System.Data.Common.DataColumnMapping("direct", "direct"),
                        new System.Data.Common.DataColumnMapping("company", "company"),
                        new System.Data.Common.DataColumnMapping("out_date", "out_date")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=localhost;Initial Catalog=Videomg;User ID=sa;Password=std001;Pooling=" +
    "False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
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
            this.Load += new System.EventHandler(this.VideoMg_Load);
            this.GB_videoinfo.ResumeLayout(false);
            this.GB_videoinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_videomg1)).EndInit();
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
        private DS_videomg dS_videomg1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}