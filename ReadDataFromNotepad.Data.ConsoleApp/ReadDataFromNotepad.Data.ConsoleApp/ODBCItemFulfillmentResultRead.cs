using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class ODBCItemFulfillmentResultRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("Date", typeof(string));
            data.Columns.Add("Period", typeof(string));
            data.Columns.Add("Type", typeof(string));
            data.Columns.Add("DocumentNumber", typeof(string));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("ItemInternalId", typeof(string));
            data.Columns.Add("Memo", typeof(string));
            data.Columns.Add("Amount", typeof(string));
            data.Columns.Add("Quantity", typeof(string));
            data.Columns.Add("CreatedFrom", typeof(string));
            data.Columns.Add("SoType", typeof(string));
            data.Columns.Add("BookingInternalId", typeof(string));
            data.Columns.Add("PoCheckNumber", typeof(string));
            data.Columns.Add("CreatedFromRma", typeof(string));
            data.Columns.Add("FulfillmentInternalID", typeof(string));
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
                        dr["Date"] = splitarray[0];
                        dr["Period"] = splitarray[1];
                        dr["Type"] = splitarray[2];
                        dr["DocumentNumber"] = splitarray[3];
                        dr["Name"] = splitarray[4];
                        dr["Item"] = splitarray[5];
                        dr["ItemInternalId"] = splitarray[6];
                        dr["Memo"] = splitarray[7];
                        dr["Amount"] = splitarray[8];
                        dr["Quantity"] = splitarray[9];
                        dr["CreatedFrom"] = splitarray[10];
                        dr["SoType"] = splitarray[11];
                        dr["BookingInternalId"] = splitarray[12];
                        dr["PoCheckNumber"] = splitarray[13];
                        dr["CreatedFromRma"] = splitarray[14];
                        dr["FulfillmentInternalID"] = splitarray[15];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
