namespace WinFormsAppUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grdCategories = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtCategoryName = new TextBox();
            btnCategory = new Button();
            cbbCatName = new ComboBox();
            txtProductName = new TextBox();
            label3 = new Label();
            btnAddProduct = new Button();
            grdProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdProducts).BeginInit();
            SuspendLayout();
            // 
            // grdCategories
            // 
            grdCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCategories.Location = new Point(46, 284);
            grdCategories.Name = "grdCategories";
            grdCategories.RowHeadersWidth = 51;
            grdCategories.RowTemplate.Height = 29;
            grdCategories.Size = new Size(568, 336);
            grdCategories.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(198, 192);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 132);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Kategori Adı";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(145, 168);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(179, 27);
            txtCategoryName.TabIndex = 2;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(145, 210);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(179, 29);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "Ekle";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // cbbCatName
            // 
            cbbCatName.FormattingEnabled = true;
            cbbCatName.Location = new Point(911, 187);
            cbbCatName.Name = "cbbCatName";
            cbbCatName.Size = new Size(254, 28);
            cbbCatName.TabIndex = 4;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(911, 154);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(253, 27);
            txtProductName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(996, 114);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 6;
            label3.Text = "Ürün Ekle";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(912, 230);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(253, 29);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "Ürün Ekle";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // grdProducts
            // 
            grdProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProducts.Location = new Point(890, 284);
            grdProducts.Name = "grdProducts";
            grdProducts.RowHeadersWidth = 51;
            grdProducts.RowTemplate.Height = 29;
            grdProducts.Size = new Size(300, 323);
            grdProducts.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 679);
            Controls.Add(grdProducts);
            Controls.Add(btnAddProduct);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(cbbCatName);
            Controls.Add(btnCategory);
            Controls.Add(txtCategoryName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grdCategories);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grdCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdCategories;
        private Label label1;
        private Label label2;
        private TextBox txtCategoryName;
        private Button btnCategory;
        private ComboBox cbbCatName;
        private TextBox txtProductName;
        private Label label3;
        private Button btnAddProduct;
        private DataGridView grdProducts;
    }
}