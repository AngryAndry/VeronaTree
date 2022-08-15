using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Списание_дерева
{
    class AddBlankSize
    {
      
        public TextBox tbLength { get; set; }
        public TextBox tbWidth { get; set; }
        public TextBox tbHeight { get; set; }
        public TextBox tbAmount { get; set; }
        public Button btDelete { get; set; }

        public AddBlankSize()
        {

            btDelete = new Button();
            btDelete.Text = "-";
            btDelete.Size = new System.Drawing.Size(25, 29);
            btDelete.Name = "22";
            btDelete.Click += new EventHandler(btDelete_Click);
            tbLength = new TextBox();
            this.tbLength.Size = new System.Drawing.Size(133, 23);
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
        public void btDelete_Click(object sender, EventArgs e)
        {

            tbLength.Name = "KillMe";
            tbLength.Dispose();
           /* btDelete.Dispose();
            tbWidth.Dispose();
            tbHeight.Dispose();
            tbAmount.Dispose();*/
        }
    }
}
