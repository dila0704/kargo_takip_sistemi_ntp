using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//gönderi ana classım gönderiden yurtiçi ve yurtdışı kalıtım alıyor
//enum da 3 durum tanımlı bekliyor, yolda ve teslim edildi 
//Itakipedilebilir sınıfı gönderiden implement edildi.
//enum 186.satırda

namespace kargo_takip_sistemi
{

    public partial class Form1 : Form
    {
        string dosyaYolu = "veriler.txt";//kullanıcların adları takip no ları ve gönderi durumu veriler dosyasında
        List<Gonderi> gonderiler = new List<Gonderi>();//aynı zamanda ekranda göstermek için listede tutuyoruz
        public Form1()
        {
            InitializeComponent();
            cmbDurum.DataSource = Enum.GetValues(typeof(Durum));
            cmbTip.Items.Add("Yurtici");
            cmbTip.Items.Add("Yurtdisi");
            DosyadanYukle();
        }
        private void DosyadanYukle()
        {
            if (!System.IO.File.Exists(dosyaYolu))
                return;

            string[] satirlar = System.IO.File.ReadAllLines(dosyaYolu);
            foreach (string satir in satirlar)
            {
                string[] parca = satir.Split('|');
                if (parca.Length == 4)
                {
                    string tip = parca[0];//takipno
                    string takipNo = parca[1];//adsoyad
                    string alici = parca[2];//gönderi durumu
                    Durum durum = (Durum)Enum.Parse(typeof(Durum), parca[3]);

                    Gonderi g;
                    if (tip == "Yurtici")
                        g = new Yurtici(takipNo, alici);
                    else
                        g = new Yurtdisi(takipNo, alici);

                    g.GonderiDurumu = durum;
                    gonderiler.Add(g);
                }
            }

            ListeyiYenile();
        }
        private void DosyayaKaydet()
        {
            List<string> satirlar = new List<string>();
            foreach (var g in gonderiler)
            {
                string tip = g is Yurtici ? "Yurtici" : "Yurtdisi";
                satirlar.Add($"{tip}|{g.TakipNo}|{g.Alici}|{g.GonderiDurumu}");
            }
            System.IO.File.WriteAllLines(dosyaYolu, satirlar);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            string takipNo = textTakipNo.Text;
            string alici = textAlici.Text;
            string tip = cmbTip.SelectedItem?.ToString();
            //tüm bilgilerin doldurulup doldurulmadığını kontrol ediyoruz

            if (string.IsNullOrEmpty(takipNo) || string.IsNullOrEmpty(alici) || string.IsNullOrEmpty(tip))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            Gonderi gonderi;
            if (tip == "Yurtici")
                gonderi = new Yurtici(takipNo, alici);
            else
                gonderi = new Yurtdisi(takipNo, alici);

            gonderiler.Add(gonderi);
            lstGonderiler.Items.Add(gonderi.Goster());
            MessageBox.Show("Gönderi oluşturuldu.");
            DosyayaKaydet();

        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (lstGonderiler.SelectedIndex >= 0)
            {
                int secilenIndex = lstGonderiler.SelectedIndex;
                Gonderi g = gonderiler[secilenIndex];

                if (cmbDurum.SelectedItem != null)
                {
                    Durum yeniDurum = (Durum)Enum.Parse(typeof(Durum), cmbDurum.SelectedItem.ToString());
                    g.DurumGuncelle(yeniDurum);      
                    DosyayaKaydet();                  
                    ListeyiYenile();                  
                }
                else
                {
                    MessageBox.Show("Lütfen bir durum seçiniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir gönderi seçiniz.");
            }

        }

        private void bnSorgula_Click(object sender, EventArgs e)
        {
            string takipNo = textTakipNo.Text;

            foreach (var g in gonderiler)
            {
                if (g.TakipNo == takipNo)
                {
                    MessageBox.Show(g.Goster());
                    return;
                }
            }

            MessageBox.Show("Gönderi bulunamadı.");
        }
        private void ListeyiYenile()
        {
            lstGonderiler.Items.Clear();
            foreach (var g in gonderiler)
            {
                lstGonderiler.Items.Add(g.Goster());
            }
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstGonderiler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textAlici_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTakipNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public enum Durum    //birden fazla durum olduğu için enum kullandık
    {
        Bekliyor,
        Yolda,
        TeslimEdildi
    }
    public interface ITakipEdilebilir
    {
        string TakipNo { get; }
        Durum GonderiDurumu { get; set; }
        void DurumGuncelle(Durum yeniDurum);
    }

    public class Gonderi : ITakipEdilebilir
    {
        public string TakipNo { get; set; }
        public string Alici { get; set; }
        public Durum GonderiDurumu { get; set; }

        public Gonderi(string takipNo, string alici)
        {
            TakipNo = takipNo;
            Alici = alici;
            GonderiDurumu = Durum.Bekliyor;
        }

        public virtual string Goster()
        {
            return $"TakipNo: {TakipNo} - Alıcı: {Alici} - Durum: {GonderiDurumu}";
        }

        public void DurumGuncelle(Durum yeniDurum)
        {
            GonderiDurumu = yeniDurum;
        }
    }
    public class Yurtici : Gonderi
    {
        public Yurtici(string takipNo, string alici) : base(takipNo, alici) { }

        public override string Goster()
        {
            return "[YURTİÇİ] " + base.Goster();
        }
    }

    public class Yurtdisi : Gonderi
    {
        public Yurtdisi(string takipNo, string alici) : base(takipNo, alici) { }

        public override string Goster()
        {
            return "[YURTDIŞI] " + base.Goster();
        }
    }
}
