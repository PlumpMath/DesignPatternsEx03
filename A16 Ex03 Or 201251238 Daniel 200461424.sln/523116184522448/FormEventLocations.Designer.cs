namespace _523116184522448
{
    public partial class EventLocationsForm
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
            this.labelEventImages = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonEventsNotReplied = new System.Windows.Forms.RadioButton();
            this.radioButtonEventsCreated = new System.Windows.Forms.RadioButton();
            this.radioButtonAllEvents = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEventImages
            // 
            this.labelEventImages.AutoSize = true;
            this.labelEventImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEventImages.Location = new System.Drawing.Point(12, 118);
            this.labelEventImages.Name = "labelEventImages";
            this.labelEventImages.Size = new System.Drawing.Size(232, 39);
            this.labelEventImages.TabIndex = 6;
            this.labelEventImages.Text = "Choose an event to see its location on the map.\nUse right mouse click to drag map" +
    ",\nMousewheel to zoom";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 160);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(266, 160);
            this.listBoxEvents.TabIndex = 5;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFetchEvents.Location = new System.Drawing.Point(4, 77);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(136, 23);
            this.buttonFetchEvents.TabIndex = 4;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonEventsNotReplied);
            this.panel1.Controls.Add(this.radioButtonEventsCreated);
            this.panel1.Controls.Add(this.radioButtonAllEvents);
            this.panel1.Controls.Add(this.buttonFetchEvents);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 103);
            this.panel1.TabIndex = 7;
            // 
            // radioButtonEventsNotReplied
            // 
            this.radioButtonEventsNotReplied.AutoSize = true;
            this.radioButtonEventsNotReplied.Location = new System.Drawing.Point(4, 52);
            this.radioButtonEventsNotReplied.Name = "radioButtonEventsNotReplied";
            this.radioButtonEventsNotReplied.Size = new System.Drawing.Size(136, 17);
            this.radioButtonEventsNotReplied.TabIndex = 7;
            this.radioButtonEventsNotReplied.TabStop = true;
            this.radioButtonEventsNotReplied.Text = "Events Not Yet Replied";
            this.radioButtonEventsNotReplied.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.radioButtonEventsNotReplied.UseVisualStyleBackColor = true;
            this.radioButtonEventsNotReplied.CheckedChanged += new System.EventHandler(this.radioButtonEventsNotReplied_CheckedChanged);
            // 
            // radioButtonEventsCreated
            // 
            this.radioButtonEventsCreated.AutoSize = true;
            this.radioButtonEventsCreated.Location = new System.Drawing.Point(4, 28);
            this.radioButtonEventsCreated.Name = "radioButtonEventsCreated";
            this.radioButtonEventsCreated.Size = new System.Drawing.Size(98, 17);
            this.radioButtonEventsCreated.TabIndex = 6;
            this.radioButtonEventsCreated.TabStop = true;
            this.radioButtonEventsCreated.Text = "Events Created";
            this.radioButtonEventsCreated.UseVisualStyleBackColor = true;
            this.radioButtonEventsCreated.CheckedChanged += new System.EventHandler(this.radioButtonEventsCreated_CheckedChanged);
            // 
            // radioButtonAllEvents
            // 
            this.radioButtonAllEvents.AutoSize = true;
            this.radioButtonAllEvents.Location = new System.Drawing.Point(4, 4);
            this.radioButtonAllEvents.Name = "radioButtonAllEvents";
            this.radioButtonAllEvents.Size = new System.Drawing.Size(72, 17);
            this.radioButtonAllEvents.TabIndex = 5;
            this.radioButtonAllEvents.TabStop = true;
            this.radioButtonAllEvents.Text = "All Events";
            this.radioButtonAllEvents.UseVisualStyleBackColor = true;
            this.radioButtonAllEvents.Checked = true;
            this.radioButtonAllEvents.CheckedChanged += new System.EventHandler(this.radioButtonAllEvents_CheckedChanged);
            // 
            // EventLocationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEventImages);
            this.Controls.Add(this.listBoxEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EventLocationsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEventImages;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.UserControl mapControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonEventsCreated;
        private System.Windows.Forms.RadioButton radioButtonAllEvents;
        private System.Windows.Forms.RadioButton radioButtonEventsNotReplied;
    }
}