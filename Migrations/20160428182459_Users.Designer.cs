using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using tiqe_web.Models;

namespace tiqe_web_csharp.Migrations
{
    [DbContext(typeof(TiqeDbContext))]
    [Migration("20160428182459_Users")]
    partial class Users
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("tiqe_web.Models.User", b =>
                {
                    b.Property<int>("TiqeUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<bool>("FirstLogin");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 20);

                    b.Property<string>("Language");

                    b.Property<DateTime>("LastLogin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 20);

                    b.Property<DateTime>("ModifyDate")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 20);

                    b.Property<string>("Picture")
                        .HasAnnotation("MaxLength", 300);

                    b.Property<DateTime>("RegisterDate")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<bool>("SendLogError");

                    b.Property<bool>("Status");

                    b.Property<bool>("UseTerms");

                    b.Property<int?>("UserTiqeUserId");

                    b.HasKey("TiqeUserId");

                    b.HasAnnotation("Relational:TableName", "TB_User");
                });

            modelBuilder.Entity("tiqe_web.Models.UserNewsletter", b =>
                {
                    b.Property<int>("UserNewsletterId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ModifyDate")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<bool>("Receiver");

                    b.Property<DateTime>("ReceiverRegisterDate")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TiqeUserId");

                    b.HasKey("UserNewsletterId");

                    b.HasAnnotation("Relational:TableName", "TB_UserNewsletter");
                });

            modelBuilder.Entity("tiqe_web.Models.User", b =>
                {
                    b.HasOne("tiqe_web.Models.User")
                        .WithMany()
                        .HasForeignKey("UserTiqeUserId");
                });

            modelBuilder.Entity("tiqe_web.Models.UserNewsletter", b =>
                {
                    b.HasOne("tiqe_web.Models.User")
                        .WithMany()
                        .HasForeignKey("TiqeUserId");
                });
        }
    }
}
