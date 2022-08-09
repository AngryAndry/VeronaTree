using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Списание_дерева.Model
{
    class AddBlank
    {
        public Label lblTreeSpecies { get; set; }
        public ComboBox cbTreeSpecies { get; set; }
        public Label lblSize { get; set; }
        public Label lblLength { get; set; }
        public Label lblWidth { get; set; }
        public Label lblHeight { get; set; }
        public TextBox tbLength { get; set; }
        public TextBox tbWidth { get; set; }
        public TextBox tbHeight { get; set; }
        public Label lblAmount { get; set; }
        public TextBox tbAmount { get; set; }
        public Button btDelete { get; set; }
        public Button btAdd { get; set; }
        public List<AddBlankSize> addBlankSizes;
        public AddBlank()
        {
            addBlankSizes = new List<AddBlankSize>();
            AddBlankSize _addBlankSize = new AddBlankSize();
            addBlankSizes.Add(_addBlankSize);
            lblTreeSpecies = new Label();
            lblTreeSpecies.AutoSize = true;
            lblTreeSpecies.Size = new System.Drawing.Size(73, 104);
            lblTreeSpecies.Text = "Порода дерева";


            cbTreeSpecies = new ComboBox();
            cbTreeSpecies.FormattingEnabled = true;
            cbTreeSpecies.Items.AddRange(new object[] {
            "Ясень",
            "Ольха ",
            "Липа",
            "Акация ",
            "Дуб"});
            cbTreeSpecies.Size = new System.Drawing.Size(151, 28);

            lblSize = new Label();
            lblSize.AutoSize = true;
            lblSize.Size = new System.Drawing.Size(133, 20);
            lblSize.Text = "Размер заготовки";

            lblLength = new Label();
            this.lblLength.AutoSize = true;
            this.lblLength.Size = new System.Drawing.Size(87, 20);
            this.lblLength.Text = "Длина   мм";

            lblWidth = new Label();
            this.lblWidth.AutoSize = true;
            this.lblWidth.Size = new System.Drawing.Size(87, 20);
            this.lblWidth.Text = "Ширина   мм";

            lblHeight = new Label();
            this.lblHeight.AutoSize = true;
            this.lblHeight.Size = new System.Drawing.Size(87, 20);
            this.lblHeight.Text = "Высота   мм";

            lblAmount = new Label();
            this.lblAmount.AutoSize = true;
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(90, 20);
            this.lblAmount.Text = "Количество";


           btDelete = new Button();
            btDelete.Text = "-";
            btDelete.Size = new System.Drawing.Size(25, 29);
            btDelete.Name = "22";
            btDelete.Click +=new EventHandler( btDelete_Click);

            btAdd = new Button();
            btAdd.Text = "+";
            btAdd.Size = new System.Drawing.Size(25, 29);
         
            /*
              tbLength = new TextBox();
              this.tbLength.Size = new System.Drawing.Size(151, 27);
              this.tbLength.KeyPress += new KeyPressEventHandler(tbLength_KeyPress);


              tbWidth = new TextBox();
              this.tbWidth.Size = new System.Drawing.Size(151, 27);
              this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLength_KeyPress);

              tbHeight = new TextBox();
              this.tbHeight.Size = new System.Drawing.Size(151, 27);
              this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLength_KeyPress);

              tbAmount = new TextBox();
              this.tbAmount.Size = new System.Drawing.Size(151, 27);
              this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLength_KeyPress);
         */
        }

        public void addNewBlankSize()
        {
            AddBlankSize _addNewBlankSize = new AddBlankSize();
            addBlankSizes.Add(_addNewBlankSize);
            
        }
        void btDelete_Click(object sender, EventArgs e)
        {
            lblTreeSpecies.Dispose();
            cbTreeSpecies.Dispose();
            
            foreach (var item in addBlankSizes)
            {
                item.btDelete.PerformClick();
            }

            lblLength.Dispose();
            lblHeight.Dispose();
            lblWidth.Dispose();
            lblAmount.Dispose();

           lblSize.Dispose();
          /*  btDelete.Dispose();
            tbLength.Dispose();
            tbWidth.Dispose();
            tbHeight.Dispose();
            tbAmount.Dispose();*/
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


    }
}
