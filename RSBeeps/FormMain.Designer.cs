namespace RSBeeps
{
    partial class FormMain
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabelTimeText = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPauseStart = new System.Windows.Forms.Button();
            this.buttonMaxTime = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabelTimeText
            // 
            this.LabelTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeText.Location = new System.Drawing.Point(0, 17);
            this.LabelTimeText.Name = "LabelTimeText";
            this.LabelTimeText.Size = new System.Drawing.Size(167, 97);
            this.LabelTimeText.TabIndex = 2;
            this.LabelTimeText.Text = "49";
            this.LabelTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTimeText.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(35, 4);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(92, 13);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Time to next beep";
            this.labelInfo.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(14, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(142, 120);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // buttonPauseStart
            // 
            this.buttonPauseStart.Enabled = false;
            this.buttonPauseStart.Location = new System.Drawing.Point(0, 131);
            this.buttonPauseStart.Name = "buttonPauseStart";
            this.buttonPauseStart.Size = new System.Drawing.Size(79, 23);
            this.buttonPauseStart.TabIndex = 6;
            this.buttonPauseStart.Text = "Pause";
            this.buttonPauseStart.UseVisualStyleBackColor = true;
            this.buttonPauseStart.Click += new System.EventHandler(this.buttonPauseStart_Click);
            // 
            // buttonMaxTime
            // 
            this.buttonMaxTime.Location = new System.Drawing.Point(45, 160);
            this.buttonMaxTime.Name = "buttonMaxTime";
            this.buttonMaxTime.Size = new System.Drawing.Size(82, 23);
            this.buttonMaxTime.TabIndex = 7;
            this.buttonMaxTime.Text = "Set New Max";
            this.buttonMaxTime.UseVisualStyleBackColor = true;
            this.buttonMaxTime.Click += new System.EventHandler(this.buttonMaxTime_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Enabled = false;
            this.buttonRestart.Location = new System.Drawing.Point(92, 131);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonRestart.TabIndex = 8;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 191);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonMaxTime);
            this.Controls.Add(this.buttonPauseStart);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.LabelTimeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "RSBeeps";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabelTimeText;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPauseStart;
        private System.Windows.Forms.Button buttonMaxTime;
        private System.Windows.Forms.Button buttonRestart;
    }
}

