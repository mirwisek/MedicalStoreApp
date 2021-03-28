using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreApp
{
    public static class DatabaseEnum
    {
        public const string SERVER_NAME = "LAPTOP-1CQRCNGU";
        public const string DATABASE_NAME = "medical";

        public const string TABLE_CLIENT = "Client";
        public const string TABLE_PRODUCT = "Product";
        public const string TABLE_LINE = "Line";
        public const string TABLE_INVOICE = "Invoice";

        public const string COL_CLIENT_ID = "ClientId";
        public const string COL_CLIENT_NAME = "ClientName";
        public const string COL_CLIENT_PHONE = "ClientPhoneNumber"; 

        public const string COL_PRODUCT_ID = "ProductId";
        public const string COL_PRODUCT_NAME = "ProductName";
        public const string COL_PRODUCT_COMPOSITION = "Composition";
        public const string COL_PRODUCT_EXPIRY = "ExpiryDate";
        public const string COL_PRODUCT_ENTRY = "EntryDate";
        public const string COL_PRODUCT_TYPE = "ProductType";
        public const string COL_PRODUCT_PACKING = "Packing";
        public const string COL_PRODUCT_SUPPLIER = "Supplier";
        public const string COL_PRODUCT_COMPANY = "Company";
        public const string COL_PRODUCT_QTY_CARTON = "QtyCarton";
        public const string COL_PRODUCT_QTY_BOX = "QtyBox";
        public const string COL_PRODUCT_PRICE_BOX = "PriceBox";
        public const string COL_PRODUCT_BOX_PER_CARTON = "BoxPerCarton";

        public const string COL_LINE_ID = "LineId";
        // Skipped COL_LINE_PRODUCT_ID because it's same as COL_PRODUCT_ID
        public const string COL_LINE_QTY_CARTON = "QtyCarton";
        public const string COL_LINE_QTY_BOX = "QtyBox";
        public const string COL_LINE_PRICE_BOX = "PriceBox";
        public const string COL_LINE_SUB_TOTAL = "SubTotals";

        public const string COL_INVOICE_ID = "InvoiceId";
        public const string COL_INVOICE_DATE = "InvoiceDate";
    }
}
