namespace ShopManagement.Application.Contracts.ProductCategoryApp
{
    public class ProductCategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string CareationDate { get; set; }

        public long ProductCount { get; set; }

    }
}
