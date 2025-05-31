using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class PurchaseOrdersListRead
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
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Account", typeof(string));
            data.Columns.Add("Memo", typeof(string));
            data.Columns.Add("Amount", typeof(string));
            data.Columns.Add("PreferredEntityBank", typeof(string));
            data.Columns.Add("VendorBankFees", typeof(string));
            data.Columns.Add("BankFee", typeof(string));
            data.Columns.Add("BillcomSyncStatusListView", typeof(string));
            data.Columns.Add("Vendor", typeof(string));
            data.Columns.Add("ReceiveInspection", typeof(string));
            data.Columns.Add("ReceivedDummy", typeof(string));
            data.Columns.Add("Received_Dummy", typeof(string));
            data.Columns.Add("Subsidiary", typeof(string));
            data.Columns.Add("Location", typeof(string));
            data.Columns.Add("Source", typeof(string));
            data.Columns.Add("Buyer", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("Department", typeof(string));
            data.Columns.Add("ExchangeRateLine", typeof(string));
            data.Columns.Add("Currency", typeof(string));
            data.Columns.Add("QuantityOrdered", typeof(string));
            data.Columns.Add("DueDateReceiveBy", typeof(string));
            data.Columns.Add("VendorName", typeof(string));
            data.Columns.Add("VendorInternalID", typeof(string));
            data.Columns.Add("VendorExternalID", typeof(string));
            data.Columns.Add("QuantityReceived", typeof(string));
            data.Columns.Add("Status", typeof(string));
            data.Columns.Add("InternalID", typeof(string));
            data.Columns.Add("ExpectedReceiptDate", typeof(string));
            data.Columns.Add("Subsidiarynohierarchy", typeof(string));
            data.Columns.Add("MainLine", typeof(string));
            data.Columns.Add("LineId", typeof(string));
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
                        dr["Name"] = splitarray[7];
                        dr["Account"] = splitarray[8];
                        dr["Memo"] = splitarray[9];
                        dr["Amount"] = splitarray[10];
                        dr["PreferredEntityBank"] = splitarray[11];
                        dr["VendorBankFees"] = splitarray[12];
                        dr["BankFee"] = splitarray[13];
                        dr["BillcomSyncStatusListView"] = splitarray[14];
                        dr["Vendor"] = splitarray[15];
                        dr["ReceiveInspection"] = splitarray[16];
                        dr["ReceivedDummy"] = splitarray[17];
                        dr["Received_Dummy"] = splitarray[18];
                        dr["Subsidiary"] = splitarray[19];
                        dr["Location"] = splitarray[20];
                        dr["Source"] = splitarray[21];
                        dr["Buyer"] = splitarray[22];
                        dr["Item"] = splitarray[23];
                        dr["Department"] = splitarray[24];
                        dr["ExchangeRateLine"] = splitarray[25];
                        dr["Currency"] = splitarray[26];
                        dr["QuantityOrdered"] = splitarray[27];
                        dr["DueDateReceiveBy"] = splitarray[28];
                        dr["VendorName"] = splitarray[29];
                        dr["VendorInternalID"] = splitarray[30];
                        dr["VendorExternalID"] = splitarray[31];
                        dr["QuantityReceived"] = splitarray[32];
                        dr["Status"] = splitarray[33];
                        dr["InternalID"] = splitarray[34];
                        dr["ExpectedReceiptDate"] = splitarray[35];
                        dr["Subsidiarynohierarchy"] = splitarray[36];
                        dr["MainLine"] = splitarray[37];
                        dr["LineId"] = splitarray[38];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
