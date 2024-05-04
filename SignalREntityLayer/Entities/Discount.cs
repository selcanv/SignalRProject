namespace SignalR.EntityLayer.DAL.Entities
{
    public class Discount
    {//günün indirimi
        public int DiscountID { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
