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
    public class OrderDetails : Printable
    {
        #region DECLARATIONS
        public string v_Job_Ticket_ID;
        public string v_Order_ID;
        public string v_OrderDetail_ID;
        public string v_OrderDetail_Type;
        public string v_OrderType;
        public string v_User_ID;
        public string v_User_ID_Type;
        public string v_User_FirstName;
        public string v_User_LastName;
        public string v_User_Login_ID;
        public string v_User_Email;
        public string v_Product_ID;
        public string v_Product_ID_Type;
        public string v_ProductName;
        public string v_ProductDescription;
        public string v_SKU_ID;
        public string v_SKU_ID_Type;
        public string v_SKU_Name;
        public string v_SKUDescription;
        public string v_Quantity;
        public string v_QuantityShipped;
        public string v_Price_Cost_Customer;
        public string v_Price_Cost_Customer_Currency;
        public string v_Price_Cost_Seller;
        public string v_Price_Cost_Seller_Currency;
        public string v_Price_Cost_Shipping;
        public string v_Price_Cost_Shipping_Currency;
        public string v_Price_Cost_Unit;
        public string v_Price_Cost_Unit_Currency;
        public string v_Price_Cost_CustomerDiscount;
        public string v_Price_Cost_CustomerDiscount_Currency;
        public string v_Price_Cost_CustomerMisc;
        public string v_Price_Cost_CustomerMisc_Currency;
        public string v_Price_Cost_SellerMisc;
        public string v_Price_Cost_SellerMisc_Currency;
        public string v_Price_Cost_SellerStoreDiscount;
        public string v_Price_Cost_SellerStoreDiscount_Currency;
        public string v_Price_Cost_SellerShipping;
        public string v_Price_Cost_SellerShipping_Currency;
        public string v_Price_Cost_Postage;
        public string v_Price_Cost_Postage_Currency;
        public string v_Price_Tax_CustomerSales;
        public string v_Price_Tax_CustomerSales_Currency;
        public string v_Price_Tax_DirectAcctSales;
        public string v_Price_Tax_DirectAcctSales_Currency;
        public string v_Price_Tax_City;
        public string v_Price_Tax_City_Currency;
        public string v_Price_Tax_County;
        public string v_Price_Tax_County_Currency;
        public string v_Price_Tax_State;
        public string v_Price_Tax_State_Currency;
        public string v_Price_Tax_District;
        public string v_Price_Tax_District_Currency;
        public string v_Price_Tax_CityFreight;
        public string v_Price_Tax_CityFreight_Currency;
        public string v_Price_Tax_CountyFreight;
        public string v_Price_Tax_CountyFreight_Currency;
        public string v_Price_Tax_StateFreight;
        public string v_Price_Tax_StateFreight_Currency;
        public string v_Price_Tax_DistrictFreight;
        public string v_Price_Tax_DistrictFreight_Currency;
        public string v_Price_Tax_TotalFreight;
        public string v_Price_Tax_TotalFreight_Currency;
        public string v_Price_Tax_TaxableSalesAmount;
        public string v_Price_Tax_TaxableSalesAmount_Currency;
        public string v_Price_Tax_ExemptSalesAmount;
        public string v_Price_Tax_ExemptSalesAmount_Currency;
        public string v_Price_Tax_NonTaxableSalesAmount;
        public string v_Price_Tax_NonTaxableSalesAmount_Currency;
        public string v_Price_Tax_CityName;
        public string v_Price_Tax_CountyName;
        public string v_Price_Tax_StateName;
        public string v_Price_Tax_Zip;
        public string v_Department_ID;
        public string v_Department_ID_Type;
        public string v_Department_Name;
        public string v_Department_Number;
        public string v_SupplierWorkOrder_ID;
        public string v_SupplierWorkOrder_ID_Type;
        public string v_SupplierWorkOrder_Name;
        public string v_Supplier_ID;
        public string v_Supplier_ID_Type;
        public string v_Supplier_Name;
        public string v_OutputFileURL;
        public string v_Shipping_Date;
        public string v_Shipping_DateShipped;
        public string v_Shipping_Method;
        public string v_Shipping_Instructions;
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
        public string v_ShippingTrackingNumber;
        public string v_ClientStatus;
        public string v_ClientStatus_Date;
        public string v_SellerStatus;
        public string v_SellerStatus_Date;
        public string v_SupplierStatus;
        public string v_SupplierStatus_Date;
        public string v_CreditCardSettlement_ID;
        public string v_CreditCardSettlement_ID_Type;
        public string v_CreditCardSettlement_Number;
        public string v_CreditCardSettlement_Date;
        public string v_CreditCardSettlement_User_ID;
        public string v_CreditCardSettlement_User_ID_Type;
        public string v_CreditCardSettlement_UserName;
        public string v_OrderNumber;
        public string v_ClientPONumber;
        public string v_SalesWorkOrder_ID;
        public string v_SalesWorkOrder_ID_Type;
        public string v_ProductType;
        public string v_Postage_Method;
        public string v_Postage_Cost;
        public string v_Postage_Cost_Currency;
        public string v_DownloadURL;
        public string v_PageCount;
        public string v_CatalogTreeNodeExternalId;
        public string v_RequisitionStatus;
        public string v_ApproverUser_ID;
        public string v_ApproverUser_ID_Type;
        public string v_ApproverUser_Name;
        public string v_ApproverUser_FirstName;
        public string v_ApproverUser_LastName;
        public string v_ApproverUser_Login_ID;
        public string v_ApproverUser_Email;
        public string v_Explanation;
        public string v_ImposedUsingDefaultURL;
        public string v_ReqUser_ID;
        public string v_ReqUser_ID_Type;
        public string v_ReqUser_Name;
        public string v_ReqUser_FirstName;
        public string v_ReqUser_LastName;
        public string v_ReqUser_Login_ID;
        public string v_ReqUser_Email;
        public string v_SKUInventorySettings_Unit;
        public string v_SKUInventorySettings_QtyPerUnit;
        public string v_SKUInventorySettings_Warehouse;
        public string v_SKUInventorySettings_Location;
        public string v_ListVendor_ID;
        public string v_ListVendor_ID_Type;
        public string v_ListVendor_Name;
        public string v_ListVendor_CustomerCost;
        public string v_ListVendor_CustomerCost_Currency;
        public string v_Impersonator_ID;
        public string v_Impersonator_ID_Type;
        public string v_Impersonator_Name;
        public string v_Impersonator_FirstName;
        public string v_Impersonator_LastName;
        public string v_Impersonator_Login_ID;
        public string v_Impersonator_Email;
        public string v_UserLiteType_ID;
        public string v_UserLiteType_ID_Type;
        public string v_UserLiteType_Login_ID;
        public string v_UserLiteType_Name;
        public string v_UserLiteType_FirstName;
        public string v_UserLiteType_LastName;
        public string v_FileDownloaded;
        public string v_DateTime_Created;
        public string v_XmlCreated;
        #endregion

        /// <summary>
        /// Queries Printable.dbo.OrderDetails based upon the OrderDetail_ID. Sets the class variables accordingly.
        /// </summary>
        /// <param name="v_OrderDetail_ID">OrderDetail_ID</param>
        public void q_RECORD_OrderDetail_ID(string v_OrderDetail_ID)
        {
            this.v_OrderDetail_ID = v_OrderDetail_ID;

            parseResponse(queryDatabase(@"SELECT TOP 1 *
                                          FROM printable.dbo.OrderDetails
                                          WHERE OrderDetail_ID = " + v_OrderDetail_ID));
        }
        public void q_RECORD_OrderDetail_ID(int v)
        { q_RECORD_OrderDetail_ID(v.ToString()); }

        /// <summary>
        /// Queries Printable.dbo.OrderDetails based upon the JT-#####. Sets the class variables accordingly.
        /// </summary>
        /// <param name="v_SupplierWorkOrder_Name">JT-#####</param>
        public void q_RECORD_SupplierWorkOrder_Name(string v_SupplierWorkOrder_Name)
        {
            this.v_SupplierWorkOrder_Name = v_SupplierWorkOrder_Name;

            parseResponse(queryDatabase(@"SELECT TOP 1 *
                                          FROM printable.dbo.OrderDetails
                                          WHERE SupplierWorkOrder_Name = '" + v_SupplierWorkOrder_Name + @"'"));            
        }
        public void q_RECORD_SupplierWorkOrder_Name(int v)
        { q_RECORD_SupplierWorkOrder_Name(v.ToString()); }

        /// <summary>
        /// Returns the number of records in Printable.dbo.OrderDetails that have a corresponding Order_ID.
        /// </summary>
        /// <param name="v_Order_ID">Order_ID</param>
        /// <returns>COUNT(*) of records with matching Order_ID</returns>
        public int q_COUNT_Order_ID(string v_Order_ID)
        {
            this.v_Order_ID = v_Order_ID;

            return countDatabase(@"SELECT COUNT(*)
                                   FROM printable.dbo.OrderDetails
                                   WHERE Order_ID = " + v_Order_ID);
        }
        public int q_COUNT_Order_ID(int v)
        { return q_COUNT_Order_ID(v.ToString()); }

        /// <summary>
        /// Returns the number of records in Printable.dbo.OrderDetails that have a corresponding JT-#####.
        /// </summary>
        /// <param name="v_SupplierWorkOrder_Name">JT-#####</param>
        /// <returns>COUNT(*) of records with matching JT-#####</returns>
        public int q_COUNT_SupplierWorkOrder_Name(string v_SupplierWorkOrder_Name)
        {
            this.v_SupplierWorkOrder_Name = v_SupplierWorkOrder_Name;

            return countDatabase(@"SELECT COUNT(*)
                                   FROM printable.dbo.OrderDetails
                                   WHERE Order_ID = " + v_SupplierWorkOrder_Name);
        }
        public int q_COUNT_SupplierWorkOrder_Name(int v)
        { return q_COUNT_SupplierWorkOrder_Name(v.ToString()); }

        /// <summary>
        /// Helper method that parses ArrayList results and sets the respective variables.
        /// </summary>
        /// <param name="list">ArrayList containing query results.</param>
        private void parseResponse(ArrayList list)
        {
            foreach (object[] row in list)
            {
                int i = 0;
                v_Job_Ticket_ID = row[i].ToString();
                i++;
                v_Order_ID = row[i].ToString();
                i++;
                v_OrderDetail_ID = row[i].ToString();
                i++;
                v_OrderDetail_Type = row[i].ToString();
                i++;
                v_OrderType = row[i].ToString();
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
                v_Product_ID = row[i].ToString();
                i++;
                v_Product_ID_Type = row[i].ToString();
                i++;
                v_ProductName = row[i].ToString();
                i++;
                v_ProductDescription = row[i].ToString();
                i++;
                v_SKU_ID = row[i].ToString();
                i++;
                v_SKU_ID_Type = row[i].ToString();
                i++;
                v_SKU_Name = row[i].ToString();
                i++;
                v_SKUDescription = row[i].ToString();
                i++;
                v_Quantity = row[i].ToString();
                i++;
                v_QuantityShipped = row[i].ToString();
                i++;
                v_Price_Cost_Customer = row[i].ToString();
                i++;
                v_Price_Cost_Customer_Currency = row[i].ToString();
                i++;
                v_Price_Cost_Seller = row[i].ToString();
                i++;
                v_Price_Cost_Seller_Currency = row[i].ToString();
                i++;
                v_Price_Cost_Shipping = row[i].ToString();
                i++;
                v_Price_Cost_Shipping_Currency = row[i].ToString();
                i++;
                v_Price_Cost_Unit = row[i].ToString();
                i++;
                v_Price_Cost_Unit_Currency = row[i].ToString();
                i++;
                v_Price_Cost_CustomerDiscount = row[i].ToString();
                i++;
                v_Price_Cost_CustomerDiscount_Currency = row[i].ToString();
                i++;
                v_Price_Cost_CustomerMisc = row[i].ToString();
                i++;
                v_Price_Cost_CustomerMisc_Currency = row[i].ToString();
                i++;
                v_Price_Cost_SellerMisc = row[i].ToString();
                i++;
                v_Price_Cost_SellerMisc_Currency = row[i].ToString();
                i++;
                v_Price_Cost_SellerStoreDiscount = row[i].ToString();
                i++;
                v_Price_Cost_SellerStoreDiscount_Currency = row[i].ToString();
                i++;
                v_Price_Cost_SellerShipping = row[i].ToString();
                i++;
                v_Price_Cost_SellerShipping_Currency = row[i].ToString();
                i++;
                v_Price_Cost_Postage = row[i].ToString();
                i++;
                v_Price_Cost_Postage_Currency = row[i].ToString();
                i++;
                v_Price_Tax_CustomerSales = row[i].ToString();
                i++;
                v_Price_Tax_CustomerSales_Currency = row[i].ToString();
                i++;
                v_Price_Tax_DirectAcctSales = row[i].ToString();
                i++;
                v_Price_Tax_DirectAcctSales_Currency = row[i].ToString();
                i++;
                v_Price_Tax_City = row[i].ToString();
                i++;
                v_Price_Tax_City_Currency = row[i].ToString();
                i++;
                v_Price_Tax_County = row[i].ToString();
                i++;
                v_Price_Tax_County_Currency = row[i].ToString();
                i++;
                v_Price_Tax_State = row[i].ToString();
                i++;
                v_Price_Tax_State_Currency = row[i].ToString();
                i++;
                v_Price_Tax_District = row[i].ToString();
                i++;
                v_Price_Tax_District_Currency = row[i].ToString();
                i++;
                v_Price_Tax_CityFreight = row[i].ToString();
                i++;
                v_Price_Tax_CityFreight_Currency = row[i].ToString();
                i++;
                v_Price_Tax_CountyFreight = row[i].ToString();
                i++;
                v_Price_Tax_CountyFreight_Currency = row[i].ToString();
                i++;
                v_Price_Tax_StateFreight = row[i].ToString();
                i++;
                v_Price_Tax_StateFreight_Currency = row[i].ToString();
                i++;
                v_Price_Tax_DistrictFreight = row[i].ToString();
                i++;
                v_Price_Tax_DistrictFreight_Currency = row[i].ToString();
                i++;
                v_Price_Tax_TotalFreight = row[i].ToString();
                i++;
                v_Price_Tax_TotalFreight_Currency = row[i].ToString();
                i++;
                v_Price_Tax_TaxableSalesAmount = row[i].ToString();
                i++;
                v_Price_Tax_TaxableSalesAmount_Currency = row[i].ToString();
                i++;
                v_Price_Tax_ExemptSalesAmount = row[i].ToString();
                i++;
                v_Price_Tax_ExemptSalesAmount_Currency = row[i].ToString();
                i++;
                v_Price_Tax_NonTaxableSalesAmount = row[i].ToString();
                i++;
                v_Price_Tax_NonTaxableSalesAmount_Currency = row[i].ToString();
                i++;
                v_Price_Tax_CityName = row[i].ToString();
                i++;
                v_Price_Tax_CountyName = row[i].ToString();
                i++;
                v_Price_Tax_StateName = row[i].ToString();
                i++;
                v_Price_Tax_Zip = row[i].ToString();
                i++;
                v_Department_ID = row[i].ToString();
                i++;
                v_Department_ID_Type = row[i].ToString();
                i++;
                v_Department_Name = row[i].ToString();
                i++;
                v_Department_Number = row[i].ToString();
                i++;
                v_SupplierWorkOrder_ID = row[i].ToString();
                i++;
                v_SupplierWorkOrder_ID_Type = row[i].ToString();
                i++;
                v_SupplierWorkOrder_Name = row[i].ToString();
                i++;
                v_Supplier_ID = row[i].ToString();
                i++;
                v_Supplier_ID_Type = row[i].ToString();
                i++;
                v_Supplier_Name = row[i].ToString();
                i++;
                v_OutputFileURL = row[i].ToString();
                i++;
                v_Shipping_Date = row[i].ToString();
                i++;
                v_Shipping_DateShipped = row[i].ToString();
                i++;
                v_Shipping_Method = row[i].ToString();
                i++;
                v_Shipping_Instructions = row[i].ToString();
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
                v_ShippingTrackingNumber = row[i].ToString();
                i++;
                v_ClientStatus = row[i].ToString();
                i++;
                v_ClientStatus_Date = row[i].ToString();
                i++;
                v_SellerStatus = row[i].ToString();
                i++;
                v_SellerStatus_Date = row[i].ToString();
                i++;
                v_SupplierStatus = row[i].ToString();
                i++;
                v_SupplierStatus_Date = row[i].ToString();
                i++;
                v_CreditCardSettlement_ID = row[i].ToString();
                i++;
                v_CreditCardSettlement_ID_Type = row[i].ToString();
                i++;
                v_CreditCardSettlement_Number = row[i].ToString();
                i++;
                v_CreditCardSettlement_Date = row[i].ToString();
                i++;
                v_CreditCardSettlement_User_ID = row[i].ToString();
                i++;
                v_CreditCardSettlement_User_ID_Type = row[i].ToString();
                i++;
                v_CreditCardSettlement_UserName = row[i].ToString();
                i++;
                v_OrderNumber = row[i].ToString();
                i++;
                v_ClientPONumber = row[i].ToString();
                i++;
                v_SalesWorkOrder_ID = row[i].ToString();
                i++;
                v_SalesWorkOrder_ID_Type = row[i].ToString();
                i++;
                v_ProductType = row[i].ToString();
                i++;
                v_Postage_Method = row[i].ToString();
                i++;
                v_Postage_Cost = row[i].ToString();
                i++;
                v_Postage_Cost_Currency = row[i].ToString();
                i++;
                v_DownloadURL = row[i].ToString();
                i++;
                v_PageCount = row[i].ToString();
                i++;
                v_CatalogTreeNodeExternalId = row[i].ToString();
                i++;
                v_RequisitionStatus = row[i].ToString();
                i++;
                v_ApproverUser_ID = row[i].ToString();
                i++;
                v_ApproverUser_ID_Type = row[i].ToString();
                i++;
                v_ApproverUser_Name = row[i].ToString();
                i++;
                v_ApproverUser_FirstName = row[i].ToString();
                i++;
                v_ApproverUser_LastName = row[i].ToString();
                i++;
                v_ApproverUser_Login_ID = row[i].ToString();
                i++;
                v_ApproverUser_Email = row[i].ToString();
                i++;
                v_Explanation = row[i].ToString();
                i++;
                v_ImposedUsingDefaultURL = row[i].ToString();
                i++;
                v_ReqUser_ID = row[i].ToString();
                i++;
                v_ReqUser_ID_Type = row[i].ToString();
                i++;
                v_ReqUser_Name = row[i].ToString();
                i++;
                v_ReqUser_FirstName = row[i].ToString();
                i++;
                v_ReqUser_LastName = row[i].ToString();
                i++;
                v_ReqUser_Login_ID = row[i].ToString();
                i++;
                v_ReqUser_Email = row[i].ToString();
                i++;
                v_SKUInventorySettings_Unit = row[i].ToString();
                i++;
                v_SKUInventorySettings_QtyPerUnit = row[i].ToString();
                i++;
                v_SKUInventorySettings_Warehouse = row[i].ToString();
                i++;
                v_SKUInventorySettings_Location = row[i].ToString();
                i++;
                v_ListVendor_ID = row[i].ToString();
                i++;
                v_ListVendor_ID_Type = row[i].ToString();
                i++;
                v_ListVendor_Name = row[i].ToString();
                i++;
                v_ListVendor_CustomerCost = row[i].ToString();
                i++;
                v_ListVendor_CustomerCost_Currency = row[i].ToString();
                i++;
                v_Impersonator_ID = row[i].ToString();
                i++;
                v_Impersonator_ID_Type = row[i].ToString();
                i++;
                v_Impersonator_Name = row[i].ToString();
                i++;
                v_Impersonator_FirstName = row[i].ToString();
                i++;
                v_Impersonator_LastName = row[i].ToString();
                i++;
                v_Impersonator_Login_ID = row[i].ToString();
                i++;
                v_Impersonator_Email = row[i].ToString();
                i++;
                v_UserLiteType_ID = row[i].ToString();
                i++;
                v_UserLiteType_ID_Type = row[i].ToString();
                i++;
                v_UserLiteType_Login_ID = row[i].ToString();
                i++;
                v_UserLiteType_Name = row[i].ToString();
                i++;
                v_UserLiteType_FirstName = row[i].ToString();
                i++;
                v_UserLiteType_LastName = row[i].ToString();
                i++;
                v_FileDownloaded = row[i].ToString();
                i++;
                v_DateTime_Created = row[i].ToString();
                i++;
                v_XmlCreated = row[i].ToString();
            }
        }        
    }
}
