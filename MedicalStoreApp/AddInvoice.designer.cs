namespace MedicalStoreApp
{
    partial class AddInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInvoiceID = new System.Windows.Forms.TextBox();
            this.tbInvoiceProduct = new System.Windows.Forms.TextBox();
            this.tbInvoiceQtyBoxes = new System.Windows.Forms.TextBox();
            this.tbInvoiceClient = new System.Windows.Forms.TextBox();
            this.btnInvoiceAddProduct = new System.Windows.Forms.Button();
            this.btnInvoiceDeleteProduct = new System.Windows.Forms.Button();
            this.dataGridViewInvoiceProduct = new System.Windows.Forms.DataGridView();
            this.co_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_packing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_PriceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_NetTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelInvoice = new System.Windows.Forms.Button();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.tbInvoiceDiscount = new System.Windows.Forms.TextBox();
            this.btnChooseProduct = new System.Windows.Forms.Button();
            this.tbInvoiceQtyCarton = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qty (Boxes)";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Client";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discount";
            // 
            // tbInvoiceID
            // 
            this.tbInvoiceID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceID.Location = new System.Drawing.Point(133, 15);
            this.tbInvoiceID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbInvoiceID.Name = "tbInvoiceID";
            this.tbInvoiceID.ReadOnly = true;
            this.tbInvoiceID.Size = new System.Drawing.Size(229, 34);
            this.tbInvoiceID.TabIndex = 7;
            // 
            // tbInvoiceProduct
            // 
            this.tbInvoiceProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbInvoiceProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbInvoiceProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceProduct.Location = new System.Drawing.Point(133, 54);
            this.tbInvoiceProduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbInvoiceProduct.Name = "tbInvoiceProduct";
            this.tbInvoiceProduct.ReadOnly = true;
            this.tbInvoiceProduct.Size = new System.Drawing.Size(195, 34);
            this.tbInvoiceProduct.TabIndex = 8;
            this.tbInvoiceProduct.TextChanged += new System.EventHandler(this.tbInvoiceProduct_TextChanged);
            // 
            // tbInvoiceQtyBoxes
            // 
            this.tbInvoiceQtyBoxes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceQtyBoxes.Location = new System.Drawing.Point(133, 92);
            this.tbInvoiceQtyBoxes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbInvoiceQtyBoxes.Name = "tbInvoiceQtyBoxes";
            this.tbInvoiceQtyBoxes.Size = new System.Drawing.Size(229, 34);
            this.tbInvoiceQtyBoxes.TabIndex = 9;
            // 
            // tbInvoiceClient
            // 
            this.tbInvoiceClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbInvoiceClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbInvoiceClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceClient.Location = new System.Drawing.Point(609, 16);
            this.tbInvoiceClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbInvoiceClient.Name = "tbInvoiceClient";
            this.tbInvoiceClient.Size = new System.Drawing.Size(229, 34);
            this.tbInvoiceClient.TabIndex = 11;
            // 
            // btnInvoiceAddProduct
            // 
            this.btnInvoiceAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceAddProduct.Location = new System.Drawing.Point(609, 138);
            this.btnInvoiceAddProduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnInvoiceAddProduct.Name = "btnInvoiceAddProduct";
            this.btnInvoiceAddProduct.Size = new System.Drawing.Size(111, 42);
            this.btnInvoiceAddProduct.TabIndex = 14;
            this.btnInvoiceAddProduct.Text = "Add Product";
            this.btnInvoiceAddProduct.UseVisualStyleBackColor = true;
            this.btnInvoiceAddProduct.Click += new System.EventHandler(this.btnInvoiceAddProduct_Click);
            // 
            // btnInvoiceDeleteProduct
            // 
            this.btnInvoiceDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceDeleteProduct.Location = new System.Drawing.Point(723, 138);
            this.btnInvoiceDeleteProduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnInvoiceDeleteProduct.Name = "btnInvoiceDeleteProduct";
            this.btnInvoiceDeleteProduct.Size = new System.Drawing.Size(116, 42);
            this.btnInvoiceDeleteProduct.TabIndex = 15;
            this.btnInvoiceDeleteProduct.Text = "Delete Product";
            this.btnInvoiceDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInvoiceProduct
            // 
            this.dataGridViewInvoiceProduct.AllowUserToAddRows = false;
            this.dataGridViewInvoiceProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewInvoiceProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewInvoiceProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoiceProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewInvoiceProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInvoiceProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewInvoiceProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoiceProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.co_ProductId,
            this.co_ProductName,
            this.co_packing,
            this.co_Price,
            this.co_Quantity,
            this.co_PriceType,
            this.co_Discount,
            this.co_SubTotal,
            this.co_NetTotal});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(3, 4, 0, 4);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInvoiceProduct.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewInvoiceProduct.Location = new System.Drawing.Point(12, 192);
            this.dataGridViewInvoiceProduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridViewInvoiceProduct.Name = "dataGridViewInvoiceProduct";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(3, 4, 0, 4);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInvoiceProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewInvoiceProduct.RowHeadersVisible = false;
            this.dataGridViewInvoiceProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoiceProduct.Size = new System.Drawing.Size(827, 271);
            this.dataGridViewInvoiceProduct.TabIndex = 16;
            // 
            // co_ProductId
            // 
            this.co_ProductId.FillWeight = 40F;
            this.co_ProductId.HeaderText = "ID";
            this.co_ProductId.Name = "co_ProductId";
            // 
            // co_ProductName
            // 
            this.co_ProductName.HeaderText = "Product Name";
            this.co_ProductName.Name = "co_ProductName";
            // 
            // co_packing
            // 
            this.co_packing.HeaderText = "Packing";
            this.co_packing.Name = "co_packing";
            // 
            // co_Price
            // 
            this.co_Price.HeaderText = "Price";
            this.co_Price.Name = "co_Price";
            // 
            // co_Quantity
            // 
            this.co_Quantity.FillWeight = 80F;
            this.co_Quantity.HeaderText = "Quantity";
            this.co_Quantity.Name = "co_Quantity";
            // 
            // co_PriceType
            // 
            this.co_PriceType.FillWeight = 80F;
            this.co_PriceType.HeaderText = "Price Type";
            this.co_PriceType.Name = "co_PriceType";
            // 
            // co_Discount
            // 
            this.co_Discount.HeaderText = "Discount";
            this.co_Discount.Name = "co_Discount";
            // 
            // co_SubTotal
            // 
            this.co_SubTotal.HeaderText = "Sub Total";
            this.co_SubTotal.Name = "co_SubTotal";
            // 
            // co_NetTotal
            // 
            this.co_NetTotal.HeaderText = "Net Total";
            this.co_NetTotal.Name = "co_NetTotal";
            // 
            // btnCancelInvoice
            // 
            this.btnCancelInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelInvoice.Location = new System.Drawing.Point(609, 472);
            this.btnCancelInvoice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancelInvoice.Name = "btnCancelInvoice";
            this.btnCancelInvoice.Size = new System.Drawing.Size(103, 42);
            this.btnCancelInvoice.TabIndex = 17;
            this.btnCancelInvoice.Text = "Cancel";
            this.btnCancelInvoice.UseVisualStyleBackColor = true;
            this.btnCancelInvoice.Click += new System.EventHandler(this.btnCancelInvoice_Click);
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInvoice.Location = new System.Drawing.Point(715, 472);
            this.btnCreateInvoice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(123, 42);
            this.btnCreateInvoice.TabIndex = 18;
            this.btnCreateInvoice.Text = "Create Invoice";
            this.btnCreateInvoice.UseVisualStyleBackColor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // tbInvoiceDiscount
            // 
            this.tbInvoiceDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceDiscount.Location = new System.Drawing.Point(609, 92);
            this.tbInvoiceDiscount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbInvoiceDiscount.Name = "tbInvoiceDiscount";
            this.tbInvoiceDiscount.Size = new System.Drawing.Size(229, 34);
            this.tbInvoiceDiscount.TabIndex = 10;
            // 
            // btnChooseProduct
            // 
            this.btnChooseProduct.Location = new System.Drawing.Point(330, 53);
            this.btnChooseProduct.Name = "btnChooseProduct";
            this.btnChooseProduct.Size = new System.Drawing.Size(32, 35);
            this.btnChooseProduct.TabIndex = 19;
            this.btnChooseProduct.Text = "...";
            this.btnChooseProduct.UseVisualStyleBackColor = true;
            this.btnChooseProduct.Click += new System.EventHandler(this.btnChooseProduct_Click);
            // 
            // tbInvoiceQtyCarton
            // 
            this.tbInvoiceQtyCarton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceQtyCarton.Location = new System.Drawing.Point(609, 54);
            this.tbInvoiceQtyCarton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbInvoiceQtyCarton.Name = "tbInvoiceQtyCarton";
            this.tbInvoiceQtyCarton.Size = new System.Drawing.Size(229, 34);
            this.tbInvoiceQtyCarton.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 34);
            this.label5.TabIndex = 20;
            this.label5.Text = "Qty (Cartons)";
            // 
            // AddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(852, 528);
            this.Controls.Add(this.tbInvoiceQtyCarton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChooseProduct);
            this.Controls.Add(this.btnCreateInvoice);
            this.Controls.Add(this.btnCancelInvoice);
            this.Controls.Add(this.dataGridViewInvoiceProduct);
            this.Controls.Add(this.btnInvoiceDeleteProduct);
            this.Controls.Add(this.btnInvoiceAddProduct);
            this.Controls.Add(this.tbInvoiceClient);
            this.Controls.Add(this.tbInvoiceDiscount);
            this.Controls.Add(this.tbInvoiceQtyBoxes);
            this.Controls.Add(this.tbInvoiceProduct);
            this.Controls.Add(this.tbInvoiceID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbInvoiceID;
        private System.Windows.Forms.TextBox tbInvoiceProduct;
        private System.Windows.Forms.TextBox tbInvoiceQtyBoxes;
        private System.Windows.Forms.TextBox tbInvoiceClient;
        private System.Windows.Forms.Button btnInvoiceAddProduct;
        private System.Windows.Forms.Button btnInvoiceDeleteProduct;
        private System.Windows.Forms.DataGridView dataGridViewInvoiceProduct;
        private System.Windows.Forms.Button btnCancelInvoice;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_packing;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_PriceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_NetTotal;
        private System.Windows.Forms.TextBox tbInvoiceDiscount;
        private System.Windows.Forms.Button btnChooseProduct;
        private System.Windows.Forms.TextBox tbInvoiceQtyCarton;
        private System.Windows.Forms.Label label5;
    }
}