namespace TheCountdown
{
    partial class TheCountdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheCountdown));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.pctSuggestions = new System.Windows.Forms.PictureBox();
            this.pctPastTimers = new System.Windows.Forms.PictureBox();
            this.pctAddTimer = new System.Windows.Forms.PictureBox();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSuggestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPastTimers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLogo.CausesValidation = false;
            this.pnlLogo.Controls.Add(this.pctSuggestions);
            this.pnlLogo.Controls.Add(this.pctPastTimers);
            this.pnlLogo.Controls.Add(this.pctAddTimer);
            this.pnlLogo.Controls.Add(this.pctBox);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(272, 39);
            this.pnlLogo.TabIndex = 0;
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.SystemColors.Control;
            this.mainPnl.Location = new System.Drawing.Point(0, 33);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(272, 365);
            this.mainPnl.TabIndex = 1;
            // 
            // pctSuggestions
            // 
            this.pctSuggestions.BackgroundImage = global::TheCountdown.Properties.Resources.Suggestions;
            this.pctSuggestions.ErrorImage = global::TheCountdown.Properties.Resources.Suggestions;
            this.pctSuggestions.InitialImage = global::TheCountdown.Properties.Resources.Suggestions;
            this.pctSuggestions.Location = new System.Drawing.Point(139, 5);
            this.pctSuggestions.Name = "pctSuggestions";
            this.pctSuggestions.Size = new System.Drawing.Size(28, 28);
            this.pctSuggestions.TabIndex = 6;
            this.pctSuggestions.TabStop = false;
            // 
            // pctPastTimers
            // 
            this.pctPastTimers.BackgroundImage = global::TheCountdown.Properties.Resources.PastTimers;
            this.pctPastTimers.ErrorImage = global::TheCountdown.Properties.Resources.PastTimers;
            this.pctPastTimers.InitialImage = global::TheCountdown.Properties.Resources.PastTimers;
            this.pctPastTimers.Location = new System.Drawing.Point(173, 5);
            this.pctPastTimers.Name = "pctPastTimers";
            this.pctPastTimers.Size = new System.Drawing.Size(28, 28);
            this.pctPastTimers.TabIndex = 5;
            this.pctPastTimers.TabStop = false;
            this.pctPastTimers.MouseLeave += new System.EventHandler(this.pctPastTimers_MouseLeave);
            this.pctPastTimers.MouseHover += new System.EventHandler(this.pctPastTimers_MouseHover);
            // 
            // pctAddTimer
            // 
            this.pctAddTimer.BackgroundImage = global::TheCountdown.Properties.Resources.AddTimer;
            this.pctAddTimer.ErrorImage = global::TheCountdown.Properties.Resources.AddTimer;
            this.pctAddTimer.InitialImage = global::TheCountdown.Properties.Resources.AddTimer;
            this.pctAddTimer.Location = new System.Drawing.Point(241, 5);
            this.pctAddTimer.Name = "pctAddTimer";
            this.pctAddTimer.Size = new System.Drawing.Size(28, 28);
            this.pctAddTimer.TabIndex = 4;
            this.pctAddTimer.TabStop = false;
            this.pctAddTimer.Click += new System.EventHandler(this.addTimerBtn_Click);
            this.pctAddTimer.MouseLeave += new System.EventHandler(this.pctAddTimer_MouseLeave);
            this.pctAddTimer.MouseHover += new System.EventHandler(this.pctAddTimer_MouseHover);
            // 
            // pctBox
            // 
            this.pctBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBox.BackgroundImage")));
            this.pctBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctBox.ErrorImage")));
            this.pctBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctBox.InitialImage")));
            this.pctBox.Location = new System.Drawing.Point(207, 5);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(28, 28);
            this.pctBox.TabIndex = 0;
            this.pctBox.TabStop = false;
            this.pctBox.Click += new System.EventHandler(this.btnTimers_Click);
            this.pctBox.MouseLeave += new System.EventHandler(this.pctBox_MouseLeave);
            this.pctBox.MouseHover += new System.EventHandler(this.pctBox_MouseHover);
            // 
            // TheCountdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 393);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.mainPnl);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TheCountdown";
            this.Text = "TheCountdown";
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctSuggestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPastTimers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.PictureBox pctAddTimer;
        private System.Windows.Forms.PictureBox pctPastTimers;
        private System.Windows.Forms.PictureBox pctSuggestions;
    }
}

