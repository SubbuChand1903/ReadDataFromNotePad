using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class ItemReceiptsListResultRead
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
            data.Columns.Add("Vendor", typeof(string));
            data.Columns.Add("Account", typeof(string));
            data.Columns.Add("Memo", typeof(string));
            data.Columns.Add("Amount", typeof(string));
            data.Columns.Add("PreferredEntityBank", typeof(string));
            data.Columns.Add("VendorBankFees", typeof(string));
            data.Columns.Add("BankFee", typeof(string));
            data.Columns.Add("BillcomSyncStatusListView", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("AbsoluteValueofQuantity", typeof(string));
            data.Columns.Add("CreatedFromNumber", typeof(string));
            data.Columns.Add("CreatedFromType", typeof(string));
            data.Columns.Add("MainLine", typeof(string));
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
                        dr["Vendor"] = splitarray[7];
                        dr["Account"] = splitarray[8];
                        dr["Memo"] = splitarray[9];
                        dr["Amount"] = splitarray[10];
                        dr["PreferredEntityBank"] = splitarray[11];
                        dr["VendorBankFees"] = splitarray[12];
                        dr["BankFee"] = splitarray[13];
                        dr["BillcomSyncStatusListView"] = splitarray[14];
                        dr["Item"] = splitarray[15];
                        dr["AbsoluteValueofQuantity"] = splitarray[16];
                        dr["CreatedFromNumber"] = splitarray[17];
                        dr["CreatedFromType"] = splitarray[18];
                        dr["MainLine"] = splitarray[19];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
