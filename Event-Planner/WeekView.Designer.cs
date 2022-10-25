namespace Event_Planner
{
    partial class Weekform
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
            this.Week = new System.Windows.Forms.Label();
            this.Saturday = new System.Windows.Forms.Label();
            this.Friday = new System.Windows.Forms.Label();
            this.Thursday = new System.Windows.Forms.Label();
            this.Wedsenday = new System.Windows.Forms.Label();
            this.Tuesday = new System.Windows.Forms.Label();
            this.Monday = new System.Windows.Forms.Label();
            this.Sunday = new System.Windows.Forms.Label();
            this.nextweek = new System.Windows.Forms.Button();
            this.prevweek = new System.Windows.Forms.Button();
            this.newEventWeek = new System.Windows.Forms.Button();
            this.deleteEventWeek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Week
            // 
            this.Week.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Week.Location = new System.Drawing.Point(12, 9);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(992, 91);
            this.Week.TabIndex = 1;
            this.Week.Text = "*Week*";
            this.Week.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Saturday
            // 
            this.Saturday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Saturday.Location = new System.Drawing.Point(863, 100);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(136, 61);
            this.Saturday.TabIndex = 2;
            this.Saturday.Text = "Sat";
            this.Saturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Friday
            // 
            this.Friday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Friday.Location = new System.Drawing.Point(721, 100);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(136, 61);
            this.Friday.TabIndex = 3;
            this.Friday.Text = "Fri";
            this.Friday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Thursday
            // 
            this.Thursday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Thursday.Location = new System.Drawing.Point(579, 100);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(136, 61);
            this.Thursday.TabIndex = 4;
            this.Thursday.Text = "Thur";
            this.Thursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wedsenday
            // 
            this.Wedsenday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wedsenday.Location = new System.Drawing.Point(437, 100);
            this.Wedsenday.Name = "Wedsenday";
            this.Wedsenday.Size = new System.Drawing.Size(136, 61);
            this.Wedsenday.TabIndex = 5;
            this.Wedsenday.Text = "Wed";
            this.Wedsenday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tuesday
            // 
            this.Tuesday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tuesday.Location = new System.Drawing.Point(295, 100);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(136, 61);
            this.Tuesday.TabIndex = 6;
            this.Tuesday.Text = "Tues";
            this.Tuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Monday
            // 
            this.Monday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Monday.Location = new System.Drawing.Point(153, 100);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(136, 61);
            this.Monday.TabIndex = 7;
            this.Monday.Text = "Mon";
            this.Monday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sunday
            // 
            this.Sunday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sunday.Location = new System.Drawing.Point(11, 100);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(136, 61);
            this.Sunday.TabIndex = 8;
            this.Sunday.Text = "Sun";
            this.Sunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextweek
            // 
            this.nextweek.Location = new System.Drawing.Point(887, 1029);
            this.nextweek.Name = "nextweek";
            this.nextweek.Size = new System.Drawing.Size(112, 34);
            this.nextweek.TabIndex = 9;
            this.nextweek.Text = "Next";
            this.nextweek.UseVisualStyleBackColor = true;
            // 
            // prevweek
            // 
            this.prevweek.Location = new System.Drawing.Point(769, 1029);
            this.prevweek.Name = "prevweek";
            this.prevweek.Size = new System.Drawing.Size(112, 34);
            this.prevweek.TabIndex = 10;
            this.prevweek.Text = "Previous";
            this.prevweek.UseVisualStyleBackColor = true;
            // 
            // newEventWeek
            // 
            this.newEventWeek.Location = new System.Drawing.Point(12, 1029);
            this.newEventWeek.Name = "newEventWeek";
            this.newEventWeek.Size = new System.Drawing.Size(179, 34);
            this.newEventWeek.TabIndex = 11;
            this.newEventWeek.Text = "New Event";
            this.newEventWeek.UseVisualStyleBackColor = true;
            this.newEventWeek.Click += new System.EventHandler(this.newEventWeek_Click);
            // 
            // deleteEventWeek
            // 
            this.deleteEventWeek.Location = new System.Drawing.Point(197, 1029);
            this.deleteEventWeek.Name = "deleteEventWeek";
            this.deleteEventWeek.Size = new System.Drawing.Size(179, 34);
            this.deleteEventWeek.TabIndex = 12;
            this.deleteEventWeek.Text = "Delete Event";
            this.deleteEventWeek.UseVisualStyleBackColor = true;
            // 
            // Weekform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 1075);
            this.Controls.Add(this.deleteEventWeek);
            this.Controls.Add(this.newEventWeek);
            this.Controls.Add(this.prevweek);
            this.Controls.Add(this.nextweek);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Week);
            this.Controls.Add(this.Wedsenday);
            this.Name = "Weekform";
            this.Text = "Week View";
            this.ResumeLayout(false);

        }

        #endregion

        private Label Week;
        private Label Saturday;
        private Label Friday;
        private Label Thursday;
        private Label Wedsenday;
        private Label Tuesday;
        private Label Monday;
        private Label Sunday;
        private Button nextweek;
        private Button prevweek;
        private Button newEventWeek;
        private Button deleteEventWeek;
    }
}