using App.Common;
using FontAwesome.Sharp;
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
    public partial class fMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public fMain()
        {
            InitializeComponent();
              
            Constants.MainMedia = new AxWMPLib.AxWindowsMediaPlayer();
            Constants.MainMedia.Visible = false;

            this.Controls.Add(Constants.MainMedia);

            Load();

            panel2.Location = new Point(0, 0);
        }

        #region Events

         
        #endregion Events

        #region Method

        new private async void Load()
        {
            imgLogo.BackgroundImage = new Bitmap(Constants.ROOT_PATH + "Assets/Images/logo-zing.png");
            imgLogo.BackgroundImageLayout = ImageLayout.Stretch;
            imgThumbnail.BackgroundImage = new Bitmap(Constants.ROOT_PATH + "Assets/Images/thumnail-default.png");
            imgThumbnail.BackgroundImageLayout = ImageLayout.Stretch;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 100);
            panelMenu.Controls.Add(leftBorderBtn);

            VisibleButton();

            Reset();
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();



                //Button transition
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Constants.ACTIVE_BUTTON_BG_COLOR;
                currentBtn.ForeColor = Constants.BORDER_MENU_LEFT_COLOR;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Constants.BORDER_MENU_LEFT_COLOR;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = Constants.BORDER_MENU_LEFT_COLOR;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Constants.MEMU_LEFT_BACKGROUND;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            //Show user control tương ứng
            //var fPersonal = new fPersonal();
            //UIHelper.ShowControl(fPersonal, panelContent);
        }

        private void VisibleButton()
        {
            btnPersonal.Visible = true;
            btnSongs.Visible = true;
            btnHistory.Visible = true;
            btnOrderFirst.Visible = true;
            btnOrderSecond.Visible = true;
        }

        #endregion Method

        #region Header
          
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Constants.MainForm.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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


        #endregion Window state


        private void imgLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            // Show user control tương ứng
            //var fPersonal = new fPersonal();
            //UIHelper.ShowControl(fPersonal, panelContent);
        }

        private void btnSongs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            //var fMusicList = new fMusicList();
            //UIHelper.ShowControl(fMusicList, panelContent);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            //var fHistory = new fHistory();
            //UIHelper.ShowControl(fHistory, panelContent);
        }

        private void btnOrderFirst_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            //var fOrder = new fOrder();
            //UIHelper.ShowControl(fOrder, panelContent);
        }

        private void btnOrderSecond_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            //var fOrder = new fOrder();
            //UIHelper.ShowControl(fOrder, panelContent);
        }

        #region Controls

        private void btnRandom_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Constants.MainMedia.Ctlcontrols.play();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {

        }


        #endregion

    }
}