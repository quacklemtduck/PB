/*namespace PB.Infrastructure
{
    class PBContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=PB.db");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}*/