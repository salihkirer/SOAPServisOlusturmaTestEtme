using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOAPWebServisTesti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            int ilkSayi = int.Parse(txtIlkSayi.Text);
            int ikinciSayi = int.Parse(txtIkinciSayi.Text);
            int sonuc;
            try
            {
                using (HesapMakinesiServis.HesapMakinesiSoapClient service = new HesapMakinesiServis.HesapMakinesiSoapClient { })
                {
                    sonuc = service.Toplama(ilkSayi, ikinciSayi);
                }
            }
            catch (Exception)
            {
                throw;
            }
            txtSonuc.Text = sonuc.ToString();
        }
    }
}
