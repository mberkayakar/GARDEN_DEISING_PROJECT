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

namespace BMF_GROUP_GARDEN_PROJECT
{
    public partial class KisiselSayfa : Form
    {
        public KisiselSayfa(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        Employee employee = new Employee();
        private void KisiselSayfa_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;

            textBox1.Text = employee.Name;
            textBox2.Text = employee.Surname;
            comboBox1.Text = employee.Sex;
            textBox3.Text = employee.UserName;
            textBox5.Text = employee.Phone;
            pictureBox1.Load(employee.Photos);

        }
    }
}
