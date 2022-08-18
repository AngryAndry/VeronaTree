using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Microsoft.Office.Interop.Word;
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

            addBlank.btAdd.Location = new System.Drawing.Point(370,92);
            addBlank.lblTreeSpecies.Location = new System.Drawing.Point(68, 95);
            addBlank.cbTreeSpecies.Location = new System.Drawing.Point(200, 95);            
            this.Controls.Add(addBlank.lblTreeSpecies);
            this.Controls.Add(addBlank.cbTreeSpecies);
            this.Controls.Add(addBlank.btAdd);
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
           
         /*   for (int j = 1; j < dGVSize.Rows.Count; j++)
            {
                if (dGVSize.Rows[j].Cells[1].Value != null)
                {
                    SizeSemimanufactures sizeSemimanufactur = new SizeSemimanufactures(Int32.Parse(dGVSize.Rows[j].Cells[0].Value.ToString()),
                        Int32.Parse(dGVSize.Rows[j].Cells[1].Value.ToString()),
                        Int32.Parse(dGVSize.Rows[j].Cells[2].Value.ToString()),
                        Int32.Parse(dGVSize.Rows[j].Cells[3].Value.ToString())
                        );
                    semimanufactures.sizeSemimanufactures.Add(sizeSemimanufactur);
                }
            }
            */
        
            order = new Order(selectedModel,tbNumberOrder.Text.ToString(),DateTime.Now);
            semimanufactures = new Semimanufactures(selectedTreeSpecies);
            order.semimanufactures.Add(semimanufactures);
             f1.orders.Add(order);

            DocX doc =DocX.Create("test.docx");
            doc.InsertParagraph("Заборный лист на древесину для фасадов").FontSize(32).Alignment = Alignment.center; ;
            doc.InsertParagraph("Модель  "+cbModel.Text+ "           заказ  №"+tbNumberOrder.Text);
            doc.InsertParagraph("Порода дерева  "+addBlanks[0].cbTreeSpecies.Text);
            
            Xceed.Document.NET.Table t = doc.AddTable( dGVSize.Rows.Count, dGVSize.Columns.Count+1);

                t.Rows[0].Cells[0].Paragraphs[0].Append("Длина");
                t.Rows[0].Cells[1].Paragraphs[0].Append("Ширина");
                t.Rows[0].Cells[2].Paragraphs[0].Append("Высота");
                t.Rows[0].Cells[3].Paragraphs[0].Append("Количество");
                t.Rows[0].Cells[4].Paragraphs[0].Append("Объём");
            for (int j = 0; j < dGVSize.Rows.Count - 1; j++)
            {
                for (int k = 0; k < dGVSize.Columns.Count+1; k++)
                {
                    if (k == 4)
                    {
                        t.Rows[j + 1].Cells[k].Paragraphs[0].Append((decimal.Parse(dGVSize.Rows[j].Cells[0].Value.ToString())*
                            decimal.Parse(dGVSize.Rows[j].Cells[1].Value.ToString())* decimal.Parse(dGVSize.Rows[j].Cells[2].Value.ToString())*
                            decimal.Parse(dGVSize.Rows[j].Cells[3].Value.ToString()) * 0.000000001m).ToString());
                    }           
                    else
                    t.Rows[j+1].Cells[k].Paragraphs[0].Append(dGVSize.Rows[j].Cells[k].Value.ToString());
                   // t.Rows[j + 1].Cells[k + 1].Range.Text = dGVSize.Rows[j].Cells[k].Value.ToString();

                }

            }
            
            doc.InsertParagraph().InsertTableAfterSelf(t);


            doc.AddFooters();

            doc.DifferentFirstPage = true; 
            doc.DifferentOddAndEvenPages = true;
            doc.Footers.First.InsertParagraph("Ответственный______________________________________________________ ").Bold();

            doc.Save();
            /*
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = app.Documents.Add(Visible: true);
            Microsoft.Office.Interop.Word.Range r = doc.Range(0,20);
            Microsoft.Office.Interop.Word.Range h = doc.Range();
            h.Text = "Бланк списания";
          //  doc.Paragraphs.Add(1);
            r.Text = "Бланк списания";
            Table t = doc.Tables.Add(r, dGVSize.Rows.Count, dGVSize.Columns.Count);

                    for (int j = 0; j < dGVSize.Rows.Count-1; j++) {

                        for (int k = 0; k < dGVSize.Columns.Count; k++)
                        {
                            t.Rows[j+1].Cells[k+1].Range.Text = dGVSize.Rows[j].Cells[k].Value.ToString();
                            
                        }

                    }
            //app.Documents.Open(@"C: \Users\Andry\Desktop\Doc1");
            doc.Save();
           
            doc.Close();
            app.Quit();
            */
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
            addBlank.lblTreeSpecies.Location = new System.Drawing.Point(73, 104 + i);
            addBlank.cbTreeSpecies.Location = new System.Drawing.Point(226, 104+ i);

            this.Controls.Add(addBlank.lblTreeSpecies);
            this.Controls.Add(addBlank.cbTreeSpecies);
            //addBlank.btDelete+= btDelete_Click
            addBlank.btAdd.Click += new EventHandler(tbAddSize_Click);

            btSave.Location = new System.Drawing.Point(226, 372 + i);
            btCancel.Location = new System.Drawing.Point (455, 372+i);
        }
     


        private void tbAddSize_Click(object sender, EventArgs e)
        {
            

        }
        private void addNewBlank() {
            AddBlank addBlank = new();
            addBlanks.Add(addBlank);
                }
        private void dGVSize_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
