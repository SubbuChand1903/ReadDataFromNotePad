using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class SalesOrderReviewRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("Subsidiarynohierarchy", typeof(string));
            data.Columns.Add("Date", typeof(string));
            data.Columns.Add("Type", typeof(string));
            data.Columns.Add("DocumentNumber", typeof(string));
            data.Columns.Add("Account", typeof(string));
            data.Columns.Add("CompanyName", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("Description", typeof(string));
            data.Columns.Add("Amount", typeof(string));
            data.Columns.Add("Quantity", typeof(string));
            data.Columns.Add("Status", typeof(string));
            data.Columns.Add("SalesRep", typeof(string));
            data.Columns.Add("Region", typeof(string));
            data.Columns.Add("Channel", typeof(string));
            data.Columns.Add("BlanketSalesOrder", typeof(string));
            data.Columns.Add("LineID", typeof(string));
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
                        dr["Date"] = splitarray[1];
                        dr["Type"] = splitarray[2];
                        dr["DocumentNumber"] = splitarray[3];
                        dr["Account"] = splitarray[4];
                        dr["CompanyName"] = splitarray[5];
                        dr["Item"] = splitarray[6];
                        dr["Description"] = splitarray[7];
                        dr["Amount"] = splitarray[8];
                        dr["Quantity"] = splitarray[9];
                        dr["Status"] = splitarray[10];
                        dr["SalesRep"] = splitarray[11];
                        dr["Region"] = splitarray[12];
                        dr["Channel"] = splitarray[13];
                        dr["BlanketSalesOrder"] = splitarray[14];
                        dr["LineID"] = splitarray[15];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
