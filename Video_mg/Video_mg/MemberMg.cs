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
    public partial class MemberMg : Form
    {
        public MemberMg()
        {
            InitializeComponent();
        }

        public void GridView()
        {
            int Cnt;
            Cnt = BindingContext[dS_videomg1, "membermg"].Count;
            lbl_allmcount.Text = Cnt + " 명";
            dgMember.DataSource = dS_videomg1.Tables["membermg"];
        }
        private void MemberMg_Load(object sender, EventArgs e)
        {
            try
            {
                sqlDataAdapter1.Fill(dS_videomg1.membermg);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (BindingContext[dS_videomg1, "membermg"].Count < 1)
            {
                bt_delete.Enabled = false;
                GB_memberinfo.Enabled = false;
            }
            GridView();
        }

        private void Bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (BindingContext[dS_videomg1, "membermg"].Count < 1)
                {
                    bt_delete.Enabled = true;
                    GB_memberinfo.Enabled = true;
                }
                BindingContext[dS_videomg1, "membermg"].EndCurrentEdit();
                BindingContext[dS_videomg1, "membermg"].AddNew();
                TBmcode.Select();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "memebermg", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                BindingContext[dS_videomg1, "membermg"].EndCurrentEdit();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlDataAdapter1.Update(dS_videomg1.membermg);
            GridView();
        }

        private void Bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                BindingContext[dS_videomg1, "membermg"].RemoveAt(BindingContext[dS_videomg1, "membermg"].Position);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GridView();
        }

        private void Bt_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult CancleM;
                CancleM = MessageBox.Show("취소 하시겠습니까?", "작성 취소", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (CancleM == DialogResult.Yes)
                {
                    BindingContext[dS_videomg1, "membermg"].CancelCurrentEdit();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_Card_Click(object sender, EventArgs e)
        {

        }

        private void Bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgMember_CurrentCellChanged(object sender, EventArgs e)
        {
            if(dgMember.CurrentCell == null)
            {
                return;
            }
            else
            {
                BindingContext[dS_videomg1, "membermg"].Position = dgMember.CurrentRow.Index;
            }
        }
    }
}
