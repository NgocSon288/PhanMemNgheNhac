
namespace App
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgThumbnail = new System.Windows.Forms.PictureBox();
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRandom = new FontAwesome.Sharp.IconButton();
            this.btnPrevious = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnRepeat = new FontAwesome.Sharp.IconButton();
            this.lblMin = new System.Windows.Forms.Label();
            this.progressBarTimeline = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lblMax = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnPersonal = new FontAwesome.Sharp.IconButton();
            this.btnOrderSecond = new FontAwesome.Sharp.IconButton();
            this.btnOrderFirst = new FontAwesome.Sharp.IconButton();
            this.btnHistory = new FontAwesome.Sharp.IconButton();
            this.btnSongs = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timerThumbnail = new System.Windows.Forms.Timer(this.components);
            this.timerTimeline = new System.Windows.Forms.Timer(this.components);
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlSearchUnderline = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.media);
            this.panel1.Controls.Add(this.imgThumbnail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 644);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 105);
            this.panel1.TabIndex = 0;
            // 
            // imgThumbnail
            // 
            this.imgThumbnail.Location = new System.Drawing.Point(12, 15);
            this.imgThumbnail.Name = "imgThumbnail";
            this.imgThumbnail.Size = new System.Drawing.Size(75, 78);
            this.imgThumbnail.TabIndex = 0;
            this.imgThumbnail.TabStop = false;
            // 
            // media
            // 
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(0, 0);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(10, 10);
            this.media.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMax);
            this.panel2.Controls.Add(this.progressBarTimeline);
            this.panel2.Controls.Add(this.lblMin);
            this.panel2.Controls.Add(this.btnRepeat);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnRandom);
            this.panel2.Location = new System.Drawing.Point(551, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 102);
            this.panel2.TabIndex = 2;
            // 
            // btnRandom
            // 
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.btnRandom.IconColor = System.Drawing.Color.White;
            this.btnRandom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRandom.IconSize = 64;
            this.btnRandom.Location = new System.Drawing.Point(125, 23);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(25, 27);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnPrevious.IconColor = System.Drawing.Color.White;
            this.btnPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevious.IconSize = 64;
            this.btnPrevious.Location = new System.Drawing.Point(198, 23);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(25, 27);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.btnPlay.IconColor = System.Drawing.Color.White;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 64;
            this.btnPlay.Location = new System.Drawing.Point(271, 23);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(25, 27);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnNext.IconColor = System.Drawing.Color.White;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 64;
            this.btnNext.Location = new System.Drawing.Point(344, 23);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 27);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.FlatAppearance.BorderSize = 0;
            this.btnRepeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.btnRepeat.IconColor = System.Drawing.Color.White;
            this.btnRepeat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRepeat.IconSize = 64;
            this.btnRepeat.Location = new System.Drawing.Point(417, 23);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(25, 27);
            this.btnRepeat.TabIndex = 4;
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.lblMin.Location = new System.Drawing.Point(37, 64);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(42, 15);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "00:00";
            // 
            // progressBarTimeline
            // 
            this.progressBarTimeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.progressBarTimeline.BorderRadius = 5;
            this.progressBarTimeline.Location = new System.Drawing.Point(86, 71);
            this.progressBarTimeline.MaximumValue = 100;
            this.progressBarTimeline.Name = "progressBarTimeline";
            this.progressBarTimeline.ProgressColor = System.Drawing.Color.Teal;
            this.progressBarTimeline.Size = new System.Drawing.Size(400, 5);
            this.progressBarTimeline.TabIndex = 6;
            this.progressBarTimeline.Value = 0;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Location = new System.Drawing.Point(492, 64);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(42, 15);
            this.lblMax.TabIndex = 7;
            this.lblMax.Text = "00:00";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panelMenu.Controls.Add(this.btnOrderSecond);
            this.panelMenu.Controls.Add(this.btnOrderFirst);
            this.panelMenu.Controls.Add(this.btnHistory);
            this.panelMenu.Controls.Add(this.btnSongs);
            this.panelMenu.Controls.Add(this.btnPersonal);
            this.panelMenu.Controls.Add(this.imgLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 644);
            this.panelMenu.TabIndex = 1;
            // 
            // imgLogo
            // 
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(238, 100);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
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
            this.btnPersonal.IconChar = FontAwesome.Sharp.IconChar.HackerNews;
            this.btnPersonal.IconColor = System.Drawing.Color.White;
            this.btnPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(0, 100);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPersonal.Size = new System.Drawing.Size(238, 53);
            this.btnPersonal.TabIndex = 5;
            this.btnPersonal.TabStop = false;
            this.btnPersonal.Text = "Cá  nhân";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnOrderSecond
            // 
            this.btnOrderSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnOrderSecond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderSecond.FlatAppearance.BorderSize = 0;
            this.btnOrderSecond.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnOrderSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderSecond.ForeColor = System.Drawing.Color.White;
            this.btnOrderSecond.IconChar = FontAwesome.Sharp.IconChar.Hamsa;
            this.btnOrderSecond.IconColor = System.Drawing.Color.White;
            this.btnOrderSecond.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrderSecond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderSecond.Location = new System.Drawing.Point(0, 312);
            this.btnOrderSecond.Name = "btnOrderSecond";
            this.btnOrderSecond.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrderSecond.Size = new System.Drawing.Size(238, 53);
            this.btnOrderSecond.TabIndex = 13;
            this.btnOrderSecond.TabStop = false;
            this.btnOrderSecond.Text = "...";
            this.btnOrderSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderSecond.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderSecond.UseVisualStyleBackColor = false;
            this.btnOrderSecond.Click += new System.EventHandler(this.btnOrderSecond_Click);
            // 
            // btnOrderFirst
            // 
            this.btnOrderFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnOrderFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderFirst.FlatAppearance.BorderSize = 0;
            this.btnOrderFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnOrderFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderFirst.ForeColor = System.Drawing.Color.White;
            this.btnOrderFirst.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            this.btnOrderFirst.IconColor = System.Drawing.Color.White;
            this.btnOrderFirst.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrderFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderFirst.Location = new System.Drawing.Point(0, 259);
            this.btnOrderFirst.Name = "btnOrderFirst";
            this.btnOrderFirst.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrderFirst.Size = new System.Drawing.Size(238, 53);
            this.btnOrderFirst.TabIndex = 12;
            this.btnOrderFirst.TabStop = false;
            this.btnOrderFirst.Text = "...";
            this.btnOrderFirst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderFirst.UseVisualStyleBackColor = false;
            this.btnOrderFirst.Click += new System.EventHandler(this.btnOrderFirst_Click);
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
            this.btnHistory.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            this.btnHistory.IconColor = System.Drawing.Color.White;
            this.btnHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(0, 206);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHistory.Size = new System.Drawing.Size(238, 53);
            this.btnHistory.TabIndex = 11;
            this.btnHistory.TabStop = false;
            this.btnHistory.Text = "Lịch sử";
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
            this.btnSongs.IconChar = FontAwesome.Sharp.IconChar.Hackerrank;
            this.btnSongs.IconColor = System.Drawing.Color.White;
            this.btnSongs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSongs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSongs.Location = new System.Drawing.Point(0, 153);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSongs.Size = new System.Drawing.Size(238, 53);
            this.btnSongs.TabIndex = 10;
            this.btnSongs.TabStop = false;
            this.btnSongs.Text = "Khám phá";
            this.btnSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSongs.UseVisualStyleBackColor = false;
            this.btnSongs.Click += new System.EventHandler(this.btnSongs_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.btnMinimize);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(238, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1087, 644);
            this.panel4.TabIndex = 2;
            // 
            // timerThumbnail
            // 
            this.timerThumbnail.Interval = 50;
            // 
            // timerTimeline
            // 
            this.timerTimeline.Interval = 1000;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1015, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "--";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1051, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlSearchUnderline);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 72);
            this.panel3.TabIndex = 4;
            // 
            // pnlSearchUnderline
            // 
            this.pnlSearchUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlSearchUnderline.Location = new System.Drawing.Point(21, 44);
            this.pnlSearchUnderline.Name = "pnlSearchUnderline";
            this.pnlSearchUnderline.Size = new System.Drawing.Size(502, 1);
            this.pnlSearchUnderline.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtSearch.Location = new System.Drawing.Point(76, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(461, 40);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Nhập tên bài hát, nghệ sĩ hoặc MV...";
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 64;
            this.iconButton1.Location = new System.Drawing.Point(24, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(56, 55);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 749);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgThumbnail;
        private AxWMPLib.AxWindowsMediaPlayer media;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnRandom;
        private FontAwesome.Sharp.IconButton btnRepeat;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPlay;
        private FontAwesome.Sharp.IconButton btnPrevious;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private Bunifu.Framework.UI.BunifuProgressBar progressBarTimeline;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox imgLogo;
        private FontAwesome.Sharp.IconButton btnOrderSecond;
        private FontAwesome.Sharp.IconButton btnOrderFirst;
        private FontAwesome.Sharp.IconButton btnHistory;
        private FontAwesome.Sharp.IconButton btnSongs;
        private FontAwesome.Sharp.IconButton btnPersonal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timerThumbnail;
        private System.Windows.Forms.Timer timerTimeline;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlSearchUnderline;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

