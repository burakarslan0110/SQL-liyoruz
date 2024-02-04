using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SQL_iyoruz
{
    public partial class FormSQL : Form
    {
        //TXT dosyalarından soru ve cevap çekimi
        StreamReader sro = new StreamReader(@"SSorular.txt",Encoding.UTF8); 
        StreamReader src = new StreamReader(@"SCevaplar.txt", Encoding.UTF8); 

        //Soru ve cevapların tutulacağı List kolleksiyon nesneleri
        List<string> sorulistem = new List<string>();
        List<string> cevaplistem = new List<string>();

        //Değişen tanımlama
        string sorusatir;           //Soruların satırlara bölüneceği değişken
        string cevapsatir;          //Cevapların satırlara bölüneceği değişken
        int SoruSira = 0;           //Soruları gezecek değişken
        int CevapSira = 1;          //Cevapları gezecek değişken
        int DogruCevap = 0;         //Doğru cevap sayısının tutulacağı değişken
        int YanlisCevap = 0;        //Yanlış cevap sayısının tutulacağı değişken
        int CevapGostermeSayac = 1; //Peş peşe üç yanlışı tutan değişken (Doğru cevabı göstermek için)
        bool boscevap = false;      //Cevap kutusuna boş bırakılırsa hata vermek için tutulan değişken


        public FormSQL()
        {
            InitializeComponent();
        }

        private void FormSQL_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            //Soruları ve cevapları TXT dosyalarından çekip özel karakterlere göre parçalayarak list'e atma.
            MessageBox.Show("SQL sorularını sağ tarafta yer alan örnek şemaya göre çözeceksiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            while (!sro.EndOfStream)
            {
                sorusatir = sro.ReadLine();
                sorulistem.AddRange(sorusatir.Split('|'));
            
            }
            sro.Close();
            while (!src.EndOfStream)
            {
                cevapsatir = src.ReadLine();
                cevaplistem.AddRange(cevapsatir.Split('#'));
            }
            src.Close();
            SoruCek(SoruSira); //İlk soruyu çek
            CevapBox.Focus();

        }
        private void SoruCek(int s) //Soru çeken metot
        {
            SoruBox.Text = sorulistem[s];
            SoruSira++;
            CevapBox.Clear();
        }
        private string CevapCek(int s) //Cevap çeken metot
        {
            return cevaplistem[s];
        }
        private bool CevapKontrol(string s, string x) //Cevap kutusuna girilen cevapları doğru cevaplarla karşılaştıran metot
        {
            string s1 = Regex.Replace(s, @"\s+", "").ToLower(); //Doğru cevaplardan tüm boşlukların silinip küçük hafre dönüştürülmesi (karşılaştırmak için)
            string x1 = Regex.Replace(x, @"\s+", "").ToLower(); //Girilen cevaplardan tüm satır atlamaların ve boşlukların silinip küçük hafre dönüştürülmesi (karşılaştırmak için)

            if (s1 == x1) //Cevap doğruysa TRUE döndür
            {
                
                return true;

            }
            else if (String.IsNullOrWhiteSpace(x)) //Cevap boşsa FALSE döndür, boscevap değişkenine FALSE ata
            {
                boscevap = true;
                return false;
            }
            else //Cevap yanlışsa FALSE döndür
            {
                return false;
            }
        }
        private void Cevapİsleme(int s)  //Cevabın doğru veya yanlışlık durumuna göre mesaj kutusu gösteren metot
        {
            if (CevapKontrol(CevapCek(s - 1), CevapBox.Text) == true)
            {
                DogruMesajKutusu(); //Cevap doğruysa doğru mesaj kutusunu göster
                CevapSira++; //Cevap doğruysa cevap değişkenini bir arttır
               

            }
            else if (CevapKontrol(CevapCek(s - 1), CevapBox.Text) == false)
            {
                YanlisMesajKutusu(); //Cevap yanlışsa yanlış mesaj kutusunu göster

            }

        }
        private void DogruMesajKutusu() //Doğru cevap mesaj kutusunu gösteren metot
        {
            MessageBox.Show("Cevabınız doğru. Devam etmek için 'Tamam' butonuna tıklayın.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DogruCevap++; //Cevap doğru olduğundan DogruCevap değişkenini bir arttır
            OzetGuncelle(true); //Anasayfadaki özet tablonun değerini güncelleyen metot (True ise DogruCevap ile güncelle)
            SoruCek(SoruSira); //Cevap doğru olduğundan diğer soruyu çek
            CevapGostermeSayac = 1; //Peş peşe üç yanlış tutan değişkeni varsayılan 1 değerini ata.
            
        }

        private void YanlisMesajKutusu() //Yanlış cevap mesaj kutusunu gösteren metot
        {
            if (boscevap == true) //Cevap kutusu boşsa hata mesajı göster
            {
                MessageBox.Show("Cevap kutucuğu boş olamaz, lütfen tekrar deneyin.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boscevap = false;
            }
            else //cevap yanlışsa
            {
                if (CevapGostermeSayac % 3 == 0) //Peş peşe yanlış sayısı 3'ün katıysa doğru cevabı gösteren mesaj kutusunu göster
                {

                    DialogResult sonuc = MessageBox.Show("Cevabınız yine yanlış, doğru cevabı görmek ister misiniz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (sonuc == DialogResult.Yes) //Kullanıcı doğru cevabı görmek isterse 
                    {
                        CevapBox.Text = CevapCek(CevapSira - 1); //Sorunun doğru cevabını cevap kutusuna çek
                        CevapGostermeSayac = 1;  //Peş peşe üç yanlış tutan değişkeni varsayılan 1 değerini ata.
                        YanlisCevap++; //Yanlış cevap sayısını bir arttır
                        OzetGuncelle(false); //Anasayfadaki özet tablonun değerini güncelleyen metot (False ise YanlisCevap ile güncelle)
                    }
                    else //Kullanıcı doğru cevabı görmek istemezse
                    {
                        CevapGostermeSayac = 1; 
                        YanlisCevap++; 
                        OzetGuncelle(false); 
                    }
                }
                else //Peş peşe yanlış sayısı 3'ün katı değilse yanlış cevap kutusunu göster
                {
                    MessageBox.Show("Cevabınız yanlış, lütfen tekrar deneyin.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CevapGostermeSayac++; 
                    YanlisCevap++; 
                    OzetGuncelle(false); 
                }
            }
        }
        private void OzetGuncelle(bool z) //Anasayfadaki özet tablonun değerini güncelleyen metot
        {
            if (z == true) //doğru cevap sayısını güncelleyecek koşul
            {
                FormAnasayfa sayac = (FormAnasayfa)Application.OpenForms["FormAnasayfa"];
                sayac.DogruLabel.Text = "Doğru Sayısı: " + DogruCevap.ToString();
                sayac.DogruLabel.Refresh();
            }
            else //yanlış cevap sayısını güncelleyecek koşul
            {
                FormAnasayfa sayac = (FormAnasayfa)Application.OpenForms["FormAnasayfa"];
                sayac.YanlisLabel.Text = "Yanlış Sayısı: " + YanlisCevap.ToString();
                sayac.YanlisLabel.Refresh();
            }

        }

        private void CevapYurut(int x) //Cevabın getirildiği ana metot
        {
            try 
            {
                if (SoruSira != DogruCevap) //Program doğru cevap verilene kadar çalışmasının sağlaması
                {
                    if (CevapSira == x)
                    {
                        Cevapİsleme(x);
                        CevapBox.SelectionStart = CevapBox.Text.Length;
                        CevapBox.ScrollToCaret();
                        CevapBox.Focus();
                    }
                }
                else if (SoruSira == DogruCevap) //Doğru cevapla soru sayısı eşleştiğinde programı sonlandırma veya yeniden başlatma
                {
                    DialogResult sonuc = MessageBox.Show("Tebrikler, SQL'liyoruz'da yer alan tüm soruları " + DogruCevap + " doğru; " + YanlisCevap + " yanlış cevapla tamamladınız." + "\n \n" + "Yeni sorular, şemalar ve bunlara ek olarak zorluk ile soru seçimi gibi özellikler ilerleyen dönemdeki güncellemeyle yayınlanacak." + "\n \n" + "Soruları baştan çözmek için istiyorsanız 'Evet' butonuna basın", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(sonuc == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
            }
            catch (Exception) //list sınırı aşımı hatasını aşma
            {
                DialogResult sonuc = MessageBox.Show("Tebrikler, SQL'liyoruz'da yer alan tüm soruları " + DogruCevap + " doğru; " + YanlisCevap + " yanlış cevapla tamamladınız." + "\n \n" + "Yeni sorular, şemalar ve bunlara ek olarak zorluk ile soru seçimi gibi özellikler ilerleyen dönemdeki güncellemeyle yayınlanacak." + "\n \n" + "Soruları baştan çözmek için istiyorsanız 'Evet' butonuna basın", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
            

        }

        private void CevapButton_Click(object sender, EventArgs e) //Cevapla butonu tıklama işlevi
        {
            CevapYurut(CevapSira); //Cevabın yürütlmesi

        }
        private void CevapBox_KeyDown(object sender, KeyEventArgs e) //Cevapla butonu CTRL+F5 kısayolu
        {
            if (e.Control && e.KeyCode == Keys.F5)
            {
                CevapYurut(CevapSira);
            }

        }

        private void BilgiButton_Click(object sender, EventArgs e) //Bilgi butonu
        {
            MessageBox.Show("Yazdığınız SQL sorgusunu CTRL + F5 kısayoluyla da çalıştırabilirsiniz." + "\n \n" + "Peş peşe yaptığınız üç yanlışta bir kez doğru cevabı görmek için bilgilendirme mesajı alacaksınız." + "\n \n" + "Her SQL sorusunun farklı yazılış şekli olabilir, bu projede yer alan doğru çözümler genel kullanımı fazla olanlar baz alınarak hazırlanmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


