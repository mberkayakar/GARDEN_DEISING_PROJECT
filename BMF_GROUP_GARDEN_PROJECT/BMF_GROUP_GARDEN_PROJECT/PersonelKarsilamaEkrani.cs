using BusinessLayer;
using DataAccessLayer_;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using DevExpress.XtraEditors.Controls;
using System.Windows.Controls;
using EntityLayer.Entities;
using BusinessLayer.Concrete;

namespace BMF_GROUP_GARDEN_PROJECT
{
    public partial class PersonelKarsilamaEkrani : Form
    {

        Employee employee;

        public PersonelKarsilamaEkrani(Employee e)
        {
            InitializeComponent();
            employee = e;
        }

        private readonly MessageManager Messages = new MessageManager(new Repository <MessageManager>()); // patlarsa gg


        

        private void PersonelKarsilamaEkrani_Load(object sender, EventArgs e)
        {





            pictureBox1.Load(employee.Photos);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            timer1.Interval = 5000;
            timer1.Enabled = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            KisiselSayfa k = new KisiselSayfa(employee);
            k.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                
            }
            else
            {

            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                MessageBox.Show("Açildi lan amq");
            }
            else
            {
                MessageBox.Show("Kapandi lan Ameka");
            }
        }
    }
}
