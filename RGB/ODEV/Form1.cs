using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pt_resim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaEkle = new OpenFileDialog();
            dosyaEkle.Filter = "Jpeg Dosyası|*.jpeg;*.jpg|Bmp Dosyası|*.bmp";

            if (dosyaEkle.ShowDialog() == DialogResult.OK)
            {
                pt_resim.ImageLocation = dosyaEkle.FileName;
            }
        }

        private void pt_YResim_Click(object sender, EventArgs e)
        {

        }

        private void btn_piksel_Click(object sender, EventArgs e)
        {
            if (pt_resim.Image == null) return;

            Bitmap resim = (Bitmap)pt_resim.Image;
            Color ilkPiksel = resim.GetPixel(0, 0);

            int genislik = resim.Width;
            int yukseklik = resim.Height;

            Bitmap yeniResim = new Bitmap(genislik, yukseklik);
            //Buradaki İç içe  2 For döngümüz resim üzerinde pixel pixel gezmemizi sağlar
            for (int i = 0; i < resim.Width; i++)
            {
                for (int x = 0; x < resim.Height; x++)
                {
                    Color oc = resim.GetPixel(i, x);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    yeniResim.SetPixel(i, x, nc);
                }
            }
            pt_YResim.Image = yeniResim;//tüm işlemler bittikten sonrada  nesmize yeni resmimizi aktarırız.
           lbl_gri.Text = "G: " + ilkPiksel.B.ToString();
        }

        private void lbl_gri_Click(object sender, EventArgs e)
        {

        }
    }
    
}
