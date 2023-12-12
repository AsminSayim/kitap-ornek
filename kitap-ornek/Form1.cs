using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitap_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kitap kitap;
        List<Kitap>kitapListesi=new List<Kitap>();

        private void Form1_Load(object sender, EventArgs e)
        {
            kitapListesi.Add(new Kitap(1,"Kürk Mantolu Madonna", "Sabahattin Ali","151-200", "Aşk-Romantik", new DateTime(1943, 12, 18), false));
            kitapListesi.Add(new Kitap(2,"Cennetteki Kaplumbağalar", "Vedat Onat" ,"144", "Edebiyat", new DateTime(2015,2,20), false));
            kitapListesi.Add(new Kitap(3,"Yeşili Sevmek ", "Leman Veli", "351-400","Gençlik", new DateTime(2023,5,28), true));
            kitapListesi.Add(new Kitap(4,"Astro: Not ", "Şeyma Karakoç", "376", "Şiir", new DateTime(2023,9,22), true));
            kitapListesi.Add(new Kitap(5,"Gelibolu Uzun Beyaz Bulut ", "Buket Uzuner", "323", "Tarihi", new DateTime(2022,7,14), true));
            dgvListe.DataSource = kitapListesi.ToList();
        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtİd.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            txtKitapAdi.Text = dgvListe.CurrentRow.Cells["kitapAdi"].Value.ToString();
            txtSayfaSayisi.Text = dgvListe.CurrentRow.Cells["sayfaSayisi"].Value.ToString();
            txtYazar.Text = dgvListe.CurrentRow.Cells["yazar"].Value.ToString();
            cmbTür.Text = dgvListe.CurrentRow.Cells["tür"].Value.ToString();
            dtpBasim.Value = (DateTime)dgvListe.CurrentRow.Cells["basimTarihi"].Value;
            chkCilt.Checked = (bool)dgvListe.CurrentRow.Cells["cilt"].Value;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtİd.Text);
            string kitapAdi = txtKitapAdi.Text;
            string sayfaSayisi = txtSayfaSayisi.Text;
            string Yazar=txtYazar.Text;
            string Tür = cmbTür.Text;
            DateTime basim=dtpBasim.Value;
            bool cilt=chkCilt.Checked;
            
            Kitap yeniKitap = new Kitap(Id, kitapAdi,Yazar, sayfaSayisi, Tür, basim, cilt);
            kitapListesi.Add(yeniKitap);
            dgvListe.DataSource=kitapListesi.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];
            Kitap secilenKitap=secilenSatir.DataBoundItem as Kitap;
            DialogResult result = MessageBox.Show("Seçilen kitap silinsin mi?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                kitapListesi.Remove(secilenKitap);
            }
            dgvListe.DataSource = kitapListesi.ToList();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];

            Kitap secilenKitap = secilenSatir.DataBoundItem as Kitap;

            int id = Convert.ToInt32(txtİd.Text);
            string kitapAdi = txtKitapAdi.Text;
            string sayfaSayisi = txtSayfaSayisi.Text;
            string yazar = txtYazar.Text;
            string tür = cmbTür.Text;
            DateTime basim = dtpBasim.Value;
            bool cilt = chkCilt.Checked;

            secilenKitap.Id = id;
            secilenKitap.KitapAdi= kitapAdi;
            secilenKitap.Yazar= yazar;
            secilenKitap.Tür = tür;
            secilenKitap.BasimTarihi= basim;
            secilenKitap.Cilt= cilt;
            secilenKitap.SayfaSayisi= sayfaSayisi;
            dgvListe.DataSource = null;
            dgvListe.DataSource = kitapListesi.ToList();

        }
    }
}
