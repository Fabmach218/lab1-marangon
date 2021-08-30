using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace lab1_marangon.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<lab1_marangon.Models.VideoGame> DataVideoGame {get; set; }

    }
}