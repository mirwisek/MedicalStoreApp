using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreApp.Model
{
    public class Product
    {
        public Product() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Composition { get; set; }
        public string Expiry { get; set; }
        public string Entry { get; set; }
        public string Type { get; set; }
        public string Packing { get; set; }
        public string Supplier { get; set; }
        public string Company { get; set; }
        public int QtyCarton { get; set; }
        public int QtyBox { get; set; }
        public float PriceBox { get; set; }
        public int BoxPerCarton { get; set; }
    }
}
