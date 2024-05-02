namespace Player
{
    partial class SplashScreenWindow
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
            this.Title = new System.Windows.Forms.Label();
            this.splashscreenImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splashSlider = new System.Windows.Forms.Panel();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splashscreenImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.AliceBlue;
            this.Title.Location = new System.Drawing.Point(26, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(110, 33);
            this.Title.TabIndex = 0;
            this.Title.Text = "GelPlayer";
            // 
            // splashscreenImage
            // 
            this.splashscreenImage.BackgroundImage = global::Player.Properties.Resources.GelPlayer_SplashImage;
            this.splashscreenImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splashscreenImage.Location = new System.Drawing.Point(32, 45);
            this.splashscreenImage.Name = "splashscreenImage";
            this.splashscreenImage.Size = new System.Drawing.Size(613, 341);
            this.splashscreenImage.TabIndex = 1;
            this.splashscreenImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(35, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Created By George Ongoro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(34, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "GelPlayer - Version 1.0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.splashSlider);
            this.panel1.Location = new System.Drawing.Point(91, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 30);
            this.panel1.TabIndex = 4;
            // 
            // splashSlider
            // 
            this.splashSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(116)))));
            this.splashSlider.Location = new System.Drawing.Point(-1, -2);
            this.splashSlider.MaximumSize = new System.Drawing.Size(500, 30);
            this.splashSlider.MinimumSize = new System.Drawing.Size(5, 30);
            this.splashSlider.Name = "splashSlider";
            this.splashSlider.Size = new System.Drawing.Size(5, 30);
            this.splashSlider.TabIndex = 5;
            // 
            // splashTimer
            // 
            this.splashTimer.Interval = 200;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // SplashScreenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(712, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splashscreenImage);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "SplashScreenWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreenWindow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SplashScreenWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splashscreenImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox splashscreenImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel splashSlider;
        private System.Windows.Forms.Timer splashTimer;
    }
}