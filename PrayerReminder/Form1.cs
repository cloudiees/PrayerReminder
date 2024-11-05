using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PrayerReminder
{
    public partial class Form1 : Form
    {
        /*
        TODO:
        - *IMPORTANT* WHY THE HELL IS ISHA DISAPPEARING
        - Make an opacity slider/value inputter thingy
        - Make a settings thing so preferences such as always on top, lock position, and opacity are saved from session to session
        - Setup reminder and maybe some things in settings for the reminder
        - Allow user to input location (or automatically get it) and calculation method (or school) for API request
        - Do the actual reminder part
        - Add an initial setup phase thing
        - Make it look less ugly
        - Make it so whenever something that is not the main form background is clicked it is able to move when it's supposed to
        - TBD
        */
        public Point mouseLocation;
        public Pair<string, DateTime>[] prayers = new Pair<string, DateTime>[6];
        public PrayerData<Control, Control, Control, FancyPanel>[] prayerObjects = new PrayerData<Control, Control, Control, FancyPanel>[5];
        public int currPrayer = -2;

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
            prayerObjects[0] = new PrayerData<Control, Control, Control, FancyPanel>(this.Controls["fajrCheck"], this.Controls["fajrLabel"], this.Controls["fajrTime"], fajrPanel);
            prayerObjects[1] = new PrayerData<Control, Control, Control, FancyPanel>(this.Controls["dhuhrCheck"], this.Controls["dhuhrLabel"], this.Controls["dhuhrTime"], dhuhrPanel);
            prayerObjects[2] = new PrayerData<Control, Control, Control, FancyPanel>(this.Controls["asrCheck"], this.Controls["asrLabel"], this.Controls["asrTime"], asrPanel);
            prayerObjects[3] = new PrayerData<Control, Control, Control, FancyPanel>(this.Controls["maghribCheck"], this.Controls["maghribLabel"], this.Controls["maghribTime"], maghribPanel);
            prayerObjects[4] = new PrayerData<Control, Control, Control, FancyPanel>(this.Controls["ishaCheck"], this.Controls["ishaLabel"], this.Controls["ishaTime"], ishaPanel);
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
            //Trace.WriteLine(timingInfo.Sunrise.Hour);
            //Trace.WriteLine(prayers[1].Second);

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
            getCurrPrayer();
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
        public void deselectPrayer(Control check, Control name, Control time, FancyPanel panel)
        {
            panel.Visible = false;
            check.Parent = this;
            name.Parent = this;
            time.Parent = this;
            check.Location = new Point(check.Location.X + panel.Location.X, check.Location.Y + panel.Location.Y);
            name.Location = new Point(name.Location.X + panel.Location.X, name.Location.Y + panel.Location.Y);
            time.Location = new Point(time.Location.X + panel.Location.X, time.Location.Y + panel.Location.Y);
        }
        public void selectPrayer(Control check, Control name, Control time, FancyPanel panel)
        {
            panel.Visible = true;
            check.Parent = panel;
            name.Parent = panel;
            time.Parent = panel;
            check.Location = new Point(check.Location.X - panel.Location.X, check.Location.Y - panel.Location.Y);
            name.Location = new Point(name.Location.X - panel.Location.X, name.Location.Y - panel.Location.Y);
            time.Location = new Point(time.Location.X - panel.Location.X, time.Location.Y - panel.Location.Y);
        }
        // Deselect current prayer and selects the new one
        public void deselectAndSelectPrayer()
        {
            int x = currPrayer - 1;
            if (x < 0) x = 5;
            if (currPrayer != 1)
            {
                if (x > 0) x -= 1;
                deselectPrayer(prayerObjects[x].checkBox, prayerObjects[x].label, prayerObjects[x].timing, prayerObjects[x].panel);
            }
            x = currPrayer;
            if (!(currPrayer < 0) && currPrayer != 1)
            {
                if (x > 0) x -= 1;
                selectPrayer(prayerObjects[x].checkBox, prayerObjects[x].label, prayerObjects[x].timing, prayerObjects[x].panel);
            }
        }
        // Gets current prayer and stores in currPrayer
        public void getCurrPrayer()
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
            else if (DateTime.Compare(prayers[5].Second, DateTime.Now) <= 0 && DateTime.Now.Hour != 0)
            {
                currPrayer = 5;
            }
            else
            {
                currPrayer = -1;
            }
            //Trace.WriteLine(currPrayer + " " + lastPrayer);
            if (currPrayer != lastPrayer)
            {
                //Trace.WriteLine(currPrayer);
                deselectAndSelectPrayer();
            }
        }
        // Prayer reminder checker
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == 0)
            {
                loadTimings();
            }
            getCurrPrayer();
        }
    }
}
