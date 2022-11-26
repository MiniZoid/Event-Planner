namespace Event_Planner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Month = new System.Windows.Forms.Label();
            this.Sunday = new System.Windows.Forms.Label();
            this.Monday = new System.Windows.Forms.Label();
            this.Tuesday = new System.Windows.Forms.Label();
            this.Wedsenday = new System.Windows.Forms.Label();
            this.Thursday = new System.Windows.Forms.Label();
            this.Friday = new System.Windows.Forms.Label();
            this.Saturday = new System.Windows.Forms.Label();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.newEvent = new System.Windows.Forms.Button();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.weekButton = new System.Windows.Forms.Button();
            this.eventViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Month.Location = new System.Drawing.Point(12, 9);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(992, 91);
            this.Month.TabIndex = 0;
            this.Month.Text = "*month*";
            this.Month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Month.Click += new System.EventHandler(this.Month_Click);
            // 
            // Sunday
            // 
            this.Sunday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sunday.Location = new System.Drawing.Point(12, 100);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(136, 61);
            this.Sunday.TabIndex = 1;
            this.Sunday.Text = "Sun";
            this.Sunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Monday
            // 
            this.Monday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Monday.Location = new System.Drawing.Point(154, 100);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(136, 61);
            this.Monday.TabIndex = 1;
            this.Monday.Text = "Mon";
            this.Monday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tuesday
            // 
            this.Tuesday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tuesday.Location = new System.Drawing.Point(296, 100);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(136, 61);
            this.Tuesday.TabIndex = 1;
            this.Tuesday.Text = "Tues";
            this.Tuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wedsenday
            // 
            this.Wedsenday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wedsenday.Location = new System.Drawing.Point(438, 100);
            this.Wedsenday.Name = "Wedsenday";
            this.Wedsenday.Size = new System.Drawing.Size(136, 61);
            this.Wedsenday.TabIndex = 1;
            this.Wedsenday.Text = "Wed";
            this.Wedsenday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Thursday
            // 
            this.Thursday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Thursday.Location = new System.Drawing.Point(580, 100);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(136, 61);
            this.Thursday.TabIndex = 1;
            this.Thursday.Text = "Thur";
            this.Thursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Friday
            // 
            this.Friday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Friday.Location = new System.Drawing.Point(722, 100);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(136, 61);
            this.Friday.TabIndex = 1;
            this.Friday.Text = "Fri";
            this.Friday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Saturday
            // 
            this.Saturday.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Saturday.Location = new System.Drawing.Point(864, 100);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(136, 61);
            this.Saturday.TabIndex = 1;
            this.Saturday.Text = "Sat";
            this.Saturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(774, 1029);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(112, 34);
            this.prev.TabIndex = 2;
            this.prev.Text = "Previous";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(892, 1029);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(112, 34);
            this.next.TabIndex = 3;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // newEvent
            // 
            this.newEvent.Location = new System.Drawing.Point(12, 1029);
            this.newEvent.Name = "newEvent";
            this.newEvent.Size = new System.Drawing.Size(179, 34);
            this.newEvent.TabIndex = 4;
            this.newEvent.Text = "New Event";
            this.newEvent.UseVisualStyleBackColor = true;
            this.newEvent.Click += new System.EventHandler(this.newEvent_Click);
            // 
            // deleteEvent
            // 
            this.deleteEvent.Location = new System.Drawing.Point(197, 1029);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(179, 34);
            this.deleteEvent.TabIndex = 5;
            this.deleteEvent.Text = "Delete Event";
            this.deleteEvent.UseVisualStyleBackColor = true;
            this.deleteEvent.Click += new System.EventHandler(this.deleteEvent_Click);
            // 
            // weekButton
            // 
            this.weekButton.Location = new System.Drawing.Point(888, 9);
            this.weekButton.Name = "weekButton";
            this.weekButton.Size = new System.Drawing.Size(112, 34);
            this.weekButton.TabIndex = 6;
            this.weekButton.Text = "Week View";
            this.weekButton.UseVisualStyleBackColor = true;
            this.weekButton.Click += new System.EventHandler(this.weekButton_Click);
            // 
            // eventViewButton
            // 
            this.eventViewButton.Location = new System.Drawing.Point(382, 1030);
            this.eventViewButton.Margin = new System.Windows.Forms.Padding(2);
            this.eventViewButton.Name = "eventViewButton";
            this.eventViewButton.Size = new System.Drawing.Size(179, 33);
            this.eventViewButton.TabIndex = 7;
            this.eventViewButton.Text = "View Events";
            this.eventViewButton.UseVisualStyleBackColor = true;
            this.eventViewButton.Click += new System.EventHandler(this.eventViewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1016, 1075);
            this.Controls.Add(this.eventViewButton);
            this.Controls.Add(this.weekButton);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.newEvent);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wedsenday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Month);
            this.Name = "Form1";
            this.Text = "Calendar ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private Label Month;
        private Label Saturday;
        private Label Friday;
        private Label Thursday;
        private Label Wedsenday;
        private Label Tuesday;
        private Label Monday;
        private Label Sunday;
        private Button next;
        private Button prev;
        private Button newEvent;
        private Button deleteEvent;
        private Button weekButton;
        private Button eventViewButton;
    }
}