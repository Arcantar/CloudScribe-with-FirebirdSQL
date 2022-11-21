// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:					Arcantar
// Created:					2022-11-10
// 

using cloudscribe.Logging.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace cloudscribe.Logging.EFCore.FirebirdSQL

{
    public class LoggingDbContext : LoggingDbContextBase, ILoggingDbContext
    {
        
        public LoggingDbContext(DbContextOptions<LoggingDbContext> options) : base(options)
        {
            // we don't want to track any logitems because we dont edit them
            // we add them delete them and view them
            //ChangeTracker.AutoDetectChangesEnabled = false;
      // Norpa V7      ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
              
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.HasSequence<int>("LogIds")
            //    .StartsAt(1)
            //    .IncrementsBy(1);

            modelBuilder.Entity<LogItem>(entity =>
            {
                entity.ToTable("cs_SystemLog");
                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
                //.ForMySQLHasColumnType("uniqueidentifier")
                //.ForSqlServerHasDefaultValueSql("newid()")
                   .IsRequired();
                
                entity.Property(p => p.LogDateUtc)
                .HasColumnName("LogDate")
                //.ForMySQLHasColumnType("datetime")
                //.ForSqlServerHasDefaultValueSql("getutcdate()")
                ;

                entity.Property(p => p.IpAddress)
                .HasMaxLength(50)
                ;

                entity.Property(p => p.Culture)
                .HasMaxLength(10)
                ;

                entity.Property(p => p.ShortUrl)
                .HasMaxLength(255)
                ;

                entity.Property(p => p.Thread)
                .HasMaxLength(255)
                ;

                entity.Property(p => p.LogLevel)
                .HasMaxLength(20)
                ;

                entity.Property(p => p.Logger)
                .HasMaxLength(255)
                ;

                //Url
                //Message
            });

            // should this be called before or after we do our thing?

            base.OnModelCreating(modelBuilder);

        }



#if DEBUG

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.AddInterceptors(new TaggedQueryCommandInterceptor());


        public class TaggedQueryCommandInterceptorContext : LoggingDbContext
        {
            private static readonly TaggedQueryCommandInterceptor _interceptor
                = new TaggedQueryCommandInterceptor();

            public TaggedQueryCommandInterceptorContext(DbContextOptions<LoggingDbContext> options) : base(options)
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

