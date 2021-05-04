using App.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class fOrder : UserControl
    {
        public fOrder()
        {
            InitializeComponent();
        }

        #region Header

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, System.EventArgs e)
        {
            Constants.MainForm.WindowState = FormWindowState.Minimized;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            pnlSearchUnderline.BackColor = Color.FromArgb(230, 230, 230);
            txtSearch.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            pnlSearchUnderline.BackColor = Color.FromArgb(150, 150, 150);
            txtSearch.ForeColor = Color.FromArgb(150, 150, 150);

            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm: nhập tên bài hát, nghệ sĩ hoặc MV...";
            }
        }

        #endregion
    }
}
