using Microsoft.EntityFrameworkCore;

namespace AllatboltProject.Backend.Context
{
    public class AllatboltInMemoryContext : AllatboltContext
    {
        public AllatboltInMemoryContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

    }
}
