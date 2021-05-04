using App.Common;
using App.Models;
using App.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UCs
{
    public partial class CreateSongUC : UserControl
    {
        private readonly ISongCategoryService _songCategoryService;

        private List<SongCategory> SongCategories;

        private Song song;

        public CreateSongUC()
        {
            InitializeComponent();

            this._songCategoryService = new SongCategoryService();

            Load();
        }

        #region Events

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckValidateValue())
            {
                song.DisplayName = txtDisplayName.Text.Trim();
                song.CategorySongID = (cbbCategory.SelectedItem as SongCategory).ID;
                song.Title = txtTitle.Text;
                song.ArtistsNames = txtArtistName.Text;
                song.Performer = txtPerformer.Text;

                // gọi api save file
                var rand = new Random();
                List<string> randStr = new List<string>()
                {
                    rand.Next(10000,10000000).ToString(),
                    rand.Next(10000,10000000).ToString(),
                    rand.Next(10000,10000000).ToString()
                };

                var check = await SaveFiles(Constants.SAVE_FILES_SONG, new List<string>() { song.Thumbnail, song.Lyric, song.URL }, randStr);

                song.Thumbnail = Constants.DOMAIN + "Assets/Images/" + randStr[0] + Path.GetFileName(song.Thumbnail);
                song.Lyric = Constants.DOMAIN + "Assets/Images/" + randStr[1] + Path.GetFileName(song.Lyric);
                song.URL = Constants.DOMAIN + "Assets/Images/" + randStr[2] + Path.GetFileName(song.URL);

                song.ViewCount = 0;
                song.IDZing = "";
                song.Code = "";

                // gọi api save song
                if (check)
                {
                    var objAsJson = JsonConvert.SerializeObject(song);
                    var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
                    var _httpClient = new HttpClient();
                    var result = await _httpClient.PostAsync(Constants.CREATE_SONG, content);
                    if ((await result.Content.ReadAsStringAsync()) == "1")
                    {
                        MessageBox.Show("Thêm bài hát thành công");

                        //Constants.CurrentPlaylist.AddMockData(song);
                        Constants.CurrentPlaylist.Load();
                        Constants.CurrentPersonal.Load();
                        Constants.CurrentManager.Load();
                        btnBack_Click(btnBack, new EventArgs());
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin bài hát không hợp lệ");
            }
        }

        private void btnLyric_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn một chứa lời bài hát";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;

                if (File.Exists(fileName))
                {
                    song.Lyric = fileName;
                    btnLyric.FlatAppearance.BorderColor = Color.FromArgb(68, 226, 255);
                    btnLyric.ForeColor = Color.FromArgb(68, 226, 255);
                    btnLyric.IconColor = Color.FromArgb(68, 226, 255);
                }
                else
                {
                    btnLyric.FlatAppearance.BorderColor = Color.Red;
                    btnLyric.ForeColor = Color.Red;
                    btnLyric.IconColor = Color.Red;
                }
            }
            else
            {
                if (song.Lyric == null || song.Lyric == "")
                {
                    btnLyric.FlatAppearance.BorderColor = Color.Red;
                    btnLyric.ForeColor = Color.Red;
                    btnLyric.IconColor = Color.Red;
                }
            }
        }

        #endregion Events

        #region Methods

        new private async void Load()
        {
            song = new Song();

            SongCategories = await _songCategoryService.GetAll();

            cbbCategory.DataSource = SongCategories;
            cbbCategory.DisplayMember = "DisplayName";
        }

        private bool CheckValidate(TextBox txt, Panel pnl, bool isNumber = false)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.ForeColor = Color.FromArgb(255, 0, 0);
                pnl.BackColor = Color.FromArgb(255, 0, 0);

                return false;
            }
            else if (isNumber && !decimal.TryParse(txt.Text, out decimal res))
            {
                txt.ForeColor = Color.FromArgb(255, 0, 0);
                pnl.BackColor = Color.FromArgb(255, 0, 0);

                return false;
            }
            else
            {
                txt.ForeColor = Color.FromArgb(102, 139, 172);
                pnl.BackColor = Color.Silver;

                return true;
            }
        }

        private bool CheckValidateValue()
        {
            var check = true;

            check = !CheckValidate(txtDisplayName, pnlDisplayName) ? false : check;
            check = !CheckValidate(txtTitle, pnlTitle) ? false : check;
            check = !CheckValidate(txtArtistName, pnlArtistName) ? false : check;
            check = !CheckValidate(txtPerformer, pnlPerformer) ? false : check;

            if (song.Lyric == null || song.Lyric == "")
            {
                check = false;

                btnLyric.FlatAppearance.BorderColor = Color.Red;
                btnLyric.ForeColor = Color.Red;
                btnLyric.IconColor = Color.Red;
            }
            if (song.URL == null || song.URL == "")
            {
                check = false;

                btnURL.FlatAppearance.BorderColor = Color.Red;
                btnURL.ForeColor = Color.Red;
                btnURL.IconColor = Color.Red;
            }
            if (song.Thumbnail == null || song.Thumbnail == "")
            {
                check = false;

                pnlThumbnail.BackColor = Color.Red;
            }

            return check;
        }

        private async Task<bool> SaveFiles(string url, List<string> files, List<string> randStr)
        {
            try
            {
                List<byte[]> fileBytes = new List<byte[]>();
                foreach (var item in files)
                {
                    fileBytes.Add(File.ReadAllBytes(item));
                }

                HttpClient client = new HttpClient();
                MultipartFormDataContent content = new MultipartFormDataContent();

                List<ByteArrayContent> byteArrayContents = new List<ByteArrayContent>();
                foreach (var item in fileBytes)
                {
                    byteArrayContents.Add(new ByteArrayContent(item));
                }

                for (int i = 0; i < files.Count; i++)
                {
                    content.Add(byteArrayContents[i], "File", randStr[i] + Path.GetFileName(files[i]));
                }

                var response = await client.PostAsync(url, content);

                var responsestr = response.Content.ReadAsStringAsync().Result;

                return responsestr == "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
                return false;
            }
        }

        #endregion Methods

        #region Header

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Control item in Constants.CurrentManager.Controls)
            {
                item.Visible = true;
            }
            Constants.CurrentManager.panelContent.SendToBack();
            Constants.CurrentManager.panelContent.Controls.Clear();
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.FromArgb(23, 15, 35);
            btnBack.IconColor = Color.FromArgb(255, 34, 101);
            btnBack.ForeColor = Color.FromArgb(255, 34, 101);
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.FromArgb(23, 15, 35);
            btnBack.IconColor = Color.FromArgb(68, 226, 255);
            btnBack.ForeColor = Color.FromArgb(68, 226, 255);
        }

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (Control item in Constants.CurrentManager.Controls)
            {
                item.Visible = true;
            }
            Constants.CurrentManager.panelContent.SendToBack();
            Constants.CurrentManager.panelContent.Controls.Clear();
        }

        #endregion Header

        #region UI

        private void btnURL_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn một bài hát";
            openFileDialog.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;

                if (File.Exists(fileName))
                {
                    song.URL = fileName;
                    btnURL.FlatAppearance.BorderColor = Color.FromArgb(68, 226, 255);
                    btnURL.ForeColor = Color.FromArgb(68, 226, 255);
                    btnURL.IconColor = Color.FromArgb(68, 226, 255);
                }
                else
                {
                    btnURL.FlatAppearance.BorderColor = Color.Red;
                    btnURL.ForeColor = Color.Red;
                    btnURL.IconColor = Color.Red;
                }
            }
            else
            {
                if (song.URL == null || song.URL == "")
                {
                    btnURL.FlatAppearance.BorderColor = Color.Red;
                    btnURL.ForeColor = Color.Red;
                    btnURL.IconColor = Color.Red;
                }
            }
        }

        private void imgMain_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn một hình ảnh";
            openFileDialog.Filter = "txt files (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg|(*.jfif)|*.jfif|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;

                if (File.Exists(fileName))
                {
                    song.Thumbnail = fileName;
                    pnlThumbnail.BackColor = Color.FromArgb(68, 226, 255);
                    imgThumbnail.BackgroundImage = Image.FromFile(fileName);
                }
                else
                {
                    pnlThumbnail.BackColor = Color.Red;
                }
            }
            else
            {
                if (song.Thumbnail == null || song.Thumbnail == "")
                {
                    pnlThumbnail.BackColor = Color.Red;
                }
            }
        }

        private void txtDisplayName_Enter(object sender, EventArgs e)
        {
            txtDisplayName.ForeColor = Color.FromArgb(68, 226, 255);
            pnlDisplayName.BackColor = Color.FromArgb(106, 252, 255);
        }

        private void txtDisplayName_Leave(object sender, EventArgs e)
        {
            CheckValidate(txtDisplayName, pnlDisplayName);
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            txtTitle.ForeColor = Color.FromArgb(68, 226, 255);
            pnlTitle.BackColor = Color.FromArgb(106, 252, 255);
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            CheckValidate(txtTitle, pnlTitle);
        }

        private void txtArtistName_Enter(object sender, EventArgs e)
        {
            txtArtistName.ForeColor = Color.FromArgb(68, 226, 255);
            pnlArtistName.BackColor = Color.FromArgb(106, 252, 255);
        }

        private void txtArtistName_Leave(object sender, EventArgs e)
        {
            CheckValidate(txtArtistName, pnlArtistName);
        }

        private void txtPerformer_Enter(object sender, EventArgs e)
        {
            txtPerformer.ForeColor = Color.FromArgb(68, 226, 255);
            pnlPerformer.BackColor = Color.FromArgb(106, 252, 255);
        }

        private void txtPerformer_Leave(object sender, EventArgs e)
        {
            CheckValidate(txtPerformer, pnlPerformer);
        }

        #endregion UI
    }
}