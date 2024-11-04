using KGySoft.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrayerReminder
{
    public partial class Form1 : Form
    {
        /*
        TODO:
        - Make an opacity slider/value inputter thingy
        - Make a settings thing so preferences such as always on top, lock position, and opacity are saved from session to session
        - Setup reminder and maybe some things in settings for the reminder
        - Allow user to input location (or automatically get it) and calculation method (or school) for API request
        - Do the actual reminder part
        - Add a selection square for the current prayer
        - Add an initial setup phase thing
        - Make it look less ugly
        - Make it so whenever something that is not the main form background is clicked it is able to move when it's supposed to
        - TBD
        */
        public Point mouseLocation;
        public Pair<string, DateTime>[] prayers = new Pair<string, DateTime>[6];
        public int currPrayer;
        
        // Pretty rectangle (idk I stole this from stack overflow)
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Form1()
        {
            for (int i = 0; i < prayers.Length; i++)
            {
                prayers[i] = new Pair<string, DateTime>();
            }
            InitializeComponent();
            ApiHelper.InitializeClient();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            loadTimings();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
   
        }
        // Loads in prayer timings
        public async void loadTimings()
        {
            var timingInfo = await TimingProcessor.LoadTimings();
            prayers[0].First = "Fajr";
            prayers[0].Second = timingInfo.Fajr;
            prayers[1].First = "Sunrise";
            prayers[1].Second = timingInfo.Sunrise;
            prayers[2].First = "Dhuhr";
            prayers[2].Second = timingInfo.Dhuhr;
            prayers[3].First = "Asr";
            prayers[3].Second = timingInfo.Asr;
            prayers[4].First = "Maghrib";
            prayers[4].Second = timingInfo.Maghrib;
            prayers[5].First = "Isha";
            prayers[5].Second = timingInfo.Isha;
            fajrTime.Text = timingInfo.Fajr.ToShortTimeString();
            dhuhrTime.Text = timingInfo.Dhuhr.ToShortTimeString();
            asrTime.Text = timingInfo.Asr.ToShortTimeString();
            maghribTime.Text = timingInfo.Maghrib.ToShortTimeString();
            ishaTime.Text = timingInfo.Isha.ToShortTimeString();
            initPrayers();
        }
        // Gets mouse location to use for moving the window
        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        // Moving the window
        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !lockPositionToolStripMenuItem.Checked)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        // Handles closing out the application via the right click menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Handles always on top toggle via right click menu (switch to seperate menu section to save selection)
        private void alwaysOnTopToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
        }
        // Live clock
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            liveClock.Text = DateTime.Now.ToShortTimeString();
        }
        // Initializes curr prayer
        public void initPrayers()
        {
            if (DateTime.Compare(prayers[0].Second, DateTime.Now) >= 0 && DateTime.Compare(prayers[1].Second, DateTime.Now) > 0)
            {
                currPrayer = 0;
            }
            else if (DateTime.Compare(prayers[1].Second, DateTime.Now) <= 0 && DateTime.Compare(prayers[2].Second, DateTime.Now) > 0)
            {
                currPrayer = 1;
            }
            else if (DateTime.Compare(prayers[2].Second, DateTime.Now) <= 0 && DateTime.Compare(prayers[3].Second, DateTime.Now) > 0)
            {
                currPrayer = 2;
            }
            else if (DateTime.Compare(prayers[3].Second, DateTime.Now) <= 0 && DateTime.Compare(prayers[4].Second, DateTime.Now) > 0)
            {
                currPrayer = 3;
            }
            else if (DateTime.Compare(prayers[4].Second, DateTime.Now) <= 0 && DateTime.Compare(prayers[5].Second, DateTime.Now) > 0)
            {
                currPrayer = 4;
            }
            else
            {
                currPrayer = 5;
            }
        }
        // Prayer reminder checker
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == 1)
            {
                loadTimings();
            }
            
        }
    }
}
