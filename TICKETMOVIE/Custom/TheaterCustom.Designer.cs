
namespace TICKETMOVIE.Custom
{
    partial class TheaterCustom
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
            this.nameTheater = new System.Windows.Forms.Label();
            this.addresstheater = new System.Windows.Forms.Label();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTheater
            // 
            this.nameTheater.AutoSize = true;
            this.nameTheater.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTheater.Location = new System.Drawing.Point(253, 25);
            this.nameTheater.Name = "nameTheater";
            this.nameTheater.Size = new System.Drawing.Size(187, 27);
            this.nameTheater.TabIndex = 1;
            this.nameTheater.Text = "CGV LÊ VĂN VIỆT";
            // 
            // addresstheater
            // 
            this.addresstheater.AutoSize = true;
            this.addresstheater.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstheater.Location = new System.Drawing.Point(254, 64);
            this.addresstheater.Name = "addresstheater";
            this.addresstheater.Size = new System.Drawing.Size(314, 23);
            this.addresstheater.TabIndex = 2;
            this.addresstheater.Text = "57 VinCom Lê Văn Việt, Lầu 3, TP.HCM";
            // 
            // btn_Xem
            // 
            this.btn_Xem.BackColor = System.Drawing.Color.Blue;
            this.btn_Xem.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.ForeColor = System.Drawing.Color.White;
            this.btn_Xem.Location = new System.Drawing.Point(459, 133);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(109, 45);
            this.btn_Xem.TabIndex = 3;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = false;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TICKETMOVIE.Properties.Resources.pandoraimage;
            this.pictureBox1.Location = new System.Drawing.Point(26, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TheaterCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_Xem);
            this.Controls.Add(this.addresstheater);
            this.Controls.Add(this.nameTheater);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TheaterCustom";
            this.Size = new System.Drawing.Size(623, 194);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameTheater;
        private System.Windows.Forms.Label addresstheater;
        private System.Windows.Forms.Button btn_Xem;
    }
}
