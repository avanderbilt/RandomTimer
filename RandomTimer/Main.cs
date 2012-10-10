using System;
using System.Windows.Forms;
using RandomTimer.Properties;

namespace RandomTimer
{
    public partial class Main : Form
    {
        private readonly Random _random;
        private readonly Timer _timer;

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
            NotifyIcon.BalloonTipText = Resources.ElapsedMessage;
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

            NotifyIcon.ShowBalloonTip(30*1000);

            EnableStart();
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

            var randomInterval = _random.Next((int)DurationNumericUpDown.Value * 1000 * 60);

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
    }
}