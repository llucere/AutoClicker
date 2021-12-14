namespace AutoClicker
{
    partial class HintMain
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
            this.Label = new System.Windows.Forms.Label();
            this.Coords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label.Location = new System.Drawing.Point(3, 1);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(134, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "Press CTRL/LMB to select";
            // 
            // Coords
            // 
            this.Coords.AutoSize = true;
            this.Coords.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Coords.Location = new System.Drawing.Point(3, 14);
            this.Coords.Name = "Coords";
            this.Coords.Size = new System.Drawing.Size(44, 13);
            this.Coords.TabIndex = 1;
            this.Coords.Text = "0px 0px";
            // 
            // HintMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 28);
            this.Controls.Add(this.Coords);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HintMain";
            this.Text = "Hint";
            this.Load += new System.EventHandler(this.HintMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Coords;
    }
}