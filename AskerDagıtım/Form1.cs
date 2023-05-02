using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskerDagıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] kisi, sehir;

        private void btnDagıtımYap_Click(object sender, EventArgs e)
        {
            DagitimYap();
        }

        private void DagitimYap()
        {
            lbxEslesme.Items.Clear();

            Random rnd = new Random();
            Asker yeni;
            int indis;

            for (int i = 0; i < kisi.Length; i++)
            {
                indis = rnd.Next(sehir.Length);
                yeni = new Asker()
                {
                    Kisi = kisi[i],
                    Sehir = sehir[indis]
                };
                lbxEslesme.Items.Add(yeni);

                sehir[indis] = sehir[sehir.Length - 1];
                Array.Resize(ref sehir, sehir.Length - 1);

                if (sehir.Length == 0)
                {
                    ListeYukle();
                }
            }
        }

        private void ListeYukle()
        {
            Array.Resize(ref sehir, lbxSehir.Items.Count);
            Array.Resize(ref kisi, lbxAsker.Items.Count);

            for (int j = 0; j < lbxSehir.Items.Count; j++)
            {
                sehir[j] = (string)lbxSehir.Items[j];
            }
            for (int j = 0; j < lbxAsker.Items.Count; j++)
            {
                kisi[j] = (string)lbxAsker.Items[j];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnAskerEkle_Click(object sender, EventArgs e)
        {
            lbxAsker.Items.Add(txtAsker.Text);
            MessageBox.Show("Kayıt Başarılı!");
            txtAsker.Text = null;
            lbxEslesme.Items.Clear();
        }

        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            lbxSehir.Items.Add(txtSehir.Text);
            MessageBox.Show("Kayıt Başarılı!");
            txtSehir.Text = null;
            txtSehir.Text = "";
            lbxEslesme.Items.Clear();
        }

        private void LoadList()
        {

            //lbxAsker.Items.Clear();
            //lbxSehir.Items.Clear();

            if (lbxAsker.Items.Count == 0)
            {
                kisi = new string[] { "Ali Ata", "Veli Bak", "Hüseyin Turan", "Baki Mercimek", "Mehmet Ayaz" };
                sehir = new string[] { "Ankara", "Bursa", "Gaziantep" };

            }
            else
            {
                ListeYukle();
            }
            lbxAsker.Items.AddRange(kisi);
            lbxSehir.Items.AddRange(sehir);
        }
    }
}
