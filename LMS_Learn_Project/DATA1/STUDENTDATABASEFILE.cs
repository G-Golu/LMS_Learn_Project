using Microsoft.EntityFrameworkCore;

namespace LMS_Learn_Project.DATA1
{
    public class STUDENTDATABASEFILE : DbContext
    {
        public STUDENTDATABASEFILE(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Models.Student> Studentregistertbl { get; set; }
    }
}
