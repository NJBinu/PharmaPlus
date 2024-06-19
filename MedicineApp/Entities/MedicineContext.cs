using Microsoft.EntityFrameworkCore;

namespace MedicineApp.Entities
{
    public class MedicineContext : DbContext
    {

        public MedicineContext(DbContextOptions<MedicineContext> options) : base(options)
        {
        }

        public DbSet<Medicine> Medicines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed the database with initial data from a text file
            modelBuilder.Entity<Medicine>().HasData(
                new Medicine
                {
                    MedicineId = 1,
                    MedicineType = "Flu and Fever",
                    MedicineName = "Tylenol",
                    Price = 10.0m,
                    StockQuantity = 100
                },
                new Medicine
                {
                    MedicineId = 2,
                    MedicineType = "Headaches",
                    MedicineName = "Advil",
                    Price = 13.0m,
                    StockQuantity = 29
                },
                new Medicine
                {
                    MedicineId = 3,
                    MedicineType = "Skin",
                    MedicineName = "Xylel",
                    Price = 15.0m,
                    StockQuantity = 120
                },
                new Medicine
                {
                    MedicineId = 4,
                    MedicineType = "Bones",
                    MedicineName = "CapB",
                    Price =30.0m,
                    StockQuantity = 130
                },
                new Medicine
                {
                    MedicineId = 5,
                    MedicineType = "Stomach Pain",
                    MedicineName = "Adderal",
                    Price = 12.0m,
                    StockQuantity = 340
                }

            );
        }
    }
}
