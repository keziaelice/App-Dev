namespace THA_W5_KEZIA_Y
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
            this.label_Product = new System.Windows.Forms.Label();
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.button_All = new System.Windows.Forms.Button();
            this.button_Filter = new System.Windows.Forms.Button();
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.dataGridView_Category = new System.Windows.Forms.DataGridView();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_NamaCategory = new System.Windows.Forms.Label();
            this.textBox_NamaCategory = new System.Windows.Forms.TextBox();
            this.button_RemoveCategory = new System.Windows.Forms.Button();
            this.button_AddCategory = new System.Windows.Forms.Button();
            this.label_Details = new System.Windows.Forms.Label();
            this.textBox_NamaDetails = new System.Windows.Forms.TextBox();
            this.label_NamaDetails = new System.Windows.Forms.Label();
            this.label_CategoryDetails = new System.Windows.Forms.Label();
            this.label_HargaDetails = new System.Windows.Forms.Label();
            this.label_StockDetails = new System.Windows.Forms.Label();
            this.textBox_HargaDetails = new System.Windows.Forms.TextBox();
            this.textBox_StockDetails = new System.Windows.Forms.TextBox();
            this.comboBox_CategoryDetails = new System.Windows.Forms.ComboBox();
            this.button_AddProduct = new System.Windows.Forms.Button();
            this.button_EditProduct = new System.Windows.Forms.Button();
            this.button_RemoveProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Product.Location = new System.Drawing.Point(35, 34);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(105, 32);
            this.label_Product.TabIndex = 0;
            this.label_Product.Text = "Product";
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.AllowUserToAddRows = false;
            this.dataGridView_Product.AllowUserToDeleteRows = false;
            this.dataGridView_Product.AllowUserToResizeColumns = false;
            this.dataGridView_Product.AllowUserToResizeRows = false;
            this.dataGridView_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Product.Location = new System.Drawing.Point(40, 76);
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.RowHeadersVisible = false;
            this.dataGridView_Product.RowHeadersWidth = 62;
            this.dataGridView_Product.RowTemplate.Height = 28;
            this.dataGridView_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Product.Size = new System.Drawing.Size(509, 300);
            this.dataGridView_Product.TabIndex = 1;
            this.dataGridView_Product.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Product_CellMouseClick);
            // 
            // button_All
            // 
            this.button_All.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_All.Location = new System.Drawing.Point(288, 36);
            this.button_All.Name = "button_All";
            this.button_All.Size = new System.Drawing.Size(50, 32);
            this.button_All.TabIndex = 2;
            this.button_All.Text = "All";
            this.button_All.UseVisualStyleBackColor = true;
            this.button_All.Click += new System.EventHandler(this.button_All_Click);
            // 
            // button_Filter
            // 
            this.button_Filter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Filter.Location = new System.Drawing.Point(344, 36);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(75, 32);
            this.button_Filter.TabIndex = 3;
            this.button_Filter.Text = "Filter:";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Filter.Enabled = false;
            this.comboBox_Filter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Location = new System.Drawing.Point(428, 38);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(121, 29);
            this.comboBox_Filter.TabIndex = 4;
            this.comboBox_Filter.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Filter_SelectionChangeCommitted);
            // 
            // dataGridView_Category
            // 
            this.dataGridView_Category.AllowUserToAddRows = false;
            this.dataGridView_Category.AllowUserToDeleteRows = false;
            this.dataGridView_Category.AllowUserToResizeColumns = false;
            this.dataGridView_Category.AllowUserToResizeRows = false;
            this.dataGridView_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Category.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Category.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Category.Location = new System.Drawing.Point(591, 76);
            this.dataGridView_Category.Name = "dataGridView_Category";
            this.dataGridView_Category.RowHeadersVisible = false;
            this.dataGridView_Category.RowHeadersWidth = 62;
            this.dataGridView_Category.RowTemplate.Height = 28;
            this.dataGridView_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Category.Size = new System.Drawing.Size(299, 210);
            this.dataGridView_Category.TabIndex = 6;
            this.dataGridView_Category.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Category_CellMouseClick);
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Category.Location = new System.Drawing.Point(586, 34);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(118, 32);
            this.label_Category.TabIndex = 5;
            this.label_Category.Text = "Category";
            // 
            // label_NamaCategory
            // 
            this.label_NamaCategory.AutoSize = true;
            this.label_NamaCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NamaCategory.Location = new System.Drawing.Point(587, 314);
            this.label_NamaCategory.Name = "label_NamaCategory";
            this.label_NamaCategory.Size = new System.Drawing.Size(60, 21);
            this.label_NamaCategory.TabIndex = 7;
            this.label_NamaCategory.Text = "Nama :";
            // 
            // textBox_NamaCategory
            // 
            this.textBox_NamaCategory.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NamaCategory.Location = new System.Drawing.Point(670, 311);
            this.textBox_NamaCategory.Name = "textBox_NamaCategory";
            this.textBox_NamaCategory.Size = new System.Drawing.Size(220, 29);
            this.textBox_NamaCategory.TabIndex = 8;
            // 
            // button_RemoveCategory
            // 
            this.button_RemoveCategory.BackColor = System.Drawing.Color.LightCoral;
            this.button_RemoveCategory.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveCategory.Location = new System.Drawing.Point(790, 347);
            this.button_RemoveCategory.Name = "button_RemoveCategory";
            this.button_RemoveCategory.Size = new System.Drawing.Size(100, 65);
            this.button_RemoveCategory.TabIndex = 10;
            this.button_RemoveCategory.Text = "Remove Category";
            this.button_RemoveCategory.UseVisualStyleBackColor = false;
            this.button_RemoveCategory.Click += new System.EventHandler(this.button_RemoveCategory_Click);
            // 
            // button_AddCategory
            // 
            this.button_AddCategory.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_AddCategory.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCategory.Location = new System.Drawing.Point(684, 347);
            this.button_AddCategory.Name = "button_AddCategory";
            this.button_AddCategory.Size = new System.Drawing.Size(100, 65);
            this.button_AddCategory.TabIndex = 11;
            this.button_AddCategory.Text = "Add Category";
            this.button_AddCategory.UseVisualStyleBackColor = false;
            this.button_AddCategory.Click += new System.EventHandler(this.button_AddCategory_Click);
            // 
            // label_Details
            // 
            this.label_Details.AutoSize = true;
            this.label_Details.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Details.Location = new System.Drawing.Point(35, 416);
            this.label_Details.Name = "label_Details";
            this.label_Details.Size = new System.Drawing.Size(92, 32);
            this.label_Details.TabIndex = 12;
            this.label_Details.Text = "Details";
            // 
            // textBox_NamaDetails
            // 
            this.textBox_NamaDetails.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NamaDetails.Location = new System.Drawing.Point(141, 457);
            this.textBox_NamaDetails.Name = "textBox_NamaDetails";
            this.textBox_NamaDetails.Size = new System.Drawing.Size(408, 29);
            this.textBox_NamaDetails.TabIndex = 14;
            // 
            // label_NamaDetails
            // 
            this.label_NamaDetails.AutoSize = true;
            this.label_NamaDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NamaDetails.Location = new System.Drawing.Point(36, 460);
            this.label_NamaDetails.Name = "label_NamaDetails";
            this.label_NamaDetails.Size = new System.Drawing.Size(60, 21);
            this.label_NamaDetails.TabIndex = 13;
            this.label_NamaDetails.Text = "Nama :";
            // 
            // label_CategoryDetails
            // 
            this.label_CategoryDetails.AutoSize = true;
            this.label_CategoryDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CategoryDetails.Location = new System.Drawing.Point(36, 497);
            this.label_CategoryDetails.Name = "label_CategoryDetails";
            this.label_CategoryDetails.Size = new System.Drawing.Size(86, 21);
            this.label_CategoryDetails.TabIndex = 15;
            this.label_CategoryDetails.Text = "Category :";
            // 
            // label_HargaDetails
            // 
            this.label_HargaDetails.AutoSize = true;
            this.label_HargaDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HargaDetails.Location = new System.Drawing.Point(36, 534);
            this.label_HargaDetails.Name = "label_HargaDetails";
            this.label_HargaDetails.Size = new System.Drawing.Size(62, 21);
            this.label_HargaDetails.TabIndex = 16;
            this.label_HargaDetails.Text = "Harga :";
            // 
            // label_StockDetails
            // 
            this.label_StockDetails.AutoSize = true;
            this.label_StockDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StockDetails.Location = new System.Drawing.Point(36, 570);
            this.label_StockDetails.Name = "label_StockDetails";
            this.label_StockDetails.Size = new System.Drawing.Size(59, 21);
            this.label_StockDetails.TabIndex = 17;
            this.label_StockDetails.Text = "Stock :";
            // 
            // textBox_HargaDetails
            // 
            this.textBox_HargaDetails.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HargaDetails.Location = new System.Drawing.Point(141, 531);
            this.textBox_HargaDetails.Name = "textBox_HargaDetails";
            this.textBox_HargaDetails.Size = new System.Drawing.Size(121, 29);
            this.textBox_HargaDetails.TabIndex = 19;
            this.textBox_HargaDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HargaDetails_KeyPress);
            // 
            // textBox_StockDetails
            // 
            this.textBox_StockDetails.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StockDetails.Location = new System.Drawing.Point(141, 567);
            this.textBox_StockDetails.Name = "textBox_StockDetails";
            this.textBox_StockDetails.Size = new System.Drawing.Size(121, 29);
            this.textBox_StockDetails.TabIndex = 20;
            this.textBox_StockDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_StockDetails_KeyPress);
            // 
            // comboBox_CategoryDetails
            // 
            this.comboBox_CategoryDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CategoryDetails.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CategoryDetails.FormattingEnabled = true;
            this.comboBox_CategoryDetails.Location = new System.Drawing.Point(141, 494);
            this.comboBox_CategoryDetails.Name = "comboBox_CategoryDetails";
            this.comboBox_CategoryDetails.Size = new System.Drawing.Size(121, 29);
            this.comboBox_CategoryDetails.TabIndex = 21;
            // 
            // button_AddProduct
            // 
            this.button_AddProduct.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_AddProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddProduct.Location = new System.Drawing.Point(282, 512);
            this.button_AddProduct.Name = "button_AddProduct";
            this.button_AddProduct.Size = new System.Drawing.Size(85, 65);
            this.button_AddProduct.TabIndex = 23;
            this.button_AddProduct.Text = "Add Product";
            this.button_AddProduct.UseVisualStyleBackColor = false;
            this.button_AddProduct.Click += new System.EventHandler(this.button_AddProduct_Click);
            // 
            // button_EditProduct
            // 
            this.button_EditProduct.BackColor = System.Drawing.Color.Moccasin;
            this.button_EditProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EditProduct.Location = new System.Drawing.Point(373, 512);
            this.button_EditProduct.Name = "button_EditProduct";
            this.button_EditProduct.Size = new System.Drawing.Size(85, 65);
            this.button_EditProduct.TabIndex = 22;
            this.button_EditProduct.Text = "Edit Product";
            this.button_EditProduct.UseVisualStyleBackColor = false;
            this.button_EditProduct.Click += new System.EventHandler(this.button_EditProduct_Click);
            // 
            // button_RemoveProduct
            // 
            this.button_RemoveProduct.BackColor = System.Drawing.Color.LightCoral;
            this.button_RemoveProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveProduct.Location = new System.Drawing.Point(464, 512);
            this.button_RemoveProduct.Name = "button_RemoveProduct";
            this.button_RemoveProduct.Size = new System.Drawing.Size(85, 65);
            this.button_RemoveProduct.TabIndex = 24;
            this.button_RemoveProduct.Text = "Remove Product";
            this.button_RemoveProduct.UseVisualStyleBackColor = false;
            this.button_RemoveProduct.Click += new System.EventHandler(this.button_RemoveProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::THA_W5_KEZIA_Y.Properties.Resources.b7bc341ad3cf9b8e2f7dc8774782c675_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(698, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(929, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_RemoveProduct);
            this.Controls.Add(this.button_AddProduct);
            this.Controls.Add(this.button_EditProduct);
            this.Controls.Add(this.comboBox_CategoryDetails);
            this.Controls.Add(this.textBox_StockDetails);
            this.Controls.Add(this.textBox_HargaDetails);
            this.Controls.Add(this.label_StockDetails);
            this.Controls.Add(this.label_HargaDetails);
            this.Controls.Add(this.label_CategoryDetails);
            this.Controls.Add(this.textBox_NamaDetails);
            this.Controls.Add(this.label_NamaDetails);
            this.Controls.Add(this.label_Details);
            this.Controls.Add(this.button_AddCategory);
            this.Controls.Add(this.button_RemoveCategory);
            this.Controls.Add(this.textBox_NamaCategory);
            this.Controls.Add(this.label_NamaCategory);
            this.Controls.Add(this.dataGridView_Category);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.comboBox_Filter);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.button_All);
            this.Controls.Add(this.dataGridView_Product);
            this.Controls.Add(this.label_Product);
            this.Name = "Form1";
            this.Text = "Blink Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.DataGridView dataGridView_Product;
        private System.Windows.Forms.Button button_All;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.ComboBox comboBox_Filter;
        private System.Windows.Forms.DataGridView dataGridView_Category;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_NamaCategory;
        private System.Windows.Forms.TextBox textBox_NamaCategory;
        private System.Windows.Forms.Button button_RemoveCategory;
        private System.Windows.Forms.Button button_AddCategory;
        private System.Windows.Forms.Label label_Details;
        private System.Windows.Forms.TextBox textBox_NamaDetails;
        private System.Windows.Forms.Label label_NamaDetails;
        private System.Windows.Forms.Label label_CategoryDetails;
        private System.Windows.Forms.Label label_HargaDetails;
        private System.Windows.Forms.Label label_StockDetails;
        private System.Windows.Forms.TextBox textBox_HargaDetails;
        private System.Windows.Forms.TextBox textBox_StockDetails;
        private System.Windows.Forms.ComboBox comboBox_CategoryDetails;
        private System.Windows.Forms.Button button_AddProduct;
        private System.Windows.Forms.Button button_EditProduct;
        private System.Windows.Forms.Button button_RemoveProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

