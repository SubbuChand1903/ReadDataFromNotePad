using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class CustomerMasterRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\PriceTier\PriceTiersResults833.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("PriceLevel", typeof(string));
            data.Columns.Add("PricingGroup", typeof(string));
            data.Columns.Add("Account", typeof(string));
            data.Columns.Add("AnnualRevenue", typeof(string));
            data.Columns.Add("BuyingGreason", typeof(string));
            data.Columns.Add("City", typeof(string));
            data.Columns.Add("Country", typeof(string));
            data.Columns.Add("CompanyName", typeof(string));
            data.Columns.Add("CustomerType", typeof(string));
            data.Columns.Add("DateCreated", typeof(string));
            data.Columns.Add("DateOfFirstOrder ", typeof(string));
            data.Columns.Add("DateOfFirstSale", typeof(string));
            data.Columns.Add("DateOfLastOrder", typeof(string));
            data.Columns.Add("DateOfLastSale", typeof(string));
            data.Columns.Add("Department", typeof(string));
            data.Columns.Add("ExternalId", typeof(string));
            data.Columns.Add("InternalId", typeof(string));
            data.Columns.Add("FreightTerms", typeof(string));
            data.Columns.Add("FreightTermsOverRide", typeof(string));
            data.Columns.Add("GropuPricingLevel ", typeof(string));
            data.Columns.Add("Inactive", typeof(string));
            data.Columns.Add("Industry", typeof(string));
            data.Columns.Add("IntercoTerms", typeof(string));
            data.Columns.Add("IsIndividual", typeof(string));
            data.Columns.Add("IsUpsellItemCorrelated", typeof(string));
            data.Columns.Add("ItemPricingLevel", typeof(string));
            data.Columns.Add("ItemPricingUnitPrice", typeof(string));
            data.Columns.Add("LastModified", typeof(string));
            data.Columns.Add("LastSalesActivity", typeof(string));
            data.Columns.Add("Leaddata", typeof(string));
            data.Columns.Add("LeadSource", typeof(string));
            data.Columns.Add("Level", typeof(string));
            data.Columns.Add("MarketSegment", typeof(string));
            data.Columns.Add("NoOfEmployees", typeof(string));
            data.Columns.Add("PricingItem", typeof(string));
            data.Columns.Add("PrimaryCurrency", typeof(string));
            data.Columns.Add("ProspectDate", typeof(string));
            data.Columns.Add("Region", typeof(string));
            data.Columns.Add("Sales", typeof(string));
            data.Columns.Add("ShippingCarrier", typeof(string));
            data.Columns.Add("ShippingCity", typeof(string));
            data.Columns.Add("ShippingCountry", typeof(string));
            data.Columns.Add("ShippingStateProvince", typeof(string));
            data.Columns.Add("ShippingZip", typeof(string));
            data.Columns.Add("StateProvince", typeof(string));
            data.Columns.Add("Status", typeof(string));
            data.Columns.Add("Territory", typeof(string));
            data.Columns.Add("TopLevelParent", typeof(string));
            data.Columns.Add("TransactionsNeedApproval", typeof(string));
            data.Columns.Add("ZipCode", typeof(string));
            data.Columns.Add("Channel", typeof(string));
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
                        dr["PriceLevel"] = splitarray[1];
                        dr["PricingGroup"] = splitarray[2];
                        dr["Account"] = splitarray[3];
                        dr["AnnualRevenue"] = splitarray[4];
                        dr["BuyingGreason"] = splitarray[5];
                        dr["City"] = splitarray[6];
                        dr["Country"] = splitarray[7];
                        dr["CompanyName"] = splitarray[8];
                        dr["CustomerType"] = splitarray[9];
                        dr["DateCreated"] = splitarray[10];
                        dr["DateOfFirstOrder "] = splitarray[11];
                        dr["DateOfFirstSale"] = splitarray[12];
                        dr["DateOfLastOrder"] = splitarray[13];
                        dr["DateOfLastSale"] = splitarray[14];
                        dr["Department"] = splitarray[15];
                        dr["ExternalId"] = splitarray[16];
                        dr["InternalId"] = splitarray[17];
                        dr["FreightTerms"] = splitarray[18];
                        dr["FreightTermsOverRide"] = splitarray[19];
                        dr["GropuPricingLevel "] = splitarray[20];
                        dr["Inactive"] = splitarray[21];
                        dr["Industry"] = splitarray[22];
                        dr["IntercoTerms"] = splitarray[23];
                        dr["IsIndividual"] = splitarray[24];
                        dr["IsUpsellItemCorrelated"] = splitarray[25];
                        dr["ItemPricingLevel"] = splitarray[26];
                        dr["ItemPricingUnitPrice"] = splitarray[27];
                        dr["LastModified"] = splitarray[28];
                        dr["LastSalesActivity"] = splitarray[29];
                        dr["Leaddata"] = splitarray[30];
                        dr["LeadSource"] = splitarray[31];
                        dr["Level"] = splitarray[32];
                        dr["MarketSegment"] = splitarray[33];
                        dr["NoOfEmployees"] = splitarray[34];
                        dr["PricingItem"] = splitarray[35];
                        dr["PrimaryCurrency"] = splitarray[36];
                        dr["ProspectDate"] = splitarray[37];
                        dr["Region"] = splitarray[38];
                        dr["Sales"] = splitarray[39];
                        dr["ShippingCarrier"] = splitarray[40];
                        dr["ShippingCity"] = splitarray[41];
                        dr["ShippingCountry"] = splitarray[42];
                        dr["ShippingStateProvince"] = splitarray[43];
                        dr["ShippingZip"] = splitarray[44];
                        dr["StateProvince"] = splitarray[45];
                        dr["Status"] = splitarray[46];
                        dr["Territory"] = splitarray[47];
                        dr["TopLevelParent"] = splitarray[48];
                        dr["TransactionsNeedApproval"] = splitarray[49];
                        dr["ZipCode"] = splitarray[50];
                        dr["Channel"] = splitarray[51]; 
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
