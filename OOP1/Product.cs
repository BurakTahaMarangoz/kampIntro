using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }   // ürün id si
        public int CategoryId { get; set; } // ürün kategori id si
        public string ProductName { get; set; } // ürün ismi
        public double UnitPrice { get; set; }  // birim fiyatı
        public int UnitsInStock { get; set; } // stok adedi

        // CRUD ne demek Araştır ? ? ?
    }
}
