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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ToolStripButton_Lent_Click(object sender, EventArgs e)
        {
            LentMg lmg = new LentMg();
            lmg.MdiParent = this;
            lmg.Show();
        }
        private void ToolStripButton_VMG_Click(object sender, EventArgs e)
        {
            VideoMg vmg = new VideoMg();
            vmg.MdiParent = this;
            vmg.Show();
        }
        private void ToolStripButton_MMG_Click(object sender, EventArgs e)
        {
            MemberMg mmg = new MemberMg();
            mmg.MdiParent = this;
            mmg.Show();
        }
        private void ToolStripButton_Search_Click(object sender, EventArgs e)
        {
            Search ser = new Search();
            ser.MdiParent = this;
            ser.Show();
        }
        private void ToolStripButton_VOption_Click(object sender, EventArgs e)
        {
            VOption vop = new VOption();
            vop.MdiParent = this;
            vop.Show();
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
