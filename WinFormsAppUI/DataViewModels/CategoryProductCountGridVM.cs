using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppUI.DataViewModels
{
    public class CategoryProductCountGridVM
    {
        public string Isim { get; set; }

        public int Id { get; set; }     //anonim class oluşturduk, isimlendirme istediğimiz şekilde olur

        public int UrunSayisi { get; set; }  // bu değişkenlere sorgudan gelen kolonlardaki değerleri atayacağız.
    }
}
