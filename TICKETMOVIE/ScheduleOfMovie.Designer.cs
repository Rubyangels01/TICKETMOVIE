
namespace TICKETMOVIE
{
    partial class ScheduleOfMovie
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
            this.namemovie = new System.Windows.Forms.Label();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.add_schedule = new System.Windows.Forms.PictureBox();
            this.icon_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_schedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_back)).BeginInit();
            this.SuspendLayout();
            // 
            // namemovie
            // 
            this.namemovie.AutoSize = true;
            this.namemovie.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namemovie.Location = new System.Drawing.Point(227, 41);
            this.namemovie.Name = "namemovie";
            this.namemovie.Size = new System.Drawing.Size(286, 27);
            this.namemovie.TabIndex = 0;
            this.namemovie.Text = "LẬT MẶT 7 : MỘT ĐIÈU ƯỚC";
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateNavigator1.Location = new System.Drawing.Point(757, 0);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Single;
            this.dateNavigator1.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.dateNavigator1.Size = new System.Drawing.Size(401, 500);
            this.dateNavigator1.TabIndex = 4;
            this.dateNavigator1.SelectionChanged += new System.EventHandler(this.dateNavigator1_SelectionChanged);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSchedule.Location = new System.Drawing.Point(0, 158);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(757, 342);
            this.dgvSchedule.TabIndex = 5;
            this.dgvSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellClick);
            // 
            // add_schedule
            // 
            this.add_schedule.Image = global::TICKETMOVIE.Properties.Resources.add2;
            this.add_schedule.Location = new System.Drawing.Point(654, 102);
            this.add_schedule.Name = "add_schedule";
            this.add_schedule.Size = new System.Drawing.Size(86, 40);
            this.add_schedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_schedule.TabIndex = 7;
            this.add_schedule.TabStop = false;
            this.add_schedule.Click += new System.EventHandler(this.add_schedule_Click);
            // 
            // icon_back
            // 
            this.icon_back.Image = global::TICKETMOVIE.Properties.Resources.icon_back;
            this.icon_back.Location = new System.Drawing.Point(27, 41);
            this.icon_back.Name = "icon_back";
            this.icon_back.Size = new System.Drawing.Size(29, 27);
            this.icon_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_back.TabIndex = 6;
            this.icon_back.TabStop = false;
            this.icon_back.Click += new System.EventHandler(this.icon_back_Click);
            // 
            // ScheduleOfMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 500);
            this.Controls.Add(this.add_schedule);
            this.Controls.Add(this.icon_back);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.dateNavigator1);
            this.Controls.Add(this.namemovie);
            this.Name = "ScheduleOfMovie";
            this.Text = "ScheduleOfMovie";
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_schedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namemovie;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.PictureBox icon_back;
        private System.Windows.Forms.PictureBox add_schedule;
    }
}