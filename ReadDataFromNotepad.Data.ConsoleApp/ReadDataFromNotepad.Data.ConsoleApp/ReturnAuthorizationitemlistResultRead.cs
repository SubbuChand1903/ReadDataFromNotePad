using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class ReturnAuthorizationitemlistResultRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("InternalId", typeof(string));
            data.Columns.Add("TranID", typeof(string));
            data.Columns.Add("Status", typeof(string));
            data.Columns.Add("CreatedDate", typeof(string));
            data.Columns.Add("TranDate", typeof(string));
            data.Columns.Add("ItemList_ReceivedDummy", typeof(string));
            data.Columns.Add("ItemList_IsClosed", typeof(string));
            data.Columns.Add("Entity_Name", typeof(string));
            data.Columns.Add("OtherRefNum", typeof(string));
            data.Columns.Add("ItemList_Item_InternalId", typeof(string));
            data.Columns.Add("ItemList_Item_Name", typeof(string));
            data.Columns.Add("ItemList_Description", typeof(string));
            data.Columns.Add("ItemList_SerialNumbers", typeof(string));
            data.Columns.Add("ItemList_Cost", typeof(string));
            data.Columns.Add("ItemList_Quantity", typeof(string));
            data.Columns.Add("ItemList_RGADispositions_InternalId", typeof(string));
            data.Columns.Add("ItemList_Notes", typeof(string));
            data.Columns.Add("ItemList_DispositionQty", typeof(string));
            data.Columns.Add("ItemList_RGADispositions", typeof(string));
            data.Columns.Add("ItemList_RGADispositionNotes", typeof(string));
            data.Columns.Add("ItemList_FromWorkOrder", typeof(string));
            data.Columns.Add("ItemList_FromWorkOrder_InternalId", typeof(string));
            data.Columns.Add("ItemList_ProductionDate", typeof(string));
            data.Columns.Add("ItemList_RespDept", typeof(string));
            data.Columns.Add("ItemList_ComponentDefective", typeof(string));
            data.Columns.Add("ItemList_DefectType", typeof(string));
            data.Columns.Add("ItemList_QualityDiagnosis", typeof(string));
            data.Columns.Add("ItemList_Vendor", typeof(string));
            data.Columns.Add("ItemList_VBDate", typeof(string));
            //data.Columns.Add("ItemList_Cost", typeof(string));       
            data.Columns.Add("ItemList_IncorrectDataRGAPostcloseoutadjust", typeof(string));
            data.Columns.Add("ShippingCost", typeof(string));
            data.Columns.Add("ShippingCost2", typeof(string));
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
                        dr["InternalId"] = splitarray[0];
                        dr["TranID"] = splitarray[1];
                        dr["Status"] = splitarray[2];
                        dr["CreatedDate"] = splitarray[3];
                        dr["TranDate"] = splitarray[4];
                        dr["ItemList_ReceivedDummy"] = splitarray[5];
                        dr["ItemList_IsClosed"] = splitarray[6];
                        dr["Entity_Name"] = splitarray[7];
                        dr["OtherRefNum"] = splitarray[8];
                        dr["ItemList_Item_InternalId"] = splitarray[9];
                        dr["ItemList_Item_Name"] = splitarray[10];
                        dr["ItemList_Description"] = splitarray[11];
                        dr["ItemList_SerialNumbers"] = splitarray[12];
                        dr["ItemList_Cost"] = splitarray[13];
                        dr["ItemList_Quantity"] = splitarray[14];
                        dr["ItemList_RGADispositions_InternalId"] = splitarray[15];
                        dr["ItemList_Notes"] = splitarray[16];
                        dr["ItemList_DispositionQty"] = splitarray[17];
                        dr["ItemList_RGADispositions"] = splitarray[18];
                        dr["ItemList_RGADispositionNotes"] = splitarray[19];
                        dr["ItemList_FromWorkOrder"] = splitarray[20];
                        dr["ItemList_FromWorkOrder_InternalId"] = splitarray[21];
                        dr["ItemList_ProductionDate"] = splitarray[22];
                        dr["ItemList_RespDept"] = splitarray[23];
                        dr["ItemList_ComponentDefective"] = splitarray[24];
                        dr["ItemList_DefectType"] = splitarray[25];
                        dr["ItemList_QualityDiagnosis"] = splitarray[26];
                        dr["ItemList_Vendor"] = splitarray[27];
                        dr["ItemList_VBDate"] = splitarray[28];
                        //dr["ItemList_Cost"] = splitarray[0];       
                        dr["ItemList_IncorrectDataRGAPostcloseoutadjust"] = splitarray[29];
                        dr["ShippingCost"] = splitarray[30];
                        dr["ShippingCost2"] = splitarray[31];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
