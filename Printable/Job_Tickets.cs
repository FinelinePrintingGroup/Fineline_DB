using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection;

namespace FinelineDatabase.Printable
{
    public class Job_Tickets : Printable
    {
        #region DECLARATIONS
        public string v_Job_Ticket_ID;
        public string v_Job_Ticket_ID_Type;
        public string v_JobTicketNumber;
        public string v_ProjectDescription;
        public string v_CreatedDate;
        public string v_Sales_ID;
        public string v_Sales_ID_Type;
        public string v_Company_ID;
        public string v_Company_ID_Type;
        public string v_Supplier_ID;
        public string v_Supplier_ID_Type;
        public string v_SupplierOrderStatus;
        public string v_BillingAddress_Description;
        public string v_BillingAddress_Address1;
        public string v_BillingAddress_Address2;
        public string v_BillingAddress_Address3;
        public string v_BillingAddress_Address4;
        public string v_BillingAddress_City;
        public string v_BillingAddress_State;
        public string v_BillingAddress_Zip;
        public string v_BillingAddress_Country;
        public string v_BillingAddress_Attn;
        public string v_ShippingAddress_Description;
        public string v_ShippingAddress_Address1;
        public string v_ShippingAddress_Address2;
        public string v_ShippingAddress_Address3;
        public string v_ShippingAddress_Address4;
        public string v_ShippingAddress_City;
        public string v_ShippingAddress_State;
        public string v_ShippingAddress_Zip;
        public string v_ShippingAddress_Country;
        public string v_ShippingAddress_Attn;
        public string v_DeliveryDate;
        public string v_Email;
        public string v_PDFInProgressTime;
        public string v_Instructions_Email;
        public string v_Instructions_GeneralDescription;
        public string v_Instructions_PaperDescription;
        public string v_Instructions_FilmDescription;
        public string v_Instructions_PressInstructions;
        public string v_Instructions_BinderyInstructions;
        public string v_Instructions_ShippingInstructions;
        public string v_FinalOutputFileURL;
        public string v_In_Logic;
        public string v_DateTime_Created;
        #endregion

        public void q_RECORD_Job_Ticket_ID(string v_Job_Ticket_ID)
        {
            this.v_Job_Ticket_ID = v_Job_Ticket_ID;

            parseResponse(queryDatabase(@"SELECT TOP 1 *
                                          FROM printable.dbo.Job_Tickets
                                          WHERE Job_Ticket_ID = '" + v_Job_Ticket_ID + "'"));
        }
        public void q_Job_Ticket_ID(int v)
        {
            q_RECORD_Job_Ticket_ID(v.ToString());
        }

        public void q_RECORD_JobTicketNumber(string v_JobTicketNumber)
        {
            this.v_JobTicketNumber = v_JobTicketNumber;

            parseResponse(queryDatabase(@"SELECT TOP 1 *
                                          FROM printable.dbo.Job_Tickets
                                          WHERE JobTicketNumber = '" + v_JobTicketNumber + "'"));
        }

        private void parseResponse(ArrayList list)
        {
            foreach (object[] row in list)
            {
                int i = 0;
                v_Job_Ticket_ID = row[i].ToString(); i++;
                v_Job_Ticket_ID_Type = row[i].ToString(); i++;
                v_JobTicketNumber = row[i].ToString(); i++;
                v_ProjectDescription = row[i].ToString(); i++;
                v_CreatedDate = row[i].ToString(); i++;
                v_Sales_ID = row[i].ToString(); i++;
                v_Sales_ID_Type = row[i].ToString(); i++;
                v_Company_ID = row[i].ToString(); i++;
                v_Company_ID_Type = row[i].ToString(); i++;
                v_Supplier_ID = row[i].ToString(); i++;
                v_Supplier_ID_Type = row[i].ToString(); i++;
                v_SupplierOrderStatus = row[i].ToString(); i++;
                v_BillingAddress_Description = row[i].ToString(); i++;
                v_BillingAddress_Address1 = row[i].ToString(); i++;
                v_BillingAddress_Address2 = row[i].ToString(); i++;
                v_BillingAddress_Address3 = row[i].ToString(); i++;
                v_BillingAddress_Address4 = row[i].ToString(); i++;
                v_BillingAddress_City = row[i].ToString(); i++;
                v_BillingAddress_State = row[i].ToString(); i++;
                v_BillingAddress_Zip = row[i].ToString(); i++;
                v_BillingAddress_Country = row[i].ToString(); i++;
                v_BillingAddress_Attn = row[i].ToString(); i++;
                v_ShippingAddress_Description = row[i].ToString(); i++;
                v_ShippingAddress_Address1 = row[i].ToString(); i++;
                v_ShippingAddress_Address2 = row[i].ToString(); i++;
                v_ShippingAddress_Address3 = row[i].ToString(); i++;
                v_ShippingAddress_Address4 = row[i].ToString(); i++;
                v_ShippingAddress_City = row[i].ToString(); i++;
                v_ShippingAddress_State = row[i].ToString(); i++;
                v_ShippingAddress_Zip = row[i].ToString(); i++;
                v_ShippingAddress_Country = row[i].ToString(); i++;
                v_ShippingAddress_Attn = row[i].ToString(); i++;
                v_DeliveryDate = row[i].ToString(); i++;
                v_Email = row[i].ToString(); i++;
                v_PDFInProgressTime = row[i].ToString(); i++;
                v_Instructions_Email = row[i].ToString(); i++;
                v_Instructions_GeneralDescription = row[i].ToString(); i++;
                v_Instructions_PaperDescription = row[i].ToString(); i++;
                v_Instructions_FilmDescription = row[i].ToString(); i++;
                v_Instructions_PressInstructions = row[i].ToString(); i++;
                v_Instructions_BinderyInstructions = row[i].ToString(); i++;
                v_Instructions_ShippingInstructions = row[i].ToString(); i++;
                v_FinalOutputFileURL = row[i].ToString(); i++;
                v_In_Logic = row[i].ToString(); i++;
                v_DateTime_Created = row[i].ToString(); i++;
            }
        }
    }
}
