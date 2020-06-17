namespace zadatak2
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
            this.lblTime = new System.Windows.Forms.Label();
            this.bntAlarm = new System.Windows.Forms.Button();
            this.nUDHours = new System.Windows.Forms.NumericUpDown();
            this.nUDMinutes = new System.Windows.Forms.NumericUpDown();
            this.nUDSeconds = new System.Windows.Forms.NumericUpDown();
            this.gbRadioBtns = new System.Windows.Forms.GroupBox();
            this.radioBtnPM = new System.Windows.Forms.RadioButton();
            this.radioBtnAM = new System.Windows.Forms.RadioButton();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSeconds)).BeginInit();
            this.gbRadioBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.Location = new System.Drawing.Point(23, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(148, 63);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            // 
            // bntAlarm
            // 
            this.bntAlarm.Location = new System.Drawing.Point(306, 150);
            this.bntAlarm.Name = "bntAlarm";
            this.bntAlarm.Size = new System.Drawing.Size(150, 45);
            this.bntAlarm.TabIndex = 1;
            this.bntAlarm.Text = "Set Alarm";
            this.bntAlarm.UseVisualStyleBackColor = true;
            this.bntAlarm.Click += new System.EventHandler(this.bntAlarm_Click);
            // 
            // nUDHours
            // 
            this.nUDHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nUDHours.Location = new System.Drawing.Point(12, 150);
            this.nUDHours.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nUDHours.Name = "nUDHours";
            this.nUDHours.Size = new System.Drawing.Size(70, 45);
            this.nUDHours.TabIndex = 2;
            // 
            // nUDMinutes
            // 
            this.nUDMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nUDMinutes.Location = new System.Drawing.Point(88, 150);
            this.nUDMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nUDMinutes.Name = "nUDMinutes";
            this.nUDMinutes.Size = new System.Drawing.Size(70, 45);
            this.nUDMinutes.TabIndex = 3;
            // 
            // nUDSeconds
            // 
            this.nUDSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nUDSeconds.Location = new System.Drawing.Point(164, 150);
            this.nUDSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nUDSeconds.Name = "nUDSeconds";
            this.nUDSeconds.Size = new System.Drawing.Size(70, 45);
            this.nUDSeconds.TabIndex = 4;
            // 
            // gbRadioBtns
            // 
            this.gbRadioBtns.Controls.Add(this.radioBtnPM);
            this.gbRadioBtns.Controls.Add(this.radioBtnAM);
            this.gbRadioBtns.Location = new System.Drawing.Point(240, 135);
            this.gbRadioBtns.Name = "gbRadioBtns";
            this.gbRadioBtns.Size = new System.Drawing.Size(63, 73);
            this.gbRadioBtns.TabIndex = 5;
            this.gbRadioBtns.TabStop = false;
            // 
            // radioBtnPM
            // 
            this.radioBtnPM.AutoSize = true;
            this.radioBtnPM.Location = new System.Drawing.Point(6, 42);
            this.radioBtnPM.Name = "radioBtnPM";
            this.radioBtnPM.Size = new System.Drawing.Size(49, 21);
            this.radioBtnPM.TabIndex = 1;
            this.radioBtnPM.Text = "PM";
            this.radioBtnPM.UseVisualStyleBackColor = true;
            // 
            // radioBtnAM
            // 
            this.radioBtnAM.AutoSize = true;
            this.radioBtnAM.Checked = true;
            this.radioBtnAM.Location = new System.Drawing.Point(6, 15);
            this.radioBtnAM.Name = "radioBtnAM";
            this.radioBtnAM.Size = new System.Drawing.Size(49, 21);
            this.radioBtnAM.TabIndex = 0;
            this.radioBtnAM.TabStop = true;
            this.radioBtnAM.Text = "AM";
            this.radioBtnAM.UseVisualStyleBackColor = true;
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAlarm.Location = new System.Drawing.Point(12, 118);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(106, 29);
            this.lblAlarm.TabIndex = 6;
            this.lblAlarm.Text = "lblAlarm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "lbl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.gbRadioBtns);
            this.Controls.Add(this.nUDSeconds);
            this.Controls.Add(this.nUDMinutes);
            this.Controls.Add(this.nUDHours);
            this.Controls.Add(this.bntAlarm);
            this.Controls.Add(this.lblTime);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUDHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSeconds)).EndInit();
            this.gbRadioBtns.ResumeLayout(false);
            this.gbRadioBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button bntAlarm;
        private System.Windows.Forms.NumericUpDown nUDHours;
        private System.Windows.Forms.NumericUpDown nUDMinutes;
        private System.Windows.Forms.NumericUpDown nUDSeconds;
        private System.Windows.Forms.GroupBox gbRadioBtns;
        private System.Windows.Forms.RadioButton radioBtnPM;
        private System.Windows.Forms.RadioButton radioBtnAM;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label label1;
    }
}

