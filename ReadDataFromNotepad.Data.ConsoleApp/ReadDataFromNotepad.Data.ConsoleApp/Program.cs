using ReadDataFromNotepad.Data.ConsoleApp.inrule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class ReadFromFile
    {
        static void Main()
        {
            /*
            //1
            Pricetierreadclass pricetierreadclass = new Pricetierreadclass();
            LoadDataTableToSQL loadDataTableToSQL = new LoadDataTableToSQL();
            
            DataTable dt = pricetierreadclass.ConvertToDataTable();
            loadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_PriceTiersResults");
            loadDataTableToSQL.BulkInsert(dt, "intakeRAW.Sng_ON_PriceTiersResults");

            //2
            AssemblyItemRead assemblyItemReadclass = new AssemblyItemRead();
            LoadDataTableToSQL assemblyItemloadDataTableToSQL = new LoadDataTableToSQL();

            DataTable assemblyItemdt = assemblyItemReadclass.ConvertToDataTable();
            assemblyItemloadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_AssemblyItems");
            assemblyItemloadDataTableToSQL.BulkInsert(assemblyItemdt, "intakeRAW.Sng_ON_AssemblyItems");

            //3
            BacklogReportRead backlogReportReadclass = new BacklogReportRead();
            LoadDataTableToSQL backlogReportReadloadDataTableToSQL = new LoadDataTableToSQL();

            DataTable backlogReportReaddt = backlogReportReadclass.ConvertToDataTable();
            backlogReportReadloadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_Backlog");
            backlogReportReadloadDataTableToSQL.BulkInsert(backlogReportReaddt, "intakeRAW.Sng_ON_Backlog");
            
            //4
            BookingsListRead bokingsListReadclass = new BookingsListRead();
            LoadDataTableToSQL bokingsListReadloadDataTableToSQL = new LoadDataTableToSQL();

            DataTable bokingsListReaddt = bokingsListReadclass.ConvertToDataTable();
            bokingsListReadloadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_bookings_full");
            bokingsListReadloadDataTableToSQL.BulkInsert(bokingsListReaddt, "intakeRAW.Sng_ON_bookings_full");

            //5
            BillofMaterialMasterRead billofMaterialMasterReadclass = new BillofMaterialMasterRead();
            LoadDataTableToSQL billofMaterialMasterReadloadDataTableToSQL = new LoadDataTableToSQL();

            DataTable billofMaterialMasterReaddt = billofMaterialMasterReadclass.ConvertToDataTable();
            billofMaterialMasterReadloadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_BillofMaterialMaster");
            billofMaterialMasterReadloadDataTableToSQL.BulkInsert(billofMaterialMasterReaddt, "intakeRAW.Sng_ON_BillofMaterialMaster");


            //6
            CustomerMasterRead customerMasterReadclass = new CustomerMasterRead();
            LoadDataTableToSQL customerMasterReadloadDataTableToSQL = new LoadDataTableToSQL();

            DataTable customerMasterReaddt = customerMasterReadclass.ConvertToDataTable();
            customerMasterReadloadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_CustomerMaster");
            customerMasterReadloadDataTableToSQL.BulkInsert(customerMasterReaddt, "intakeRAW.Sng_ON_CustomerMaster");

            //7
            DailyReportRead dailyReportReadclass = new DailyReportRead();
            LoadDataTableToSQL dailyReportReadloadDataTableToSQL = new LoadDataTableToSQL();

            DataTable dailyReportReaddt = dailyReportReadclass.ConvertToDataTable();
            dailyReportReadloadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_invoices");
            dailyReportReadloadDataTableToSQL.BulkInsert(dailyReportReaddt, "intakeRAW.Sng_ON_invoices");

            //8
            DashboardQualityDataRead dashboardQualityDataReadclass = new DashboardQualityDataRead();
            LoadDataTableToSQL dashboardQualityDataReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable dashboardQualityDataReaddt = dashboardQualityDataReadclass.ConvertToDataTable();
            dashboardQualityDataReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_QualityData");
            dashboardQualityDataReadDataTableToSQL.BulkInsert(dashboardQualityDataReaddt, "intakeRAW.Sng_ON_QualityData");

            //9
            InventoryAdjustmentsandTransferRead inventoryAdjustmentsandTransferReadclass = new InventoryAdjustmentsandTransferRead();
            LoadDataTableToSQL inventoryAdjustmentsandTransferReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable inventoryAdjustmentsandTransferReaddt = inventoryAdjustmentsandTransferReadclass.ConvertToDataTable();
            inventoryAdjustmentsandTransferReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_inventory_adjustment_transfer");
            inventoryAdjustmentsandTransferReadDataTableToSQL.BulkInsert(inventoryAdjustmentsandTransferReaddt, "intakeRAW.Sng_ON_inventory_adjustment_transfer");

            //10
            InventoryBalanceResultRead inventoryBalanceResultReadclass = new InventoryBalanceResultRead();
            LoadDataTableToSQL inventoryBalanceResultReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable inventoryBalanceResultReaddt = inventoryBalanceResultReadclass.ConvertToDataTable();
            inventoryBalanceResultReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_InventoryBalanceResults");
            inventoryBalanceResultReadDataTableToSQL.BulkInsert(inventoryBalanceResultReaddt, "intakeRAW.Sng_ON_InventoryBalanceResults");

            //11
            InventoryItemResultRead inventoryItemResultReadclass = new InventoryItemResultRead();
            LoadDataTableToSQL inventoryItemResultReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable inventoryItemResultReaddt = inventoryItemResultReadclass.ConvertToDataTable();
            inventoryItemResultReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_InventoryItems");
            inventoryItemResultReadDataTableToSQL.BulkInsert(inventoryItemResultReaddt, "intakeRAW.Sng_ON_InventoryItems");

            */

            //12
            InvoicesListRead invoicesListReadclass = new InvoicesListRead();
            LoadDataTableToSQL invoicesListReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable invoicesListReaddt = invoicesListReadclass.ConvertToDataTable();
            invoicesListReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_invoices_full");
            invoicesListReadDataTableToSQL.BulkInsert(invoicesListReaddt, "intakeRAW.Sng_ON_invoices_full");

            /*           
            //13
            ItemFulfillmentListRead itemFulfillmentListReadclass = new ItemFulfillmentListRead();
            LoadDataTableToSQL itemFulfillmentListReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable itemFulfillmentListReaddt = itemFulfillmentListReadclass.ConvertToDataTable();
            itemFulfillmentListReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_item_fulfillment_full");
            itemFulfillmentListReadDataTableToSQL.BulkInsert(itemFulfillmentListReaddt, "intakeRAW.Sng_ON_item_fulfillment_full");

            //14
            ItemMasterRead itemMasterReadclass = new ItemMasterRead();
            LoadDataTableToSQL itemMasterReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable itemMasterReaddt = itemMasterReadclass.ConvertToDataTable();
            itemMasterReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_ItemMaster");
            itemMasterReadDataTableToSQL.BulkInsert(itemMasterReaddt, "intakeRAW.Sng_ON_ItemMaster");

            //15
            ItemReceiptitemListResultRead itemReceiptitemListResultReadclass = new ItemReceiptitemListResultRead();
            LoadDataTableToSQL itemReceiptitemListResultReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable itemReceiptitemListResultReaddt = itemReceiptitemListResultReadclass.ConvertToDataTable();
            itemReceiptitemListResultReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_ItemReceipt_itemlist");
            itemReceiptitemListResultReadDataTableToSQL.BulkInsert(itemReceiptitemListResultReaddt, "intakeRAW.Sng_ON_ItemReceipt_itemlist");

            //16
            ItemReceiptsListResultRead itemReceiptsListResultReadclass = new ItemReceiptsListResultRead();
            LoadDataTableToSQL itemReceiptsListResultReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable itemReceiptsListResultReaddt = itemReceiptsListResultReadclass.ConvertToDataTable();
            itemReceiptsListResultReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_item_fulfillment_full");
            itemReceiptsListResultReadDataTableToSQL.BulkInsert(itemReceiptsListResultReaddt, "intakeRAW.Sng_ON_item_fulfillment_full");

            //17
            MOListResultRead mOListResultReadclass = new MOListResultRead();
            LoadDataTableToSQL mOListResultReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable mOListResultReaddt = mOListResultReadclass.ConvertToDataTable();
            mOListResultReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_Manufacturing_operation_tasks");
            mOListResultReadDataTableToSQL.BulkInsert(mOListResultReaddt, "intakeRAW.Sng_ON_Manufacturing_operation_tasks");

            //18
            ODBCItemFulfillmentResultRead oDBCItemFulfillmentResultReadclass = new ODBCItemFulfillmentResultRead();
            LoadDataTableToSQL oDBCItemFulfillmentResultReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable oDBCItemFulfillmentResultReaddt = oDBCItemFulfillmentResultReadclass.ConvertToDataTable();
            oDBCItemFulfillmentResultReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_Itemfulfillment");
            oDBCItemFulfillmentResultReadDataTableToSQL.BulkInsert(oDBCItemFulfillmentResultReaddt, "intakeRAW.Sng_ON_Itemfulfillment");

            //19
            OTDReportResultRead oTDReportResultReadclass = new OTDReportResultRead();
            LoadDataTableToSQL oTDReportResultReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable oTDReportResultReaddt = oTDReportResultReadclass.ConvertToDataTable();
            oTDReportResultReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_Otd_report");
            oTDReportResultReadDataTableToSQL.BulkInsert(oTDReportResultReaddt, "intakeRAW.Sng_ON_Otd_report");

            //20
            ProductivityReportResultRead productivityReportResultReadclass = new ProductivityReportResultRead();
            LoadDataTableToSQL productivityReportResultReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable productivityReportResultReaddt = productivityReportResultReadclass.ConvertToDataTable();
            productivityReportResultReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_productivity_report_data");
            productivityReportResultReadDataTableToSQL.BulkInsert(productivityReportResultReaddt, "intakeRAW.Sng_ON_productivity_report_data");

            //21
            PurchaseOrdersListRead purchaseOrdersListReadclass = new PurchaseOrdersListRead();
            LoadDataTableToSQL purchaseOrdersListReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable purchaseOrdersListReaddt = purchaseOrdersListReadclass.ConvertToDataTable();
            purchaseOrdersListReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_Purchase_orders");
            purchaseOrdersListReadDataTableToSQL.BulkInsert(purchaseOrdersListReaddt, "intakeRAW.Sng_ON_Purchase_orders");

            //22
            ReturnAuthorizationitemlistResultRead returnAuthorizationitemlistResultReadclass = new ReturnAuthorizationitemlistResultRead();
            LoadDataTableToSQL returnAuthorizationitemlistResultReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable returnAuthorizationitemlistResultReaddt = returnAuthorizationitemlistResultReadclass.ConvertToDataTable();
            returnAuthorizationitemlistResultReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_Returnauthorization_itemlist");
            returnAuthorizationitemlistResultReadDataTableToSQL.BulkInsert(returnAuthorizationitemlistResultReaddt, "intakeRAW.Sng_ON_Returnauthorization_itemlist");

            //23
            RGAtimestampcountRead rGAtimestampcountReadclass = new RGAtimestampcountRead();
            LoadDataTableToSQL rGAtimestampcountReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable rGAtimestampcountReaddt = rGAtimestampcountReadclass.ConvertToDataTable();
            rGAtimestampcountReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_RGATimeStamp");
            rGAtimestampcountReadDataTableToSQL.BulkInsert(rGAtimestampcountReaddt, "intakeRAW.Sng_ON_RGATimeStamp");

            //24
            SalesOrderReviewRead salesOrderReviewReadclass = new SalesOrderReviewRead();
            LoadDataTableToSQL salesOrderReviewReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable salesOrderReviewReaddt = salesOrderReviewReadclass.ConvertToDataTable();
            salesOrderReviewReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_bookings");
            salesOrderReviewReadDataTableToSQL.BulkInsert(salesOrderReviewReaddt, "intakeRAW.Sng_ON_bookings");

            //25
            WorkOrder_itemListRead workOrder_itemListReadclass = new WorkOrder_itemListRead();
            LoadDataTableToSQL workOrder_itemListReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable workOrder_itemListReaddt = workOrder_itemListReadclass.ConvertToDataTable();
            workOrder_itemListReadDataTableToSQL.DeleteRecords("intakeRAW.Sng_ON_WorkOrder_itemList");
            workOrder_itemListReadDataTableToSQL.BulkInsert(workOrder_itemListReaddt, "intakeRAW.Sng_ON_WorkOrder_itemList");

            //26
            WorkOrderCompletionListRead workOrderCompletionListReadclass = new WorkOrderCompletionListRead();
            LoadDataTableToSQL workOrderCompletionListReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable workOrderCompletionListReaddt = workOrderCompletionListReadclass.ConvertToDataTable();
            workOrderCompletionListReadDataTableToSQL.DeleteRecords("intakeRAW.sng_on_work_order_completion");
            workOrderCompletionListReadDataTableToSQL.BulkInsert(workOrderCompletionListReaddt, "intakeRAW.sng_on_work_order_completion");

            //27
            WorkOrdersListRead workOrdersListReadclass = new WorkOrdersListRead();
            LoadDataTableToSQL workOrdersListReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable workOrdersListReaddt = workOrdersListReadclass.ConvertToDataTable();
            workOrdersListReadDataTableToSQL.DeleteRecords("intakeRAW.sng_on_WorkOrdersList");
            workOrdersListReadDataTableToSQL.BulkInsert(workOrdersListReaddt, "intakeRAW.sng_on_WorkOrdersList");
            
            //Inrule
            //1
            WORKBENCHRecurringRevenueRecogn WORKBENCHRecurringRevenueRecognReadclass = new WORKBENCHRecurringRevenueRecogn();
            LoadDataTableToSQL WORKBENCHRecurringRevenueRecognReadDataTableToSQL = new LoadDataTableToSQL();

            DataTable WORKBENCHRecurringRevenueRecognReaddt = WORKBENCHRecurringRevenueRecognReadclass.ConvertToDataTable();
            WORKBENCHRecurringRevenueRecognReadDataTableToSQL.DeleteRecords("intakeRAW.INR_ON_RecurringRevenueRecogn");
            WORKBENCHRecurringRevenueRecognReadDataTableToSQL.BulkInsert(WORKBENCHRecurringRevenueRecognReaddt, "intakeRAW.INR_ON_RecurringRevenueRecogn");
            */

        }
    }
}