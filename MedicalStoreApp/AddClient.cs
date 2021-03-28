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
    public partial class AddClient : Form
    {
        MainPanel parentPanel;
        Client selectedclient;

        public AddClient(MainPanel parentPanel)
        {
            InitializeComponent();
            this.parentPanel = parentPanel;
        }
        public AddClient(MainPanel parentPanel, Client c)
        {
            InitializeComponent();
            this.parentPanel = parentPanel;
            selectedclient = c;
            try
            {
                tbClientName.Text = c.ClientName;
                tbClientPhone.Text = c.ClientPhone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Client Fetch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Client fetchvalues()
        {
            Client c = new Client();

            try
            {
                if (selectedclient != null)
                {
                    c.ClientId = selectedclient.ClientId;
                }
                c.ClientName = tbClientName.Text;
                c.ClientPhone = tbClientPhone.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Client Add/Edit error!" + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client c = fetchvalues();

            if (selectedclient == null)
            {
                if (c != null && DatabaseHandler.AddClient(c))
                {
                    parentPanel.UpdateClientTable();
                    Dispose();
                }
            }
            else
            {
                if (c != null && DatabaseHandler.UpdateClient(c))
                {
                    parentPanel.UpdateClientTable();
                    // Change selection to the updated row
                    parentPanel.selectCurrentClientRow();
                    Dispose();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
