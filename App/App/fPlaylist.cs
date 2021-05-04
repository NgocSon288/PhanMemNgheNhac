using App.Common;
using App.Models;
using App.Services;
using App.UCs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class fPlaylist : UserControl
    {
        private readonly ISongService _songService;
        private readonly ISongCategoryService _songCategoryService;

        private List<PlaylistItemUC> PlaylistItemUCMockData;
        public List<PlaylistItemUC> PlaylistItemUCResult;
        private List<Song> Songs;
        private List<SongCategory> SongCategories;

        private List<int> CategoryListActive;
        private int stt = 1;

        public fPlaylist()
        {
            InitializeComponent();

            SetStatusFilter(false);

            Control.CheckForIllegalCrossThreadCalls = false;

            this._songService = new SongService();
            this._songCategoryService = new SongCategoryService();

            Load();
        }

        #region Events

        private async void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetStatusFilter(false);

                stt = 1;
                await FilterPlaylistItem();

                LoadPlaylistItemUC(new Action<bool>(SetStatusFilter));
            }
        }

        public async void DeleteByIDAndReload(int songId)
        {
            var item = PlaylistItemUCMockData.FirstOrDefault(s => s.Song.ID == songId);
            PlaylistItemUCMockData.Remove(item);

            SetStatusFilter(false);

            stt = 1;
            await FilterPlaylistItem();

            LoadPlaylistItemUC(new Action<bool>(SetStatusFilter));
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            SetStatusFilter(false);

            stt = 1;
            await FilterPlaylistItem();

            LoadPlaylistItemUC(new Action<bool>(SetStatusFilter));
        }

        private async void Btn_Click(object sender, EventArgs e)
        {
            SetStatusFilter(false);

            var btn = sender as Button;
            var categoryID = (int)btn.Tag;

            if (btn.ForeColor == Color.FromArgb(58, 216, 245))
            {
                CategoryListActive.Add(categoryID);
                btn.ForeColor = Color.FromArgb(40, 40, 40);
                btn.BackColor = Color.FromArgb(58, 216, 245);
            }
            else
            {
                CategoryListActive.RemoveAt(CategoryListActive.IndexOf(categoryID));
                btn.ForeColor = Color.FromArgb(58, 216, 245);
                btn.BackColor = Color.FromArgb(40, 40, 40);
            }

            stt = 1;
            await FilterPlaylistItem();

            LoadPlaylistItemUC(new Action<bool>(SetStatusFilter));
        }

        #endregion Events

        #region Methods

        public async Task Load()
        {
            Songs = await _songService.GetAll();
            SongCategories = await _songCategoryService.GetAll();
            CategoryListActive = new List<int>();
            PlaylistItemUCMockData = new List<PlaylistItemUC>();

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

        private Task FilterSongs()
        {
            Task task = new Task(() =>
            {
                var keyword = txtSearch.Text.Trim().ToUpper();

                if (keyword != "" && !CompareStringHelper.Contanins(keyword, "Nhập tên bài hát, nghệ sĩ"))
                {
                    Songs = Songs.Where(s => CompareStringHelper.Contanins(s.DisplayName, keyword) || CompareStringHelper.Contanins(s.ArtistsNames, keyword) || CompareStringHelper.Contanins(s.Performer, keyword)).ToList();
                }
                else
                {
                    Songs = Songs.ToList();
                }

                if (CategoryListActive.Count > 0)
                {
                    Songs = Songs.Where(s => CategoryListActive.Any(c => c == s.CategorySongID)).ToList();
                }
            });

            task.Start();

            return task;
        }

        private Task FilterPlaylistItem()
        {
            Task task = new Task(() =>
            {
                var keyword = txtSearch.Text.Trim().ToUpper();

                if (keyword != "" && !CompareStringHelper.Contanins(keyword, "Nhập tên bài hát, nghệ sĩ"))
                {
                    PlaylistItemUCResult = PlaylistItemUCMockData.Where(p =>
                    {
                        var s = p.Tag as Song;

                        return CompareStringHelper.Contanins(s.DisplayName, keyword) || CompareStringHelper.Contanins(s.ArtistsNames, keyword) || CompareStringHelper.Contanins(s.Performer, keyword);
                    }).ToList();
                }
                else
                {
                    PlaylistItemUCResult = PlaylistItemUCMockData.ToList();
                }

                if (CategoryListActive.Count > 0)
                {
                    PlaylistItemUCResult = PlaylistItemUCResult.Where(p =>
                    {
                        var s = p.Tag as Song;
                        return CategoryListActive.Any(c => c == s.CategorySongID);
                    }).ToList();
                }
            });

            task.Start();

            return task;
        }

        private async Task LoadPlaylistItem(Action<bool> callback)
        {
            Task task = new Task(() =>
            {
                flpPlaylist.Controls.Clear();
                PlaylistItemUC.STT = 1;

                foreach (var item in Songs)
                {
                    var playlistItem = new PlaylistItemUC(item);
                    playlistItem.Margin = new Padding(0, 0, 0, 0);
                    playlistItem.Tag = item;

                    this.BeginInvoke((Action)(() =>
                    {
                        flpPlaylist.Controls.Add(playlistItem);
                    }));
                    lblCount.Text = (PlaylistItemUC.STT - 1).ToString();

                    if (Constants.CurrentPlaylistItemUC != null && item.ID == Constants.CurrentPlaylistItemUC.Song.ID)
                    {
                        playlistItem.timerVisualiation.Start();
                        playlistItem.visualiation.Visible = true;

                        Constants.CurrentPlaylistItemUC = playlistItem;
                    }

                    PlaylistItemUCMockData.Add(playlistItem);
                }
            });

            task.Start();

            await task;
            PlaylistItemUCResult = PlaylistItemUCMockData.ToList();
            Constants.IsPlaulistReady = true;

            callback(true);
        }

        public void AddMockData(Song song)
        {
            SetStatusFilter(false);
            var playlistItem = new PlaylistItemUC(song);
            playlistItem.Margin = new Padding(0, 0, 0, 0);
            playlistItem.Tag = song;

            this.BeginInvoke((Action)(() =>
            {
                flpPlaylist.Controls.Add(playlistItem);
            }));
            lblCount.Text = (PlaylistItemUC.STT - 1).ToString();

            PlaylistItemUCMockData.Insert(PlaylistItemUCMockData.Count - 1, playlistItem);

            LoadPlaylistItemUC(new Action<bool>(SetStatusFilter));
        }

        private Task LoadPlaylistItemUC()
        {
            flpPlaylist.Controls.Clear();

            Task task = new Task(() =>
            {
                foreach (var item in PlaylistItemUCResult)
                {
                    this.BeginInvoke((Action)(() =>
                    {
                        flpPlaylist.Controls.Add(item);
                    }));

                    item.SetColorTop(stt);
                    lblCount.Text = (stt++).ToString();
                }
            });

            task.Start();
            return task;
        }

        private async Task LoadPlaylistItemUC(Action<bool> callback)
        {
            await LoadPlaylistItemUC();

            callback(true);
        }

        private void SetStatusFilter(bool status)
        {
            // block texhSearch
            txtSearch.Enabled = status;

            // block category
            flpCategory.Enabled = status;
        }

        public void UpdateFavoriteMusic(int songID)
        {
            foreach (PlaylistItemUC item in flpPlaylist.Controls)
            {
                var song = item.Tag as Song;
                if (song.ID == songID)
                {
                    // gọi update uc
                    item.UpdateHeartIcon();
                    return;
                }
            }
        }

        public void SetPlaying(Song s)
        {
            PlaylistItemUC curItem = null;
            foreach (PlaylistItemUC item in flpPlaylist.Controls)
            {
                item.visualiation.Visible = false;
                if (item.Song.ID == s.ID)
                {
                    curItem = item;
                }
            }
            curItem?.SetVisualiation();
        }

        public void ResetPlaying()
        {
            foreach (PlaylistItemUC item in flpPlaylist.Controls)
            {
                item.visualiation.Visible = false;
            }
        }

        #endregion Methods

        #region Header

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
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
    }
}