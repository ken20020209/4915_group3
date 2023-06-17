using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ITP4915_group3_project.batchProcessing
{
    class requestMatch
    {
        public int processedNum = 0;
        public int errorProcess = 0;
        public int totalRequest = 0;

        // init adapter
        private purchase_dbDataSetTableAdapters.purchasers_requestTableAdapter purchasers_RequestTableAdapter = new purchase_dbDataSetTableAdapters.purchasers_requestTableAdapter();
        private purchase_dbDataSetTableAdapters.itemTableAdapter itemTableAdapter = new purchase_dbDataSetTableAdapters.itemTableAdapter();
        private purchase_dbDataSetTableAdapters.warehouse_itemTableAdapter warehouse_ItemTableAdapter = new purchase_dbDataSetTableAdapters.warehouse_itemTableAdapter();
        private purchase_dbDataSetTableAdapters.warehousedispatchinstructionTableAdapter warehousedispatchinstructionTableAdapter = new purchase_dbDataSetTableAdapters.warehousedispatchinstructionTableAdapter();

        //init table adapter manageer
        private purchase_dbDataSetTableAdapters.TableAdapterManager TableAdapterManager = new purchase_dbDataSetTableAdapters.TableAdapterManager();
        

        //init bindingSource and dataset
        private purchase_dbDataSet dataSet=new purchase_dbDataSet();
        private System.Windows.Forms.BindingSource itemBindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource warehouseItemBindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource purchasersRequestBindingSource = new System.Windows.Forms.BindingSource();

        
        



        public requestMatch()
        {
            //binding manage
            this.TableAdapterManager.purchasers_requestTableAdapter = this.purchasers_RequestTableAdapter;
            this.TableAdapterManager.itemTableAdapter = this.itemTableAdapter;
            this.TableAdapterManager.warehouse_itemTableAdapter = this.warehouse_ItemTableAdapter;
            this.TableAdapterManager.warehousedispatchinstructionTableAdapter = this.warehousedispatchinstructionTableAdapter;


            //set binginSource 
            // relation
            //purchasers_request -> purchasers_request_item -> Warehouse_item_item_ID_fk
            purchasersRequestBindingSource.DataSource = this.dataSet;
            purchasersRequestBindingSource.DataMember = "purchasers_request";

            itemBindingSource.DataSource = purchasersRequestBindingSource;
            itemBindingSource.DataMember = "purchasers_request_item";

            warehouseItemBindingSource.DataSource = itemBindingSource;
            warehouseItemBindingSource.DataMember = "Warehouse_item_item_ID_fk";
            


            //fill dataset
            this.purchasers_RequestTableAdapter.FillBy_Status(this.dataSet.purchasers_request,1000, "%");
            this.itemTableAdapter.Fill(this.dataSet.item);
            this.warehouse_ItemTableAdapter.Fill(this.dataSet.warehouse_item);
            this.warehousedispatchinstructionTableAdapter.Fill(this.dataSet.warehousedispatchinstruction);







        }

        // return processed num record
        public void process()
        {
            //count affected row
            this.totalRequest = this.dataSet.purchasers_request.Count();

            if (Properties.Settings.Default.autoWarehouse == "Yes")
            {
                matchWarehouse();
            }
            if (Properties.Settings.Default.autoBPA == "Yes") 
            {
                matchBPA();
            }

            // set error status
            foreach(DataRowView rowRequest in purchasersRequestBindingSource)
            {
                if((int)rowRequest.Row["status_ID"]==1000)
                {
                    rowRequest.Row["status_ID"] = 1100;
                    this.errorProcess++;
                }
            }
            //set affected row count
            this.processedNum = this.totalRequest - this.errorProcess;

            //save 
            /*this.TableAdapterManager.UpdateAll(this.dataSet);*/

            
        }
        private void matchWarehouse()
        {
            // for loop print 

            foreach (DataRowView rowRequest in purchasersRequestBindingSource)
            {
                // request statuts is not wait to process
                if ((int)rowRequest.Row["status_ID"] != 1000)
                {
                    continue;
                }

                int purchasers_request_ID = (int)rowRequest.Row["purchasers_request_ID"];
                int requireQty = (int)rowRequest.Row["qty"];
         /*       Console.WriteLine(purchasers_request_ID + " requireQty:" + requireQty);*/

                foreach (DataRowView rowItem in itemBindingSource)
                {

                    /*string itemName = rowItem.Row["item_name"].ToString();*/
                    foreach (DataRowView rowWarehouseItem in warehouseItemBindingSource)
                    {
                        /*Console.WriteLine("     " + itemName + ":" + rowWarehouseItem.Row["qty"]);*/
                        int warehouseQty = (int)rowWarehouseItem.Row["qty"];
                        int item_ID = (int)rowWarehouseItem.Row["item_ID"];
                        int warehouse_ID = (int)rowWarehouseItem.Row["warehouse_ID"];
                        // match success
                        if(warehouseQty>=requireQty)
                        {
                            // insert waerhouse despatch instruction
                            purchase_dbDataSet.warehousedispatchinstructionRow warehousedispatchinstructionRow = this.dataSet.warehousedispatchinstruction.NewwarehousedispatchinstructionRow();
                            warehousedispatchinstructionRow.warehouse_ID = warehouse_ID;
                            warehousedispatchinstructionRow.itemID = item_ID;
                            warehousedispatchinstructionRow.status_id = 3000;
                            warehousedispatchinstructionRow.Purchasers_Request_id = purchasers_request_ID;

                            this.dataSet.warehousedispatchinstruction.AddwarehousedispatchinstructionRow(warehousedispatchinstructionRow);

                            // update warehouse item qty
                            rowWarehouseItem.Row["qty"] =warehouseQty-requireQty;

                            // update request status
                            rowRequest.Row["status_ID"] = 1200;

                            break;
                        }

                    }
                }
                purchasersRequestBindingSource.MoveNext();
            }

            
            
        }
        private void matchBPA()
        {

        }
    }
}
