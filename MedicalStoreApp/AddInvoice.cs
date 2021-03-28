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
    public partial class AddInvoice : Form
    {
        public int tempProductId = -1;
        public string tempProductName = "";
        public AddInvoice()
        {
            InitializeComponent();

            RefreshClientAutoCompleteSource();
        }

        public void RefreshClientAutoCompleteSource()
        {
            // Table with clientID, ClientName only
            DataTable table = DatabaseHandler.GetFilteredClient(DatabaseEnum.COL_CLIENT_NAME, tbInvoiceClient.Text);

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            
            foreach (DataRow row in table.Rows)
            {
                collection.Add(row[DatabaseEnum.COL_CLIENT_NAME].ToString() + " (" +
                    row[DatabaseEnum.COL_CLIENT_ID].ToString() + ")");
            }

            tbInvoiceClient.AutoCompleteCustomSource = collection;
        }

        private void tbInvoiceProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInvoiceAddProduct_Click(object sender, EventArgs e)
        {
            int res = DatabaseHandler.AddLine(tempProductId, tbInvoiceQtyCarton.Text, tbInvoiceQtyBoxes.Text);
            
        }

        private void btnCancelInvoice_Click(object sender, EventArgs e)
        {
            DatabaseHandler.EndLineTransaction(false);
            this.Dispose();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            DatabaseHandler.EndLineTransaction(true);
            this.Dispose();
        }

        private void btnChooseProduct_Click(object sender, EventArgs e)
        {
            SelectProductForm obj = new SelectProductForm(this);
            obj.ShowDialog();
        }
        public void UpdateValues()
        {
            tbInvoiceProduct.Text = tempProductName;
        }
    }
}
