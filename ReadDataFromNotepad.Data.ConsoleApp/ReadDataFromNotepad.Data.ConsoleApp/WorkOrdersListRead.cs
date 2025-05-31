using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class WorkOrdersListRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("Date", typeof(string));
            data.Columns.Add("DocumentNumber", typeof(string));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Status", typeof(string));
            data.Columns.Add("Memo", typeof(string));
            data.Columns.Add("Amount", typeof(string));
            data.Columns.Add("ManufacturingRouting", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("CreatedForm", typeof(string));
            data.Columns.Add("CreateFromDocumentNumber", typeof(string));
            data.Columns.Add("ConfirmDate", typeof(string));
            data.Columns.Add("SchedulingMethod", typeof(string));
            data.Columns.Add("Quantity", typeof(string));
            data.Columns.Add("QuantityBilled", typeof(string));
            data.Columns.Add("QuantityCommitted", typeof(string));
            data.Columns.Add("QuantityFailed", typeof(string));
            data.Columns.Add("QuantityFulfilledReceived", typeof(string));
            data.Columns.Add("QuantityPacked", typeof(string));
            data.Columns.Add("QuantityPicked", typeof(string));
            data.Columns.Add("QuantityinTransactionUnits", typeof(string));
            data.Columns.Add("QuantityonShipments", typeof(string));
            data.Columns.Add("Subsidiary", typeof(string));
            data.Columns.Add("Department", typeof(string));
            data.Columns.Add("Class", typeof(string));
            data.Columns.Add("Location", typeof(string));
            data.Columns.Add("NewConfirmedDate", typeof(string));
            data.Columns.Add("ExpectedShipDate", typeof(string));
            data.Columns.Add("ActualProductionEndDate", typeof(string));
            data.Columns.Add("ActualProductionStartDate", typeof(string));
            data.Columns.Add("DNSB", typeof(string));
            data.Columns.Add("InternalID", typeof(string));
            data.Columns.Add("WIP", typeof(string));
            data.Columns.Add("SubsidiaryNoHierarchy", typeof(string));
            data.Columns.Add("MainLine", typeof(string));
            data.Columns.Add("LineId", typeof(string));
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
                        dr["DocumentNumber"] = splitarray[1];
                        dr["Name"] = splitarray[2];
                        dr["Status"] = splitarray[3];
                        dr["Memo"] = splitarray[4];
                        dr["Amount"] = splitarray[5];
                        dr["ManufacturingRouting"] = splitarray[6];
                        dr["Item"] = splitarray[7];
                        dr["CreatedForm"] = splitarray[8];
                        dr["CreateFromDocumentNumber"] = splitarray[9];
                        dr["ConfirmDate"] = splitarray[10];
                        dr["SchedulingMethod"] = splitarray[11];
                        dr["Quantity"] = splitarray[12];
                        dr["QuantityBilled"] = splitarray[13];
                        dr["QuantityCommitted"] = splitarray[14];
                        dr["QuantityFailed"] = splitarray[15];
                        dr["QuantityFulfilledReceived"] = splitarray[16];
                        dr["QuantityPacked"] = splitarray[17];
                        dr["QuantityPicked"] = splitarray[18];
                        dr["QuantityinTransactionUnits"] = splitarray[19];
                        dr["QuantityonShipments"] = splitarray[20];
                        dr["Subsidiary"] = splitarray[21];
                        dr["Department"] = splitarray[22];
                        dr["Class"] = splitarray[23];
                        dr["Location"] = splitarray[24];
                        dr["NewConfirmedDate"] = splitarray[25];
                        dr["ExpectedShipDate"] = splitarray[26];
                        dr["ActualProductionEndDate"] = splitarray[27];
                        dr["ActualProductionStartDate"] = splitarray[28];
                        dr["DNSB"] = splitarray[29];
                        dr["InternalID"] = splitarray[30];
                        dr["WIP"] = splitarray[31];
                        dr["SubsidiaryNoHierarchy"] = splitarray[32];
                        dr["MainLine"] = splitarray[33];
                        dr["LineId"] = splitarray[34];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
