using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class Pricetierreadclass
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("InternalID", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("QuantityRange", typeof(string));
            data.Columns.Add("SaleUnit", typeof(string));
            data.Columns.Add("Currency", typeof(string));
            data.Columns.Add("UnitPrice", typeof(string));
            data.Columns.Add("Id", typeof(string));
            data.Columns.Add("MaximumQuantity", typeof(string));
            data.Columns.Add("MinimumQuantity", typeof(string));
            data.Columns.Add("PriceLevel", typeof(string));
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
                        dr["InternalID"] = splitarray[0];
                        dr["Item"] = splitarray[1];
                        dr["QuantityRange"] = splitarray[2];
                        dr["SaleUnit"] = splitarray[3];
                        dr["Currency"] = splitarray[4];
                        dr["UnitPrice"] = splitarray[5];
                        dr["Id"] = splitarray[6];
                        dr["MaximumQuantity"] = splitarray[7];
                        dr["MinimumQuantity"] = splitarray[8];
                        dr["PriceLevel"] = splitarray[9];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}


