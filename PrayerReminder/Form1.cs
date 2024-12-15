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
        - Make a settings thing so preferences such as always on top, lock position, and opacity are saved from session to session
        - Setup reminder and maybe some things in settings for the reminder
        - Allow user to input location (or automatically get it) and calculation method (or school) for API request
        - Do the actual reminder part
        - Add an initial setup phase thing
        - Make it look less ugly
        */
        private double currOpacity;
        private ToolStripMenuItem currOpacityObj;
        private Point mouseLocation;
        private bool mouseDown;
        private Pair<string, DateTime>[] prayers = new Pair<string, DateTime>[6];
        private int currPrayer = -2;
        private PrayerData<Control, Control, Control>[] prayerObjects = new PrayerData<Control, Control, Control>[5];

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
            prayerObjects[0] = new PrayerData<Control, Control, Control>(this.Controls["fajrCheck"], this.Controls["fajrLabel"], this.Controls["fajrTime"]);
            prayerObjects[1] = new PrayerData<Control, Control, Control>(this.Controls["dhuhrCheck"], this.Controls["dhuhrLabel"], this.Controls["dhuhrTime"]);
            prayerObjects[2] = new PrayerData<Control, Control, Control>(this.Controls["asrCheck"], this.Controls["asrLabel"], this.Controls["asrTime"]);
            prayerObjects[3] = new PrayerData<Control, Control, Control>(this.Controls["maghribCheck"], this.Controls["maghribLabel"], this.Controls["maghribTime"]);
            prayerObjects[4] = new PrayerData<Control, Control, Control>(this.Controls["ishaCheck"], this.Controls["ishaLabel"], this.Controls["ishaTime"]);
            loadTimings();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            currOpacity = 1;
            this.Opacity = currOpacity;
            currOpacityObj = this.opacity100;
            currOpacityObj.Checked = true;
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
        // Handling moving the window
        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseLocation = e.Location;
        }
        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - mouseLocation.X) + e.X, (this.Location.Y - mouseLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void mouse_Up(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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
        // Deselects current prayer
        public void deselectPrayer(Control check, Control name, Control time)
        {
            if (check.Parent != this)
            {
                check.Parent = this;
                name.Parent = this;
                time.Parent = this;
                check.Location = new Point(check.Location.X + selectedPanel.Location.X, check.Location.Y + selectedPanel.Location.Y);
                name.Location = new Point(name.Location.X + selectedPanel.Location.X, name.Location.Y + selectedPanel.Location.Y);
                time.Location = new Point(time.Location.X + selectedPanel.Location.X, time.Location.Y + selectedPanel.Location.Y);
            }
        }
        // Selects current prayer
        public void selectPrayer(Control check, Control name, Control time, Point newLoc)
        {
            selectedPanel.Location = newLoc;
            selectedPanel.Visible = true;
            check.Parent = selectedPanel;
            name.Parent = selectedPanel;
            time.Parent = selectedPanel;
            check.Location = new Point(10, 10);
            name.Location = new Point(30, 10);
            time.Location = new Point(95, 10);

        }
        // Deselect current prayer and selects the new one
        public void deselectAndSelectPrayer()
        {
            int x = currPrayer - 1;
            if (x < 0) x = 5;
            if (currPrayer != 1)
            {
                if (x > 0) x -= 1;
                deselectPrayer(prayerObjects[x].checkBox, prayerObjects[x].label, prayerObjects[x].timing);
            }
            x = currPrayer;
            if (!(currPrayer < 0) && currPrayer != 1)
            {
                if (x > 0) x -= 1;
                Point newLoc = new Point(10, (45 * x) + 55);
                selectPrayer(prayerObjects[x].checkBox, prayerObjects[x].label, prayerObjects[x].timing, newLoc);
            }
            if (currPrayer == -1)
            {
                selectedPanel.Visible = false;
            }
        }
        // Initializes curr prayer
        public void initPrayers()
        {
            int lastPrayer = currPrayer;
            if (DateTime.Compare(prayers[0].Second, DateTime.Now) <= 0 && DateTime.Compare(prayers[1].Second, DateTime.Now) > 0)
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
            else if ((DateTime.Compare(prayers[5].Second, DateTime.Now) <= 0 && DateTime.Now.Hour != 0))
            {
                currPrayer = 5;
            }
            else
            {
                currPrayer = -1;
            }
            if (currPrayer != lastPrayer)
            {
                deselectAndSelectPrayer();
            }
        }
        // Periodically checks if it's a new prayer time
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == 0)
            {
                loadTimings();
            }
            initPrayers();
        }
        // Handler for changing opacity via tool strip menu
        private void Opacity_Clicked(object sender, EventArgs e)
        {
            currOpacityObj.Checked = false;
            currOpacityObj = (ToolStripMenuItem)sender;
            currOpacityObj.Checked = true;
            currOpacity = (double)currOpacityObj.Tag;
            this.Opacity = currOpacity;
        }
    }
}
