using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Video_mg
{
    public partial class LentMg : Form
    {
        public LentMg()
        {
            InitializeComponent();
            DBCon();
        }

        SqlConnection sql;
        SqlCommand sqlC;
        SqlCommand sqlC2;
        SqlDataAdapter sqlA;
        SqlDataAdapter sqlA2;
        DataSet DS;
        DataSet DS2;
        int i, j;

        public void DBCon()
        {
            String c = "server=jump8779;database=Videomg;uid=sa;pwd=std001";
            sql = new SqlConnection(c);
            sql.Open(); // 서버 연결
        }
        public void MemberSelect()
        {
            String s = "SELECT * FROM lent WHERE mcode=@mcode"; 
            sqlC2 = new SqlCommand(s, sql);
            sqlC2.Parameters.Add("@mcode", SqlDbType.Int, 4);
            sqlC2.Parameters["@mcode"].Value = TBcode.Text;

            sqlA2 = new SqlDataAdapter();
            sqlA2.SelectCommand = sqlC2; // Select문 명령으로 sqlC2를 넘겨줌
            try
            {
                DS2 = new DataSet();
                DS2.Clear();
                sqlA2.TableMappings.Add("Table", "lent"); // 소스네임"Table"의 "lent"테이블 생성
                sqlA2.Fill(DS2, "Table"); // Fill의 파라미터로는 소스네임을 넘겨줌

                lbl_alllentcount.Text = DS2.Tables["lent"].Rows.Count + " 개";
                dgVideo.DataSource = DS2.Tables["lent"];
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LentMg_Load(object sender, EventArgs e)
        {

        }

        private void Bt_readC_Click(object sender, EventArgs e)
        {

        }

        private void Bt_search_Click(object sender, EventArgs e)
        {
            String s = "SELECT * FROM membermg WHERE iname='" + STBname.Text +
            "' OR mcode='" + STBcode.Text +
            "' OR phone='" + STBphone.Text +
            "' OR pcs='" + STBpcs.Text + "'";
            sqlC = new SqlCommand(s, sql);
            sqlA = new SqlDataAdapter();
            sqlA.SelectCommand = sqlC;
            try
            {
                DS = new DataSet();
                DS.Clear();
                sqlA.TableMappings.Add("Table", "membermg");
                sqlA.Fill(DS, "Table");
                if (DS.Tables["membermg"].Rows.Count == 1)
                {
                    DataRow Row = DS.Tables["membermg"].Rows[0];
                    TBcode.Text = Row["mcode"].ToString();
                    TBname.Text = Row["iname"].ToString();
                    TBjumin.Text = Row["jumin"].ToString();
                    TBsinbun.Text = Row["sinbun"].ToString();
                    TBphone.Text = Row["phone"].ToString();
                    TBpcs.Text = Row["pcs"].ToString();
                    TBzip.Text = Row["zip"].ToString();
                    TBaddress.Text = Row["_address"].ToString();

                    MemberSelect();
                }
                else if (DS.Tables["membermg"].Rows.Count < 1)
                {
                    DialogResult msg;
                    msg = MessageBox.Show("고객 정보가 없습니다. 추가하시겠습니까?", "고객 정보",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (msg == DialogResult.Yes)
                    {
                        MemberMg member = new MemberMg();
                        member.MdiParent = this.MdiParent;
                        member.Show();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    DialogResult msg;
                    msg = MessageBox.Show("중복된 정보가 있습니다.", "고객 정보",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (msg == DialogResult.OK)
                    {
                        tabControl1.SelectedIndex = 1;
                        dgMember.DataSource = DS;
                        dgMember.DataMember = "membermg";
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            STBname.Text = "";
            STBcode.Text = "";
            STBphone.Text = "";
            STBpcs.Text = "";
        }

        private void Bt_choice_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow Row = DS.Tables["membermg"].Rows[dgMember.CurrentCell.RowIndex];
                TBcode.Text = Row["mcode"].ToString();
                TBname.Text = Row["iname"].ToString();
                TBjumin.Text = Row["jumin"].ToString();
                TBsinbun.Text = Row["sinbun"].ToString();
                TBphone.Text = Row["phone"].ToString();
                TBpcs.Text = Row["pcs"].ToString();
                TBzip.Text = Row["zip"].ToString();
                TBaddress.Text = Row["_address"].ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MemberSelect();
        }

        private void Bt_vmatch_Click(object sender, EventArgs e)
        {
            bt_save.Enabled = true;

            SqlCommand sqlC3;
            SqlDataAdapter sqlA3 = new SqlDataAdapter();
            DataSet DS3 = new DataSet();

            string s = "SELECT * FROM videomg WHERE vcode='" + TBvcode.Text +
                "' OR _subject='" + TBvtitle.Text + "'";
            sqlC3 = new SqlCommand(s, sql);
            sqlA3.SelectCommand = sqlC3;

            SqlCommand sqlC4;
            SqlDataAdapter sqlA4 = new SqlDataAdapter();
            string s2 = "SELECT * FROM lentoption";

            sqlC4 = new SqlCommand(s2, sql);
            sqlA4.SelectCommand = sqlC4;

            try
            {
                sqlA3.TableMappings.Add("Table", "videomg");
                sqlA3.Fill(DS3, "Table");
                sqlA4.TableMappings.Add("Table", "lentoption");
                sqlA4.Fill(DS3, "Table");

                DataRow VRow, Row;
                VRow = DS3.Tables["videomg"].Rows[0];
                TBvcode.Text = VRow["vcode"].ToString();
                TBvtitle.Text = VRow["_subject"].ToString();
                DateTime dt = dateTimePicker1.Value;

                foreach (DataRow ORow in DS3.Tables["lentoption"].Rows)
                {
                    DateTime date = Convert.ToDateTime(VRow["out_date"]);
                    date = date.AddDays(Convert.ToDouble(ORow["vdate"]));
                    if (DateTime.Today.Date < date)
                    {
                        Row = DS3.Tables["lentoption"].Rows[0];
                    }
                    else
                    {
                        Row = DS3.Tables["lentoption"].Rows[1];
                    }
                    TBlentpay.Text = Row["lent_pay"].ToString();
                    TBdelaypay.Text = Row["delay_pay"].ToString();
                    TBoutdate.Text = dt.AddDays(Convert.ToDouble(Row["lent_date"])).ToString();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_save_Click(object sender, EventArgs e)
        {
            SqlCommand sqlC3;
            string s = "INSERT INTO lent (mcode, vcode, lent_date, return_date1," +
                " return_date2, lent_pay, delay_pay1, delay_pay2, vsubject) " +
                "VALUES (@mcode, @vcode, @lent_date, @return_date1, @return_date2, " +
                "@lent_pay, @delay_pay1, @delay_pay2, @vsubject)"; // sql문

            sqlC3 = new SqlCommand(s, sql);
            sqlA2 = new SqlDataAdapter();
            sqlA2.InsertCommand = sqlC3; // Insert문 명령으로 sqlC3을 넘겨줌

            sqlC3.Parameters.Add("@mcode", SqlDbType.Int, 4);
            sqlC3.Parameters.Add("@vcode", SqlDbType.VarChar, 14);
            sqlC3.Parameters.Add("@lent_date", SqlDbType.VarChar, 10);
            sqlC3.Parameters.Add("@return_date1", SqlDbType.VarChar, 10);
            sqlC3.Parameters.Add("@return_date2", SqlDbType.VarChar, 10);
            sqlC3.Parameters.Add("@lent_pay", SqlDbType.Int, 4);
            sqlC3.Parameters.Add("@delay_pay1", SqlDbType.Int, 4);
            sqlC3.Parameters.Add("@delay_pay2", SqlDbType.Int, 4);
            sqlC3.Parameters.Add("@vsubject", SqlDbType.VarChar, 100);

            DataRow LRow;
            LRow = DS2.Tables["lent"].NewRow();

            LRow["mcode"] = TBcode.Text;
            LRow["vcode"] = TBvcode.Text;
            LRow["lent_date"] = dateTimePicker1.Value;
            LRow["vsubject"] = TBvtitle.Text;
            LRow["return_date1"] = TBoutdate.Text;
            LRow["return_date2"] = "대여중";
            LRow["lent_pay"] = TBlentpay.Text;
            LRow["delay_pay1"] = TBdelaypay.Text;
            LRow["delay_pay2"] = 0;

            DS2.Tables["lent"].Rows.Add(LRow);

            sqlC3.Parameters["@mcode"].Value = LRow["mcode"];
            sqlC3.Parameters["@vcode"].Value = LRow["vcode"];
            sqlC3.Parameters["@vsubject"].Value = LRow["vsubject"];
            sqlC3.Parameters["@lent_date"].Value = LRow["lent_date"];
            sqlC3.Parameters["@return_date1"].Value = LRow["return_date1"];
            sqlC3.Parameters["@return_date2"].Value = LRow["return_date2"];
            sqlC3.Parameters["@lent_pay"].Value = LRow["lent_pay"];
            sqlC3.Parameters["@delay_pay1"].Value = LRow["delay_pay1"];
            sqlC3.Parameters["@delay_pay2"].Value = LRow["delay_pay2"];

            i += Convert.ToInt32(LRow["lent_pay"]);
            lbl_alllentpay.Text = i + " 원";
            lbl_alllentcount.Text = DS2.Tables["lent"].Rows.Count + " 개";

            sqlA2.Update(DS2.Tables["lent"]); // DB 업데이트

            TBvcode.Text = "";
            TBvtitle.Text = "";
            TBlentpay.Text = "";
            TBdelaypay.Text = "";
            TBoutdate.Text = "0000-00-00";
            bt_save.Enabled = false;
        }

        private void Bt_vreturn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlC3;
            string s = "UPDATE lent SET mcode = @mcode, return_date2 = @return_date2, " +
                "delay_pay2 = @delay_pay2 WHERE lentcode = @lentcode";
            sqlC3 = new SqlCommand(s, sql);
            sqlA2.UpdateCommand = sqlC3; // update문 명령으로 sqlC3을 넘겨줌

            sqlC3.Parameters.Add("@mcode", SqlDbType.Int, 4);
            sqlC3.Parameters.Add("@return_date2", SqlDbType.VarChar, 10);
            sqlC3.Parameters.Add("@delay_pay2", SqlDbType.Int, 4);
            sqlC3.Parameters.Add("@lentcode", SqlDbType.Int, 4);

            try
            {
                DataRow LRow = DS2.Tables["lent"].Rows[dgVideo.CurrentCell.RowIndex];

                TimeSpan DT = DateTime.Today.Date - Convert.ToDateTime(LRow["return_date1"]);
                int k = Convert.ToInt32(DT.TotalDays);

                LRow.BeginEdit(); 
                LRow["return_date2"] = DateTime.Today.Date;
                if (k < 1)
                {
                    LRow["mcode"] = "-" + LRow["mcode"];
                }
                else
                {
                    LRow["delay_pay2"] = Convert.ToInt32(LRow["delay_pay1"]) * k;

                    DialogResult msg;
                    msg = MessageBox.Show(LRow["delay_pay2"] + " 원의 연체료가 있습니다." +
                        "삭제하겠습니까?", "대여 비디오 반납", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        LRow["mcode"] = "-" + LRow["mcode"];
                    }
                    else if (msg == DialogResult.No)
                    {
                        j += Convert.ToInt32(LRow["delay_pay2"]);
                        lbl_alldelaypay.Text = j + " 원";
                    }
                    else
                    {
                        LRow.RejectChanges();
                    }
                }
                LRow.EndEdit();
                sqlC3.Parameters["@lentcode"].Value = LRow["lentcode"];
                sqlC3.Parameters["@mcode"].Value = LRow["mcode"];
                sqlC3.Parameters["@return_date2"].Value = LRow["return_date2"].ToString();
                sqlC3.Parameters["@delay_pay2"].Value = LRow["delay_pay2"];
                sqlA2.Update(DS2.Tables["lent"]); // DB 업데이트
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MemberSelect();
        }

        private void LentMg_FormClosing(object sender, FormClosingEventArgs e)
        {
            sql.Close();
        }
    }
}
