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
            sql.Open();
        }
        public void MemberSelect()
        {
            String s = "SELECT * FROM lent WHERE mcode=@mcode";
            sqlC2 = new SqlCommand(s, sql);
            sqlC2.Parameters.Add("@mcode", SqlDbType.Int, 4);
            sqlC2.Parameters["@mcode"].Value = TBcode.Text;

            sqlA2 = new SqlDataAdapter();
            sqlA2.SelectCommand = sqlC2;
            try
            {
                DS2 = new DataSet();
                DS2.Clear();
                sqlA2.TableMappings.Add("Table", "lent");
                sqlA2.Fill(DS2, "Table");

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
                    foreach (DataRow Row in DS.Tables["membermg"].Rows)
                    {
                        TBcode.Text = Row["mcode"].ToString();
                        TBname.Text = Row["iname"].ToString();
                        TBjumin.Text = Row["jumin"].ToString();
                        TBsinbun.Text = Row["sinbun"].ToString();
                        TBphone.Text = Row["phone"].ToString();
                        TBpcs.Text = Row["pcs"].ToString();
                        TBzip.Text = Row["zip"].ToString();
                        TBaddress.Text = Row["_address"].ToString();
                    }
                    MemberSelect();
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
            
        }

        private void Bt_save_Click(object sender, EventArgs e)
        {
            
        }

        private void Bt_vreturn_Click(object sender, EventArgs e)
        {
            
        }

        private void LentMg_FormClosing(object sender, FormClosingEventArgs e)
        {
            sql.Close();
        }
    }
}
