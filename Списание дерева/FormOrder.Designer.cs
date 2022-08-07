
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
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.cbTreeSpecies = new System.Windows.Forms.ComboBox();
            this.lblTreeSpecies = new System.Windows.Forms.Label();
            this.tbNumberOrder = new System.Windows.Forms.TextBox();
            this.lblNumberOrder = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(441, 374);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(94, 29);
            this.btCancel.TabIndex = 36;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(212, 374);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(94, 29);
            this.btSave.TabIndex = 35;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(212, 267);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(151, 27);
            this.tbAmount.TabIndex = 34;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(59, 270);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(90, 20);
            this.lblAmount.TabIndex = 33;
            this.lblAmount.Text = "Количество";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(591, 189);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(93, 20);
            this.lblHeight.TabIndex = 32;
            this.lblHeight.Text = "Высота   мм";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(393, 189);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(101, 20);
            this.lblWidth.TabIndex = 31;
            this.lblWidth.Text = "Ширина   мм";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(212, 189);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(87, 20);
            this.lblLength.TabIndex = 30;
            this.lblLength.Text = "Длина   мм";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(591, 212);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(151, 27);
            this.tbHeight.TabIndex = 29;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(393, 212);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(151, 27);
            this.tbWidth.TabIndex = 28;
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(212, 212);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(151, 27);
            this.tbLength.TabIndex = 27;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(59, 215);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(133, 20);
            this.lblSize.TabIndex = 26;
            this.lblSize.Text = "Размер заготовки";
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
            this.cbTreeSpecies.Location = new System.Drawing.Point(212, 149);
            this.cbTreeSpecies.Name = "cbTreeSpecies";
            this.cbTreeSpecies.Size = new System.Drawing.Size(151, 28);
            this.cbTreeSpecies.TabIndex = 25;
            // 
            // lblTreeSpecies
            // 
            this.lblTreeSpecies.AutoSize = true;
            this.lblTreeSpecies.Location = new System.Drawing.Point(59, 149);
            this.lblTreeSpecies.Name = "lblTreeSpecies";
            this.lblTreeSpecies.Size = new System.Drawing.Size(116, 20);
            this.lblTreeSpecies.TabIndex = 24;
            this.lblTreeSpecies.Text = "Порода дерева";
            // 
            // tbNumberOrder
            // 
            this.tbNumberOrder.Location = new System.Drawing.Point(212, 48);
            this.tbNumberOrder.Name = "tbNumberOrder";
            this.tbNumberOrder.Size = new System.Drawing.Size(151, 27);
            this.tbNumberOrder.TabIndex = 23;
            // 
            // lblNumberOrder
            // 
            this.lblNumberOrder.AutoSize = true;
            this.lblNumberOrder.Location = new System.Drawing.Point(59, 51);
            this.lblNumberOrder.Name = "lblNumberOrder";
            this.lblNumberOrder.Size = new System.Drawing.Size(106, 20);
            this.lblNumberOrder.TabIndex = 22;
            this.lblNumberOrder.Text = "Номер заказа";
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Items.AddRange(new object[] {
            "Unica",
            "Lady",
            "Kreola"});
            this.cbModel.Location = new System.Drawing.Point(474, 48);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(151, 28);
            this.cbModel.TabIndex = 21;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(393, 51);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(63, 20);
            this.lblModel.TabIndex = 20;
            this.lblModel.Text = "Модель";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FormOrder";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cbTreeSpecies;
        private System.Windows.Forms.Label lblTreeSpecies;
        private System.Windows.Forms.TextBox tbNumberOrder;
        private System.Windows.Forms.Label lblNumberOrder;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label lblModel;
    }
}