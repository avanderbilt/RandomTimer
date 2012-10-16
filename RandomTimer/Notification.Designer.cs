namespace RandomTimer
{
    partial class Notification
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
            this.TimerElapsedLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerElapsedLabel
            // 
            this.TimerElapsedLabel.AutoSize = true;
            this.TimerElapsedLabel.Location = new System.Drawing.Point(48, 9);
            this.TimerElapsedLabel.Name = "TimerElapsedLabel";
            this.TimerElapsedLabel.Size = new System.Drawing.Size(205, 17);
            this.TimerElapsedLabel.TabIndex = 1;
            this.TimerElapsedLabel.Text = "The random timer has elapsed.";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(113, 29);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 64);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TimerElapsedLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Notification";
            this.Opacity = 0.9D;
            this.Text = "Random Timer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerElapsedLabel;
        public System.Windows.Forms.Button ResetButton;
    }
}