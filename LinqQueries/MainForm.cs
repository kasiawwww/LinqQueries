using MockData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqQueries
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void getResults_Click(object sender, EventArgs e)
        {
           // ObjectRepo repo = new ObjectRepo();
           // repo.Add(new Person {Id=100, Name = "Hanna", LastName = "Lis", BirthDate = new DateTime (1970,5,30), Height = 175, Weight = 65 });
            dgv.DataSource = null;
            dgv.DataSource = People.PeopleList.OrderByDescending(a=>a.Id).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ObjectRepo repo = new ObjectRepo();
            //Person person = new Person();
            //person.Name = tbName.Text;
            //person.LastName = tbLastname.Text;
            //person.BirthDate = dpBirthDate.Value;
            //person.Weight = Convert.ToInt32(mtbHeight.Text);
            //person.Height = Convert.ToInt32(mtbHeight.Text);

            Person person = new Person
            {
                Name = tbName.Text,
                LastName = tbLastname.Text,
                BirthDate = dpBirthDate.Value,
                Weight = Convert.ToInt32(mtbWeight.Text),
                Height = Convert.ToInt32(mtbHeight.Text)
            };
            repo.Add(person);
            MessageBox.Show("OK"); //mb tab tab
            getResults_Click(sender, e); //getResults_Click(null, null);

        }
    }
}
