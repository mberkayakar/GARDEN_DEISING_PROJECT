using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMF_GROUP_GARDEN_PROJECT
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        int a;
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            this.TransparencyKey = Color.Green;

            timer1.Interval = 600;
            timer1.Start();
            progressPanel1.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;

            if (a == 3)
            {
                progressPanel1.Visible = true;
            }
            if (a == 7)
            {
               timer1.Stop();
                Giris_Ekran g = new Giris_Ekran();
                g.Show();
                this.Visible = false;
            }
        }
    }
}
