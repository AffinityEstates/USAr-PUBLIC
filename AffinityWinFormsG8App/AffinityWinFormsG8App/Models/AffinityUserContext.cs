/*
    Effective Date: January 1, 2023.

    Affinity and its subsidiaries and affiliates (collectively, “Affinity”, “us” or “we”) understand that your privacy is important to you. We are committed to respecting your privacy and protecting your personal data, which is any information that is capable of identifying you as an individual person. 
    This Privacy Policy describes how we handle and protect your personal data in connection with Affinity's business activities, like conferences and events, and client services, and on websites, applications, and communications that post a link 
    to this Privacy Policy (collectively, “the Sites”), in our capacity as data controllers.
 * */
using AffinityWinFormsG8App.Models;
using Microsoft.EntityFrameworkCore;

namespace AffinityWinFormsG8App.Models
{
    public class AffinityUserContext : DbContext
    {
        public DbSet<AffinityUser> AffinityUsers { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=affinity.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Employee" },
                new Category { CategoryId = 2, Name = "Contractor" },
                new Category { CategoryId = 3, Name = "Visitor" },
                new Category { CategoryId = 4, Name = "Admin" });

            modelBuilder.Entity<AffinityUser>().HasData(
                new AffinityUser { UserId = 1, CategoryId = 1, UserName = "Bob11" },
                new AffinityUser { UserId = 2, CategoryId = 1, UserName = "Brie1909" },
                new AffinityUser { UserId = 3, CategoryId = 1, UserName = "Stilton" },
                new AffinityUser { UserId = 4, CategoryId = 1, UserName = "Cheshire" },
                new AffinityUser { UserId = 5, CategoryId = 1, UserName = "Swiss" },
                new AffinityUser { UserId = 6, CategoryId = 1, UserName = "Gruyere" },
                new AffinityUser { UserId = 7, CategoryId = 1, UserName = "Colby" },
                new AffinityUser { UserId = 8, CategoryId = 1, UserName = "Mozzela" },
                new AffinityUser { UserId = 9, CategoryId = 1, UserName = "Ricotta" },
                new AffinityUser { UserId = 10, CategoryId = 1, UserName = "Parmesan" },
                new AffinityUser { UserId = 11, CategoryId = 2, UserName = "Ham" },
                new AffinityUser { UserId = 29, CategoryId = 3, UserName = "Malted" },
                new AffinityUser { UserId = 30, CategoryId = 3, UserName = "Sourdough" },
                new AffinityUser { UserId = 31, CategoryId = 3, UserName = "Corn" },
                new AffinityUser { UserId = 32, CategoryId = 3, UserName = "White22" },
                new AffinityUser { UserId = 33, CategoryId = 4, UserName = "Admin" });
        }
    }
}