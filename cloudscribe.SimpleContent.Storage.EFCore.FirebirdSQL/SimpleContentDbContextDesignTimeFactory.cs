using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace cloudscribe.SimpleContent.Storage.EFCore.FirebirdSQL
{
    public class SimpleContentDbContextDesignTimeFactory : IDesignTimeDbContextFactory<SimpleContentDbContext>
    {
        public SimpleContentDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SimpleContentDbContext>();
            var conn = "Server=yourserver;Database=yourdb;Uid=youruser;Pwd=yourpassword;Charset=utf8;";
            builder.UseFirebird(conn
               // , o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
                );

            return new SimpleContentDbContext(builder.Options);
        }
    }
}
