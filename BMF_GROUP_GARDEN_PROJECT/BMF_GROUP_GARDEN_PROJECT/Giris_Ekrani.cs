using BusinessLayer;
using DataAccessLayer_;
using EntityLayer;
using EntityLayer.Entities;
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
    public partial class Giris_Ekrani : Form
    {
        public Giris_Ekrani()
        {
            InitializeComponent();
        }

        private void Giris_Ekrani_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private readonly EmployeesManager personel = new EmployeesManager(new Repository<Employee>());

   

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var a = personel.GetByFilter(x => x.UserName == textBox1.Text);

            if (a == null)
            {
                MessageBox.Show("Sistemde Boyle Bir Kullanıcı Mevcut değıdlır. ");
                return;
            }
            else
            {


                //foreach (var item in a)
                //{
                if (a.Password == textBox2.Text)
                {
                    MessageBox.Show("Giriş Başarılı ... Geldiniz " + a.Name + "   " + a.Surname);
                    PersonelKarsilamaEkrani p = new PersonelKarsilamaEkrani(new Employee { ID = a.ID, Name = a.Name, Surname = a.Surname, Sex = a.Sex, UserName = a.UserName, Password = a.Password, Phone = a.Phone, Email = a.Email, Photos =a.Photos});
                    p.Show();
                    this.Hide();
                    return;
                }
               
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else 
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Şifre_Sıfırlama s = new Şifre_Sıfırlama();
            this.Hide();
            s.Show();

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.ShowDialog();
            var a =f.FileName;
            MessageBox.Show("Seşildi");
        }
    }
}








