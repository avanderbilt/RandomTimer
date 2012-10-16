using System;
using System.Drawing;
using System.Windows.Forms;
using RandomTimer.Properties;

namespace RandomTimer
{
    public partial class Main : Form
    {
        private readonly Random _random;
        private readonly Timer _timer;

        private readonly Notification _notification;

        public Main()
        {
            InitializeComponent();

            _random = new Random();

            Icon = Resources.Clock;
            Opacity = 0.90;

            _timer = new Timer();
            _timer.Tick += new EventHandler(Timer_Tick);

            Icon = Resources.Clock;

            NotifyIcon.Icon = Resources.Clock;
            NotifyIcon.Text = Resources.StoppedLabel;

            _notification = new Notification
            {
                StartPosition = FormStartPosition.Manual
            };

            _notification.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - _notification.Width - 10,
                                 Screen.PrimaryScreen.WorkingArea.Bottom - _notification.Height - 10);

            _notification.ResetButton.Click += NotificationResetButton_Click;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void Timer_Tick(object theObject, EventArgs eventArgs)
        {
            _timer.Stop();

            ShowNotificationWindow();

            EnableStart();
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void NotificationResetButton_Click(object sender, EventArgs e)
        {
            StartTimer();
            _notification.Hide();
        }

        private void StartContextMenuItem_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StopContextMenuItem_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void exitContextMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void StartTimer()
        {
            if (DurationNumericUpDown.Value == 0)
                return;

            var randomInterval = _random.Next((int) DurationNumericUpDown.Value*1000*60);

            _timer.Interval = randomInterval;
            _timer.Start();

            EnableStop();
        }

        private void EnableStart()
        {
            StatusStripLabel.Text = Resources.StoppedLabel;
            NotifyIcon.Text = Resources.StoppedLabel;

            StartButton.Enabled = true;
            StopButton.Enabled = false;
            StartContextMenuItem.Enabled = true;
            StopContextMenuItem.Enabled = false;
            DurationNumericUpDown.Enabled = true;
        }

        private void StopTimer()
        {
            _timer.Stop();
            StatusStripLabel.Text = Resources.StoppedLabel;
            NotifyIcon.Text = Resources.StoppedLabel;

            EnableStart();
        }

        private void EnableStop()
        {
            StatusStripLabel.Text = Resources.RunningLabel;
            NotifyIcon.Text = Resources.RunningLabel;

            StartButton.Enabled = false;
            StopButton.Enabled = true;
            StartContextMenuItem.Enabled = false;
            StopContextMenuItem.Enabled = true;
            DurationNumericUpDown.Enabled = false;
            WindowState = FormWindowState.Minimized;
        }

        private void ShowNotificationWindow()
        {
            _notification.Show();
        }
    }
}