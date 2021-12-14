namespace AutoClicker
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.Delay = new System.Windows.Forms.Button();
            this.InputType = new System.Windows.Forms.Button();
            this.Hours = new System.Windows.Forms.TextBox();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.Minutes = new System.Windows.Forms.TextBox();
            this.MilliSecondsLabel = new System.Windows.Forms.Label();
            this.MilliSeconds = new System.Windows.Forms.TextBox();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.TextBox();
            this.ClicksPerCycleRender = new System.Windows.Forms.Label();
            this.ClicksPerRender = new System.Windows.Forms.TextBox();
            this.SpecifiedLocationBox = new System.Windows.Forms.CheckBox();
            this.PickLocation = new System.Windows.Forms.Button();
            this.RepeatUntilStoppedCheckbox = new System.Windows.Forms.CheckBox();
            this.RepeatsLabel = new System.Windows.Forms.Label();
            this.Repeats = new System.Windows.Forms.TextBox();
            this.Xlbl = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.Ylbl = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.TextBox();
            this.TopMostCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // StopButton
            // 
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.StopButton, "StopButton");
            this.StopButton.Name = "StopButton";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.Name = "StartButton";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Delay
            // 
            this.Delay.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Delay, "Delay");
            this.Delay.Name = "Delay";
            this.Delay.UseVisualStyleBackColor = true;
            this.Delay.Click += new System.EventHandler(this.Delay_Click);
            // 
            // InputType
            // 
            this.InputType.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.InputType, "InputType");
            this.InputType.Name = "InputType";
            this.InputType.UseVisualStyleBackColor = true;
            this.InputType.Click += new System.EventHandler(this.InputType_Click);
            // 
            // Hours
            // 
            this.Hours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Hours, "Hours");
            this.Hours.Name = "Hours";
            this.Hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeVal_KeyPress);
            // 
            // HoursLabel
            // 
            resources.ApplyResources(this.HoursLabel, "HoursLabel");
            this.HoursLabel.Name = "HoursLabel";
            // 
            // MinutesLabel
            // 
            resources.ApplyResources(this.MinutesLabel, "MinutesLabel");
            this.MinutesLabel.Name = "MinutesLabel";
            // 
            // Minutes
            // 
            this.Minutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Minutes, "Minutes");
            this.Minutes.Name = "Minutes";
            this.Minutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeVal_KeyPress);
            // 
            // MilliSecondsLabel
            // 
            resources.ApplyResources(this.MilliSecondsLabel, "MilliSecondsLabel");
            this.MilliSecondsLabel.Name = "MilliSecondsLabel";
            // 
            // MilliSeconds
            // 
            this.MilliSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.MilliSeconds, "MilliSeconds");
            this.MilliSeconds.Name = "MilliSeconds";
            this.MilliSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeVal_KeyPress);
            // 
            // SecondsLabel
            // 
            resources.ApplyResources(this.SecondsLabel, "SecondsLabel");
            this.SecondsLabel.Name = "SecondsLabel";
            // 
            // Seconds
            // 
            this.Seconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Seconds, "Seconds");
            this.Seconds.Name = "Seconds";
            this.Seconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeVal_KeyPress);
            // 
            // ClicksPerCycleRender
            // 
            resources.ApplyResources(this.ClicksPerCycleRender, "ClicksPerCycleRender");
            this.ClicksPerCycleRender.Name = "ClicksPerCycleRender";
            // 
            // ClicksPerRender
            // 
            this.ClicksPerRender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ClicksPerRender, "ClicksPerRender");
            this.ClicksPerRender.Name = "ClicksPerRender";
            this.ClicksPerRender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeVal_KeyPress);
            // 
            // SpecifiedLocationBox
            // 
            resources.ApplyResources(this.SpecifiedLocationBox, "SpecifiedLocationBox");
            this.SpecifiedLocationBox.Name = "SpecifiedLocationBox";
            this.SpecifiedLocationBox.UseVisualStyleBackColor = true;
            this.SpecifiedLocationBox.CheckedChanged += new System.EventHandler(this.SpecifiedLocationBox_CheckedChanged);
            // 
            // PickLocation
            // 
            this.PickLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.PickLocation, "PickLocation");
            this.PickLocation.Name = "PickLocation";
            this.PickLocation.UseVisualStyleBackColor = true;
            this.PickLocation.Click += new System.EventHandler(this.PickLocation_Click);
            // 
            // RepeatUntilStoppedCheckbox
            // 
            resources.ApplyResources(this.RepeatUntilStoppedCheckbox, "RepeatUntilStoppedCheckbox");
            this.RepeatUntilStoppedCheckbox.Name = "RepeatUntilStoppedCheckbox";
            this.RepeatUntilStoppedCheckbox.UseVisualStyleBackColor = true;
            this.RepeatUntilStoppedCheckbox.CheckedChanged += new System.EventHandler(this.RepeatUntilStoppedCheckbox_CheckedChanged);
            // 
            // RepeatsLabel
            // 
            resources.ApplyResources(this.RepeatsLabel, "RepeatsLabel");
            this.RepeatsLabel.Name = "RepeatsLabel";
            // 
            // Repeats
            // 
            this.Repeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Repeats, "Repeats");
            this.Repeats.Name = "Repeats";
            this.Repeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeVal_KeyPress);
            // 
            // Xlbl
            // 
            resources.ApplyResources(this.Xlbl, "Xlbl");
            this.Xlbl.Name = "Xlbl";
            // 
            // X
            // 
            this.X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.X, "X");
            this.X.Name = "X";
            this.X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeVal_KeyPress);
            // 
            // Ylbl
            // 
            resources.ApplyResources(this.Ylbl, "Ylbl");
            this.Ylbl.Name = "Ylbl";
            // 
            // Y
            // 
            this.Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Y, "Y");
            this.Y.Name = "Y";
            this.Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeVal_KeyPress);
            // 
            // TopMostCheck
            // 
            resources.ApplyResources(this.TopMostCheck, "TopMostCheck");
            this.TopMostCheck.Name = "TopMostCheck";
            this.TopMostCheck.UseVisualStyleBackColor = true;
            this.TopMostCheck.CheckedChanged += new System.EventHandler(this.TopMost_CheckedChanged);
            // 
            // Window
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TopMostCheck);
            this.Controls.Add(this.Ylbl);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.Xlbl);
            this.Controls.Add(this.X);
            this.Controls.Add(this.RepeatsLabel);
            this.Controls.Add(this.Repeats);
            this.Controls.Add(this.RepeatUntilStoppedCheckbox);
            this.Controls.Add(this.PickLocation);
            this.Controls.Add(this.SpecifiedLocationBox);
            this.Controls.Add(this.ClicksPerCycleRender);
            this.Controls.Add(this.ClicksPerRender);
            this.Controls.Add(this.MilliSecondsLabel);
            this.Controls.Add(this.MilliSeconds);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.InputType);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Window";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button Delay;
        private System.Windows.Forms.Button InputType;
        private System.Windows.Forms.TextBox Hours;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.TextBox Minutes;
        private System.Windows.Forms.Label MilliSecondsLabel;
        private System.Windows.Forms.TextBox MilliSeconds;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.TextBox Seconds;
        private System.Windows.Forms.Label ClicksPerCycleRender;
        private System.Windows.Forms.TextBox ClicksPerRender;
        private System.Windows.Forms.CheckBox SpecifiedLocationBox;
        private System.Windows.Forms.Button PickLocation;
        private System.Windows.Forms.CheckBox RepeatUntilStoppedCheckbox;
        private System.Windows.Forms.Label RepeatsLabel;
        private System.Windows.Forms.TextBox Repeats;
        private System.Windows.Forms.Label Xlbl;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label Ylbl;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.CheckBox TopMostCheck;
    }
}

