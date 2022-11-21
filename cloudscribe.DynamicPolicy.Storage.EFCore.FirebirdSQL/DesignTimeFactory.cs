using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace cloudscribe.DynamicPolicy.Storage.EFCore.FirebirdSQL
{
    public class DesignTimeFactory : IDesignTimeDbContextFactory<DynamicPolicyDbContext>
    {
        public DynamicPolicyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DynamicPolicyDbContext>();
            var conn = "Server=yourserver;Database=yourdb;Uid=youruser;Pwd=yourpassword;Charset=utf8;";
            builder.UseFirebird(conn
                //, o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
                );
            return new DynamicPolicyDbContext(builder.Options);
        }
    }
}
