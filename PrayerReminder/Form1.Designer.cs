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
            this.opacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity100 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity90 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity75 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity50 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity25 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity10 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.selectedPanel = new PrayerReminder.FancyPanel();
            this.schoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shafiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanafiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockPositionToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem,
            this.opacityToolStripMenuItem,
            this.schoolToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
            // 
            // lockPositionToolStripMenuItem
            // 
            this.lockPositionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.lockPositionToolStripMenuItem.CheckOnClick = true;
            this.lockPositionToolStripMenuItem.Name = "lockPositionToolStripMenuItem";
            this.lockPositionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lockPositionToolStripMenuItem.Text = "Lock Position";
            this.lockPositionToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.lockPositionToolStripMenuItem_CheckStateChanged);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_CheckStateChanged);
            // 
            // opacityToolStripMenuItem
            // 
            this.opacityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacity100,
            this.opacity90,
            this.opacity75,
            this.opacity50,
            this.opacity25,
            this.opacity10});
            this.opacityToolStripMenuItem.Name = "opacityToolStripMenuItem";
            this.opacityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opacityToolStripMenuItem.Text = "Opacity";
            // 
            // opacity100
            // 
            this.opacity100.Name = "opacity100";
            this.opacity100.Size = new System.Drawing.Size(102, 22);
            this.opacity100.Tag = 1D;
            this.opacity100.Text = "100%";
            this.opacity100.Click += new System.EventHandler(this.Opacity_Clicked);
            // 
            // opacity90
            // 
            this.opacity90.Name = "opacity90";
            this.opacity90.Size = new System.Drawing.Size(102, 22);
            this.opacity90.Tag = 0.9D;
            this.opacity90.Text = "90%";
            this.opacity90.Click += new System.EventHandler(this.Opacity_Clicked);
            // 
            // opacity75
            // 
            this.opacity75.Name = "opacity75";
            this.opacity75.Size = new System.Drawing.Size(102, 22);
            this.opacity75.Tag = 0.75D;
            this.opacity75.Text = "75%";
            this.opacity75.Click += new System.EventHandler(this.Opacity_Clicked);
            // 
            // opacity50
            // 
            this.opacity50.Name = "opacity50";
            this.opacity50.Size = new System.Drawing.Size(102, 22);
            this.opacity50.Tag = 0.5D;
            this.opacity50.Text = "50%";
            this.opacity50.Click += new System.EventHandler(this.Opacity_Clicked);
            // 
            // opacity25
            // 
            this.opacity25.Name = "opacity25";
            this.opacity25.Size = new System.Drawing.Size(102, 22);
            this.opacity25.Tag = 0.25D;
            this.opacity25.Text = "25%";
            this.opacity25.Click += new System.EventHandler(this.Opacity_Clicked);
            // 
            // opacity10
            // 
            this.opacity10.Name = "opacity10";
            this.opacity10.Size = new System.Drawing.Size(102, 22);
            this.opacity10.Tag = 0.1D;
            this.opacity10.Text = "10%";
            this.opacity10.Click += new System.EventHandler(this.Opacity_Clicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.dhuhrLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.dhuhrLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.dhuhrLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.asrLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.asrLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.asrLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.maghribLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.maghribLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.maghribLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.ishaLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.ishaLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.ishaLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.dhuhrTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.dhuhrTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.dhuhrTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.maghribTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.maghribTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.maghribTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.asrTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.asrTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.asrTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.ishaTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.ishaTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.ishaTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.dhuhrCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.dhuhrCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.dhuhrCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.asrCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.asrCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.asrCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.maghribCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.maghribCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.maghribCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.ishaCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.ishaCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.ishaCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.liveClock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.liveClock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.liveClock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.fajrTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.fajrTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.fajrTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
            // 
            // fajrLabel
            // 
            this.fajrLabel.AutoSize = true;
            this.fajrLabel.BackColor = System.Drawing.Color.Transparent;
            this.fajrLabel.Font = new System.Drawing.Font("Aqua Grotesque", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fajrLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fajrLabel.Location = new System.Drawing.Point(40, 63);
            this.fajrLabel.Name = "fajrLabel";
            this.fajrLabel.Size = new System.Drawing.Size(32, 16);
            this.fajrLabel.TabIndex = 6;
            this.fajrLabel.Text = "Fajr";
            this.fajrLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.fajrLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.fajrLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
            this.fajrCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.fajrCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.fajrCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
            // 
            // selectedPanel
            // 
            this.selectedPanel.BackColor = System.Drawing.Color.White;
            this.selectedPanel.BorderRadius = 20;
            this.selectedPanel.ForeColor = System.Drawing.Color.Black;
            this.selectedPanel.GradientAngle = 90F;
            this.selectedPanel.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.selectedPanel.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.selectedPanel.Location = new System.Drawing.Point(10, 235);
            this.selectedPanel.Name = "selectedPanel";
            this.selectedPanel.Size = new System.Drawing.Size(175, 30);
            this.selectedPanel.TabIndex = 27;
            this.selectedPanel.Visible = false;
            this.selectedPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.selectedPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.selectedPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
            // 
            // schoolToolStripMenuItem
            // 
            this.schoolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shafiToolStripMenuItem,
            this.hanafiToolStripMenuItem});
            this.schoolToolStripMenuItem.Name = "schoolToolStripMenuItem";
            this.schoolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.schoolToolStripMenuItem.Text = "School";
            // 
            // shafiToolStripMenuItem
            // 
            this.shafiToolStripMenuItem.Name = "shafiToolStripMenuItem";
            this.shafiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shafiToolStripMenuItem.Text = "Shafi";
            this.shafiToolStripMenuItem.Tag = 0;
            this.shafiToolStripMenuItem.Click += new System.EventHandler(this.School_Clicked);
            // 
            // hanafiToolStripMenuItem
            // 
            this.hanafiToolStripMenuItem.Name = "hanafiToolStripMenuItem";
            this.hanafiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hanafiToolStripMenuItem.Text = "Hanafi";
            this.hanafiToolStripMenuItem.Tag = 1;
            this.hanafiToolStripMenuItem.Click += new System.EventHandler(this.School_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(194, 281);
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
            this.Controls.Add(this.selectedPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
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
        private FancyPanel selectedPanel;
        private ToolStripMenuItem opacityToolStripMenuItem;
        private ToolStripMenuItem opacity100;
        private ToolStripMenuItem opacity90;
        private ToolStripMenuItem opacity75;
        private ToolStripMenuItem opacity50;
        private ToolStripMenuItem opacity25;
        private ToolStripMenuItem opacity10;
        private ToolStripMenuItem schoolToolStripMenuItem;
        private ToolStripMenuItem shafiToolStripMenuItem;
        private ToolStripMenuItem hanafiToolStripMenuItem;
    }
}

