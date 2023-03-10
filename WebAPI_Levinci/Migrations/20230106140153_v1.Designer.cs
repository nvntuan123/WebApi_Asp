// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_Levinci.Models;

#nullable disable

namespace WebAPILevinci.Migrations
{
    [DbContext(typeof(LevinciContext))]
    [Migration("20230106140153_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPI_Levinci.Models.Users", b =>
                {
                    b.Property<string>("strID")
                        .HasMaxLength(10)
                        .HasColumnType("varchar")
                        .HasColumnName("ID")
                        .HasColumnOrder(0);

                    b.Property<string>("strEmail")
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Email")
                        .HasColumnOrder(5);

                    b.Property<string>("strName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Name")
                        .HasColumnOrder(3);

                    b.Property<string>("strPassword")
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Password")
                        .HasColumnOrder(2);

                    b.Property<string>("strRole")
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Role")
                        .HasColumnOrder(4);

                    b.Property<string>("strUserName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("UserName")
                        .HasColumnOrder(1);

                    b.HasKey("strID");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
