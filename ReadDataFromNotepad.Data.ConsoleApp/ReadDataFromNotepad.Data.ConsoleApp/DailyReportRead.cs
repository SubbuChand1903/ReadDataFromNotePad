using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class DailyReportRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("Date", typeof(string));
            data.Columns.Add("AccountNumber", typeof(string));
            data.Columns.Add("CompanyName", typeof(string));
            data.Columns.Add("Channel", typeof(string));
            data.Columns.Add("Region", typeof(string));
            data.Columns.Add("AddressShippingAddressCountryName", typeof(string));
            data.Columns.Add("SalesRep", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("ItemDescriptionSales", typeof(string));
            data.Columns.Add("Quantity", typeof(string));
            data.Columns.Add("Sales", typeof(string));
            data.Columns.Add("DocumentNumber", typeof(string));
            data.Columns.Add("CREATEDFROM", typeof(string));
            data.Columns.Add("PriceLevel", typeof(string));
            data.Columns.Add("LineID", typeof(string));
            DataRow dr = null;
            foreach (string st in stringarry)
            {
                if (!string.IsNullOrEmpty(st))
                {
                    string[] splitarray = st.Split('¢');

                    if (splitarray != null && splitarray.Length > 1)
                    {
                        dr = data.NewRow();
                        dr["Date"] = splitarray[0];
                        dr["AccountNumber"] = splitarray[1];
                        dr["CompanyName"] = splitarray[2];
                        dr["Channel"] = splitarray[3];
                        dr["Region"] = splitarray[4];
                        dr["AddressShippingAddressCountryName"] = splitarray[5];
                        dr["SalesRep"] = splitarray[6];
                        dr["Item"] = splitarray[7];
                        dr["ItemDescriptionSales"] = splitarray[8];
                        dr["Quantity"] = splitarray[9];
                        dr["Sales"] = splitarray[10];
                        dr["DocumentNumber"] = splitarray[11];
                        dr["CREATEDFROM"] = splitarray[12];
                        dr["PriceLevel"] = splitarray[13];
                        dr["LineID"] = splitarray[14];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
