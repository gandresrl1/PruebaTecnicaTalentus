// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(TalentusDB))]
    [Migration("20230117044829_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DAL.ModelDB.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CityId"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Name = "Monterrey, Nuevo Leon, Mexico"
                        },
                        new
                        {
                            CityId = 2,
                            Name = "Monterrey, Casanare, Colombia"
                        },
                        new
                        {
                            CityId = 3,
                            Name = "Monterrey, Cortes, Honduras"
                        },
                        new
                        {
                            CityId = 4,
                            Name = "Monterrey, Bio-Bio, Chile"
                        },
                        new
                        {
                            CityId = 5,
                            Name = "Monterrey, Asturias, Spain"
                        },
                        new
                        {
                            CityId = 6,
                            Name = "Monterrey, Magdalena, Colombia"
                        },
                        new
                        {
                            CityId = 7,
                            Name = "Monterrey, Tamaulipas, Mexico"
                        },
                        new
                        {
                            CityId = 8,
                            Name = "Monterrey, Campeche, Mexico"
                        },
                        new
                        {
                            CityId = 9,
                            Name = "Monterrey, Tabasco, Mexico"
                        },
                        new
                        {
                            CityId = 10,
                            Name = "Monterrey, Chiapas, Mexico"
                        },
                        new
                        {
                            CityId = 11,
                            Name = "Monterrey, Francisco Morazan, Honduras"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
