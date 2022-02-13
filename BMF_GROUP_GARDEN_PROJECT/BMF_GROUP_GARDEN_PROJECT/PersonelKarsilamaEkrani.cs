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
    public partial class PersonelKarsilamaEkrani : Form
    {

        Employee employee;

        public PersonelKarsilamaEkrani(Employee e)
        {
            InitializeComponent();
            employee = e;
        }

        private void PersonelKarsilamaEkrani_Load(object sender, EventArgs e)
        {
            this.Text = employee.UserName + String.Format(" ({0})", employee.Name + "  " + employee.Surname);
        }
    }
}
