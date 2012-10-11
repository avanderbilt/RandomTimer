namespace RandomTimer
{
    partial class Main
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StartContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DurationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(55, 56);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 29);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "&Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(136, 56);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 29);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "S&top";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.NotifyIcon.Text = "NotifyIcon";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.BalloonTipClicked += new System.EventHandler(this.NotifyIcon_BalloonTipClicked);
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartContextMenuItem,
            this.StopContextMenuItem,
            this.toolStripSeparator1,
            this.exitContextMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 104);
            // 
            // StartContextMenuItem
            // 
            this.StartContextMenuItem.Name = "StartContextMenuItem";
            this.StartContextMenuItem.Size = new System.Drawing.Size(152, 24);
            this.StartContextMenuItem.Text = "Start";
            this.StartContextMenuItem.Click += new System.EventHandler(this.StartContextMenuItem_Click);
            // 
            // StopContextMenuItem
            // 
            this.StopContextMenuItem.Enabled = false;
            this.StopContextMenuItem.Name = "StopContextMenuItem";
            this.StopContextMenuItem.Size = new System.Drawing.Size(152, 24);
            this.StopContextMenuItem.Text = "Stop";
            this.StopContextMenuItem.Click += new System.EventHandler(this.StopContextMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 95);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(263, 25);
            this.StatusStrip.TabIndex = 3;
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(69, 20);
            this.StatusStripLabel.Text = "Stopped.";
            // 
            // DurationNumericUpDown
            // 
            this.DurationNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationNumericUpDown.Location = new System.Drawing.Point(12, 12);
            this.DurationNumericUpDown.Name = "DurationNumericUpDown";
            this.DurationNumericUpDown.Size = new System.Drawing.Size(240, 38);
            this.DurationNumericUpDown.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitContextMenuItem
            // 
            this.exitContextMenuItem.Name = "exitContextMenuItem";
            this.exitContextMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exitContextMenuItem.Text = "Exit";
            this.exitContextMenuItem.Click += new System.EventHandler(this.exitContextMenuItem_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.StopButton;
            this.ClientSize = new System.Drawing.Size(263, 120);
            this.Controls.Add(this.DurationNumericUpDown);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(281, 165);
            this.MinimumSize = new System.Drawing.Size(281, 165);
            this.Name = "Main";
            this.Text = "Random Timer";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.NumericUpDown DurationNumericUpDown;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StartContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitContextMenuItem;
    }
}