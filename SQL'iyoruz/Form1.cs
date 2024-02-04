using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SQL_iyoruz
{
    public partial class Form1 : Form
    {
        FormAnasayfa anasayfa;
        FormSQL sqlform;
        public Form1()
        {
            InitializeComponent();
            mdiProp(); //Form yapısı ayarlarını tutan sınıf nesnesi
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            if (anasayfa == null) //Program açıldığında Anasayfa formunu yükle
            {
                anasayfa = new FormAnasayfa();
                anasayfa.FormClosed += anasayfa_FormKapat;
                anasayfa.MdiParent = this;
                anasayfa.Dock = DockStyle.Fill;
                anasayfa.Show();
            }
            else
            {
                anasayfa.Activate();
            }

        }

        bool SidebarAnimasyon = true;
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void SidebarHareket_Tick(object sender, EventArgs e) //Menü animasyonu çalıştıran metot
        {
            if (SidebarAnimasyon)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width <= 56)
                {
                    SidebarAnimasyon = false;
                    SidebarHareket.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width >= 230)
                {
                    SidebarAnimasyon = true;
                    SidebarHareket.Stop();
                }
            }
        }

        private void SidebarButonu_Click(object sender, EventArgs e) //Menü butonu
        {
            SidebarHareket.Start();
        }

        private void AnaSayfaButonu_Click(object sender, EventArgs e) //Anasayfa butonu
        {
            if (anasayfa == null)
            {
                anasayfa = new FormAnasayfa();
                anasayfa.FormClosed += anasayfa_FormKapat;
                anasayfa.MdiParent = this;
                anasayfa.Dock = DockStyle.Fill;
                anasayfa.Show();
            }
            else
            {
                anasayfa.Activate();
            }
        }

        private void anasayfa_FormKapat(object sender, FormClosedEventArgs e)
        {
            anasayfa = null;
        }

        private void SQLleButonu_Click(object sender, EventArgs e) //SQL'lemeye Başla butonu
        {

            if (sqlform == null)
            {
                sqlform = new FormSQL();
                sqlform.FormClosed += sqlform_FormKapat;
                sqlform.MdiParent = this;
                sqlform.Dock = DockStyle.Fill;
                sqlform.Show();

            }

            else
            {
                sqlform.Activate();
            }
        }

        private void sqlform_FormKapat(object sender, FormClosedEventArgs e)
        {
            sqlform = null;
        }

        private void Oracle_Kur_Button_Click(object sender, EventArgs e) //Oracle kurmaya başla butonu
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://ybskulubu.cumhuriyet.edu.tr/docker-ile-oracle-database-nasil-kurulur/");
            Process.Start(sInfo);
        }

        private void CıkısButonu_Click(object sender, EventArgs e) //Programdan çıkış butonu
        {
            MessageBox.Show("SQL'liyoruz uygulamasını kullandığınız için teşekkürler. Güncellemeler yakında...", "ÇIKIŞ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }


    }
}
