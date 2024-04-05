using Microsoft.EntityFrameworkCore;

namespace Gtm_Mgt_Demo.Models
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
        {
        }

        // Remove OnConfiguring method override

        public DbSet<GymTrainee> Trainees { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<TrainingLevel> TrainingLevels { get; set; }
        public DbSet<MonthlyFeeVoucher> MonthlyFeeVouchers { get; set; }
    }
}

