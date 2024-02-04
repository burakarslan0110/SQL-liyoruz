namespace SQL_iyoruz
{
    partial class FormAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnasayfa));
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CozulenSoruLabel = new System.Windows.Forms.Label();
            this.YanlisLabel = new System.Windows.Forms.Label();
            this.DogruLabel = new System.Windows.Forms.Label();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.GitHubBox = new System.Windows.Forms.PictureBox();
            this.LinkedInBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkedInBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.bigLabel1.Location = new System.Drawing.Point(41, -6);
            this.bigLabel1.MinimumSize = new System.Drawing.Size(346, 81);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(724, 81);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "SQL\'liyoruz ";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.CozulenSoruLabel);
            this.groupBox1.Controls.Add(this.YanlisLabel);
            this.groupBox1.Controls.Add(this.DogruLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.groupBox1.Location = new System.Drawing.Point(246, 303);
            this.groupBox1.MaximumSize = new System.Drawing.Size(350, 180);
            this.groupBox1.MinimumSize = new System.Drawing.Size(330, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 180);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Özet";
            // 
            // CozulenSoruLabel
            // 
            this.CozulenSoruLabel.AutoSize = true;
            this.CozulenSoruLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CozulenSoruLabel.Location = new System.Drawing.Point(6, 32);
            this.CozulenSoruLabel.Name = "CozulenSoruLabel";
            this.CozulenSoruLabel.Size = new System.Drawing.Size(312, 38);
            this.CozulenSoruLabel.TabIndex = 2;
            this.CozulenSoruLabel.Text = "Toplam Soru Sayısı: 25";
            this.CozulenSoruLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // YanlisLabel
            // 
            this.YanlisLabel.AutoSize = true;
            this.YanlisLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YanlisLabel.Location = new System.Drawing.Point(6, 124);
            this.YanlisLabel.Name = "YanlisLabel";
            this.YanlisLabel.Size = new System.Drawing.Size(205, 38);
            this.YanlisLabel.TabIndex = 1;
            this.YanlisLabel.Text = "Yanlış Sayısı: 0";
            this.YanlisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DogruLabel
            // 
            this.DogruLabel.AutoSize = true;
            this.DogruLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DogruLabel.Location = new System.Drawing.Point(6, 77);
            this.DogruLabel.Name = "DogruLabel";
            this.DogruLabel.Size = new System.Drawing.Size(214, 38);
            this.DogruLabel.TabIndex = 0;
            this.DogruLabel.Text = "Doğru Sayısı: 0";
            this.DogruLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.Black;
            this.dungeonLabel1.Location = new System.Drawing.Point(35, 65);
            this.dungeonLabel1.MinimumSize = new System.Drawing.Size(730, 93);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(730, 93);
            this.dungeonLabel1.TabIndex = 11;
            this.dungeonLabel1.Text = "SQL\'liyoruz, çeşitli sorularla temel düzeyde SQL pratiği yapmanızı sağlayan bir p" +
    "roje. \r\nGeliştiren: BURAK ARSLAN";
            this.dungeonLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dungeonLabel2.ForeColor = System.Drawing.Color.Black;
            this.dungeonLabel2.Location = new System.Drawing.Point(35, 235);
            this.dungeonLabel2.MinimumSize = new System.Drawing.Size(730, 62);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(730, 62);
            this.dungeonLabel2.TabIndex = 12;
            this.dungeonLabel2.Text = "Soru çözümü için soldaki menüden \"SQL\'lemeye Başla\" butonuna tıklayın.\r\nBu sayfad" +
    "an yaptığınız doğru ve yanlış sayısını görebilirsiniz. \r\n";
            this.dungeonLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GitHubBox
            // 
            this.GitHubBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GitHubBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHubBox.Image = ((System.Drawing.Image)(resources.GetObject("GitHubBox.Image")));
            this.GitHubBox.Location = new System.Drawing.Point(209, 142);
            this.GitHubBox.Name = "GitHubBox";
            this.GitHubBox.Size = new System.Drawing.Size(190, 90);
            this.GitHubBox.TabIndex = 13;
            this.GitHubBox.TabStop = false;
            this.GitHubBox.WaitOnLoad = true;
            this.GitHubBox.Click += new System.EventHandler(this.GitHubBox_Click);
            // 
            // LinkedInBox
            // 
            this.LinkedInBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LinkedInBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkedInBox.Image = ((System.Drawing.Image)(resources.GetObject("LinkedInBox.Image")));
            this.LinkedInBox.Location = new System.Drawing.Point(416, 142);
            this.LinkedInBox.Name = "LinkedInBox";
            this.LinkedInBox.Size = new System.Drawing.Size(190, 90);
            this.LinkedInBox.TabIndex = 14;
            this.LinkedInBox.TabStop = false;
            this.LinkedInBox.WaitOnLoad = true;
            this.LinkedInBox.Click += new System.EventHandler(this.LinkedInBox_Click);
            // 
            // FormAnasayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 500);
            this.Controls.Add(this.LinkedInBox);
            this.Controls.Add(this.GitHubBox);
            this.Controls.Add(this.dungeonLabel2);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAnasayfa";
            this.Text = "FormAnasayfa";
            this.Load += new System.EventHandler(this.FormAnasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkedInBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private System.Windows.Forms.PictureBox GitHubBox;
        private System.Windows.Forms.PictureBox LinkedInBox;
        public System.Windows.Forms.Label YanlisLabel;
        public System.Windows.Forms.Label DogruLabel;
        public System.Windows.Forms.Label CozulenSoruLabel;
    }
}