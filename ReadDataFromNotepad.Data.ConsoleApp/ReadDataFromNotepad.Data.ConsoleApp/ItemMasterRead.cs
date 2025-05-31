using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class ItemMasterRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("DisplayName", typeof(string));
            data.Columns.Add("Description", typeof(string));
            data.Columns.Add("Type", typeof(string));
            data.Columns.Add("BasePrice", typeof(string));
            data.Columns.Add("Planner", typeof(string));
            data.Columns.Add("EngineeringComplete", typeof(string));
            data.Columns.Add("SalesComplete", typeof(string));
            data.Columns.Add("EngineeringCompletedBy", typeof(string));
            data.Columns.Add("SalesAssigned", typeof(string));
            data.Columns.Add("FinanceAssigned", typeof(string));
            data.Columns.Add("Class", typeof(string));
            data.Columns.Add("ClassNoHierarchy", typeof(string));
            data.Columns.Add("ClassLevel3", typeof(string));
            data.Columns.Add("AutoReorderPoint", typeof(string));
            data.Columns.Add("CurrentStandardCost", typeof(string));
            data.Columns.Add("Inactive", typeof(string));
            data.Columns.Add("InternalID", typeof(string));
            data.Columns.Add("CurrentStandardCostEffectiveDate", typeof(string));
            data.Columns.Add("DateCreated", typeof(string));
            data.Columns.Add("Department", typeof(string));
            data.Columns.Add("DepartmentNoHierarchy", typeof(string));
            data.Columns.Add("DisplayName1", typeof(string));
            data.Columns.Add("ExternalID", typeof(string));
            data.Columns.Add("FinishedProduct", typeof(string));
            data.Columns.Add("ItemHeight", typeof(string));
            data.Columns.Add("ItemWidth", typeof(string));
            data.Columns.Add("LastCountDate", typeof(string));
            data.Columns.Add("LastPurchasePrice", typeof(string));
            data.Columns.Add("Level3", typeof(string));
            data.Columns.Add("Level3Class", typeof(string));
            data.Columns.Add("MPN", typeof(string));
            data.Columns.Add("MakeBuy", typeof(string));
            data.Columns.Add("Manufacturer", typeof(string));
            data.Columns.Add("ManufacturerCountry", typeof(string));
            data.Columns.Add("CountryofOrigin", typeof(string));
            data.Columns.Add("MatrixItem", typeof(string));
            data.Columns.Add("NextCountDate", typeof(string));
            data.Columns.Add("ObsoleteDate", typeof(string));
            data.Columns.Add("OnHand", typeof(string));
            data.Columns.Add("OnOrder", typeof(string));
            data.Columns.Add("OnSpecial", typeof(string));
            data.Columns.Add("OnlineCustomerPrice", typeof(string));
            data.Columns.Add("OnlinePrice", typeof(string));
            data.Columns.Add("Planner1", typeof(string));
            data.Columns.Add("PurchasePrice", typeof(string));
            data.Columns.Add("PurchaseDescription", typeof(string));
            data.Columns.Add("PurchaseLeadTime", typeof(string));
            data.Columns.Add("Purchased", typeof(string));
            data.Columns.Add("ReceivingInspection", typeof(string));
            data.Columns.Add("ReorderPoint", typeof(string));
            data.Columns.Add("ReorderMultiple", typeof(string));
            data.Columns.Add("SafetyStockLevel", typeof(string));
            data.Columns.Add("SafetyStockDays", typeof(string));
            data.Columns.Add("ShipsIndividually", typeof(string));
            data.Columns.Add("ShippingPackage", typeof(string));
            data.Columns.Add("SpecialOrderItem", typeof(string));
            data.Columns.Add("SpecialWorkOrderItem", typeof(string));
            data.Columns.Add("Subsidiary", typeof(string));
            data.Columns.Add("SubsidiaryNoHierarchy", typeof(string));
            data.Columns.Add("TotalQuantityOnHand", typeof(string));
            data.Columns.Add("TransferPrice", typeof(string));
            data.Columns.Add("UPCCode", typeof(string));
            data.Columns.Add("Vendor", typeof(string));
            data.Columns.Add("VendorName", typeof(string));
            data.Columns.Add("VendorCode", typeof(string));
            data.Columns.Add("VendorPrice", typeof(string));
            data.Columns.Add("VendorPriceEntered", typeof(string));
            data.Columns.Add("Weight", typeof(string));
            data.Columns.Add("AverageCost", typeof(string));
            data.Columns.Add("Parent", typeof(string));
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
                        dr["Name"] = splitarray[0];
                        dr["DisplayName"] = splitarray[1];
                        dr["Description"] = splitarray[2];
                        dr["Type"] = splitarray[3];
                        dr["BasePrice"] = splitarray[4];
                        dr["Planner"] = splitarray[5];
                        dr["EngineeringComplete"] = splitarray[6];
                        dr["SalesComplete"] = splitarray[7];
                        dr["EngineeringCompletedBy"] = splitarray[8];
                        dr["SalesAssigned"] = splitarray[9];
                        dr["FinanceAssigned"] = splitarray[10];
                        dr["Class"] = splitarray[11];
                        dr["ClassNoHierarchy"] = splitarray[12];
                        dr["ClassLevel3"] = splitarray[13];
                        dr["AutoReorderPoint"] = splitarray[14];
                        dr["CurrentStandardCost"] = splitarray[15];
                        dr["Inactive"] = splitarray[16];
                        dr["InternalID"] = splitarray[17];
                        dr["CurrentStandardCostEffectiveDate"] = splitarray[18];
                        dr["DateCreated"] = splitarray[19];
                        dr["Department"] = splitarray[20];
                        dr["DepartmentNoHierarchy"] = splitarray[21];
                        dr["DisplayName1"] = splitarray[22];
                        dr["ExternalID"] = splitarray[23];
                        dr["FinishedProduct"] = splitarray[24];
                        dr["ItemHeight"] = splitarray[25];
                        dr["ItemWidth"] = splitarray[26];
                        dr["LastCountDate"] = splitarray[27];
                        dr["LastPurchasePrice"] = splitarray[28];
                        dr["Level3"] = splitarray[29];
                        dr["Level3Class"] = splitarray[30];
                        dr["MPN"] = splitarray[31];
                        dr["MakeBuy"] = splitarray[32];
                        dr["Manufacturer"] = splitarray[33];
                        dr["ManufacturerCountry"] = splitarray[34];
                        dr["CountryofOrigin"] = splitarray[35];
                        dr["MatrixItem"] = splitarray[36];
                        dr["NextCountDate"] = splitarray[37];
                        dr["ObsoleteDate"] = splitarray[38];
                        dr["OnHand"] = splitarray[39];
                        dr["OnOrder"] = splitarray[40];
                        dr["OnSpecial"] = splitarray[41];
                        dr["OnlineCustomerPrice"] = splitarray[42];
                        dr["OnlinePrice"] = splitarray[43];
                        dr["Planner1"] = splitarray[44];
                        dr["PurchasePrice"] = splitarray[45];
                        dr["PurchaseDescription"] = splitarray[46];
                        dr["PurchaseLeadTime"] = splitarray[47];
                        dr["Purchased"] = splitarray[48];
                        dr["ReceivingInspection"] = splitarray[49];
                        dr["ReorderPoint"] = splitarray[50];
                        dr["ReorderMultiple"] = splitarray[51];
                        dr["SafetyStockLevel"] = splitarray[52];
                        dr["SafetyStockDays"] = splitarray[53];
                        dr["ShipsIndividually"] = splitarray[54];
                        dr["ShippingPackage"] = splitarray[55];
                        dr["SpecialOrderItem"] = splitarray[56];
                        dr["SpecialWorkOrderItem"] = splitarray[57];
                        dr["Subsidiary"] = splitarray[58];
                        dr["SubsidiaryNoHierarchy"] = splitarray[59];
                        dr["TotalQuantityOnHand"] = splitarray[60];
                        dr["TransferPrice"] = splitarray[61];
                        dr["UPCCode"] = splitarray[62];
                        dr["Vendor"] = splitarray[63];
                        dr["VendorName"] = splitarray[64];
                        dr["VendorCode"] = splitarray[65];
                        dr["VendorPrice"] = splitarray[66];
                        dr["VendorPriceEntered"] = splitarray[67];
                        dr["Weight"] = splitarray[68];
                        dr["AverageCost"] = splitarray[69];
                        dr["Parent"] = splitarray[70];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
