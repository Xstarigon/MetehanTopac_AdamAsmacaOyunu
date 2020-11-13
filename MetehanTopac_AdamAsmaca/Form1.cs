using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetehanTopac_AdamAsmaca.Classes;

namespace MetehanTopac_AdamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Oyun oyun = new Oyun();
        string kelime;
        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Visible = false;
            trackBar2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            pGiris.Visible = true;
            lKelime.Visible = false;
            Klavye.Visible = false;
            panelKalan.Visible = false;
            panelTahmin.Visible = false;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar2.Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                trackBar1.Visible = true;
                label4.Visible = true;
            }
            else
            {
                trackBar1.Visible = false;
                label4.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                trackBar2.Visible = true;
                label5.Visible = true;
            }
            else
            {
                trackBar2.Visible = false;
                label5.Visible = false;
            }
        }

        int SentenceNumber;
        int WordNumber;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            SentenceNumber = trackBar1.Value;
            WordNumber = trackBar2.Value;
            pGiris.Visible = false;
            lKelime.Visible = true;
            Klavye.Visible = true;
            panelKalan.Visible = true;
            panelTahmin.Visible = true;
            if (radioButton1.Checked == false)
            {
                lKTahmin.Text = "∞";
            }else
            {
                lKTahmin.Text = SentenceNumber.ToString();
            }
            if (radioButton4.Checked == false)
            {
                lHTahmin.Text = "∞";
            }else
            {
                lHTahmin.Text = WordNumber.ToString();
            }
            kelime = oyun.KelimeSec();
            for (int i = 0; i < kelime.Replace(" ", "").Length; i++)
            {
                lKelime.Text = lKelime.Text + "_ ";
            }
        }
        bool sonuc;
        public void HarfSorgula(string kelime, string harf, int WordNumber)
        {
            int harfYeri;
            if (kelime.Contains(harf.ToLower()))
            {
                harfYeri = kelime.IndexOf(harf.ToLower());
                lKelime.Text = lKelime.Text.Remove(harfYeri, 1);
                lKelime.Text = lKelime.Text.Insert(harfYeri, harf);
                sonuc = true;
            }
            else
            {
                sonuc = false;
                if(radioButton3.Checked == false) { 
                this.WordNumber = WordNumber - 1;
                lHTahmin.Text = this.WordNumber.ToString();
                }
            }
            if(this.WordNumber == 0 || this.SentenceNumber == 0)
            {
                MessageBox.Show("Oyunu kaybettiniz!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }
        string tahmin;
        public void KelimeSorgulama(string kelime)
        {
            tahmin = textBox1.Text.Trim().ToLower();
            if(kelime.Replace(" ", "").ToLower() == tahmin)
            {
                MessageBox.Show("Tebrikler! Oyunu Kazandınız.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }else
            {
                MessageBox.Show("Üzgünüm! Tahminin yanlış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (radioButton2.Checked == false)
                {
                    SentenceNumber--;
                    lKTahmin.Text = SentenceNumber.ToString();
                }

            }
        }

        private void bC_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "C", WordNumber);
            if (sonuc == true)
                bC.BackColor = Color.Green;
            else
                bC.BackColor = Color.Red;
        }

        private void bB_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "B", WordNumber);
            if (sonuc == true)
                bB.BackColor = Color.Green;
            else
                bB.BackColor = Color.Red;
        }

        private void bA_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "A", WordNumber);
            if (sonuc == true)
                bA.BackColor = Color.Green;
            else
                bA.BackColor = Color.Red;
        }

        private void bÇ_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "Ç", WordNumber);
            if (sonuc == true)
                bÇ.BackColor = Color.Green;
            else
                bÇ.BackColor = Color.Red;
        }

        private void bD_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "D", WordNumber);
            if (sonuc == true)
                bD.BackColor = Color.Green;
            else
                bD.BackColor = Color.Red;
        }

        private void bE_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "E", WordNumber);
            if (sonuc == true)
                bE.BackColor = Color.Green;
            else
                bE.BackColor = Color.Red;
        }

        private void bF_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "F", WordNumber);
            if (sonuc == true)
                bF.BackColor = Color.Green;
            else
                bF.BackColor = Color.Red;
        }

        private void bG_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "G", WordNumber);
            if (sonuc == true)
                bG.BackColor = Color.Green;
            else
                bG.BackColor = Color.Red;
        }

        private void bĞ_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "Ğ", WordNumber);
            if (sonuc == true)
                bĞ.BackColor = Color.Green;
            else
                bĞ.BackColor = Color.Red;
        }

        private void bH_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "H", WordNumber);
            if (sonuc == true)
                bH.BackColor = Color.Green;
            else
                bH.BackColor = Color.Red;
        }

        private void bİ_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "İ", WordNumber);
            if (sonuc == true)
                bİ.BackColor = Color.Green;
            else
                bİ.BackColor = Color.Red;
        }

        private void bI_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "I", WordNumber);
            if (sonuc == true)
                bI.BackColor = Color.Green;
            else
                bI.BackColor = Color.Red;
        }

        private void bJ_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "J", WordNumber);
            if (sonuc == true)
                bJ.BackColor = Color.Green;
            else
                bJ.BackColor = Color.Red;
        }

        private void bK_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "K", WordNumber);
            if (sonuc == true)
                bK.BackColor = Color.Green;
            else
                bK.BackColor = Color.Red;
        }

        private void bL_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "L", WordNumber);
            if (sonuc == true)
                bL.BackColor = Color.Green;
            else
                bL.BackColor = Color.Red;
        }

        private void bM_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "M", WordNumber);
            if (sonuc == true)
                bM.BackColor = Color.Green;
            else
                bM.BackColor = Color.Red;
        }

        private void bN_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "N", WordNumber);
            if (sonuc == true)
                bN.BackColor = Color.Green;
            else
                bN.BackColor = Color.Red;
        }

        private void bO_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "O", WordNumber);
            if (sonuc == true)
                bO.BackColor = Color.Green;
            else
                bO.BackColor = Color.Red;
        }

        private void bÖ_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "Ö", WordNumber);
            if (sonuc == true)
                bÖ.BackColor = Color.Green;
            else
                bÖ.BackColor = Color.Red;
        }

        private void bP_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "P", WordNumber);
            if (sonuc == true)
                bP.BackColor = Color.Green;
            else
                bP.BackColor = Color.Red;
        }

        private void bR_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "R", WordNumber);
            if (sonuc == true)
                bR.BackColor = Color.Green;
            else
                bR.BackColor = Color.Red;
        }

        private void bS_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "S", WordNumber);
            if (sonuc == true)
                bS.BackColor = Color.Green;
            else
                bS.BackColor = Color.Red;
        }

        private void bŞ_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "Ş", WordNumber);
            if (sonuc == true)
                bŞ.BackColor = Color.Green;
            else
                bŞ.BackColor = Color.Red;
        }

        private void bT_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "T", WordNumber);
            if (sonuc == true)
                bT.BackColor = Color.Green;
            else
                bT.BackColor = Color.Red;
        }

        private void bU_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "U", WordNumber);
            if (sonuc == true)
                bU.BackColor = Color.Green;
            else
                bU.BackColor = Color.Red;
        }

        private void bÜ_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "Ü", WordNumber);
            if (sonuc == true)
                bÜ.BackColor = Color.Green;
            else
                bÜ.BackColor = Color.Red;
        }

        private void bV_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "V", WordNumber);
            if (sonuc == true)
                bV.BackColor = Color.Green;
            else
                bV.BackColor = Color.Red;
        }

        private void bY_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "Y", WordNumber);
            if (sonuc == true)
                bY.BackColor = Color.Green;
            else
                bY.BackColor = Color.Red;
        }

        private void bZ_Click(object sender, EventArgs e)
        {
            HarfSorgula(kelime, "Z", WordNumber);
            if (sonuc == true)
                bZ.BackColor = Color.Green;
            else
                bZ.BackColor = Color.Red;
        }

        private void bTahmin_Click(object sender, EventArgs e)
        {
            KelimeSorgulama(kelime);
        }
    }
}
