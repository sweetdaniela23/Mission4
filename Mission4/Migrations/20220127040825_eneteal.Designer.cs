// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    [Migration("20220127040825_eneteal")]
    partial class eneteal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.MovieEntry", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DirectorFirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DirectorLastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieID");

                    b.ToTable("Entries");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Fantasy",
                            DirectorFirstName = "Marbalble",
                            DirectorLastName = "Nonito",
                            Edited = false,
                            LentTo = "Josh",
                            Notes = "This is a great movie!",
                            Rating = "PG",
                            Title = "Encanto",
                            Year = "2022"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
