using ITP4915_group3_project.database;
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

            MySqlConnection conn = new dbConnect().getConn();

            string sql = "SELECT * FROM 4523_g1_project_db.restaurantstockdetail;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            kryptonTextBoxID.Text = rdr[0].ToString();
            kryptonTextBoxName.Text = rdr[1].ToString();
            kryptonTextBoxCategory.Text = rdr[2].ToString();
            kryptonTextBoxBrand.Text = rdr[3].ToString();
            kryptonDomainUpDownQty.Text = rdr[4].ToString();
            kryptonRichTextBoxRemarks.Text = rdr[5].ToString();

            rdr.Close();
        }
    }
}
