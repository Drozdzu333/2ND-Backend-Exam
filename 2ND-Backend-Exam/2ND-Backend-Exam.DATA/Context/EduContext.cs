namespace _2ND_Backend_Exam.DATA.Context
{
    public class EduContext : DbContext
    {
        public EduContext(DbContextOptions options) : base(options) {}

        public DbSet<Author> Authors { get; set; }
        public DbSet<EduMaterial> EduMaterials { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EduMaterial>()
                .Property(a => a.PublicationDate)
                .HasColumnType("date");
            builder.RunSeeder();
        }

    }
}
