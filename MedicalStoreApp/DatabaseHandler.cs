using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MedicalStoreApp.Model;
using System.Data;
using System.Windows.Forms;

namespace MedicalStoreApp
{
    public static class DatabaseHandler
    {
        private static string connectionString = @"Data source=" + DatabaseEnum.SERVER_NAME +
                ";Initial catalog=" + DatabaseEnum.DATABASE_NAME +
                ";Integrated Security=True";
        private static SqlConnection con = new SqlConnection(connectionString);
        private static SqlTransaction transaction;
        private static SqlCommand transCommand;

        public static DataTable GetClientTable()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + DatabaseEnum.TABLE_CLIENT, con);
            DataTable dt = new DataTable(DatabaseEnum.TABLE_CLIENT);

            sda.Fill(dt);
            return dt;
        }

        //public static DataTable GetClientTable()
        //{
        //    SqlDataAdapter sda = new SqlDataAdapter("SELECT l.LineId, p.ProductName, p.ProductType, " +
        //        "l.SubTotal FROM Line AS l INNER JOIN Product AS p ON l.ProductId = p.ProductId; ", con);
        //    DataTable dt = new DataTable(DatabaseEnum.TABLE_CLIENT);

        //    sda.Fill(dt);
        //    return dt;
        //}

        public static Boolean AddClient(Client c)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Client values('";
            cmd.CommandText += c.ClientName + "','";
            cmd.CommandText += c.ClientPhone + "')";
            cmd.Connection = con;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Database: Client Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public static Client GetClientById(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * " + " FROM " + DatabaseEnum.TABLE_CLIENT +
                " WHERE " + DatabaseEnum.COL_CLIENT_ID + " = " + id, con);

            Client c = new Client();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    c.ClientId = Convert.ToInt32(reader[DatabaseEnum.COL_CLIENT_ID]);
                    c.ClientName = reader[DatabaseEnum.COL_CLIENT_NAME].ToString();
                    c.ClientPhone = reader[DatabaseEnum.COL_CLIENT_PHONE].ToString();

                }
            }
            con.Close();
            return c;

        }
        public static Boolean UpdateClient(Client c)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE " + DatabaseEnum.TABLE_CLIENT + " SET " +
                DatabaseEnum.COL_CLIENT_NAME + " = '" + c.ClientName + "'," +
                DatabaseEnum.COL_CLIENT_PHONE + " = '" + c.ClientPhone + "' WHERE " +
                DatabaseEnum.COL_CLIENT_ID + " = " + c.ClientId,
                con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Database: Client Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }
        //How to call this function
        // GetFilteredClientTable(DatabaseEnum.COL_CLIENT_ID, id)
        // OR
        // GetFilteredClientTable(DatabaseEnum.COL_CLIENT_NAME, name)
        public static DataTable GetFilteredClientTable(string searchFor, string query)
        {
            string sql = "SELECT * FROM " + DatabaseEnum.TABLE_CLIENT +
                " WHERE " + searchFor + " LIKE '%" + query + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable(DatabaseEnum.TABLE_CLIENT);
            sda.Fill(dt);
            return dt;
        }

        public static Boolean DeleteClient(int id)
        {
            con.Open();
            // same as delete from Client where ClientId = 5;
            SqlCommand cmd = new SqlCommand("DELETE FROM " + DatabaseEnum.TABLE_CLIENT + " WHERE " + 
                DatabaseEnum.COL_CLIENT_ID + " = " + id, con);
            
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show( ex.Message, "Database: Client Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }finally
            {
                con.Close();
            }
            return true;
        }

        public static DataTable GetProductTable()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT " + 
                DatabaseEnum.COL_PRODUCT_ID + "," +
                DatabaseEnum.COL_PRODUCT_NAME + "," +
                DatabaseEnum.COL_PRODUCT_TYPE + " FROM " +
                DatabaseEnum.TABLE_PRODUCT , con);

            DataTable tableProduct = new DataTable(DatabaseEnum.TABLE_PRODUCT);
            da.Fill(tableProduct);

            return tableProduct;
        }

        public static DataTable GetProductDetails(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * " + " FROM " + DatabaseEnum.TABLE_PRODUCT +
                " WHERE " + DatabaseEnum.COL_PRODUCT_ID + " = " + id, con);

            DataTable tableProduct = new DataTable("ProductDetailsTable");
            tableProduct.Columns.Add("Property");
            tableProduct.Columns.Add("Value");

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    DateTime date;

                    tableProduct.Rows.Add("ID", reader[DatabaseEnum.COL_PRODUCT_ID]);
                    tableProduct.Rows.Add("Product Name", reader[DatabaseEnum.COL_PRODUCT_NAME]);
                    tableProduct.Rows.Add("Product Type", reader[DatabaseEnum.COL_PRODUCT_TYPE]);
                    tableProduct.Rows.Add("Composition", reader[DatabaseEnum.COL_PRODUCT_COMPOSITION]);
                    tableProduct.Rows.Add("Packaging", reader[DatabaseEnum.COL_PRODUCT_PACKING]);
                    tableProduct.Rows.Add("Company", reader[DatabaseEnum.COL_PRODUCT_COMPANY]);
                    tableProduct.Rows.Add("Supplier", reader[DatabaseEnum.COL_PRODUCT_SUPPLIER]);

                    date = (DateTime) reader[DatabaseEnum.COL_PRODUCT_EXPIRY];

                    tableProduct.Rows.Add("Expiry Date", date.ToString("dd-MM-yyyy"));

                    tableProduct.Rows.Add("Quantity of Cartons", reader[DatabaseEnum.COL_PRODUCT_QTY_CARTON]);
                    tableProduct.Rows.Add("Quantity of Boxes", reader[DatabaseEnum.COL_PRODUCT_QTY_BOX]);
                    // Include price of carton as well
                    tableProduct.Rows.Add("Price of Box", reader[DatabaseEnum.COL_PRODUCT_PRICE_BOX]);
                    tableProduct.Rows.Add("Box/Carton", reader[DatabaseEnum.COL_PRODUCT_BOX_PER_CARTON]);


                    date = (DateTime) reader[DatabaseEnum.COL_PRODUCT_ENTRY];

                    tableProduct.Rows.Add("Stock Added Date", date.ToString("dd-MM-yyyy"));
                }
            }
            con.Close();
            return tableProduct;
        }

        public static Boolean AddProduct(Product p)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO " + DatabaseEnum.TABLE_PRODUCT + " VALUES ('" + 
                p.Name + "','" + p.Composition + "','" + p.Expiry + "'," + " GetDate() " + ",'" + p.Type + "','" + p.Packing 
                + "','" + p.Supplier + "','" + p.Company + "'," + p.QtyCarton + "," + p.QtyBox + "," + p.PriceBox + "," + 
                p.BoxPerCarton + ");",
                con);
            
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Database: Product Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public static Boolean DeleteProduct(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM " + DatabaseEnum.TABLE_PRODUCT + " WHERE " +
                DatabaseEnum.COL_PRODUCT_ID + " = " + id, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Database: Product Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public static Product GetProductById(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * " + " FROM " + DatabaseEnum.TABLE_PRODUCT +
                " WHERE " + DatabaseEnum.COL_PRODUCT_ID + " = " + id, con);

            Product p = new Product();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    p.Id = Convert.ToInt32(reader[DatabaseEnum.COL_PRODUCT_ID]);
                    p.Name = reader[DatabaseEnum.COL_PRODUCT_NAME].ToString();
                    p.Type = reader[DatabaseEnum.COL_PRODUCT_TYPE].ToString();
                    p.Composition = reader[DatabaseEnum.COL_PRODUCT_COMPOSITION].ToString();
                    p.Packing = reader[DatabaseEnum.COL_PRODUCT_PACKING].ToString();
                    p.Company = reader[DatabaseEnum.COL_PRODUCT_COMPANY].ToString();
                    p.Supplier =  reader[DatabaseEnum.COL_PRODUCT_SUPPLIER].ToString();
                    
                    p.Expiry = ((DateTime)reader[DatabaseEnum.COL_PRODUCT_EXPIRY]).ToString("MM/dd/yyyy");

                    p.QtyCarton = Convert.ToInt32(reader[DatabaseEnum.COL_PRODUCT_QTY_CARTON]);
                    p.QtyBox = Convert.ToInt32(reader[DatabaseEnum.COL_PRODUCT_QTY_BOX]);
                    // Include price of carton as well
                    p.PriceBox = (float) Convert.ToDouble(reader[DatabaseEnum.COL_PRODUCT_PRICE_BOX]);
                    p.BoxPerCarton = Convert.ToInt32(reader[DatabaseEnum.COL_PRODUCT_BOX_PER_CARTON]);
                }
            }
            con.Close();
            return p;
        }

        public static Boolean UpdateProduct(Product p)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE " + DatabaseEnum.TABLE_PRODUCT + " SET " +
                DatabaseEnum.COL_PRODUCT_NAME + " = '" + p.Name + "', " +
                DatabaseEnum.COL_PRODUCT_COMPOSITION + " = '" + p.Composition + "', " +
                DatabaseEnum.COL_PRODUCT_EXPIRY + " = '" + p.Expiry + "', " +
                DatabaseEnum.COL_PRODUCT_ENTRY + " = " + " GetDate(), " +
                DatabaseEnum.COL_PRODUCT_TYPE + " = '" + p.Type + "', " +
                DatabaseEnum.COL_PRODUCT_PACKING + " = '" + p.Packing + "', " +
                DatabaseEnum.COL_PRODUCT_SUPPLIER + " = '" + p.Supplier + "', " +
                DatabaseEnum.COL_PRODUCT_COMPANY + " = '" + p.Company + "', " +
                DatabaseEnum.COL_PRODUCT_QTY_CARTON + " = " + p.QtyCarton + ", " +
                DatabaseEnum.COL_PRODUCT_QTY_BOX + " = " + p.QtyBox + ", " +
                DatabaseEnum.COL_PRODUCT_PRICE_BOX + " = " + p.PriceBox + ", " +
                DatabaseEnum.COL_PRODUCT_BOX_PER_CARTON + " = " + p.BoxPerCarton +
                " WHERE " + DatabaseEnum.COL_PRODUCT_ID + " = " + p.Id,
                con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Database: Product Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public static DataTable GetFilteredClient(string searchFor, string query)
        {
            string sql = "SELECT " + DatabaseEnum.COL_CLIENT_ID + "," +
                DatabaseEnum.COL_CLIENT_NAME + " FROM " + DatabaseEnum.TABLE_CLIENT +
                " WHERE " + searchFor + " LIKE '%" + query + "%'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable(DatabaseEnum.TABLE_CLIENT);
            sda.Fill(dt);
            return dt;
        }

        public static int InsertInvoice()
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction("Insertion");
            SqlCommand cmd = new SqlCommand("INSERT INTO INVOICE VALUES()");
            int id = -1;

            con.Close();
            return id;
        }

        public static int AddLine(int pid, string qtyCarton, string qtyBox)
        {
            int r = -1;
            if(con.State == ConnectionState.Closed)
            {
                BeginLineTrasaction();
                transCommand = new SqlCommand("STOCK_EVALUATION", con);
                transCommand.Transaction = transaction;
                transCommand.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                if(transCommand.Parameters.Count > 0)
                    transCommand.Parameters.Clear();
                transCommand.Parameters.Add(new SqlParameter("@PID", pid));
                transCommand.Parameters.Add(new SqlParameter("@QTY_CARTON", qtyCarton));
                transCommand.Parameters.Add(new SqlParameter("@QTY_BOX", qtyBox));

                r = Convert.ToInt32(transCommand.ExecuteScalar());
            }
            return r;
        }

        public static void BeginLineTrasaction()
        {
            con.Open();
            transaction = con.BeginTransaction("LineTransaction");
        }

        public static void EndLineTransaction(bool commit)
        {
            if (commit)
                transaction.Commit();
            else
                transaction.Rollback();
            con.Close();
        }

        public static DataTable SelectProductForInvoice(string s)
        {
            try
            {
                //string query = "Select *From" + DatabaseEnum.TABLE_PRODUCT + "Where" + DatabaseEnum.COL_PRODUCT_NAME + "Like '%" + s+"%'";
                string query = "SELECT " + DatabaseEnum.COL_PRODUCT_ID + "," +
                    DatabaseEnum.COL_PRODUCT_NAME + "," + DatabaseEnum.COL_PRODUCT_TYPE + " FROM " + DatabaseEnum.TABLE_PRODUCT +
                    " WHERE " + DatabaseEnum.COL_PRODUCT_NAME + " LIKE '%" + s + "%'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable(DatabaseEnum.TABLE_PRODUCT);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                DataTable dt = new DataTable(DatabaseEnum.TABLE_PRODUCT);
                return dt;

            }
        }
    }
}
