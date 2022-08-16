
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
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.dGVSize = new System.Windows.Forms.DataGridView();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(425, 37);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 15);
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
            this.cbModel.Location = new System.Drawing.Point(494, 34);
            this.cbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(133, 23);
            this.cbModel.TabIndex = 4;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            // 
            // lblNumberOrder
            // 
            this.lblNumberOrder.AutoSize = true;
            this.lblNumberOrder.Location = new System.Drawing.Point(64, 37);
            this.lblNumberOrder.Name = "lblNumberOrder";
            this.lblNumberOrder.Size = new System.Drawing.Size(82, 15);
            this.lblNumberOrder.TabIndex = 5;
            this.lblNumberOrder.Text = "Номер заказа";
            // 
            // tbNumberOrder
            // 
            this.tbNumberOrder.Location = new System.Drawing.Point(198, 34);
            this.tbNumberOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumberOrder.Name = "tbNumberOrder";
            this.tbNumberOrder.Size = new System.Drawing.Size(133, 23);
            this.tbNumberOrder.TabIndex = 6;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(198, 305);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(82, 22);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(402, 305);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(82, 22);
            this.btCancel.TabIndex = 19;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // dGVSize
            // 
            this.dGVSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Length,
            this.Height,
            this.Width,
            this.Amount});
            this.dGVSize.Location = new System.Drawing.Point(64, 124);
            this.dGVSize.Name = "dGVSize";
            this.dGVSize.RowTemplate.Height = 25;
            this.dGVSize.Size = new System.Drawing.Size(563, 164);
            this.dGVSize.TabIndex = 21;
            this.dGVSize.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSize_CellContentClick);
            // 
            // Length
            // 
            this.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Length.HeaderText = "Длина";
            this.Length.Name = "Length";
            // 
            // Height
            // 
            this.Height.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Height.HeaderText = "Ширина";
            this.Height.Name = "Height";
            // 
            // Width
            // 
            this.Width.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Width.HeaderText = "Высота";
            this.Width.Name = "Width";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.HeaderText = "Количество";
            this.Amount.Name = "Amount";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.dGVSize);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbNumberOrder);
            this.Controls.Add(this.lblNumberOrder);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.lblModel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddForm";
            this.Text = "Добавление заказа";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label lblNumberOrder;
        private System.Windows.Forms.TextBox tbNumberOrder;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridView dGVSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}