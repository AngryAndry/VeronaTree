using GemBox.Document;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Списание_дерева.Model;

namespace Списание_дерева
{
    public partial class FormOrder : Form
    {
        private Form1 f1;
        public string selectedModel { get; set; }
        public string selectedTreeSpecies { get; set; }
        public FormOrder()
        {
            InitializeComponent();

        }
        public FormOrder(Form1 form)
        {
            f1 = form;
            InitializeComponent();
            ComponentInfo.SetLicense("PDH37-2BD7F-BWOQG-E7EJV-RIDHSY");

            tbNumberOrder.Text = f1.dataGridView1[0, f1.dataGridView1.CurrentRow.Index].Value.ToString();
            cbModel.Text = f1.dataGridView1[1, f1.dataGridView1.CurrentRow.Index].Value.ToString();
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
                    if (u.numberOrder == tbNumberOrder.Text && u.model == cbModel.Text)
                    {
                        cbTreeSpecies.Text = u.semimanufactures;
                        dGVSize.Rows.Add(u.length, u.width, u.height, u.amount);
                    }
                }
            }


        }
        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedModel = cbModel.SelectedItem.ToString();
        }

        private void cbTreeSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTreeSpecies = cbTreeSpecies.SelectedItem.ToString();

        }
        private void btDeleteOrder_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var variable = db.Orders
     .Where(c => c.numberOrder == tbNumberOrder.Text)
     .FirstOrDefault();

                db.Orders.Remove(variable);
                db.SaveChanges();
            }
            f1.PopulateDataGrid();
            MessageBox.Show("Заказ удален");
            this.Close();

            /*      (from user in db.Users.Include(p => p.Company)
                   where user.CompanyId == 1
                   select user).ToList();*/
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {


                // создание и добавление моделей
                Order order = new Order { numberOrder = tbNumberOrder.Text.ToString(), model = cbModel.Text, date = DateTime.Now.ToString() };
                var variable = db.Orders
.Where(c => c.numberOrder == f1.dataGridView1[0, f1.dataGridView1.CurrentRow.Index].Value.ToString())
.FirstOrDefault();

                db.Orders.Remove(variable);
                db.Orders.AddRange(order);


                Semimanufactures semimanufactures = new Semimanufactures { treeSpecies = cbTreeSpecies.SelectedItem.ToString(), order = order };
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
             
            
            f1.PopulateDataGrid();
            db.SaveChanges();
            }



            f1.PopulateDataGrid();
            this.Close();
        }

        private void btSaveAndPrint_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {


                // создание и добавление моделей
                Order order = new Order { numberOrder = tbNumberOrder.Text.ToString(), model = cbModel.Text, date = DateTime.Now.ToString() };
                var variable = db.Orders
.Where(c => c.numberOrder == f1.dataGridView1[0, f1.dataGridView1.CurrentRow.Index].Value.ToString())
.FirstOrDefault();

                db.Orders.Remove(variable);
                db.Orders.AddRange(order);


                Semimanufactures semimanufactures = new Semimanufactures { treeSpecies = cbTreeSpecies.SelectedItem.ToString(), order = order };
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


                f1.PopulateDataGrid();
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
            using (PrintDialog printDialog1 = new PrintDialog())
            {
                var pi = new ProcessStartInfo(fullname);
                pi.UseShellExecute = true;
                pi.Verb = "print";
                var process = System.Diagnostics.Process.Start(pi);
            }
            f1.PopulateDataGrid();
           // DocumentModel.Load(fullname, LoadOptions.DocxDefault).Print();
            this.Close();

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

   
    

