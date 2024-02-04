namespace SQL_iyoruz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ControlBox = new ReaLTaiizor.Controls.ControlBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.SidebarButonu = new System.Windows.Forms.PictureBox();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AnaSayfaButonu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SQLleButonu = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Oracle_Kur_Button = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CıkısButonu = new System.Windows.Forms.Button();
            this.SidebarHareket = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidebarButonu)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ControlBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SidebarButonu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 40);
            this.panel1.TabIndex = 0;
            // 
            // ControlBox
            // 
            this.ControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.ControlBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ControlBox.DefaultLocation = true;
            this.ControlBox.Location = new System.Drawing.Point(967, -1);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(77, 19);
            this.ControlBox.TabIndex = 3;
            this.ControlBox.Text = "controlBoxEdit1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "SQL\'liyoruz V1";
            // 
            // SidebarButonu
            // 
            this.SidebarButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SidebarButonu.Image = ((System.Drawing.Image)(resources.GetObject("SidebarButonu.Image")));
            this.SidebarButonu.Location = new System.Drawing.Point(12, 3);
            this.SidebarButonu.Name = "SidebarButonu";
            this.SidebarButonu.Size = new System.Drawing.Size(32, 31);
            this.SidebarButonu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SidebarButonu.TabIndex = 1;
            this.SidebarButonu.TabStop = false;
            this.SidebarButonu.Click += new System.EventHandler(this.SidebarButonu_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.Sidebar.Controls.Add(this.panel2);
            this.Sidebar.Controls.Add(this.panel4);
            this.Sidebar.Controls.Add(this.panel5);
            this.Sidebar.Controls.Add(this.panel7);
            this.Sidebar.Controls.Add(this.panel8);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Sidebar.Location = new System.Drawing.Point(0, 40);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(230, 530);
            this.Sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 216);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AnaSayfaButonu);
            this.panel4.Location = new System.Drawing.Point(3, 225);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 63);
            this.panel4.TabIndex = 5;
            // 
            // AnaSayfaButonu
            // 
            this.AnaSayfaButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.AnaSayfaButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnaSayfaButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnaSayfaButonu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaSayfaButonu.ForeColor = System.Drawing.Color.White;
            this.AnaSayfaButonu.Image = ((System.Drawing.Image)(resources.GetObject("AnaSayfaButonu.Image")));
            this.AnaSayfaButonu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnaSayfaButonu.Location = new System.Drawing.Point(-7, -4);
            this.AnaSayfaButonu.Name = "AnaSayfaButonu";
            this.AnaSayfaButonu.Size = new System.Drawing.Size(250, 74);
            this.AnaSayfaButonu.TabIndex = 2;
            this.AnaSayfaButonu.Text = "            Ana Sayfa";
            this.AnaSayfaButonu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnaSayfaButonu.UseVisualStyleBackColor = false;
            this.AnaSayfaButonu.Click += new System.EventHandler(this.AnaSayfaButonu_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SQLleButonu);
            this.panel5.Location = new System.Drawing.Point(3, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 63);
            this.panel5.TabIndex = 6;
            // 
            // SQLleButonu
            // 
            this.SQLleButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.SQLleButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SQLleButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SQLleButonu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SQLleButonu.ForeColor = System.Drawing.Color.White;
            this.SQLleButonu.Image = ((System.Drawing.Image)(resources.GetObject("SQLleButonu.Image")));
            this.SQLleButonu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SQLleButonu.Location = new System.Drawing.Point(-7, -6);
            this.SQLleButonu.Name = "SQLleButonu";
            this.SQLleButonu.Size = new System.Drawing.Size(250, 74);
            this.SQLleButonu.TabIndex = 7;
            this.SQLleButonu.Text = "             SQL\'lemeye Başla";
            this.SQLleButonu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SQLleButonu.UseVisualStyleBackColor = false;
            this.SQLleButonu.Click += new System.EventHandler(this.SQLleButonu_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Oracle_Kur_Button);
            this.panel7.Location = new System.Drawing.Point(3, 363);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(227, 63);
            this.panel7.TabIndex = 8;
            // 
            // Oracle_Kur_Button
            // 
            this.Oracle_Kur_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.Oracle_Kur_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Oracle_Kur_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Oracle_Kur_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Oracle_Kur_Button.ForeColor = System.Drawing.Color.White;
            this.Oracle_Kur_Button.Image = ((System.Drawing.Image)(resources.GetObject("Oracle_Kur_Button.Image")));
            this.Oracle_Kur_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Oracle_Kur_Button.Location = new System.Drawing.Point(-7, -5);
            this.Oracle_Kur_Button.Name = "Oracle_Kur_Button";
            this.Oracle_Kur_Button.Size = new System.Drawing.Size(250, 74);
            this.Oracle_Kur_Button.TabIndex = 8;
            this.Oracle_Kur_Button.Text = "             Oracle Kurulumu";
            this.Oracle_Kur_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Oracle_Kur_Button.UseVisualStyleBackColor = false;
            this.Oracle_Kur_Button.Click += new System.EventHandler(this.Oracle_Kur_Button_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.CıkısButonu);
            this.panel8.Location = new System.Drawing.Point(3, 432);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(227, 63);
            this.panel8.TabIndex = 7;
            // 
            // CıkısButonu
            // 
            this.CıkısButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.CıkısButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CıkısButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CıkısButonu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CıkısButonu.ForeColor = System.Drawing.Color.White;
            this.CıkısButonu.Image = ((System.Drawing.Image)(resources.GetObject("CıkısButonu.Image")));
            this.CıkısButonu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CıkısButonu.Location = new System.Drawing.Point(-7, -5);
            this.CıkısButonu.Name = "CıkısButonu";
            this.CıkısButonu.Size = new System.Drawing.Size(250, 74);
            this.CıkısButonu.TabIndex = 7;
            this.CıkısButonu.Text = "             Çıkış";
            this.CıkısButonu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CıkısButonu.UseVisualStyleBackColor = false;
            this.CıkısButonu.Click += new System.EventHandler(this.CıkısButonu_Click);
            // 
            // SidebarHareket
            // 
            this.SidebarHareket.Interval = 10;
            this.SidebarHareket.Tick += new System.EventHandler(this.SidebarHareket_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1030, 570);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(39)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL\'liyoruz V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidebarButonu)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox SidebarButonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Button AnaSayfaButonu;
        private System.Windows.Forms.Button SQLleButonu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CıkısButonu;
        private System.Windows.Forms.Timer SidebarHareket;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Oracle_Kur_Button;
        private System.Windows.Forms.Panel panel8;
        private ReaLTaiizor.Controls.ControlBoxEdit ControlBox;
    }
}

