using Microsoft.VisualBasic.ApplicationServices;
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
       public List<Order> orders = new List<Order>();
        public Form1()
        {

            InitializeComponent();
            
            PopulateDataGrid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        public void PopulateDataGrid()
        {
            dataGridView1.Rows.Clear();

            using (ApplicationContext db = new ApplicationContext())
            {
                var order = db.Orders.ToList();
                if (order == null)
                {
                    return;
                }
                foreach (var item in order)
                {

                    dataGridView1.Rows.Add(item.numberOrder, item.model);

                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
           AddForm formAdd = new AddForm(this);

            formAdd.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FormOrder formAdd = new FormOrder(this);

            formAdd.Show();
        }
    }
}
