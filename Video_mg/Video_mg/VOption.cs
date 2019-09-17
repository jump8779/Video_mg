using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_mg
{
    public partial class VOption : Form
    {
        public VOption()
        {
            InitializeComponent();
            DataLoad();
        }
        public void DataLoad()
        {
            dS_videomg1.Clear();
            sqlDataAdapter1.Fill(dS_videomg1.lentoption);

            if (dS_videomg1.lentoption.Rows.Count < 1)
            {
                bt_registe.Enabled = true;
            }
            else
            {
                foreach (DataRow ORow in dS_videomg1.lentoption.Rows)
                {
                    if (ORow["vcode"].ToString() == "1")
                    {
                        TBnew_cdate.Text = ORow["vdate"].ToString();
                        TBnew_lentdate.Text = ORow["lent_date"].ToString();
                        TBnew_lentpay.Text = ORow["lent_pay"].ToString();
                        TBnew_delaypay.Text = ORow["delay_pay"].ToString();
                    }
                    else if (ORow["vcode"].ToString() == "2")
                    {
                        TBold_lentdate.Text = ORow["lent_date"].ToString();
                        TBold_lentpay.Text = ORow["lent_pay"].ToString();
                        TBold_delaypay.Text = ORow["delay_pay"].ToString();
                    }
                }
                bt_registe.Enabled = false;
            }
        }

        private void Bt_registe_Click(object sender, EventArgs e)
        {
            DataRow ORow;
            ORow = dS_videomg1.lentoption.NewRow();
            ORow["vcode"] = 1;
            ORow["vdate"] = TBnew_cdate.Text;
            ORow["lent_date"] = TBnew_lentdate.Text;
            ORow["lent_pay"] = TBnew_lentpay.Text;
            ORow["delay_pay"] = TBnew_delaypay.Text;
            dS_videomg1.lentoption.Rows.Add(ORow);

            ORow = dS_videomg1.lentoption.NewRow();
            ORow["vcode"] = 2;
            ORow["vdate"] = TBnew_cdate.Text;
            ORow["lent_date"] = TBold_lentdate.Text;
            ORow["lent_pay"] = TBold_lentpay.Text;
            ORow["delay_pay"] = TBold_delaypay.Text;
            dS_videomg1.lentoption.Rows.Add(ORow);
            sqlDataAdapter1.Update(dS_videomg1.lentoption);
            bt_registe.Enabled = false;
        }

        private void Bt_edit_Click(object sender, EventArgs e)
        {
            DataRow ORow;
            ORow = dS_videomg1.lentoption.Rows[0];
            ORow.BeginEdit();
            ORow["vcode"] = 1;
            ORow["vdate"] = TBnew_cdate.Text;
            ORow["lent_date"] = TBnew_lentdate.Text;
            ORow["lent_pay"] = TBnew_lentpay.Text;
            ORow["delay_pay"] = TBnew_delaypay.Text;
            ORow.EndEdit();

            ORow = dS_videomg1.lentoption.Rows[1];
            ORow.BeginEdit();
            ORow["vcode"] = 2;
            ORow["vdate"] = TBnew_cdate.Text;
            ORow["lent_date"] = TBold_lentdate.Text;
            ORow["lent_pay"] = TBold_lentpay.Text;
            ORow["delay_pay"] = TBold_delaypay.Text;
            ORow.EndEdit();
            sqlDataAdapter1.Update(dS_videomg1.lentoption);
        }

        private void Bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
