namespace TradeLendaInventory.Utility
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
            public const string ProductADD = "api/inventorymanagement/AddProduct";

            public const string CategoryADD = "api/InventoryManagement/AddCategory";
            public const string CategoryList = "api/InventoryManagement/Getcategeory";
            public const string CategoryById = "api/InventoryManagement/GEtCategoryByID/";
            public const string DeleteCategory = "api/InventoryManagement/DeleteCategory/";
            public const string EditCategory = "api/InventoryManagement/EditCategory";

            public const string BrandGet = "api/InventoryManagement/GetBrand";
            public const string ADDBRAND = "api/InventoryManagement/AddBRAND";
            public const string DeleteBrand = "api/inventorymanagement/DeleteBrand/";

            public const string CustomerAdd =  "api/Peoples/AddCustomer";
            public const string CustomerList = "api/Peoples/GetCustomer";
            public const string DeleteCustomer = "api/Peoples/DeleteCustomer/";
            public const string SupplierList = "api/Peoples/GetSupplier";
            public const string SupplierADD =  "api/Peoples/AddSupplier";
            public const string WarehouseGET = "api/Peoples/GetWarehouse";
            public const string WarehouseAdd = "api/Peoples/AddWarehouse";
            public const string StoreList = "api/Peoples/GetStore";
            public const string StoreADD = "api/Peoples/AddStore";
            public const string DeleteStore = "api/Peoples/DeleteStore/";

            public const string StockList = "api/Stock/get-stock-list";
            public const string StockAdd = "api/Stock/add-new-stock";
            public const string PurchaseADD = "api/Purchase/GetPurchaseListAsync";

            public const string GetUser = "api/UserManagement/GetUsers";
            public const string AddUser = "api/UserManagement/AddUser";

        }

        public class Keys
        {
            public const string ApiBaseUrl = "App:ApiBaseUrl";
        }
    }
}
