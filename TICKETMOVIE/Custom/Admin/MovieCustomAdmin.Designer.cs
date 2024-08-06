
namespace TICKETMOVIE.Custom.Admin
{
    partial class MovieCustomAdmin
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
            this.namemovie = new System.Windows.Forms.Label();
            this.releaseddate = new System.Windows.Forms.Label();
            this.btn_xem = new System.Windows.Forms.Button();
            this.img_movie = new System.Windows.Forms.PictureBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // namemovie
            // 
            this.namemovie.AutoSize = true;
            this.namemovie.Location = new System.Drawing.Point(221, 48);
            this.namemovie.Name = "namemovie";
            this.namemovie.Size = new System.Drawing.Size(192, 17);
            this.namemovie.TabIndex = 1;
            this.namemovie.Text = "LẬT MẶT 7 : MỘT ĐIỀU ƯỚC";
            // 
            // releaseddate
            // 
            this.releaseddate.AutoSize = true;
            this.releaseddate.Location = new System.Drawing.Point(221, 82);
            this.releaseddate.Name = "releaseddate";
            this.releaseddate.Size = new System.Drawing.Size(72, 17);
            this.releaseddate.TabIndex = 3;
            this.releaseddate.Text = "17/9/2024";
            // 
            // btn_xem
            // 
            this.btn_xem.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.Location = new System.Drawing.Point(224, 143);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(99, 31);
            this.btn_xem.TabIndex = 4;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // img_movie
            // 
            this.img_movie.Image = global::TICKETMOVIE.Properties.Resources.imgmovie;
            this.img_movie.Location = new System.Drawing.Point(28, 15);
            this.img_movie.Name = "img_movie";
            this.img_movie.Size = new System.Drawing.Size(150, 171);
            this.img_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_movie.TabIndex = 0;
            this.img_movie.TabStop = false;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Edit.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(380, 143);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(99, 31);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = false;
            // 
            // MovieCustomAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.releaseddate);
            this.Controls.Add(this.namemovie);
            this.Controls.Add(this.img_movie);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MovieCustomAdmin";
            this.Size = new System.Drawing.Size(636, 199);
            this.Click += new System.EventHandler(this.MovieCustomAdmin_Click);
            ((System.ComponentModel.ISupportInitialize)(this.img_movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_movie;
        private System.Windows.Forms.Label namemovie;
        private System.Windows.Forms.Label releaseddate;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_Edit;
    }
}
