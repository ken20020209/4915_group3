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
        public string restaurant_ID;
        public string restaurant_Name;
        public string creator_ID;
        public string creator_Name;

        public requestOrder(string restaurant_ID,string restaurant_Name,string creator_ID, string creator_Name)
        {
            this.restaurant_Name = restaurant_Name;
            this.restaurant_ID = restaurant_ID;
            this.creator_ID = creator_ID;
            this.creator_Name = creator_Name;
            //need to assgin one id;
            this.request_ID = "00";

            item_ID = new List<string>();
            item_qty = new List<int>();
        }
    }
}
