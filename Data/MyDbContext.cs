using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationWithNET8.Data
{
    public class MyDbContext(DbContextOptions<MyDbContext> options) : IdentityDbContext(options)
    {
    }
}
