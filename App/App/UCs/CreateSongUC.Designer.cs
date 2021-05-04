
namespace App.UCs
{
    partial class CreateSongUC
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
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnURL = new FontAwesome.Sharp.IconButton();
            this.btnLyric = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPerformer = new System.Windows.Forms.Panel();
            this.txtPerformer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlArtistName = new System.Windows.Forms.Panel();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDisplayName = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlThumbnail = new System.Windows.Forms.Panel();
            this.imgThumbnail = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlThumbnail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbnail)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 39;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Font = new System.Drawing.Font("Consolas", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.lblDisplayName.Location = new System.Drawing.Point(120, 6);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(797, 56);
            this.lblDisplayName.TabIndex = 40;
            this.lblDisplayName.Text = "THÊM BÀI HÁT MỚI";
            this.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnURL);
            this.panel1.Controls.Add(this.btnLyric);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pnlPerformer);
            this.panel1.Controls.Add(this.txtPerformer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pnlArtistName);
            this.panel1.Controls.Add(this.txtArtistName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pnlTitle);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlDisplayName);
            this.panel1.Controls.Add(this.txtDisplayName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pnlThumbnail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 548);
            this.panel1.TabIndex = 41;
            // 
            // btnURL
            // 
            this.btnURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnURL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.btnURL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.btnURL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.btnURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnURL.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.btnURL.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnURL.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.btnURL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnURL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnURL.Location = new System.Drawing.Point(468, 410);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(118, 35);
            this.btnURL.TabIndex = 105;
            this.btnURL.Text = "Audio";
            this.btnURL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnURL.UseVisualStyleBackColor = true;
            this.btnURL.Click += new System.EventHandler(this.btnURL_Click);
            // 
            // btnLyric
            // 
            this.btnLyric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLyric.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.btnLyric.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.btnLyric.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.btnLyric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLyric.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLyric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.btnLyric.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnLyric.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.btnLyric.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLyric.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLyric.Location = new System.Drawing.Point(468, 351);
            this.btnLyric.Name = "btnLyric";
            this.btnLyric.Size = new System.Drawing.Size(118, 35);
            this.btnLyric.TabIndex = 104;
            this.btnLyric.Text = "Lyric";
            this.btnLyric.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLyric.UseVisualStyleBackColor = true;
            this.btnLyric.Click += new System.EventHandler(this.btnLyric_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 16.125F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(34)))), ((int)(((byte)(101)))));
            this.btnUpdate.Location = new System.Drawing.Point(691, 502);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 46);
            this.btnUpdate.TabIndex = 103;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "THOÁT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnCreate.FlatAppearance.BorderSize = 2;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCreate.Location = new System.Drawing.Point(892, 502);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(173, 43);
            this.btnCreate.TabIndex = 102;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "THÊM";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label6.Location = new System.Drawing.Point(324, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 101;
            this.label6.Text = "*Audio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label5.Location = new System.Drawing.Point(324, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 99;
            this.label5.Text = "*Lời nhạc:";
            // 
            // pnlPerformer
            // 
            this.pnlPerformer.BackColor = System.Drawing.Color.Silver;
            this.pnlPerformer.ForeColor = System.Drawing.Color.Red;
            this.pnlPerformer.Location = new System.Drawing.Point(468, 312);
            this.pnlPerformer.Name = "pnlPerformer";
            this.pnlPerformer.Size = new System.Drawing.Size(581, 2);
            this.pnlPerformer.TabIndex = 97;
            // 
            // txtPerformer
            // 
            this.txtPerformer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.txtPerformer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPerformer.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerformer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.txtPerformer.Location = new System.Drawing.Point(480, 292);
            this.txtPerformer.Name = "txtPerformer";
            this.txtPerformer.Size = new System.Drawing.Size(569, 33);
            this.txtPerformer.TabIndex = 95;
            this.txtPerformer.Enter += new System.EventHandler(this.txtPerformer_Enter);
            this.txtPerformer.Leave += new System.EventHandler(this.txtPerformer_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label4.Location = new System.Drawing.Point(324, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 96;
            this.label4.Text = "*Trình bày:";
            // 
            // pnlArtistName
            // 
            this.pnlArtistName.BackColor = System.Drawing.Color.Silver;
            this.pnlArtistName.ForeColor = System.Drawing.Color.Red;
            this.pnlArtistName.Location = new System.Drawing.Point(468, 252);
            this.pnlArtistName.Name = "pnlArtistName";
            this.pnlArtistName.Size = new System.Drawing.Size(581, 2);
            this.pnlArtistName.TabIndex = 94;
            // 
            // txtArtistName
            // 
            this.txtArtistName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.txtArtistName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArtistName.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.txtArtistName.Location = new System.Drawing.Point(480, 232);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(569, 33);
            this.txtArtistName.TabIndex = 92;
            this.txtArtistName.Enter += new System.EventHandler(this.txtArtistName_Enter);
            this.txtArtistName.Leave += new System.EventHandler(this.txtArtistName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label3.Location = new System.Drawing.Point(324, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 93;
            this.label3.Text = "*Tác giả:";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Silver;
            this.pnlTitle.ForeColor = System.Drawing.Color.Red;
            this.pnlTitle.Location = new System.Drawing.Point(468, 191);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(581, 2);
            this.pnlTitle.TabIndex = 91;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.txtTitle.Location = new System.Drawing.Point(480, 171);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(569, 33);
            this.txtTitle.TabIndex = 89;
            this.txtTitle.Enter += new System.EventHandler(this.txtTitle_Enter);
            this.txtTitle.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(324, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "*Tiêu đề:";
            // 
            // cbbCategory
            // 
            this.cbbCategory.BackColor = System.Drawing.Color.White;
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCategory.Font = new System.Drawing.Font("Consolas", 21F);
            this.cbbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(468, 105);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(581, 41);
            this.cbbCategory.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(324, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "*Thể loại:";
            // 
            // pnlDisplayName
            // 
            this.pnlDisplayName.BackColor = System.Drawing.Color.Silver;
            this.pnlDisplayName.ForeColor = System.Drawing.Color.Red;
            this.pnlDisplayName.Location = new System.Drawing.Point(468, 56);
            this.pnlDisplayName.Name = "pnlDisplayName";
            this.pnlDisplayName.Size = new System.Drawing.Size(581, 2);
            this.pnlDisplayName.TabIndex = 86;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.txtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayName.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.txtDisplayName.Location = new System.Drawing.Point(480, 36);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(569, 33);
            this.txtDisplayName.TabIndex = 84;
            this.txtDisplayName.Enter += new System.EventHandler(this.txtDisplayName_Enter);
            this.txtDisplayName.Leave += new System.EventHandler(this.txtDisplayName_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label9.Location = new System.Drawing.Point(324, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 85;
            this.label9.Text = "*Tên bài hát:";
            // 
            // pnlThumbnail
            // 
            this.pnlThumbnail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.pnlThumbnail.Controls.Add(this.imgThumbnail);
            this.pnlThumbnail.Location = new System.Drawing.Point(3, 4);
            this.pnlThumbnail.Name = "pnlThumbnail";
            this.pnlThumbnail.Size = new System.Drawing.Size(304, 304);
            this.pnlThumbnail.TabIndex = 3;
            // 
            // imgThumbnail
            // 
            this.imgThumbnail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.imgThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgThumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgThumbnail.Location = new System.Drawing.Point(2, 2);
            this.imgThumbnail.Margin = new System.Windows.Forms.Padding(0);
            this.imgThumbnail.Name = "imgThumbnail";
            this.imgThumbnail.Size = new System.Drawing.Size(300, 300);
            this.imgThumbnail.TabIndex = 2;
            this.imgThumbnail.TabStop = false;
            this.imgThumbnail.Click += new System.EventHandler(this.imgMain_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(983, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 61);
            this.panel2.TabIndex = 42;
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
            this.btnClose.Location = new System.Drawing.Point(52, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 17;
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
            this.btnMinimize.Location = new System.Drawing.Point(10, 6);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "--";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // CreateSongUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CreateSongUC";
            this.Size = new System.Drawing.Size(1071, 609);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlThumbnail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbnail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlThumbnail;
        private System.Windows.Forms.PictureBox imgThumbnail;
        private System.Windows.Forms.Panel pnlDisplayName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPerformer;
        private System.Windows.Forms.TextBox txtPerformer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlArtistName;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private FontAwesome.Sharp.IconButton btnLyric;
        private FontAwesome.Sharp.IconButton btnURL;
    }
}
