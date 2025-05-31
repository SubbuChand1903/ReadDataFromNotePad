using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class MOListResultRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("ActualRunTime", typeof(string));
            data.Columns.Add("ActualSetupTime", typeof(string));
            data.Columns.Add("CompletedQuantity", typeof(string));
            data.Columns.Add("Dispatched", typeof(string));
            data.Columns.Add("EndDate", typeof(string));
            data.Columns.Add("EndDateTime", typeof(string));
            data.Columns.Add("EstimatedWork", typeof(string));
            data.Columns.Add("ExternalID", typeof(string));
            data.Columns.Add("ID", typeof(string));
            data.Columns.Add("InputQuantity", typeof(string));
            data.Columns.Add("InternalID", typeof(string));
            data.Columns.Add("LaborResources", typeof(string));
            data.Columns.Add("LagAmount", typeof(string));
            data.Columns.Add("LagType", typeof(string));
            data.Columns.Add("LagUnits", typeof(string));
            data.Columns.Add("MachineResources", typeof(string));
            data.Columns.Add("ManufacturingCostTemplate", typeof(string));
            data.Columns.Add("ManufacturingWorkCenter", typeof(string));
            data.Columns.Add("Notes", typeof(string));
            data.Columns.Add("OperationName", typeof(string));
            data.Columns.Add("OperationSequence", typeof(string));
            data.Columns.Add("Order", typeof(string));
            data.Columns.Add("Predecessor", typeof(string));
            data.Columns.Add("PredecessorType", typeof(string));
            data.Columns.Add("RemainingQuantity", typeof(string));
            data.Columns.Add("RunRate", typeof(string));
            data.Columns.Add("RunTime", typeof(string));
            data.Columns.Add("SetupTime", typeof(string));
            data.Columns.Add("StartDate", typeof(string));
            data.Columns.Add("StartDateTime", typeof(string));
            data.Columns.Add("Status", typeof(string));
            data.Columns.Add("WorkOrder", typeof(string));
            data.Columns.Add("WorkOrderNumber", typeof(string));
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
                        dr["ActualRunTime"] = splitarray[0];
                        dr["ActualSetupTime"] = splitarray[1];
                        dr["CompletedQuantity"] = splitarray[2];
                        dr["Dispatched"] = splitarray[3];
                        dr["EndDate"] = splitarray[4];
                        dr["EndDateTime"] = splitarray[5];
                        dr["EstimatedWork"] = splitarray[6];
                        dr["ExternalID"] = splitarray[7];
                        dr["ID"] = splitarray[8];
                        dr["InputQuantity"] = splitarray[9];
                        dr["InternalID"] = splitarray[10];
                        dr["LaborResources"] = splitarray[11];
                        dr["LagAmount"] = splitarray[12];
                        dr["LagType"] = splitarray[13];
                        dr["LagUnits"] = splitarray[14];
                        dr["MachineResources"] = splitarray[15];
                        dr["ManufacturingCostTemplate"] = splitarray[16];
                        dr["ManufacturingWorkCenter"] = splitarray[17];
                        dr["Notes"] = splitarray[18];
                        dr["OperationName"] = splitarray[19];
                        dr["OperationSequence"] = splitarray[20];
                        dr["Order"] = splitarray[21];
                        dr["Predecessor"] = splitarray[22];
                        dr["PredecessorType"] = splitarray[23];
                        dr["RemainingQuantity"] = splitarray[24];
                        dr["RunRate"] = splitarray[25];
                        dr["RunTime"] = splitarray[26];
                        dr["SetupTime"] = splitarray[27];
                        dr["StartDate"] = splitarray[28];
                        dr["StartDateTime"] = splitarray[29];
                        dr["Status"] = splitarray[30];
                        dr["WorkOrder"] = splitarray[31];
                        dr["WorkOrderNumber"] = splitarray[32];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
