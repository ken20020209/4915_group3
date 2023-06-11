using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.stock
{
    public partial class detail : Form
    {
        public detail()
        {
            InitializeComponent();
        }
        public detail(string restID,string itemID)
        {
            InitializeComponent();
/*
            string connStr = "server = localhost; user = root; database = 4523_g1_project_db; port = 3308; password = 123123";
            MySqlConnection conn;

            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            

            string sql = "SELECT * FROM 4523_g1_project_db.restaurantstockdetail;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();*/

   /*         rdr.Read();*/
            //use data set to read database
            restaurantstockdetailTableAdapter.Fill(this._4523_g1_project_dbDataSet.restaurantstockdetail);
            _4523_g1_project_dbDataSet.restaurantstockdetailRow data = this._4523_g1_project_dbDataSet.restaurantstockdetail.FindByitem_ID("0");
            
            kryptonTextBoxID.Text = data.item_ID;
            kryptonTextBoxName.Text = data.item_name;
            kryptonTextBoxCategory.Text = data.category_name;
            kryptonTextBoxBrand.Text = data.name;
            kryptonDomainUpDownQty.Text = data.qty.ToString();
            kryptonRichTextBoxRemarks.Text = data.remarks;

 /*           rdr.Close();*/
        }


    }
}
