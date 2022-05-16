
namespace Abitizer
{
    partial class FacultyBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uniNameLabel = new System.Windows.Forms.Label();
            this.specialityLabel = new System.Windows.Forms.Label();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uniNameLabel
            // 
            this.uniNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uniNameLabel.Location = new System.Drawing.Point(16, 55);
            this.uniNameLabel.Name = "uniNameLabel";
            this.uniNameLabel.Size = new System.Drawing.Size(734, 36);
            this.uniNameLabel.TabIndex = 0;
            this.uniNameLabel.Text = "label1";
            this.uniNameLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // specialityLabel
            // 
            this.specialityLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specialityLabel.Location = new System.Drawing.Point(16, 10);
            this.specialityLabel.Name = "specialityLabel";
            this.specialityLabel.Size = new System.Drawing.Size(734, 36);
            this.specialityLabel.TabIndex = 0;
            this.specialityLabel.Text = "label1";
            this.specialityLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accuracyLabel.Location = new System.Drawing.Point(746, 10);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(129, 71);
            this.accuracyLabel.TabIndex = 0;
            this.accuracyLabel.Text = "99%";
            this.accuracyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accuracyLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // FacultyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.accuracyLabel);
            this.Controls.Add(this.specialityLabel);
            this.Controls.Add(this.uniNameLabel);
            this.Name = "FacultyBox";
            this.Size = new System.Drawing.Size(890, 91);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uniNameLabel;
        private System.Windows.Forms.Label specialityLabel;
        private System.Windows.Forms.Label accuracyLabel;
    }
}
