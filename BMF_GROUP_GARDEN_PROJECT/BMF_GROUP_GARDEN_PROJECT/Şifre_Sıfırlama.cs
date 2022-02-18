using BusinessLayer;
using DataAccessLayer_;
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

        private readonly EmployeesManager personel = new EmployeesManager(new Repository<Employee>());



        MailMessage eposta = new MailMessage();

        SmtpClient smtp = new SmtpClient();
        Employee employee = new Employee();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var a = personel.GetByFilter(x => x.UserName == textBox1.Text);

            if (a ==null)
            {
                MessageBox.Show("Sistemde Byle Bir Kullanıcı Mevcut Bulunmamaktadır. ");

            }
            else
            {

        
                    employee.Email = a.Email; // bu sensin yani sen parolanı unuttun ole dusun
                    employee.Password = a.Password;

            

                eposta.From = new MailAddress("m.berkay.akar@mail.com");
                eposta.To.Add(employee.Email);
                eposta.Subject = "BMF_GARDEN_PROJECT_RESET_PASSWORD";
                
                eposta.IsBodyHtml = true;

                //eposta.Body = @"<!DOCTYPE html><html><head><title> Page Title </title></head><body><h1>This is a Heading</h1><p>This is a paragraph.</p></body></html>";


                eposta.Body = @"
<!DOCTYPE html>
<html>
<head>
<style>
h1 {color:red;}
p {color:blue;}
</style>
</head>
<body>

<h1 >This is a heading</h1>
<p>This is a paragraph.</p>

</body>
</html>


 ";


                //"Değerli BMF_PROJECT üyesi seni oncelikle aramızda gordugumuzden tekrardan mutluluk duymaktayız. \n \n \n  Unuttuğun şifren : " + employee.Password + "\n \n \n İyi günler dileriz ...";

                smtp.Credentials = new System.Net.NetworkCredential("m.berkay.akar@gmail.com", "Mba18514110");



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
                //  

             


            }
        }

        List<Employee> emp = new List<Employee>();

        private void Şifre_Sıfırlama_Load(object sender, EventArgs e)
        {
            emp = personel.Getall().ToList();

            AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
            foreach (var item in emp)
            {
                sc.Add(item.UserName + "   (" + item.Name + " " + item.Surname + ")");
            }
            textBox1.AutoCompleteCustomSource = sc;
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
    

        }
    }
}
