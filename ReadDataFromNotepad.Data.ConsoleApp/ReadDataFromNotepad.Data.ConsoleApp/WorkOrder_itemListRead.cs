using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class WorkOrder_itemListRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("WorkOrder_InternalID", typeof(string));
            data.Columns.Add("WorkOrder", typeof(string));
            data.Columns.Add("WorkOrderItem", typeof(string));
            data.Columns.Add("WorkOrderItem_InternalID", typeof(string));
            data.Columns.Add("WorkOrderItem_Quantity", typeof(string));
            data.Columns.Add("CreatedFromType", typeof(string));
            data.Columns.Add("SalesOrder", typeof(string));
            data.Columns.Add("SalesOrder_InternalID", typeof(string));
            data.Columns.Add("ProductionStartDate", typeof(string));
            data.Columns.Add("ProductionEndDate", typeof(string));
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
                        dr["WorkOrder_InternalID"] = splitarray[0];
                        dr["WorkOrder"] = splitarray[1];
                        dr["WorkOrderItem"] = splitarray[2];
                        dr["WorkOrderItem_InternalID"] = splitarray[3];
                        dr["WorkOrderItem_Quantity"] = splitarray[4];
                        dr["CreatedFromType"] = splitarray[5];
                        dr["SalesOrder"] = splitarray[6];
                        dr["SalesOrder_InternalID"] = splitarray[7];
                        dr["ProductionStartDate"] = splitarray[8];
                        dr["ProductionEndDate"] = splitarray[9];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
