using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class DashboardQualityDataRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("InternalID", typeof(string));
            data.Columns.Add("InspectionDateTime", typeof(string));
            data.Columns.Add("ItemInspectionItem", typeof(string));
            data.Columns.Add("ItemID", typeof(string));
            data.Columns.Add("ItemInternalId", typeof(string));
            data.Columns.Add("DashboardQualityDataResultInternalID", typeof(string));
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
                        dr["InspectionDateTime"] = splitarray[0];
                        dr["ItemInspectionItem"] = splitarray[0];
                        dr["ItemID"] = splitarray[0];
                        dr["ItemInternalId"] = splitarray[0];
                        dr["DashboardQualityDataResultInternalID"] = splitarray[0];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
