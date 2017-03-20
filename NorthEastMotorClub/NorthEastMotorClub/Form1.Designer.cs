namespace NorthEastMotorClub
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
            this.lblDriverNames = new System.Windows.Forms.Label();
            this.lstDrivers = new System.Windows.Forms.ListBox();
            this.driverTimer = new System.Windows.Forms.Timer(this.components);
            this.btnComplete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblListDriver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDriverNames
            // 
            this.lblDriverNames.AutoSize = true;
            this.lblDriverNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverNames.Location = new System.Drawing.Point(12, 9);
            this.lblDriverNames.Name = "lblDriverNames";
            this.lblDriverNames.Size = new System.Drawing.Size(65, 20);
            this.lblDriverNames.TabIndex = 0;
            this.lblDriverNames.Text = "Drivers";
            // 
            // lstDrivers
            // 
            this.lstDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDrivers.FormattingEnabled = true;
            this.lstDrivers.Location = new System.Drawing.Point(16, 32);
            this.lstDrivers.Name = "lstDrivers";
            this.lstDrivers.Size = new System.Drawing.Size(339, 134);
            this.lstDrivers.TabIndex = 1;
            this.lstDrivers.SelectedIndexChanged += new System.EventHandler(this.lstDrivers_SelectedIndexChanged);
            // 
            // driverTimer
            // 
            this.driverTimer.Enabled = true;
            this.driverTimer.Interval = 1000;
            this.driverTimer.Tick += new System.EventHandler(this.driverTimer_Tick);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(377, 32);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(128, 36);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Text = "Finish Race";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "No. of drivers finished:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(248, 182);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(64, 16);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "00:00:00";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(313, 227);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(13, 13);
            this.lblFinish.TabIndex = 6;
            this.lblFinish.Text = "0";
            this.lblFinish.Click += new System.EventHandler(this.lblFinish_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time Taken:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Miles Completed:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(86, 205);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 13);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Not Finished";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(106, 227);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(77, 13);
            this.lblMiles.TabIndex = 11;
            this.lblMiles.Text = "Not Completed";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(377, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 34);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Driver:";
            // 
            // lblListDriver
            // 
            this.lblListDriver.AutoSize = true;
            this.lblListDriver.Location = new System.Drawing.Point(57, 182);
            this.lblListDriver.Name = "lblListDriver";
            this.lblListDriver.Size = new System.Drawing.Size(0, 13);
            this.lblListDriver.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 262);
            this.Controls.Add(this.lblListDriver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lstDrivers);
            this.Controls.Add(this.lblDriverNames);
            this.Name = "Form1";
            this.Text = "North East Motor Club";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriverNames;
        private System.Windows.Forms.ListBox lstDrivers;
        private System.Windows.Forms.Timer driverTimer;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblListDriver;
    }
}

