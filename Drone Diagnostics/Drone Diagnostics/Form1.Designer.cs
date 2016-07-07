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
            this.components = new System.ComponentModel.Container();
            this.serialMonitorLabel = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.motorsTab = new System.Windows.Forms.TabPage();
            this.sonarTab = new System.Windows.Forms.TabPage();
            this.gyroTab = new System.Windows.Forms.TabPage();
            this.serialMonitor = new System.Windows.Forms.ListBox();
            this.serialStopButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comPort = new System.Windows.Forms.TextBox();
            this.batteryLifeLabel = new System.Windows.Forms.Label();
            this.serialBeginButton = new System.Windows.Forms.Button();
            this.serialClearButton = new System.Windows.Forms.Button();
            this.checkComPortsButton = new System.Windows.Forms.Button();
            this.serialMonitorTestTimer = new System.Windows.Forms.Timer(this.components);
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
            this.tabs.Location = new System.Drawing.Point(12, 172);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(738, 628);
            this.tabs.TabIndex = 2;
            // 
            // motorsTab
            // 
            this.motorsTab.Location = new System.Drawing.Point(4, 29);
            this.motorsTab.Name = "motorsTab";
            this.motorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.motorsTab.Size = new System.Drawing.Size(730, 595);
            this.motorsTab.TabIndex = 0;
            this.motorsTab.Text = "Motors";
            this.motorsTab.UseVisualStyleBackColor = true;
            // 
            // sonarTab
            // 
            this.sonarTab.Location = new System.Drawing.Point(4, 29);
            this.sonarTab.Name = "sonarTab";
            this.sonarTab.Padding = new System.Windows.Forms.Padding(3);
            this.sonarTab.Size = new System.Drawing.Size(730, 595);
            this.sonarTab.TabIndex = 1;
            this.sonarTab.Text = "Sonars";
            this.sonarTab.UseVisualStyleBackColor = true;
            // 
            // gyroTab
            // 
            this.gyroTab.Location = new System.Drawing.Point(4, 29);
            this.gyroTab.Name = "gyroTab";
            this.gyroTab.Size = new System.Drawing.Size(730, 595);
            this.gyroTab.TabIndex = 2;
            this.gyroTab.Text = "9-Axis";
            this.gyroTab.UseVisualStyleBackColor = true;
            // 
            // serialMonitor
            // 
            this.serialMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialMonitor.FormattingEnabled = true;
            this.serialMonitor.ItemHeight = 20;
            this.serialMonitor.Location = new System.Drawing.Point(782, 172);
            this.serialMonitor.Name = "serialMonitor";
            this.serialMonitor.Size = new System.Drawing.Size(346, 584);
            this.serialMonitor.TabIndex = 0;
            // 
            // serialStopButton
            // 
            this.serialStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialStopButton.Location = new System.Drawing.Point(1023, 764);
            this.serialStopButton.Name = "serialStopButton";
            this.serialStopButton.Size = new System.Drawing.Size(105, 33);
            this.serialStopButton.TabIndex = 3;
            this.serialStopButton.Text = "Stop";
            this.serialStopButton.UseVisualStyleBackColor = true;
            this.serialStopButton.Click += new System.EventHandler(this.serialStopButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(501, 133);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 32);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 75;
            // 
            // comPort
            // 
            this.comPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPort.Location = new System.Drawing.Point(782, 134);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(106, 30);
            this.comPort.TabIndex = 6;
            this.comPort.TextChanged += new System.EventHandler(this.comPort_TextChanged);
            this.comPort.Enter += new System.EventHandler(this.comPort_Enter);
            this.comPort.Leave += new System.EventHandler(this.comPort_Leave);
            // 
            // batteryLifeLabel
            // 
            this.batteryLifeLabel.AutoSize = true;
            this.batteryLifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryLifeLabel.Location = new System.Drawing.Point(581, 105);
            this.batteryLifeLabel.Name = "batteryLifeLabel";
            this.batteryLifeLabel.Size = new System.Drawing.Size(90, 20);
            this.batteryLifeLabel.TabIndex = 7;
            this.batteryLifeLabel.Text = "Battery Life";
            // 
            // serialBeginButton
            // 
            this.serialBeginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialBeginButton.Location = new System.Drawing.Point(781, 765);
            this.serialBeginButton.Name = "serialBeginButton";
            this.serialBeginButton.Size = new System.Drawing.Size(125, 33);
            this.serialBeginButton.TabIndex = 8;
            this.serialBeginButton.Text = "Begin";
            this.serialBeginButton.UseVisualStyleBackColor = true;
            this.serialBeginButton.Click += new System.EventHandler(this.serialBeginButton_Click);
            // 
            // serialClearButton
            // 
            this.serialClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialClearButton.Location = new System.Drawing.Point(912, 765);
            this.serialClearButton.Name = "serialClearButton";
            this.serialClearButton.Size = new System.Drawing.Size(105, 33);
            this.serialClearButton.TabIndex = 9;
            this.serialClearButton.Text = "Clear";
            this.serialClearButton.UseVisualStyleBackColor = true;
            this.serialClearButton.Click += new System.EventHandler(this.serialClearButton_Click);
            // 
            // checkComPortsButton
            // 
            this.checkComPortsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkComPortsButton.Location = new System.Drawing.Point(895, 133);
            this.checkComPortsButton.Name = "checkComPortsButton";
            this.checkComPortsButton.Size = new System.Drawing.Size(233, 31);
            this.checkComPortsButton.TabIndex = 10;
            this.checkComPortsButton.Text = "Check Available Ports";
            this.checkComPortsButton.UseVisualStyleBackColor = true;
            this.checkComPortsButton.Click += new System.EventHandler(this.checkComPortsButton_Click);
            // 
            // serialMonitorTestTimer
            // 
            this.serialMonitorTestTimer.Enabled = true;
            this.serialMonitorTestTimer.Interval = 1000;
            this.serialMonitorTestTimer.Tick += new System.EventHandler(this.serialMonitorTestTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 810);
            this.Controls.Add(this.checkComPortsButton);
            this.Controls.Add(this.serialClearButton);
            this.Controls.Add(this.serialBeginButton);
            this.Controls.Add(this.batteryLifeLabel);
            this.Controls.Add(this.comPort);
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
        private System.Windows.Forms.TextBox comPort;
        private System.Windows.Forms.Label batteryLifeLabel;
        private System.Windows.Forms.Button serialBeginButton;
        private System.Windows.Forms.Button serialClearButton;
        private System.Windows.Forms.Button checkComPortsButton;
        private System.Windows.Forms.Timer serialMonitorTestTimer;
    }
}

