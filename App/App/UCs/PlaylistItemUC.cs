using App.Common;
using App.DatabaseLocal.Models;
using App.DatabaseLocal.Services;
using App.Models;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace App.UCs
{
    public partial class PlaylistItemUC : UserControl
    {
        private readonly ISongPersonalService _songPersonalService;

        public static int STT = 1;

        public Song Song;

        public PlaylistItemUC(Song song)
        {
            InitializeComponent();

            this._songPersonalService = new SongPersonalService();

            this.Song = song;

            Load();
        }

        private Color EnterColor = Color.FromArgb(45, 37, 55);
        private Color LeaveColor = Color.FromArgb(23, 15, 35);

        private int VisualiationMusicCount = 5;

        #region Methods

        new private void Load()
        {
            this.MouseEnter += PlaylistItemEnter;
            this.MouseLeave += (o, e) =>
            {
                SetPlaylistItemColor(LeaveColor);
            };

            foreach (Control item in this.Controls)
            {
                item.MouseHover += PlaylistItemEnter;
            }

            this.MouseDoubleClick += PlayListItemMouseDoubleClick;

            SetColorTop(STT);

            STT++;

            var request = WebRequest.Create(Song.Thumbnail);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                imgThumbnail.BackgroundImage = Bitmap.FromStream(stream);
            }

            lblSongName.Text = Song.DisplayName.Length > 35 ? Song.DisplayName.Substring(0, 35) + "..." : Song.DisplayName;
            lblDuration.Text = $"{(Song.Duration / 60).ToString().PadLeft(2, '0')}:{(Song.Duration % 60).ToString().PadLeft(2, '0')}";
            lblArtistsName.Text = Song.ArtistsNames;

            if (IsFavorite())
            {
                btnHeart.IconColor = Color.FromArgb(144, 0, 161);
                btnHeart.IconChar = IconChar.Heartbeat;
            }

            if (fLayout.SongSeens.Any(s => s.ID == Song.ID))
            {
                if (!btnEye.Visible)
                {
                    btnEye.Visible = true;
                }
            }
            else
            {
                if (btnEye.Visible)
                {
                    btnEye.Visible = false;
                }
            }
        }

        private bool IsFavorite()
        {
            return Constants.SongPersonals.Any(s => s.ID == Song.ID);
        }

        public void SetColorTop(int stt)
        {
            lblSTT.Text = stt.ToString();

            switch (stt)
            {
                case 1:
                    lblSTT.ForeColor = Constants.COLOR_FIRST;
                    break;

                case 2:
                    lblSTT.ForeColor = Constants.COLOR_SECONDE;
                    break;

                case 3:
                    lblSTT.ForeColor = Constants.COLOR_THRID;
                    break;

                default:
                    lblSTT.ForeColor = Constants.COLOR_DEFAULT;
                    break;
            }
        }

        public void PlayListItemMouseDoubleClick(object sender, MouseEventArgs e)
        {
            Constants.CURRENT_SONG_PLAYING = CURRENT_SONG_PLAYING.PLAYLIST_SONG_PLAYING;
            if ((Constants.CurrentPlaylistItemUC == this && Constants.CurrentPlaylistItemUC.visualiation.Visible) || Song.URL == Constants.MainMedia.URL)
            {
                Constants.CurrentPlaylistItemUC = this;
                Constants.MainForm.ClickButtonPauseOrPlay();

                return;
            }

            PlaylistItemDoubleClick();
        }

        public void PlaylistItemDoubleClick()
        {
            Constants.CurrentPlaylistItemPUC = null;
            //Constants.CURRENT_SONG_PLAYING = CURRENT_SONG_PLAYING.PLAYLIST_SONG_PLAYING;
            Constants.CurrentPlaylist.ResetPlaying();
            if (!visualiation.Visible)
            {
                timerVisualiation.Start();
                visualiation.Visible = true;

                Reset(Constants.CurrentPlaylistItemUC);
                Constants.CurrentPlaylistItemUC = this;
            }
            else
            {
                timerVisualiation.Stop();
                visualiation.Visible = false;
            }

            Constants.MainForm.LoadDataSong(Song);
            Constants.CurrentPersonal.SetPlaying(); //asdsadadasdasd
            if (!btnEye.Visible)
            {
                btnEye.Visible = true;
            }
        }

        public void SetVisualiation()
        {
            if (!visualiation.Visible)
            {
                timerVisualiation.Start();
                visualiation.Visible = true;
            }
            else
            {
                timerVisualiation.Stop();
                visualiation.Visible = false;
            }
        }

        public void Reset(PlaylistItemUC item = null)
        {
            if (item != null && item != this)
            {
                item.timerVisualiation.Stop();
                item.visualiation.Visible = false;
            }
        }

        private void PlaylistItemEnter(object sender, EventArgs e)
        {
            SetPlaylistItemColor(EnterColor);
        }

        private void SetPlaylistItemColor(Color color, PlaylistItemUC PlaylistItemUC = null)
        {
            if (PlaylistItemUC == null)
            {
                this.BackColor = color;
                btnEye.BackColor = color;
                btnHeart.BackColor = color;
                btnArrowAll.BackColor = color;
            }
            else
            {
                PlaylistItemUC.BackColor = color;
                PlaylistItemUC.btnEye.BackColor = color;
                PlaylistItemUC.btnHeart.BackColor = color;
                PlaylistItemUC.btnArrowAll.BackColor = color;
            }
        }

        private void timerVisualiation_Tick_1(object sender, EventArgs e)
        {
            if (!Constants.MainForm.isPlaying())
                return;

            var urlImg = $"../../Assets/Images/visualiation-{new Random().Next(1, VisualiationMusicCount)}.png";

            visualiation.BackgroundImage = new Bitmap(urlImg);
            visualiation.BackgroundImageLayout = ImageLayout.Stretch;
            visualiation.BringToFront();
        }

        #endregion Methods

        private void btnHeart_Click(object sender, EventArgs e)
        {
            var btn = sender as IconButton;

            if (btn.IconChar == IconChar.Heart)
            {
                btn.IconColor = Color.FromArgb(144, 0, 161);
                btn.IconChar = IconChar.Heartbeat;

                var s = new SongPersonal(Song.ID);

                Constants.SongPersonals.Add(s);
                _songPersonalService.Insert(s);
            }
            else
            {
                btn.IconColor = Color.White;
                btn.IconChar = IconChar.Heart;

                var s = Constants.SongPersonals.FirstOrDefault(sp => sp.ID == Song.ID);

                Constants.SongPersonals.Remove(s);
                _songPersonalService.InsertRange(Constants.SongPersonals);
            }

            // cập nhật lại filter bên personal
            Constants.CurrentPersonal.UpdateFavoriteMusic(Song);
        }

        public void UpdateHeartIcon()
        {
            btnHeart.IconColor = Color.White;
            btnHeart.IconChar = IconChar.Heart;
        }

        private void btnArrowAll_Click(object sender, EventArgs e)
        {
            Constants.CURRENT_SONG_PLAYING = CURRENT_SONG_PLAYING.PLAYLIST_SONG_PLAYING;
            var a = Constants.MainForm.isPlaying();
            if (!Constants.MainForm.isPlaying())
            {
                //if (Constants.CurrentPlaylistItemUC == this)
                if ((Constants.CurrentPlaylistItemUC == this && Constants.CurrentPlaylistItemUC.visualiation.Visible) || Song.URL == Constants.MainMedia.URL || Constants.MainMedia.URL == "")
                {
                    Constants.MainForm.ClickButtonPauseOrPlay();

                    PlaylistItemDoubleClick();
                }
            }
            else
            {
                if (Constants.CurrentPlaylistItemUC != this || (Constants.CurrentPlaylistItemPUC != null && Constants.CurrentPlaylistItemPUC.Song.ID == Song.ID))
                {
                    PlaylistItemDoubleClick();
                }
            }

            Constants.CURRENT_PLAYLIST = CURRENT_PLAYLIST.PLAYLIST_PLAYLIST;
            // Show detail
            if (Constants.CURRENT_PLAYLIST == CURRENT_PLAYLIST.PLAYLIST_PLAYLIST)
            {
                //fSongDetail fSongDetail = new fSongDetail();
                //UIHelper.ShowControl(fSongDetail, Constants.CurrentPlaylist.panelContent);

                foreach (Control item in Constants.CurrentPlaylist.Controls)
                {
                    if (item.Name != "panelContent")
                    {
                        item.Visible = false;
                    }
                }

                fSongDetail fSongDetail = new fSongDetail(this.Song);
                UIHelper.ShowControl(fSongDetail, Constants.CurrentPlaylist.panelContent);
            }
        }

        #region Test

        ////https://www.youtube.com/watch?v=MzDQALXH-SI
        //private async void menuDeleteSong_Click(object sender, EventArgs e)
        //{
        //    if (Constants.IsPlaulistReady && Constants.IsPersonalReady)
        //    {
        //        var url = $"https://localhost:44309/Api/MusicAPIController/Delete/{Song.ID}";

        //        HttpClient client = new HttpClient();

        //        var text = await client.GetStringAsync(url);

        //        if (text == "1")
        //        {
        //            Constants.CurrentPlaylist.DeleteByIDAndReload(Song.ID);
        //            Constants.CurrentPersonal.DeleteByIDAndReload(Song.ID);
        //        }

        //        MessageBox.Show(text == "1" ? "Xóa thành công!" : "Xóa không thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng đợi");
        //    }
        //    //var url = "http://localhost/MusicApplicationAPI/Api/MusicAPIController/Create";

        //    //var myObject = new Song
        //    //{
        //    //    IDZing = "IDZing",
        //    //    CategorySongID = 1,
        //    //    DisplayName = "Nhạc test",
        //    //    Title = "Title",
        //    //    Code = "Code",
        //    //    ArtistsNames = "ArtistsName",
        //    //    Performer = "Performer",
        //    //    Lyric = "Lyric",
        //    //    Thumbnail = "https://tse4.mm.bing.net/th?id=OIP.fS75LzIH__ROiq-2lueL4QHaE6&pid=Api&P=0&w=270&h=180",
        //    //    Duration = 200,
        //    //    ViewCount = 0,
        //    //    URL = "http://localhost"
        //    //};

        //    //var objAsJson = JsonConvert.SerializeObject(myObject);
        //    //var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
        //    //var _httpClient = new HttpClient();
        //    //var result = await _httpClient.PostAsync(url, content); //or PostAsync for POST
        //    //MessageBox.Show((await result.Content.ReadAsStringAsync()));

        //    //var url = "http://localhost/MusicApplicationAPI/Api/MusicAPIController/UploadImage";
        //    //var url = "https://localhost:44309/Api/MusicAPIController/UploadFile";

        //    ////variable
        //    //var imgFile = "../../Assets/Images/logo-zing.jpg";
        //    //var txtFile = "../../Assets/Images/file-text.txt";
        //    //var audFile = "";

        //    //OpenFileDialog openFileDialog = new OpenFileDialog();
        //    //if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    //{
        //    //    imgFile = openFileDialog.FileName;
        //    //}
        //    //if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    //{
        //    //    txtFile = openFileDialog.FileName;
        //    //}
        //    //if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    //{
        //    //    audFile = openFileDialog.FileName;
        //    //}

        //    //try
        //    //{
        //    //    var upImgFilebytes = File.ReadAllBytes(imgFile);
        //    //    var upTxtFilebytes = File.ReadAllBytes(txtFile);
        //    //    var upAudFilebytes = File.ReadAllBytes(audFile);

        //    //    HttpClient client = new HttpClient();
        //    //    MultipartFormDataContent content = new MultipartFormDataContent();

        //    //    ByteArrayContent baImgContent = new ByteArrayContent(upImgFilebytes);
        //    //    ByteArrayContent baTxtContent = new ByteArrayContent(upTxtFilebytes);
        //    //    ByteArrayContent baAudContent = new ByteArrayContent(upAudFilebytes);

        //    //    content.Add(baImgContent, "File", "logo-zing-img.png");     // xử lý ngẩu nhiên tên file tại đây
        //    //    content.Add(baTxtContent, "File", "file-text.txt");         // xử  lý ngẩu nhiên tên file tại đây
        //    //    content.Add(baAudContent, "File", "file-aud.mp3");         // xử  lý ngẩu nhiên tên file tại đây

        //    //    var response = await client.PostAsync(url, content);

        //    //    var responsestr = response.Content.ReadAsStringAsync().Result;

        //    //    MessageBox.Show(responsestr);
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show("error: " + ex.Message);
        //    //}

        //    //var a = "Api/MusicAPIController/Create";
        //}

        #endregion
    }
}