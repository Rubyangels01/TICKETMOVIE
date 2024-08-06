
namespace TICKETMOVIE.Ui.Admin
{
    partial class TheaterForm
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
            this.panel_tool = new System.Windows.Forms.Panel();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.flowpaneltheater = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_tool
            // 
            this.panel_tool.Controls.Add(this.searchControl1);
            this.panel_tool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tool.Location = new System.Drawing.Point(0, 0);
            this.panel_tool.Name = "panel_tool";
            this.panel_tool.Size = new System.Drawing.Size(1084, 81);
            this.panel_tool.TabIndex = 0;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(88, 28);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(4);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(348, 30);
            this.searchControl1.TabIndex = 0;
            // 
            // flowpaneltheater
            // 
            this.flowpaneltheater.BackColor = System.Drawing.Color.White;
            this.flowpaneltheater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpaneltheater.Location = new System.Drawing.Point(0, 81);
            this.flowpaneltheater.Name = "flowpaneltheater";
            this.flowpaneltheater.Size = new System.Drawing.Size(1084, 438);
            this.flowpaneltheater.TabIndex = 1;
            // 
            // TheaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 519);
            this.Controls.Add(this.flowpaneltheater);
            this.Controls.Add(this.panel_tool);
            this.Name = "TheaterForm";
            this.Text = "TheaterForm";
            this.panel_tool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_tool;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.FlowLayoutPanel flowpaneltheater;
    }
}