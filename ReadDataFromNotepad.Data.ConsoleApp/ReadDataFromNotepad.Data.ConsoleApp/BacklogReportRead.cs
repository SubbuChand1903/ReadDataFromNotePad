using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class BacklogReportRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("Subsidiarynohierarchy", typeof(string));
            data.Columns.Add("DocumentNumber", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("Id", typeof(string));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("CustomerPartNumber", typeof(string));
            data.Columns.Add("CustomerPO", typeof(string));
            data.Columns.Add("Description", typeof(string));
            data.Columns.Add("Quantity", typeof(string));
            data.Columns.Add("QuantityCommitted", typeof(string));
            data.Columns.Add("QuantityShipped", typeof(string));
            data.Columns.Add("OpenQuantity", typeof(string));
            data.Columns.Add("DNSB", typeof(string));
            data.Columns.Add("Intercompany", typeof(string));
            data.Columns.Add("ShipComplete", typeof(string));
            data.Columns.Add("Date", typeof(string));
            data.Columns.Add("CustomerRequestDate", typeof(string));
            data.Columns.Add("ManufacturingLeadTimeDate", typeof(string));
            data.Columns.Add("ExpectedShipDate", typeof(string));
            data.Columns.Add("ConfirmDate", typeof(string));
            data.Columns.Add("NewConfirmedDate", typeof(string));
            data.Columns.Add("Amount", typeof(string));
            data.Columns.Add("SOTotalValue", typeof(string));
            data.Columns.Add("ApplyingTransaction", typeof(string));
            data.Columns.Add("WOStatus", typeof(string));
            data.Columns.Add("SalesRep", typeof(string));
            data.Columns.Add("Class", typeof(string));
            data.Columns.Add("Level3", typeof(string));
            data.Columns.Add("WOPlannedStartDate", typeof(string));
            data.Columns.Add("WOPlannedEndDate", typeof(string));
            data.Columns.Add("ReasonforReschedule", typeof(string));
            data.Columns.Add("RescheduleReasonCode", typeof(string));
            data.Columns.Add("WorkOrderNotes", typeof(string));
            data.Columns.Add("Region", typeof(string));
            data.Columns.Add("Terms", typeof(string));
            data.Columns.Add("CustomerDeposit", typeof(string));
            data.Columns.Add("Amount1", typeof(string));
            data.Columns.Add("LineID", typeof(string));
            data.Columns.Add("DateCreated", typeof(string));
            data.Columns.Add("CreditHold", typeof(string));
            data.Columns.Add("OverCredit", typeof(string));
            data.Columns.Add("AllowFulfilment", typeof(string));
            data.Columns.Add("ApprovalDate", typeof(string));
            data.Columns.Add("BlanketSalesOrder", typeof(string));
            data.AcceptChanges();

            DataRow dr = null;
            foreach (string st in stringarry)
            {
                if (!string.IsNullOrEmpty(st))
                {
                    string[] splitarray = st.Split('¢');

                    if (splitarray != null && splitarray.Length > 1)
                    {
                        dr = data.NewRow();
                        dr["Subsidiarynohierarchy"] = splitarray[0];
                        dr["DocumentNumber"] = splitarray[1];
                        dr["Item"] = splitarray[2];
                        dr["Id"] = splitarray[3];
                        dr["Name"] = splitarray[4];
                        dr["CustomerPartNumber"] = splitarray[5];
                        dr["CustomerPO"] = splitarray[6];
                        dr["Description"] = splitarray[7];
                        dr["Quantity"] = splitarray[8];
                        dr["QuantityCommitted"] = splitarray[9];
                        dr["QuantityShipped"] = splitarray[10];
                        dr["OpenQuantity"] = splitarray[11];
                        dr["DNSB"] = splitarray[12];
                        dr["Intercompany"] = splitarray[13];
                        dr["ShipComplete"] = splitarray[14];
                        dr["Date"] = splitarray[15];
                        dr["CustomerRequestDate"] = splitarray[16];
                        dr["ManufacturingLeadTimeDate"] = splitarray[17];
                        dr["ExpectedShipDate"] = splitarray[18];
                        dr["ConfirmDate"] = splitarray[19];
                        dr["NewConfirmedDate"] = splitarray[20];
                        dr["Amount"] = splitarray[21];
                        dr["SOTotalValue"] = splitarray[22];
                        dr["ApplyingTransaction"] = splitarray[23];
                        dr["WOStatus"] = splitarray[24];
                        dr["SalesRep"] = splitarray[25];
                        dr["Class"] = splitarray[26];
                        dr["Level3"] = splitarray[27];
                        dr["WOPlannedStartDate"] = splitarray[28];
                        dr["WOPlannedEndDate"] = splitarray[29];
                        dr["ReasonforReschedule"] = splitarray[30];
                        dr["RescheduleReasonCode"] = splitarray[31];
                        dr["WorkOrderNotes"] = splitarray[32];
                        dr["Region"] = splitarray[33];
                        dr["Terms"] = splitarray[34];
                        dr["CustomerDeposit"] = splitarray[35];
                        dr["Amount1"] = splitarray[36];
                        dr["LineID"] = splitarray[37];
                        dr["DateCreated"] = splitarray[38];
                        dr["CreditHold"] = splitarray[39];
                        dr["OverCredit"] = splitarray[40];
                        dr["AllowFulfilment"] = splitarray[41];
                        dr["ApprovalDate"] = splitarray[42];
                        dr["BlanketSalesOrder"] = splitarray[43];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
