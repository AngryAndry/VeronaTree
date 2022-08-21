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
            
            PopulateDataGrid(orders);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void PopulateDataGrid(List<Order> record)
        {
            dataGridView1.Rows.Clear();
            if (record == null)
            {
                return;
            }
            foreach (var item in record)
            {

                dataGridView1.Rows.Add(item.numberOrder,item.model);
                
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
           AddForm formAdd = new AddForm(this);

            formAdd.Show();
        }
    }
}
