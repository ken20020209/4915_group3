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
        private purchase_dbDataSetTableAdapters.bpa_remain_qtyTableAdapter bpa_Remain_QtyTableAdapter = new purchase_dbDataSetTableAdapters.bpa_remain_qtyTableAdapter();
        private purchase_dbDataSetTableAdapters.blanket_releaseTableAdapter blanket_ReleaseTableAdapter = new purchase_dbDataSetTableAdapters.blanket_releaseTableAdapter();
        private purchase_dbDataSetTableAdapters.purchase_order_allTableAdapter purchase_Order_AllTableAdapter = new purchase_dbDataSetTableAdapters.purchase_order_allTableAdapter();

        //init table adapter manageer
        private purchase_dbDataSetTableAdapters.TableAdapterManager TableAdapterManager = new purchase_dbDataSetTableAdapters.TableAdapterManager();
        

        //init bindingSource and dataset
        private purchase_dbDataSet dataSet=new purchase_dbDataSet();
        private System.Windows.Forms.BindingSource itemBindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource warehouseItemBindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource purchasersRequestBindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource bpa_Remain_QtyBindingSource = new System.Windows.Forms.BindingSource();



        
        



        public requestMatch()
        {
            //binding manage
            this.TableAdapterManager.purchasers_requestTableAdapter = this.purchasers_RequestTableAdapter;
            this.TableAdapterManager.itemTableAdapter = this.itemTableAdapter;
            this.TableAdapterManager.warehouse_itemTableAdapter = this.warehouse_ItemTableAdapter;
            this.TableAdapterManager.warehousedispatchinstructionTableAdapter = this.warehousedispatchinstructionTableAdapter;
            this.TableAdapterManager.blanket_releaseTableAdapter = this.blanket_ReleaseTableAdapter;
            this.TableAdapterManager.purchase_order_allTableAdapter = this.purchase_Order_AllTableAdapter;
            

            //set binginSource 
            // relation
            //purchasers_request -> purchasers_request_item -> Warehouse_item_item_ID_fk
            //                                              -> 
            purchasersRequestBindingSource.DataSource = this.dataSet;
            purchasersRequestBindingSource.DataMember = "purchasers_request";

            itemBindingSource.DataSource = purchasersRequestBindingSource;
            itemBindingSource.DataMember = "purchasers_request_item";

            warehouseItemBindingSource.DataSource = itemBindingSource;
            warehouseItemBindingSource.DataMember = "Warehouse_item_item_ID_fk";

            bpa_Remain_QtyBindingSource.DataSource = itemBindingSource;
            bpa_Remain_QtyBindingSource.DataMember = "bpa_remain_qty_item";





            //fill dataset
            this.purchasers_RequestTableAdapter.FillBy_Status(this.dataSet.purchasers_request,1000, "%");
            this.itemTableAdapter.Fill(this.dataSet.item);
            this.warehouse_ItemTableAdapter.Fill(this.dataSet.warehouse_item);
            this.warehousedispatchinstructionTableAdapter.Fill(this.dataSet.warehousedispatchinstruction);
            this.bpa_Remain_QtyTableAdapter.FillBy_lessEqual_qty(this.dataSet.bpa_remain_qty, 0);
            this.blanket_ReleaseTableAdapter.Fill(this.dataSet.blanket_release);
            this.purchase_Order_AllTableAdapter.Fill(this.dataSet.purchase_order_all);







        }

        // return processed num record
        public void process()
        {

            //count affected row
            this.totalRequest = this.dataSet.purchasers_request.Count();

            if (Properties.Settings.Default.autoWarehouse == "Yes")
            {
#if DEBUG
                //debug message
                this.dataSet.warehousedispatchinstruction.warehousedispatchinstructionRowChanged += (object sender, purchase_dbDataSet.warehousedispatchinstructionRowChangeEvent e) =>
                  {
                      string message="";
                      message += " Instruction_ID:" + e.Row.Instruction_ID;
                      message += " itemID:" + e.Row.itemID;
                      message += " status_id:" + e.Row.status_id;
                      message += " Purchasers_Request_id:" + e.Row.Purchasers_Request_id;
                      message += " item_name:" + e.Row.warehouse_itemRowParent.itemRow.item_name;

                      


                      Console.WriteLine(message);
                  };
#endif
                matchWarehouse();
            }

            if (Properties.Settings.Default.autoBPA == "Yes") 
            {
#if DEBUG
                //debug message
                this.dataSet.blanket_release.blanket_releaseRowChanged += (object sender, purchase_dbDataSet.blanket_releaseRowChangeEvent e) =>
                  {

                  };
                this.dataSet.purchase_order_all.purchase_order_allRowChanged += (object sender, purchase_dbDataSet.purchase_order_allRowChangeEvent e) =>
                  {
                      string message = "";
                      message += " purchasers_request_ID:" + e.Row.purchasers_request_ID;
                      message += " BR_relase_ID:" + e.Row.BR_relase_ID;
                      message += " line_ID:" + e.Row.blanket_releaseRow.line_ID;
                      message += " create_date:" + e.Row.blanket_releaseRow.create_date;
                      message += " expected_delivery_date:" + e.Row.blanket_releaseRow.expected_delivery_date;
                      message += " item_qty:" + e.Row.blanket_releaseRow.item_qty;

                      Console.WriteLine(message);
                  };
#endif
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
        // use binding source get date 
        // bad method
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
        // use datarow reation match bpa
        // better than use binding source
        private void matchBPA()
        {
            foreach (purchase_dbDataSet.purchasers_requestRow purchasers_RequestRow in this.dataSet.purchasers_request.Rows)
            {
                if(purchasers_RequestRow.status_ID!=1000)
                {
                    continue;
                }
                int requireQty = purchasers_RequestRow.qty;
                int requestID = purchasers_RequestRow.purchasers_request_id;
                // save rows  wait to add to table
                List<purchase_dbDataSet.blanket_releaseRow> blanket_ReleaseRows = new List<purchase_dbDataSet.blanket_releaseRow>();
                

                // order date;
                DateTime create_date = DateTime.Now;
                DateTime expected_date = create_date.AddDays(7);

               

                foreach(purchase_dbDataSet.bpa_remain_qtyRow bpa_Remain_QtyRow in purchasers_RequestRow.itemRow.Getbpa_remain_qtyRows())
                {
                    purchase_dbDataSet.blanket_releaseRow blanket_ReleaseRow = this.dataSet.blanket_release.Newblanket_releaseRow();
                    

                    int lineID = bpa_Remain_QtyRow.lines_ID;

                    int releaseQty = 0;
                    if(requireQty==0)
                    {
                        break;
                    }
                    if(bpa_Remain_QtyRow.remain_qty>=requireQty)
                    {
                        releaseQty = requireQty;
                    }
                    else
                    {
                        releaseQty = bpa_Remain_QtyRow.remain_qty;
                    }
                    requireQty -= releaseQty;
                    blanket_ReleaseRow.line_ID = lineID;
                    blanket_ReleaseRow.create_date = create_date;
                    blanket_ReleaseRow.expected_delivery_date = expected_date;
                    blanket_ReleaseRow.item_qty = releaseQty;

                    //add to temp table 
                    blanket_ReleaseRows.Add(blanket_ReleaseRow);

                }
                if(requireQty==0)
                {
                    foreach(purchase_dbDataSet.blanket_releaseRow blanket_ReleaseRow in blanket_ReleaseRows)
                    {
                        //add release 
                        this.dataSet.blanket_release.Addblanket_releaseRow(blanket_ReleaseRow);
                        //add purchase order all
                        purchase_dbDataSet.purchase_order_allRow purchase_Order_AllRow = this.dataSet.purchase_order_all.Newpurchase_order_allRow();
                        purchase_Order_AllRow.BR_relase_ID = this.dataSet.blanket_release.Last().release_ID;
                        purchase_Order_AllRow.purchasers_request_ID = requestID;

                        this.dataSet.purchase_order_all.Addpurchase_order_allRow(purchase_Order_AllRow);
                    }

                    //update request statuts
                    purchasers_RequestRow.status_ID = 1200;
                }
            }
        }
    }
}
