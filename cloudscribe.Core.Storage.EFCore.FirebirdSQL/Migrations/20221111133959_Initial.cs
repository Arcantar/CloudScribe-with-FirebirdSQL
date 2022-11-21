using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cloudscribe.Core.Storage.EFCore.FirebirdSQL.Migrations;

public partial class Initial : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "cs_GeoCountry",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false)
                 .Annotation("FbSql:ValueGeneratedOnAdd", true),
                ISOCode2 = table.Column<string>(maxLength: 2, nullable: false),
                ISOCode3 = table.Column<string>(maxLength: 3, nullable: false),
                Name = table.Column<string>(maxLength: 255, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_cs_GeoCountry", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "cs_GeoZone",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false)
                    .Annotation("FbSql:ValueGeneratedOnAdd", true),
                Code = table.Column<string>(maxLength: 255, nullable: false),
                CountryId = table.Column<Guid>(nullable: false),
                Name = table.Column<string>(maxLength: 255, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_cs_GeoZone", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "cs_SiteHost",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false)
                    .Annotation("FbSql:ValueGeneratedOnAdd", true),
                HostName = table.Column<string>(maxLength: 255, nullable: false),
                SiteId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_cs_SiteHost", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "cs_Role",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false)
                    .Annotation("FbSql:ValueGeneratedOnAdd", true),
                NormalizedRoleName = table.Column<string>(maxLength: 50, nullable: false),
                RoleName = table.Column<string>(maxLength: 50, nullable: false),
                SiteId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_cs_Role", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "cs_Site",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false)
                    .Annotation("FbSql:ValueGeneratedOnAdd", true),
                AccountApprovalEmailCsv = table.Column<string>(nullable: true),
                AddThisDotComUsername = table.Column<string>(maxLength: 50, nullable: true),
                AliasId = table.Column<string>(maxLength: 36, nullable: true),
                AllowNewRegistration = table.Column<bool>(nullable: false),
                AllowPersistentLogin = table.Column<bool>(nullable: false),
                CaptchaOnLogin = table.Column<bool>(nullable: false),
                CaptchaOnRegistration = table.Column<bool>(nullable: false),
                CompanyCountry = table.Column<string>(maxLength: 10, nullable: true),
                CompanyFax = table.Column<string>(maxLength: 20, nullable: true),
                CompanyLocality = table.Column<string>(maxLength: 200, nullable: true),
                CompanyName = table.Column<string>(maxLength: 250, nullable: true),
                CompanyPhone = table.Column<string>(maxLength: 20, nullable: true),
                CompanyPostalCode = table.Column<string>(maxLength: 20, nullable: true),
                CompanyPublicEmail = table.Column<string>(maxLength: 100, nullable: true),
                CompanyRegion = table.Column<string>(maxLength: 200, nullable: true),
                CompanyStreetAddress = table.Column<string>(maxLength: 250, nullable: true),
                CompanyStreetAddress2 = table.Column<string>(maxLength: 250, nullable: true),
                ConcurrencyStamp = table.Column<string>(nullable: true),
                CreatedUtc = table.Column<DateTime>(nullable: false),
                DefaultEmailFromAddress = table.Column<string>(maxLength: 100, nullable: true),
                DefaultEmailFromAlias = table.Column<string>(maxLength: 100, nullable: true),
                DisableDbAuth = table.Column<bool>(nullable: false),
                DkimDomain = table.Column<string>(maxLength: 255, nullable: true),
                DkimPrivateKey = table.Column<string>(nullable: true),
                DkimPublicKey = table.Column<string>(nullable: true),
                DkimSelector = table.Column<string>(maxLength: 128, nullable: true),
                FacebookAppId = table.Column<string>(maxLength: 100, nullable: true),
                FacebookAppSecret = table.Column<string>(nullable: true),
                GoogleAnalyticsProfileId = table.Column<string>(maxLength: 25, nullable: true),
                GoogleClientId = table.Column<string>(maxLength: 100, nullable: true),
                GoogleClientSecret = table.Column<string>(nullable: true),
                IsDataProtected = table.Column<bool>(nullable: false),
                IsServerAdminSite = table.Column<bool>(nullable: false),
                LdapDomain = table.Column<string>(maxLength: 255, nullable: true),
                LdapPort = table.Column<int>(nullable: false),
                LdapRootDN = table.Column<string>(maxLength: 255, nullable: true),
                LdapServer = table.Column<string>(maxLength: 255, nullable: true),
                LdapUserDNKey = table.Column<string>(maxLength: 10, nullable: true),
                LoginInfoBottom = table.Column<string>(nullable: true),
                LoginInfoTop = table.Column<string>(nullable: true),
                MaxInvalidPasswordAttempts = table.Column<int>(nullable: false),
                MicrosoftClientId = table.Column<string>(maxLength: 100, nullable: true),
                MicrosoftClientSecret = table.Column<string>(nullable: true),
                MinRequiredPasswordLength = table.Column<int>(nullable: false),
                OidConnectAppId = table.Column<string>(maxLength: 255, nullable: true),
                OidConnectAppSecret = table.Column<string>(maxLength: 255, nullable: true),
                PreferredHostName = table.Column<string>(maxLength: 250, nullable: true),
                PrivacyPolicy = table.Column<string>(nullable: true),
                RecaptchaPrivateKey = table.Column<string>(maxLength: 255, nullable: true),
                RecaptchaPublicKey = table.Column<string>(maxLength: 255, nullable: true),
                RegistrationAgreement = table.Column<string>(nullable: true),
                RegistrationPreamble = table.Column<string>(nullable: true),
                RequireApprovalBeforeLogin = table.Column<bool>(nullable: false),
                RequireConfirmedEmail = table.Column<bool>(nullable: false),
                RequireConfirmedPhone = table.Column<bool>(nullable: false),
                RequiresQuestionAndAnswer = table.Column<bool>(nullable: false),
                SignEmailWithDkim = table.Column<bool>(nullable: false),
                SiteFolderName = table.Column<string>(maxLength: 50, nullable: true, defaultValue: "")
                    .Annotation("FbSql:ValueGeneratedOnAdd", true),
                SiteIsClosed = table.Column<bool>(nullable: false),
                SiteIsClosedMessage = table.Column<string>(nullable: true),
                SiteName = table.Column<string>(maxLength: 255, nullable: false),
                SmsClientId = table.Column<string>(maxLength: 255, nullable: true),
                SmsFrom = table.Column<string>(maxLength: 100, nullable: true),
                SmsSecureToken = table.Column<string>(nullable: true),
                SmtpPassword = table.Column<string>(nullable: true),
                SmtpPort = table.Column<int>(nullable: false),
                SmtpPreferredEncoding = table.Column<string>(maxLength: 20, nullable: true),
                SmtpRequiresAuth = table.Column<bool>(nullable: false),
                SmtpServer = table.Column<string>(maxLength: 200, nullable: true),
                SmtpUseSsl = table.Column<bool>(nullable: false),
                SmtpUser = table.Column<string>(maxLength: 500, nullable: true),
                Theme = table.Column<string>(maxLength: 100, nullable: true),
                TimeZoneId = table.Column<string>(maxLength: 50, nullable: true),
                TwitterConsumerKey = table.Column<string>(maxLength: 100, nullable: true),
                TwitterConsumerSecret = table.Column<string>(nullable: true),
                UseEmailForLogin = table.Column<bool>(nullable: false),
                UseInvisibleRecaptcha = table.Column<bool>(nullable: false),
                OidConnectAuthority = table.Column<string>(maxLength: 255, nullable: true),
                TermsUpdatedUtc = table.Column<DateTime>(nullable: false),
                OidConnectDisplayName = table.Column<string>(maxLength: 150, nullable: true),

                ForcedCulture = table.Column<string>(maxLength: 10, nullable: true),
                ForcedUICulture = table.Column<string>(maxLength: 10, nullable: true),

                PwdRequireDigit = table.Column<bool>(nullable: false),
                PwdRequireLowercase = table.Column<bool>(nullable: false),
                PwdRequireNonAlpha = table.Column<bool>(nullable: false),
                PwdRequireUppercase = table.Column<bool>(nullable: false),
                CompanyWebsite = table.Column<string>(maxLength: 255, nullable: true),
                EmailApiEndpoint = table.Column<string>(maxLength: 255, nullable: true),
                EmailApiKey = table.Column<string>(maxLength: 255, nullable: true),
                EmailSenderName = table.Column<string>(maxLength: 100, nullable: false, defaultValue: "SmtpMailSender"),
                RequireCookieConsent = table.Column<bool>(nullable: false, defaultValue: true),
                CookiePolicySummary = table.Column<string>(maxLength: 255, nullable: true),
                LastModifiedUtc = table.Column<DateTime>(nullable: false, defaultValue: "NOW"),
                FooterContent = table.Column<string>(nullable: true),
                HeaderContent = table.Column<string>(nullable: true),
                Require2FA = table.Column<bool>(nullable: false, defaultValue: false),
                ShowSiteNameLink = table.Column<bool>(nullable: false),
                LogoUrl = table.Column<string>(maxLength: 250, nullable: true),
                LdapUseSsl = table.Column<bool>(nullable: false, defaultValue: true),
                LdapUserDNFormat = table.Column<string>(maxLength: 100, nullable: true),
                OidConnectScopesCsv = table.Column<string>(maxLength: 100, nullable: true),
                SingleBrowserSessions = table.Column<bool>(nullable: false, defaultValue: false),          
                AllowUserToChangeEmail = table.Column<bool>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_cs_Site", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "cs_User",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false)
                    .Annotation("FbSql:ValueGeneratedOnAdd", true),
                AccessFailedCount = table.Column<int>(nullable: false),
                AccountApproved = table.Column<bool>(nullable: false),
                AuthorBio = table.Column<string>(nullable: true),
                AvatarUrl = table.Column<string>(maxLength: 255, nullable: true),
                CanAutoLockout = table.Column<bool>(nullable: false),
                Comment = table.Column<string>(nullable: true),
                CreatedUtc = table.Column<DateTime>(nullable: false),
                DateOfBirth = table.Column<DateTime>(nullable: true),
                DisplayInMemberList = table.Column<bool>(nullable: false),
                DisplayName = table.Column<string>(maxLength: 100, nullable: false),
                Email = table.Column<string>(maxLength: 100, nullable: true),
                EmailConfirmed = table.Column<bool>(nullable: false),
                FirstName = table.Column<string>(maxLength: 100, nullable: true),
                Gender = table.Column<string>(nullable: true),
                IsLockedOut = table.Column<bool>(nullable: false),
                LastLoginUtc = table.Column<DateTime>(nullable: true),
                LastModifiedUtc = table.Column<DateTime>(nullable: false),
                LastName = table.Column<string>(maxLength: 100, nullable: true),
                LastPasswordChangeUtc = table.Column<DateTime>(nullable: true),
                LockoutEndDateUtc = table.Column<DateTime>(nullable: true),
                MustChangePwd = table.Column<bool>(nullable: false),
                NewEmail = table.Column<string>(maxLength: 100, nullable: true),
                NewEmailApproved = table.Column<bool>(nullable: false),
                NormalizedEmail = table.Column<string>(maxLength: 100, nullable: true),
                NormalizedUserName = table.Column<string>(maxLength: 50, nullable: false),
                PasswordHash = table.Column<string>(nullable: true),
                PhoneNumber = table.Column<string>(maxLength: 50, nullable: true),
                PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                RolesChanged = table.Column<bool>(nullable: false),
                SecurityStamp = table.Column<string>(maxLength: 50, nullable: true),
                Signature = table.Column<string>(nullable: true),
                SiteId = table.Column<Guid>(nullable: false),
                TimeZoneId = table.Column<string>(maxLength: 50, nullable: true),
                TwoFactorEnabled = table.Column<bool>(nullable: false),
                UserName = table.Column<string>(maxLength: 50, nullable: false),
                WebSiteUrl = table.Column<string>(maxLength: 100, nullable: true),
                AgreementAcceptedUtc = table.Column<DateTime>(nullable: true),
                EmailConfirmSentUtc = table.Column<DateTime>(nullable: true),
                BrowserKey = table.Column<string>(maxLength: 50, nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_cs_User", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "cs_UserClaim",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false)
                    .Annotation("FbSql:ValueGeneratedOnAdd", true),
                ClaimType = table.Column<string>(maxLength: 255, nullable: true),
                ClaimValue = table.Column<string>(nullable: true),
                SiteId = table.Column<Guid>(nullable: false),
                UserId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_cs_UserClaim", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "cs_UserLocation",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false)
                    .Annotation("FbSql:ValueGeneratedOnAdd", true),
                CaptureCount = table.Column<int>(nullable: false),
                City = table.Column<string>(maxLength: 255, nullable: true),
                Continent = table.Column<string>(maxLength: 255, nullable: true),
                Country = table.Column<string>(maxLength: 255, nullable: true),
                FirstCaptureUtc = table.Column<DateTime>(nullable: false),
                HostName = table.Column<string>(maxLength: 255, nullable: true),
                IpAddress = table.Column<string>(maxLength: 50, nullable: true),
                IpAddressLong = table.Column<long>(nullable: false),
                Isp = table.Column<string>(maxLength: 255, nullable: true),
                LastCaptureUtc = table.Column<DateTime>(nullable: false),
                Latitude = table.Column<double>(nullable: false),
                Longitude = table.Column<double>(nullable: false),
                Region = table.Column<string>(maxLength: 255, nullable: true),
                SiteId = table.Column<Guid>(nullable: false),
                TimeZone = table.Column<string>(maxLength: 255, nullable: true),
                UserId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_cs_UserLocation", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "cs_UserLogin",
            columns: table => new
            {
                UserId = table.Column<Guid>(nullable: false),
                SiteId = table.Column<Guid>(nullable: false),
                LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                ProviderDisplayName = table.Column<string>(maxLength: 100, nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_cs_UserLogin", x => new { x.UserId, x.SiteId, x.LoginProvider, x.ProviderKey });
            });

        migrationBuilder.CreateTable(
            name: "cs_UserRole",
            columns: table => new
            {
                UserId = table.Column<Guid>(nullable: false),
                RoleId = table.Column<Guid>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_cs_UserRole", x => new { x.UserId, x.RoleId });
            });


        migrationBuilder.CreateTable(
           name: "cs_UserToken",
           columns: table => new
           {
               UserId = table.Column<Guid>( nullable: false),
               SiteId = table.Column<Guid>( nullable: false),
               LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
               Name = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: false),
               Value = table.Column<string>(type: "blob sub_type text", nullable: true)
           },
           constraints: table =>
           {
               table.PrimaryKey("PK_cs_UserToken", x => new { x.UserId, x.SiteId, x.LoginProvider, x.Name });
           });

        migrationBuilder.CreateIndex(
            name: "IX_cs_UserToken_SiteId",
            table: "cs_UserToken",
            column: "SiteId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_UserToken_UserId",
            table: "cs_UserToken",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_GeoCountry_ISOCode2",
            table: "cs_GeoCountry",
            column: "ISOCode2");

        migrationBuilder.CreateIndex(
            name: "IX_cs_GeoZone_Code",
            table: "cs_GeoZone",
            column: "Code");

        migrationBuilder.CreateIndex(
            name: "IX_cs_GeoZone_CountryId",
            table: "cs_GeoZone",
            column: "CountryId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_SiteHost_HostName",
            table: "cs_SiteHost",
            column: "HostName");

        migrationBuilder.CreateIndex(
            name: "IX_cs_SiteHost_SiteId",
            table: "cs_SiteHost",
            column: "SiteId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_Role_Id",
            table: "cs_Role",
            column: "Id",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_cs_Role_NormalizedRoleName",
            table: "cs_Role",
            column: "NormalizedRoleName");

        migrationBuilder.CreateIndex(
            name: "IX_cs_Role_SiteId",
            table: "cs_Role",
            column: "SiteId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_Site_AliasId",
            table: "cs_Site",
            column: "AliasId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_Site_SiteFolderName",
            table: "cs_Site",
            column: "SiteFolderName");

        migrationBuilder.CreateIndex(
            name: "IX_cs_User_DisplayName",
            table: "cs_User",
            column: "DisplayName");

        migrationBuilder.CreateIndex(
            name: "IX_cs_User_NormalizedEmail",
            table: "cs_User",
            column: "NormalizedEmail");

        migrationBuilder.CreateIndex(
            name: "IX_cs_User_NormalizedUserName",
            table: "cs_User",
            column: "NormalizedUserName");

        migrationBuilder.CreateIndex(
            name: "IX_cs_User_SiteId",
            table: "cs_User",
            column: "SiteId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_UserClaim_ClaimType",
            table: "cs_UserClaim",
            column: "ClaimType");

        migrationBuilder.CreateIndex(
            name: "IX_cs_UserClaim_SiteId",
            table: "cs_UserClaim",
            column: "SiteId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_UserClaim_UserId",
            table: "cs_UserClaim",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_UserLocation_IpAddress",
            table: "cs_UserLocation",
            column: "IpAddress");

        migrationBuilder.CreateIndex(
            name: "IX_cs_UserLocation_UserId",
            table: "cs_UserLocation",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_UserLogin_SiteId",
            table: "cs_UserLogin",
            column: "SiteId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_UserLogin_UserId",
            table: "cs_UserLogin",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_UserRole_RoleId",
            table: "cs_UserRole",
            column: "RoleId");

        migrationBuilder.CreateIndex(
            name: "IX_cs_UserRole_UserId",
            table: "cs_UserRole",
            column: "UserId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "cs_GeoCountry");

        migrationBuilder.DropTable(
            name: "cs_GeoZone");

        migrationBuilder.DropTable(
            name: "cs_SiteHost");

        migrationBuilder.DropTable(
            name: "cs_Role");

        migrationBuilder.DropTable(
            name: "cs_Site");

        migrationBuilder.DropTable(
            name: "cs_User");

        migrationBuilder.DropTable(
            name: "cs_UserClaim");

        migrationBuilder.DropTable(
            name: "cs_UserLocation");

        migrationBuilder.DropTable(
            name: "cs_UserLogin");

        migrationBuilder.DropTable(
            name: "cs_UserRole");

        migrationBuilder.DropTable(
           name: "cs_UserToken");
    }
}
