using Duende.IdentityServer.EntityFramework.Options;
using Hooks.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Hooks.Shared.Domain;

namespace Hooks.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        
        public DbSet<Photo> Photos { get; set; }
        
        public DbSet<Hooks.Shared.Domain.Like> Like { get; set; } = default!;
        
        public DbSet<Hooks.Shared.Domain.Location> Location { get; set; } = default!;
        
        public DbSet<Hooks.Shared.Domain.Match> Match { get; set; } = default!;
        
        public DbSet<Hooks.Shared.Domain.Message> Message { get; set; } = default!;
        
        public DbSet<Hooks.Shared.Domain.Preference> Preference { get; set; } = default!;
    }
}