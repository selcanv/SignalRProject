namespace SignalR.EntityLayer.DAL.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }


        //product ilişkisi için liste olarak geçtim. Böylece 1-n ilişki kısmı hazırlandı
        public List<Product> Products { get; set; }

    }
}
