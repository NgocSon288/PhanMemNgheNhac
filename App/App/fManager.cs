using App.Common;
using App.Models;
using App.Services;
using App.UCs;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class fManager : UserControl
    {
        private readonly ISongService _songService;
        private readonly ISongCategoryService _songCategoryService;

        private List<Song> Songs;
        private Dictionary<int, string> SongCategories;

        private Song CurrentSong;

        public fManager()
        {
            InitializeComponent();

            this._songService = new SongService();
            this._songCategoryService = new SongCategoryService();

            Load();
        }

        #region Events

        private void lvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvList.SelectedItems != null && lvList.SelectedItems.Count > 0)
            {
                CurrentSong = lvList.SelectedItems[0].Tag as Song;

                LoadDetail(CurrentSong);
            }
        }

        #endregion Events

        #region Methods

        new public async Task Load()
        {
            Songs = await _songService.GetAll();
            SongCategories = new Dictionary<int, string>();
            foreach (var item in await _songCategoryService.GetAll())
            {
                SongCategories.Add(item.ID, item.DisplayName);
            }

            LoadListView();
            if (Songs.Count > 0)
            {
                CurrentSong = Songs[0];
                LoadDetail();
            }
        }

        private async Task LoadListView()
        {
            lvList.Clear();
            var id = 1;

            lvList.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lvList.Columns.Add("Tên bài hát", 750, HorizontalAlignment.Left);
            lvList.Columns.Add("Thể loại", 300, HorizontalAlignment.Left);
            lvList.Columns.Add("Tác giả", 500, HorizontalAlignment.Left);
            lvList.Columns.Add("Trình bài", 500, HorizontalAlignment.Left);

            foreach (var item in Songs)
            {
                var itemListView = new ListViewItem();
                itemListView.Tag = item;
                itemListView.Text = (id++).ToString();
                itemListView.SubItems.Add(item.DisplayName);
                itemListView.SubItems.Add(SongCategories[item.CategorySongID]);
                itemListView.SubItems.Add(item.ArtistsNames);
                itemListView.SubItems.Add(item.Performer);

                lvList.Items.Add(itemListView);
            }
        }

        private void LoadDetail(Song song = null)
        {
            if (song == null)
            {
                song = CurrentSong;
            }

            lblDisplayName.Text = song.DisplayName;
            lblIDZing.Text = song.IDZing;
            lblTitle.Text = song.Title;
            lblCategory.Text = SongCategories[song.CategorySongID];
            lblCode.Text = song.Code;
            lblArtistName.Text = song.ArtistsNames;
            lblPerformer.Text = song.Performer;

            var request = WebRequest.Create(song.Thumbnail);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                imgThumbnail.BackgroundImage = Bitmap.FromStream(stream);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentSong != null)
            {
                if (Constants.IsPlaulistReady && Constants.IsPersonalReady)
                {
                    var url = $"https://localhost:44309/Api/MusicAPIController/Delete/{CurrentSong.ID}";

                    HttpClient client = new HttpClient();

                    var text = await client.GetStringAsync(url);

                    if (text == "1")
                    {
                        Constants.isDelete = true;

                        Callback();

                        Songs.Remove(Songs.FirstOrDefault(s => s.ID == CurrentSong.ID));
                        Load();
                        if (Songs.Count > 0)
                        {
                            CurrentSong = Songs[0];
                            LoadDetail();
                        }
                    }

                    MessageBox.Show(text == "1" ? "Xóa thành công!" : "Xóa không thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng đợi");
                }
            }
        }

        private async Task Callback()
        {
            Constants.CurrentPlaylist.Load();
            Constants.CurrentPersonal.Load();
            Constants.isPriority = true;
            if (Constants.CurrentPlaylistItemUC?.Song?.ID == CurrentSong.ID || Constants.CurrentPlaylistItemPUC?.Song?.ID == CurrentSong.ID)
            {
                //Constants.MainForm.BtnNext_Click(Constants.MainForm.btnNext, new EventArgs
                Constants.CurrentPlaylistItemPUC = null;
                Constants.CurrentPlaylistItemUC = null;

                if (Constants.MainForm.isPlaying())
                {
                    Constants.MainMedia.Ctlcontrols.pause();
                    Constants.MainForm.btnPlay.IconChar = IconChar.PauseCircle;
                }
                else
                {
                    Constants.MainMedia.Ctlcontrols.play();
                    Constants.MainForm.btnPlay.IconChar = IconChar.PlayCircle;
                }

                Constants.MainForm.ResetDataSong();
            }
            else
            {
                Constants.CurrentPersonal.SetPlaying();
                //Constants.CurrentPlaylist.SetPlaying();
            }
            Constants.isPriority = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control item in Constants.CurrentManager.Controls)
            {
                if (item.Name != "panelContent")
                {
                    item.Visible = false;
                }
            }

            var createSongUC = new CreateSongUC();
            UIHelper.ShowControl(createSongUC, Constants.CurrentManager.panelContent);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (CurrentSong == null)
                return;

            foreach (Control item in Constants.CurrentManager.Controls)
            {
                if (item.Name != "panelContent")
                {
                    item.Visible = false;
                }
            }

            var updateSongUC = new UpdateSongUC(CurrentSong);
            UIHelper.ShowControl(updateSongUC, Constants.CurrentManager.panelContent);
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

        #endregion Header
    }
}