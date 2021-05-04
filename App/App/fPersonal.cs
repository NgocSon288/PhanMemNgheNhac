using App.Common;
using App.DatabaseLocal.Services;
using App.Models;
using App.Services;
using App.UCs;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class fPersonal : UserControl
    {
        private readonly ISongPersonalService _songPersonalService;
        private readonly ISongService _songService;
        private readonly ISongCategoryService _songCategoryService;

        private List<PlaylistItemPUC> PlaylistItemPUCMockData;
        public List<PlaylistItemPUC> PlaylistItemPUCResult;
        private List<Song> Songs;
        private List<SongCategory> SongCategories;

        private List<int> CategoryListActive;
        private int stt = 1;

        public fPersonal()
        {
            InitializeComponent();

            this._songPersonalService = new SongPersonalService();
            this._songService = new SongService();
            this._songCategoryService = new SongCategoryService();

            Load();
        }

        #region Methods

        // Load item from  Static

        new public async Task Load()
        {
            flpPlaylist.Size = new Size(flpPlaylist.Size.Width, flpPlaylist.Size.Height + 300);
            flpFavoriteList.Size = new Size(flpFavoriteList.Size.Width, flpFavoriteList.Size.Height + 300);

            Songs = await _songService.GetAll();
            SongCategories = await _songCategoryService.GetAll();
            CategoryListActive = new List<int>();
            PlaylistItemPUCMockData = new List<PlaylistItemPUC>();

            LoadCategory();

            SetStatusFilter(false);

            LoadPlaylistItem(new Action<bool>(SetStatusFilter));
        }

        private void LoadCategory()
        {
            flpCategory.Controls.Clear();

            foreach (var item in SongCategories)
            {
                var btn = new Button()
                {
                    Width = 260,
                    Height = 60,
                    Text = item.DisplayName,
                    ForeColor = Color.FromArgb(58, 216, 245),
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(40, 5, 80, 5)
                };

                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.BorderColor = Color.FromArgb(58, 216, 245);
                btn.Tag = item.ID;
                btn.Click += Btn_Click;
                btn.Font = new Font(btn.Font.FontFamily, 10);

                flpCategory.Controls.Add(btn);
            }
        }

        private async void Btn_Click(object sender, EventArgs e)
        {
        }

        public async void UpdateFavoriteMusic(Song s = null)
        {
            SetStatusPlaylist();

            stt = 0;

            await FilterPlaylistItem();

            await LoadPlaylistItemUC(new Action<bool>(SetStatusFilter));

            if (flpPlaylist.Controls.Count <= 0)
            {
                lblCount.Text = "0";
            }

            SetStatusPlaylist();

            if (s != null)
            {
                SetPlaying();
            }
        }

        private async Task LoadPlaylistItemUC(Action<bool> callback)
        {
            PlaylistItemPUCResult.ForEach(item =>
            {
                item.btnHeart.IconColor = Color.FromArgb(144, 0, 161);
                item.btnHeart.IconChar = IconChar.Heartbeat;
            });

            await LoadPlaylistItemUC();

            callback(true);
        }

        public async void DeleteByIDAndReload(int songId)
        {
            var item = PlaylistItemPUCMockData.FirstOrDefault(s => s.Song.ID == songId);
            PlaylistItemPUCMockData.Remove(item);

            SetStatusFilter(false);

            stt = 1;
            await FilterPlaylistItem();

            LoadPlaylistItemUC(new Action<bool>(SetStatusFilter));

            UpdateFavoriteMusic();
        }

        private Task LoadPlaylistItemUC()
        {
            flpPlaylist.Controls.Clear();

            Task task = new Task(() =>
            {
                foreach (var item in PlaylistItemPUCResult)
                {
                    this.BeginInvoke((Action)(() =>
                    {
                        flpPlaylist.Controls.Add(item);
                    }));

                    item.SetColorTop(++stt);
                    lblCount.Text = (stt).ToString();
                }
            });

            task.Start();
            return task;
        }

        private async Task LoadPlaylistItem(Action<bool> callback)
        {
            flpPlaylist.Visible = false;
            lblCount.Visible = false;
            Task task = new Task(() =>
            {
                flpPlaylist.Controls.Clear();
                PlaylistItemPUC.STT = 1;
                var favoriteSongs = _songPersonalService.GetAll().Select(f => f.ID).ToList();

                foreach (var item in Songs)
                {
                    var playlistItem = new PlaylistItemPUC(item);
                    playlistItem.Margin = new Padding(0, 0, 0, 0);
                    playlistItem.Tag = item;
                    playlistItem.Width = playlistItem.Width - 15;

                    if (favoriteSongs.Contains(item.ID))
                    {
                        this.BeginInvoke((Action)(() =>
                        {
                            flpPlaylist.Controls.Add(playlistItem);
                        }));
                        lblCount.Text = (PlaylistItemPUC.STT - 1).ToString();
                    }

                    if (Constants.CurrentPlaylistItemUC != null && item.ID == Constants.CurrentPlaylistItemUC.Song.ID)
                    {
                        playlistItem.timerVisualiation.Start();
                        playlistItem.visualiation.Visible = true;

                        Constants.CurrentPlaylistItemPUC = playlistItem;
                    }

                    PlaylistItemPUCMockData.Add(playlistItem);
                }
            });

            task.Start();

            await task;
            PlaylistItemPUCResult = PlaylistItemPUCMockData.ToList();
            Constants.IsPersonalReady = true;

            var a = flpPlaylist.Controls.Count;
            SetStatusPlaylist();

            callback(true);
            UpdateFavoriteMusic();        // nào lỗi bật lên
            lblCount.Visible = true;
            flpPlaylist.Visible = true;
        }

        private async Task FilterPlaylistItem()
        {
            Task task = new Task(() =>
            {
                var keyword = txtSearch.Text.Trim().ToUpper();

                if (keyword != "" && !CompareStringHelper.Contanins(keyword, "Nhập tên bài hát, nghệ sĩ hoặc MV..."))
                {
                    PlaylistItemPUCResult = PlaylistItemPUCMockData.Where(p =>
                    {
                        var s = p.Tag as Song;

                        return CompareStringHelper.Contanins(s.DisplayName, keyword) || CompareStringHelper.Contanins(s.ArtistsNames, keyword) || CompareStringHelper.Contanins(s.Performer, keyword);
                    }).ToList();
                }
                else
                {
                    PlaylistItemPUCResult = PlaylistItemPUCMockData.ToList();
                }

                if (CategoryListActive.Count > 0)
                {
                    PlaylistItemPUCResult = PlaylistItemPUCResult.Where(p =>
                    {
                        var s = p.Tag as Song;
                        return CategoryListActive.Any(c => c == s.CategorySongID);
                    }).ToList();
                }

                // filter by localfile
                var favoriteSongs = _songPersonalService.GetAll().Select(f => f.ID).ToList();
                PlaylistItemPUCResult = PlaylistItemPUCResult.Where(p => favoriteSongs.Contains(p.Song.ID)).ToList();
            });

            task.Start();
            await task;
            PlaylistItemPUCResult = PlaylistItemPUCResult.OrderBy(p => p.order).ToList();
        }

        private void SetStatusFilter(bool status)
        {
            // block texhSearch
            txtSearch.Enabled = status;

            // block category
            flpCategory.Enabled = status;
        }

        private void SetStatusPlaylist()
        {
            if (flpPlaylist.Controls.Count <= 0)
            {
                flpPlaylist.Visible = false;
            }
            else
            {
                flpPlaylist.Visible = true;
            }
        }

        public void SetPlaying()
        {
            PlaylistItemPUC curItem = null;
            foreach (PlaylistItemPUC item in flpPlaylist.Controls)
            {
                item.visualiation.Visible = false;
                if (item.Song.ID == Constants.CurrentPlaylistItemUC?.Song.ID || item.Song.ID == Constants.CurrentPlaylistItemPUC?.Song.ID)
                {
                    curItem = item;
                }
            }

            curItem?.SetVisualiation();
        }

        public void ResetPlaying()
        {
            foreach (PlaylistItemPUC item in flpPlaylist.Controls)
            {
                item.visualiation.Visible = false;
            }
        }

        #endregion Methods

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

        #endregion Header

        #region UI

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as IconButton;
            btn.BackColor = Color.FromArgb(23, 15, 35);
            btn.IconColor = Color.FromArgb(255, 34, 101);
            btn.ForeColor = Color.FromArgb(255, 34, 101);
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as IconButton;
            btn.BackColor = Color.FromArgb(23, 15, 35);
            btn.IconColor = Color.FromArgb(68, 226, 255);
            btn.ForeColor = Color.FromArgb(68, 226, 255);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Constants.IsPersonalReady)
                flpPlaylist.Visible = !flpPlaylist.Visible;
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as IconButton;
            btn.BackColor = Color.FromArgb(23, 15, 35);
            btn.IconColor = Color.FromArgb(255, 34, 101);
            btn.ForeColor = Color.FromArgb(255, 34, 101);
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as IconButton;
            btn.BackColor = Color.FromArgb(23, 15, 35);
            btn.IconColor = Color.FromArgb(68, 226, 255);
            btn.ForeColor = Color.FromArgb(68, 226, 255);
        }

        #endregion UI
    }
}