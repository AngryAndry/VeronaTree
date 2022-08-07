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
    public partial class AddForm : Form
    {
        private int i;
        private Form1 f1;
        public string selectedModel { get; set; }
        public string selectedTreeSpecies { get; set; }
        Order order;
        Semimanufactures semimanufactures;
        SizeSemimanufactures sizeSemimanufactures;
        
        public AddForm()
        {
            InitializeComponent();
            cbModel.SelectedIndexChanged += cbModel_SelectedIndexChanged;
            cbTreeSpecies.SelectedIndexChanged += cbTreeSpecies_SelectedIndexChanged;
        }

        public AddForm(Form1 form1)
        {
            InitializeComponent();

            f1 = form1;
            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void tbLength_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void tbLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private  void btSave_Click(object sender, EventArgs e)
        {
           // order = new Order(selectedModel,tbNumberOrder.Text.ToString(),DateTime.Now,selectedTreeSpecies,Int32.Parse(tbLength.Text),Int32.Parse(tbWidth.Text),Int32.Parse(tbHeight.Text),Int32.Parse(tbAmount.Text));
            order = new Order(selectedModel,tbNumberOrder.Text.ToString(),DateTime.Now);
            semimanufactures = new Semimanufactures(selectedTreeSpecies);
            sizeSemimanufactures = new SizeSemimanufactures(Int32.Parse(tbLength.Text), Int32.Parse(tbWidth.Text), Int32.Parse(tbHeight.Text), Int32.Parse(tbAmount.Text));
            semimanufactures.sizeSemimanufactures.Add(sizeSemimanufactures);
            order.semimanufactures.Add(semimanufactures);
             f1.orders.Add(order);
            
            // f1.dataGridView1.Rows.Add(selectedModel,selectedTreeSpecies);
            f1.PopulateDataGrid(f1.orders);
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
             selectedModel = cbModel.SelectedItem.ToString();
        }

        private void cbTreeSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
             selectedTreeSpecies = cbTreeSpecies.SelectedItem.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            i = i + 155;
            AddBlank addBlank = new AddBlank();
            addBlank.lblTreeSpecies.Location = new System.Drawing.Point(73, 104 + i);
            addBlank.cbTreeSpecies.Location = new System.Drawing.Point(226, 104+ i);
            addBlank.btDelete.Location = new System.Drawing.Point(400, 104+ i);
            addBlank.lblSize.Location = new Point(73, 147+i);
            addBlank.tbLength.Location = new Point(73, 206+i);
            addBlank.tbWidth.Location = new Point(248, 206+i);
            addBlank.tbHeight.Location = new Point(416, 206 + i);
            addBlank.tbAmount.Location = new Point(626, 206 + i);
            addBlank.lblLength.Location = new Point(73, 177 + i);
            addBlank.lblWidth.Location = new Point(248, 177 + i);
            addBlank.lblHeight.Location = new Point(416, 177 + i);
            addBlank.lblAmount.Location = new System.Drawing.Point(626, 177+i);

            this.Controls.Add(addBlank.lblTreeSpecies);
            this.Controls.Add(addBlank.cbTreeSpecies);
            this.Controls.Add(addBlank.btDelete);
            this.Controls.Add(addBlank.tbLength);
            Controls.Add(addBlank.lblSize);
            Controls.Add(addBlank.lblLength);
            Controls.Add(addBlank.lblHeight);
            Controls.Add(addBlank.lblWidth);
            Controls.Add(addBlank.tbAmount);
            Controls.Add(addBlank.tbWidth);
            Controls.Add(addBlank.tbHeight);
            //addBlank.btDelete+= btDelete_Click
            addBlank.btDelete.Click += new EventHandler(btDelete_Click);

            btSave.Location = new Point(226, 372 + i);
            btCancel.Location = new Point (455, 372+i);
        }
        void btDelete_Click(object sender, EventArgs e)
        {
            i = i - 155;

        }

        private void tbAddSize_Click(object sender, EventArgs e)
        {
            i = i + 35;
            
            AddBlank addBlank = new AddBlank();
        
      
       //     addBlank.btDelete.Location = new System.Drawing.Point(400, 104 + i);
           
            addBlank.tbLength.Location = new Point(73, 206 + i);
            addBlank.tbWidth.Location = new Point(248, 206 + i);
            addBlank.tbHeight.Location = new Point(416, 206 + i);
            addBlank.tbAmount.Location = new Point(626, 206 + i);
         


          //  this.Controls.Add(addBlank.btDelete);
            this.Controls.Add(addBlank.tbLength);
   
            Controls.Add(addBlank.tbAmount);
            Controls.Add(addBlank.tbWidth);
            Controls.Add(addBlank.tbHeight);
            btSave.Location = new Point(226, 372 + i);
            btCancel.Location = new Point(455, 372 + i);
        }
    }
}
