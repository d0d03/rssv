namespace zadatak1
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
            this.lblCrit = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblOutliers = new System.Windows.Forms.Label();
            this.tBoxCrit = new System.Windows.Forms.RichTextBox();
            this.tBoxCurrent = new System.Windows.Forms.RichTextBox();
            this.tBoxOutliers = new System.Windows.Forms.RichTextBox();
            this.btn_start_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCrit
            // 
            this.lblCrit.AutoSize = true;
            this.lblCrit.Location = new System.Drawing.Point(51, 33);
            this.lblCrit.Name = "lblCrit";
            this.lblCrit.Size = new System.Drawing.Size(90, 17);
            this.lblCrit.TabIndex = 0;
            this.lblCrit.Text = "Critical Value";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(51, 125);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(95, 17);
            this.lblCurrent.TabIndex = 1;
            this.lblCurrent.Text = "Current Value";
            // 
            // lblOutliers
            // 
            this.lblOutliers.AutoSize = true;
            this.lblOutliers.Location = new System.Drawing.Point(51, 220);
            this.lblOutliers.Name = "lblOutliers";
            this.lblOutliers.Size = new System.Drawing.Size(57, 17);
            this.lblOutliers.TabIndex = 2;
            this.lblOutliers.Text = "Outliers";
            // 
            // tBoxCrit
            // 
            this.tBoxCrit.Location = new System.Drawing.Point(54, 53);
            this.tBoxCrit.Name = "tBoxCrit";
            this.tBoxCrit.Size = new System.Drawing.Size(238, 42);
            this.tBoxCrit.TabIndex = 3;
            this.tBoxCrit.Text = "";
            this.tBoxCrit.TextChanged += new System.EventHandler(this.tBoxCrit_TextChanged);
            // 
            // tBoxCurrent
            // 
            this.tBoxCurrent.Location = new System.Drawing.Point(54, 145);
            this.tBoxCurrent.Name = "tBoxCurrent";
            this.tBoxCurrent.Size = new System.Drawing.Size(238, 42);
            this.tBoxCurrent.TabIndex = 4;
            this.tBoxCurrent.Text = "";
            // 
            // tBoxOutliers
            // 
            this.tBoxOutliers.Location = new System.Drawing.Point(54, 240);
            this.tBoxOutliers.Name = "tBoxOutliers";
            this.tBoxOutliers.Size = new System.Drawing.Size(238, 42);
            this.tBoxOutliers.TabIndex = 5;
            this.tBoxOutliers.Text = "";
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.Location = new System.Drawing.Point(54, 332);
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(238, 58);
            this.btn_start_stop.TabIndex = 6;
            this.btn_start_stop.Text = "Start";
            this.btn_start_stop.UseVisualStyleBackColor = true;
            this.btn_start_stop.Click += new System.EventHandler(this.btn_start_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.btn_start_stop);
            this.Controls.Add(this.tBoxOutliers);
            this.Controls.Add(this.tBoxCurrent);
            this.Controls.Add(this.tBoxCrit);
            this.Controls.Add(this.lblOutliers);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblCrit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrit;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblOutliers;
        private System.Windows.Forms.RichTextBox tBoxCrit;
        private System.Windows.Forms.RichTextBox tBoxCurrent;
        private System.Windows.Forms.RichTextBox tBoxOutliers;
        private System.Windows.Forms.Button btn_start_stop;
    }
}

