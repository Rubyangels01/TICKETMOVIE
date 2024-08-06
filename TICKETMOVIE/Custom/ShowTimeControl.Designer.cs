
namespace TICKETMOVIE.Custom
{
    partial class ShowTimeControl
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
            this.panel_hourshow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_display = new System.Windows.Forms.FlowLayoutPanel();
            this.showdate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelroom = new System.Windows.Forms.Label();
            this.panel_display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_hourshow
            // 
            this.panel_hourshow.BackColor = System.Drawing.Color.White;
            this.panel_hourshow.Location = new System.Drawing.Point(3, 35);
            this.panel_hourshow.Name = "panel_hourshow";
            this.panel_hourshow.Size = new System.Drawing.Size(582, 53);
            this.panel_hourshow.TabIndex = 1;
            // 
            // panel_display
            // 
            this.panel_display.BackColor = System.Drawing.Color.GhostWhite;
            this.panel_display.Controls.Add(this.showdate);
            this.panel_display.Controls.Add(this.labelroom);
            this.panel_display.Controls.Add(this.pictureBox2);
            this.panel_display.Controls.Add(this.panel_hourshow);
            this.panel_display.Location = new System.Drawing.Point(3, 3);
            this.panel_display.Name = "panel_display";
            this.panel_display.Size = new System.Drawing.Size(595, 104);
            this.panel_display.TabIndex = 2;
            // 
            // showdate
            // 
            this.showdate.AutoSize = true;
            this.showdate.BackColor = System.Drawing.Color.Transparent;
            this.showdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showdate.ForeColor = System.Drawing.Color.Black;
            this.showdate.Location = new System.Drawing.Point(3, 0);
            this.showdate.Name = "showdate";
            this.showdate.Size = new System.Drawing.Size(118, 29);
            this.showdate.TabIndex = 0;
            this.showdate.Text = "15/5/2024";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TICKETMOVIE.Properties.Resources.icon_edit;
            this.pictureBox2.Location = new System.Drawing.Point(284, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelroom
            // 
            this.labelroom.AutoSize = true;
            this.labelroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelroom.Location = new System.Drawing.Point(127, 0);
            this.labelroom.Name = "labelroom";
            this.labelroom.Size = new System.Drawing.Size(151, 29);
            this.labelroom.TabIndex = 5;
            this.labelroom.Text = "PHÒNG N01";
            // 
            // ShowTimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_display);
            this.Name = "ShowTimeControl";
            this.Size = new System.Drawing.Size(601, 117);
            this.panel_display.ResumeLayout(false);
            this.panel_display.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel_hourshow;
        private System.Windows.Forms.FlowLayoutPanel panel_display;
        private System.Windows.Forms.Label showdate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelroom;
    }
}
