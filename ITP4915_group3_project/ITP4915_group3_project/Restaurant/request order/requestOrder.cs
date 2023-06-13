﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ITP4915_group3_project.Restaurant.request_order
{
    public class requestOrder
    {
        public int request_ID;
        public List<int> item_ID;
        public List<int> item_qty;
        public List<string> item_name;
        public int restaurant_ID;
        public string restaurant_Name;
        public int creator_ID;
        public string creator_Name;
        public DateTime mysqlDate;
        public int priority;
        public requestOrder(int restaurant_ID,string restaurant_Name, int creator_ID, string creator_Name)
        {
            this.restaurant_Name = restaurant_Name;
            this.restaurant_ID = restaurant_ID;
            this.creator_ID = creator_ID;
            this.creator_Name = creator_Name;
            //need to assgin one id;

            DateTime date = DateTime.Now; // or any other date you want to create
            this.mysqlDate = date;

            item_ID = new List<int>();
            item_qty = new List<int>();
            item_name = new List<string>();
        }
        //laod data to db;
        public void insertDB()
        {
            _4523_g1_project_dbDataSet.purchasers_requestDataTable datasetRequest = new _4523_g1_project_dbDataSet.purchasers_requestDataTable();
            _4523_g1_project_dbDataSetTableAdapters.purchasers_requestTableAdapter adapterRequest = new _4523_g1_project_dbDataSetTableAdapters.purchasers_requestTableAdapter();
            adapterRequest.Fill(datasetRequest);
            for(int i=0;i<item_qty.Count();i++)
            {
                adapterRequest.Insert(creator_ID, restaurant_ID, item_ID[i], item_qty[i], priority, 1, mysqlDate, mysqlDate, "");
            }
        }
            
    }
}
