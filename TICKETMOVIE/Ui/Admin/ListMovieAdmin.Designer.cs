﻿
namespace TICKETMOVIE.Ui.Admin
{
    partial class ListMovieAdmin
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
            this.flowpanellistmovie = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 100);
            this.panel1.TabIndex = 0;
            // 
            // flowpanellistmovie
            // 
            this.flowpanellistmovie.AutoScroll = true;
            this.flowpanellistmovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanellistmovie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowpanellistmovie.Location = new System.Drawing.Point(0, 100);
            this.flowpanellistmovie.Name = "flowpanellistmovie";
            this.flowpanellistmovie.Size = new System.Drawing.Size(1235, 510);
            this.flowpanellistmovie.TabIndex = 1;
            // 
            // ListMovieAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 610);
            this.Controls.Add(this.flowpanellistmovie);
            this.Controls.Add(this.panel1);
            this.Name = "ListMovieAdmin";
            this.Text = "ListMovieAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowpanellistmovie;
    }
}