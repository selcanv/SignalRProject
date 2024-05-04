namespace SignalR.EntityLayer.DAL.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set;}
        public bool ProductStatus { get; set; }

        //her ürünün bir kategorisi olacak
        public int CategoryID { get; set; }
        //1-n olduğunu belirtmek için
        public Category Category { get; set; }
    }
}
