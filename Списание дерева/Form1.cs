using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Списание_дерева.Model;

namespace Списание_дерева
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Order> orders = new List<Order>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           AddForm formAdd = new AddForm(this);

            formAdd.Show();
        }
    }
}
