namespace WorkingHoursTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartStop = new System.Windows.Forms.Button();
            this._totalElapsedTimeDisplay = new System.Windows.Forms.Label();
            this._currentElapsedTimeDisplay = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartStop
            // 
            this.StartStop.Location = new System.Drawing.Point(12, 109);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(238, 44);
            this.StartStop.TabIndex = 0;
            this.StartStop.Text = "Start";
            this.StartStop.UseVisualStyleBackColor = true;
            this.StartStop.Click += new System.EventHandler(this.startButton_Click);
            // 
            // _totalElapsedTimeDisplay
            // 
            this._totalElapsedTimeDisplay.AutoSize = true;
            this._totalElapsedTimeDisplay.Location = new System.Drawing.Point(109, 28);
            this._totalElapsedTimeDisplay.Name = "_totalElapsedTimeDisplay";
            this._totalElapsedTimeDisplay.Size = new System.Drawing.Size(0, 13);
            this._totalElapsedTimeDisplay.TabIndex = 2;
            // 
            // _currentElapsedTimeDisplay
            // 
            this._currentElapsedTimeDisplay.AutoSize = true;
            this._currentElapsedTimeDisplay.Location = new System.Drawing.Point(109, 60);
            this._currentElapsedTimeDisplay.Name = "_currentElapsedTimeDisplay";
            this._currentElapsedTimeDisplay.Size = new System.Drawing.Size(0, 13);
            this._currentElapsedTimeDisplay.TabIndex = 3;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(85, 159);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(94, 31);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Time Elapsed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Shift Time Elapsed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this._currentElapsedTimeDisplay);
            this.Controls.Add(this._totalElapsedTimeDisplay);
            this.Controls.Add(this.StartStop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TimeSheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.Label _totalElapsedTimeDisplay;
        private System.Windows.Forms.Label _currentElapsedTimeDisplay;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

