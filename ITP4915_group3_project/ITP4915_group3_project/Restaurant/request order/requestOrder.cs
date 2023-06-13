using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915_group3_project.Restaurant.request_order
{
    public class requestOrder
    {
        public string request_ID;
        public List<string> item_ID;
        public List<int> item_qty;
        public List<string> item_name;
        public string restaurant_ID;
        public string restaurant_Name;
        public string creator_ID;
        public string creator_Name;
        public string mysqlDate;
        public string priority;

        public requestOrder(string restaurant_ID,string restaurant_Name,string creator_ID, string creator_Name)
        {
            this.restaurant_Name = restaurant_Name;
            this.restaurant_ID = restaurant_ID;
            this.creator_ID = creator_ID;
            this.creator_Name = creator_Name;
            //need to assgin one id;
            this.request_ID = "00";

            DateTime date = DateTime.Now; // or any other date you want to create
            this.mysqlDate = date.ToString("yyyy-MM-dd");

            item_ID = new List<string>();
            item_qty = new List<int>();
            item_name = new List<string>();
        }
        //laod data to db;
        public void insertDB()
        {

        }
    }
}
