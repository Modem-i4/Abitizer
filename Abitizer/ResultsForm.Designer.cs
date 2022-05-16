namespace Abitizer
{
    partial class ResultsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.logoText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пропоновані вузи та факультети:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 59);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(890, 529);
            this.resultBox.TabIndex = 3;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::Abitizer.Properties.Resources.logo;
            this.logoBox.Location = new System.Drawing.Point(855, 9);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(47, 47);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 4;
            this.logoBox.TabStop = false;
            // 
            // logoText
            // 
            this.logoText.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.logoText.Location = new System.Drawing.Point(757, 15);
            this.logoText.Name = "logoText";
            this.logoText.Size = new System.Drawing.Size(92, 35);
            this.logoText.TabIndex = 5;
            this.logoText.Text = "Abitizer";
            this.logoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.logoText);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ResultsForm";
            this.Text = "Результат опрацювання";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel resultBox;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label logoText;
    }
}