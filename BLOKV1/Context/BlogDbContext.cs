using BLOGV1.Models;
using BLOKV1.Models;
using Microsoft.EntityFrameworkCore;

namespace BLOKV1.Context
{
    public class BlogDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DOĞUKAN\\SQLEXPRESS;  database=BlogV1;Integrated Security=True; TrustServerCertificate=True; ");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Projects> Projects  { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<ProjectImages> ProjectImages { get; set; }

    }
}
