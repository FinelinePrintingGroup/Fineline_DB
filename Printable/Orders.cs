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
    /// <summary>
    /// Static class used to retrieve single records from Printable.dbo.OrderDetails
    /// </summary>
    public class Orders : Printable
    {
        #region DECLARATIONS
        public string v_Order_ID;
        public string v_Order_ID_Type;
        public string v_OrderNumber;
        public string v_Description;
        public string v_CreateDate;
        public string v_Status;
        public string v_User_ID;
        public string v_User_ID_Type;
        public string v_User_FirstName;
        public string v_User_LastName;
        public string v_User_Login_ID;
        public string v_User_Email;
        public string v_Seller_ID;
        public string v_Seller_ID_Type;
        public string v_Seller_Name;
        public string v_UserGroup_ID;
        public string v_UserGroup_Type;
        public string v_Company_ID;
        public string v_Company_ID_Type;
        public string v_Company_Name;
        public string v_BillingAddress_ID;
        public string v_BillingAddress_ID_Type;
        public string v_BillingAddress_Description;
        public string v_BillingAddress_Address1;
        public string v_BillingAddress_Address2;
        public string v_BillingAddress_Address3;
        public string v_BillingAddress_Address4;
        public string v_BillingAddress_City;
        public string v_BillingAddress_State;
        public string v_BillingAddress_Zip;
        public string v_BillingAddress_Country;
        public string v_BillingAddress_PhoneNumber;
        public string v_BillingAddress_FaxNumber;
        public string v_BillingAddress_CompanyName;
        public string v_BillingAddress_Attn;
        public string v_ShippingAddress_ID;
        public string v_ShippingAddress_ID_Type;
        public string v_ShippingAddress_Description;
        public string v_ShippingAddress_Address1;
        public string v_ShippingAddress_Address2;
        public string v_ShippingAddress_Address3;
        public string v_ShippingAddress_Address4;
        public string v_ShippingAddress_City;
        public string v_ShippingAddress_State;
        public string v_ShippingAddress_Zip;
        public string v_ShippingAddress_Country;
        public string v_ShippingAddress_PhoneNumber;
        public string v_ShippingAddress_FaxNumber;
        public string v_ShippingAddress_CompanyName;
        public string v_ShippingAddress_Attn;
        public string v_PaymentMethod;
        public string v_CreditCard_AuthorizationNumber;
        public string v_CreditCard_AuthorizationExpirationDate;
        public string v_CreditCard_ConfirmationNumber;
        public string v_CreditCard_CCType;
        public string v_DateTime_Created;
        #endregion

        /// <summary>
        /// Queries Printable.dbo.Orders for the record with Order_ID equal to the parameter passed to it.
        /// </summary>
        /// <param name="v_Order_ID">Order_ID</param>
        public void q_RECORD_Order_ID(string v_Order_ID)
        {
            this.v_Order_ID = v_Order_ID;

            parseResponse(queryDatabase(@"SELECT TOP 1 *
                                          FROM printable.dbo.Orders
                                          WHERE Order_ID = " + v_Order_ID));
        }
        public void q_RECORD_Order_ID(int v)
        {
            q_RECORD_Order_ID(v.ToString());
        }

        private void parseResponse(ArrayList list)
        {
            foreach (object[] row in list)
            {
                int i = 0;
                v_Order_ID = row[i].ToString();
                i++;
                v_Order_ID_Type = row[i].ToString();
                i++;
                v_OrderNumber = row[i].ToString();
                i++;
                v_Description = row[i].ToString();
                i++;
                v_CreateDate = row[i].ToString();
                i++;
                v_Status = row[i].ToString();
                i++;
                v_User_ID = row[i].ToString();
                i++;
                v_User_ID_Type = row[i].ToString();
                i++;
                v_User_FirstName = row[i].ToString();
                i++;
                v_User_LastName = row[i].ToString();
                i++;
                v_User_Login_ID = row[i].ToString();
                i++;
                v_User_Email = row[i].ToString();
                i++;
                v_Seller_ID = row[i].ToString();
                i++;
                v_Seller_ID_Type = row[i].ToString();
                i++;
                v_Seller_Name = row[i].ToString();
                i++;
                v_UserGroup_ID = row[i].ToString();
                i++;
                v_UserGroup_Type = row[i].ToString();
                i++;
                v_Company_ID = row[i].ToString();
                i++;
                v_Company_ID_Type = row[i].ToString();
                i++;
                v_Company_Name = row[i].ToString();
                i++;
                v_BillingAddress_ID = row[i].ToString();
                i++;
                v_BillingAddress_ID_Type = row[i].ToString();
                i++;
                v_BillingAddress_Description = row[i].ToString();
                i++;
                v_BillingAddress_Address1 = row[i].ToString();
                i++;
                v_BillingAddress_Address2 = row[i].ToString();
                i++;
                v_BillingAddress_Address3 = row[i].ToString();
                i++;
                v_BillingAddress_Address4 = row[i].ToString();
                i++;
                v_BillingAddress_City = row[i].ToString();
                i++;
                v_BillingAddress_State = row[i].ToString();
                i++;
                v_BillingAddress_Zip = row[i].ToString();
                i++;
                v_BillingAddress_Country = row[i].ToString();
                i++;
                v_BillingAddress_PhoneNumber = row[i].ToString();
                i++;
                v_BillingAddress_FaxNumber = row[i].ToString();
                i++;
                v_BillingAddress_CompanyName = row[i].ToString();
                i++;
                v_BillingAddress_Attn = row[i].ToString();
                i++;
                v_ShippingAddress_ID = row[i].ToString();
                i++;
                v_ShippingAddress_ID_Type = row[i].ToString();
                i++;
                v_ShippingAddress_Description = row[i].ToString();
                i++;
                v_ShippingAddress_Address1 = row[i].ToString();
                i++;
                v_ShippingAddress_Address2 = row[i].ToString();
                i++;
                v_ShippingAddress_Address3 = row[i].ToString();
                i++;
                v_ShippingAddress_Address4 = row[i].ToString();
                i++;
                v_ShippingAddress_City = row[i].ToString();
                i++;
                v_ShippingAddress_State = row[i].ToString();
                i++;
                v_ShippingAddress_Zip = row[i].ToString();
                i++;
                v_ShippingAddress_Country = row[i].ToString();
                i++;
                v_ShippingAddress_PhoneNumber = row[i].ToString();
                i++;
                v_ShippingAddress_FaxNumber = row[i].ToString();
                i++;
                v_ShippingAddress_CompanyName = row[i].ToString();
                i++;
                v_ShippingAddress_Attn = row[i].ToString();
                i++;
                v_PaymentMethod = row[i].ToString();
                i++;
                v_CreditCard_AuthorizationNumber = row[i].ToString();
                i++;
                v_CreditCard_AuthorizationExpirationDate = row[i].ToString();
                i++;
                v_CreditCard_ConfirmationNumber = row[i].ToString();
                i++;
                v_CreditCard_CCType = row[i].ToString();
                i++;
                v_DateTime_Created = row[i].ToString();
            }
        }
    }
}
