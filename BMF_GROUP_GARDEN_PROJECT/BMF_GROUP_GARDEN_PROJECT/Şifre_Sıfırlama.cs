using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMF_GROUP_GARDEN_PROJECT
{
    public partial class Şifre_Sıfırlama : Form
    {
        public Şifre_Sıfırlama()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        CategoryManager personel = new CategoryManager();



        MailMessage eposta = new MailMessage();

        SmtpClient smtp = new SmtpClient();


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var a = personel.getbyfilter(textBox1.Text);

            if (a.Count == 0)
            {
                MessageBox.Show("Sistemde Byle Bir Kullanıcı Mevcut Bulunmamaktadır. ");

            }
            else
            {

                Employee employee = new Employee();
                foreach (var item in a)
                {
                    employee.Email = item.Email; // bu sensin yani sen parolanı unuttun ole dusun
                    employee.Password = item.Password;

                }

                eposta.From = new MailAddress("m.berkay.akar@mail.com");
                eposta.To.Add(employee.Email);
                eposta.Subject = "BMF_GARDEN_PROJECT_RESET_PASSWORD";
                eposta.Body = "Değerli BMF_PROJECT üyesi seni oncelikle aramızda gordugumuzden tekrardan mutluluk duymaktayız. \n \n \n  Unuttuğun şifren : " + employee.Password + "\n \n \n İyi günler dileriz ...";

                smtp.Credentials = new System.Net.NetworkCredential("m.berkay.akar@gmail.com", "Qwerasdf0147");



                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                // smtp.Port = 25;
                smtp.Port = 587;
                // smtp.UseDefaultCredentials = false;

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(eposta);

                MessageBox.Show("Lütfen Mail Adresinizi Kontrol Ediniz"); // Aklına sıçayım portu yanlış yazmısın geldi bana
                // knk diğer protlada denedim bu sadece ssl olup olmamasına bakıyo
                // var aq
                // daha once adlıgım bi domainin maili için attıramadıydım 25 vermen lazımdı port nosunu,
                // ama şimdi fişek oldu
                // kardeşim sikine daşşana beline sağlık

             


            }
        }

   

        private void Şifre_Sıfırlama_Load(object sender, EventArgs e)
        {
           
        }
    }
}
