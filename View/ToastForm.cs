using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace View
{
    public partial class ToastForm : Form
    {
        int toastX, toastY;
        Timer autoCloseTimer = new Timer();

        public ToastForm(string type, string message)
        {
            InitializeComponent();


            labelType.Text = type;
            labelMessage.Text = message;

            switch (type)
            {
                case "SUCCESS":
                    toastBorder.BackColor = Color.FromArgb(57, 155, 53);
                    pictureBoxIcon.Image = Properties.Resources._22_226960_download_success_png_image_green_like_button_png;
                    break;
                case "ERROR":
                    toastBorder.BackColor = Color.FromArgb(227, 50, 45);
                    pictureBoxIcon.Image = Properties.Resources.Error;
                    break;
                case "INFO":
                    toastBorder.BackColor = Color.FromArgb(18, 136, 191);
                    pictureBoxIcon.Image = Properties.Resources.infor;
                    break;
                case "WARNING":
                    toastBorder.BackColor = Color.FromArgb(245, 171, 35);
                    pictureBoxIcon.Image = Properties.Resources.Warning;
                    break;
            }

            autoCloseTimer.Interval = 10000; // 15.000 milliseconds = 15 giây
            autoCloseTimer.Tick += AutoCloseTimer_Tick;
        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            position();
            autoCloseTimer.Start();
        }
        private void position()
        {

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = screenWidth - this.Width - 5;
            toastY = screenHeight - this.Height - 855;

            this.Location = new Point(toastX, toastY);
        }
        private void AutoCloseTimer_Tick(object sender, EventArgs e)
        {
            // Dừng Timer và đóng form
            autoCloseTimer.Stop();
            this.Close();
        }
    }
}
