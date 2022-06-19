using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    // Context nesnesi Db tabloları ile proje classlarını bağlamak,ilişkilendirmek
    public class NorthwindContext : DbContext  //contextimixin ta kendisi. DbContext entityframework ile beraber geliyor
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //bu method proje hangi veritabı ile ilişkili olduğunu belirteceğimiz yer
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database =Northwind;Trusted_Connection=true"); // sql serves adres tanımlama //context hangi veritabanına bağlanacağını buldu burda 
        }

        public DbSet<Product> Products { get; set; } // burda da diyor ki benim hangi clasım hangi tabloya karşılık geliyor => //benim produtc nesnemi veritabanındaki products ile bağla
        public DbSet<Category> Categories { get; set; } //veritabanı ile tabloları ilişkilendirdiğimiz yer
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
