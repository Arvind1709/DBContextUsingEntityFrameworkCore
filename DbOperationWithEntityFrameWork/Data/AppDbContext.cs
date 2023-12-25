using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEntityFrameWork.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
    }
}
