using MedicalStoreApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreApp
{
    public partial class AddProduct : Form
    {
        MainPanel parent;
        Product selectedProduct;

        public AddProduct(MainPanel parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public AddProduct(MainPanel parent, Product p)
        {
            InitializeComponent();
            this.parent = parent;
            selectedProduct = p;

            try
            {
                tbProductID.Text = p.Id.ToString();
                tbProductName.Text = p.Name;
                tbProductComposition.Text = p.Composition;
                tbProductCompany.Text = p.Company;
                tbProductPacking.Text = p.Packing;
                tbProductSupplier.Text = p.Supplier.ToString();
                tbProductQtyBox.Text = p.QtyBox.ToString();
                tbProductQtyCarton.Text = p.QtyCarton.ToString();
                tbProductPriceBox.Text = ""  + p.PriceBox;
                tbProductBoxPerCarton.Text = p.BoxPerCarton.ToString();
                dateTimeProductExpiry.Value = DateTime.Parse(p.Expiry);
                cbProductType.SelectedItem = p.Type;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Product Fetch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            Product p = fetchValues();

            // means product has to be added
            if (selectedProduct == null)
            {
                if (p != null && DatabaseHandler.AddProduct(p))
                {
                    parent.UpdateProductTable();
                    // Change selection to the newly added row
                    parent.selectProductIndexLastRow();
                    Dispose();
                }
            }
            // edit the product
            else {
                if (p != null && DatabaseHandler.UpdateProduct(p))
                {
                    parent.UpdateProductTable();
                    // Change selection to the newly added row
                    parent.selectProductIndexLastRow();
                    Dispose();
                }
            }
        }

        private Product fetchValues()
        {
            Product p = new Product();

            try
            {
                if(selectedProduct != null)
                {
                    p.Id = Convert.ToInt32(tbProductID.Text);
                }
                p.Name = tbProductName.Text;
                p.Composition = tbProductComposition.Text;
                p.Type = cbProductType.Text;
                p.Packing = tbProductPacking.Text;
                p.Company = tbProductCompany.Text;
                p.Supplier = tbProductSupplier.Text;
                p.QtyCarton = Convert.ToInt32(tbProductQtyCarton.Text);
                p.QtyBox = Convert.ToInt32(tbProductQtyBox.Text);
                p.PriceBox = (float)Convert.ToDouble(tbProductPriceBox.Text);
                p.BoxPerCarton = Convert.ToInt32(tbProductBoxPerCarton.Text);
                p.Expiry = dateTimeProductExpiry.Value.ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Product Add/Edit error!" + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return p;
        }

        private void btnCancelAddProduct_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
