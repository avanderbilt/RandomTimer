using System;
using System.Windows.Forms;
using RandomTimer.Properties;

namespace RandomTimer
{
    public partial class Main : Form
    {
        private readonly Random _random;
        private readonly Timer Timer;

        public Main()
        {
            InitializeComponent();

            _random = new Random();

            Timer = new Timer();
            Timer.Tick += new EventHandler(Timer_Tick);

            Icon = Resources.Clock;

            NotifyIcon.Icon = Resources.Clock;
            NotifyIcon.BalloonTipText = "The random timer has elapsed.";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StartTimer()
        {
            if (DurationNumericUpDown.Value == 0)
                return;

            var randomInterval = _random.Next((int)DurationNumericUpDown.Value * 1000 * 60);

            Timer.Interval = randomInterval;
            Timer.Start();
            StatusStripLabel.Text = "Running ...";
            NotifyIcon.Text = "Running ...";

            StartButton.Enabled = false;
            StopButton.Enabled = true;
            StartContextMenuItem.Enabled = false;
            StopContextMenuItem.Enabled = true;
            DurationNumericUpDown.Enabled = false;
            WindowState = FormWindowState.Minimized;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void StopTimer()
        {
            Timer.Stop();
            StatusStripLabel.Text = "Stopped.";
            NotifyIcon.Text = "Stopped.";

            StartButton.Enabled = true;
            StopButton.Enabled = false;
            StartContextMenuItem.Enabled = true;
            StopContextMenuItem.Enabled = false;
            DurationNumericUpDown.Enabled = true;
        }

        private void Timer_Tick(object theObject, EventArgs eventArgs)
        {
            Timer.Stop();
            StatusStripLabel.Text = "Stopped.";
            NotifyIcon.Text = "Stopped.";

            // WindowState = FormWindowState.Normal;

            NotifyIcon.ShowBalloonTip(30*1000);

            StartButton.Enabled = true;
            StopButton.Enabled = false;
            StartContextMenuItem.Enabled = true;
            StopContextMenuItem.Enabled = false;
            DurationNumericUpDown.Enabled = true;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Minimized:
                    NotifyIcon.Visible = true;
                    ShowInTaskbar = false;
                    break;
                case FormWindowState.Normal:
                    NotifyIcon.Visible = false;
                    ShowInTaskbar = true;
                    BringToFront();
                    break;
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void NotifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StartContextMenuItem_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StopContextMenuItem_Click(object sender, EventArgs e)
        {
            StopTimer();
        }
    }
}
