﻿namespace _523116184522448
{
    public partial class FormEventImages
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventImages));
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listView = new System.Windows.Forms.ListView();
            this.imageListEventImages = new System.Windows.Forms.ImageList(this.components);
            this.labelEventImages = new System.Windows.Forms.Label();
            this.labelPhotosList = new System.Windows.Forms.Label();
            this.textBoxCommentPhoto = new System.Windows.Forms.TextBox();
            this.buttonPostComment = new System.Windows.Forms.Button();
            this.labelCommentPhoto = new System.Windows.Forms.Label();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.labelListOfComments = new System.Windows.Forms.Label();
            this.buttonLikePhoto = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.labelFilterOptions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFetchEvents
            // 
            resources.ApplyResources(this.buttonFetchEvents, "buttonFetchEvents");
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxEvents, "listBoxEvents");
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // listView
            // 
            this.listView.LargeImageList = this.imageListEventImages;
            resources.ApplyResources(this.listView, "listView");
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // imageListEventImages
            // 
            this.imageListEventImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageListEventImages, "imageListEventImages");
            this.imageListEventImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelEventImages
            // 
            resources.ApplyResources(this.labelEventImages, "labelEventImages");
            this.labelEventImages.Name = "labelEventImages";
            // 
            // labelPhotosList
            // 
            resources.ApplyResources(this.labelPhotosList, "labelPhotosList");
            this.labelPhotosList.Name = "labelPhotosList";
            // 
            // textBoxCommentPhoto
            // 
            resources.ApplyResources(this.textBoxCommentPhoto, "textBoxCommentPhoto");
            this.textBoxCommentPhoto.Name = "textBoxCommentPhoto";
            // 
            // buttonPostComment
            // 
            resources.ApplyResources(this.buttonPostComment, "buttonPostComment");
            this.buttonPostComment.Name = "buttonPostComment";
            this.buttonPostComment.UseVisualStyleBackColor = true;
            this.buttonPostComment.Click += new System.EventHandler(this.buttonPostComment_Click);
            // 
            // labelCommentPhoto
            // 
            resources.ApplyResources(this.labelCommentPhoto, "labelCommentPhoto");
            this.labelCommentPhoto.Name = "labelCommentPhoto";
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxComments, "listBoxComments");
            this.listBoxComments.Name = "listBoxComments";
            // 
            // labelListOfComments
            // 
            resources.ApplyResources(this.labelListOfComments, "labelListOfComments");
            this.labelListOfComments.Name = "labelListOfComments";
            // 
            // buttonLikePhoto
            // 
            resources.ApplyResources(this.buttonLikePhoto, "buttonLikePhoto");
            this.buttonLikePhoto.Name = "buttonLikePhoto";
            this.buttonLikePhoto.UseVisualStyleBackColor = true;
            this.buttonLikePhoto.Click += new System.EventHandler(this.buttonLikePhoto_Click);
            // 
            // labelFilter
            // 
            resources.ApplyResources(this.labelFilter, "labelFilter");
            this.labelFilter.Name = "labelFilter";
            // 
            // textBoxFilter
            // 
            resources.ApplyResources(this.textBoxFilter, "textBoxFilter");
            this.textBoxFilter.Name = "textBoxFilter";
            // 
            // labelFilterOptions
            // 
            resources.ApplyResources(this.labelFilterOptions, "labelFilterOptions");
            this.labelFilterOptions.Name = "labelFilterOptions";
            // 
            // EventImagesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFilterOptions);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.labelListOfComments);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.buttonLikePhoto);
            this.Controls.Add(this.labelCommentPhoto);
            this.Controls.Add(this.buttonPostComment);
            this.Controls.Add(this.textBoxCommentPhoto);
            this.Controls.Add(this.labelPhotosList);
            this.Controls.Add(this.labelEventImages);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonFetchEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EventImagesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageListEventImages;
        private System.Windows.Forms.Label labelEventImages;
        private System.Windows.Forms.Label labelPhotosList;
        private System.Windows.Forms.TextBox textBoxCommentPhoto;
        private System.Windows.Forms.Button buttonPostComment;
        private System.Windows.Forms.Label labelCommentPhoto;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label labelListOfComments;
        private System.Windows.Forms.Button buttonLikePhoto;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label labelFilterOptions;
    }
}