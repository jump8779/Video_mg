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
    public partial class VideoMg : Form
    {
        public VideoMg()
        {
            InitializeComponent();
        }

        private void GridView()
        {
            int Cnt;
            dgVideo.DataSource = dS_videomg1.Tables["videomg"];
            Cnt = BindingContext[dS_videomg1, "videomg"].Count;
            lbl_allvcount.Text = Cnt + " 개";
        }
        private void Bt_vinsert_Click(object sender, EventArgs e)
        {
            if (BindingContext[dS_videomg1, "videomg"].Count < 1)
            {
                bt_vdelete.Enabled = true;
                GB_videoinfo.Enabled = true;
            }
            BindingContext[dS_videomg1, "videomg"].EndCurrentEdit();
            BindingContext[dS_videomg1, "videomg"].AddNew();
            TBvcode.Select();
        }

        private void Bt_vsave_Click(object sender, EventArgs e)
        {
            try
            {
                BindingContext[dS_videomg1, "videomg"].EndCurrentEdit();
                GridView();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_vdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (BindingContext[dS_videomg1, "videomg"].Count > 0)
                {
                    BindingContext[dS_videomg1, "videomg"].RemoveAt(BindingContext[dS_videomg1, "videomg"].Position);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindingContext[dS_videomg1, "videomg"].EndCurrentEdit();
            GridView();
        }

        private void Bt_vcancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult CancleM;
                CancleM = MessageBox.Show("취소 하시겠습니까?", "데이터 추가",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (CancleM == DialogResult.Yes)
                {
                    BindingContext[dS_videomg1, "videomg"].CancelCurrentEdit();
                }
                else
                {
                    TBvcode.Select();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_update_Click(object sender, EventArgs e)
        {
            try
            {
                sqlDataAdapter1.Update(dS_videomg1.videomg);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VideoMg_Load(object sender, EventArgs e)
        {
            try
            {
                sqlDataAdapter1.Fill(dS_videomg1.videomg);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (BindingContext[dS_videomg1.videomg].Count < 1)
            {
                bt_vdelete.Enabled = false;
                GB_videoinfo.Enabled = false;
            }
            GridView();
        }

        private void DgVideo_CurrentCellChanged(object sender, EventArgs e)
        {
            if(dgVideo.CurrentCell == null)
            {
                return;
            }
            else
            {
                BindingContext[dS_videomg1, "videomg"].Position = dgVideo.CurrentRow.Index;
            }
        }
    }
}
