namespace Drone_Diagnostics
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
            this.serialMonitorLabel = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.motorsTab = new System.Windows.Forms.TabPage();
            this.sonarTab = new System.Windows.Forms.TabPage();
            this.serialMonitor = new System.Windows.Forms.ListBox();
            this.gyroTab = new System.Windows.Forms.TabPage();
            this.serialStopButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.droneStatusLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.batteryLifeLabel = new System.Windows.Forms.Label();
            this.serialBeginButton = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialMonitorLabel
            // 
            this.serialMonitorLabel.AutoSize = true;
            this.serialMonitorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialMonitorLabel.Location = new System.Drawing.Point(891, 23);
            this.serialMonitorLabel.Name = "serialMonitorLabel";
            this.serialMonitorLabel.Size = new System.Drawing.Size(146, 26);
            this.serialMonitorLabel.TabIndex = 1;
            this.serialMonitorLabel.Text = "Serial Monitor";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.motorsTab);
            this.tabs.Controls.Add(this.sonarTab);
            this.tabs.Controls.Add(this.gyroTab);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(12, 144);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(738, 656);
            this.tabs.TabIndex = 2;
            // 
            // motorsTab
            // 
            this.motorsTab.Location = new System.Drawing.Point(4, 29);
            this.motorsTab.Name = "motorsTab";
            this.motorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.motorsTab.Size = new System.Drawing.Size(730, 623);
            this.motorsTab.TabIndex = 0;
            this.motorsTab.Text = "Motors";
            this.motorsTab.UseVisualStyleBackColor = true;
            // 
            // sonarTab
            // 
            this.sonarTab.Location = new System.Drawing.Point(4, 29);
            this.sonarTab.Name = "sonarTab";
            this.sonarTab.Padding = new System.Windows.Forms.Padding(3);
            this.sonarTab.Size = new System.Drawing.Size(730, 673);
            this.sonarTab.TabIndex = 1;
            this.sonarTab.Text = "Sonars";
            this.sonarTab.UseVisualStyleBackColor = true;
            // 
            // serialMonitor
            // 
            this.serialMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialMonitor.FormattingEnabled = true;
            this.serialMonitor.ItemHeight = 20;
            this.serialMonitor.Location = new System.Drawing.Point(782, 172);
            this.serialMonitor.Name = "serialMonitor";
            this.serialMonitor.Size = new System.Drawing.Size(346, 624);
            this.serialMonitor.TabIndex = 0;
            // 
            // gyroTab
            // 
            this.gyroTab.Location = new System.Drawing.Point(4, 29);
            this.gyroTab.Name = "gyroTab";
            this.gyroTab.Size = new System.Drawing.Size(730, 673);
            this.gyroTab.TabIndex = 2;
            this.gyroTab.Text = "9-Axis";
            this.gyroTab.UseVisualStyleBackColor = true;
            // 
            // serialStopButton
            // 
            this.serialStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialStopButton.Location = new System.Drawing.Point(1021, 117);
            this.serialStopButton.Name = "serialStopButton";
            this.serialStopButton.Size = new System.Drawing.Size(107, 33);
            this.serialStopButton.TabIndex = 3;
            this.serialStopButton.Text = "Stop";
            this.serialStopButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(501, 118);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 32);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 75;
            // 
            // droneStatusLabel
            // 
            this.droneStatusLabel.AutoSize = true;
            this.droneStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.droneStatusLabel.Location = new System.Drawing.Point(12, 9);
            this.droneStatusLabel.Name = "droneStatusLabel";
            this.droneStatusLabel.Size = new System.Drawing.Size(71, 22);
            this.droneStatusLabel.TabIndex = 5;
            this.droneStatusLabel.Text = "Status: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(782, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 32);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "COM Port";
            // 
            // batteryLifeLabel
            // 
            this.batteryLifeLabel.AutoSize = true;
            this.batteryLifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryLifeLabel.Location = new System.Drawing.Point(581, 90);
            this.batteryLifeLabel.Name = "batteryLifeLabel";
            this.batteryLifeLabel.Size = new System.Drawing.Size(90, 20);
            this.batteryLifeLabel.TabIndex = 7;
            this.batteryLifeLabel.Text = "Battery Life";
            // 
            // serialBeginButton
            // 
            this.serialBeginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialBeginButton.Location = new System.Drawing.Point(894, 117);
            this.serialBeginButton.Name = "serialBeginButton";
            this.serialBeginButton.Size = new System.Drawing.Size(121, 33);
            this.serialBeginButton.TabIndex = 8;
            this.serialBeginButton.Text = "Begin";
            this.serialBeginButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 810);
            this.Controls.Add(this.serialBeginButton);
            this.Controls.Add(this.batteryLifeLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.droneStatusLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.serialStopButton);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.serialMonitorLabel);
            this.Controls.Add(this.serialMonitor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label serialMonitorLabel;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage motorsTab;
        private System.Windows.Forms.TabPage sonarTab;
        private System.Windows.Forms.ListBox serialMonitor;
        private System.Windows.Forms.TabPage gyroTab;
        private System.Windows.Forms.Button serialStopButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label droneStatusLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label batteryLifeLabel;
        private System.Windows.Forms.Button serialBeginButton;
    }
}

