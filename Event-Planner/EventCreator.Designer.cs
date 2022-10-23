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
            this.formField1 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.dayOfEvent = new System.Windows.Forms.Label();
            this.formField2 = new System.Windows.Forms.TextBox();
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
            // formField1
            // 
            this.formField1.Location = new System.Drawing.Point(209, 106);
            this.formField1.Name = "formField1";
            this.formField1.Size = new System.Drawing.Size(150, 31);
            this.formField1.TabIndex = 1;
            this.formField1.TextChanged += new System.EventHandler(this.formField1_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(388, 350);
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
            this.Close.Location = new System.Drawing.Point(12, 350);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(112, 34);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // dayOfEvent
            // 
            this.dayOfEvent.AutoSize = true;
            this.dayOfEvent.Location = new System.Drawing.Point(121, 186);
            this.dayOfEvent.Name = "dayOfEvent";
            this.dayOfEvent.Size = new System.Drawing.Size(43, 25);
            this.dayOfEvent.TabIndex = 0;
            this.dayOfEvent.Text = "Day";
            this.dayOfEvent.Click += new System.EventHandler(this.label1_Click);
            // 
            // formField2
            // 
            this.formField2.Location = new System.Drawing.Point(209, 180);
            this.formField2.Name = "formField2";
            this.formField2.Size = new System.Drawing.Size(150, 31);
            this.formField2.TabIndex = 1;
            this.formField2.TextChanged += new System.EventHandler(this.formField1_TextChanged);
            // 
            // EventCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 396);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.formField2);
            this.Controls.Add(this.dayOfEvent);
            this.Controls.Add(this.formField1);
            this.Controls.Add(this.label1);
            this.Name = "EventCreator";
            this.Text = "EventCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox formField1;
        private Button Save;
        private Button Close;
        private Label dayOfEvent;
        private TextBox formField2;
    }
}