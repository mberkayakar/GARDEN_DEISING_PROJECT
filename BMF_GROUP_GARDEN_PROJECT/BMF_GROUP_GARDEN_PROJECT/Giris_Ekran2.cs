
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
    public partial class Giris_Ekran2 : Form
    {
        private readonly EmployeesManager personel = new EmployeesManager(new Repository<Employee>());
        private readonly GenericManager<CITY> _genericCityRepository = new GenericManager<CITY>(new Repository<CITY>());


        public Giris_Ekran2()
        {
            InitializeComponent();
        }

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
                    PersonelKarsilamaEkrani p = new PersonelKarsilamaEkrani(new Employee { ID = a.ID, Name = a.Name, Surname = a.Surname, Sex = a.Sex, UserName = a.UserName, Password = a.Password, Phone = a.Phone, Email = a.Email });
                    p.Show();
                    this.Hide();
                    return;
                }
                // }
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Şifre_Sıfırlama s = new Şifre_Sıfırlama();
            this.Hide();
            s.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
 

            
            var a = personel.Getall();

            dataGridView1.DataSource = a;

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {


      



            Employee kaydedilecekpersonel = new Employee();
            kaydedilecekpersonel.Password = textBox7.Text;
            kaydedilecekpersonel.Name = textBox3.Text;
            kaydedilecekpersonel.Surname = textBox4.Text;
            kaydedilecekpersonel.Sex = textBox5.Text;
            kaydedilecekpersonel.UserName = textBox6.Text;
            kaydedilecekpersonel.Phone = textBox8.Text;
            kaydedilecekpersonel.Email = textBox9.Text;

            var a = personel.GetByFilter(x => x.UserName == kaydedilecekpersonel.UserName);

            if (a == null)
            {
                personel.Additem(kaydedilecekpersonel);
                MessageBox.Show("Kayıt İşlemi Başarılı");
                Form1_Load(this, null);
            }
            else
            {
                MessageBox.Show("Boyle Bir Kayıt sistemde Mevcuttur");
                return;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Employee silincekpersonel = new Employee();
            personel.DeleteById(Convert.ToInt32(textBox10.Text));
            MessageBox.Show("Silinme İşlemi Gerçekleşti");
            Form1_Load(this, null);

        }


        #region MyRegion

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region RB

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked )
            {
                simpleButton3.Visible = true;
                    

            }
            else
            {
                simpleButton5.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                simpleButton3.Visible = false;
            }
            else
            {
                simpleButton5.Visible = true;
            }
        }
        #endregion



        private void simpleButton5_Click(object sender, EventArgs e)
        {



            Employee kaydedilecekpersonel = new Employee();
            kaydedilecekpersonel.Password = textBox7.Text;
            kaydedilecekpersonel.Name = textBox3.Text;
            kaydedilecekpersonel.Surname = textBox4.Text;
            kaydedilecekpersonel.Sex = textBox5.Text;
            kaydedilecekpersonel.UserName = textBox6.Text;
            kaydedilecekpersonel.Phone = textBox8.Text;
            kaydedilecekpersonel.Email = textBox9.Text;
            kaydedilecekpersonel.Photos = textBox10.Text;

            var a = personel.GetByFilter(x => x.UserName == kaydedilecekpersonel.UserName);
 
                kaydedilecekpersonel.ID = a.ID;
  
      



            if (a != null)
            {
                personel.Update(kaydedilecekpersonel);
                MessageBox.Show("Güncelleme Başarılı");
                Form1_Load(this, null);
            }
            else
            {
                MessageBox.Show("Boyle Bir Kayıt Mevcut Değildir. Olası bir sorun ile karşılaştıysanız lütfen yneticiye raporlayınız");
                return;
            }
            Form1_Load(this, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["Surname"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["Sex"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.ShowDialog();
            var a = f.FileName;
            textBox10.Text = f.FileName;
        }
    }
 }
 
