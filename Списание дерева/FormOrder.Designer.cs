
namespace Списание_дерева
{
    partial class FormOrder
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.cbTreeSpecies = new System.Windows.Forms.ComboBox();
            this.lblTreeSpecies = new System.Windows.Forms.Label();
            this.tbNumberOrder = new System.Windows.Forms.TextBox();
            this.lblNumberOrder = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.dGVSize = new System.Windows.Forms.DataGridView();
            this.btSaveAndPrint = new System.Windows.Forms.Button();
            this.btDeleteOrder = new System.Windows.Forms.Button();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(415, 307);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(82, 22);
            this.btCancel.TabIndex = 36;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSave.Location = new System.Drawing.Point(235, 307);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(82, 22);
            this.btSave.TabIndex = 35;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
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
            this.cbTreeSpecies.Location = new System.Drawing.Point(178, 94);
            this.cbTreeSpecies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTreeSpecies.Name = "cbTreeSpecies";
            this.cbTreeSpecies.Size = new System.Drawing.Size(133, 23);
            this.cbTreeSpecies.TabIndex = 25;
            // 
            // lblTreeSpecies
            // 
            this.lblTreeSpecies.AutoSize = true;
            this.lblTreeSpecies.Location = new System.Drawing.Point(52, 94);
            this.lblTreeSpecies.Name = "lblTreeSpecies";
            this.lblTreeSpecies.Size = new System.Drawing.Size(89, 15);
            this.lblTreeSpecies.TabIndex = 24;
            this.lblTreeSpecies.Text = "Порода дерева";
            // 
            // tbNumberOrder
            // 
            this.tbNumberOrder.Location = new System.Drawing.Point(186, 36);
            this.tbNumberOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumberOrder.Name = "tbNumberOrder";
            this.tbNumberOrder.Size = new System.Drawing.Size(133, 23);
            this.tbNumberOrder.TabIndex = 23;
            // 
            // lblNumberOrder
            // 
            this.lblNumberOrder.AutoSize = true;
            this.lblNumberOrder.Location = new System.Drawing.Point(52, 38);
            this.lblNumberOrder.Name = "lblNumberOrder";
            this.lblNumberOrder.Size = new System.Drawing.Size(82, 15);
            this.lblNumberOrder.TabIndex = 22;
            this.lblNumberOrder.Text = "Номер заказа";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(344, 38);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 15);
            this.lblModel.TabIndex = 20;
            this.lblModel.Text = "Модель";
            // 
            // dGVSize
            // 
            this.dGVSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Length,
            this.Height,
            this.Width,
            this.Amount});
            this.dGVSize.Location = new System.Drawing.Point(10, 120);
            this.dGVSize.Name = "dGVSize";
            this.dGVSize.RowHeadersWidth = 51;
            this.dGVSize.RowTemplate.Height = 25;
            this.dGVSize.Size = new System.Drawing.Size(679, 164);
            this.dGVSize.TabIndex = 37;
            // 
            // btSaveAndPrint
            // 
            this.btSaveAndPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSaveAndPrint.Location = new System.Drawing.Point(10, 307);
            this.btSaveAndPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSaveAndPrint.Name = "btSaveAndPrint";
            this.btSaveAndPrint.Size = new System.Drawing.Size(193, 22);
            this.btSaveAndPrint.TabIndex = 38;
            this.btSaveAndPrint.Text = "Сохранить и распечатать";
            this.btSaveAndPrint.UseVisualStyleBackColor = true;
            this.btSaveAndPrint.Click += new System.EventHandler(this.btSaveAndPrint_Click);
            // 
            // btDeleteOrder
            // 
            this.btDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteOrder.BackColor = System.Drawing.Color.Red;
            this.btDeleteOrder.Location = new System.Drawing.Point(565, 307);
            this.btDeleteOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteOrder.Name = "btDeleteOrder";
            this.btDeleteOrder.Size = new System.Drawing.Size(124, 22);
            this.btDeleteOrder.TabIndex = 39;
            this.btDeleteOrder.Text = "Удалить заказ";
            this.btDeleteOrder.UseVisualStyleBackColor = false;
            this.btDeleteOrder.Click += new System.EventHandler(this.btDeleteOrder_Click);
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Items.AddRange(new object[] {
            "Unica",
            "Lady",
            "Kreola",
            "Victoria",
            "Cristina",
            "Naomi",
            "Vintage",
            "Grazia",
            "Karmen",
            "Valeriana",
            "Lea",
            "Asty",
            "Country",
            "НСТ",
            "___"});
            this.cbModel.Location = new System.Drawing.Point(415, 36);
            this.cbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(133, 23);
            this.cbModel.TabIndex = 40;
            // 
            // Length
            // 
            this.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Length.HeaderText = "Длина";
            this.Length.MinimumWidth = 6;
            this.Length.Name = "Length";
            // 
            // Height
            // 
            this.Height.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Height.HeaderText = "Ширина";
            this.Height.MinimumWidth = 6;
            this.Height.Name = "Height";
            // 
            // Width
            // 
            this.Width.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Width.HeaderText = "Толщина";
            this.Width.MinimumWidth = 6;
            this.Width.Name = "Width";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.HeaderText = "Количество";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.btDeleteOrder);
            this.Controls.Add(this.btSaveAndPrint);
            this.Controls.Add(this.dGVSize);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbTreeSpecies);
            this.Controls.Add(this.lblTreeSpecies);
            this.Controls.Add(this.tbNumberOrder);
            this.Controls.Add(this.lblNumberOrder);
            this.Controls.Add(this.lblModel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOrder";
            this.Text = "Заказ";
            ((System.ComponentModel.ISupportInitialize)(this.dGVSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbTreeSpecies;
        private System.Windows.Forms.Label lblTreeSpecies;
        private System.Windows.Forms.TextBox tbNumberOrder;
        private System.Windows.Forms.Label lblNumberOrder;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.DataGridView dGVSize;
        private System.Windows.Forms.Button btSaveAndPrint;
        private System.Windows.Forms.Button btDeleteOrder;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}