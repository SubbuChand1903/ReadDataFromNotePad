using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class OTDReportResultRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("OrderType", typeof(string));
            data.Columns.Add("InvoiceDate", typeof(string));
            data.Columns.Add("AsOfDate", typeof(string));
            data.Columns.Add("Period", typeof(string));
            data.Columns.Add("TaxPeriod", typeof(string));
            data.Columns.Add("Type", typeof(string));
            data.Columns.Add("DocumentNumber", typeof(string));
            data.Columns.Add("LineID", typeof(string));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Account", typeof(string));
            data.Columns.Add("Memo", typeof(string));
            data.Columns.Add("InvoiceAmount", typeof(string));
            data.Columns.Add("PreferredEntityBank", typeof(string));
            data.Columns.Add("VendorBankFees", typeof(string));
            data.Columns.Add("BankFee", typeof(string));
            data.Columns.Add("BillcomSyncStatusListView", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("ItemDescription", typeof(string));
            data.Columns.Add("CustomerID", typeof(string));
            data.Columns.Add("CustomerName", typeof(string));
            data.Columns.Add("InvoiceQuantity", typeof(string));
            data.Columns.Add("Intercompany", typeof(string));
            data.Columns.Add("ExpectedShipDate", typeof(string));
            data.Columns.Add("CustomerRequestDate", typeof(string));
            data.Columns.Add("ConfirmDate", typeof(string));
            data.Columns.Add("NewConfirmedDate", typeof(string));
            data.Columns.Add("Amount", typeof(string));
            data.Columns.Add("OrderNumber", typeof(string));
            data.Columns.Add("OrderQuantity", typeof(string));
            data.Columns.Add("OrderAmount", typeof(string));
            data.Columns.Add("Region", typeof(string));
            data.Columns.Add("OrderDate", typeof(string));
            data.Columns.Add("OrderStatus", typeof(string));
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
                        dr["InvoiceDate"] = splitarray[1];
                        dr["AsOfDate"] = splitarray[2];
                        dr["Period"] = splitarray[3];
                        dr["TaxPeriod"] = splitarray[4];
                        dr["Type"] = splitarray[5];
                        dr["DocumentNumber"] = splitarray[6];
                        dr["LineID"] = splitarray[7];
                        dr["Name"] = splitarray[8];
                        dr["Account"] = splitarray[9];
                        dr["Memo"] = splitarray[10];
                        dr["InvoiceAmount"] = splitarray[11];
                        dr["PreferredEntityBank"] = splitarray[12];
                        dr["VendorBankFees"] = splitarray[13];
                        dr["BankFee"] = splitarray[14];
                        dr["BillcomSyncStatusListView"] = splitarray[15];
                        dr["Item"] = splitarray[16];
                        dr["ItemDescription"] = splitarray[17];
                        dr["CustomerID"] = splitarray[18];
                        dr["CustomerName"] = splitarray[19];
                        dr["InvoiceQuantity"] = splitarray[20];
                        dr["Intercompany"] = splitarray[21];
                        dr["ExpectedShipDate"] = splitarray[22];
                        dr["CustomerRequestDate"] = splitarray[23];
                        dr["ConfirmDate"] = splitarray[24];
                        dr["NewConfirmedDate"] = splitarray[25];
                        dr["Amount"] = splitarray[26];
                        dr["OrderNumber"] = splitarray[27];
                        dr["OrderQuantity"] = splitarray[28];
                        dr["OrderAmount"] = splitarray[29];
                        dr["Region"] = splitarray[30];
                        dr["OrderDate"] = splitarray[31];
                        dr["OrderStatus"] = splitarray[32];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
