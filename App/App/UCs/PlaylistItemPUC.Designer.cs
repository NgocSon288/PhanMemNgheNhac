
namespace App.UCs
{
    partial class PlaylistItemPUC
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
            this.btnHeart = new FontAwesome.Sharp.IconButton();
            this.lblArtistsName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblSongName = new System.Windows.Forms.Label();
            this.imgThumbnail = new System.Windows.Forms.PictureBox();
            this.visualiation = new System.Windows.Forms.PictureBox();
            this.lblSTT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timerVisualiation = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnArrowAll = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualiation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHeart
            // 
            this.btnHeart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.btnHeart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeart.FlatAppearance.BorderSize = 0;
            this.btnHeart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnHeart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnHeart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHeart.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnHeart.IconColor = System.Drawing.Color.White;
            this.btnHeart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHeart.Location = new System.Drawing.Point(927, 12);
            this.btnHeart.Margin = new System.Windows.Forms.Padding(1);
            this.btnHeart.Name = "btnHeart";
            this.btnHeart.Size = new System.Drawing.Size(48, 48);
            this.btnHeart.TabIndex = 31;
            this.btnHeart.UseVisualStyleBackColor = false;
            this.btnHeart.Click += new System.EventHandler(this.btnHeart_Click);
            // 
            // lblArtistsName
            // 
            this.lblArtistsName.AutoSize = true;
            this.lblArtistsName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblArtistsName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistsName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblArtistsName.Location = new System.Drawing.Point(332, 40);
            this.lblArtistsName.Name = "lblArtistsName";
            this.lblArtistsName.Size = new System.Drawing.Size(70, 15);
            this.lblArtistsName.TabIndex = 30;
            this.lblArtistsName.Text = "Tăng Phúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(141, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "-";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDuration.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDuration.Location = new System.Drawing.Point(790, 25);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(54, 19);
            this.lblDuration.TabIndex = 28;
            this.lblDuration.Text = "00:00";
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSongName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSongName.Location = new System.Drawing.Point(331, 9);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(230, 22);
            this.lblSongName.TabIndex = 27;
            this.lblSongName.Text = "Chỉ là khong cùng nhau";
            // 
            // imgThumbnail
            // 
            this.imgThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgThumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgThumbnail.Location = new System.Drawing.Point(241, 1);
            this.imgThumbnail.Name = "imgThumbnail";
            this.imgThumbnail.Size = new System.Drawing.Size(60, 60);
            this.imgThumbnail.TabIndex = 26;
            this.imgThumbnail.TabStop = false;
            // 
            // visualiation
            // 
            this.visualiation.Location = new System.Drawing.Point(107, 13);
            this.visualiation.Name = "visualiation";
            this.visualiation.Size = new System.Drawing.Size(100, 40);
            this.visualiation.TabIndex = 32;
            this.visualiation.TabStop = false;
            this.visualiation.Visible = false;
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSTT.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTT.ForeColor = System.Drawing.Color.Red;
            this.lblSTT.Location = new System.Drawing.Point(27, 9);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(37, 41);
            this.lblSTT.TabIndex = 25;
            this.lblSTT.Text = "1";
            // 
            // timerVisualiation
            // 
            this.timerVisualiation.Interval = 50;
            this.timerVisualiation.Tick += new System.EventHandler(this.timerVisualiation_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 1);
            this.panel1.TabIndex = 34;
            // 
            // btnArrowAll
            // 
            this.btnArrowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.btnArrowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowAll.FlatAppearance.BorderSize = 0;
            this.btnArrowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnArrowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnArrowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnArrowAll.IconChar = FontAwesome.Sharp.IconChar.ArrowsAlt;
            this.btnArrowAll.IconColor = System.Drawing.Color.White;
            this.btnArrowAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowAll.Location = new System.Drawing.Point(980, 12);
            this.btnArrowAll.Margin = new System.Windows.Forms.Padding(1);
            this.btnArrowAll.Name = "btnArrowAll";
            this.btnArrowAll.Size = new System.Drawing.Size(48, 48);
            this.btnArrowAll.TabIndex = 33;
            this.btnArrowAll.UseVisualStyleBackColor = false;
            this.btnArrowAll.Click += new System.EventHandler(this.btnArrowAll_Click);
            // 
            // PlaylistItemPUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.btnHeart);
            this.Controls.Add(this.lblArtistsName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.imgThumbnail);
            this.Controls.Add(this.visualiation);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnArrowAll);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PlaylistItemPUC";
            this.Size = new System.Drawing.Size(1047, 70);
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualiation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblArtistsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.PictureBox imgThumbnail;
        public System.Windows.Forms.PictureBox visualiation;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSTT;
        public System.Windows.Forms.Timer timerVisualiation;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnArrowAll;
        public FontAwesome.Sharp.IconButton btnHeart;
        public System.Windows.Forms.Label lblDuration;
    }
}
