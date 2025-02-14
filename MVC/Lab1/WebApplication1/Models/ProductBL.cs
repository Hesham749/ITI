namespace WebApplication1.Models
{
    public static class ProductBL
    {
        static ICollection<Product> Products = [];

        static ProductBL()
        {
            Products.Add(new() { Id = 1, Name = "Cheetos", Price = 10, ImageURL = "1.jpg" });
            Products.Add(new() { Id = 2, Name = "Tiger", Price = 15, ImageURL = "2.jpg" });
            Products.Add(new() { Id = 3, Name = "Lion", Price = 10, ImageURL = "3.jpg" });
            Products.Add(new() { Id = 4, Name = "Layes", Price = 20, ImageURL = "4.jpg" });
        }

        public static ICollection<Product> GetAllProducts()
         => Products;

        public static Product GetProduct(int id)
         => Products.SingleOrDefault(p => p.Id == id);
    }
}
