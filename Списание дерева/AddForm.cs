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
            //cbTreeSpecies.SelectedIndexChanged += cbTreeSpecies_SelectedIndexChanged;
        }

        public AddForm(Form1 form1)
        {
            InitializeComponent();
            i = 0;
            f1 = form1;
            AddBlank addBlank = new();

            addBlank.lblSize.Location = new Point(73,143 + i);
            addBlank.lblLength.Location = new Point(73, 177+ i);
            addBlank.lblWidth.Location = new Point(248, 177 + i);
            addBlank.lblHeight.Location = new Point(416, 177 + i);
            addBlank.lblAmount.Location = new System.Drawing.Point(626, 177 + i);
            //addBlank.btAdd.Location = new System.Drawing.Point(tbAddSize.Location.X, tbAddSize.Location.Y + i);
            Controls.Add(addBlank.lblSize);
            Controls.Add(addBlank.lblLength);
            Controls.Add(addBlank.lblHeight);
            Controls.Add(addBlank.lblWidth);
            Controls.Add(addBlank.lblAmount);
           // Controls.Add(addBlank.btAdd);
                
                addBlank.addBlankSizes[0].tbLength.Location = new Point(73, 206 + i);
                addBlank.addBlankSizes[0].tbWidth.Location = new Point(248, 206 + i);
                addBlank.addBlankSizes[0].tbHeight.Location = new Point(416, 206 + i);
                addBlank.addBlankSizes[0].tbAmount.Location = new Point(626, 206 + i);
                this.Controls.Add(addBlank.addBlankSizes[0].tbLength);
                Controls.Add(addBlank.addBlankSizes[0].tbAmount);
                Controls.Add(addBlank.addBlankSizes[0].tbWidth);
                Controls.Add(addBlank.addBlankSizes[0].tbHeight);
            addBlank.addBlankSizes[0].btDelete.Click += new EventHandler(btDelete_Click);
            addBlank.lblTreeSpecies.Location = new System.Drawing.Point(73, 104 + i);
            addBlank.cbTreeSpecies.Location = new System.Drawing.Point(226, 104 + i);
            addBlank.tbAddSize.Click += new System.EventHandler(this.tbAddSize_Click);

            Controls.Add(addBlank.tbAddSize);
            this.Controls.Add(addBlank.lblTreeSpecies);
            this.Controls.Add(addBlank.cbTreeSpecies);
            addBlanks.Add(addBlank);
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
        //    sizeSemimanufactures = new SizeSemimanufactures(Int32.Parse(tbLength.Text), Int32.Parse(tbWidth.Text), Int32.Parse(tbHeight.Text), Int32.Parse(tbAmount.Text));
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
        //     selectedTreeSpecies = cbTreeSpecies.SelectedItem.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        AddBlank addBlank = new AddBlank();

            i = i + 155;
            addBlank.lblSize.Location = new Point(73, 143 + i);
            addBlank.lblLength.Location = new Point(73, 177 + i);
            addBlank.lblWidth.Location = new Point(248, 177 + i);
            addBlank.lblHeight.Location = new Point(416, 177 + i);
            addBlank.lblAmount.Location = new System.Drawing.Point(416, 177 + i);
           // addBlank.tbAddSize.Location = new Point(addBlank.tbAddSize.Location.X, addBlank.tbAddSize.Location.Y + i);
            //addBlank.btAdd.Location = new System.Drawing.Point(tbAddSize.Location.X, tbAddSize.Location.Y + i);
            Controls.Add(addBlank.lblSize);
            Controls.Add(addBlank.lblLength);
            Controls.Add(addBlank.lblHeight);
            Controls.Add(addBlank.lblWidth);
            Controls.Add(addBlank.lblAmount);
            Controls.Add(addBlank.btAdd);
          //  Controls.Add(addBlank.tbAddSize);
            
            foreach (var item in addBlank.addBlankSizes)
            {
                
          //  item.btDelete.Location = new System.Drawing.Point(addBlank.tbAddSize.Location.X, addBlank.tbAddSize.Location.Y + i);
                item.tbLength.Location = new Point(73, 206+i);
                item.tbWidth.Location = new Point(248, 206+i);
                item.tbHeight.Location = new Point(416, 206 + i);
                item.tbAmount.Location = new Point(626, 206 + i);
                // this.Controls.Add(item.btDelete);

                //   item.btDelete.Click += new EventHandler(btDelete_Click);

            this.Controls.Add(item.tbLength);
            Controls.Add(item.tbAmount);
            Controls.Add(item.tbWidth);
            Controls.Add(item.tbHeight);
                addBlanks.Add(addBlank);
            }
                addBlank.tbAddSize.Click += new System.EventHandler(this.tbAddSize_Click);
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
            foreach (var addBlank in addBlanks)
            {

                addBlank.lblSize.Dispose();
                addBlank.lblLength.Dispose();
                addBlank.lblWidth.Dispose();
                addBlank.lblHeight.Dispose();
                addBlank.lblAmount.Dispose();
                foreach (var item in addBlank.addBlankSizes)
                {
                    Controls.Add(item.tbLength);
                    Controls.Add(item.tbAmount);
                    Controls.Add(item.tbWidth);
                    Controls.Add(item.tbHeight);
                }
            }
            UpdateForm();      
        }
        Button but;
        void btSizeDelete_Click(object sender, EventArgs e)
        {
          
            UpdateForm();

        }

        private void tbAddSize_Click(object sender, EventArgs e)
        {
            i = i + 35;
            AddBlankSize addBlank = new AddBlankSize();
            
            //addBlanks[addBlanks.Count - 1].addNewBlankSize();
            addBlank.tbLength.Location = new Point(73, 206 + i);
            addBlank.tbWidth.Location = new Point(248,206+ i);
            addBlank.tbHeight.Location = new Point(416,206 + i);
            addBlank.tbAmount.Location = new Point(626,206 + i);
            addBlank.btDelete.Location = new System.Drawing.Point(addBlanks[0].tbAddSize.Location.X, addBlanks[0].tbAddSize.Location.Y + i);
 
            this.Controls.Add(addBlank.tbLength);

                Controls.Add(addBlank.tbAmount);
                Controls.Add(addBlank.tbWidth);
                Controls.Add(addBlank.tbHeight);
            Controls.Add(addBlank.btDelete);
                btSave.Location = new Point(226, 372 + i);
                btCancel.Location = new Point(455, 372 + i);

            //  addBlank[addBlanks.Count - 1].btDelete.Location = new System.Drawing.Point(400, 104 + i);
            addBlank.btDelete.Click += new EventHandler(btSizeDelete_Click);
            addBlanks[0].addBlankSizes.Add(addBlank);

        }
        private void addNewBlank() {
            AddBlank addBlank = new();
            addBlanks.Add(addBlank);
                }
        private void UpdateForm()
        {
            i = 0;
            foreach (var addBlank in addBlanks)
            {
                Controls.Remove(addBlank.lblSize);
                Controls.Remove(addBlank.lblLength);
                Controls.Remove(addBlank.lblWidth);
                Controls.Remove(addBlank.lblHeight);
                Controls.Remove(addBlank.lblAmount);
                
                foreach (var item in addBlank.addBlankSizes)
                {
                    Controls.Remove(item.tbLength);
                    Controls.Remove(item.tbAmount);
                    Controls.Remove(item.tbWidth);
                    Controls.Remove(item.tbHeight);
                    Controls.Remove(item.btDelete);

                }
            }
            

            foreach (var addBlank in addBlanks)
            {

                addBlank.lblTreeSpecies.Location = new System.Drawing.Point(73, 104 + i);
                addBlank.cbTreeSpecies.Location = new System.Drawing.Point(226, 104 + i);
                addBlank.lblSize.Location = new Point(73, 143 + i);
                addBlank.lblLength.Location = new Point(73, 177 + i);
                addBlank.lblWidth.Location = new Point(248, 177 + i);
                addBlank.lblHeight.Location = new Point(416, 177 + i);
                addBlank.lblAmount.Location = new Point(626, 177 + i);
                //addBlank.btAdd.Location = new System.Drawing.Point(tbAddSize.Location.X, tbAddSize.Location.Y + i);
                Controls.Add(addBlank.lblSize);
                Controls.Add(addBlank.lblLength);
                Controls.Add(addBlank.lblHeight);
                Controls.Add(addBlank.lblWidth);
                Controls.Add(addBlank.lblAmount);
               // Controls.Add(addBlank.btAdd);
                for (int i = 0; i < addBlank.addBlankSizes.Count; i++)
                {
                    if (addBlank.addBlankSizes[i].tbLength.Name == "KillMe")
                    {
                        addBlank.addBlankSizes.RemoveAt(i);
                    }

                }

                foreach (var item in addBlank.addBlankSizes)
                {


                    item.tbLength.Location = new Point(73, 206 + i);
                    item.tbWidth.Location = new Point(248, 206 + i);
                    item.tbHeight.Location = new Point(416, 206 + i);
                    item.tbAmount.Location = new Point(626, 206 + i);
                    addBlank.btDelete.Location = new System.Drawing.Point(addBlanks[0].tbAddSize.Location.X, addBlanks[0].tbAddSize.Location.Y + i);
                    Controls.Add(item.btDelete);
                    Controls.Add(item.tbLength);
                    Controls.Add(item.tbAmount);
                    Controls.Add(item.tbWidth);
                    Controls.Add(item.tbHeight);
                    item.btDelete.Click += new EventHandler(btDelete_Click);
                    i += 35;
                }
              
                addBlank.tbAddSize.Click += new System.EventHandler(this.tbAddSize_Click);

                Controls.Add(addBlank.tbAddSize);
                this.Controls.Add(addBlank.lblTreeSpecies);
                this.Controls.Add(addBlank.cbTreeSpecies);
                
                //i += 155;
            }
        }
    }
}
