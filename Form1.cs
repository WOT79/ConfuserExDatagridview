using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public List<Person> GetPersons()
            {
                var p = new List<Person>();
                p.Add(new Person() { FirstName = "FN AAAA", LastName = "LN AAAA", Age = 5 });
                p.Add(new Person() { FirstName = "FN BBBB", LastName = "LN BBBB", Age = 10 });
                p.Add(new Person() { FirstName = "FN CCCC", LastName = "LN CCCC", Age = 15 });
                p.Add(new Person() { FirstName = "FN DDDD", LastName = "LN DDDD", Age = 20 });

                return p;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                BindingSource bs = new BindingSource();
                bs.DataSource = new Person().GetPersons();
                dataGridView1.DataSource = bs;
                dataGridView1.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
