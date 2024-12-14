
namespace TICKETMOVIE
{
    partial class MoviePage
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
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.edshowdate = new DevExpress.XtraEditors.DateEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_picture = new System.Windows.Forms.PictureBox();
            this.panel_infomovie = new System.Windows.Forms.Panel();
            this.cast = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.releasedtime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.nameMovie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btncreateschedule = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_room = new System.Windows.Forms.ComboBox();
            this.icon_reload = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_hour = new System.Windows.Forms.ComboBox();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_minute = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edshowdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edshowdate.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_picture)).BeginInit();
            this.panel_infomovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_reload)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // edshowdate
            // 
            this.edshowdate.EditValue = null;
            this.edshowdate.Location = new System.Drawing.Point(1071, 68);
            this.edshowdate.Margin = new System.Windows.Forms.Padding(4);
            this.edshowdate.Name = "edshowdate";
            this.edshowdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edshowdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edshowdate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.edshowdate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.edshowdate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.edshowdate.Size = new System.Drawing.Size(199, 22);
            this.edshowdate.TabIndex = 2;
            this.edshowdate.EditValueChanged += new System.EventHandler(this.edshowdate_EditValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.img_picture);
            this.panel1.Controls.Add(this.panel_infomovie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 623);
            this.panel1.TabIndex = 0;
            // 
            // img_picture
            // 
            this.img_picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.img_picture.Location = new System.Drawing.Point(0, 0);
            this.img_picture.Name = "img_picture";
            this.img_picture.Size = new System.Drawing.Size(605, 274);
            this.img_picture.TabIndex = 2;
            this.img_picture.TabStop = false;
            // 
            // panel_infomovie
            // 
            this.panel_infomovie.Controls.Add(this.cast);
            this.panel_infomovie.Controls.Add(this.label12);
            this.panel_infomovie.Controls.Add(this.language);
            this.panel_infomovie.Controls.Add(this.label10);
            this.panel_infomovie.Controls.Add(this.releasedtime);
            this.panel_infomovie.Controls.Add(this.label7);
            this.panel_infomovie.Controls.Add(this.description);
            this.panel_infomovie.Controls.Add(this.label5);
            this.panel_infomovie.Controls.Add(this.pictureBox1);
            this.panel_infomovie.Controls.Add(this.time);
            this.panel_infomovie.Controls.Add(this.nameMovie);
            this.panel_infomovie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_infomovie.Location = new System.Drawing.Point(0, 280);
            this.panel_infomovie.Name = "panel_infomovie";
            this.panel_infomovie.Size = new System.Drawing.Size(605, 343);
            this.panel_infomovie.TabIndex = 1;
            // 
            // cast
            // 
            this.cast.AutoSize = true;
            this.cast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cast.ForeColor = System.Drawing.Color.Transparent;
            this.cast.Location = new System.Drawing.Point(213, 293);
            this.cast.Name = "cast";
            this.cast.Size = new System.Drawing.Size(238, 20);
            this.cast.TabIndex = 10;
            this.cast.Text = "Trần Phi Vũ, Nguyễn Đức Minh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(29, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Cast:";
            // 
            // language
            // 
            this.language.AutoSize = true;
            this.language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language.ForeColor = System.Drawing.Color.Transparent;
            this.language.Location = new System.Drawing.Point(213, 249);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(97, 20);
            this.language.TabIndex = 8;
            this.language.Text = "Vietnamese";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(29, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Language:";
            // 
            // releasedtime
            // 
            this.releasedtime.AutoSize = true;
            this.releasedtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releasedtime.ForeColor = System.Drawing.Color.Transparent;
            this.releasedtime.Location = new System.Drawing.Point(213, 196);
            this.releasedtime.Name = "releasedtime";
            this.releasedtime.Size = new System.Drawing.Size(91, 20);
            this.releasedtime.TabIndex = 6;
            this.releasedtime.Text = "15/05/2024";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(29, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Released Date: ";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Transparent;
            this.description.Location = new System.Drawing.Point(34, 147);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(353, 20);
            this.description.TabIndex = 4;
            this.description.Text = "Bộ phim nói về tình mẫu tử thiêng liêng cao cả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(29, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Desciption: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TICKETMOVIE.Properties.Resources.oclock;
            this.pictureBox1.Location = new System.Drawing.Point(29, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Transparent;
            this.time.ImageKey = "(none)";
            this.time.Location = new System.Drawing.Point(57, 64);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(75, 20);
            this.time.TabIndex = 1;
            this.time.Text = "138 Phút";
            // 
            // nameMovie
            // 
            this.nameMovie.AutoSize = true;
            this.nameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameMovie.ForeColor = System.Drawing.Color.Transparent;
            this.nameMovie.Location = new System.Drawing.Point(24, 16);
            this.nameMovie.Name = "nameMovie";
            this.nameMovie.Size = new System.Drawing.Size(133, 29);
            this.nameMovie.TabIndex = 0;
            this.nameMovie.Text = "LẬT MẶT 7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(950, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày chiếu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(673, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 29);
            this.label13.TabIndex = 6;
            this.label13.Text = "Thêm lịch chiếu";
            // 
            // btncreateschedule
            // 
            this.btncreateschedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btncreateschedule.Location = new System.Drawing.Point(1151, 171);
            this.btncreateschedule.Name = "btncreateschedule";
            this.btncreateschedule.Size = new System.Drawing.Size(126, 32);
            this.btncreateschedule.TabIndex = 7;
            this.btncreateschedule.Text = "Tạo lịch chiếu";
            this.btncreateschedule.UseVisualStyleBackColor = false;
            this.btncreateschedule.Click += new System.EventHandler(this.btncreateschedule_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(675, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Giờ";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Green;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(605, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(670, 10);
            this.label15.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Phòng";
            // 
            // cb_room
            // 
            this.cb_room.Enabled = false;
            this.cb_room.FormattingEnabled = true;
            this.cb_room.Location = new System.Drawing.Point(751, 150);
            this.cb_room.Name = "cb_room";
            this.cb_room.Size = new System.Drawing.Size(121, 24);
            this.cb_room.TabIndex = 23;
            this.cb_room.SelectedIndexChanged += new System.EventHandler(this.cb_room_SelectedIndexChanged);
            // 
            // icon_reload
            // 
            this.icon_reload.Image = global::TICKETMOVIE.Properties.Resources.iconreload;
            this.icon_reload.Location = new System.Drawing.Point(1238, 20);
            this.icon_reload.Name = "icon_reload";
            this.icon_reload.Size = new System.Drawing.Size(32, 32);
            this.icon_reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_reload.TabIndex = 26;
            this.icon_reload.TabStop = false;
            this.icon_reload.Click += new System.EventHandler(this.icon_reload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Phút";
            // 
            // cb_hour
            // 
            this.cb_hour.Enabled = false;
            this.cb_hour.FormattingEnabled = true;
            this.cb_hour.Location = new System.Drawing.Point(751, 71);
            this.cb_hour.Name = "cb_hour";
            this.cb_hour.Size = new System.Drawing.Size(121, 24);
            this.cb_hour.TabIndex = 29;
            this.cb_hour.SelectedIndexChanged += new System.EventHandler(this.cb_hour_SelectedIndexChanged);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.Beige;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.dataGridView1);
            this.sidePanel1.Controls.Add(this.cb_minute);
            this.sidePanel1.Controls.Add(this.cb_hour);
            this.sidePanel1.Controls.Add(this.label2);
            this.sidePanel1.Controls.Add(this.icon_reload);
            this.sidePanel1.Controls.Add(this.cb_room);
            this.sidePanel1.Controls.Add(this.label3);
            this.sidePanel1.Controls.Add(this.label15);
            this.sidePanel1.Controls.Add(this.label14);
            this.sidePanel1.Controls.Add(this.btncreateschedule);
            this.sidePanel1.Controls.Add(this.label13);
            this.sidePanel1.Controls.Add(this.label1);
            this.sidePanel1.Controls.Add(this.panel1);
            this.sidePanel1.Controls.Add(this.edshowdate);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1285, 623);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(605, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 405);
            this.dataGridView1.TabIndex = 31;
            // 
            // cb_minute
            // 
            this.cb_minute.Enabled = false;
            this.cb_minute.FormattingEnabled = true;
            this.cb_minute.Location = new System.Drawing.Point(751, 108);
            this.cb_minute.Name = "cb_minute";
            this.cb_minute.Size = new System.Drawing.Size(121, 24);
            this.cb_minute.TabIndex = 30;
            this.cb_minute.SelectedIndexChanged += new System.EventHandler(this.cb_minute_SelectedIndexChanged);
            // 
            // MoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 623);
            this.Controls.Add(this.sidePanel1);
            this.Name = "MoviePage";
            this.Text = "MoviePage";
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edshowdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edshowdate.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_picture)).EndInit();
            this.panel_infomovie.ResumeLayout(false);
            this.panel_infomovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_reload)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private DevExpress.XtraEditors.DateEdit edshowdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox img_picture;
        private System.Windows.Forms.Panel panel_infomovie;
        private System.Windows.Forms.Label cast;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label language;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label releasedtime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label nameMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btncreateschedule;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_room;
        private System.Windows.Forms.PictureBox icon_reload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_hour;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.ComboBox cb_minute;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}