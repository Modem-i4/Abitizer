
namespace Abitizer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.logoText = new System.Windows.Forms.Label();
            this.pointsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.schoolLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.schoolNUD = new System.Windows.Forms.NumericUpDown();
            this.ukrNUD = new System.Windows.Forms.NumericUpDown();
            this.mathNUD = new System.Windows.Forms.NumericUpDown();
            this.histiryNUD = new System.Windows.Forms.NumericUpDown();
            this.geographyNUD = new System.Windows.Forms.NumericUpDown();
            this.englishNUD = new System.Windows.Forms.NumericUpDown();
            this.foreignNUD = new System.Windows.Forms.NumericUpDown();
            this.physicsNUD = new System.Windows.Forms.NumericUpDown();
            this.biologyNUD = new System.Windows.Forms.NumericUpDown();
            this.chemestryNUD = new System.Windows.Forms.NumericUpDown();
            this.startBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.pointsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukrNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histiryNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geographyNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreignNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biologyNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemestryNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Image = global::Abitizer.Properties.Resources.logo;
            this.logoBox.Location = new System.Drawing.Point(226, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(150, 150);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // logoText
            // 
            this.logoText.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.logoText.Location = new System.Drawing.Point(223, 168);
            this.logoText.Name = "logoText";
            this.logoText.Size = new System.Drawing.Size(153, 35);
            this.logoText.TabIndex = 1;
            this.logoText.Text = "Abitizer";
            this.logoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointsGroupBox
            // 
            this.pointsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.pointsGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointsGroupBox.Location = new System.Drawing.Point(11, 195);
            this.pointsGroupBox.Name = "pointsGroupBox";
            this.pointsGroupBox.Size = new System.Drawing.Size(549, 381);
            this.pointsGroupBox.TabIndex = 2;
            this.pointsGroupBox.TabStop = false;
            this.pointsGroupBox.Text = "Бали";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.36467F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63533F));
            this.tableLayoutPanel1.Controls.Add(this.schoolLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.schoolNUD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ukrNUD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mathNUD, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.histiryNUD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.geographyNUD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.englishNUD, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.foreignNUD, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.physicsNUD, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.biologyNUD, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.chemestryNUD, 1, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // schoolLabel
            // 
            this.schoolLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schoolLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.schoolLabel.Location = new System.Drawing.Point(3, 0);
            this.schoolLabel.Name = "schoolLabel";
            this.schoolLabel.Size = new System.Drawing.Size(381, 34);
            this.schoolLabel.TabIndex = 1;
            this.schoolLabel.Text = "Бал атестата";
            this.schoolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Українська мова та література";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Математика";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Історія України";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(381, 34);
            this.label5.TabIndex = 1;
            this.label5.Text = "Географія";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 34);
            this.label6.TabIndex = 1;
            this.label6.Text = "Англійська мова";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(381, 34);
            this.label7.TabIndex = 1;
            this.label7.Text = "Інша іноземна мова";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(381, 34);
            this.label8.TabIndex = 1;
            this.label8.Text = "Фізика";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(381, 34);
            this.label9.TabIndex = 1;
            this.label9.Text = "Біологія";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(381, 43);
            this.label10.TabIndex = 1;
            this.label10.Text = "Хімія";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // schoolNUD
            // 
            this.schoolNUD.DecimalPlaces = 1;
            this.schoolNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schoolNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.schoolNUD.Location = new System.Drawing.Point(390, 3);
            this.schoolNUD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.schoolNUD.Name = "schoolNUD";
            this.schoolNUD.Size = new System.Drawing.Size(143, 30);
            this.schoolNUD.TabIndex = 2;
            this.schoolNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.schoolNUD.Enter += new System.EventHandler(this.NUD_SelectAll);
            this.schoolNUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUD_KeyPress);
            this.schoolNUD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_SelectAll);
            // 
            // ukrNUD
            // 
            this.ukrNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ukrNUD.Location = new System.Drawing.Point(390, 37);
            this.ukrNUD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ukrNUD.Name = "ukrNUD";
            this.ukrNUD.Size = new System.Drawing.Size(143, 30);
            this.ukrNUD.TabIndex = 2;
            this.ukrNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ukrNUD.Enter += new System.EventHandler(this.NUD_SelectAll);
            this.ukrNUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUD_KeyPress);
            this.ukrNUD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_SelectAll);
            // 
            // mathNUD
            // 
            this.mathNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mathNUD.Location = new System.Drawing.Point(390, 71);
            this.mathNUD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.mathNUD.Name = "mathNUD";
            this.mathNUD.Size = new System.Drawing.Size(143, 30);
            this.mathNUD.TabIndex = 2;
            this.mathNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mathNUD.Enter += new System.EventHandler(this.NUD_SelectAll);
            this.mathNUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUD_KeyPress);
            this.mathNUD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_SelectAll);
            // 
            // histiryNUD
            // 
            this.histiryNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histiryNUD.Location = new System.Drawing.Point(390, 105);
            this.histiryNUD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.histiryNUD.Name = "histiryNUD";
            this.histiryNUD.Size = new System.Drawing.Size(143, 30);
            this.histiryNUD.TabIndex = 2;
            this.histiryNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.histiryNUD.Enter += new System.EventHandler(this.NUD_SelectAll);
            this.histiryNUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUD_KeyPress);
            this.histiryNUD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_SelectAll);
            // 
            // geographyNUD
            // 
            this.geographyNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geographyNUD.Location = new System.Drawing.Point(390, 139);
            this.geographyNUD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.geographyNUD.Name = "geographyNUD";
            this.geographyNUD.Size = new System.Drawing.Size(143, 30);
            this.geographyNUD.TabIndex = 2;
            this.geographyNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.geographyNUD.Enter += new System.EventHandler(this.NUD_SelectAll);
            this.geographyNUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUD_KeyPress);
            this.geographyNUD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_SelectAll);
            // 
            // englishNUD
            // 
            this.englishNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.englishNUD.Location = new System.Drawing.Point(390, 173);
            this.englishNUD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.englishNUD.Name = "englishNUD";
            this.englishNUD.Size = new System.Drawing.Size(143, 30);
            this.englishNUD.TabIndex = 2;
            this.englishNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.englishNUD.Enter += new System.EventHandler(this.NUD_SelectAll);
            this.englishNUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUD_KeyPress);
            this.englishNUD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_SelectAll);
            // 
            // foreignNUD
            // 
            this.foreignNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foreignNUD.Location = new System.Drawing.Point(390, 207);
            this.foreignNUD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.foreignNUD.Name = "foreignNUD";
            this.foreignNUD.Size = new System.Drawing.Size(143, 30);
            this.foreignNUD.TabIndex = 2;
            this.foreignNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.foreignNUD.Enter += new System.EventHandler(this.NUD_SelectAll);
            this.foreignNUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUD_KeyPress);
            this.foreignNUD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_SelectAll);
            // 
            // physicsNUD
            // 
            this.physicsNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physicsNUD.Location = new System.Drawing.Point(390, 241);
            this.physicsNUD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.physicsNUD.Name = "physicsNUD";
            this.physicsNUD.Size = new System.Drawing.Size(143, 30);
            this.physicsNUD.TabIndex = 2;
            this.physicsNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.physicsNUD.Enter += new System.EventHandler(this.NUD_SelectAll);
            this.physicsNUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUD_KeyPress);
            this.physicsNUD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_SelectAll);
            // 
            // biologyNUD
            // 
            this.biologyNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biologyNUD.Location = new System.Drawing.Point(390, 275);
            this.biologyNUD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.biologyNUD.Name = "biologyNUD";
            this.biologyNUD.Size = new System.Drawing.Size(143, 30);
            this.biologyNUD.TabIndex = 2;
            this.biologyNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.biologyNUD.Enter += new System.EventHandler(this.NUD_SelectAll);
            this.biologyNUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUD_KeyPress);
            this.biologyNUD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_SelectAll);
            // 
            // chemestryNUD
            // 
            this.chemestryNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chemestryNUD.Location = new System.Drawing.Point(390, 309);
            this.chemestryNUD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.chemestryNUD.Name = "chemestryNUD";
            this.chemestryNUD.Size = new System.Drawing.Size(143, 30);
            this.chemestryNUD.TabIndex = 2;
            this.chemestryNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chemestryNUD.Enter += new System.EventHandler(this.NUD_SelectAll);
            this.chemestryNUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUD_KeyPress);
            this.chemestryNUD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUD_SelectAll);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBtn.Location = new System.Drawing.Point(24, 592);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(526, 52);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Рекомендувати!";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 656);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.pointsGroupBox);
            this.Controls.Add(this.logoText);
            this.Controls.Add(this.logoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Abitizer";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.pointsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schoolNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukrNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histiryNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geographyNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreignNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biologyNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemestryNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label logoText;
        private System.Windows.Forms.GroupBox pointsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label schoolLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown schoolNUD;
        private System.Windows.Forms.NumericUpDown ukrNUD;
        private System.Windows.Forms.NumericUpDown mathNUD;
        private System.Windows.Forms.NumericUpDown histiryNUD;
        private System.Windows.Forms.NumericUpDown geographyNUD;
        private System.Windows.Forms.NumericUpDown englishNUD;
        private System.Windows.Forms.NumericUpDown foreignNUD;
        private System.Windows.Forms.NumericUpDown physicsNUD;
        private System.Windows.Forms.NumericUpDown biologyNUD;
        private System.Windows.Forms.NumericUpDown chemestryNUD;
        private System.Windows.Forms.Button startBtn;
    }
}

