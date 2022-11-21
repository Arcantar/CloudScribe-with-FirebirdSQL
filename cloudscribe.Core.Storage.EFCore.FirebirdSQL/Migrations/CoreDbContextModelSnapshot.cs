﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cloudscribe.Core.Storage.EFCore.FirebirdSQL;

namespace cloudscribe.Core.Storage.EFCore.FirebirdSQL.Migrations;

[DbContext(typeof(CoreDbContext))]
partial class CoreDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "3.1.0")
            .HasAnnotation("Relational:MaxIdentifierLength", 64);

        modelBuilder.Entity("cloudscribe.Core.Models.Geography.GeoCountry", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<string>("ISOCode2")
                    .IsRequired()
                    .HasColumnType("varchar(2) CHARACTER SET UTF8")
                    .HasMaxLength(2);

                b.Property<string>("ISOCode3")
                    .IsRequired()
                    .HasColumnType("varchar(3) CHARACTER SET UTF8")
                    .HasMaxLength(3);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.HasKey("Id");

                b.HasIndex("ISOCode2");

                b.ToTable("cs_GeoCountry");
            });

        modelBuilder.Entity("cloudscribe.Core.Models.Geography.GeoZone", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<string>("Code")
                    .IsRequired()
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<Guid>("CountryId")
                    .HasColumnType("char(36)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.HasKey("Id");

                b.HasIndex("Code");

                b.HasIndex("CountryId");

                b.ToTable("cs_GeoZone");
            });

        modelBuilder.Entity("cloudscribe.Core.Models.SiteHost", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<string>("HostName")
                    .IsRequired()
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<Guid>("SiteId")
                    .HasColumnType("char(36)");

                b.HasKey("Id");

                b.HasIndex("HostName");

                b.HasIndex("SiteId");

                b.ToTable("cs_SiteHost");
            });

        modelBuilder.Entity("cloudscribe.Core.Models.SiteRole", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<string>("NormalizedRoleName")
                    .IsRequired()
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50);

                b.Property<string>("RoleName")
                    .IsRequired()
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50);

                b.Property<Guid>("SiteId")
                    .HasColumnType("char(36)");

                b.HasKey("Id");

                b.HasIndex("Id")
                    .IsUnique();

                b.HasIndex("NormalizedRoleName");

                b.HasIndex("SiteId");

                b.ToTable("cs_Role");
            });

        modelBuilder.Entity("cloudscribe.Core.Models.SiteSettings", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<string>("AccountApprovalEmailCsv")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("AddThisDotComUsername")
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50);

                b.Property<string>("AliasId")
                    .HasColumnType("varchar(36) CHARACTER SET UTF8")
                    .HasMaxLength(36);

                b.Property<bool>("AllowNewRegistration")
                    .HasColumnType("boolean");

                b.Property<bool>("AllowPersistentLogin")
                    .HasColumnType("boolean");

                b.Property<bool>("AllowUserToChangeEmail")
                    .HasColumnType("boolean");

                b.Property<bool>("CaptchaOnLogin")
                    .HasColumnType("boolean");

                b.Property<bool>("CaptchaOnRegistration")
                    .HasColumnType("boolean");

                b.Property<string>("CompanyCountry")
                    .HasColumnType("varchar(10) CHARACTER SET UTF8")
                    .HasMaxLength(10);

                b.Property<string>("CompanyFax")
                    .HasColumnType("varchar(20) CHARACTER SET UTF8")
                    .HasMaxLength(20);

                b.Property<string>("CompanyLocality")
                    .HasColumnType("varchar(200) CHARACTER SET UTF8")
                    .HasMaxLength(200);

                b.Property<string>("CompanyName")
                    .HasColumnType("varchar(250) CHARACTER SET UTF8")
                    .HasMaxLength(250);

                b.Property<string>("CompanyPhone")
                    .HasColumnType("varchar(20) CHARACTER SET UTF8")
                    .HasMaxLength(20);

                b.Property<string>("CompanyPostalCode")
                    .HasColumnType("varchar(20) CHARACTER SET UTF8")
                    .HasMaxLength(20);

                b.Property<string>("CompanyPublicEmail")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("CompanyRegion")
                    .HasColumnType("varchar(200) CHARACTER SET UTF8")
                    .HasMaxLength(200);

                b.Property<string>("CompanyStreetAddress")
                    .HasColumnType("varchar(250) CHARACTER SET UTF8")
                    .HasMaxLength(250);

                b.Property<string>("CompanyStreetAddress2")
                    .HasColumnType("varchar(250) CHARACTER SET UTF8")
                    .HasMaxLength(250);

                b.Property<string>("CompanyWebsite")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("ConcurrencyStamp")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("CookiePolicySummary")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<DateTime>("CreatedUtc")
                    .HasColumnType("timestamp");

                b.Property<string>("DefaultEmailFromAddress")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("DefaultEmailFromAlias")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<bool>("DisableDbAuth")
                    .HasColumnType("boolean");

                b.Property<string>("DkimDomain")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("DkimPrivateKey")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("DkimPublicKey")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("DkimSelector")
                    .HasColumnType("varchar(128) CHARACTER SET UTF8")
                    .HasMaxLength(128);

                b.Property<string>("EmailApiEndpoint")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("EmailApiKey")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("EmailSenderName")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100)
                    .HasDefaultValue("SmtpMailSender");

                b.Property<string>("FacebookAppId")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("FacebookAppSecret")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("FooterContent")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("ForcedCulture")
                    .HasColumnType("varchar(10) CHARACTER SET UTF8")
                    .HasMaxLength(10);

                b.Property<string>("ForcedUICulture")
                    .HasColumnType("varchar(10) CHARACTER SET UTF8")
                    .HasMaxLength(10);

                b.Property<string>("GoogleAnalyticsProfileId")
                    .HasColumnType("varchar(25) CHARACTER SET UTF8")
                    .HasMaxLength(25);

                b.Property<string>("GoogleClientId")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("GoogleClientSecret")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("HeaderContent")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<bool>("IsDataProtected")
                    .HasColumnType("boolean");

                b.Property<bool>("IsServerAdminSite")
                    .HasColumnType("boolean");

                b.Property<DateTime>("LastModifiedUtc")
                    .HasColumnType("timestamp");

                b.Property<string>("LdapDomain")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<int>("LdapPort")
                    .HasColumnType("int");

                b.Property<string>("LdapRootDN")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("LdapServer")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<bool>("LdapUseSsl")
                    .HasColumnType("boolean");

                b.Property<string>("LdapUserDNFormat")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("LdapUserDNKey")
                    .HasColumnType("varchar(10) CHARACTER SET UTF8")
                    .HasMaxLength(10);

                b.Property<string>("LoginInfoBottom")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("LoginInfoTop")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("LogoUrl")
                    .HasColumnType("varchar(250) CHARACTER SET UTF8")
                    .HasMaxLength(250);

                b.Property<int>("MaxInvalidPasswordAttempts")
                    .HasColumnType("int");

                b.Property<string>("MicrosoftClientId")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("MicrosoftClientSecret")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<int>("MinRequiredPasswordLength")
                    .HasColumnType("int");

                b.Property<string>("OidConnectAppId")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("OidConnectAppSecret")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("OidConnectAuthority")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("OidConnectDisplayName")
                    .HasColumnType("varchar(150) CHARACTER SET UTF8")
                    .HasMaxLength(150);

                b.Property<string>("OidConnectScopesCsv")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("PreferredHostName")
                    .HasColumnType("varchar(250) CHARACTER SET UTF8")
                    .HasMaxLength(250);

                b.Property<string>("PrivacyPolicy")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<bool>("PwdRequireDigit")
                    .HasColumnType("boolean");

                b.Property<bool>("PwdRequireLowercase")
                    .HasColumnType("boolean");

                b.Property<bool>("PwdRequireNonAlpha")
                    .HasColumnType("boolean");

                b.Property<bool>("PwdRequireUppercase")
                    .HasColumnType("boolean");

                b.Property<string>("RecaptchaPrivateKey")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("RecaptchaPublicKey")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("RegistrationAgreement")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("RegistrationPreamble")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<bool>("Require2FA")
                    .HasColumnType("boolean");

                b.Property<bool>("RequireApprovalBeforeLogin")
                    .HasColumnType("boolean");

                b.Property<bool>("RequireConfirmedEmail")
                    .HasColumnType("boolean");

                b.Property<bool>("RequireConfirmedPhone")
                    .HasColumnType("boolean");

                b.Property<bool>("RequireCookieConsent")
                    .HasColumnType("boolean");

                b.Property<bool>("RequiresQuestionAndAnswer")
                    .HasColumnType("boolean");

                b.Property<bool>("ShowSiteNameLink")
                    .HasColumnType("boolean");

                b.Property<bool>("SignEmailWithDkim")
                    .HasColumnType("boolean");

                b.Property<bool>("SingleBrowserSessions")
                    .HasColumnType("boolean");

                b.Property<string>("SiteFolderName")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50)
                    .HasDefaultValue("");

                b.Property<bool>("SiteIsClosed")
                    .HasColumnType("boolean");

                b.Property<string>("SiteIsClosedMessage")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("SiteName")
                    .IsRequired()
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("SmsClientId")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("SmsFrom")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("SmsSecureToken")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("SmtpPassword")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<int>("SmtpPort")
                    .HasColumnType("int");

                b.Property<string>("SmtpPreferredEncoding")
                    .HasColumnType("varchar(20) CHARACTER SET UTF8")
                    .HasMaxLength(20);

                b.Property<bool>("SmtpRequiresAuth")
                    .HasColumnType("boolean");

                b.Property<string>("SmtpServer")
                    .HasColumnType("varchar(200) CHARACTER SET UTF8")
                    .HasMaxLength(200);

                b.Property<bool>("SmtpUseSsl")
                    .HasColumnType("boolean");

                b.Property<string>("SmtpUser")
                    .HasColumnType("varchar(500) CHARACTER SET UTF8")
                    .HasMaxLength(500);

                b.Property<DateTime>("TermsUpdatedUtc")
                    .HasColumnType("timestamp");

                b.Property<string>("Theme")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("TimeZoneId")
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50);

                b.Property<string>("TwitterConsumerKey")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("TwitterConsumerSecret")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<bool>("UseEmailForLogin")
                    .HasColumnType("boolean");

                b.Property<bool>("UseInvisibleRecaptcha")
                    .HasColumnType("boolean");

                b.Property<bool>("AllowUserToChangeEmail")
                    .HasColumnType("boolean");

                b.HasKey("Id");

                b.HasIndex("AliasId");

                b.HasIndex("SiteFolderName");

                b.ToTable("cs_Site");
            });

        modelBuilder.Entity("cloudscribe.Core.Models.SiteUser", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int");

                b.Property<bool>("AccountApproved")
                    .HasColumnType("boolean");

                b.Property<DateTime?>("AgreementAcceptedUtc")
                    .HasColumnType("timestamp");

                b.Property<string>("AuthorBio")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("AvatarUrl")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("BrowserKey")
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50);

                b.Property<bool>("CanAutoLockout")
                    .HasColumnType("boolean");

                b.Property<string>("Comment")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<DateTime>("CreatedUtc")
                    .HasColumnType("timestamp");

                b.Property<DateTime?>("DateOfBirth")
                    .HasColumnType("timestamp");

                b.Property<bool>("DisplayInMemberList")
                    .HasColumnType("boolean");

                b.Property<string>("DisplayName")
                    .IsRequired()
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("Email")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<DateTime?>("EmailConfirmSentUtc")
                    .HasColumnType("timestamp");

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("boolean");

                b.Property<string>("FirstName")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("Gender")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<bool>("IsLockedOut")
                    .HasColumnType("boolean");

                b.Property<DateTime?>("LastLoginUtc")
                    .HasColumnType("timestamp");

                b.Property<DateTime>("LastModifiedUtc")
                    .HasColumnType("timestamp");

                b.Property<string>("LastName")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<DateTime?>("LastPasswordChangeUtc")
                    .HasColumnType("timestamp");

                b.Property<DateTime?>("LockoutEndDateUtc")
                    .HasColumnType("timestamp");

                b.Property<bool>("MustChangePwd")
                    .HasColumnType("boolean");

                b.Property<string>("NewEmail")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<bool>("NewEmailApproved")
                    .HasColumnType("boolean");

                b.Property<string>("NormalizedEmail")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.Property<string>("NormalizedUserName")
                    .IsRequired()
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50);

                b.Property<string>("PasswordHash")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50);

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("boolean");

                b.Property<bool>("RolesChanged")
                    .HasColumnType("boolean");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50);

                b.Property<string>("Signature")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<Guid>("SiteId")
                    .HasColumnType("char(36)");

                b.Property<string>("TimeZoneId")
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50);

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("boolean");

                b.Property<string>("UserName")
                    .IsRequired()
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50);

                b.Property<string>("WebSiteUrl")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.HasKey("Id");

                b.HasIndex("DisplayName");

                b.HasIndex("NormalizedEmail");

                b.HasIndex("NormalizedUserName");

                b.HasIndex("SiteId");

                b.ToTable("cs_User");
            });

        modelBuilder.Entity("cloudscribe.Core.Models.UserClaim", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<string>("ClaimType")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("ClaimValue")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.Property<Guid>("SiteId")
                    .HasColumnType("char(36)");

                b.Property<Guid>("UserId")
                    .HasColumnType("char(36)");

                b.HasKey("Id");

                b.HasIndex("ClaimType");

                b.HasIndex("SiteId");

                b.HasIndex("UserId");

                b.ToTable("cs_UserClaim");
            });

        modelBuilder.Entity("cloudscribe.Core.Models.UserLocation", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<int>("CaptureCount")
                    .HasColumnType("int");

                b.Property<string>("City")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("Continent")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("Country")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<DateTime>("FirstCaptureUtc")
                    .HasColumnType("timestamp");

                b.Property<string>("HostName")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<string>("IpAddress")
                    .HasColumnType("varchar(50) CHARACTER SET UTF8")
                    .HasMaxLength(50);

                b.Property<long>("IpAddressLong")
                    .HasColumnType("bigint");

                b.Property<string>("Isp")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<DateTime>("LastCaptureUtc")
                    .HasColumnType("timestamp");

                b.Property<double>("Latitude")
                    .HasColumnType("double");

                b.Property<double>("Longitude")
                    .HasColumnType("double");

                b.Property<string>("Region")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<Guid>("SiteId")
                    .HasColumnType("char(36)");

                b.Property<string>("TimeZone")
                    .HasColumnType("varchar(255) CHARACTER SET UTF8")
                    .HasMaxLength(255);

                b.Property<Guid>("UserId")
                    .HasColumnType("char(36)");

                b.HasKey("Id");

                b.HasIndex("IpAddress");

                b.HasIndex("UserId");

                b.ToTable("cs_UserLocation");
            });

        modelBuilder.Entity("cloudscribe.Core.Models.UserLogin", b =>
            {
                b.Property<Guid>("UserId")
                    .HasColumnType("char(36)");

                b.Property<Guid>("SiteId")
                    .HasColumnType("char(36)");

                b.Property<string>("LoginProvider")
                    .HasColumnType("varchar(128) CHARACTER SET UTF8")
                    .HasMaxLength(128);

                b.Property<string>("ProviderKey")
                    .HasColumnType("varchar(128) CHARACTER SET UTF8")
                    .HasMaxLength(128);

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("varchar(100) CHARACTER SET UTF8")
                    .HasMaxLength(100);

                b.HasKey("UserId", "SiteId", "LoginProvider", "ProviderKey");

                b.HasIndex("SiteId");

                b.HasIndex("UserId");

                b.ToTable("cs_UserLogin");
            });

        modelBuilder.Entity("cloudscribe.Core.Models.UserRole", b =>
            {
                b.Property<Guid>("UserId")
                    .HasColumnType("char(36)");

                b.Property<Guid>("RoleId")
                    .HasColumnType("char(36)");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.HasIndex("UserId");

                b.ToTable("cs_UserRole");
            });

        modelBuilder.Entity("cloudscribe.Core.Models.UserToken", b =>
            {
                b.Property<Guid>("UserId");
                // .HasColumnType("char(36)");

                b.Property<Guid>("SiteId");
                    //.HasColumnType("char(36)");

                b.Property<string>("LoginProvider")
                    .HasColumnType("varchar(128) CHARACTER SET UTF8")
                    .HasMaxLength(128);

                b.Property<string>("Name")
                    .HasColumnType("varchar(450) CHARACTER SET UTF8")
                    .HasMaxLength(450);

                b.Property<string>("Value")
                    .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                b.HasKey("UserId", "SiteId", "LoginProvider", "Name");

                b.HasIndex("SiteId");

                b.HasIndex("UserId");

                b.ToTable("cs_UserToken");
            });
#pragma warning restore 612, 618
    }
}
