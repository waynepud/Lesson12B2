namespace Lesson12B2
{
    partial class Splashform
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
            this.SplashformTimer = new System.Windows.Forms.Timer(this.components);
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SplashformTimer
            // 
            this.SplashformTimer.Enabled = true;
            this.SplashformTimer.Interval = 3000;
            this.SplashformTimer.Tick += new System.EventHandler(this.SplashformTimer_Tick);
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelabel.Location = new System.Drawing.Point(6, 118);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(284, 64);
            this.Welcomelabel.TabIndex = 0;
            this.Welcomelabel.Text = "Welcome to my\r\nawesome calculator";
            this.Welcomelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Splashform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.ControlBox = false;
            this.Controls.Add(this.Welcomelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splashform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splashform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashformTimer;
        private System.Windows.Forms.Label Welcomelabel;
    }
}