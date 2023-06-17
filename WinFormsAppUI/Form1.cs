using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

            FillCategoryGrid();
            FillProductGrid();
            FillCategoryCbb();
            //AsNoTrackingCalculation();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category addedCategory = new Category();
            addedCategory.CategoryName = txtCategoryName.Text;
            if (string.IsNullOrEmpty(txtCategoryName.Text))
                throw new Exception("Kategori adı boş olamaz");

            context.Categories.Add(addedCategory);// gride adı girip ekle butonu ile yeni kategori ekledik
            context.SaveChanges(); // bu fonksiyonu çağırmazsak db tarafında güncelleme olmaz.

            #region AddRange ile toplu ekleme
            List<Category> categories = new List<Category>
                {
                    new Category {CategoryName = "TEST2"},
                    new Category {CategoryName = "TEST2"},  //KATEGORİ LİSTESİ OLUŞTURDUK
                    new Category {CategoryName = "TEST2"}
                };



            context.Categories.AddRange(categories); //bulk insert ile listeyi categories tablosuna ekledik.
            #endregion

            FillCategoryGrid(); //güncel tabloyu görmek için ekle butonu içinde gridi doldurdan fonksiyonu çağırdık.

        }
        #region Helpers
        private void FillCategoryGrid()
        {
            //var categories = context.Categories.Include(c => c.Products).ToList();
            //var kategoriler = context.Categories.Include(nameof(Category.Products)).ToList();
            var categories = (from c in context.Categories.AsNoTracking().AsSplitQuery().Include(c => c.Products)
                              select new CategoryProductCountGridVM
                              {
                                  Id = c.CategoryID,  //kategori id , kategori adı ve kategorideki ürün sayısını geetirdik.
                                  Isim = c.CategoryName, //anonim tip oluşturduk, tek kullanımlık sorguya özel yazdık.
                                  UrunSayisi = c.Products.Count,  //assplitquery ayrı ayrı sorgular gönderir performans için.
                              }).ToList();
            grdCategories.DataSource = categories;
        }

        private void AsNoTrackingCalculation()
        {
            Stopwatch timeCalculator = new Stopwatch();
            timeCalculator.Start(); // dönen sonucun süresini hesaplamak için kronometre ekledik.

            context.Products.ToList();

            timeCalculator.Stop();

            TimeSpan timeSpan = timeCalculator.Elapsed;

            string gecenZaman = timeSpan.TotalMicroseconds.ToString();

            timeCalculator = new Stopwatch();
            timeCalculator.Start();

            context.Products.AsNoTracking().ToList();

            timeCalculator.Stop();

            TimeSpan timeSpan1 = timeCalculator.Elapsed;

            string gecenZaman2 = timeSpan1.TotalMicroseconds.ToString();

            MessageBox.Show("Without AsNoTracking : " + gecenZaman + "  " + "With AsNoTracking : " + gecenZaman2);

        }

        private void FillCategoryCbb()
        {
            var categories = context.Categories.AsNoTracking().ToList();
            cbbCatName.DataSource = categories;
            cbbCatName.DisplayMember = nameof(Category.CategoryName);
            cbbCatName.ValueMember = nameof(Category.CategoryID);
        }

        #endregion

        private void FillProductGrid()
        {
            var products = (from p in context.Products.AsNoTracking().Include(p => p.Category)
                            select new
                            {
                                UrunAdi = p.ProductName,
                                UrunId = p.ProductID,
                                UrunKategori = p.Category.CategoryName
                            });
            grdProducts.DataSource = products.ToList();


        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var categoryId = Convert.ToInt32(cbbCatName.SelectedValue);

            Product addedProduct = new Product()
            {
                ProductName = txtProductName.Text,
                CategoryID = categoryId,
            };

            context.Products.Add(addedProduct);
            context.SaveChanges();
            FillProductGrid();
        }
    }
}
