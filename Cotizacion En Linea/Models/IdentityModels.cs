using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Cotizacion_En_Linea.Models
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class MyUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<MyUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class MyLogin : IdentityUserLogin {}
    
    public class MyRole : IdentityRole {}

    public class MyClaim : IdentityUserClaim { }

    public class MyUserRole : IdentityUserRole { }

    public class ApplicationDbContext : IdentityDbContext<MyUser>
    {
        public ApplicationDbContext()
            : base("CotizacionEnLineaEntities", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<MyUser>().ToTable("Users");
            modelBuilder.Entity<MyUserRole>().ToTable("AspNetUserRoles");
            modelBuilder.Entity<MyRole>().ToTable("AspNetRoles");
            modelBuilder.Entity<MyClaim>().ToTable("AspNetClaims");
            modelBuilder.Entity<MyLogin>().ToTable("AspNetLogins");

        }
    }
}