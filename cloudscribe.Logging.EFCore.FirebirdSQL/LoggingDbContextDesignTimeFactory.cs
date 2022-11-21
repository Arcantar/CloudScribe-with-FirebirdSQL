using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace cloudscribe.Logging.EFCore.FirebirdSQL
{
    public class LoggingDbContextDesignTimeFactory : IDesignTimeDbContextFactory<LoggingDbContext>
    {
        public LoggingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LoggingDbContext>();
            var conn = "Server=yourserver;Database=yourdb;Uid=youruser;Pwd=yourpassword;Charset=utf8;";
        builder.UseFirebird(conn
            //, o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
            );

            return new LoggingDbContext(builder.Options);
        }
    }
}
