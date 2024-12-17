namespace picplay
{
    partial class Form1
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
            this.ListBoxImages = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxImages
            // 
            this.ListBoxImages.AllowDrop = true;
            this.ListBoxImages.FormattingEnabled = true;
            this.ListBoxImages.ItemHeight = 16;
            this.ListBoxImages.Location = new System.Drawing.Point(12, 12);
            this.ListBoxImages.Name = "ListBoxImages";
            this.ListBoxImages.Size = new System.Drawing.Size(67, 100);
            this.ListBoxImages.TabIndex = 0;
            this.ListBoxImages.SelectedIndexChanged += new System.EventHandler(this.ListBoxImages_SelectedIndexChanged);
            this.ListBoxImages.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBoxImages_DragDrop);
            this.ListBoxImages.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBoxImages_DragEnter);
            this.ListBoxImages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxImages_KeyDown);
            this.ListBoxImages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxImages_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ListBoxImages);
            this.Name = "Form1";
            this.Text = "PicPlay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxImages;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

