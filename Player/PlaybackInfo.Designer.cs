namespace Player
{
    partial class PlaybackInfo
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
            this.aboutPlayback1 = new Player.AboutPlayback();
            this.SuspendLayout();
            // 
            // aboutPlayback1
            // 
            this.aboutPlayback1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(210)))));
            this.aboutPlayback1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutPlayback1.ForeColor = System.Drawing.Color.Black;
            this.aboutPlayback1.Location = new System.Drawing.Point(0, 0);
            this.aboutPlayback1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aboutPlayback1.Name = "aboutPlayback1";
            this.aboutPlayback1.Size = new System.Drawing.Size(346, 448);
            this.aboutPlayback1.TabIndex = 0;
            this.aboutPlayback1.Load += new System.EventHandler(this.aboutPlayback1_Load);
            // 
            // PlaybackInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 448);
            this.Controls.Add(this.aboutPlayback1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaybackInfo";
            this.Text = "PlaybackInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private AboutPlayback aboutPlayback1;
    }
}