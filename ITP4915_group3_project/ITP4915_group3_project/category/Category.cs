﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ITP4915_group3_project.category
{
    public partial class Category : KryptonForm
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButtonCategory_Click(object sender, EventArgs e)
        {
            new category.header(kryptonPanelHeader, panelCategoryContent);
        }

        private void kryptonButtonItem_Click(object sender, EventArgs e)
        {
            new produce.header(kryptonPanelHeader, panelCategoryContent);
        }

        private void kryptonButtonBrand_Click(object sender, EventArgs e)
        {
            new brand.header(kryptonPanelHeader, panelCategoryContent);
        }

        private void kryptonButtonReturn_Click(object sender, EventArgs e)
        {
            new return_reson.header(kryptonPanelHeader, panelCategoryContent);
        }

        private void kryptonButtonSupplier_Click(object sender, EventArgs e)
        {
            new supplier.header(kryptonPanelHeader, panelCategoryContent);
        }

        private void kryptonButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButtonRestaurant_Click(object sender, EventArgs e)
        {
            new restaurant.header(kryptonPanelHeader, panelCategoryContent);
        }

        private void kryptonButtonWarehouse_Click(object sender, EventArgs e)
        {
            new warehouse.header(kryptonPanelHeader, panelCategoryContent);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            new address.header(kryptonPanelHeader, panelCategoryContent);
        }
    }
}
