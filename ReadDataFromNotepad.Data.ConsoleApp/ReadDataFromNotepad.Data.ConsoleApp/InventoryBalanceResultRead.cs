using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class InventoryBalanceResultRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("BinNumber", typeof(string));
            data.Columns.Add("Location", typeof(string));
            data.Columns.Add("InventoryNumber", typeof(string));
            data.Columns.Add("Status", typeof(string));
            data.Columns.Add("OnHand", typeof(string));
            data.Columns.Add("Available", typeof(string));
            data.Columns.Add("ItemType", typeof(string));
            data.Columns.Add("ItemInternalID", typeof(string));
            data.Columns.Add("LocationName", typeof(string));
            data.Columns.Add("LocationCity", typeof(string));
            data.Columns.Add("LocationCountry", typeof(string));
            data.Columns.Add("LocationStateProvince", typeof(string));
            data.Columns.Add("LocationInternalID", typeof(string));
            data.Columns.Add("LocationExternalID", typeof(string));
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
                        dr["Item"] = splitarray[0];
                        dr["BinNumber"] = splitarray[1];
                        dr["Location"] = splitarray[2];
                        dr["InventoryNumber"] = splitarray[3];
                        dr["Status"] = splitarray[4];
                        dr["OnHand"] = splitarray[5];
                        dr["Available"] = splitarray[6];
                        dr["ItemType"] = splitarray[7];
                        dr["ItemInternalID"] = splitarray[8];
                        dr["LocationName"] = splitarray[9];
                        dr["LocationCity"] = splitarray[10];
                        dr["LocationCountry"] = splitarray[11];
                        dr["LocationStateProvince"] = splitarray[12];
                        dr["LocationInternalID"] = splitarray[13];
                        dr["LocationExternalID"] = splitarray[14];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
