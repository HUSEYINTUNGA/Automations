using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FİSTİK_Otomasyon
{
    public partial class FrmHakkımızda : Form
    {
        public FrmHakkımızda()
        {
            InitializeComponent();
        }

        private void btnAnladım_Click(object sender, EventArgs e)
        {
            FrmAnaMenu gcs = new FrmAnaMenu();
            gcs.Show();
            this.Hide();
        }
    }
}
