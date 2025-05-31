using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReadDataFromNotepad.Data.ConsoleApp.inrule
{
    class WORKBENCHRecurringRevenueRecogn
    {
            public DataTable ConvertToDataTable()
            {
                string s = string.Empty;
                string[] stringarry = System.IO.File.ReadAllLines(@"C:\ProjectDocs\Inrule\WORKBENCHRecurringRevenueRecognitionForecastResults120.txt");
                System.Data.DataTable data = new System.Data.DataTable();
            data.Columns.Add("RecordType", typeof(string));
            data.Columns.Add("Id", typeof(string));
            data.Columns.Add("CompanyName", typeof(string));
            data.Columns.Add("SourceDocument", typeof(string));
            data.Columns.Add("CustomerJob", typeof(string));
            data.Columns.Add("PartnerCompanyName", typeof(string));
            data.Columns.Add("RevenueElementSourceDate", typeof(string));
            data.Columns.Add("Currency", typeof(string));
            data.Columns.Add("SourceDocumentType", typeof(string));
            data.Columns.Add("Element", typeof(string));
            data.Columns.Add("Type", typeof(string));
            data.Columns.Add("DeferredAccount", typeof(string));
            data.Columns.Add("Account", typeof(string));
            data.Columns.Add("IsRecognized", typeof(string));
            data.Columns.Add("Status", typeof(string));
            data.Columns.Add("Amount", typeof(string));
            data.Columns.Add("ClassFullName", typeof(string));
            data.Columns.Add("RecognizedinPeriod", typeof(string));
            data.Columns.Add("TotalRecognized_", typeof(string));
            data.Columns.Add("RevenuePlanType", typeof(string));
            data.Columns.Add("PlannedPeriod", typeof(string));
            data.Columns.Add("PostingPeriod", typeof(string));
            data.Columns.Add("TotalRecognized", typeof(string));
            data.Columns.Add("RemainingDeferredBalance", typeof(string));
            data.Columns.Add("InternalID", typeof(string));
            data.Columns.Add("Number", typeof(string));
            data.Columns.Add("AmountLineLevel", typeof(string));
            data.Columns.Add("TransactionInternalID", typeof(string));
            data.Columns.Add("TransactionLineID", typeof(string));
            data.Columns.Add("AppliedtoTransactionDocumentNumber", typeof(string));
            data.Columns.Add("AppliedtoTransactionDocumentNumber_", typeof(string));
            data.Columns.Add("RevenueElementSource", typeof(string));
            data.Columns.Add("IntakeDate", typeof(string));

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
                            dr["CompanyName"] = splitarray[0];
                            dr["SourceDocument"] = splitarray[1];
                            dr["CustomerJob"] = splitarray[2];
                            dr["PartnerCompanyName"] = splitarray[3];
                            dr["RevenueElementSourceDate"] = splitarray[4];
                            dr["Currency"] = splitarray[5];
                            dr["SourceDocumentType"] = splitarray[6];
                            dr["Element"] = splitarray[7];
                            dr["Type"] = splitarray[8];
                            dr["DeferredAccount"] = splitarray[9];
                            dr["Account"] = splitarray[10];
                            dr["IsRecognized"] = splitarray[11];
                            dr["Status"] = splitarray[12];
                            dr["Amount"] = splitarray[13];
                            dr["ClassFullName"] = splitarray[14];
                            dr["RecognizedinPeriod"] = splitarray[15];
                            dr["TotalRecognized_"] = splitarray[16];
                            dr["RevenuePlanType"] = splitarray[17];
                            dr["PlannedPeriod"] = splitarray[18];
                            dr["PostingPeriod"] = splitarray[19];
                            dr["TotalRecognized"] = splitarray[20];
                            dr["RemainingDeferredBalance"] = splitarray[21];
                            dr["InternalID"] = splitarray[22];
                            dr["Number"] = splitarray[23];
                            dr["AmountLineLevel"] = splitarray[24];
                            dr["TransactionInternalID"] = splitarray[25];
                            dr["TransactionLineID"] = splitarray[26];
                            dr["AppliedtoTransactionDocumentNumber"] = splitarray[27];
                            dr["AppliedtoTransactionDocumentNumber_"] = splitarray[28];
                            dr["RevenueElementSource"] = splitarray[29];
                            data.Rows.Add(dr);
                        }
                    }
                }
                data.AcceptChanges();
                return data;
            }

        }
    }
