namespace Event_Planner
{
    partial class EventView
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
            this.eventview_label = new System.Windows.Forms.Label();
            this.eventview_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eventview_label
            // 
            this.eventview_label.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventview_label.Location = new System.Drawing.Point(12, 9);
            this.eventview_label.Name = "eventview_label";
            this.eventview_label.Size = new System.Drawing.Size(822, 111);
            this.eventview_label.TabIndex = 0;
            this.eventview_label.Text = "Events for *Month*";
            this.eventview_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eventview_label.Click += new System.EventHandler(this.eventview_label_Click);
            // 
            // eventview_tb
            // 
            this.eventview_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventview_tb.Location = new System.Drawing.Point(12, 123);
            this.eventview_tb.Multiline = true;
            this.eventview_tb.Name = "eventview_tb";
            this.eventview_tb.Size = new System.Drawing.Size(822, 786);
            this.eventview_tb.TabIndex = 1;
            this.eventview_tb.Text = "*List of Events*";
            this.eventview_tb.TextChanged += new System.EventHandler(this.eventview_tb_TextChanged);
            // 
            // EventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 921);
            this.Controls.Add(this.eventview_tb);
            this.Controls.Add(this.eventview_label);
            this.Name = "EventView";
            this.Text = "EventView";
            this.Load += new System.EventHandler(this.EventView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label eventview_label;
        private TextBox eventview_tb;
    }
}