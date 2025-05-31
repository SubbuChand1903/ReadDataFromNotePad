using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class ProductivityReportResultRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("OrderType", typeof(string));
            data.Columns.Add("Date", typeof(string));
            data.Columns.Add("AsOfDate", typeof(string));
            data.Columns.Add("Period", typeof(string));
            data.Columns.Add("TaxPeriod", typeof(string));
            data.Columns.Add("Type", typeof(string));
            data.Columns.Add("DocumentNumber", typeof(string));
            data.Columns.Add("CreatedFrom", typeof(string));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Memo", typeof(string));
            data.Columns.Add("Amount", typeof(string));
            data.Columns.Add("PreferredEntityBank", typeof(string));
            data.Columns.Add("VendorBankFees", typeof(string));
            data.Columns.Add("BankFee", typeof(string));
            data.Columns.Add("BillComSyncStatusListView", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("Status", typeof(string));
            data.Columns.Add("MOStartDate", typeof(string));
            data.Columns.Add("MOWorkOrder", typeof(string));
            data.Columns.Add("MOStatus", typeof(string));
            data.Columns.Add("MOStartDateTime", typeof(string));
            data.Columns.Add("MOSetupTimeMin", typeof(string));
            data.Columns.Add("MORunTime", typeof(string));
            data.Columns.Add("MOOperationSequence", typeof(string));
            data.Columns.Add("MOOperationName", typeof(string));
            data.Columns.Add("MOOrder", typeof(string));
            data.Columns.Add("MOManufacturingWorkCenter", typeof(string));
            data.Columns.Add("MOEndDate", typeof(string));
            data.Columns.Add("MOEndDateTime", typeof(string));
            data.Columns.Add("MOActualRunTime", typeof(string));
            data.Columns.Add("MOActualSetupTime", typeof(string));
            data.Columns.Add("MOCompletedQuantity", typeof(string));
            data.Columns.Add("MOID", typeof(string));
            data.Columns.Add("MOExternalID", typeof(string));
            data.Columns.Add("MORunRateMinUnit", typeof(string));
            data.Columns.Add("ItemMakeBuy", typeof(string));
            data.Columns.Add("PlannedStartDate", typeof(string));
            data.Columns.Add("PlannedEndDate", typeof(string));
            data.Columns.Add("Quantity", typeof(string));
            data.Columns.Add("AppliedtoAmount", typeof(string));
            data.Columns.Add("AppliedtoDocumentNumber", typeof(string));
            data.Columns.Add("AppliedtoType", typeof(string));
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
                        dr["OrderType"] = splitarray[0];
                        dr["Date"] = splitarray[1];
                        dr["AsOfDate"] = splitarray[2];
                        dr["Period"] = splitarray[3];
                        dr["TaxPeriod"] = splitarray[4];
                        dr["Type"] = splitarray[5];
                        dr["DocumentNumber"] = splitarray[6];
                        dr["CreatedFrom"] = splitarray[7];
                        dr["Name"] = splitarray[8];
                        dr["Memo"] = splitarray[9];
                        dr["Amount"] = splitarray[10];
                        dr["PreferredEntityBank"] = splitarray[11];
                        dr["VendorBankFees"] = splitarray[12];
                        dr["BankFee"] = splitarray[13];
                        dr["BillComSyncStatusListView"] = splitarray[14];
                        dr["Item"] = splitarray[15];
                        dr["Status"] = splitarray[16];
                        dr["MOStartDate"] = splitarray[17];
                        dr["MOWorkOrder"] = splitarray[18];
                        dr["MOStatus"] = splitarray[19];
                        dr["MOStartDateTime"] = splitarray[20];
                        dr["MOSetupTimeMin"] = splitarray[21];
                        dr["MORunTime"] = splitarray[22];
                        dr["MOOperationSequence"] = splitarray[23];
                        dr["MOOperationName"] = splitarray[24];
                        dr["MOOrder"] = splitarray[25];
                        dr["MOManufacturingWorkCenter"] = splitarray[26];
                        dr["MOEndDate"] = splitarray[27];
                        dr["MOEndDateTime"] = splitarray[28];
                        dr["MOActualRunTime"] = splitarray[29];
                        dr["MOActualSetupTime"] = splitarray[30];
                        dr["MOCompletedQuantity"] = splitarray[31];
                        dr["MOID"] = splitarray[32];
                        dr["MOExternalID"] = splitarray[33];
                        dr["MORunRateMinUnit"] = splitarray[34];
                        dr["ItemMakeBuy"] = splitarray[35];
                        dr["PlannedStartDate"] = splitarray[36];
                        dr["PlannedEndDate"] = splitarray[37];
                        dr["Quantity"] = splitarray[38];
                        dr["AppliedtoAmount"] = splitarray[39];
                        dr["AppliedtoDocumentNumber"] = splitarray[40];
                        dr["AppliedtoType"] = splitarray[41]; 
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
