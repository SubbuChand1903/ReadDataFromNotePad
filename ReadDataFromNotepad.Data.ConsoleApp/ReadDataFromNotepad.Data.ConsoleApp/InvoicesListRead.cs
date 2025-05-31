using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp
{
    class InvoicesListRead
    {
        public DataTable ConvertToDataTable()
        {
            string s = string.Empty;
            string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\SnG\OT load\InvoicesListResults950.txt");
            System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("OrderType", typeof(string));
            data.Columns.Add("Date", typeof(string));
            data.Columns.Add("AsOfDate", typeof(string));
            data.Columns.Add("Period", typeof(string));
            data.Columns.Add("TaxPeriod", typeof(string));
            data.Columns.Add("Type", typeof(string));
            data.Columns.Add("DocumentNumber", typeof(string));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Account", typeof(string));
            data.Columns.Add("Memo", typeof(string));
            data.Columns.Add("Amount", typeof(string));
            data.Columns.Add("PreferredEntityBank", typeof(string));
            data.Columns.Add("VendorBankFees", typeof(string));
            data.Columns.Add("BankFee", typeof(string));
            data.Columns.Add("BillcomSyncStatusListView", typeof(string));
            data.Columns.Add("Vendor", typeof(string));
            data.Columns.Add("ReceiveInspection", typeof(string));
            data.Columns.Add("ReceivedDummy", typeof(string));
            data.Columns.Add("Received_Dummy", typeof(string));
            data.Columns.Add("Subsidiary", typeof(string));
            data.Columns.Add("Location", typeof(string));
            data.Columns.Add("Source", typeof(string));
            data.Columns.Add("Buyer", typeof(string));
            data.Columns.Add("Item", typeof(string));
            data.Columns.Add("Department", typeof(string));
            data.Columns.Add("ExchangeRateLine", typeof(string));
            data.Columns.Add("Currency", typeof(string));
            data.Columns.Add("QuantityOrdered", typeof(string));
            data.Columns.Add("QuantityReceived", typeof(string));
            data.Columns.Add("Status", typeof(string));
            data.Columns.Add("InternalID", typeof(string));
            data.Columns.Add("Subsidiarynohierarchy", typeof(string));
            data.Columns.Add("LineID", typeof(string));
            data.Columns.Add("Account1", typeof(string));
            data.Columns.Add("CompanyName", typeof(string));
            data.Columns.Add("CustomerInternalID", typeof(string));
            data.Columns.Add("SalesRep", typeof(string));
            data.Columns.Add("BlanketSalesOrder", typeof(string));
            data.Columns.Add("AmountGross", typeof(string));
            data.Columns.Add("AmountNet", typeof(string));
            data.Columns.Add("AmountNetofTax", typeof(string));
            data.Columns.Add("AmountShipping", typeof(string));
            data.Columns.Add("AmountSigned", typeof(string));
            data.Columns.Add("AmountTax", typeof(string));
            data.Columns.Add("AmountTransactionTaxTotal", typeof(string));
            data.Columns.Add("AmountTransactionTotal", typeof(string));
            data.Columns.Add("AmountDiscount", typeof(string));
            data.Columns.Add("ShipDate", typeof(string));
            data.Columns.Add("ShipComplete", typeof(string));
            data.Columns.Add("ShipTo", typeof(string));
            data.Columns.Add("ShipVia", typeof(string));
            data.Columns.Add("ShipmentNumber", typeof(string));
            data.Columns.Add("ShippingAddress", typeof(string));
            data.Columns.Add("ShippingAddress1", typeof(string));
            data.Columns.Add("ShippingAddress2", typeof(string));
            data.Columns.Add("ShippingCarrier", typeof(string));
            data.Columns.Add("ShippingCity", typeof(string));
            data.Columns.Add("ShippingCost", typeof(string));
            data.Columns.Add("ShippingCost1", typeof(string));
            data.Columns.Add("ShippingCountry", typeof(string));
            data.Columns.Add("ShippingStateProvince", typeof(string));
            data.Columns.Add("TaxLine", typeof(string));
            data.Columns.Add("Terms", typeof(string));
            data.Columns.Add("TermsDiscountAmount", typeof(string));
            data.Columns.Add("TermsDiscountDate", typeof(string));
            data.Columns.Add("TotalPackageWeightInPounds", typeof(string));
            data.Columns.Add("TotalPackageWeightInPounds1", typeof(string));
            data.Columns.Add("TotalQuantity", typeof(string));
            data.Columns.Add("CreatedFrom", typeof(string));
            data.Columns.Add("CreatedFromDocumentNumber", typeof(string));
            data.Columns.Add("CreatedFromInternalID", typeof(string));
            data.Columns.Add("MainLine", typeof(string));
            data.Columns.Add("ItemInternalId", typeof(string));
            data.AcceptChanges();

            DataRow dr = null;
            foreach (string st in stringarry)
            {
                if (!string.IsNullOrEmpty(st))
                {
                    string[] splitarray = st.Split(',');

                    if (splitarray != null && splitarray.Length > 1)
                    {
                        dr = data.NewRow();
                        dr["OrderType"] = splitarray[0];
                        dr["Date"] = splitarray[1];
                        dr["AsOfDate"] = splitarray[2];
                        dr["Period"] = splitarray[3];
                        dr["TaxPeriod"] = splitarray[4];
                        dr["Type"] = splitarray[5];
                        dr["DocumentNumber"] = splitarray[6];
                        dr["Name"] = splitarray[7];
                        dr["Account"] = splitarray[8];
                        dr["Memo"] = splitarray[9];
                        dr["Amount"] = splitarray[10];
                        dr["PreferredEntityBank"] = splitarray[11];
                        dr["VendorBankFees"] = splitarray[12];
                        dr["BankFee"] = splitarray[13];
                        dr["BillcomSyncStatusListView"] = splitarray[14];
                        dr["Vendor"] = splitarray[15];
                        dr["ReceiveInspection"] = splitarray[16];
                        dr["ReceivedDummy"] = splitarray[17];
                        dr["Received_Dummy"] = splitarray[18];
                        dr["Subsidiary"] = splitarray[19];
                        dr["Location"] = splitarray[20];
                        dr["Source"] = splitarray[21];
                        dr["Buyer"] = splitarray[22];
                        dr["Item"] = splitarray[23];
                        dr["Department"] = splitarray[24];
                        dr["ExchangeRateLine"] = splitarray[25];
                        dr["Currency"] = splitarray[26];
                        dr["QuantityOrdered"] = splitarray[27];
                        dr["QuantityReceived"] = splitarray[28];
                        dr["Status"] = splitarray[29];
                        dr["InternalID"] = splitarray[30];
                        dr["Subsidiarynohierarchy"] = splitarray[31];
                        dr["LineID"] = splitarray[32];
                        dr["Account1"] = splitarray[33];
                        dr["CompanyName"] = splitarray[34];
                        dr["CustomerInternalID"] = splitarray[35];
                        dr["SalesRep"] = splitarray[36];
                        dr["BlanketSalesOrder"] = splitarray[37];
                        dr["AmountGross"] = splitarray[38];
                        dr["AmountNet"] = splitarray[39];
                        dr["AmountNetofTax"] = splitarray[40];
                        dr["AmountShipping"] = splitarray[41];
                        dr["AmountSigned"] = splitarray[42];
                        dr["AmountTax"] = splitarray[43];
                        dr["AmountTransactionTaxTotal"] = splitarray[44];
                        dr["AmountTransactionTotal"] = splitarray[45];
                        dr["AmountDiscount"] = splitarray[46];
                        dr["ShipDate"] = splitarray[47];
                        dr["ShipComplete"] = splitarray[48];
                        dr["ShipTo"] = splitarray[49];
                        dr["ShipVia"] = splitarray[50];
                        dr["ShipmentNumber"] = splitarray[51];
                        dr["ShippingAddress"] = splitarray[52];
                        dr["ShippingAddress1"] = splitarray[53];
                        dr["ShippingAddress2"] = splitarray[54];
                        dr["ShippingCarrier"] = splitarray[55];
                        dr["ShippingCity"] = splitarray[56];
                        dr["ShippingCost"] = splitarray[57];
                        dr["ShippingCost1"] = splitarray[58];
                        dr["ShippingCountry"] = splitarray[59];
                        dr["ShippingStateProvince"] = splitarray[60];
                        dr["TaxLine"] = splitarray[61];
                        dr["Terms"] = splitarray[62];
                        dr["TermsDiscountAmount"] = splitarray[63];
                        dr["TermsDiscountDate"] = splitarray[64];
                        dr["TotalPackageWeightInPounds"] = splitarray[65];
                        dr["TotalPackageWeightInPounds1"] = splitarray[66];
                        dr["TotalQuantity"] = splitarray[67];
                        dr["CreatedFrom"] = splitarray[68];
                        dr["CreatedFromDocumentNumber"] = splitarray[69];
                        dr["CreatedFromInternalID"] = splitarray[70];
                        dr["MainLine"] = splitarray[71];
                        dr["ItemInternalId"] = splitarray[72];
                        data.Rows.Add(dr);
                    }
                }
            }
            data.AcceptChanges();
            return data;
        }

    }
}
