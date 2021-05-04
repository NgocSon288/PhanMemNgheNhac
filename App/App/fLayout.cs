using App.Common;
using App.DatabaseLocal.Models;
using App.DatabaseLocal.Services;
using App.Models;
using App.UCs;
using FontAwesome.Sharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class fLayout : Form
    {
        private readonly ISongPersonalService _songPersonalService;
        private readonly ISongSeenService _songSeenService;

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private Image thumbnailMain;
        private int rotateThumbnail;

        public static List<SongSeen> SongSeens;

        private Song currentSong;

        public fLayout()
        {
            InitializeComponent();

            this._songPersonalService = new SongPersonalService();
            this._songSeenService = new SongSeenService();
            SongSeens = _songSeenService.GetAll();

            Constants.MainForm = this;
            Constants.MainMedia = media;

            Load();
        }

        #region Events

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            NextOrPrevious(false);
        }

        public void BtnNext_Click(object sender, EventArgs e)
        {
            NextOrPrevious();
        }

        #endregion Events

        #region Methods

        new private async void Load()
        {
            Constants.SongPersonals = _songPersonalService.GetAll();
            Constants.CurrentPlaylist = fPlaylist;
            Constants.CurrentPersonal = fPersonal;
            Constants.CurrentManager = fManager;
            btnNext.Click += BtnNext_Click;
            btnPrevious.Click += BtnPrevious_Click;
            btnRandom.Click += BtnRandom_Click;
            media.PlayStateChange += Media_PlayStateChange;

            imgLogo.BackgroundImage = new Bitmap(Constants.ROOT_PATH + "Assets/Images/logo-zing.png");
            imgLogo.BackgroundImageLayout = ImageLayout.Stretch;
            imgThumbnail.BackgroundImage = new Bitmap(Constants.ROOT_PATH + "Assets/Images/thumnail-default.png");
            imgThumbnail.BackgroundImageLayout = ImageLayout.Stretch;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 100);
            panelMenu.Controls.Add(leftBorderBtn);

            VisibleButton();

            Reset();

            thumbnailMain = UIHelper.ClipToCircle(imgThumbnail.BackgroundImage, Constants.FOOTER_BACKGROUND);
            imgThumbnail.BackgroundImage = thumbnailMain;

            // note test

            timerThumbnail.Start();
            timerTimeline.Start();
            timerSongName.Start();
        }

        public void NextOrPrevious(bool isNext = true, bool isRandom = false, bool isRepeat = false)
        {
            // find next PlayListItemUC in this;
            if (Constants.CURRENT_SONG_PLAYING == CURRENT_SONG_PLAYING.PLAYLIST_SONG_PLAYING || Constants.isPriority)
            {
                if ((Constants.CurrentPlaylistItemUC != null && Constants.IsPlaulistReady) || Constants.isPriority)
                {
                    var index = 0;
                    if (!Constants.isPriority)
                    {
                        foreach (PlaylistItemUC item in fPlaylist.flpPlaylist.Controls)
                        {
                            if (Constants.CurrentPlaylistItemUC == item)
                            {
                                break;
                            }
                            index++;
                        }
                    }

                    if (isRepeat)
                    {
                    }
                    // find next index
                    else if (!isRandom)
                    {
                        if (isNext)
                        {
                            index = index == fPlaylist.flpPlaylist.Controls.Count - 1 ? 0 : index + 1;
                        }
                        else
                        {
                            index = index == 0 ? fPlaylist.flpPlaylist.Controls.Count - 1 : index - 1;
                        }
                    }
                    else
                    {
                        if (fPlaylist.flpPlaylist.Controls.Count > 1)
                        {
                            var i = index;
                            while (i == index)
                            {
                                i = new Random().Next(0, fPlaylist.flpPlaylist.Controls.Count);
                            }

                            index = i;
                        }
                        else
                        {
                            index = 0;
                        }
                    }

                    // find next PlayListItemPUC
                    var itemUC = fPlaylist.flpPlaylist.Controls[index] as PlaylistItemUC;
                    itemUC.PlayListItemMouseDoubleClick(itemUC, null);

                    var s = itemUC.Song;
                    if (Constants.isPriority)
                    {
                        Constants.CurrentPersonal.SetPlaying();
                        Constants.CurrentPlaylist.SetPlaying(itemUC.Song);
                    }

                    // Load SongDetail
                    if (Constants.CurrentPlaylist.panelContent.Controls.Count > 0)
                    {
                        fSongDetail fSongDetail = new fSongDetail(itemUC.Song);
                        UIHelper.ShowControl(fSongDetail, Constants.CurrentPlaylist.panelContent);
                    }
                }
            }
            else if (Constants.CURRENT_SONG_PLAYING == CURRENT_SONG_PLAYING.PERSONA_SONG_PLAYING)
            {
                if (Constants.CurrentPlaylistItemPUC != null && Constants.IsPersonalReady)
                {
                    var index = 0;
                    foreach (PlaylistItemPUC item in fPersonal.flpPlaylist.Controls)
                    {
                        if (Constants.CurrentPlaylistItemPUC == item)
                        {
                            break;
                        }
                        index++;
                    }

                    if (isRepeat)
                    {
                    }
                    // find next index
                    else if (!isRandom)
                    {
                        if (isNext)
                        {
                            index = index == fPersonal.flpPlaylist.Controls.Count - 1 ? 0 : index + 1;
                        }
                        else
                        {
                            index = index == 0 ? fPersonal.flpPlaylist.Controls.Count - 1 : index - 1;
                        }
                    }
                    else
                    {
                        if (fPersonal.flpPlaylist.Controls.Count > 1)
                        {
                            var i = index;
                            while (i == index)
                            {
                                i = new Random().Next(0, fPersonal.flpPlaylist.Controls.Count);
                            }

                            index = i;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                    // find next PlayListItemPUC
                    var itemPUC = fPersonal.flpPlaylist.Controls[index] as PlaylistItemPUC;
                    itemPUC.PlayListItemMouseDoubleClick(itemPUC, null);

                    // Load SongDetail
                    if (Constants.CurrentPersonal.panelContent.Controls.Count > 0)
                    {
                        fSongDetail fSongDetail = new fSongDetail(itemPUC.Song);
                        UIHelper.ShowControl(fSongDetail, Constants.CurrentPersonal.panelContent);
                    }
                }
            }

            if (Constants.CurrentPlaylistItemPUC != null && Constants.CurrentPlaylistItemUC != null)
            {
                media.Ctlcontrols.play();
            }
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                // panelContent.Visible = true;

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

            ResetRoot();
        }

        private void ResetRoot()
        {
            // trở về playlist
            if (Constants.CURRENT_PLAYLIST == CURRENT_PLAYLIST.PLAYLIST_PLAYLIST)
            {
                foreach (Control item in Constants.CurrentPlaylist.Controls)
                {
                    item.Visible = true;
                }
                Constants.CurrentPlaylist.panelContent.SendToBack();
                Constants.CurrentPlaylist.panelContent.Controls.Clear();
                Constants.CurrentPlaylistItemUC?.Focus();
            }
            else if (Constants.CURRENT_PLAYLIST == CURRENT_PLAYLIST.PERSONA_PLAYLISTL)
            {
                foreach (Control item in Constants.CurrentPersonal.Controls)
                {
                    item.Visible = true;
                }
                Constants.CurrentPersonal.panelContent.SendToBack();
                Constants.CurrentPersonal.panelContent.Controls.Clear();
                Constants.CurrentPlaylistItemPUC?.Focus();
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

            // UIHelper.ShowControl(fPersonal, panelContent);

            fPersonal.Visible = true;
            fPlaylist.Visible = false;
            fManager.Visible = false;
        }

        private void VisibleButton()
        {
            btnPersonal.Visible = true;
            btnSongs.Visible = true;
            btnHistory.Visible = true; 
        }

        public bool isPlaying()
        {
            return media.playState == WMPLib.WMPPlayState.wmppsPlaying;
        }

        public void ResetDataSong()
        {
            media.URL = "";
            imgThumbnail.BackgroundImage = UIHelper.ClipToCircle(new Bitmap(Constants.ROOT_PATH + "Assets/Images/thumnail-default.png"), Constants.FOOTER_BACKGROUND);
            lblSongName.Text = "Tên bài hát";
            lblSongName.Left = 0;
            progressBarSongTime.Value = 0;
            lblArtistName.Text = "Trình bày";
            lblMinTime.Text = "00:00";
            lblMaxTime.Text = "00:00";
        }

        public void LoadDataSong(Song song, bool isPass = false, bool isChangeURL = false)
        {
            if (!isPass)
            {
                if (song.URL == media.URL)
                {
                    return;
                }
            }

            if (song.Duration == 0)
            {
                Constants.errorDuration = true;
            }

            currentSong = song;

            rotateThumbnail = 0;
            lblSongName.Left = 0;
            if (!isChangeURL)
            {
                media.URL = song.URL;
            }

            var request = WebRequest.Create(song.Thumbnail);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                thumbnailMain = UIHelper.ClipToCircle(Bitmap.FromStream(stream), Constants.FOOTER_BACKGROUND);
                imgThumbnail.BackgroundImage = thumbnailMain;
            }
            if (!isChangeURL)
            {
                lblMinTime.Text = $"{(0 / 60).ToString().PadLeft(2, '0')}:{(0 % 60).ToString().PadLeft(2, '0')}";
                song.Duration = song.Duration == 0 ? 232 : song.Duration;
                lblMaxTime.Text = $"{(song.Duration / 60).ToString().PadLeft(2, '0')}:{(song.Duration % 60).ToString().PadLeft(2, '0')}";
                progressBarSongTime.MaximumValue = song.Duration;
                progressBarSongTime.Value = 0;
            }

            lblSongName.Text = song.DisplayName;
            lblArtistName.Text = song.ArtistsNames;

            if (!isChangeURL)
            {
                media.Ctlcontrols.play();
            }

            switch (Constants.CURRENT_PAGE)
            {
                case CURRENT_PAGE.PERSONAL:
                    Constants.CURRENT_PLAYLIST = CURRENT_PLAYLIST.PERSONA_PLAYLISTL;
                    break;

                case CURRENT_PAGE.PLAYLIST:
                    Constants.CURRENT_PLAYLIST = CURRENT_PLAYLIST.PLAYLIST_PLAYLIST;
                    break;

                case CURRENT_PAGE.MANAGER:
                    Constants.CURRENT_PLAYLIST = CURRENT_PLAYLIST.MANAGER_PLAYLIST;
                    break;
            }

            if (!SongSeens.Any(s => s.ID == song.ID))
            {
                SongSeens.Add(new SongSeen() { ID = song.ID });
                _songSeenService.InsertRange(SongSeens);
            }
        }

        public void ClickButtonPauseOrPlay()
        {
            if (isPlaying())
            {
                media.Ctlcontrols.pause();
                btnPlay.IconChar = IconChar.PauseCircle;
            }
            else
            {
                media.Ctlcontrols.play();
                btnPlay.IconChar = IconChar.PlayCircle;
            }
        }

        #endregion Methods

        #region Menu animation

        private void imgLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Constants.CURRENT_PAGE = CURRENT_PAGE.PERSONAL;

            ActivateButton(sender);

            fPersonal.Visible = true;
            fPlaylist.Visible = false;
            fManager.Visible = false;
        }

        private void btnSongs_Click(object sender, EventArgs e)
        {
            Constants.CURRENT_PAGE = CURRENT_PAGE.PLAYLIST;

            ActivateButton(sender);

            fPlaylist.Visible = true;
            fPersonal.Visible = false;
            fManager.Visible = false;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Constants.CURRENT_PAGE = CURRENT_PAGE.MANAGER;

            ActivateButton(sender);

            fPlaylist.Visible = false;
            fPersonal.Visible = false;
            fManager.Visible = true;
        }

        private void btnOrderFirst_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            var fOrder = new fOrder();
            // UIHelper.ShowControl(fOrder, panelContent);
        }

        private void btnOrderSecond_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            var fOrder = new fOrder();
            // UIHelper.ShowControl(fOrder, panelContent);
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            NextOrPrevious(true, true);
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            Constants.IsReapeat = !Constants.IsReapeat;

            if (Constants.IsReapeat)
            {
                btnRepeat.IconColor = Color.FromArgb(120, 6, 130);
            }
            else
            {
                btnRepeat.IconColor = Color.White;
            }
        }

        #endregion Menu animation

        #region Footer animation

        private void timerThumbnail_Tick(object sender, EventArgs e)
        {
            if (isPlaying())
            {
                rotateThumbnail += 3;
                Constants.CURRENT_ROTATION = rotateThumbnail;
                imgThumbnail.BackgroundImage = UIHelper.RotateImage(thumbnailMain, rotateThumbnail);
            }
        }

        private async void timerTimeline_Tick(object sender, EventArgs e)
        {
            if (isPlaying())
            {
                var second = (int)media.Ctlcontrols.currentPosition;
                lblMinTime.Text = $"{(second / 60).ToString().PadLeft(2, '0')}:{(second % 60).ToString().PadLeft(2, '0')}";
                progressBarSongTime.Value = second;

                if (Constants.errorDuration)
                {
                    progressBarSongTime.MaximumValue = (int)media.currentMedia.duration;
                    lblMaxTime.Text = $"{(progressBarSongTime.MaximumValue / 60).ToString().PadLeft(2, '0')}:{(progressBarSongTime.MaximumValue % 60).ToString().PadLeft(2, '0')}";
                    Constants.errorDuration = false;

                    using (HttpClient client = new HttpClient())
                    {
                        currentSong.Duration = progressBarSongTime.MaximumValue;

                        var objAsJson = JsonConvert.SerializeObject(currentSong);
                        var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
                        var _httpClient = new HttpClient();
                        var result = client.PostAsync(Constants.UPDATE_SONG, content);
                    }

                    if (Constants.CurrentPlaylistItemPUC != null)
                    {
                        Constants.CurrentPlaylistItemPUC.lblDuration.Text = $"{(currentSong.Duration / 60).ToString().PadLeft(2, '0')}:{(currentSong.Duration % 60).ToString().PadLeft(2, '0')}";
                    }

                    if (Constants.CurrentPlaylistItemUC != null)
                    {
                        Constants.CurrentPlaylistItemUC.lblDuration.Text = $"{(currentSong.Duration / 60).ToString().PadLeft(2, '0')}:{(currentSong.Duration % 60).ToString().PadLeft(2, '0')}";
                    }
                }
            }
        }

        private void Media_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (media.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                // Lặp lại bài
                if (Constants.IsReapeat)
                {
                    NextOrPrevious(true, false, true);
                }

                // Next bài
                else
                {
                    NextOrPrevious(true, false);
                }
            }

            if (media.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                media.Ctlcontrols.play();
            }
        }

        private void btnHeart_Click(object sender, EventArgs e)
        {
            if (lblSongName.Text == "Tên bài hát")
                return;

            var btn = sender as IconButton;

            if (btn.IconChar == IconChar.Heart)
            {
                btn.IconChar = IconChar.Heartbeat;
                btn.IconColor = Color.FromArgb(144, 0, 161);
            }
            else
            {
                btn.IconChar = IconChar.Heart;
                btn.IconColor = Color.White;
            }
        }

        private void btnRandom_MouseHover(object sender, EventArgs e)
        {
            var btn = sender as IconButton;

            btn.IconColor = Color.FromArgb(89, 85, 96);
            btn.BackColor = Color.FromArgb(18, 12, 28);
        }

        private void btnRandom_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as IconButton;

            btn.IconColor = Color.White;
            btn.BackColor = Color.FromArgb(18, 12, 28);
        }

        private void btnRandom_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as IconButton;

            btn.IconColor = Color.White;
            btn.BackColor = Color.FromArgb(18, 12, 28);

            if (btn.Name == "btnRepeat" && Constants.IsReapeat)
            {
                btn.IconColor = Color.FromArgb(120, 6, 130);
            }
        }

        private void btnRandom_MouseUp(object sender, MouseEventArgs e)
        {
            var btn = sender as IconButton;

            btn.IconColor = Color.FromArgb(89, 85, 96);
            btn.BackColor = Color.FromArgb(18, 12, 28);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!Constants.isDelete)
            {
                ClickButtonPauseOrPlay();
                Constants.isDelete = false;
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            media.settings.volume = trackBarVolume.Value;
            lblVolume.Text = $"{trackBarVolume.Value}%";

            if (trackBarVolume.Value == 0)
            {
                btnVolume.IconChar = IconChar.VolumeMute;
            }
            else if (trackBarVolume.Value == 100)
            {
                btnVolume.IconChar = IconChar.VolumeUp;
            }
            else
            {
                btnVolume.IconChar = IconChar.VolumeDown;
            }
        }

        private void progressBarSongTime_ValueChanged(object sender, EventArgs e)
        {
            var second = progressBarSongTime.Value;
            lblMinTime.Text = $"{(second / 60).ToString().PadLeft(2, '0')}:{(second % 60).ToString().PadLeft(2, '0')}";
            media.Ctlcontrols.currentPosition = progressBarSongTime.Value;
        }

        private void timerSongName_Tick(object sender, EventArgs e)
        {
            if (lblSongName.Text == "Tên bài hát")
                return;

            var width = lblSongName.Width;

            lblSongName.Left -= 2;

            if (lblSongName.Location.X + width <= 0 + 10)
            {
                lblSongName.Left = panelSongInfo.Width;
            }
        }

        #endregion Footer animation

    }
}