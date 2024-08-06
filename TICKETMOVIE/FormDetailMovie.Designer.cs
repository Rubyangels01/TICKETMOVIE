
namespace TICKETMOVIE
{
    partial class FormDetailMovie
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
            this.panel_infor_movie = new System.Windows.Forms.Panel();
            this.btn_Revenue = new System.Windows.Forms.Button();
            this.btn_Setschedule = new System.Windows.Forms.Button();
            this.txtdescription = new System.Windows.Forms.Label();
            this.txtcast = new System.Windows.Forms.Label();
            this.txtlanguage = new System.Windows.Forms.Label();
            this.txtreleaseddate = new System.Windows.Forms.Label();
            this.txttime = new System.Windows.Forms.Label();
            this.txttypemovie = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnamemovie = new System.Windows.Forms.Label();
            this.img_movie = new System.Windows.Forms.PictureBox();
            this.icon_back = new System.Windows.Forms.PictureBox();
            this.panel_infor_movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_movie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_infor_movie
            // 
            this.panel_infor_movie.BackColor = System.Drawing.Color.White;
            this.panel_infor_movie.Controls.Add(this.icon_back);
            this.panel_infor_movie.Controls.Add(this.btn_Revenue);
            this.panel_infor_movie.Controls.Add(this.btn_Setschedule);
            this.panel_infor_movie.Controls.Add(this.txtdescription);
            this.panel_infor_movie.Controls.Add(this.txtcast);
            this.panel_infor_movie.Controls.Add(this.txtlanguage);
            this.panel_infor_movie.Controls.Add(this.txtreleaseddate);
            this.panel_infor_movie.Controls.Add(this.txttime);
            this.panel_infor_movie.Controls.Add(this.txttypemovie);
            this.panel_infor_movie.Controls.Add(this.label7);
            this.panel_infor_movie.Controls.Add(this.label6);
            this.panel_infor_movie.Controls.Add(this.label5);
            this.panel_infor_movie.Controls.Add(this.label4);
            this.panel_infor_movie.Controls.Add(this.label3);
            this.panel_infor_movie.Controls.Add(this.label2);
            this.panel_infor_movie.Controls.Add(this.txtnamemovie);
            this.panel_infor_movie.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_infor_movie.Location = new System.Drawing.Point(0, 0);
            this.panel_infor_movie.Name = "panel_infor_movie";
            this.panel_infor_movie.Size = new System.Drawing.Size(667, 573);
            this.panel_infor_movie.TabIndex = 0;
            // 
            // btn_Revenue
            // 
            this.btn_Revenue.BackColor = System.Drawing.Color.White;
            this.btn_Revenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Revenue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Revenue.Location = new System.Drawing.Point(351, 508);
            this.btn_Revenue.Name = "btn_Revenue";
            this.btn_Revenue.Size = new System.Drawing.Size(121, 42);
            this.btn_Revenue.TabIndex = 14;
            this.btn_Revenue.Text = "Doanh Thu";
            this.btn_Revenue.UseVisualStyleBackColor = false;
            this.btn_Revenue.Click += new System.EventHandler(this.btn_Revenue_Click);
            // 
            // btn_Setschedule
            // 
            this.btn_Setschedule.BackColor = System.Drawing.Color.Blue;
            this.btn_Setschedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Setschedule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Setschedule.Location = new System.Drawing.Point(524, 508);
            this.btn_Setschedule.Name = "btn_Setschedule";
            this.btn_Setschedule.Size = new System.Drawing.Size(121, 42);
            this.btn_Setschedule.TabIndex = 13;
            this.btn_Setschedule.Text = "Đặt lịch chiếu";
            this.btn_Setschedule.UseVisualStyleBackColor = false;
            this.btn_Setschedule.Click += new System.EventHandler(this.btn_Setschedule_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.AutoSize = true;
            this.txtdescription.Location = new System.Drawing.Point(369, 321);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(193, 17);
            this.txtdescription.TabIndex = 12;
            this.txtdescription.Text = "Bộ phim xoay quanh tình cảm";
            // 
            // txtcast
            // 
            this.txtcast.AutoSize = true;
            this.txtcast.Location = new System.Drawing.Point(366, 268);
            this.txtcast.Name = "txtcast";
            this.txtcast.Size = new System.Drawing.Size(224, 17);
            this.txtcast.TabIndex = 11;
            this.txtcast.Text = "Hoàng Minh Hải. Nguyễn Tú Châu";
            // 
            // txtlanguage
            // 
            this.txtlanguage.AutoSize = true;
            this.txtlanguage.Location = new System.Drawing.Point(369, 223);
            this.txtlanguage.Name = "txtlanguage";
            this.txtlanguage.Size = new System.Drawing.Size(116, 17);
            this.txtlanguage.TabIndex = 10;
            this.txtlanguage.Text = "English - VietSub";
            // 
            // txtreleaseddate
            // 
            this.txtreleaseddate.AutoSize = true;
            this.txtreleaseddate.Location = new System.Drawing.Point(369, 180);
            this.txtreleaseddate.Name = "txtreleaseddate";
            this.txtreleaseddate.Size = new System.Drawing.Size(80, 17);
            this.txtreleaseddate.TabIndex = 9;
            this.txtreleaseddate.Text = "27/07/2024";
            // 
            // txttime
            // 
            this.txttime.AutoSize = true;
            this.txttime.Location = new System.Drawing.Point(369, 135);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(64, 17);
            this.txttime.TabIndex = 8;
            this.txttime.Text = "138 phút";
            // 
            // txttypemovie
            // 
            this.txttypemovie.AutoSize = true;
            this.txttypemovie.Location = new System.Drawing.Point(366, 100);
            this.txttypemovie.Name = "txttypemovie";
            this.txttypemovie.Size = new System.Drawing.Size(111, 17);
            this.txttypemovie.TabIndex = 7;
            this.txttypemovie.Text = "Tình cảm, tâm lý";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Diễn viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngôn ngữ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày khởi chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thể loại";
            // 
            // txtnamemovie
            // 
            this.txtnamemovie.AutoSize = true;
            this.txtnamemovie.BackColor = System.Drawing.Color.Transparent;
            this.txtnamemovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamemovie.ForeColor = System.Drawing.Color.Black;
            this.txtnamemovie.Location = new System.Drawing.Point(109, 40);
            this.txtnamemovie.Name = "txtnamemovie";
            this.txtnamemovie.Size = new System.Drawing.Size(321, 29);
            this.txtnamemovie.TabIndex = 0;
            this.txtnamemovie.Text = "LẬT MẶT 7: MỘT ĐIỀU ƯỚC";
            this.txtnamemovie.Click += new System.EventHandler(this.label1_Click);
            // 
            // img_movie
            // 
            this.img_movie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_movie.Image = global::TICKETMOVIE.Properties.Resources.imgmovie;
            this.img_movie.Location = new System.Drawing.Point(667, 0);
            this.img_movie.Name = "img_movie";
            this.img_movie.Size = new System.Drawing.Size(454, 573);
            this.img_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_movie.TabIndex = 1;
            this.img_movie.TabStop = false;
            // 
            // icon_back
            // 
            this.icon_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_back.Image = global::TICKETMOVIE.Properties.Resources.icon_back1;
            this.icon_back.Location = new System.Drawing.Point(31, 39);
            this.icon_back.Name = "icon_back";
            this.icon_back.Size = new System.Drawing.Size(23, 30);
            this.icon_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_back.TabIndex = 15;
            this.icon_back.TabStop = false;
            this.icon_back.Click += new System.EventHandler(this.icon_back_Click);
            // 
            // FormDetailMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 573);
            this.Controls.Add(this.img_movie);
            this.Controls.Add(this.panel_infor_movie);
            this.Name = "FormDetailMovie";
            this.Text = "FormDetailMovie";
            this.Load += new System.EventHandler(this.FormDetailMovie_Load);
            this.panel_infor_movie.ResumeLayout(false);
            this.panel_infor_movie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_movie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_infor_movie;
        private System.Windows.Forms.Label txtnamemovie;
        private System.Windows.Forms.PictureBox img_movie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtdescription;
        private System.Windows.Forms.Label txtcast;
        private System.Windows.Forms.Label txtlanguage;
        private System.Windows.Forms.Label txtreleaseddate;
        private System.Windows.Forms.Label txttime;
        private System.Windows.Forms.Label txttypemovie;
        private System.Windows.Forms.Button btn_Setschedule;
        private System.Windows.Forms.Button btn_Revenue;
        private System.Windows.Forms.PictureBox icon_back;
    }
}