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
        List<AddBlank> addBlanks = new List<AddBlank>();

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
        AddBlank addBlank = new AddBlank();

            i = i + 155;
            addBlank.lblSize.Location = new Point(lblSize.Location.X, lblSize.Location.Y+i);
            addBlank.lblLength.Location = new Point(lblLength.Location.X, lblLength.Location.Y + i);
            addBlank.lblWidth.Location = new Point(lblWidth.Location.X, lblWidth.Location.Y + i);
            addBlank.lblHeight.Location = new Point(lblHeight.Location.X, lblHeight.Location.Y + i);
            addBlank.lblAmount.Location = new System.Drawing.Point(lblAmount.Location.X, lblAmount.Location.Y+ i);
            //addBlank.btAdd.Location = new System.Drawing.Point(tbAddSize.Location.X, tbAddSize.Location.Y + i);
            Controls.Add(addBlank.lblSize);
            Controls.Add(addBlank.lblLength);
            Controls.Add(addBlank.lblHeight);
            Controls.Add(addBlank.lblWidth);
            Controls.Add(addBlank.btAdd);
            
            foreach (var item in addBlank.addBlankSizes)
            {
                
            item.btDelete.Location = new System.Drawing.Point(tbAddSize.Location.X, tbAddSize.Location.Y + i);
                item.tbLength.Location = new Point(73, 206+i);
                item.tbWidth.Location = new Point(248, 206+i);
                item.tbHeight.Location = new Point(416, 206 + i);
                item.tbAmount.Location = new Point(626, 206 + i);
            this.Controls.Add(item.btDelete);
            this.Controls.Add(item.tbLength);
            Controls.Add(item.tbAmount);
            Controls.Add(item.tbWidth);
            Controls.Add(item.tbHeight);
                item.btDelete.Click += new EventHandler(btDelete_Click);


            }
            addBlank.lblTreeSpecies.Location = new System.Drawing.Point(73, 104 + i);
            addBlank.cbTreeSpecies.Location = new System.Drawing.Point(226, 104+ i);

            this.Controls.Add(addBlank.lblTreeSpecies);
            this.Controls.Add(addBlank.cbTreeSpecies);
            //addBlank.btDelete+= btDelete_Click
            addBlank.btDelete.Click += new EventHandler(btDelete_Click);
            addBlank.btAdd.Click += new EventHandler(tbAddSize_Click);

            btSave.Location = new Point(226, 372 + i);
            btCancel.Location = new Point (455, 372+i);
        }
        void btDelete_Click(object sender, EventArgs e)
        {
            i = i - 155;

        }
                void btSizeDelete_Click(object sender, EventArgs e)
        {
            i = i - 35;
         
        }

        private void tbAddSize_Click(object sender, EventArgs e)
        {
            i = i + 35;
            addNewBlank();
            addBlanks[addBlanks.Count - 1].addNewBlankSize();
            addBlanks[addBlanks.Count - 1].addBlankSizes[addBlanks[addBlanks.Count - 1].addBlankSizes.Count-1].tbLength.Location = new Point(tbLength.Location.X, tbLength.Location.Y + i);

            addBlanks[addBlanks.Count - 1].addBlankSizes[addBlanks[addBlanks.Count - 1].addBlankSizes.Count-1].tbWidth.Location = new Point(248, 206 + i);
            addBlanks[addBlanks.Count - 1].addBlankSizes[addBlanks[addBlanks.Count - 1].addBlankSizes.Count-1].tbHeight.Location = new Point(416, 206 + i);
            addBlanks[addBlanks.Count - 1].addBlankSizes[addBlanks[addBlanks.Count - 1].addBlankSizes.Count-1].tbAmount.Location = new Point(626, 206 + i);
            addBlanks[addBlanks.Count - 1].addBlankSizes[addBlanks[addBlanks.Count - 1].addBlankSizes.Count - 1].btDelete.Location = new System.Drawing.Point(tbAddSize.Location.X, tbAddSize.Location.Y + i);



            //  this.Controls.Add(addBlank.btDelete);
            this.Controls.Add(addBlanks[addBlanks.Count - 1].addBlankSizes[addBlanks[addBlanks.Count - 1].addBlankSizes.Count-1].tbLength);

                Controls.Add(addBlanks[addBlanks.Count - 1].addBlankSizes[addBlanks[addBlanks.Count - 1].addBlankSizes.Count-1].tbAmount);
                Controls.Add(addBlanks[addBlanks.Count - 1].addBlankSizes[addBlanks[addBlanks.Count - 1].addBlankSizes.Count-1].tbWidth);
                Controls.Add(addBlanks[addBlanks.Count - 1].addBlankSizes[addBlanks[addBlanks.Count - 1].addBlankSizes.Count-1].tbHeight);
            Controls.Add(addBlanks[addBlanks.Count - 1].addBlankSizes[addBlanks[addBlanks.Count - 1].addBlankSizes.Count - 1].btDelete);
                btSave.Location = new Point(226, 372 + i);
                btCancel.Location = new Point(455, 372 + i);

            //  addBlank[addBlanks.Count - 1].btDelete.Location = new System.Drawing.Point(400, 104 + i);
            addBlanks[addBlanks.Count - 1].addBlankSizes[addBlanks[addBlanks.Count - 1].addBlankSizes.Count - 1].btDelete.Click += new EventHandler(btSizeDelete_Click);


        }
        private void addNewBlank() {
            AddBlank addBlank = new();
            addBlanks.Add(addBlank);
                }
    }
}
