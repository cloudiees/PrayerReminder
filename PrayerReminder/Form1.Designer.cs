using System.Drawing;
using System.Windows.Forms;

namespace PrayerReminder
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dhuhrLabel = new System.Windows.Forms.Label();
            this.asrLabel = new System.Windows.Forms.Label();
            this.maghribLabel = new System.Windows.Forms.Label();
            this.ishaLabel = new System.Windows.Forms.Label();
            this.dhuhrTime = new System.Windows.Forms.Label();
            this.maghribTime = new System.Windows.Forms.Label();
            this.asrTime = new System.Windows.Forms.Label();
            this.ishaTime = new System.Windows.Forms.Label();
            this.dhuhrCheck = new System.Windows.Forms.CheckBox();
            this.asrCheck = new System.Windows.Forms.CheckBox();
            this.maghribCheck = new System.Windows.Forms.CheckBox();
            this.ishaCheck = new System.Windows.Forms.CheckBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.liveClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.fajrTime = new System.Windows.Forms.Label();
            this.fajrLabel = new System.Windows.Forms.Label();
            this.fajrCheck = new System.Windows.Forms.CheckBox();
            this.fajrPanel = new PrayerReminder.FancyPanel();
            this.dhuhrPanel = new PrayerReminder.FancyPanel();
            this.asrPanel = new PrayerReminder.FancyPanel();
            this.maghribPanel = new PrayerReminder.FancyPanel();
            this.ishaPanel = new PrayerReminder.FancyPanel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockPositionToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // lockPositionToolStripMenuItem
            // 
            this.lockPositionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.lockPositionToolStripMenuItem.CheckOnClick = true;
            this.lockPositionToolStripMenuItem.Name = "lockPositionToolStripMenuItem";
            this.lockPositionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lockPositionToolStripMenuItem.Text = "Lock Position";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_CheckStateChanged);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dhuhrLabel
            // 
            this.dhuhrLabel.AutoSize = true;
            this.dhuhrLabel.BackColor = System.Drawing.Color.Transparent;
            this.dhuhrLabel.Font = new System.Drawing.Font("Aqua Grotesque", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhuhrLabel.Location = new System.Drawing.Point(40, 110);
            this.dhuhrLabel.Name = "dhuhrLabel";
            this.dhuhrLabel.Size = new System.Drawing.Size(43, 16);
            this.dhuhrLabel.TabIndex = 7;
            this.dhuhrLabel.Text = "Dhuhr";
            // 
            // asrLabel
            // 
            this.asrLabel.AutoSize = true;
            this.asrLabel.BackColor = System.Drawing.Color.Transparent;
            this.asrLabel.Font = new System.Drawing.Font("Aqua Grotesque", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asrLabel.Location = new System.Drawing.Point(40, 155);
            this.asrLabel.Name = "asrLabel";
            this.asrLabel.Size = new System.Drawing.Size(28, 16);
            this.asrLabel.TabIndex = 8;
            this.asrLabel.Text = "Asr";
            // 
            // maghribLabel
            // 
            this.maghribLabel.AutoSize = true;
            this.maghribLabel.BackColor = System.Drawing.Color.Transparent;
            this.maghribLabel.Font = new System.Drawing.Font("Aqua Grotesque", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maghribLabel.Location = new System.Drawing.Point(40, 200);
            this.maghribLabel.Name = "maghribLabel";
            this.maghribLabel.Size = new System.Drawing.Size(60, 16);
            this.maghribLabel.TabIndex = 9;
            this.maghribLabel.Text = "Maghrib";
            // 
            // ishaLabel
            // 
            this.ishaLabel.AutoSize = true;
            this.ishaLabel.BackColor = System.Drawing.Color.Transparent;
            this.ishaLabel.Font = new System.Drawing.Font("Aqua Grotesque", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ishaLabel.Location = new System.Drawing.Point(40, 245);
            this.ishaLabel.Name = "ishaLabel";
            this.ishaLabel.Size = new System.Drawing.Size(31, 16);
            this.ishaLabel.TabIndex = 10;
            this.ishaLabel.Text = "Isha";
            // 
            // dhuhrTime
            // 
            this.dhuhrTime.AutoSize = true;
            this.dhuhrTime.BackColor = System.Drawing.Color.Transparent;
            this.dhuhrTime.Font = new System.Drawing.Font("Aqua Grotesque", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhuhrTime.Location = new System.Drawing.Point(105, 110);
            this.dhuhrTime.Name = "dhuhrTime";
            this.dhuhrTime.Size = new System.Drawing.Size(0, 16);
            this.dhuhrTime.TabIndex = 12;
            // 
            // maghribTime
            // 
            this.maghribTime.AutoSize = true;
            this.maghribTime.BackColor = System.Drawing.Color.Transparent;
            this.maghribTime.Font = new System.Drawing.Font("Aqua Grotesque", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maghribTime.Location = new System.Drawing.Point(105, 200);
            this.maghribTime.Name = "maghribTime";
            this.maghribTime.Size = new System.Drawing.Size(0, 16);
            this.maghribTime.TabIndex = 14;
            // 
            // asrTime
            // 
            this.asrTime.AutoSize = true;
            this.asrTime.BackColor = System.Drawing.Color.Transparent;
            this.asrTime.Font = new System.Drawing.Font("Aqua Grotesque", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asrTime.Location = new System.Drawing.Point(105, 155);
            this.asrTime.Name = "asrTime";
            this.asrTime.Size = new System.Drawing.Size(0, 16);
            this.asrTime.TabIndex = 13;
            // 
            // ishaTime
            // 
            this.ishaTime.AutoSize = true;
            this.ishaTime.BackColor = System.Drawing.Color.Transparent;
            this.ishaTime.Font = new System.Drawing.Font("Aqua Grotesque", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ishaTime.Location = new System.Drawing.Point(105, 245);
            this.ishaTime.Name = "ishaTime";
            this.ishaTime.Size = new System.Drawing.Size(0, 16);
            this.ishaTime.TabIndex = 15;
            // 
            // dhuhrCheck
            // 
            this.dhuhrCheck.AutoSize = true;
            this.dhuhrCheck.BackColor = System.Drawing.Color.Transparent;
            this.dhuhrCheck.Location = new System.Drawing.Point(20, 110);
            this.dhuhrCheck.Name = "dhuhrCheck";
            this.dhuhrCheck.Size = new System.Drawing.Size(15, 14);
            this.dhuhrCheck.TabIndex = 17;
            this.dhuhrCheck.UseVisualStyleBackColor = false;
            // 
            // asrCheck
            // 
            this.asrCheck.AutoSize = true;
            this.asrCheck.BackColor = System.Drawing.Color.Transparent;
            this.asrCheck.Location = new System.Drawing.Point(20, 155);
            this.asrCheck.Name = "asrCheck";
            this.asrCheck.Size = new System.Drawing.Size(15, 14);
            this.asrCheck.TabIndex = 18;
            this.asrCheck.UseVisualStyleBackColor = false;
            // 
            // maghribCheck
            // 
            this.maghribCheck.AutoSize = true;
            this.maghribCheck.BackColor = System.Drawing.Color.Transparent;
            this.maghribCheck.Location = new System.Drawing.Point(20, 200);
            this.maghribCheck.Name = "maghribCheck";
            this.maghribCheck.Size = new System.Drawing.Size(15, 14);
            this.maghribCheck.TabIndex = 19;
            this.maghribCheck.UseVisualStyleBackColor = false;
            // 
            // ishaCheck
            // 
            this.ishaCheck.AutoSize = true;
            this.ishaCheck.BackColor = System.Drawing.Color.Transparent;
            this.ishaCheck.Location = new System.Drawing.Point(20, 245);
            this.ishaCheck.Name = "ishaCheck";
            this.ishaCheck.Size = new System.Drawing.Size(15, 14);
            this.ishaCheck.TabIndex = 20;
            this.ishaCheck.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Aqua Grotesque", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(11, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 18);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "Prayer Reminder";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liveClock
            // 
            this.liveClock.AutoSize = true;
            this.liveClock.BackColor = System.Drawing.Color.Transparent;
            this.liveClock.Font = new System.Drawing.Font("Aqua Grotesque", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveClock.Location = new System.Drawing.Point(11, 30);
            this.liveClock.Name = "liveClock";
            this.liveClock.Size = new System.Drawing.Size(63, 16);
            this.liveClock.TabIndex = 22;
            this.liveClock.Text = "12:00 AM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 6000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // fajrTime
            // 
            this.fajrTime.AutoSize = true;
            this.fajrTime.BackColor = System.Drawing.Color.Transparent;
            this.fajrTime.Font = new System.Drawing.Font("Aqua Grotesque", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fajrTime.Location = new System.Drawing.Point(105, 65);
            this.fajrTime.Name = "fajrTime";
            this.fajrTime.Size = new System.Drawing.Size(0, 16);
            this.fajrTime.TabIndex = 11;
            // 
            // fajrLabel
            // 
            this.fajrLabel.AutoSize = true;
            this.fajrLabel.BackColor = System.Drawing.Color.Transparent;
            this.fajrLabel.Font = new System.Drawing.Font("Aqua Grotesque", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fajrLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fajrLabel.Location = new System.Drawing.Point(40, 65);
            this.fajrLabel.Name = "fajrLabel";
            this.fajrLabel.Size = new System.Drawing.Size(32, 16);
            this.fajrLabel.TabIndex = 6;
            this.fajrLabel.Text = "Fajr";
            // 
            // fajrCheck
            // 
            this.fajrCheck.AutoSize = true;
            this.fajrCheck.BackColor = System.Drawing.Color.Transparent;
            this.fajrCheck.Location = new System.Drawing.Point(20, 65);
            this.fajrCheck.Name = "fajrCheck";
            this.fajrCheck.Size = new System.Drawing.Size(15, 14);
            this.fajrCheck.TabIndex = 16;
            this.fajrCheck.UseVisualStyleBackColor = false;
            // 
            // fajrPanel
            // 
            this.fajrPanel.BackColor = System.Drawing.Color.White;
            this.fajrPanel.BorderRadius = 20;
            this.fajrPanel.ForeColor = System.Drawing.Color.Black;
            this.fajrPanel.GradientAngle = 90F;
            this.fajrPanel.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(122)))), ((int)(((byte)(252)))));
            this.fajrPanel.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(122)))), ((int)(((byte)(252)))));
            this.fajrPanel.Location = new System.Drawing.Point(11, 55);
            this.fajrPanel.Name = "fajrPanel";
            this.fajrPanel.Size = new System.Drawing.Size(152, 30);
            this.fajrPanel.TabIndex = 23;
            this.fajrPanel.Visible = false;
            // 
            // dhuhrPanel
            // 
            this.dhuhrPanel.BackColor = System.Drawing.Color.White;
            this.dhuhrPanel.BorderRadius = 20;
            this.dhuhrPanel.ForeColor = System.Drawing.Color.Black;
            this.dhuhrPanel.GradientAngle = 90F;
            this.dhuhrPanel.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dhuhrPanel.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dhuhrPanel.Location = new System.Drawing.Point(11, 100);
            this.dhuhrPanel.Name = "dhuhrPanel";
            this.dhuhrPanel.Size = new System.Drawing.Size(152, 30);
            this.dhuhrPanel.TabIndex = 24;
            this.dhuhrPanel.Visible = false;
            // 
            // asrPanel
            // 
            this.asrPanel.BackColor = System.Drawing.Color.White;
            this.asrPanel.BorderRadius = 20;
            this.asrPanel.ForeColor = System.Drawing.Color.Black;
            this.asrPanel.GradientAngle = 90F;
            this.asrPanel.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.asrPanel.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.asrPanel.Location = new System.Drawing.Point(11, 145);
            this.asrPanel.Name = "asrPanel";
            this.asrPanel.Size = new System.Drawing.Size(152, 30);
            this.asrPanel.TabIndex = 25;
            this.asrPanel.Visible = false;
            // 
            // maghribPanel
            // 
            this.maghribPanel.BackColor = System.Drawing.Color.White;
            this.maghribPanel.BorderRadius = 20;
            this.maghribPanel.ForeColor = System.Drawing.Color.Black;
            this.maghribPanel.GradientAngle = 90F;
            this.maghribPanel.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.maghribPanel.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.maghribPanel.Location = new System.Drawing.Point(11, 190);
            this.maghribPanel.Name = "maghribPanel";
            this.maghribPanel.Size = new System.Drawing.Size(152, 30);
            this.maghribPanel.TabIndex = 26;
            this.maghribPanel.Visible = false;
            // 
            // ishaPanel
            // 
            this.ishaPanel.BackColor = System.Drawing.Color.White;
            this.ishaPanel.BorderRadius = 20;
            this.ishaPanel.ForeColor = System.Drawing.Color.Black;
            this.ishaPanel.GradientAngle = 90F;
            this.ishaPanel.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ishaPanel.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ishaPanel.Location = new System.Drawing.Point(11, 235);
            this.ishaPanel.Name = "ishaPanel";
            this.ishaPanel.Size = new System.Drawing.Size(152, 30);
            this.ishaPanel.TabIndex = 27;
            this.ishaPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(174, 281);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.fajrCheck);
            this.Controls.Add(this.fajrLabel);
            this.Controls.Add(this.fajrTime);
            this.Controls.Add(this.liveClock);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.ishaCheck);
            this.Controls.Add(this.maghribCheck);
            this.Controls.Add(this.asrCheck);
            this.Controls.Add(this.dhuhrCheck);
            this.Controls.Add(this.ishaTime);
            this.Controls.Add(this.maghribTime);
            this.Controls.Add(this.asrTime);
            this.Controls.Add(this.dhuhrTime);
            this.Controls.Add(this.ishaLabel);
            this.Controls.Add(this.maghribLabel);
            this.Controls.Add(this.asrLabel);
            this.Controls.Add(this.dhuhrLabel);
            this.Controls.Add(this.fajrPanel);
            this.Controls.Add(this.dhuhrPanel);
            this.Controls.Add(this.asrPanel);
            this.Controls.Add(this.maghribPanel);
            this.Controls.Add(this.ishaPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lockPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private Label dhuhrLabel;
        private Label asrLabel;
        private Label maghribLabel;
        private Label ishaLabel;
        private Label dhuhrTime;
        private Label maghribTime;
        private Label asrTime;
        private Label ishaTime;
        private CheckBox dhuhrCheck;
        private CheckBox asrCheck;
        private CheckBox maghribCheck;
        private CheckBox ishaCheck;
        private Label titleLabel;
        private Label liveClock;
        private Timer timer1;
        private Timer timer2;
        private Label fajrTime;
        private Label fajrLabel;
        private CheckBox fajrCheck;
        private FancyPanel fajrPanel;
        private FancyPanel dhuhrPanel;
        private FancyPanel asrPanel;
        private FancyPanel maghribPanel;
        private FancyPanel ishaPanel;
    }
}

