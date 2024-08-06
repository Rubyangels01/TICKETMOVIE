
namespace TICKETMOVIE
{
    partial class ListMoviePage
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
            this.panel_displaylistmovie = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_displaylistmovie
            // 
            this.panel_displaylistmovie.AutoScroll = true;
            this.panel_displaylistmovie.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_displaylistmovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_displaylistmovie.Location = new System.Drawing.Point(0, 0);
            this.panel_displaylistmovie.Name = "panel_displaylistmovie";
            this.panel_displaylistmovie.Size = new System.Drawing.Size(1241, 558);
            this.panel_displaylistmovie.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_status);
            this.panel1.Controls.Add(this.searchControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 67);
            this.panel1.TabIndex = 1;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(112, 18);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(378, 34);
            this.searchControl1.TabIndex = 0;
            this.searchControl1.SelectedIndexChanged += new System.EventHandler(this.searchControl1_SelectedIndexChanged);
            this.searchControl1.Click += new System.EventHandler(this.searchControl1_Click);
            // 
            // cb_status
            // 
            this.cb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(895, 19);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(278, 33);
            this.cb_status.TabIndex = 1;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // ListMoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_displaylistmovie);
            this.Name = "ListMoviePage";
            this.Text = "ListMoviePage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel_displaylistmovie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_status;
        private DevExpress.XtraEditors.SearchControl searchControl1;
    }
}