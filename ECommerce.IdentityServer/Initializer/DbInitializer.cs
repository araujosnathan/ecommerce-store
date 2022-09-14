using System.Security.Claims;
using IdentityModel;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.IdentityServer.Initializer
{
    public class DbInitializer : IDbInitializer
    {
            private readonly MySQLContext _context;
            private readonly UserManager<ApplicationUser> _user;
            private readonly RoleManager<IdentityRole> _role;

            public DbInitializer(MySQLContext context,
                UserManager<ApplicationUser> user,
                RoleManager<IdentityRole> role)
            {
                _context = context;
                _user = user;
                _role = role;
            }

            public void Initialize()
            {
                if (_role.FindByNameAsync(IdentityConfiguration.Admin).Result != null) return;
                _role.CreateAsync(new IdentityRole(
                    IdentityConfiguration.Admin)).GetAwaiter().GetResult();
                _role.CreateAsync(new IdentityRole(
                    IdentityConfiguration.Client)).GetAwaiter().GetResult();

                ApplicationUser admin = new()
                {
                    UserName = "nathan-admin",
                    Email = "nathan-admin@gmail.com.",
                    EmailConfirmed = true,
                    PhoneNumber = "+55 (11) 99999-9999",
                    FirstName = "Nathan",
                    LastName = "Admin"
                };

                _user.CreateAsync(admin, "Admin123").GetAwaiter().GetResult();
                _user.AddToRoleAsync(admin,
                    IdentityConfiguration.Admin).GetAwaiter().GetResult();

                var adminClaims = _user.AddClaimsAsync(admin, new Claim[]
                {
                new Claim(JwtClaimTypes.Name, $"{admin.FirstName} {admin.LastName}"),
                new Claim(JwtClaimTypes.GivenName, admin.FirstName),
                new Claim(JwtClaimTypes.FamilyName, admin.LastName),
                new Claim(JwtClaimTypes.Role, IdentityConfiguration.Admin)
                }).Result;

                ApplicationUser client = new()
                {
                    UserName = "nathan-client",
                    Email = "nathan-client@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "+55 (11) 99999-9999",
                    FirstName = "Nathan",
                    LastName = "Client"
                };

                _user.CreateAsync(client, "Nathan123").GetAwaiter().GetResult();
                _user.AddToRoleAsync(client,
                    IdentityConfiguration.Client).GetAwaiter().GetResult();
                var clientClaims = _user.AddClaimsAsync(client, new Claim[]
                {
                new Claim(JwtClaimTypes.Name, $"{client.FirstName} {client.LastName}"),
                new Claim(JwtClaimTypes.GivenName, client.FirstName),
                new Claim(JwtClaimTypes.FamilyName, client.LastName),
                new Claim(JwtClaimTypes.Role, IdentityConfiguration.Client)
                }).Result;
            }
    }
}

