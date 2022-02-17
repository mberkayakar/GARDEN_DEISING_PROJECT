using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DataAccessLayer_;
using DevExpress.XtraEditors.Controls;
using System.Windows.Controls;
using EntityLayer;
using EntityLayer.Entities;

namespace BMF_GROUP_GARDEN_PROJECT
{
    public partial class SehirlerBilgisi : Form
    {
        private readonly EmployeesManager _employeesManager = new EmployeesManager(new Repository<Employee>()); // patlarsa gg
        private readonly GenericManager<CITY> _genericCityRepository = new GenericManager<CITY>(new Repository<CITY>());


        private void Test()
        {
            var cities = _genericCityRepository.GetAll(x => x.CityName == "İstanbul", x => x.DISTRICT);
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public SehirlerBilgisi()
        {
            InitializeComponent();
        }


        private void SehirlerBilgisi_Load(object sender, EventArgs e)
        {
            Test();
            DataAccessLayer_.Context conn = new DataAccessLayer_.Context();




            foreach (var item in conn.CITIES)
            {
                ComboboxItem cmd = new ComboboxItem();
                cmd.Text = item.CityName;
                cmd.Value = item.ID;
                comboBox1.Items.Add(cmd);
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";

            DataAccessLayer_.Context conn = new DataAccessLayer_.Context();

            int ilid = (comboBox1.SelectedItem as ComboboxItem).Value;
            var a = (from memleket in conn.DISTRICTS
                     where memleket.CityId
== ilid
                     select memleket).ToList();


            foreach (var item in a)
            {
                ComboboxItem cmd = new ComboboxItem();
                cmd.Text = item.Name;
                cmd.Value = item.ID;
                comboBox2.Items.Add(cmd);
            }

        }
    }
}
