﻿namespace TradeLendaInventory.Utility
{
    public class Constants
    {
        public const string ClientWithToken = "webapi_with_token";
        public class ClientRoutes
        {
            public const string Token = "api/usermanagement/authenticate";
            public const string Register = "api/usermanagement/register";

            public const string Productlist = "api/inventorymanagement/GetProducts";
            public const string DeleteProduct = "api/inventoryManagement/DeleteProduct/";
            public const string LowStockProductList = "api/inventorymanagement/GetLowStockProduct";
            public const string NoStockProductList = "api/inventorymanagement/GetNoStockProducts";
            public const string RecentProductList = "api/inventorymanagement/GEtREcentProducts";
            public const string ExpiredProductList = "api/inventorymanagement/GetExpiredProduct";

            public const string CategoryADD = "api/InventoryManagement/AddCategory";
            public const string CategoryList = "api/InventoryManagement/Getcategeory";
            public const string CategoryById = "api/InventoryManagement/GEtCategoryByID/";
            public const string DeleteCategory = "api/InventoryManagement/DeleteCategory/";
            public const string EditCategory = "api/InventoryManagement/EditCategory";

            public const string CustomerAdd = "api/Peoples/AddCustomer";
            public const string CustomerList = "api/Peoples/GetCustomer";
            public const string WarehouseADD = "api/Peoples/GetWarehouse";
            public const string WarehouseAdd = "api/Peoples/AddWarehouse";
        }

        public class Keys
        {
            public const string ApiBaseUrl = "App:ApiBaseUrl";
        }
    }
}