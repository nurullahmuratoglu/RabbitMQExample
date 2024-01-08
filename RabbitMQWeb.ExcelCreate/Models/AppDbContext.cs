using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace RabbitMQWeb.ExcelCreate.Models
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UserFile> UserFiles { get; set; }


        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //    //builder.Entity<IdentityUserLogin<string>>().HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId });

        //    builder.Entity<IdentityUser>().HasData(
        //       new IdentityUser()
        //       {
        //           Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
        //           UserName = "deneme",
        //           NormalizedUserName = "DENEME",
        //           Email = "deneme@gmail.com",
        //           NormalizedEmail = "DENEME@GMAİL.COM",
        //           EmailConfirmed = true,
        //           PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "G4m3rpr0+")
        //       },
        //       new IdentityUser()
        //       {
        //           Id = "1689e75d-6c66-4eef-917d-73109d6b207d",
        //           UserName = "deneme2",
        //           NormalizedUserName = "DENEME2",
        //           Email = "deneme2@gmail.com",
        //           NormalizedEmail = "DENEME2@GMAİL.COM",
        //           EmailConfirmed = true,
        //           PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "G4m3rpr0+")
        //       }


        //        );

        //    base.OnModelCreating( builder );
        //}

    }
}
