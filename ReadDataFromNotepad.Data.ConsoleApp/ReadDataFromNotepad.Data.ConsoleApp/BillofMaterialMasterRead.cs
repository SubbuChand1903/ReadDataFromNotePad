using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class BillofMaterialMasterRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("BillofMaterials", typeof(string));
            data.Columns.Add("DateCreated", typeof(string));
            data.Columns.Add("EffectiveEndDate", typeof(string));
            data.Columns.Add("EffectiveStartDate", typeof(string));
            data.Columns.Add("ExternalID", typeof(string));
            data.Columns.Add("Inactive", typeof(string));
            data.Columns.Add("InternalID", typeof(string));
            data.Columns.Add("Memo", typeof(string));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("ComponentBaseUnits", typeof(string));
            data.Columns.Add("ComponentBoMQuantity", typeof(string));
            data.Columns.Add("ComponentBoMQuantityinBaseUnits", typeof(string));
            data.Columns.Add("ComponentComponentYield", typeof(string));
            data.Columns.Add("ComponentDescription", typeof(string));
            data.Columns.Add("ComponentInternalID", typeof(string));
            data.Columns.Add("ComponentItem", typeof(string));
            data.Columns.Add("ComponentItemSource", typeof(string));
            data.Columns.Add("ComponentItemSubtype", typeof(string));
            data.Columns.Add("ComponentItemType", typeof(string));
            data.Columns.Add("ComponentLineID", typeof(string));
            data.Columns.Add("ComponentQuantity", typeof(string));
            data.Columns.Add("ComponentQuantityInBaseUnits", typeof(string));
            data.Columns.Add("ComponentRevisionName", typeof(string));
            data.Columns.Add("ComponentRoutingText", typeof(string));
            data.Columns.Add("ComponentUnits", typeof(string));
            data.Columns.Add("ComponentWeight", typeof(string));
            data.Columns.Add("ComponentWorkInstructions", typeof(string));
            data.Columns.Add("BillofMaterialsInternalID", typeof(string));
            data.Columns.Add("BillofMaterialsExternalID", typeof(string));
            data.Columns.Add("BillofMaterialsName", typeof(string));
            data.Columns.Add("BillofMaterialsSubsidiary", typeof(string));
            data.Columns.Add("BillofMaterialsSubsidiaryNoHierarchy	", typeof(string));
            data.Columns.Add("BillofMaterialsUsedonAssembly", typeof(string));
            data.Columns.Add("BillofMaterialsUseComponentYield", typeof(string));
            data.Columns.Add("BillofMaterialsRestrictToLocations", typeof(string));
            data.Columns.Add("BillofMaterialsRestrictToAssemblies", typeof(string));
            data.Columns.Add("BillofMaterialsMemo", typeof(string));
            data.Columns.Add("BillofMaterialsLegacyBoMForAssembly", typeof(string));
            data.Columns.Add("BillofMaterialsInactive", typeof(string));
            data.Columns.Add("BillofMaterialsDateCreated", typeof(string));
            data.Columns.Add("BillofMaterialsAvailableForAllAssemblies", typeof(string));
            data.Columns.Add("BillofMaterialsAvailableForAllLocations", typeof(string));
            data.Columns.Add("BillofMaterialsIncludeChildren", typeof(string));
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
                        dr["RecordType"] = splitarray[0];
                        dr["Id"] = splitarray[1];
                        dr["BillofMaterials"] = splitarray[2];
                        dr["DateCreated"] = splitarray[3];
                        dr["EffectiveEndDate"] = splitarray[4];
                        dr["EffectiveStartDate"] = splitarray[5];
                        dr["ExternalID"] = splitarray[6];
                        dr["Inactive"] = splitarray[7];
                        dr["InternalID"] = splitarray[8];
                        dr["Memo"] = splitarray[9];
                        dr["Name"] = splitarray[10];
                        dr["ComponentBaseUnits"] = splitarray[11];
                        dr["ComponentBoMQuantity"] = splitarray[12];
                        dr["ComponentBoMQuantityinBaseUnits"] = splitarray[13];
                        dr["ComponentComponentYield"] = splitarray[14];
                        dr["ComponentDescription"] = splitarray[15];
                        dr["ComponentInternalID"] = splitarray[16];
                        dr["ComponentItem"] = splitarray[17];
                        dr["ComponentItemSource"] = splitarray[18];
                        dr["ComponentItemSubtype"] = splitarray[19];
                        dr["ComponentItemType"] = splitarray[20];
                        dr["ComponentLineID"] = splitarray[21];
                        dr["ComponentQuantity"] = splitarray[22];
                        dr["ComponentQuantityInBaseUnits"] = splitarray[23];
                        dr["ComponentRevisionName"] = splitarray[24];
                        dr["ComponentRoutingText"] = splitarray[25];
                        dr["ComponentUnits"] = splitarray[26];
                        dr["ComponentWeight"] = splitarray[27];
                        dr["ComponentWorkInstructions"] = splitarray[28];
                        dr["BillofMaterialsInternalID"] = splitarray[29];
                        dr["BillofMaterialsExternalID"] = splitarray[30];
                        dr["BillofMaterialsName"] = splitarray[31];
                        dr["BillofMaterialsSubsidiary"] = splitarray[32];
                        dr["BillofMaterialsSubsidiaryNoHierarchy"] = splitarray[33];
                        dr["BillofMaterialsUsedonAssembly"] = splitarray[34];
                        dr["BillofMaterialsUseComponentYield"] = splitarray[35];
                        dr["BillofMaterialsRestrictToLocations"] = splitarray[36];
                        dr["BillofMaterialsRestrictToAssemblies"] = splitarray[37];
                        dr["BillofMaterialsMemo"] = splitarray[38];
                        dr["BillofMaterialsLegacyBoMForAssembly"] = splitarray[39];
                        dr["BillofMaterialsInactive"] = splitarray[40];
                        dr["BillofMaterialsDateCreated"] = splitarray[41];
                        dr["BillofMaterialsAvailableForAllAssemblies"] = splitarray[42];
                        dr["BillofMaterialsAvailableForAllLocations"] = splitarray[43];
                        dr["BillofMaterialsIncludeChildren"] = splitarray[44];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
