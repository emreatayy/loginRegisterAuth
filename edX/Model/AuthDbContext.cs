using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace edX.Model
{
    public class AuthDbContext:IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options): base(options) 
        { 
        
        }
    }
}
