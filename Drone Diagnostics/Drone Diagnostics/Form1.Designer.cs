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
            this.resultsFromR = new System.Windows.Forms.ListBox();
            this.serialMonitor = new System.Windows.Forms.ListBox();
            this.serialStopButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialBeginButton = new System.Windows.Forms.Button();
            this.serialClearButton = new System.Windows.Forms.Button();
            this.serialMonitorTestTimer = new System.Windows.Forms.Timer(this.components);
            this.comPortList = new System.Windows.Forms.ComboBox();
            this.refreshSerial = new System.Windows.Forms.Button();
            this.serialMonitorLabel = new System.Windows.Forms.Label();
            this.rMonitorLabel = new System.Windows.Forms.Label();
            this.sonarViewer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sonarViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsFromR
            // 
            this.resultsFromR.FormattingEnabled = true;
            this.resultsFromR.Location = new System.Drawing.Point(1457, 36);
            this.resultsFromR.Name = "resultsFromR";
            this.resultsFromR.Size = new System.Drawing.Size(314, 199);
            this.resultsFromR.TabIndex = 0;
            // 
            // serialMonitor
            // 
            this.serialMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialMonitor.FormattingEnabled = true;
            this.serialMonitor.ItemHeight = 20;
            this.serialMonitor.Location = new System.Drawing.Point(1457, 316);
            this.serialMonitor.Name = "serialMonitor";
            this.serialMonitor.Size = new System.Drawing.Size(314, 484);
            this.serialMonitor.TabIndex = 0;
            this.serialMonitor.SelectedIndexChanged += new System.EventHandler(this.serialMonitor_SelectedIndexChanged);
            // 
            // serialStopButton
            // 
            this.serialStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialStopButton.Location = new System.Drawing.Point(1685, 816);
            this.serialStopButton.Name = "serialStopButton";
            this.serialStopButton.Size = new System.Drawing.Size(87, 33);
            this.serialStopButton.TabIndex = 3;
            this.serialStopButton.Text = "Stop";
            this.serialStopButton.UseVisualStyleBackColor = true;
            this.serialStopButton.Click += new System.EventHandler(this.serialStopButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 817);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(380, 33);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 75;
            // 
            // serialBeginButton
            // 
            this.serialBeginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialBeginButton.Location = new System.Drawing.Point(1457, 817);
            this.serialBeginButton.Name = "serialBeginButton";
            this.serialBeginButton.Size = new System.Drawing.Size(128, 33);
            this.serialBeginButton.TabIndex = 8;
            this.serialBeginButton.Text = "Begin";
            this.serialBeginButton.UseVisualStyleBackColor = true;
            this.serialBeginButton.Click += new System.EventHandler(this.serialBeginButton_Click);
            // 
            // serialClearButton
            // 
            this.serialClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialClearButton.Location = new System.Drawing.Point(1591, 816);
            this.serialClearButton.Name = "serialClearButton";
            this.serialClearButton.Size = new System.Drawing.Size(88, 33);
            this.serialClearButton.TabIndex = 9;
            this.serialClearButton.Text = "Clear";
            this.serialClearButton.UseVisualStyleBackColor = true;
            this.serialClearButton.Click += new System.EventHandler(this.serialClearButton_Click);
            // 
            // serialMonitorTestTimer
            // 
            this.serialMonitorTestTimer.Enabled = true;
            this.serialMonitorTestTimer.Interval = 200;
            this.serialMonitorTestTimer.Tick += new System.EventHandler(this.serialMonitorTestTimer_Tick);
            // 
            // comPortList
            // 
            this.comPortList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortList.FormattingEnabled = true;
            this.comPortList.Location = new System.Drawing.Point(1617, 282);
            this.comPortList.Name = "comPortList";
            this.comPortList.Size = new System.Drawing.Size(155, 28);
            this.comPortList.TabIndex = 11;
            // 
            // refreshSerial
            // 
            this.refreshSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshSerial.Location = new System.Drawing.Point(1457, 282);
            this.refreshSerial.Name = "refreshSerial";
            this.refreshSerial.Size = new System.Drawing.Size(154, 28);
            this.refreshSerial.TabIndex = 12;
            this.refreshSerial.Text = "Refresh";
            this.refreshSerial.UseVisualStyleBackColor = true;
            this.refreshSerial.Click += new System.EventHandler(this.refreshSerial_Click);
            // 
            // serialMonitorLabel
            // 
            this.serialMonitorLabel.AutoSize = true;
            this.serialMonitorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialMonitorLabel.Location = new System.Drawing.Point(1557, 253);
            this.serialMonitorLabel.Name = "serialMonitorLabel";
            this.serialMonitorLabel.Size = new System.Drawing.Size(120, 20);
            this.serialMonitorLabel.TabIndex = 13;
            this.serialMonitorLabel.Text = "Serial Monitor";
            // 
            // rMonitorLabel
            // 
            this.rMonitorLabel.AutoSize = true;
            this.rMonitorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMonitorLabel.Location = new System.Drawing.Point(1569, 9);
            this.rMonitorLabel.Name = "rMonitorLabel";
            this.rMonitorLabel.Size = new System.Drawing.Size(87, 20);
            this.rMonitorLabel.TabIndex = 14;
            this.rMonitorLabel.Text = "R Monitor";
            // 
            // sonarViewer
            // 
            this.sonarViewer.Location = new System.Drawing.Point(462, 152);
            this.sonarViewer.Name = "sonarViewer";
            this.sonarViewer.Size = new System.Drawing.Size(756, 584);
            this.sonarViewer.TabIndex = 15;
            this.sonarViewer.TabStop = false;
            this.sonarViewer.Click += new System.EventHandler(this.sonarViewer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 861);
            this.Controls.Add(this.sonarViewer);
            this.Controls.Add(this.rMonitorLabel);
            this.Controls.Add(this.serialMonitorLabel);
            this.Controls.Add(this.resultsFromR);
            this.Controls.Add(this.refreshSerial);
            this.Controls.Add(this.comPortList);
            this.Controls.Add(this.serialClearButton);
            this.Controls.Add(this.serialBeginButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.serialStopButton);
            this.Controls.Add(this.serialMonitor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sonarViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox serialMonitor;
        private System.Windows.Forms.Button serialStopButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button serialBeginButton;
        private System.Windows.Forms.Button serialClearButton;
        private System.Windows.Forms.Timer serialMonitorTestTimer;
        private System.Windows.Forms.ComboBox comPortList;
        private System.Windows.Forms.ListBox resultsFromR;
        private System.Windows.Forms.Button refreshSerial;
        private System.Windows.Forms.Label serialMonitorLabel;
        private System.Windows.Forms.Label rMonitorLabel;
        private System.Windows.Forms.PictureBox sonarViewer;
    }
}

