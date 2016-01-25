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
            this.mapControl = m_Map.MapControl;

            this.SuspendLayout();
            // 
            // labelEventImages
            // 
            this.labelEventImages.AutoSize = true;
            this.labelEventImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEventImages.Location = new System.Drawing.Point(27, 38);
            this.labelEventImages.Name = "labelEventImages";
            this.labelEventImages.Size = new System.Drawing.Size(232, 39);
            this.labelEventImages.TabIndex = 6;
            this.labelEventImages.Text = "Choose an event to see its location on the map.\nUse right mouse click to drag map" +
    ",\nMousewheel to zoom";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 82);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(266, 238);
            this.listBoxEvents.TabIndex = 5;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFetchEvents.Location = new System.Drawing.Point(57, 12);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(163, 23);
            this.buttonFetchEvents.TabIndex = 4;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // MapControl
            // 
            this.m_Map.Initialize();
            // 
            // EventLocationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 326);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.labelEventImages);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonFetchEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EventLocationsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEventImages;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.UserControl mapControl;
    }
}