
namespace App
{
    partial class fSongDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblTitleFilmName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblLyricLine = new System.Windows.Forms.Label();
            this.lblArtistsNames = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPerformer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgThumbnail = new System.Windows.Forms.PictureBox();
            this.lblSongName = new System.Windows.Forms.Label();
            this.timerThumbnail = new System.Windows.Forms.Timer(this.components);
            this.timerLyricLeft = new System.Windows.Forms.Timer(this.components);
            this.flpLyrics = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbnail)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(1035, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnMinimize.Location = new System.Drawing.Point(993, 6);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "--";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.Location = new System.Drawing.Point(0, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 52);
            this.btnBack.TabIndex = 38;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.flpLyrics);
            this.pnlRight.Controls.Add(this.lblTitleFilmName);
            this.pnlRight.Controls.Add(this.panel3);
            this.pnlRight.Controls.Add(this.pnlLeft);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRight.Location = new System.Drawing.Point(0, 61);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1071, 548);
            this.pnlRight.TabIndex = 39;
            // 
            // lblTitleFilmName
            // 
            this.lblTitleFilmName.AutoSize = true;
            this.lblTitleFilmName.Font = new System.Drawing.Font("Consolas", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFilmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(34)))), ((int)(((byte)(101)))));
            this.lblTitleFilmName.Location = new System.Drawing.Point(748, 0);
            this.lblTitleFilmName.Name = "lblTitleFilmName";
            this.lblTitleFilmName.Size = new System.Drawing.Size(144, 26);
            this.lblTitleFilmName.TabIndex = 19;
            this.lblTitleFilmName.Text = "Lời bài hát";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(533, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 548);
            this.panel3.TabIndex = 1;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.pnlLeft.Controls.Add(this.lblLyricLine);
            this.pnlLeft.Controls.Add(this.lblArtistsNames);
            this.pnlLeft.Controls.Add(this.label5);
            this.pnlLeft.Controls.Add(this.lblPerformer);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.lblCategory);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.imgThumbnail);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(533, 548);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblLyricLine
            // 
            this.lblLyricLine.AutoSize = true;
            this.lblLyricLine.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyricLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.lblLyricLine.Location = new System.Drawing.Point(191, 303);
            this.lblLyricLine.Name = "lblLyricLine";
            this.lblLyricLine.Size = new System.Drawing.Size(130, 22);
            this.lblLyricLine.TabIndex = 33;
            this.lblLyricLine.Text = "Chiều hôm ấy";
            // 
            // lblArtistsNames
            // 
            this.lblArtistsNames.AutoSize = true;
            this.lblArtistsNames.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistsNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.lblArtistsNames.Location = new System.Drawing.Point(249, 494);
            this.lblArtistsNames.Name = "lblArtistsNames";
            this.lblArtistsNames.Size = new System.Drawing.Size(72, 17);
            this.lblArtistsNames.TabIndex = 32;
            this.lblArtistsNames.Text = "sáng tác";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label5.Location = new System.Drawing.Point(37, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sàng tác:";
            // 
            // lblPerformer
            // 
            this.lblPerformer.AutoSize = true;
            this.lblPerformer.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.lblPerformer.Location = new System.Drawing.Point(249, 429);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(80, 17);
            this.lblPerformer.TabIndex = 30;
            this.lblPerformer.Text = "trình bài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(37, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Trình bài:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.lblCategory.Location = new System.Drawing.Point(249, 364);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 17);
            this.lblCategory.TabIndex = 28;
            this.lblCategory.Text = "thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label3.Location = new System.Drawing.Point(37, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Thể loại:";
            // 
            // imgThumbnail
            // 
            this.imgThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgThumbnail.Location = new System.Drawing.Point(142, 0);
            this.imgThumbnail.Name = "imgThumbnail";
            this.imgThumbnail.Size = new System.Drawing.Size(250, 250);
            this.imgThumbnail.TabIndex = 0;
            this.imgThumbnail.TabStop = false;
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Font = new System.Drawing.Font("Consolas", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.lblSongName.Location = new System.Drawing.Point(405, 18);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(276, 26);
            this.lblSongName.TabIndex = 40;
            this.lblSongName.Text = "CHỈ LÀ KHÔNG CÙNG NHAU";
            // 
            // timerThumbnail
            // 
            this.timerThumbnail.Interval = 50;
            this.timerThumbnail.Tick += new System.EventHandler(this.timerThumbnail_Tick);
            // 
            // timerLyricLeft
            // 
            this.timerLyricLeft.Tick += new System.EventHandler(this.timerLyricLeft_Tick);
            // 
            // flpLyrics
            // 
            this.flpLyrics.AutoScroll = true;
            this.flpLyrics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpLyrics.Location = new System.Drawing.Point(535, 29);
            this.flpLyrics.Name = "flpLyrics";
            this.flpLyrics.Size = new System.Drawing.Size(536, 519);
            this.flpLyrics.TabIndex = 20;
            // 
            // fSongDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Name = "fSongDetail";
            this.Size = new System.Drawing.Size(1071, 609);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox imgThumbnail;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblArtistsNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPerformer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLyricLine;
        private System.Windows.Forms.Label lblTitleFilmName;
        private System.Windows.Forms.Timer timerThumbnail;
        private System.Windows.Forms.Timer timerLyricLeft;
        private System.Windows.Forms.FlowLayoutPanel flpLyrics;
    }
}
