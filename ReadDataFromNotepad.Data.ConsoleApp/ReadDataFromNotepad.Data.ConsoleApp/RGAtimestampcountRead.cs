using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class RGAtimestampcountRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("Date", typeof(string));
            data.Columns.Add("Internal_ID", typeof(string));
            data.Columns.Add("Document_Number", typeof(string));
            data.Columns.Add("Line_ID", typeof(string));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Item_Internal_ID", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("RGA_Dispositions", typeof(string));
            data.Columns.Add("Closed", typeof(string));
            data.Columns.Add("Field", typeof(string));
            data.Columns.Add("Date1", typeof(string));
            data.Columns.Add("Old_Value", typeof(string));
            data.Columns.Add("New_Value", typeof(string)); 
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
                        dr["Internal_ID"] = splitarray[1];
                        dr["Document_Number"] = splitarray[2];
                        dr["Line_ID"] = splitarray[3];
                        dr["Name"] = splitarray[4];
                        dr["Item_Internal_ID"] = splitarray[5];
                        dr["Item"] = splitarray[6];
                        dr["RGA_Dispositions"] = splitarray[7];
                        dr["Closed"] = splitarray[8];
                        dr["Field"] = splitarray[9];
                        dr["Date1"] = splitarray[10];
                        dr["Old_Value"] = splitarray[11];
                        dr["New_Value"] = splitarray[12];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
