using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class ItemFulfillmentListRead
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
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("Subsidiary", typeof(string));
            data.Columns.Add("Subsidiarynohierarchy", typeof(string));
            data.Columns.Add("InternalID", typeof(string));
            data.Columns.Add("CreatedFromType", typeof(string));
            data.Columns.Add("CreatedFromDocumentNumber", typeof(string));
            data.Columns.Add("CreatedFromInternalID", typeof(string));
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
                        dr["Item"] = splitarray[11];
                        dr["Subsidiary"] = splitarray[12];
                        dr["Subsidiarynohierarchy"] = splitarray[13];
                        dr["InternalID"] = splitarray[14];
                        dr["CreatedFromType"] = splitarray[15];
                        dr["CreatedFromDocumentNumber"] = splitarray[16];
                        dr["CreatedFromInternalID"] = splitarray[17];
                        dr["MainLine"] = splitarray[18];
                        dr["LineId"] = splitarray[19];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
