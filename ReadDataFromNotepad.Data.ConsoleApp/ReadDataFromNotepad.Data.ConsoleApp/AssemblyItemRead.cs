using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class AssemblyItemRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("ItemInternalId", typeof(string));
            data.Columns.Add("ClassLevel", typeof(string));
            data.Columns.Add("ClassName", typeof(string));
            data.Columns.Add("ItemDescription", typeof(string));
            data.Columns.Add("Item", typeof(string));
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
                        dr["ItemInternalId"] = splitarray[0];
                        dr["ClassLevel"] = splitarray[1];
                        dr["ClassName"] = splitarray[2];
                        dr["ItemDescription"] = splitarray[3];
                        dr["Item"] = splitarray[4];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
