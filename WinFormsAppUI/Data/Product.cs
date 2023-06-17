using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppUI.Data
{
    public class Product
    {
        public int ProductID { get; set; }

        //[MaxLength(40)] //bu sadece veri tabanı oluşurken işe yarar

        public string ProductName { get; set; }

        public string? QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public int? CategoryID { get; set; }

        public Category Category { get; set; } //navigation property
    }
}
