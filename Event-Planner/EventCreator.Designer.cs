namespace Event_Planner
{
    partial class EventCreator
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
            if(disposing && (components != null))
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
            this.label1 = new System.Windows.Forms.Label();
            this.eventName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.dtForm = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(209, 106);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(180, 31);
            this.eventName.TabIndex = 1;
            this.eventName.TextChanged += new System.EventHandler(this.formField1_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(388, 450);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(112, 34);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Close
            // 
            this.Close.AllowDrop = true;
            this.Close.Location = new System.Drawing.Point(12, 459);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(112, 34);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // dtForm
            // 
            this.dtForm.Location = new System.Drawing.Point(96, 220);
            this.dtForm.Name = "dtForm";
            this.dtForm.Size = new System.Drawing.Size(293, 31);
            this.dtForm.TabIndex = 5;
            this.dtForm.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(96, 270);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(293, 31);
            this.TimePicker.TabIndex = 6;
            this.TimePicker.Value = new System.DateTime(2022, 11, 3, 18, 35, 0, 0);
            // 
            // EventCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 496);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.dtForm);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.label1);
            this.Name = "EventCreator";
            this.Text = "EventCreator";
            this.Load += new System.EventHandler(this.EventCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox eventName;
        private Button Save;
        private Button Close;
        private DateTimePicker dtForm;
        private DateTimePicker TimePicker;
    }
}