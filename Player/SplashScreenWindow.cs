using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class SplashScreenWindow : Form
    {
        public SplashScreenWindow()
        {
            InitializeComponent();
        }

        private void SplashScreenWindow_Load(object sender, EventArgs e)
        {
            splashTimer.Start();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            while (splashSlider.Width < splashSlider.MaximumSize.Width)
            {
                splashSlider.Width = splashSlider.Width + 5;

            }

            if(splashSlider.Width >= splashSlider.MaximumSize.Width)
            {
                splashTimer.Stop();
                PlayerWindow playerWindow = new PlayerWindow();
                playerWindow.Show();
                SplashScreenWindow splashscreen = new SplashScreenWindow();
                splashscreen.Hide();
            }
            


        }


    }
}
