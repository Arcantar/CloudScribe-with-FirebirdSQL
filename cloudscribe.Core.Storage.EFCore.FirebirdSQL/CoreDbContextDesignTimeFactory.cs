using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace cloudscribe.Core.Storage.EFCore.FirebirdSQL;

public class CoreDbContextDesignTimeFactory : IDesignTimeDbContextFactory<CoreDbContext>
{
    public CoreDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<CoreDbContext>();

        var connString = "Server=yourserver;Database=yourdb;Uid=sysdba;Pwd=masterkey;Charset=utf8;";

        
        builder.UseFirebird(connString,
            o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));//, ServerVersion.AutoDetect(connString));


        return new CoreDbContext(builder.Options);
    }
}
