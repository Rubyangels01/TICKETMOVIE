
namespace TICKETMOVIE
{
    partial class MovieCustom
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
            this.txtnamemovie = new System.Windows.Forms.Label();
            this.img_movie = new System.Windows.Forms.PictureBox();
            this.btnxem = new System.Windows.Forms.Button();
            this.btn_XemRevenue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnamemovie
            // 
            this.txtnamemovie.AutoSize = true;
            this.txtnamemovie.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamemovie.Location = new System.Drawing.Point(109, 370);
            this.txtnamemovie.Name = "txtnamemovie";
            this.txtnamemovie.Size = new System.Drawing.Size(118, 27);
            this.txtnamemovie.TabIndex = 1;
            this.txtnamemovie.Text = "LẬT MẶT 7";
            // 
            // img_movie
            // 
            this.img_movie.Image = global::TICKETMOVIE.Properties.Resources.imgmovie;
            this.img_movie.Location = new System.Drawing.Point(30, 12);
            this.img_movie.Name = "img_movie";
            this.img_movie.Size = new System.Drawing.Size(267, 342);
            this.img_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_movie.TabIndex = 0;
            this.img_movie.TabStop = false;
            // 
            // btnxem
            // 
            this.btnxem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxem.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Location = new System.Drawing.Point(14, 442);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(124, 38);
            this.btnxem.TabIndex = 2;
            this.btnxem.Text = "Chi Tiết";
            this.btnxem.UseVisualStyleBackColor = false;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btn_XemRevenue
            // 
            this.btn_XemRevenue.BackColor = System.Drawing.Color.Ivory;
            this.btn_XemRevenue.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemRevenue.Location = new System.Drawing.Point(174, 442);
            this.btn_XemRevenue.Name = "btn_XemRevenue";
            this.btn_XemRevenue.Size = new System.Drawing.Size(137, 38);
            this.btn_XemRevenue.TabIndex = 4;
            this.btn_XemRevenue.Text = "Lịch Chiếu";
            this.btn_XemRevenue.UseVisualStyleBackColor = false;
            this.btn_XemRevenue.Click += new System.EventHandler(this.btn_XemRevenue_Click);
            // 
            // MovieCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_XemRevenue);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.txtnamemovie);
            this.Controls.Add(this.img_movie);
            this.Name = "MovieCustom";
            this.Size = new System.Drawing.Size(326, 492);
            ((System.ComponentModel.ISupportInitialize)(this.img_movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_movie;
        private System.Windows.Forms.Label txtnamemovie;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Button btn_XemRevenue;
    }
}
