using System;
namespace ITP4915_group3_project.General.navi
{
    public partial class navi : Krypton.Toolkit.KryptonForm
    {
        string role_name;
        public navi()
        {
            InitializeComponent();
        }
        public navi(string role_name)
        {
            InitializeComponent();

            this.role_name = role_name;

        }
        

        public void kryptonButtonRestaurant_Click(object sender, EventArgs e)
        {
            // jump to restaurant form
            this.Hide();
            new Restaurant.restaurant().ShowDialog();
            this.Close();
        }

        public void kryptonButtonWarehosue_Click(object sender, EventArgs e)
        {
/*            login.Login.role_id = 21;*/
            this.Hide();
            new warehouse.warehouse().ShowDialog();
            this.Close();
        }

        public void kryptonButtonPurchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Purchase.purchase().ShowDialog();
            this.Close();
        }

        public void kryptonButtonDelivery_Click(object sender, EventArgs e)
        {
            this.Hide();
            new delivery.delivery().ShowDialog();
            this.Close();
        }

        public void kryptonButtonCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new category.Category().ShowDialog();
            this.Close();
        }

        public void kryptonButtonAccounting_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Accounting.accounting().ShowDialog();
            this.Close();
        }

        public void kryptonButtonHR_Click(object sender, EventArgs e)
        {
            this.Hide();
            new humanResources.humanResources().ShowDialog();
            this.Close();
        }

        private void navi_Load(object sender, EventArgs e)
        {
            // different role to different system
            if (role_name == "Restaurant manager")
            {
                kryptonButtonRestaurant_Click(null, null);

            }
            else if (role_name == "warehouse manager")
            {
                kryptonButtonWarehosue_Click(null, null);
            }
            else if (role_name == "Purchase manager")
            {
                kryptonButtonPurchase_Click(null, null);
            }
            else if (role_name == "role2") // disable 
            {
                //kryptonButtonDelivery_Click(null, null);
            }
            else if (role_name == "Category manager")
            {
                kryptonButtonCategory_Click(null, null);
            }
            else if (role_name == "Accounting manager")
            {
                kryptonButtonAccounting_Click(null, null);
            }
            else if (role_name == "HR manager")
            {
                kryptonButtonHR_Click(null, null);
            }
            else if (role_name == "admin")
            {
                //do nothing 
            }
        }
    }
}
