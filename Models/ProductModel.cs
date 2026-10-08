namespace MVC031.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ImageURL { get; set; }
        public decimal ProductPrice { get; set; }
        public string Description { get; set; }

        public static List<ProductModel> GetProducts()
        {
            var products = new List<ProductModel>
            {
                new ProductModel { ProductID = 1, ProductName = "Áo thun nam", ImageURL = "/images/product1.jpg", ProductPrice = 150000, Description = "Áo thun cotton thoáng mát" },
                new ProductModel { ProductID = 2, ProductName = "Quần jean nữ", ImageURL = "/images/product2.jpg", ProductPrice = 350000, Description = "Quần jean form slimfit" },
                new ProductModel { ProductID = 3, ProductName = "Giày sneaker", ImageURL = "/images/product3.jpg", ProductPrice = 550000, Description = "Giày thể thao êm chân" },
                new ProductModel { ProductID = 4, ProductName = "Túi xách nữ", ImageURL = "/images/product4.jpg", ProductPrice = 420000, Description = "Túi da tổng hợp cao cấp" },
                new ProductModel { ProductID = 5, ProductName = "Đồng hồ nam", ImageURL = "/images/product5.jpg", ProductPrice = 890000, Description = "Đồng hồ dây da chống nước" },
                new ProductModel { ProductID = 6, ProductName = "Nón lưỡi trai", ImageURL = "/images/product6.jpg", ProductPrice = 120000, Description = "Nón thời trang unisex" },
                new ProductModel { ProductID = 7, ProductName = "Kính mát", ImageURL = "/images/product7.jpg", ProductPrice = 250000, Description = "Kính chống tia UV" },
                new ProductModel { ProductID = 8, ProductName = "Balo laptop", ImageURL = "/images/product8.jpg", ProductPrice = 480000, Description = "Balo chống nước 15.6 inch" },
                new ProductModel { ProductID = 9, ProductName = "Áo khoác gió", ImageURL = "/images/product9.jpg", ProductPrice = 320000, Description = "Áo khoác nhẹ, chống nước nhẹ" },
                new ProductModel { ProductID = 10, ProductName = "Dép sandal", ImageURL = "/images/product10.jpg", ProductPrice = 180000, Description = "Dép quai ngang êm ái" }
            };

            return products;
        }
    }
}