using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Списание_дерева
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();

        }
        public FormOrder(Form1 f1)
        {
            InitializeComponent();
            tbNumberOrder.Text=f1.dataGridView1[0, f1.dataGridView1.CurrentRow.Index].Value.ToString();
            cbModel.Text=f1.dataGridView1[1, f1.dataGridView1.CurrentRow.Index].Value.ToString();
            using (ApplicationContext db = new ApplicationContext())
            {
                //var order = db.Orders.ToList();
               // var order = db.semimanufactures.Include(u => u.treeSpecies).ToList();
                //cbTreeSpecies.Text = order[0].ToString()
;            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
           
        }
    }
}
