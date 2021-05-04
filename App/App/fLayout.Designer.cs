
namespace App
{
    partial class fLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLayout));
            this.timerThumbnail = new System.Windows.Forms.Timer(this.components);
            this.timerTimeline = new System.Windows.Forms.Timer(this.components);
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.btnVolume = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.progressBarSongTime = new Bunifu.Framework.UI.BunifuSlider();
            this.lblMaxTime = new System.Windows.Forms.Label();
            this.lblMinTime = new System.Windows.Forms.Label();
            this.btnRepeat = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.btnPrevious = new FontAwesome.Sharp.IconButton();
            this.btnRandom = new FontAwesome.Sharp.IconButton();
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelSongInfo = new System.Windows.Forms.Panel();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.lblSongName = new System.Windows.Forms.Label();
            this.imgThumbnail = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHistory = new FontAwesome.Sharp.IconButton();
            this.btnSongs = new FontAwesome.Sharp.IconButton();
            this.btnPersonal = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.timerSongName = new System.Windows.Forms.Timer(this.components);
            this.fManager = new App.fManager();
            this.fPersonal = new App.fPersonal();
            this.fPlaylist = new App.fPlaylist();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            this.panelSongInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbnail)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timerThumbnail
            // 
            this.timerThumbnail.Interval = 50;
            this.timerThumbnail.Tick += new System.EventHandler(this.timerThumbnail_Tick);
            // 
            // timerTimeline
            // 
            this.timerTimeline.Interval = 1000;
            this.timerTimeline.Tick += new System.EventHandler(this.timerTimeline_Tick);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.panelFooter.Controls.Add(this.lblVolume);
            this.panelFooter.Controls.Add(this.trackBarVolume);
            this.panelFooter.Controls.Add(this.btnVolume);
            this.panelFooter.Controls.Add(this.panel4);
            this.panelFooter.Controls.Add(this.media);
            this.panelFooter.Controls.Add(this.panelSongInfo);
            this.panelFooter.Controls.Add(this.imgThumbnail);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 610);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1308, 100);
            this.panelFooter.TabIndex = 0;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(1258, 35);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(40, 22);
            this.lblVolume.TabIndex = 26;
            this.lblVolume.Text = "50%";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.trackBarVolume.Location = new System.Drawing.Point(1082, 36);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(177, 45);
            this.trackBarVolume.SmallChange = 5;
            this.trackBarVolume.TabIndex = 25;
            this.trackBarVolume.TickFrequency = 10;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // btnVolume
            // 
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnVolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeDown;
            this.btnVolume.IconColor = System.Drawing.Color.White;
            this.btnVolume.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolume.IconSize = 64;
            this.btnVolume.Location = new System.Drawing.Point(1044, 36);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(25, 30);
            this.btnVolume.TabIndex = 24;
            this.btnVolume.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.progressBarSongTime);
            this.panel4.Controls.Add(this.lblMaxTime);
            this.panel4.Controls.Add(this.lblMinTime);
            this.panel4.Controls.Add(this.btnRepeat);
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnPlay);
            this.panel4.Controls.Add(this.btnPrevious);
            this.panel4.Controls.Add(this.btnRandom);
            this.panel4.Location = new System.Drawing.Point(473, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 93);
            this.panel4.TabIndex = 23;
            // 
            // progressBarSongTime
            // 
            this.progressBarSongTime.BackColor = System.Drawing.Color.Transparent;
            this.progressBarSongTime.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.progressBarSongTime.BorderRadius = 0;
            this.progressBarSongTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarSongTime.IndicatorColor = System.Drawing.Color.White;
            this.progressBarSongTime.Location = new System.Drawing.Point(54, 64);
            this.progressBarSongTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.progressBarSongTime.MaximumValue = 0;
            this.progressBarSongTime.Name = "progressBarSongTime";
            this.progressBarSongTime.Size = new System.Drawing.Size(400, 30);
            this.progressBarSongTime.TabIndex = 8;
            this.progressBarSongTime.Value = 0;
            this.progressBarSongTime.ValueChanged += new System.EventHandler(this.progressBarSongTime_ValueChanged);
            // 
            // lblMaxTime
            // 
            this.lblMaxTime.AutoSize = true;
            this.lblMaxTime.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTime.ForeColor = System.Drawing.Color.White;
            this.lblMaxTime.Location = new System.Drawing.Point(463, 64);
            this.lblMaxTime.Name = "lblMaxTime";
            this.lblMaxTime.Size = new System.Drawing.Size(42, 15);
            this.lblMaxTime.TabIndex = 7;
            this.lblMaxTime.Text = "00:00";
            // 
            // lblMinTime
            // 
            this.lblMinTime.AutoSize = true;
            this.lblMinTime.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.lblMinTime.Location = new System.Drawing.Point(8, 64);
            this.lblMinTime.Name = "lblMinTime";
            this.lblMinTime.Size = new System.Drawing.Size(42, 15);
            this.lblMinTime.TabIndex = 5;
            this.lblMinTime.Text = "00:00";
            // 
            // btnRepeat
            // 
            this.btnRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepeat.FlatAppearance.BorderSize = 0;
            this.btnRepeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.btnRepeat.IconColor = System.Drawing.Color.White;
            this.btnRepeat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRepeat.IconSize = 64;
            this.btnRepeat.Location = new System.Drawing.Point(388, 23);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(25, 30);
            this.btnRepeat.TabIndex = 4;
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            this.btnRepeat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRandom_MouseDown);
            this.btnRepeat.MouseLeave += new System.EventHandler(this.btnRandom_MouseLeave);
            this.btnRepeat.MouseHover += new System.EventHandler(this.btnRandom_MouseHover);
            this.btnRepeat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRandom_MouseUp);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnNext.IconColor = System.Drawing.Color.White;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 64;
            this.btnNext.Location = new System.Drawing.Point(315, 23);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 30);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRandom_MouseDown);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnRandom_MouseLeave);
            this.btnNext.MouseHover += new System.EventHandler(this.btnRandom_MouseHover);
            this.btnNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRandom_MouseUp);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnPlay.IconColor = System.Drawing.Color.White;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 64;
            this.btnPlay.Location = new System.Drawing.Point(242, 23);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(25, 30);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRandom_MouseDown);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnRandom_MouseLeave);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnRandom_MouseHover);
            this.btnPlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRandom_MouseUp);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnPrevious.IconColor = System.Drawing.Color.White;
            this.btnPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevious.IconSize = 64;
            this.btnPrevious.Location = new System.Drawing.Point(169, 23);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(25, 30);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRandom_MouseDown);
            this.btnPrevious.MouseLeave += new System.EventHandler(this.btnRandom_MouseLeave);
            this.btnPrevious.MouseHover += new System.EventHandler(this.btnRandom_MouseHover);
            this.btnPrevious.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRandom_MouseUp);
            // 
            // btnRandom
            // 
            this.btnRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.btnRandom.IconColor = System.Drawing.Color.White;
            this.btnRandom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRandom.IconSize = 64;
            this.btnRandom.Location = new System.Drawing.Point(96, 23);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(25, 30);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRandom_MouseDown);
            this.btnRandom.MouseLeave += new System.EventHandler(this.btnRandom_MouseLeave);
            this.btnRandom.MouseHover += new System.EventHandler(this.btnRandom_MouseHover);
            this.btnRandom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRandom_MouseUp);
            // 
            // media
            // 
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(0, 0);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(10, 10);
            this.media.TabIndex = 22;
            // 
            // panelSongInfo
            // 
            this.panelSongInfo.Controls.Add(this.lblArtistName);
            this.panelSongInfo.Controls.Add(this.lblSongName);
            this.panelSongInfo.Location = new System.Drawing.Point(118, 5);
            this.panelSongInfo.Name = "panelSongInfo";
            this.panelSongInfo.Size = new System.Drawing.Size(289, 90);
            this.panelSongInfo.TabIndex = 1;
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblArtistName.Location = new System.Drawing.Point(-2, 53);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(70, 15);
            this.lblArtistName.TabIndex = 1;
            this.lblArtistName.Text = "Trình bày";
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSongName.Location = new System.Drawing.Point(3, 12);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(120, 22);
            this.lblSongName.TabIndex = 0;
            this.lblSongName.Text = "Tên bài hát";
            // 
            // imgThumbnail
            // 
            this.imgThumbnail.Location = new System.Drawing.Point(9, 5);
            this.imgThumbnail.Name = "imgThumbnail";
            this.imgThumbnail.Size = new System.Drawing.Size(90, 90);
            this.imgThumbnail.TabIndex = 0;
            this.imgThumbnail.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 609);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1308, 1);
            this.panel3.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panelMenu.Controls.Add(this.btnHistory);
            this.panelMenu.Controls.Add(this.btnSongs);
            this.panelMenu.Controls.Add(this.btnPersonal);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 609);
            this.panelMenu.TabIndex = 3;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnHistory.IconColor = System.Drawing.Color.White;
            this.btnHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(0, 206);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHistory.Size = new System.Drawing.Size(238, 53);
            this.btnHistory.TabIndex = 13;
            this.btnHistory.TabStop = false;
            this.btnHistory.Text = "Quản lý";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnSongs
            // 
            this.btnSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSongs.FlatAppearance.BorderSize = 0;
            this.btnSongs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongs.ForeColor = System.Drawing.Color.White;
            this.btnSongs.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnSongs.IconColor = System.Drawing.Color.White;
            this.btnSongs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSongs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSongs.Location = new System.Drawing.Point(0, 153);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSongs.Size = new System.Drawing.Size(238, 53);
            this.btnSongs.TabIndex = 12;
            this.btnSongs.TabStop = false;
            this.btnSongs.Text = "Khám phá";
            this.btnSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSongs.UseVisualStyleBackColor = false;
            this.btnSongs.Click += new System.EventHandler(this.btnSongs_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnPersonal.IconColor = System.Drawing.Color.White;
            this.btnPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(0, 100);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPersonal.Size = new System.Drawing.Size(238, 53);
            this.btnPersonal.TabIndex = 11;
            this.btnPersonal.TabStop = false;
            this.btnPersonal.Text = "Cá  nhân";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imgLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 100);
            this.panel2.TabIndex = 10;
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(238, 100);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // timerSongName
            // 
            this.timerSongName.Interval = 10;
            this.timerSongName.Tick += new System.EventHandler(this.timerSongName_Tick);
            // 
            // fManager
            // 
            this.fManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.fManager.Location = new System.Drawing.Point(238, 0);
            this.fManager.Name = "fManager";
            this.fManager.Size = new System.Drawing.Size(1071, 609);
            this.fManager.TabIndex = 6;
            // 
            // fPersonal
            // 
            this.fPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.fPersonal.Location = new System.Drawing.Point(238, 0);
            this.fPersonal.Margin = new System.Windows.Forms.Padding(0);
            this.fPersonal.Name = "fPersonal";
            this.fPersonal.Size = new System.Drawing.Size(1071, 609);
            this.fPersonal.TabIndex = 5;
            // 
            // fPlaylist
            // 
            this.fPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.fPlaylist.Location = new System.Drawing.Point(238, 0);
            this.fPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.fPlaylist.Name = "fPlaylist";
            this.fPlaylist.Size = new System.Drawing.Size(1071, 609);
            this.fPlaylist.TabIndex = 4;
            // 
            // fLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 710);
            this.Controls.Add(this.fManager);
            this.Controls.Add(this.fPersonal);
            this.Controls.Add(this.fPlaylist);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLayout";
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            this.panelSongInfo.ResumeLayout(false);
            this.panelSongInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbnail)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerThumbnail;
        private System.Windows.Forms.Timer timerTimeline;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox imgThumbnail;
        private FontAwesome.Sharp.IconButton btnHistory;
        private FontAwesome.Sharp.IconButton btnSongs;
        private FontAwesome.Sharp.IconButton btnPersonal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel panelSongInfo;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblArtistName;
        private AxWMPLib.AxWindowsMediaPlayer media;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMaxTime;
        private System.Windows.Forms.Label lblMinTime;
        private FontAwesome.Sharp.IconButton btnRepeat;
        private FontAwesome.Sharp.IconButton btnPrevious;
        private FontAwesome.Sharp.IconButton btnRandom;
        private FontAwesome.Sharp.IconButton btnVolume;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Timer timerSongName;
        public Bunifu.Framework.UI.BunifuSlider progressBarSongTime;
        private fPersonal fPersonal;
        private fPlaylist fPlaylist;
        private fManager fManager;
        public FontAwesome.Sharp.IconButton btnNext;
        public FontAwesome.Sharp.IconButton btnPlay;
    }
}