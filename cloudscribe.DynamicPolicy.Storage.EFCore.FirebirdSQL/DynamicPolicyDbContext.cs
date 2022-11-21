using cloudscribe.DynamicPolicy.Storage.EFCore.Common;
using cloudscribe.DynamicPolicy.Storage.EFCore.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace cloudscribe.DynamicPolicy.Storage.EFCore.FirebirdSQL
{
    public class DynamicPolicyDbContext : DynamicPolicyDbContextBase, IDynamicPolicyDbContext
    {
        public DynamicPolicyDbContext(
            DbContextOptions<DynamicPolicyDbContext> options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AuthorizationPolicyEntity>(entity =>
            {
                entity.ToTable("csp_AuthPolicy").HasKey(x => x.Id);

                entity.Property(x => x.TenantId).IsRequired();//.HasMaxLength(36).IsRequired();
                entity.HasIndex(x => x.TenantId);

                entity.Property(x => x.Name).HasMaxLength(200);
                entity.HasIndex(x => new { x.Name, x.TenantId }).IsUnique();

                entity.HasMany(x => x.AllowedRoles).WithOne(x => x.Policy).IsRequired().OnDelete(DeleteBehavior.Cascade);
                entity.HasMany(x => x.AuthenticationSchemes).WithOne(x => x.Policy).IsRequired().OnDelete(DeleteBehavior.Cascade);
                entity.HasMany(x => x.RequiredClaims).WithOne(x => x.Policy).IsRequired().OnDelete(DeleteBehavior.Cascade);

            });

            modelBuilder.Entity<AllowedRoleEntity>(entity =>
            {
                entity.ToTable("csp_AuthPolicyRole").HasKey(x => x.Id);
                entity.Property(x => x.AllowedRole).HasMaxLength(200).IsRequired();
            });

            modelBuilder.Entity<AuthenticationSchemeEntity>(entity =>
            {
                entity.ToTable("csp_AuthPolicyScheme").HasKey(x => x.Id);
                entity.Property(x => x.AuthenticationScheme).HasMaxLength(255).IsRequired();
            });

            modelBuilder.Entity<ClaimRequirementEntity>(entity =>
            {
                entity.ToTable("csp_AuthPolicyClaim").HasKey(x => x.Id);
                entity.Property(x => x.ClaimName).HasMaxLength(255).IsRequired();
                entity.HasMany(x => x.AllowedValues).WithOne(x => x.ClaimRequirement).IsRequired().OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AllowedClaimValueEntity>(entity =>
            {
                entity.ToTable("csp_AuthPolicyClaimValue").HasKey(x => x.Id);
                entity.Property(x => x.AllowedValue).HasMaxLength(255).IsRequired();

            });

        }



#if DEBUG

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.AddInterceptors(new TaggedQueryCommandInterceptor());


        public class TaggedQueryCommandInterceptorContext : DynamicPolicyDbContext
        {
            private static readonly TaggedQueryCommandInterceptor _interceptor
                = new TaggedQueryCommandInterceptor();

            public TaggedQueryCommandInterceptorContext(DbContextOptions<DynamicPolicyDbContext> options) : base(options)
            {
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.AddInterceptors(_interceptor);
        }
    }
    public class TaggedQueryCommandInterceptor : DbCommandInterceptor
    {
        public override InterceptionResult<DbDataReader> ReaderExecuting(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<DbDataReader> result)
        {
            ManipulateCommand(command);

            return result;
        }

        public override ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<DbDataReader> result,
            CancellationToken cancellationToken = default)
        {
            ManipulateCommand(command);

            return new ValueTask<InterceptionResult<DbDataReader>>(result);
        }

        private static void ManipulateCommand(DbCommand command)
        {
            // if (command.CommandText.StartsWith("-- Use hint: robust plan", StringComparison.Ordinal))
            // {
            //     command.CommandText += " OPTION (ROBUST PLAN)";
            // }
            Console.WriteLine(command.CommandText);
            if (command.Parameters is not null)
            {
                //foreach (var parameter in command.Parameters.AsQueryable())
                for (int i = command.Parameters.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(command.Parameters[i].ParameterName.ToString()
                    + " = "
                    + command.Parameters[i].Value.ToString());
                }
            }
            Console.WriteLine("       ---------------               ");
        }
#endif

    }
}
