// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WM_Personel_Takip.Models;

namespace WM_Personel_Takip.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WM_Personel_Takip.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kullanici");

                    b.Property<string>("Sifre");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("WM_Personel_Takip.Models.Birim", b =>
                {
                    b.Property<int>("BirimID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirimAD");

                    b.HasKey("BirimID");

                    b.ToTable("Birims");
                });

            modelBuilder.Entity("WM_Personel_Takip.Models.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BirimID");

                    b.Property<string>("PersnelSOYAD");

                    b.Property<string>("PersonelAD");

                    b.Property<string>("PersonelSEHİR");

                    b.HasKey("PersonelID");

                    b.HasIndex("BirimID");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("WM_Personel_Takip.Models.Personel", b =>
                {
                    b.HasOne("WM_Personel_Takip.Models.Birim", "Birim")
                        .WithMany("parsonels")
                        .HasForeignKey("BirimID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
