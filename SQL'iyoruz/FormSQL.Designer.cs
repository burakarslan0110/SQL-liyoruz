namespace SQL_iyoruz
{
    partial class FormSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSQL));
            this.CevapButton = new ReaLTaiizor.Controls.Button();
            this.CevapBox = new System.Windows.Forms.TextBox();
            this.SoruBox = new System.Windows.Forms.TextBox();
            this.SoruGroupBox = new System.Windows.Forms.GroupBox();
            this.CevapgroupBox = new System.Windows.Forms.GroupBox();
            this.SemaBox1 = new System.Windows.Forms.PictureBox();
            this.BilgiButton = new ReaLTaiizor.Controls.Button();
            this.SoruGroupBox.SuspendLayout();
            this.CevapgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SemaBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CevapButton
            // 
            this.CevapButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CevapButton.BackColor = System.Drawing.Color.Transparent;
            this.CevapButton.BorderColor = System.Drawing.Color.Transparent;
            this.CevapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CevapButton.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.CevapButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.CevapButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CevapButton.Image = null;
            this.CevapButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CevapButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.CevapButton.Location = new System.Drawing.Point(83, 445);
            this.CevapButton.MaximumSize = new System.Drawing.Size(220, 50);
            this.CevapButton.MinimumSize = new System.Drawing.Size(120, 50);
            this.CevapButton.Name = "CevapButton";
            this.CevapButton.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.CevapButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.CevapButton.Size = new System.Drawing.Size(120, 50);
            this.CevapButton.TabIndex = 8;
            this.CevapButton.Text = "Cevapla";
            this.CevapButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CevapButton.Click += new System.EventHandler(this.CevapButton_Click);
            // 
            // CevapBox
            // 
            this.CevapBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CevapBox.BackColor = System.Drawing.Color.White;
            this.CevapBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CevapBox.Location = new System.Drawing.Point(5, 34);
            this.CevapBox.MinimumSize = new System.Drawing.Size(314, 150);
            this.CevapBox.Multiline = true;
            this.CevapBox.Name = "CevapBox";
            this.CevapBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CevapBox.Size = new System.Drawing.Size(314, 150);
            this.CevapBox.TabIndex = 6;
            this.CevapBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CevapBox_KeyDown);
            // 
            // SoruBox
            // 
            this.SoruBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoruBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoruBox.Enabled = false;
            this.SoruBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoruBox.Location = new System.Drawing.Point(5, 33);
            this.SoruBox.MinimumSize = new System.Drawing.Size(314, 104);
            this.SoruBox.Multiline = true;
            this.SoruBox.Name = "SoruBox";
            this.SoruBox.ReadOnly = true;
            this.SoruBox.Size = new System.Drawing.Size(314, 160);
            this.SoruBox.TabIndex = 4;
            // 
            // SoruGroupBox
            // 
            this.SoruGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoruGroupBox.Controls.Add(this.SoruBox);
            this.SoruGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoruGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.SoruGroupBox.Location = new System.Drawing.Point(12, 20);
            this.SoruGroupBox.MaximumSize = new System.Drawing.Size(425, 143);
            this.SoruGroupBox.MinimumSize = new System.Drawing.Size(325, 200);
            this.SoruGroupBox.Name = "SoruGroupBox";
            this.SoruGroupBox.Size = new System.Drawing.Size(325, 200);
            this.SoruGroupBox.TabIndex = 9;
            this.SoruGroupBox.TabStop = false;
            this.SoruGroupBox.Text = "Sorular";
            // 
            // CevapgroupBox
            // 
            this.CevapgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CevapgroupBox.Controls.Add(this.CevapBox);
            this.CevapgroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CevapgroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.CevapgroupBox.Location = new System.Drawing.Point(12, 237);
            this.CevapgroupBox.MaximumSize = new System.Drawing.Size(425, 250);
            this.CevapgroupBox.MinimumSize = new System.Drawing.Size(325, 190);
            this.CevapgroupBox.Name = "CevapgroupBox";
            this.CevapgroupBox.Size = new System.Drawing.Size(325, 190);
            this.CevapgroupBox.TabIndex = 10;
            this.CevapgroupBox.TabStop = false;
            this.CevapgroupBox.Text = "Cevaplar";
            // 
            // SemaBox1
            // 
            this.SemaBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SemaBox1.Image = ((System.Drawing.Image)(resources.GetObject("SemaBox1.Image")));
            this.SemaBox1.Location = new System.Drawing.Point(346, -32);
            this.SemaBox1.Name = "SemaBox1";
            this.SemaBox1.Size = new System.Drawing.Size(463, 489);
            this.SemaBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SemaBox1.TabIndex = 11;
            this.SemaBox1.TabStop = false;
            // 
            // BilgiButton
            // 
            this.BilgiButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BilgiButton.BackColor = System.Drawing.Color.Transparent;
            this.BilgiButton.BorderColor = System.Drawing.Color.Transparent;
            this.BilgiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BilgiButton.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.BilgiButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.BilgiButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BilgiButton.Image = ((System.Drawing.Image)(resources.GetObject("BilgiButton.Image")));
            this.BilgiButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BilgiButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.BilgiButton.Location = new System.Drawing.Point(217, 445);
            this.BilgiButton.Name = "BilgiButton";
            this.BilgiButton.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.BilgiButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.BilgiButton.Size = new System.Drawing.Size(50, 50);
            this.BilgiButton.TabIndex = 12;
            this.BilgiButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BilgiButton.Click += new System.EventHandler(this.BilgiButton_Click);
            // 
            // FormSQL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(790, 500);
            this.Controls.Add(this.BilgiButton);
            this.Controls.Add(this.SemaBox1);
            this.Controls.Add(this.CevapgroupBox);
            this.Controls.Add(this.CevapButton);
            this.Controls.Add(this.SoruGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(790, 500);
            this.Name = "FormSQL";
            this.Text = "FormSQL";
            this.Load += new System.EventHandler(this.FormSQL_Load);
            this.SoruGroupBox.ResumeLayout(false);
            this.SoruGroupBox.PerformLayout();
            this.CevapgroupBox.ResumeLayout(false);
            this.CevapgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SemaBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.Button CevapButton;
        private System.Windows.Forms.TextBox CevapBox;
        private System.Windows.Forms.TextBox SoruBox;
        private System.Windows.Forms.GroupBox SoruGroupBox;
        private System.Windows.Forms.GroupBox CevapgroupBox;
        private System.Windows.Forms.PictureBox SemaBox1;
        private ReaLTaiizor.Controls.Button BilgiButton;
    }
}