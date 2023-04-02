using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static THA_W5_KEZIA_Y.Form1;

namespace THA_W5_KEZIA_Y
{
    public partial class Form1 : Form
    {
        public class Shop
        {
            public List<Product> allProducts = new List<Product>();
            public List<Product> getAllProducts() { return allProducts; }
            public void setAllProducts(List<Product> allProducts) { this.allProducts = allProducts; }
        }
        public class Category
        {
            public string categoryID { get; set; }
            public string categoryName { get; set; }

            public List<Product> products = new List<Product>();
            public List<Product> getProducts() { return products; }
            public void setProducts(List<Product> products) { this.products = products; }
            public Category()
            {

            }
            public Category(string categoryID, string categoryName)
            {
                this.categoryID = categoryID;
                this.categoryName = categoryName;
            }
            Shop shop = new Shop();
            public void addProduct(string productID, string productName, string productPrice, string productStock)
            {
                Product product = new Product(productID, productName, productPrice, productStock, categoryID, categoryName);
                products.Add(product);
            }
        }
        public class Product : Category
        {
            public string productID { get; set; }
            public string productName { get; set; }
            public string productPrice { get; set; }
            public string productStock { get; set; }
            public Product()
            {

            }
            public Product(string productID, string productName, string productPrice, string productStock, string categoryID, string categoryName)
            {
                this.productID = productID;
                this.productName = productName;
                this.productPrice = productPrice;
                this.productStock = productStock;
                this.categoryID = categoryID;
                this.categoryName = categoryName;
            }
        }
        public void addNewProduct()
        {
            foreach (Category category in categories)
            {
                foreach (Product product in category.products)
                {
                    if (shop.allProducts.Contains(product) == false)
                    {
                        shop.allProducts.Add(product);
                    }
                }
            }
        }
        public void showAllProducts()
        {
            dtProdukSimpan.Rows.Clear();
            foreach (Product product in shop.allProducts)
            {
                dtProdukSimpan.Rows.Add($"{product.productID}", $"{product.productName}", $"{product.productPrice}", $"{product.productStock}", $"{product.categoryID}");
            }
            dataGridView_Product.DataSource = dtProdukSimpan;
            dataGridView_Product.ClearSelection();
        }
        public void updateCategories()
        {
            dtCategory.Rows.Clear();
            comboBox_Filter.Items.Clear();
            comboBox_CategoryDetails.Items.Clear();
            foreach (Category category in categories)
            {
                dtCategory.Rows.Add($"{category.categoryID}", $"{ category.categoryName}");
                comboBox_Filter.Items.Add(category.categoryName);
                comboBox_CategoryDetails.Items.Add(category.categoryName);
            }
            dataGridView_Category.DataSource = dtCategory;
            dataGridView_Category.ClearSelection();
        }
        public Form1()
        {
            InitializeComponent();
        }

        List<Category> categories = new List<Category>();
        Shop shop = new Shop();

        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        List<string> columnListProduct = new List<string>() {"ID Product", "Nama Product", "Harga", "Stock", "ID Category"};

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string column in columnListProduct)
            {
                dtProdukSimpan.Columns.Add(column);
                dtProdukTampil.Columns.Add(column);
            }
            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");

            Category category1 = new Category("C1", "Jas");
            categories.Add(category1);
            category1.addProduct("J001", "Jas Hitam", "100000", "10");
            addNewProduct();
            Category category2 = new Category("C2", "T-Shirt");
            categories.Add(category2);
            category2.addProduct("T001", "T-Shirt Black Pink", "70000", "20");
            category2.addProduct("T002", "T-Shirt Obsessive", "75000", "16");
            addNewProduct();
            Category category3 = new Category("C3", "Rok");
            categories.Add(category3);
            category3.addProduct("R001", "Rok mini", "82000", "26");
            addNewProduct();
            Category category4 = new Category("C4", "Celana");
            categories.Add(category4);
            category4.addProduct("J002", "Jeans Biru", "90000", "5");
            category4.addProduct("C001", "Celana Pendek Coklat", "60000", "11");
            addNewProduct();
            Category category5 = new Category("C5", "Cawat");
            categories.Add(category5);
            category5.addProduct("C002", "Cawat Blink-blink", "1000000", "1");
            addNewProduct();
            category2.addProduct("R002", "Rocca Shirt", "50000", "8");
            addNewProduct();
            showAllProducts();
            updateCategories();

            DataGridViewColumn column0 = dataGridView_Product.Columns[0];
            column0.Width = 55;
            DataGridViewColumn column1 = dataGridView_Product.Columns[1];
            column1.Width = 100;
            DataGridViewColumn column2 = dataGridView_Product.Columns[2];
            column2.Width = 60;
            DataGridViewColumn column3 = dataGridView_Product.Columns[3];
            column3.Width = 45;
        }

        private void button_All_Click(object sender, EventArgs e)
        {
            showAllProducts();
            comboBox_Filter.SelectedItem = null;
            comboBox_Filter.Enabled = false;
        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            comboBox_Filter.Enabled = true;
        }

        private void comboBox_Filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox_NamaDetails.Clear();
            comboBox_CategoryDetails.SelectedItem = null;
            textBox_HargaDetails.Clear();
            textBox_StockDetails.Clear();
            dtProdukTampil.Rows.Clear();
            foreach (Product product in shop.allProducts)
            {
                if (product.categoryName == comboBox_Filter.Text)
                {
                    dtProdukTampil.Rows.Add($"{product.productID}", $"{product.productName}", $"{product.productPrice}", $"{product.productStock}", $"{product.categoryID}");
                }
            }
            dataGridView_Product.DataSource = dtProdukTampil;
            dataGridView_Product.ClearSelection();
        }

        private void textBox_HargaDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_StockDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView_Product_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_Product.Rows.Count > 0)
            {
                int categoryIndex = -1;
                foreach (Product product in shop.allProducts)
                {
                    if (dataGridView_Product.CurrentRow.Cells[0].Value.ToString() == product.productID)
                    {
                        textBox_NamaDetails.Text = product.productName;
                        foreach (Category category in categories)
                        {
                            categoryIndex++;
                            if (category.categoryID == product.categoryID)
                            {
                                comboBox_CategoryDetails.SelectedIndex = categoryIndex;
                                break;
                            }
                        }
                        textBox_HargaDetails.Text = product.productPrice;
                        textBox_StockDetails.Text = product.productStock;
                        break;
                    }
                } 
            }
        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            if (textBox_NamaDetails.Text != "" && comboBox_CategoryDetails.Text != "" && textBox_HargaDetails.Text != "" && textBox_StockDetails.Text != "")
            {
                int max = 0;
                foreach (Product product in shop.allProducts)
                {
                    if (product.productID.Substring(0, 1) == textBox_NamaDetails.Text.Substring(0, 1).ToUpper())
                    {
                        int prodIDLength = product.productID.Length;
                        if (Convert.ToInt32((product.productID).Substring(1, prodIDLength - 1)) > max)
                        {
                            max = Convert.ToInt32((product.productID).Substring(1, prodIDLength - 1));
                        } 
                    }
                }
                string newProdID = textBox_NamaDetails.Text.Substring(0, 1).ToUpper() + (max + 1).ToString("D3");
                foreach (Category category in categories)
                {
                    if (category.categoryName == comboBox_CategoryDetails.Text)
                    {

                        category.addProduct(newProdID, textBox_NamaDetails.Text, textBox_HargaDetails.Text, textBox_StockDetails.Text);
                        addNewProduct();
                        showAllProducts();
                        textBox_NamaDetails.Clear();
                        comboBox_CategoryDetails.SelectedItem = null;
                        textBox_HargaDetails.Clear();
                        textBox_StockDetails.Clear();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan masukkan detail produk dengan lengkap. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_EditProduct_Click(object sender, EventArgs e)
        {
            string prodID = dataGridView_Product.CurrentRow.Cells[0].Value.ToString();
            string catID = dataGridView_Product.CurrentRow.Cells[4].Value.ToString();
            if (dataGridView_Product.SelectedRows.Count > 0)
            {
                for (int i = 0; i < shop.allProducts.Count; i++)
                {
                    Product product = shop.allProducts[i];
                    foreach (Category category in categories)
                    {
                        if (product.productID == prodID && category.categoryID == catID)
                        {
                            foreach (Product product2 in category.products)
                            {
                                if (product2.productID == prodID)
                                {
                                    product.productName = textBox_NamaDetails.Text;
                                    product2.productName = textBox_NamaDetails.Text;
                                    product.productPrice = textBox_HargaDetails.Text;
                                    product2.productPrice = textBox_HargaDetails.Text;
                                    product.productStock = textBox_StockDetails.Text;
                                    product2.productStock = textBox_StockDetails.Text;
                                    if (category.categoryName != comboBox_CategoryDetails.Text)
                                    {
                                        foreach (Category newCategory in categories)
                                        {
                                            if (newCategory.categoryName == comboBox_CategoryDetails.Text)
                                            {
                                                newCategory.products.Add(product2);
                                                product.categoryID = newCategory.categoryID;
                                                product.categoryName = newCategory.categoryName;
                                            }
                                        }
                                        category.products.Remove(product2);
                                    }
                                    if (product.productStock == "0")
                                    {
                                        shop.allProducts.Remove(product);
                                        category.products.Remove(product2);
                                    }
                                    textBox_NamaDetails.Clear();
                                    comboBox_CategoryDetails.SelectedItem = null;
                                    textBox_HargaDetails.Clear();
                                    textBox_StockDetails.Clear();
                                    showAllProducts();
                                    comboBox_Filter.SelectedItem = null;
                                    comboBox_Filter.Enabled = false;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih produk yang ingin diedit terlebih dahulu. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_RemoveProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView_Product.SelectedRows.Count > 0)
            {
                foreach (Category category in categories)
                {
                    if (category.categoryID == dataGridView_Product.CurrentRow.Cells[4].Value.ToString())
                    {
                        foreach (Product product in category.products)
                        {
                            if (product.productID == dataGridView_Product.CurrentRow.Cells[0].Value.ToString())
                            {
                                category.products.Remove(product);
                                shop.allProducts.Remove(product);
                                break;
                            }
                        }
                    }
                }
                textBox_NamaDetails.Clear();
                comboBox_CategoryDetails.SelectedItem = null;
                textBox_HargaDetails.Clear();
                textBox_StockDetails.Clear();
                showAllProducts();
                comboBox_Filter.SelectedItem = null;
                comboBox_Filter.Enabled = false; 
            }
        }

        private void dataGridView_Category_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_Category.Rows.Count > 0)
            {
                foreach (Category category in categories)
                {
                    if (dataGridView_Category.CurrentRow.Cells[0].Value.ToString() == category.categoryID)
                    {
                        textBox_NamaCategory.Text = category.categoryName;
                    }
                } 
            }
        }

        private void button_AddCategory_Click(object sender, EventArgs e)
        {
            bool categoryFound = false;
            if (textBox_NamaCategory.Text != "")
            {
                foreach (Category category in categories)
                {
                    if (category.categoryName == textBox_NamaCategory.Text)
                    {
                        categoryFound = true;
                        MessageBox.Show("Category sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_NamaCategory.Focus();
                        break;
                    }
                }
                if (categoryFound == false)
                {
                    int max = 0;
                    foreach (Category category in categories)
                    {
                        int catIDLength = category.categoryID.Length;
                        if (Convert.ToInt32((category.categoryID).Substring(1, catIDLength - 1)) > max)
                        {
                            max = Convert.ToInt32((category.categoryID).Substring(1, catIDLength - 1));
                        }
                    }
                    string newCatID = "C" + (max+1).ToString();
                    Category newCategory = new Category(newCatID, textBox_NamaCategory.Text);
                    categories.Add(newCategory);
                    updateCategories();
                    textBox_NamaCategory.Clear();
                }
            }
            else
            {
                MessageBox.Show("Silakan masukkan nama kategori terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_NamaCategory.Focus();
            }
            textBox_NamaDetails.Clear();
            comboBox_CategoryDetails.SelectedItem = null;
            textBox_HargaDetails.Clear();
            textBox_StockDetails.Clear();
        }

        private void button_RemoveCategory_Click(object sender, EventArgs e)
        {
            if (dataGridView_Category.SelectedRows.Count > 0)
            {
                foreach (Category category in categories)
                {
                    if (dataGridView_Category.CurrentRow.Cells[0].Value.ToString() == category.categoryID)
                    {
                        foreach (Product product in category.products)
                        {
                            shop.allProducts.Remove(product);
                        }
                        categories.Remove(category);
                        break;
                    }
                }
                textBox_NamaCategory.Clear();
                showAllProducts();
                updateCategories();
                textBox_NamaDetails.Clear();
                comboBox_CategoryDetails.SelectedItem = null;
                textBox_HargaDetails.Clear();
                textBox_StockDetails.Clear();
            }
        }
    }
}
