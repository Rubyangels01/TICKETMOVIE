
namespace TICKETMOVIE
{
    partial class DetailTheater
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
            this.tvAddress = new System.Windows.Forms.Label();
            this.tvnameMovie = new System.Windows.Forms.Label();
            this.flowpanelmovie = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvAddress);
            this.panel1.Controls.Add(this.tvnameMovie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 94);
            this.panel1.TabIndex = 0;
            // 
            // tvAddress
            // 
            this.tvAddress.AutoSize = true;
            this.tvAddress.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvAddress.Location = new System.Drawing.Point(618, 31);
            this.tvAddress.Name = "tvAddress";
            this.tvAddress.Size = new System.Drawing.Size(475, 27);
            this.tvAddress.TabIndex = 1;
            this.tvAddress.Text = "127 LÊ VĂN VIỆT, HIỆP PHÚ, THỦ ĐỨC, TP. HCM";
            this.tvAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tvnameMovie
            // 
            this.tvnameMovie.AutoSize = true;
            this.tvnameMovie.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvnameMovie.Location = new System.Drawing.Point(237, 31);
            this.tvnameMovie.Name = "tvnameMovie";
            this.tvnameMovie.Size = new System.Drawing.Size(187, 27);
            this.tvnameMovie.TabIndex = 0;
            this.tvnameMovie.Text = "CGV LÊ VĂN VIỆT";
            this.tvnameMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowpanelmovie
            // 
            this.flowpanelmovie.AutoScroll = true;
            this.flowpanelmovie.BackColor = System.Drawing.Color.White;
            this.flowpanelmovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelmovie.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowpanelmovie.Location = new System.Drawing.Point(0, 94);
            this.flowpanelmovie.Name = "flowpanelmovie";
            this.flowpanelmovie.Size = new System.Drawing.Size(1306, 505);
            this.flowpanelmovie.TabIndex = 1;
            // 
            // DetailTheater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 599);
            this.Controls.Add(this.flowpanelmovie);
            this.Controls.Add(this.panel1);
            this.Name = "DetailTheater";
            this.Text = "DetailTheater";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tvAddress;
        private System.Windows.Forms.Label tvnameMovie;
        private System.Windows.Forms.FlowLayoutPanel flowpanelmovie;
    }
}