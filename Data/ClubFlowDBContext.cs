using ClubFlow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ClubFlow.Data
{
    public class ClubFlowDBContext : DbContext
    {
        public ClubFlowDBContext(DbContextOptions<ClubFlowDBContext> options) : base(options) { 
        }

        public DbSet<Club> tb_clubs { get; set; }
        public DbSet<User> tb_users { get; set; }

        public DbSet<Member> tb_members { get; set; }


    }
}
