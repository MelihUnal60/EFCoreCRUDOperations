using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppUI.Data
{
    public class Category  //northwind için oluşturuyoruz, ihtiyacımız olmayan kolonları classta tutmayabiliriz
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }


    }
}
