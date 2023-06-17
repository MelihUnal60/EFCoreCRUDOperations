using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppUI.Data;
using WinFormsAppUI.DataViewModels;

namespace WinFormsAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwndDbContext context = new NorthwndDbContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            GetCategoryData();
        }

        #region Helpers
        private void GetCategoryData()
        {
            //var categories = context.Categories.Include(c => c.Products).ToList();
            //var kategoriler = context.Categories.Include(nameof(Category.Products)).ToList();
            var categories = (from c in context.Categories.Include(c=> c.Products)
                             select new CategoryProductCountGridVM
                             {
                                 Id = c.CategoryID,  //kategori id , kategori adı ve kategorideki ürün sayısını geetirdik.
                                 Isim  = c.CategoryName, //anonim tip oluşturduk, tek kullanımlık sorguya özel yazdık.
                                 UrunSayisi = c.Products.Count,
                             }).ToList();
            grdCategories.DataSource = categories;
        }

        #endregion
    }
}
