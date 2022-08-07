
namespace Списание_дерева
{
    partial class AddForm
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblModel = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.lblNumberOrder = new System.Windows.Forms.Label();
            this.tbNumberOrder = new System.Windows.Forms.TextBox();
            this.cbTreeSpecies = new System.Windows.Forms.ComboBox();
            this.lblTreeSpecies = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAddBlank = new System.Windows.Forms.Button();
            this.tbAddSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(486, 49);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(63, 20);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Модель";
            this.lblModel.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Items.AddRange(new object[] {
            "Unica",
            "Lady",
            "Kreola"});
            this.cbModel.Location = new System.Drawing.Point(565, 46);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(151, 28);
            this.cbModel.TabIndex = 4;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            // 
            // lblNumberOrder
            // 
            this.lblNumberOrder.AutoSize = true;
            this.lblNumberOrder.Location = new System.Drawing.Point(73, 49);
            this.lblNumberOrder.Name = "lblNumberOrder";
            this.lblNumberOrder.Size = new System.Drawing.Size(106, 20);
            this.lblNumberOrder.TabIndex = 5;
            this.lblNumberOrder.Text = "Номер заказа";
            // 
            // tbNumberOrder
            // 
            this.tbNumberOrder.Location = new System.Drawing.Point(226, 46);
            this.tbNumberOrder.Name = "tbNumberOrder";
            this.tbNumberOrder.Size = new System.Drawing.Size(151, 27);
            this.tbNumberOrder.TabIndex = 6;
            // 
            // cbTreeSpecies
            // 
            this.cbTreeSpecies.FormattingEnabled = true;
            this.cbTreeSpecies.Items.AddRange(new object[] {
            "Ясень",
            "Ольха ",
            "Липа",
            "Акация ",
            "Дуб"});
            this.cbTreeSpecies.Location = new System.Drawing.Point(226, 104);
            this.cbTreeSpecies.Name = "cbTreeSpecies";
            this.cbTreeSpecies.Size = new System.Drawing.Size(151, 28);
            this.cbTreeSpecies.TabIndex = 8;
            this.cbTreeSpecies.SelectedIndexChanged += new System.EventHandler(this.cbTreeSpecies_SelectedIndexChanged);
            // 
            // lblTreeSpecies
            // 
            this.lblTreeSpecies.AutoSize = true;
            this.lblTreeSpecies.Location = new System.Drawing.Point(73, 104);
            this.lblTreeSpecies.Name = "lblTreeSpecies";
            this.lblTreeSpecies.Size = new System.Drawing.Size(116, 20);
            this.lblTreeSpecies.TabIndex = 7;
            this.lblTreeSpecies.Text = "Порода дерева";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(73, 206);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(151, 27);
            this.tbLength.TabIndex = 10;
            this.tbLength.TextChanged += new System.EventHandler(this.tbLength_TextChanged);
            this.tbLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLength_KeyPress);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(73, 147);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(133, 20);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Размер заготовки";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(248, 206);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(151, 27);
            this.tbWidth.TabIndex = 11;
            this.tbWidth.TextChanged += new System.EventHandler(this.tbWidth_TextChanged);
            this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidth_KeyPress);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(416, 206);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(151, 27);
            this.tbHeight.TabIndex = 12;
            this.tbHeight.TextChanged += new System.EventHandler(this.tbHeight_TextChanged);
            this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeight_KeyPress);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(73, 177);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(87, 20);
            this.lblLength.TabIndex = 13;
            this.lblLength.Text = "Длина   мм";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(248, 177);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(101, 20);
            this.lblWidth.TabIndex = 14;
            this.lblWidth.Text = "Ширина   мм";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(416, 177);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(93, 20);
            this.lblHeight.TabIndex = 15;
            this.lblHeight.Text = "Высота   мм";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(626, 206);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(151, 27);
            this.tbAmount.TabIndex = 17;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(626, 177);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(90, 20);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "Количество";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(226, 372);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(94, 29);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(455, 372);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(94, 29);
            this.btCancel.TabIndex = 19;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAddBlank
            // 
            this.btAddBlank.ForeColor = System.Drawing.Color.LimeGreen;
            this.btAddBlank.Location = new System.Drawing.Point(400, 104);
            this.btAddBlank.Name = "btAddBlank";
            this.btAddBlank.Size = new System.Drawing.Size(25, 29);
            this.btAddBlank.TabIndex = 20;
            this.btAddBlank.Text = "+";
            this.btAddBlank.UseVisualStyleBackColor = true;
            this.btAddBlank.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAddSize
            // 
            this.tbAddSize.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbAddSize.Location = new System.Drawing.Point(42, 206);
            this.tbAddSize.Name = "tbAddSize";
            this.tbAddSize.Size = new System.Drawing.Size(25, 29);
            this.tbAddSize.TabIndex = 21;
            this.tbAddSize.Text = "+";
            this.tbAddSize.UseVisualStyleBackColor = true;
            this.tbAddSize.Click += new System.EventHandler(this.tbAddSize_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAddSize);
            this.Controls.Add(this.btAddBlank);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cbTreeSpecies);
            this.Controls.Add(this.lblTreeSpecies);
            this.Controls.Add(this.tbNumberOrder);
            this.Controls.Add(this.lblNumberOrder);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.lblModel);
            this.Name = "AddForm";
            this.Text = "Добавление заказа";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label lblNumberOrder;
        private System.Windows.Forms.TextBox tbNumberOrder;
        private System.Windows.Forms.ComboBox cbTreeSpecies;
        private System.Windows.Forms.Label lblTreeSpecies;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAddBlank;
        private System.Windows.Forms.Button tbAddSize;
    }
}