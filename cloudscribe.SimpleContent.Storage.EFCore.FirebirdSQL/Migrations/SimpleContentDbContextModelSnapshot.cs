﻿
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cloudscribe.SimpleContent.Storage.EFCore.FirebirdSQL;

namespace cloudscribe.SimpleContent.Storage.EFCore.FirebirdSQL.Migrations
{
    [DbContext(typeof(SimpleContentDbContext))]
    partial class SimpleContentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("cloudscribe.SimpleContent.Models.ContentHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasMaxLength(36);

                    b.Property<string>("ArchivedBy")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<DateTime>("ArchivedUtc")
                        .HasColumnType("timestamp");

                    b.Property<string>("Author")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("CategoriesCsv")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("Content")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("ContentId")
                        .IsRequired()
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<string>("ContentSource")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<string>("ContentType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<string>("CorrelationKey")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("timestamp");

                    b.Property<string>("DraftAuthor")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("DraftContent")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<DateTime?>("DraftPubDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("DraftSerializedModel")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<bool>("IsDraftHx")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp");

                    b.Property<string>("LastModifiedByUser")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<string>("MetaDescription")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("MetaHtml")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("MetaJson")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<int>("PageOrder")
                        .HasColumnType("int");

                    b.Property<string>("ParentId")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("ParentSlug")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("ProjectId")
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("PubDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("SerializedModel")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("Serializer")
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<string>("Slug")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("TeaserOverride")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("TemplateKey")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("ViewRoles")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<bool>("WasDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("ContentSource");

                    b.HasIndex("CorrelationKey");

                    b.HasIndex("CreatedByUser");

                    b.HasIndex("LastModifiedByUser");

                    b.HasIndex("Title");

                    b.ToTable("cs_ContentHistory");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Models.ProjectSettings", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<string>("AboutContent")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("AboutHeading")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<bool>("AddBlogToPagesTree")
                        .HasColumnType("boolean");

                    b.Property<bool>("BlogMenuLinksToNewestPost")
                        .HasColumnType("boolean");

                    b.Property<string>("BlogPageNavComponentVisibility")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<int>("BlogPagePosition")
                        .HasColumnType("int");

                    b.Property<string>("BlogPageText")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("CdnUrl")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("ChannelCategoriesCsv")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("ChannelRating")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<int>("ChannelTimeToLive")
                        .HasColumnType("int");

                    b.Property<string>("CommentNotificationEmail")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<string>("CopyrightNotice")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<int>("DaysToComment")
                        .HasColumnType("int");

                    b.Property<string>("DefaultContentType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<int>("DefaultFeedItems")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(20);

                    b.Property<string>("DefaultPageSlug")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("DisqusShortName")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<string>("FacebookAppId")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<string>("Image")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<bool>("IncludePubDateInPostUrls")
                        .HasColumnType("boolean");

                    b.Property<string>("LanguageCode")
                        .HasColumnType("varchar(10) CHARACTER SET UTF8")
                        .HasMaxLength(10);

                    b.Property<string>("LocalMediaVirtualPath")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("ManagingEditorEmail")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<int>("MaxFeedItems")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1000);

                    b.Property<bool>("ModerateComments")
                        .HasColumnType("boolean");

                    b.Property<int>("PostsPerPage")
                        .HasColumnType("int");

                    b.Property<string>("PubDateFormat")
                        .HasColumnType("varchar(75) CHARACTER SET UTF8")
                        .HasMaxLength(75);

                    b.Property<string>("Publisher")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("PublisherEntityType")
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<string>("PublisherLogoHeight")
                        .HasColumnType("varchar(20) CHARACTER SET UTF8")
                        .HasMaxLength(20);

                    b.Property<string>("PublisherLogoUrl")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("PublisherLogoWidth")
                        .HasColumnType("varchar(20) CHARACTER SET UTF8")
                        .HasMaxLength(20);

                    b.Property<string>("RecaptchaPrivateKey")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("RecaptchaPublicKey")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("RemoteFeedProcessorUseAgentFragment")
                        .HasColumnName("RemoteFeedProcUseAgentFrag")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("RemoteFeedUrl")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<bool>("ShowAboutBox")
                        .HasColumnType("boolean");

                    b.Property<bool>("ShowFeaturedPostsOnDefaultPage")
                        .HasColumnType("boolean");

                    b.Property<bool>("ShowRecentPostsOnDefaultPage")
                        .HasColumnType("boolean");

                    b.Property<bool>("ShowRelatedPosts")
                        .HasColumnType("boolean");

                    b.Property<bool>("ShowTitle")
                        .HasColumnType("boolean");

                    b.Property<string>("SiteName")
                        .HasColumnType("varchar(200) CHARACTER SET UTF8")
                        .HasMaxLength(200);

                    b.Property<byte>("TeaserMode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((byte)0);

                    b.Property<int>("TeaserTruncationLength")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(20);

                    b.Property<byte>("TeaserTruncationMode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((byte)0);

                    b.Property<string>("TimeZoneId")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("TwitterCreator")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<string>("TwitterPublisher")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<bool>("UseDefaultPageAsRootNode")
                        .HasColumnType("boolean");

                    b.Property<string>("WebmasterEmail")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("cs_ContentProject");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageCategory", b =>
                {
                    b.Property<string>("Value")
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<string>("PageEntityId")
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.HasKey("Value", "PageEntityId");

                    b.HasIndex("PageEntityId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("Value");

                    b.ToTable("cs_PageCategory");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageComment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("Content")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<string>("Ip")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("boolean");

                    b.Property<string>("PageEntityId")
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<DateTime>("PubDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("UserAgent")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("Website")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PageEntityId");

                    b.HasIndex("ProjectId");

                    b.ToTable("cs_PageComment");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("CategoriesCsv")
                        .HasColumnType("varchar(500) CHARACTER SET UTF8")
                        .HasMaxLength(500);

                    b.Property<string>("Content")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("ContentType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<string>("CorrelationKey")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("timestamp");

                    b.Property<bool>("DisableEditor")
                        .HasColumnType("boolean");

                    b.Property<string>("DraftAuthor")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("DraftContent")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<DateTime?>("DraftPubDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("DraftSerializedModel")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("ExternalUrl")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp");

                    b.Property<string>("LastModifiedByUser")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<string>("MenuFilters")
                        .HasColumnType("varchar(500) CHARACTER SET UTF8")
                        .HasMaxLength(500);

                    b.Property<bool>("MenuOnly")
                        .HasColumnType("boolean");

                    b.Property<string>("MetaDescription")
                        .HasColumnType("varchar(500) CHARACTER SET UTF8")
                        .HasMaxLength(500);

                    b.Property<string>("MetaHtml")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("MetaJson")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<int>("PageOrder")
                        .HasColumnType("int");

                    b.Property<string>("ParentId")
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<string>("ParentSlug")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("PubDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("SerializedModel")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("Serializer")
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<bool>("ShowCategories")
                        .HasColumnType("boolean");

                    b.Property<bool>("ShowComments")
                        .HasColumnType("boolean");

                    b.Property<bool>("ShowHeading")
                        .HasColumnType("boolean");

                    b.Property<bool>("ShowLastModified")
                        .HasColumnType("boolean");

                    b.Property<bool>("ShowMenu")
                        .HasColumnType("boolean");

                    b.Property<bool>("ShowPubDate")
                        .HasColumnType("boolean");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("TemplateKey")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("ViewRoles")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.HasKey("Id");

                    b.HasIndex("CorrelationKey");

                    b.HasIndex("ParentId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("Slug", "ProjectId");

                    b.ToTable("cs_Page");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageResourceEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<string>("Environment")
                        .IsRequired()
                        .HasColumnType("varchar(15) CHARACTER SET UTF8")
                        .HasMaxLength(15);

                    b.Property<string>("PageEntityId")
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<int>("Sort")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET UTF8")
                        .HasMaxLength(10);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PageEntityId");

                    b.ToTable("cs_PageResource");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostCategory", b =>
                {
                    b.Property<string>("Value")
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<string>("PostEntityId")
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.HasKey("Value", "PostEntityId");

                    b.HasIndex("PostEntityId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("Value");

                    b.ToTable("cs_PostCategory");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostComment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("Content")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<string>("Ip")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("boolean");

                    b.Property<string>("PostEntityId")
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<DateTime>("PubDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("UserAgent")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("Website")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PostEntityId");

                    b.HasIndex("ProjectId");

                    b.ToTable("cs_PostComment");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36) CHARACTER SET UTF8")
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("AutoTeaser")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("BlogId")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<string>("CategoriesCsv")
                        .HasColumnType("varchar(500) CHARACTER SET UTF8")
                        .HasMaxLength(500);

                    b.Property<string>("Content")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("ContentType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<string>("CorrelationKey")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("timestamp");

                    b.Property<string>("DraftAuthor")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("DraftContent")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<DateTime?>("DraftPubDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("DraftSerializedModel")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("varchar(250) CHARACTER SET UTF8")
                        .HasMaxLength(250);

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp");

                    b.Property<string>("LastModifiedByUser")
                        .HasColumnType("varchar(100) CHARACTER SET UTF8")
                        .HasMaxLength(100);

                    b.Property<string>("MetaDescription")
                        .HasColumnType("varchar(500) CHARACTER SET UTF8")
                        .HasMaxLength(500);

                    b.Property<string>("MetaHtml")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("MetaJson")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<DateTime?>("PubDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("SerializedModel")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("Serializer")
                        .HasColumnType("varchar(50) CHARACTER SET UTF8")
                        .HasMaxLength(50);

                    b.Property<bool>("ShowComments")
                        .HasColumnType("boolean");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<bool>("SuppressTeaser")
                        .HasColumnType("boolean");

                    b.Property<string>("TeaserOverride")
                        .HasColumnType("blob sub_type text CHARACTER SET UTF8");

                    b.Property<string>("TemplateKey")
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.Property<string>("ThumbnailUrl")
                        .HasColumnType("varchar(250) CHARACTER SET UTF8")
                        .HasMaxLength(250);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET UTF8")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("CorrelationKey");

                    b.HasIndex("Slug");

                    b.ToTable("cs_Post");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageComment", b =>
                {
                    b.HasOne("cloudscribe.SimpleContent.Storage.EFCore.Models.PageEntity", null)
                        .WithMany("PageComments")
                        .HasForeignKey("PageEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageResourceEntity", b =>
                {
                    b.HasOne("cloudscribe.SimpleContent.Storage.EFCore.Models.PageEntity", null)
                        .WithMany("PageResources")
                        .HasForeignKey("PageEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostComment", b =>
                {
                    b.HasOne("cloudscribe.SimpleContent.Storage.EFCore.Models.PostEntity", null)
                        .WithMany("PostComments")
                        .HasForeignKey("PostEntityId");
                });
#pragma warning restore 612, 618
        }
    }
}
