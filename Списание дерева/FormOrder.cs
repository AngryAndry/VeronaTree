using Microsoft.EntityFrameworkCore;
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
                var index = db.Orders.FirstOrDefault(p => p.numberOrder == tbNumberOrder.Text);
                var g = from order in db.Orders
                        join semimanufactures in db.semimanufactures on order.Id equals semimanufactures.OrderId
                        join sizeSemimanufactures in db.sizeSemimanufactures on semimanufactures.Id equals sizeSemimanufactures.semimanufacturesID
                        select new
                        {

                         numberOrder = order.numberOrder,
                         model = order.model,
                            semimanufactures = semimanufactures.treeSpecies,
                                       amount = sizeSemimanufactures.amount
                ,
                            length = sizeSemimanufactures.length
                ,
                            width = sizeSemimanufactures.width
                ,
                            height = sizeSemimanufactures.height,
                            


                        };

                foreach (var u in g)
                {
                    if (u.numberOrder == tbNumberOrder.Text &&u.model == cbModel.Text)
                    {
                        cbTreeSpecies.Text = u.semimanufactures;
                        dGVSize.Rows.Add(u.length,u.width,u.height,u.amount);
                    }
                }
                }


            }

            /*      (from user in db.Users.Include(p => p.Company)
                   where user.CompanyId == 1
                   select user).ToList();*/
        }
        }

   
    

