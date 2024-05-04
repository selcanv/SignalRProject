using Microsoft.EntityFrameworkCore;
using SignalR.EntityLayer.DAL.Entities;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Concrete
{
    //bağlantı adresini ":DbContext" olarak geçtim 
    public class SignalRContext:DbContext
    {
        //override OnConfiguring dedim ve {} arasına bağantı adresimi geçicem
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1J4T1BQ\\SQLEXPRESS;initial Catalog=SignalRDb; integrated Security=true");
        }
        //veritabanına neler yansıyacak ?
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        //böylece burada ilgili dbsetlerimin tamamını bir property olarak geçmiş oldum.
    }
}
