namespace PRN_SE1624_WinFormsApp
{
    public partial class FrmAddProduct
    {
        private Label lbProductId;
        private Label lbProductName;
        private TextBox txtProductId;

        private TextBox txtProductName;
        private Label lbUnitPrice;
        private MaskedTextBox maskedTextBox1;
        private Label lbCreateDate;
        private Label lbDesc;
        private TextBox txtDesc;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lbContinued = new System.Windows.Forms.Label();
            this.grpContinued = new System.Windows.Forms.GroupBox();
            this.rdDiscontinued = new System.Windows.Forms.RadioButton();
            this.rdContinued = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.grpContinued.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(57, 60);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(97, 25);
            this.lbProductId.TabIndex = 0;
            this.lbProductId.Text = "Product ID";
            // 
            // txtProductId
            // 
            this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductId.Location = new System.Drawing.Point(239, 57);
            this.txtProductId.Multiline = true;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(364, 31);
            this.txtProductId.TabIndex = 1;
            this.txtProductId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductId_KeyDown);
            this.txtProductId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductId_KeyPress);
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(57, 118);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(126, 25);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Location = new System.Drawing.Point(239, 115);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(364, 31);
            this.txtProductName.TabIndex = 2;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(57, 170);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(86, 25);
            this.lbUnitPrice.TabIndex = 3;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(239, 167);
            this.maskedTextBox1.Mask = "0000.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(243, 24);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(57, 232);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(104, 25);
            this.lbCreateDate.TabIndex = 5;
            this.lbCreateDate.Text = "Create Date";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(55, 363);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(102, 25);
            this.lbDesc.TabIndex = 7;
            this.lbDesc.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Location = new System.Drawing.Point(239, 367);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(362, 135);
            this.txtDesc.TabIndex = 7;
            // 
            // lbContinued
            // 
            this.lbContinued.AutoSize = true;
            this.lbContinued.Location = new System.Drawing.Point(57, 300);
            this.lbContinued.Name = "lbContinued";
            this.lbContinued.Size = new System.Drawing.Size(94, 25);
            this.lbContinued.TabIndex = 9;
            this.lbContinued.Text = "Continued";
            // 
            // grpContinued
            // 
            this.grpContinued.Controls.Add(this.rdDiscontinued);
            this.grpContinued.Controls.Add(this.rdContinued);
            this.grpContinued.Location = new System.Drawing.Point(239, 285);
            this.grpContinued.Name = "grpContinued";
            this.grpContinued.Size = new System.Drawing.Size(362, 59);
            this.grpContinued.TabIndex = 10;
            this.grpContinued.TabStop = false;
            // 
            // rdDiscontinued
            // 
            this.rdDiscontinued.AutoSize = true;
            this.rdDiscontinued.Location = new System.Drawing.Point(191, 20);
            this.rdDiscontinued.Name = "rdDiscontinued";
            this.rdDiscontinued.Size = new System.Drawing.Size(141, 29);
            this.rdDiscontinued.TabIndex = 6;
            this.rdDiscontinued.TabStop = true;
            this.rdDiscontinued.Text = "Discontinued";
            this.rdDiscontinued.UseVisualStyleBackColor = true;
            // 
            // rdContinued
            // 
            this.rdContinued.AutoSize = true;
            this.rdContinued.Checked = true;
            this.rdContinued.Location = new System.Drawing.Point(17, 20);
            this.rdContinued.Name = "rdContinued";
            this.rdContinued.Size = new System.Drawing.Size(119, 29);
            this.rdContinued.TabIndex = 5;
            this.rdContinued.TabStop = true;
            this.rdContinued.Text = "Continued";
            this.rdContinued.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 567);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(370, 567);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 42);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtCreateDate
            // 
            this.dtCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreateDate.Location = new System.Drawing.Point(239, 232);
            this.dtCreateDate.Name = "dtCreateDate";
            this.dtCreateDate.Size = new System.Drawing.Size(192, 31);
            this.dtCreateDate.TabIndex = 4;
            this.dtCreateDate.Value = new System.DateTime(2022, 6, 8, 13, 13, 52, 0);
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 645);
            this.Controls.Add(this.dtCreateDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpContinued);
            this.Controls.Add(this.lbContinued);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.lbProductName);
            this.Name = "FrmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPT Ecommerce Product Application";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmAddProduct_KeyPress);
            this.grpContinued.ResumeLayout(false);
            this.grpContinued.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private Label lbContinued;
        private GroupBox grpContinued;
        private RadioButton rdDiscontinued;
        private RadioButton rdContinued;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtCreateDate;
    }
}