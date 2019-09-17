namespace Video_mg
{
    partial class MemberMg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberMg));
            this.GB_memberinfo = new System.Windows.Forms.GroupBox();
            this.TBaddress = new System.Windows.Forms.TextBox();
            this.dS_videomg1 = new Video_mg.DS_videomg();
            this.TBzip = new System.Windows.Forms.TextBox();
            this.TBpcs = new System.Windows.Forms.TextBox();
            this.TBphone = new System.Windows.Forms.TextBox();
            this.TBsex = new System.Windows.Forms.TextBox();
            this.TBsinbun = new System.Windows.Forms.TextBox();
            this.TBjumin = new System.Windows.Forms.TextBox();
            this.TBiname = new System.Windows.Forms.TextBox();
            this.TBmcode = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblzip = new System.Windows.Forms.Label();
            this.lblpcs = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.lblsinbun = new System.Windows.Forms.Label();
            this.lbljumin = new System.Windows.Forms.Label();
            this.lbliname = new System.Windows.Forms.Label();
            this.lblmcode = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_Card = new System.Windows.Forms.Button();
            this.lblallmember = new System.Windows.Forms.Label();
            this.lbl_allmcount = new System.Windows.Forms.Label();
            this.dgMember = new System.Windows.Forms.DataGridView();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.GB_memberinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_videomg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMember)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_memberinfo
            // 
            this.GB_memberinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_memberinfo.Controls.Add(this.TBaddress);
            this.GB_memberinfo.Controls.Add(this.TBzip);
            this.GB_memberinfo.Controls.Add(this.TBpcs);
            this.GB_memberinfo.Controls.Add(this.TBphone);
            this.GB_memberinfo.Controls.Add(this.TBsex);
            this.GB_memberinfo.Controls.Add(this.TBsinbun);
            this.GB_memberinfo.Controls.Add(this.TBjumin);
            this.GB_memberinfo.Controls.Add(this.TBiname);
            this.GB_memberinfo.Controls.Add(this.TBmcode);
            this.GB_memberinfo.Controls.Add(this.lbladdress);
            this.GB_memberinfo.Controls.Add(this.lblzip);
            this.GB_memberinfo.Controls.Add(this.lblpcs);
            this.GB_memberinfo.Controls.Add(this.lblphone);
            this.GB_memberinfo.Controls.Add(this.lblsex);
            this.GB_memberinfo.Controls.Add(this.lblsinbun);
            this.GB_memberinfo.Controls.Add(this.lbljumin);
            this.GB_memberinfo.Controls.Add(this.lbliname);
            this.GB_memberinfo.Controls.Add(this.lblmcode);
            this.GB_memberinfo.Location = new System.Drawing.Point(13, 13);
            this.GB_memberinfo.Name = "GB_memberinfo";
            this.GB_memberinfo.Size = new System.Drawing.Size(866, 270);
            this.GB_memberinfo.TabIndex = 0;
            this.GB_memberinfo.TabStop = false;
            this.GB_memberinfo.Text = "고객 정보";
            // 
            // TBaddress
            // 
            this.TBaddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "membermg._address", true));
            this.TBaddress.Location = new System.Drawing.Point(99, 227);
            this.TBaddress.Name = "TBaddress";
            this.TBaddress.Size = new System.Drawing.Size(740, 25);
            this.TBaddress.TabIndex = 17;
            // 
            // dS_videomg1
            // 
            this.dS_videomg1.DataSetName = "DS_videomg";
            this.dS_videomg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBzip
            // 
            this.TBzip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "membermg.zip", true));
            this.TBzip.Location = new System.Drawing.Point(99, 187);
            this.TBzip.Name = "TBzip";
            this.TBzip.Size = new System.Drawing.Size(289, 25);
            this.TBzip.TabIndex = 16;
            // 
            // TBpcs
            // 
            this.TBpcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBpcs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "membermg.pcs", true));
            this.TBpcs.Location = new System.Drawing.Point(524, 146);
            this.TBpcs.Name = "TBpcs";
            this.TBpcs.Size = new System.Drawing.Size(315, 25);
            this.TBpcs.TabIndex = 15;
            // 
            // TBphone
            // 
            this.TBphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "membermg.phone", true));
            this.TBphone.Location = new System.Drawing.Point(99, 146);
            this.TBphone.Name = "TBphone";
            this.TBphone.Size = new System.Drawing.Size(289, 25);
            this.TBphone.TabIndex = 14;
            // 
            // TBsex
            // 
            this.TBsex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBsex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "membermg.sex", true));
            this.TBsex.Location = new System.Drawing.Point(524, 107);
            this.TBsex.Name = "TBsex";
            this.TBsex.Size = new System.Drawing.Size(315, 25);
            this.TBsex.TabIndex = 13;
            // 
            // TBsinbun
            // 
            this.TBsinbun.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "membermg.sinbun", true));
            this.TBsinbun.Location = new System.Drawing.Point(99, 106);
            this.TBsinbun.Name = "TBsinbun";
            this.TBsinbun.Size = new System.Drawing.Size(289, 25);
            this.TBsinbun.TabIndex = 12;
            // 
            // TBjumin
            // 
            this.TBjumin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBjumin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "membermg.jumin", true));
            this.TBjumin.Location = new System.Drawing.Point(524, 66);
            this.TBjumin.Name = "TBjumin";
            this.TBjumin.Size = new System.Drawing.Size(315, 25);
            this.TBjumin.TabIndex = 11;
            // 
            // TBiname
            // 
            this.TBiname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "membermg.iname", true));
            this.TBiname.Location = new System.Drawing.Point(99, 66);
            this.TBiname.Name = "TBiname";
            this.TBiname.Size = new System.Drawing.Size(289, 25);
            this.TBiname.TabIndex = 10;
            // 
            // TBmcode
            // 
            this.TBmcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_videomg1, "membermg.mcode", true));
            this.TBmcode.Location = new System.Drawing.Point(99, 30);
            this.TBmcode.Name = "TBmcode";
            this.TBmcode.Size = new System.Drawing.Size(156, 25);
            this.TBmcode.TabIndex = 9;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(50, 231);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(47, 15);
            this.lbladdress.TabIndex = 8;
            this.lbladdress.Text = "주소 :";
            // 
            // lblzip
            // 
            this.lblzip.AutoSize = true;
            this.lblzip.Location = new System.Drawing.Point(20, 191);
            this.lblzip.Name = "lblzip";
            this.lblzip.Size = new System.Drawing.Size(77, 15);
            this.lblzip.TabIndex = 7;
            this.lblzip.Text = "우편번호 :";
            // 
            // lblpcs
            // 
            this.lblpcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpcs.AutoSize = true;
            this.lblpcs.Location = new System.Drawing.Point(460, 150);
            this.lblpcs.Name = "lblpcs";
            this.lblpcs.Size = new System.Drawing.Size(62, 15);
            this.lblpcs.TabIndex = 6;
            this.lblpcs.Text = "휴대폰 :";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(20, 150);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(77, 15);
            this.lblphone.TabIndex = 5;
            this.lblphone.Text = "전화번호 :";
            // 
            // lblsex
            // 
            this.lblsex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(475, 110);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(47, 15);
            this.lblsex.TabIndex = 4;
            this.lblsex.Text = "성별 :";
            // 
            // lblsinbun
            // 
            this.lblsinbun.AutoSize = true;
            this.lblsinbun.Location = new System.Drawing.Point(20, 110);
            this.lblsinbun.Name = "lblsinbun";
            this.lblsinbun.Size = new System.Drawing.Size(77, 15);
            this.lblsinbun.TabIndex = 3;
            this.lblsinbun.Text = "고객신분 :";
            // 
            // lbljumin
            // 
            this.lbljumin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbljumin.AutoSize = true;
            this.lbljumin.Location = new System.Drawing.Point(415, 70);
            this.lbljumin.Name = "lbljumin";
            this.lbljumin.Size = new System.Drawing.Size(107, 15);
            this.lbljumin.TabIndex = 2;
            this.lbljumin.Text = "주민등록번호 :";
            // 
            // lbliname
            // 
            this.lbliname.AutoSize = true;
            this.lbliname.Location = new System.Drawing.Point(35, 70);
            this.lbliname.Name = "lbliname";
            this.lbliname.Size = new System.Drawing.Size(62, 15);
            this.lbliname.TabIndex = 1;
            this.lbliname.Text = "고객명 :";
            // 
            // lblmcode
            // 
            this.lblmcode.AutoSize = true;
            this.lblmcode.Location = new System.Drawing.Point(20, 34);
            this.lblmcode.Name = "lblmcode";
            this.lblmcode.Size = new System.Drawing.Size(77, 15);
            this.lblmcode.TabIndex = 0;
            this.lblmcode.Text = "고객번호 :";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(13, 289);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(101, 36);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "추가";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.Bt_add_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(120, 289);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(101, 36);
            this.bt_save.TabIndex = 1;
            this.bt_save.Text = "저장";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.Bt_save_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(227, 289);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(101, 36);
            this.bt_delete.TabIndex = 1;
            this.bt_delete.Text = "삭제";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(334, 289);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(101, 36);
            this.bt_cancel.TabIndex = 1;
            this.bt_cancel.Text = "취소";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.Bt_cancel_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exit.Location = new System.Drawing.Point(778, 289);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(101, 36);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "나가기";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.Bt_exit_Click);
            // 
            // bt_Card
            // 
            this.bt_Card.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Card.Location = new System.Drawing.Point(671, 289);
            this.bt_Card.Name = "bt_Card";
            this.bt_Card.Size = new System.Drawing.Size(101, 36);
            this.bt_Card.TabIndex = 1;
            this.bt_Card.Text = "카드 관리";
            this.bt_Card.UseVisualStyleBackColor = true;
            this.bt_Card.Click += new System.EventHandler(this.Bt_Card_Click);
            // 
            // lblallmember
            // 
            this.lblallmember.AutoSize = true;
            this.lblallmember.Location = new System.Drawing.Point(21, 340);
            this.lblallmember.Name = "lblallmember";
            this.lblallmember.Size = new System.Drawing.Size(102, 15);
            this.lblallmember.TabIndex = 2;
            this.lblallmember.Text = "현재 고객 수 :";
            // 
            // lbl_allmcount
            // 
            this.lbl_allmcount.BackColor = System.Drawing.Color.Black;
            this.lbl_allmcount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_allmcount.ForeColor = System.Drawing.Color.White;
            this.lbl_allmcount.Location = new System.Drawing.Point(129, 334);
            this.lbl_allmcount.Name = "lbl_allmcount";
            this.lbl_allmcount.Size = new System.Drawing.Size(60, 28);
            this.lbl_allmcount.TabIndex = 3;
            this.lbl_allmcount.Text = "0 명";
            this.lbl_allmcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgMember
            // 
            this.dgMember.AllowUserToAddRows = false;
            this.dgMember.AllowUserToDeleteRows = false;
            this.dgMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMember.Location = new System.Drawing.Point(13, 365);
            this.dgMember.Name = "dgMember";
            this.dgMember.ReadOnly = true;
            this.dgMember.RowHeadersWidth = 51;
            this.dgMember.RowTemplate.Height = 27;
            this.dgMember.Size = new System.Drawing.Size(866, 201);
            this.dgMember.TabIndex = 4;
            this.dgMember.CurrentCellChanged += new System.EventHandler(this.DgMember_CurrentCellChanged);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT membermg.*\r\nFROM  membermg";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=localhost;Initial Catalog=Videomg;User ID=sa;Password=std001;Pooling=" +
    "False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@mcode", System.Data.SqlDbType.Int, 0, "mcode"),
            new System.Data.SqlClient.SqlParameter("@iname", System.Data.SqlDbType.VarChar, 0, "iname"),
            new System.Data.SqlClient.SqlParameter("@jumin", System.Data.SqlDbType.VarChar, 0, "jumin"),
            new System.Data.SqlClient.SqlParameter("@sinbun", System.Data.SqlDbType.VarChar, 0, "sinbun"),
            new System.Data.SqlClient.SqlParameter("@sex", System.Data.SqlDbType.VarChar, 0, "sex"),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar, 0, "phone"),
            new System.Data.SqlClient.SqlParameter("@pcs", System.Data.SqlDbType.VarChar, 0, "pcs"),
            new System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 0, "zip"),
            new System.Data.SqlClient.SqlParameter("@_address", System.Data.SqlDbType.VarChar, 0, "_address")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@mcode", System.Data.SqlDbType.Int, 0, "mcode"),
            new System.Data.SqlClient.SqlParameter("@iname", System.Data.SqlDbType.VarChar, 0, "iname"),
            new System.Data.SqlClient.SqlParameter("@jumin", System.Data.SqlDbType.VarChar, 0, "jumin"),
            new System.Data.SqlClient.SqlParameter("@sinbun", System.Data.SqlDbType.VarChar, 0, "sinbun"),
            new System.Data.SqlClient.SqlParameter("@sex", System.Data.SqlDbType.VarChar, 0, "sex"),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar, 0, "phone"),
            new System.Data.SqlClient.SqlParameter("@pcs", System.Data.SqlDbType.VarChar, 0, "pcs"),
            new System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 0, "zip"),
            new System.Data.SqlClient.SqlParameter("@_address", System.Data.SqlDbType.VarChar, 0, "_address"),
            new System.Data.SqlClient.SqlParameter("@Original_mcode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "mcode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_iname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "iname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_jumin", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "jumin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sinbun", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sinbun", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sinbun", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sinbun", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sex", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sex", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sex", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sex", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_phone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pcs", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pcs", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pcs", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pcs", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_zip", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "zip", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "zip", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull__address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "_address", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original__address", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "_address", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_mcode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "mcode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_iname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "iname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_jumin", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "jumin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sinbun", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sinbun", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sinbun", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sinbun", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sex", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sex", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sex", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sex", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_phone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pcs", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pcs", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pcs", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pcs", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_zip", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "zip", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "zip", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull__address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "_address", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original__address", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "_address", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "membermg", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("mcode", "mcode"),
                        new System.Data.Common.DataColumnMapping("iname", "iname"),
                        new System.Data.Common.DataColumnMapping("jumin", "jumin"),
                        new System.Data.Common.DataColumnMapping("sinbun", "sinbun"),
                        new System.Data.Common.DataColumnMapping("sex", "sex"),
                        new System.Data.Common.DataColumnMapping("phone", "phone"),
                        new System.Data.Common.DataColumnMapping("pcs", "pcs"),
                        new System.Data.Common.DataColumnMapping("zip", "zip"),
                        new System.Data.Common.DataColumnMapping("_address", "_address")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // MemberMg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 578);
            this.Controls.Add(this.dgMember);
            this.Controls.Add(this.lbl_allmcount);
            this.Controls.Add(this.lblallmember);
            this.Controls.Add(this.bt_Card);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.GB_memberinfo);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(909, 625);
            this.Name = "MemberMg";
            this.Text = "고객 정보";
            this.Load += new System.EventHandler(this.MemberMg_Load);
            this.GB_memberinfo.ResumeLayout(false);
            this.GB_memberinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_videomg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_memberinfo;
        private System.Windows.Forms.TextBox TBaddress;
        private System.Windows.Forms.TextBox TBzip;
        private System.Windows.Forms.TextBox TBpcs;
        private System.Windows.Forms.TextBox TBphone;
        private System.Windows.Forms.TextBox TBsex;
        private System.Windows.Forms.TextBox TBsinbun;
        private System.Windows.Forms.TextBox TBjumin;
        private System.Windows.Forms.TextBox TBiname;
        private System.Windows.Forms.TextBox TBmcode;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblzip;
        private System.Windows.Forms.Label lblpcs;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lblsinbun;
        private System.Windows.Forms.Label lbljumin;
        private System.Windows.Forms.Label lbliname;
        private System.Windows.Forms.Label lblmcode;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_Card;
        private System.Windows.Forms.Label lblallmember;
        private System.Windows.Forms.Label lbl_allmcount;
        private System.Windows.Forms.DataGridView dgMember;
        private DS_videomg dS_videomg1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}