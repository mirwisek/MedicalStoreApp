using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MedicalStoreApp.Model;


namespace MedicalStoreApp
{
    public partial class MainPanel : Form
    {
        // to save selected row index
        private int currentRowIndex = -1;
        public MainPanel()
        {
            InitializeComponent();

            initGridViews();

        }
        public void UpdateClientTable()
        {
            DataTable tableClient = DatabaseHandler.GetClientTable();
            clientGridView.DataSource = tableClient;
        }

        public void UpdateProductTable()
        {
            DataTable tableProduct = DatabaseHandler.GetProductTable();
            productIndexGridView.DataSource = tableProduct;
        }

        public void initGridViews()
        {
            clientGridView.RowHeadersVisible = false;
            clientGridView.Columns[0].DataPropertyName = DatabaseEnum.COL_CLIENT_ID;
            clientGridView.Columns[1].DataPropertyName = DatabaseEnum.COL_CLIENT_NAME;
            clientGridView.Columns[2].DataPropertyName = DatabaseEnum.COL_CLIENT_PHONE;

            productIndexGridView.RowHeadersVisible = false;
            productIndexGridView.Columns[0].DataPropertyName = DatabaseEnum.COL_PRODUCT_ID;
            productIndexGridView.Columns[1].DataPropertyName = DatabaseEnum.COL_PRODUCT_NAME;
            productIndexGridView.Columns[2].DataPropertyName = DatabaseEnum.COL_PRODUCT_TYPE;
                        
        }

        private void CNew_botton_Click(object sender, EventArgs e)
        {
            AddClient obj = new AddClient(this);
            obj.ShowDialog();

        }

        private void textbox_searchClient_Enter(object sender, EventArgs e)
        {
            if (tbSearchClient.Text == "Search....")
            {
                tbSearchClient.Text = "";
                tbSearchClient.ForeColor = Color.Black;
            }

        }

        private void textbox_searchClient_Leave(object sender, EventArgs e)
        {
            if (tbSearchClient.Text == "")
            {
                tbSearchClient.Text = "Search....";
                tbSearchClient.ForeColor = Color.Gray;
            }

        }

        private void textbox_ProductSearch_Enter(object sender, EventArgs e)
        {
            if (tbProductSearch.Text == "Search....")
            {
                tbProductSearch.Text = "";
                tbProductSearch.ForeColor = Color.Black;
            }
        }

        private void textbox_ProductSearch_Leave(object sender, EventArgs e)
        {
            if (tbProductSearch.Text == "")
            {
                tbProductSearch.Text = "Search....";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddInvoice addInvoicesobj = new AddInvoice();
            addInvoicesobj.ShowDialog();
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            UpdateClientTable();
            UpdateProductTable();
        }

        private void ClientGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    clientGridView.Rows[e.RowIndex].Selected = true;
                    currentRowIndex = e.RowIndex;
                    cmsClient.Show(clientGridView, e.Location);
                    cmsClient.Show(Cursor.Position);
                }
                catch (ArgumentOutOfRangeException)
                {
                    // do nothing
                }
            }
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            string clientId = clientGridView.Rows[currentRowIndex].Cells[0].Value.ToString();
            int cid = Convert.ToInt32(clientId);

            AddClient addClient = new AddClient(this, DatabaseHandler.GetClientById(cid));
            addClient.Show();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            string clientId = clientGridView.Rows[currentRowIndex].Cells[0].Value.ToString();

            if (DatabaseHandler.DeleteClient(Convert.ToInt32(clientId)))
            {
                UpdateClientTable();
            }
        }

        private void productIndexGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                try
                {
                    string val = productIndexGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int id = Convert.ToInt32(val);
                    productDetailGridView.Columns.Clear();
                    productDetailGridView.DataSource = DatabaseHandler.GetProductDetails(id);
                }
                catch (Exception)
                {
                    // do noting
                }
            } else if(e.Button == MouseButtons.Right)
            {
                try
                {
                    // Left click code + Right Click code
                    string val = productIndexGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int id = Convert.ToInt32(val);
                    productDetailGridView.Columns.Clear();
                    productDetailGridView.DataSource = DatabaseHandler.GetProductDetails(id);
                    // Right click starts here
                    productIndexGridView.Rows[e.RowIndex].Selected = true;
                    currentRowIndex = e.RowIndex;
                    cmsProduct.Show(productIndexGridView, e.Location);
                    cmsProduct.Show(Cursor.Position);
                }
                catch (ArgumentOutOfRangeException)
                {
                    // do nothing
                }
            }
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            new AddProduct(this).ShowDialog();
        }

        public void selectProductIndexLastRow()
        {
            DataGridViewRow row = productIndexGridView.Rows[productIndexGridView.Rows.Count - 1];
            row.Selected = true;
            try
            {
                string val = row.Cells[0].Value.ToString();
                int id = Convert.ToInt32(val);
                productDetailGridView.Columns.Clear();
                productDetailGridView.DataSource = DatabaseHandler.GetProductDetails(id);
            }
            catch (Exception)
            {
                // do noting
            }
        }

        private void toolStripMenuItemDeleteProduct_Click(object sender, EventArgs e)
        {
            string productId = productIndexGridView.Rows[currentRowIndex].Cells[0].Value.ToString();

            if (DatabaseHandler.DeleteProduct(Convert.ToInt32(productId)))
            {
                UpdateProductTable();
                selectProductIndexLastRow();
            }
        }

        private void toolStripMenuItemEditProduct_Click(object sender, EventArgs e)
        {
            string id = productIndexGridView.Rows[currentRowIndex].Cells[0].Value.ToString();
            int productId = Convert.ToInt32(id);

            AddProduct addProduct = new AddProduct(this, DatabaseHandler.GetProductById(productId));
            addProduct.Show();
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            AddInvoice addInvoice = new AddInvoice();
            addInvoice.Show();
        }

        public void selectCurrentClientRow()
        {
            clientGridView.Rows[currentRowIndex].Selected = true;
        }

        private void tbSearchClient_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = DatabaseHandler.GetFilteredClientTable(DatabaseEnum.COL_CLIENT_NAME, tbSearchClient.Text);
            clientGridView.Columns.Clear();
            clientGridView.DataSource = dt;
        }

        private void tbSearchClient_Enter(object sender, EventArgs e)
        {
            tbSearchClient.Text = "";
        }
    }
}
