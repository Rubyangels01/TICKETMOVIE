
namespace TICKETMOVIE.Ui.Admin
{
    partial class AddMoviePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.datereleaseddate = new DevExpress.XtraEditors.DateEdit();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtcast = new System.Windows.Forms.TextBox();
            this.cblanguage = new System.Windows.Forms.ComboBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.txtnamemovie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Chooseimg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgmovie = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datereleaseddate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datereleaseddate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgmovie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.datereleaseddate);
            this.panel1.Controls.Add(this.btnAddMovie);
            this.panel1.Controls.Add(this.txtdescription);
            this.panel1.Controls.Add(this.txtcast);
            this.panel1.Controls.Add(this.cblanguage);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.txttime);
            this.panel1.Controls.Add(this.cbtype);
            this.panel1.Controls.Add(this.txtnamemovie);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Chooseimg);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgmovie);
            this.panel1.Location = new System.Drawing.Point(348, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 512);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(597, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Khởi chiếu";
            // 
            // datereleaseddate
            // 
            this.datereleaseddate.EditValue = null;
            this.datereleaseddate.Location = new System.Drawing.Point(726, 261);
            this.datereleaseddate.Margin = new System.Windows.Forms.Padding(4);
            this.datereleaseddate.Name = "datereleaseddate";
            this.datereleaseddate.Properties.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datereleaseddate.Properties.Appearance.Options.UseFont = true;
            this.datereleaseddate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datereleaseddate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datereleaseddate.Size = new System.Drawing.Size(237, 30);
            this.datereleaseddate.TabIndex = 33;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(855, 426);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(117, 36);
            this.btnAddMovie.TabIndex = 32;
            this.btnAddMovie.Text = "Thêm phim";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(498, 371);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(465, 22);
            this.txtdescription.TabIndex = 31;
            // 
            // txtcast
            // 
            this.txtcast.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcast.Location = new System.Drawing.Point(498, 309);
            this.txtcast.Multiline = true;
            this.txtcast.Name = "txtcast";
            this.txtcast.Size = new System.Drawing.Size(465, 22);
            this.txtcast.TabIndex = 30;
            // 
            // cblanguage
            // 
            this.cblanguage.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblanguage.FormattingEnabled = true;
            this.cblanguage.Location = new System.Drawing.Point(726, 212);
            this.cblanguage.Name = "cblanguage";
            this.cblanguage.Size = new System.Drawing.Size(237, 31);
            this.cblanguage.TabIndex = 29;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(726, 171);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(237, 30);
            this.txtprice.TabIndex = 28;
            // 
            // txttime
            // 
            this.txttime.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.Location = new System.Drawing.Point(726, 133);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(237, 30);
            this.txttime.TabIndex = 27;
            // 
            // cbtype
            // 
            this.cbtype.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Location = new System.Drawing.Point(726, 94);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(237, 31);
            this.cbtype.TabIndex = 26;
            this.cbtype.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
            // 
            // txtnamemovie
            // 
            this.txtnamemovie.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamemovie.Location = new System.Drawing.Point(726, 53);
            this.txtnamemovie.Name = "txtnamemovie";
            this.txtnamemovie.Size = new System.Drawing.Size(237, 30);
            this.txtnamemovie.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Diễn viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngôn ngữ";
            // 
            // btn_Chooseimg
            // 
            this.btn_Chooseimg.Location = new System.Drawing.Point(368, 226);
            this.btn_Chooseimg.Name = "btn_Chooseimg";
            this.btn_Chooseimg.Size = new System.Drawing.Size(128, 30);
            this.btn_Chooseimg.TabIndex = 21;
            this.btn_Chooseimg.Text = "Chọn Ảnh";
            this.btn_Chooseimg.UseVisualStyleBackColor = true;
            this.btn_Chooseimg.Click += new System.EventHandler(this.btn_Chooseimg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Giá vé phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Thời lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên Phim";
            // 
            // imgmovie
            // 
            this.imgmovie.BackColor = System.Drawing.Color.Gainsboro;
            this.imgmovie.Location = new System.Drawing.Point(324, 53);
            this.imgmovie.Name = "imgmovie";
            this.imgmovie.Size = new System.Drawing.Size(205, 167);
            this.imgmovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgmovie.TabIndex = 16;
            this.imgmovie.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(847, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "THÊM PHIM";
            // 
            // AddMoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::TICKETMOVIE.Properties.Resources.header_main;
            this.ClientSize = new System.Drawing.Size(1499, 619);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "AddMoviePage";
            this.Text = "AddMoviePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datereleaseddate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datereleaseddate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgmovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtcast;
        private System.Windows.Forms.ComboBox cblanguage;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.TextBox txtnamemovie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Chooseimg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgmovie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.DateEdit datereleaseddate;
    }
}