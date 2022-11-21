﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
//	Author:                 Arcantar
//  Created:			    2022-11-10
// 

using cloudscribe.Core.Models;
using cloudscribe.Core.Models.Geography;
using cloudscribe.Core.Storage.EFCore.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace cloudscribe.Core.Storage.EFCore.FirebirdSQL
{
    public class CoreDbContext : CoreDbContextBase, ICoreDbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {

        }

        protected CoreDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var tableNames = new CoreTableNames();

            modelBuilder.Entity<SiteSettings>(entity =>
            {

                entity.ToTable(tableNames.TablePrefix + tableNames.SiteTableName);

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id);

                entity.Property(p => p.AliasId)
                .HasMaxLength(36)
                ;

                entity.HasIndex(p => p.AliasId);

                entity.Property(p => p.SiteName)
                .HasMaxLength(255)
                .IsRequired();

                entity.Property(p => p.Theme)
                .HasMaxLength(100);

                entity.Property(p => p.AllowNewRegistration)
                .IsRequired()
                ;

                entity.Property(p => p.RequireConfirmedEmail)
                .IsRequired()
                ;

                entity.Property(p => p.RequireConfirmedPhone)
                .IsRequired()
                ;

                entity.Property(p => p.IsServerAdminSite)
                .IsRequired()
                ;


                entity.Property(p => p.LdapServer)
                .HasMaxLength(255);
                ;

                entity.Property(p => p.LdapPort)
                ;

                entity.Property(p => p.LdapDomain)
                .HasMaxLength(255);
                ;

                entity.Property(p => p.LdapRootDN)
                .HasMaxLength(255);
                ;

                entity.Property(p => p.LdapUserDNFormat)
               .HasMaxLength(100);


                entity.Property(p => p.LdapUserDNKey)
                .HasMaxLength(10);
                ;

                entity.Property(p => p.UseEmailForLogin)
                .IsRequired()
                ;

                entity.Property(p => p.AllowUserToChangeEmail)
                .IsRequired()
                ;

                entity.Property(p => p.RequiresQuestionAndAnswer)
                .IsRequired()
                ;

                entity.Property(p => p.MaxInvalidPasswordAttempts)
                ;


                entity.Property(p => p.MinRequiredPasswordLength)
                ;

                entity.Property(p => p.DefaultEmailFromAddress)
                .HasMaxLength(100);
                ;

                entity.Property(p => p.DefaultEmailFromAlias)
                .HasMaxLength(100);
                ;

                entity.Property(p => p.RecaptchaPrivateKey)
                .HasMaxLength(255);
                ;

                entity.Property(p => p.RecaptchaPublicKey)
                .HasMaxLength(255);
                ;

                entity.Property(p => p.UseInvisibleRecaptcha)
               .IsRequired()
               ;

                entity.Property(p => p.DisableDbAuth)
                .IsRequired()
                ;

                entity.Property(p => p.RequireApprovalBeforeLogin)
                .IsRequired()
                ;

                entity.Property(p => p.AllowPersistentLogin)
                .IsRequired()
                ;

                entity.Property(p => p.CaptchaOnLogin)
                .IsRequired()
                ;

                entity.Property(p => p.CaptchaOnRegistration)
                .IsRequired()
                ;

                entity.Property(p => p.SiteIsClosed)
                .IsRequired()
                ;

                //not mapped should map to nvarchar(max) by default I think
                // SiteIsClosedMessage 
                // PrivacyPolicy

                entity.Property(p => p.TimeZoneId)
                .HasMaxLength(50);
                ;

                entity.Property(p => p.GoogleAnalyticsProfileId)
                .HasMaxLength(25);
                ;

                entity.Property(p => p.CompanyName)
                .HasMaxLength(250);
                ;

                entity.Property(p => p.CompanyStreetAddress)
                .HasMaxLength(250);
                ;

                entity.Property(p => p.CompanyStreetAddress2)
                .HasMaxLength(250);
                ;

                entity.Property(p => p.CompanyRegion)
                .HasMaxLength(200);
                ;

                entity.Property(p => p.CompanyLocality)
                .HasMaxLength(200);
                ;

                entity.Property(p => p.CompanyCountry)
                .HasMaxLength(10);
                ;

                entity.Property(p => p.CompanyPostalCode)
                .HasMaxLength(20);
                ;

                entity.Property(p => p.CompanyPublicEmail)
                .HasMaxLength(100);
                ;

                entity.Property(p => p.CompanyWebsite)
                .HasMaxLength(255);
                ;

                entity.Property(p => p.CompanyPhone)
                .HasMaxLength(20);
                ;

                entity.Property(p => p.CompanyFax)
                .HasMaxLength(20);
                ;

                entity.Property(p => p.FacebookAppId)
                .HasMaxLength(100);
                ;

                entity.Property(p => p.FacebookAppSecret)
                ;

                entity.Property(p => p.GoogleClientId)
                .HasMaxLength(100);
                ;

                entity.Property(p => p.GoogleClientSecret)
                ;

                entity.Property(p => p.TwitterConsumerKey)
                .HasMaxLength(100);
                ;

                entity.Property(p => p.TwitterConsumerSecret)
                ;

                entity.Property(p => p.MicrosoftClientId)
                .HasMaxLength(100);
                ;

                entity.Property(p => p.MicrosoftClientSecret)
                ;

                entity.Property(p => p.OidConnectAppId)
               .HasMaxLength(255);
                ;

                entity.Property(p => p.OidConnectAppSecret)
               .HasMaxLength(255);
                ;

                entity.Property(p => p.OidConnectAuthority)
               .HasMaxLength(255);
                ;

                entity.Property(p => p.OidConnectDisplayName)
               .HasMaxLength(150);
                ;

                entity.Property(p => p.PreferredHostName)
                .HasMaxLength(250);
                ;

                entity.Property(p => p.SiteFolderName)
                .HasMaxLength(50)
                .HasDefaultValue(string.Empty)
                ;

                entity.HasIndex(p => p.SiteFolderName);

                entity.Property(p => p.AddThisDotComUsername)
                .HasMaxLength(50);
                ;

                //not mapped should map to ntext by default I think
                // LoginInfoTop 
                // LoginInfoBottom
                // RegistrationAgreement
                // RegistrationPreamble

                entity.Property(p => p.SmtpServer)
                .HasMaxLength(200);
                ;

                entity.Property(p => p.SmtpPort)
                ;

                entity.Property(p => p.SmtpUser)
                .HasMaxLength(500); // large so it can be encrypted
                ;

                entity.Property(p => p.SmtpPassword)
                ;

                entity.Property(p => p.SmtpPreferredEncoding)
                .HasMaxLength(20);
                ;

                entity.Property(p => p.SmtpRequiresAuth)
                .IsRequired()
                ;

                entity.Property(p => p.SmtpUseSsl)
                .IsRequired()
                ;

                entity.Property(p => p.DkimDomain)
                .HasMaxLength(255);
                ;

                entity.Property(p => p.DkimSelector)
                .HasMaxLength(128);
                ;

                entity.Property(p => p.SignEmailWithDkim)
                .IsRequired()
                ;

                entity.Property(p => p.SmsClientId)
                .HasMaxLength(255);
                ;

                entity.Property(p => p.SmsFrom)
                .HasMaxLength(100);
                ;

                entity.Property(p => p.IsDataProtected)
                .IsRequired()
                ;

                entity.Property(p => p.CreatedUtc)
                ;

                entity.Property(p => p.ForcedCulture)
                .HasMaxLength(10);
                ;

                entity.Property(p => p.ForcedUICulture)
                .HasMaxLength(10);
                ;

                entity.Property(p => p.PwdRequireNonAlpha)
                .IsRequired()
                // .HasDefaultValue(true)
                ;
                entity.Property(p => p.PwdRequireLowercase)
                .IsRequired()
                // .HasDefaultValue(true)
                ;
                entity.Property(p => p.PwdRequireUppercase)
                .IsRequired()
                // .HasDefaultValue(true)
                ;
                entity.Property(p => p.PwdRequireDigit)
                .IsRequired()
                // .HasDefaultValue(true)
                ;

                entity.Property(p => p.EmailSenderName)
                .HasMaxLength(100)
                .IsRequired()
                .HasDefaultValue("SmtpMailSender")
                ;

                entity.Property(p => p.CookiePolicySummary).HasMaxLength(255);

                entity.Property(p => p.ShowSiteNameLink);

                entity.Property(p => p.LogoUrl)
               .HasMaxLength(250);
                ;

            });

            modelBuilder.Entity<SiteHost>(entity =>
            {
                entity.ToTable(tableNames.TablePrefix + tableNames.SiteHostTableName);

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
               ;

                entity.Property(p => p.SiteId)
                .IsRequired()
                ;
                entity.HasIndex(p => p.SiteId);

                entity.Property(p => p.HostName)
                .IsRequired()
                .HasMaxLength(255);
                ;

                entity.HasIndex(p => p.HostName);
            });

            modelBuilder.Entity<SiteUser>(entity =>
            {
                entity.ToTable(tableNames.TablePrefix + tableNames.UserTableName);

                entity.Property(p => p.Id)
                   .IsRequired()
                   ;

                entity.HasKey(p => p.Id);

                entity.Property(p => p.SiteId)
                    .IsRequired()
                    ;

                entity.HasIndex(p => p.SiteId);

                entity.Property(p => p.AccountApproved)
                .IsRequired()
                ;

                entity.Property(p => p.DisplayInMemberList)
                .IsRequired()
                ;

                entity.Property(p => p.Email)
                 //.IsRequired() 2019-03-01 need to allow initial null value for ldap auth and other scenarios, site rules middleware will force the user to provide an email
                 .HasMaxLength(100)
                 ;

                entity.Property(p => p.NormalizedEmail)
                // .IsRequired()
                .HasMaxLength(100)
                ;

                entity.Property(p => p.NewEmail)
                .HasMaxLength(100)
                ;

                entity.HasIndex(p => p.NormalizedEmail);

                entity.Property(p => p.UserName)
                .IsRequired()
                .HasMaxLength(50)
                ;

                entity.Property(p => p.NormalizedUserName)
                .IsRequired()
                .HasMaxLength(50)
                ;
                entity.HasIndex(p => p.NormalizedUserName);

                entity.Property(p => p.DisplayName)
                .IsRequired()
                .HasMaxLength(100);

                entity.HasIndex(p => p.DisplayName);

                entity.Property(p => p.FirstName)
                .HasMaxLength(100);

                entity.Property(p => p.LastName)
                .HasMaxLength(100);

                entity.Property(p => p.EmailConfirmed)
                .IsRequired()
                ;

                //entity.Property(p => p.IsDeleted)
                //.IsRequired()
                //;

                entity.Property(p => p.IsLockedOut)
                .IsRequired()
                ;

                entity.Property(p => p.MustChangePwd)
                .IsRequired()
                ;

                entity.Property(p => p.NewEmailApproved)
                .IsRequired()
                ;

                entity.Property(p => p.RolesChanged)
                .IsRequired()
                ;

                entity.Property(p => p.TwoFactorEnabled)
                .IsRequired()
                ;

                entity.Property(p => p.PhoneNumber)
               .HasMaxLength(50)
               ;

                entity.Property(p => p.PhoneNumberConfirmed)
                .IsRequired()
                ;

                entity.Property(p => p.CanAutoLockout)
                .IsRequired()
                ;

                entity.Property(p => p.AvatarUrl)
                .HasMaxLength(255)
                ;

                entity.Property(p => p.WebSiteUrl)
                .HasMaxLength(100)
                ;

                entity.Property(p => p.SecurityStamp)
                .HasMaxLength(50)
                ;

                entity.Property(p => p.TimeZoneId)
                .HasMaxLength(50)
                ;

                entity.Property(p => p.BrowserKey)
                .HasMaxLength(50)
                ;

            });

            modelBuilder.Entity<SiteRole>(entity =>
            {
                entity.Ignore(x => x.MemberCount);

                entity.ToTable(tableNames.TablePrefix + tableNames.RoleTableName);

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
                   .IsRequired()
                   ;

                entity.HasIndex(p => p.Id)
                .IsUnique();

                entity.Property(p => p.SiteId)
                   .IsRequired()
                   ;

                entity.HasIndex(p => p.SiteId);

                entity.Property(p => p.NormalizedRoleName)
                .IsRequired()
                .HasMaxLength(50);
                ;

                entity.HasIndex(p => p.NormalizedRoleName);

                entity.Property(p => p.RoleName)
                .IsRequired()
                .HasMaxLength(50);
                ;


            });

            modelBuilder.Entity<UserClaim>(entity =>
            {
                entity.ToTable(tableNames.TablePrefix + tableNames.UserClaimTableName);

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
                   .IsRequired()
                ;

                entity.Property(p => p.UserId)
                .IsRequired()
                ;

                entity.HasIndex(p => p.UserId);

                entity.Property(p => p.SiteId)
                 .IsRequired()
                 ;

                entity.HasIndex(p => p.SiteId);

                entity.Property(p => p.ClaimType)
                .HasMaxLength(255)
                ;

                entity.HasIndex(p => p.ClaimType);
                // should we limit claim value?



                // not mapped will result in nvarchar(max) I think
                //ClaimType
                //ClaimValue
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable(tableNames.TablePrefix + tableNames.UserLoginTableName);


                entity.HasKey(p => new { p.UserId, p.SiteId, p.LoginProvider, p.ProviderKey });

                entity.Property(p => p.LoginProvider)
                .HasMaxLength(128)
                ;

                entity.Property(p => p.ProviderKey)
                .HasMaxLength(128)
                ;

                entity.Property(p => p.UserId)
                .IsRequired()
                ;

                entity.HasIndex(p => p.UserId);

                entity.Property(p => p.SiteId)
                .IsRequired()
                ;

                entity.HasIndex(p => p.SiteId);

                entity.Property(p => p.ProviderDisplayName)
                .HasMaxLength(100)
                ;
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.ToTable(tableNames.TablePrefix + tableNames.UserTokenTableName);

                entity.HasKey(p => new { p.UserId, p.SiteId, p.LoginProvider, p.Name });

                entity.Property(p => p.LoginProvider).HasMaxLength(128);

                entity.Property(p => p.Name).HasMaxLength(450);

                entity.Property(p => p.UserId).IsRequired();

                entity.HasIndex(p => p.UserId);

                entity.Property(p => p.SiteId).IsRequired();

                entity.HasIndex(p => p.SiteId);

                entity.Property(p => p.Value);

            });

            modelBuilder.Entity<GeoCountry>(entity =>
            {
                entity.ToTable(tableNames.TablePrefix + tableNames.GeoCountryTableName);

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
                   .IsRequired()
                   ;

                entity.Property(p => p.Name)
                .HasMaxLength(255)
                .IsRequired()
                ;

                entity.Property(p => p.ISOCode2)
                .HasMaxLength(2)
                .IsRequired()
                ;

                entity.HasIndex(p => p.ISOCode2);

                entity.Property(p => p.ISOCode3)
                .HasMaxLength(3)
                .IsRequired()
                ;
            });

            modelBuilder.Entity<GeoZone>(entity =>
            {
                entity.ToTable(tableNames.TablePrefix + tableNames.GeoZoneTableName);

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
                   .IsRequired()
                   ;

                entity.Property(p => p.CountryId)
                   .IsRequired()
                   ;

                entity.HasIndex(p => p.CountryId);

                entity.Property(p => p.Name)
                .HasMaxLength(255)
                .IsRequired()
                ;

                entity.Property(p => p.Code)
                .HasMaxLength(255)
                .IsRequired()
                ;

                entity.HasIndex(p => p.Code);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable(tableNames.TablePrefix + tableNames.UserRoleTableName);

                entity.Property(p => p.UserId)
                ;
                entity.HasIndex(p => p.UserId);

                entity.Property(p => p.RoleId)
                ;
                entity.HasIndex(p => p.RoleId);

                entity.HasKey(p => new { p.UserId, p.RoleId });
            });

            modelBuilder.Entity<UserLocation>(entity =>
            {
                entity.ToTable(tableNames.TablePrefix + tableNames.UserLocationTableName);

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
               ;

                entity.Property(p => p.UserId)
                ;

                entity.Property(p => p.SiteId)
                ;

                entity.Property(p => p.IpAddress)
                    .HasMaxLength(50)
                 ;

                entity.HasIndex(p => p.IpAddress);

                entity.Property(p => p.IpAddressLong)
                 ;

                entity.Property(p => p.Isp)
                    .HasMaxLength(255)
                 ;

                entity.Property(p => p.Continent)
                    .HasMaxLength(255)
                 ;

                entity.Property(p => p.Country)
                    .HasMaxLength(255)
                 ;

                entity.Property(p => p.Region)
                    .HasMaxLength(255)
                 ;

                entity.Property(p => p.City)
                    .HasMaxLength(255)
                 ;

                entity.Property(p => p.TimeZone)
                    .HasMaxLength(255)
                 ;

                entity.Property(p => p.FirstCaptureUtc)
                ;

                entity.Property(p => p.LastCaptureUtc)
                ;

                entity.Property(p => p.Latitude)
                ;

                entity.Property(p => p.Longitude)
                ;

                entity.Property(p => p.HostName)
                    .HasMaxLength(255)
                 ;

                entity.HasIndex(p => p.UserId);

                // goode idea or not?
                //entity.HasIndex(p => p.Latitude);
                //entity.HasIndex(p => p.Longitude);
            });



        }




#if DEBUG

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.AddInterceptors(new TaggedQueryCommandInterceptor());


        public class TaggedQueryCommandInterceptorContext : CoreDbContext
        {
            private static readonly TaggedQueryCommandInterceptor _interceptor
                = new TaggedQueryCommandInterceptor();

            public TaggedQueryCommandInterceptorContext(DbContextOptions<CoreDbContext> options) : base(options)
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