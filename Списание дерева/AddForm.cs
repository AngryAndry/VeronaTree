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
using System.IO;
using System.Drawing.Printing;

using Spire.Doc;
using System.Diagnostics;
using GemBox.Document;
using Microsoft.VisualBasic.ApplicationServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            i = 0;
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


        private void tbLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
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
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
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
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
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
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
      
        private  void btSave_Click(object sender, EventArgs e)
        {

            using (ApplicationContext db = new ApplicationContext())
            {


                // создание и добавление моделей
                Order order = new Order { numberOrder = tbNumberOrder.Text.ToString(), model = selectedModel, date = DateTime.Now.ToString() };

                db.Orders.AddRange(order);

                Semimanufactures semimanufactures = new Semimanufactures { treeSpecies = selectedTreeSpecies, order = order };
                db.semimanufactures.AddRange(semimanufactures);
                List<SizeSemimanufactures> sizeSemimanufactures1 = new();
                for (int i = 0; i < dGVSize.Rows.Count - 1; i++)
                {

                    SizeSemimanufactures sizeSemimanufactures = new SizeSemimanufactures
                    {
                        semimanufactures = semimanufactures,
                        amount = Int32.Parse(dGVSize.Rows[i].Cells[0].Value.ToString())
                    ,
                        length = Int32.Parse(dGVSize.Rows[i].Cells[1].Value.ToString())
                    ,
                        width = Int32.Parse(dGVSize.Rows[i].Cells[2].Value.ToString())
                    ,
                        height = Int32.Parse(dGVSize.Rows[i].Cells[3].Value.ToString())
                    };
                    sizeSemimanufactures1.Add(sizeSemimanufactures);
                }

                db.sizeSemimanufactures.AddRange(sizeSemimanufactures1);
                db.SaveChanges();
            }
           
           
       
            f1.PopulateDataGrid();
          this.Close();
        
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

        private void btSaveAndPrint_Click(object sender, EventArgs e)
        {
          
            using (ApplicationContext db = new ApplicationContext())
            {
                

                // создание и добавление моделей
                Order order = new Order { numberOrder = tbNumberOrder.Text.ToString(), model =selectedModel, date =DateTime.Now.ToString() };
                
                db.Orders.AddRange(order);
               
                Semimanufactures semimanufactures = new Semimanufactures { treeSpecies = selectedTreeSpecies , order = order };
                db.semimanufactures.AddRange(semimanufactures);
                List<SizeSemimanufactures> sizeSemimanufactures1 = new ();
                for (int i = 0; i < dGVSize.Rows.Count-1; i++)
                {
                
                SizeSemimanufactures sizeSemimanufactures = new SizeSemimanufactures { semimanufactures =semimanufactures,
                    amount = Int32.Parse(dGVSize.Rows[i].Cells[0].Value.ToString())
                ,
                    length = Int32.Parse(dGVSize.Rows[i].Cells[1].Value.ToString())
                ,
                    width = Int32.Parse(dGVSize.Rows[i].Cells[2].Value.ToString())
                ,
                    height = Int32.Parse(dGVSize.Rows[i].Cells[3].Value.ToString())
                };
                    sizeSemimanufactures1.Add(sizeSemimanufactures);
                }
                
                db.sizeSemimanufactures.AddRange(sizeSemimanufactures1);
                db.SaveChanges();
            }
           
            
           
            using (DocX doc = DocX.Create("test.docx"))
            {

                doc.InsertParagraph("Заборный лист на древесину для фасадов").FontSize(20).Bold().Alignment = Alignment.center;
                Xceed.Document.NET.Paragraph paragraph = doc.InsertParagraph();
                paragraph.Alignment = Alignment.right;
                paragraph.AppendLine();

                paragraph.Append("Модель :  ").FontSize(14).Alignment = Alignment.left;
                paragraph.Append(cbModel.Text).FontSize(14).Bold().Alignment = Alignment.left;

                paragraph.AppendLine();
                paragraph.Append("Заказ :  №").FontSize(14).Alignment = Alignment.left;
                paragraph.Append(tbNumberOrder.Text).FontSize(14).Bold().Alignment = Alignment.left;

                paragraph.AppendLine();
                paragraph.Append("Порода дерева :  ").FontSize(14).Alignment = Alignment.left;
                paragraph.Append(selectedTreeSpecies).FontSize(14).Bold().Alignment = Alignment.left;






                Xceed.Document.NET.Table t = doc.AddTable(dGVSize.Rows.Count, dGVSize.Columns.Count + 1);

                t.Rows[0].Cells[0].Paragraphs[0].Append("Длина  ММ");
                t.Rows[0].Cells[1].Paragraphs[0].Append("Ширина  ММ");
                t.Rows[0].Cells[2].Paragraphs[0].Append("Высота  ММ");
                t.Rows[0].Cells[3].Paragraphs[0].Append("Количество ШТ");
                t.Rows[0].Cells[4].Paragraphs[0].Append("Объём  М3");
                List<Decimal> v = new List<decimal>();
                Decimal val;
                for (int j = 0; j < dGVSize.Rows.Count - 1; j++)
                {
                    for (int k = 0; k < dGVSize.Columns.Count + 1; k++)
                    {
                        if (k == 4)
                        {
                            val = decimal.Parse(dGVSize.Rows[j].Cells[0].Value.ToString()) *
                                   decimal.Parse(dGVSize.Rows[j].Cells[1].Value.ToString()) * decimal.Parse(dGVSize.Rows[j].Cells[2].Value.ToString()) *
                                   decimal.Parse(dGVSize.Rows[j].Cells[3].Value.ToString()) * 0.000000001m;
                            t.Rows[j + 1].Cells[k].Paragraphs[0].Append((val).ToString());
                            v.Add(val);
                        }
                        else
                            t.Rows[j + 1].Cells[k].Paragraphs[0].Append(dGVSize.Rows[j].Cells[k].Value.ToString());
                        // t.Rows[j + 1].Cells[k + 1].Range.Text = dGVSize.Rows[j].Cells[k].Value.ToString();

                    }

                }
                val = 0;
                doc.InsertParagraph().InsertTableAfterSelf(t);
                foreach (var i in v)
                {
                    val += i;
                }

                doc.InsertParagraph("Общий объём = " + val).Bold().Alignment = Alignment.right;
                doc.AddFooters();

                doc.DifferentFirstPage = true;
                doc.DifferentOddAndEvenPages = true;
                doc.Footers.First.InsertParagraph("Ответственный___________________________________________________     " + DateTime.Now).FontSize(12).Bold().Alignment = Alignment.left;
                doc.Save();

            }
            FileInfo f = new FileInfo("test.docx");
            string fullname = f.FullName;

            var pi = new ProcessStartInfo(fullname);
            pi.UseShellExecute = true;
            pi.Verb = "print";
            var process = System.Diagnostics.Process.Start(pi);



            f1.PopulateDataGrid();
            //DocumentModel.Load(fullname, LoadOptions.DocxDefault).Print();
            this.Close();
        }

        private void dGVSize_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           
        }
    }
}
