namespace DataLayer.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbContext : System.Data.Entity.DbContext
    {
        public DbContext()
            : base("name=DbContext")
        {
        }
        public DbContext(string connectionString): base(connectionString) { }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Library> Library { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        public class DbContextInitializer : DropCreateDatabaseAlways<DbContext>
        {
            protected override void Seed(DbContext context)
            {
                context.Authors.Add(new Entities.Authors { Id = 1, FirstName = "John", LastName = "Doe" });
                context.Authors.Add(new Entities.Authors { Id = 2, FirstName = "Colin", LastName = "Coles" });
                base.Seed(context);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Authors>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Authors>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Authors)
                .HasForeignKey(e => e.AuthorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Books>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Books>()
                .HasMany(e => e.Library)
                .WithRequired(e => e.Books)
                .HasForeignKey(e => e.BookID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Books>()
                .HasMany(e => e.Library1)
                .WithRequired(e => e.Books1)
                .HasForeignKey(e => e.BookID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Library)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Library1)
                .WithRequired(e => e.Users1)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);
        }
    }
}
