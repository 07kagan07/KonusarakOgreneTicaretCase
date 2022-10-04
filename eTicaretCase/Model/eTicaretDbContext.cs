using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eTicaretCase.Model
{
    public class eTicaretDbContext : IdentityDbContext
    {
        public eTicaretDbContext(DbContextOptions<eTicaretDbContext> options) : base(options) { }
    }
}
