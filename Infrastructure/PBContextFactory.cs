namespace PB.Infrastructure
{
    class PBContextFactory : IDesignTimeDbContextFactory<PBContext>
    {
        public PBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PBContext>();
            optionsBuilder.UseSqlite("Data Source=PB.db");

            return new PBContext(optionsBuilder.Options);
        }
    }
}