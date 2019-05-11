using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestleUI
{
    public partial class HakkindaUI : Form
    {
        NestleBLL.KontrolPaneli.KullaniciGirisi KullanHakkinda = new NestleBLL.KontrolPaneli.KullaniciGirisi();
        public HakkindaUI()
        {
            InitializeComponent();
        }

        private void HakkindaUI_Load(object sender, EventArgs e)
        {
            lblHakkimda.Text = KullanHakkinda.Hakkimda();
            lblSlogan.Text = KullanHakkinda.Slogan();
        }
    }
}
