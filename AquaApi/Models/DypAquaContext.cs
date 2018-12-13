using Microsoft.EntityFrameworkCore;

namespace AquaApi.Models
{
    public partial class DypAquaContext : DbContext
    {
        public DypAquaContext()
        {
        }

        public DypAquaContext(DbContextOptions<DypAquaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Akwaria> Akwaria { get; set; }
        public virtual DbSet<Akwarium> Akwarium { get; set; }
        public virtual DbSet<Biotop> Biotop { get; set; }
        public virtual DbSet<Czujniki> Czujniki { get; set; }
        public virtual DbSet<Galeria> Galeria { get; set; }
        public virtual DbSet<Klienci> Klienci { get; set; }
        public virtual DbSet<ObrazkiOpis> ObrazkiOpis { get; set; }
        public virtual DbSet<Pokarm> Pokarm { get; set; }
        public virtual DbSet<Pomiary> Pomiary { get; set; }
        public virtual DbSet<Rodzina> Rodzina { get; set; }
        public virtual DbSet<Rozmiar> Rozmiar { get; set; }
        public virtual DbSet<Rozmnazanie> Rozmnazanie { get; set; }
        public virtual DbSet<Ryb2Akwarium> Ryb2Akwarium { get; set; }
        public virtual DbSet<Ryb2Biotop> Ryb2Biotop { get; set; }
        public virtual DbSet<Ryb2Pokarm> Ryb2Pokarm { get; set; }
        public virtual DbSet<Ryb2Rodzina> Ryb2Rodzina { get; set; }
        public virtual DbSet<Ryb2Rozmiar> Ryb2Rozmiar { get; set; }
        public virtual DbSet<Ryb2Rozmnazanie> Ryb2Rozmnazanie { get; set; }
        public virtual DbSet<Ryb2Woda> Ryb2Woda { get; set; }
        public virtual DbSet<Ryb2Zerowanie> Ryb2Zerowanie { get; set; }
        public virtual DbSet<Rybki> Rybki { get; set; }
        public virtual DbSet<Woda> Woda { get; set; }
        public virtual DbSet<Zerowanie> Zerowanie { get; set; }

        // Unable to generate entity type for table 'dbo.Obrazki'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=192.168.30.40,7978;Initial Catalog=DypAqua;Integrated Security=False;MultipleActiveResultSets=true;User ID=sa;Password=QWE()rty");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Akwaria>(entity =>
            {
                entity.HasKey(e => e.Idakwarium);

                entity.Property(e => e.Idakwarium).HasColumnName("IDAkwarium");

                entity.Property(e => e.Idklienta).HasColumnName("IDKlienta");

                entity.Property(e => e.Opis)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdklientaNavigation)
                    .WithMany(p => p.Akwaria)
                    .HasForeignKey(d => d.Idklienta)
                    .HasConstraintName("FK_Akwaria_Klienci");
            });

            modelBuilder.Entity<Akwarium>(entity =>
            {
                entity.HasKey(e => e.Idakwarium);

                entity.Property(e => e.Idakwarium).HasColumnName("IDAkwarium");

                entity.Property(e => e.Akwarium1)
                    .HasColumnName("Akwarium")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Biotop>(entity =>
            {
                entity.HasKey(e => e.Idbiotop);

                entity.Property(e => e.Idbiotop).HasColumnName("IDBiotop");

                entity.Property(e => e.Biotop1)
                    .HasColumnName("Biotop")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Czujniki>(entity =>
            {
                entity.HasKey(e => e.Idczujnika);

                entity.Property(e => e.Idczujnika).HasColumnName("IDCzujnika");

                entity.Property(e => e.CoMierzy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idakwarium).HasColumnName("IDAkwarium");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypHardware)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Galeria>(entity =>
            {
                entity.HasKey(e => new { e.Idrybka, e.Idobrazek });

                entity.Property(e => e.Idrybka).HasColumnName("IDRybka");

                entity.Property(e => e.Idobrazek).HasColumnName("IDObrazek");

                entity.HasOne(d => d.IdobrazekNavigation)
                    .WithMany(p => p.Galeria)
                    .HasForeignKey(d => d.Idobrazek)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Galeria_ObrazkiOpis");

                entity.HasOne(d => d.Idobrazek1)
                    .WithMany(p => p.Galeria)
                    .HasForeignKey(d => d.Idobrazek)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Galeria_Rybka");
            });

            modelBuilder.Entity<Klienci>(entity =>
            {
                entity.HasKey(e => e.Idklienta);

                entity.Property(e => e.Idklienta).HasColumnName("IDKlienta");

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObrazkiOpis>(entity =>
            {
                entity.HasKey(e => e.Idobrazek);

                entity.HasIndex(e => e.Plik)
                    .HasName("IX_ObrazkiOpis")
                    .IsUnique();

                entity.Property(e => e.Idobrazek).HasColumnName("IDObrazek");

                entity.Property(e => e.Alt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Plik)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pokarm>(entity =>
            {
                entity.HasKey(e => e.Idpokarm);

                entity.Property(e => e.Idpokarm).HasColumnName("IDPokarm");

                entity.Property(e => e.Opis)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pokarm1)
                    .HasColumnName("Pokarm")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pomiary>(entity =>
            {
                entity.HasKey(e => e.Idpomiaru);

                entity.HasIndex(e => new { e.Idakwarium, e.Wartosc, e.Idczujnika, e.DataPomiaru })
                    .HasName("idx_IDCzujnika_DataPomiaru");

                entity.Property(e => e.Idpomiaru).HasColumnName("IDPomiaru");

                entity.Property(e => e.DataPomiaru).HasColumnType("datetime");

                entity.Property(e => e.Idakwarium).HasColumnName("IDAkwarium");

                entity.Property(e => e.Idczujnika).HasColumnName("IDCzujnika");

                entity.HasOne(d => d.IdakwariumNavigation)
                    .WithMany(p => p.Pomiary)
                    .HasForeignKey(d => d.Idakwarium)
                    .HasConstraintName("FK_Pomiary_Akwaria");

                entity.HasOne(d => d.IdczujnikaNavigation)
                    .WithMany(p => p.Pomiary)
                    .HasForeignKey(d => d.Idczujnika)
                    .HasConstraintName("FK_Pomiary_Czujniki");
            });

            modelBuilder.Entity<Rodzina>(entity =>
            {
                entity.HasKey(e => e.Idrodzina);

                entity.Property(e => e.Idrodzina).HasColumnName("IDRodzina");

                entity.Property(e => e.Opis)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rodzina1)
                    .HasColumnName("Rodzina")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rozmiar>(entity =>
            {
                entity.HasKey(e => e.Idrozmiar);

                entity.Property(e => e.Idrozmiar).HasColumnName("IDRozmiar");

                entity.Property(e => e.Opis)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rozmiar1)
                    .HasColumnName("Rozmiar")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rozmnazanie>(entity =>
            {
                entity.HasKey(e => e.Idrozmnazanie);

                entity.Property(e => e.Idrozmnazanie).HasColumnName("IDRozmnazanie");

                entity.Property(e => e.Opis)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rozmnazanie1)
                    .HasColumnName("Rozmnazanie")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ryb2Akwarium>(entity =>
            {
                entity.HasKey(e => new { e.Idrybka, e.Idakwarium });

                entity.Property(e => e.Idrybka).HasColumnName("IDRybka");

                entity.Property(e => e.Idakwarium).HasColumnName("IDAkwarium");

                entity.HasOne(d => d.IdrybkaNavigation)
                    .WithMany(p => p.Ryb2Akwarium)
                    .HasForeignKey(d => d.Idrybka)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Akwarium_Akwarium");

                entity.HasOne(d => d.Idrybka1)
                    .WithMany(p => p.Ryb2Akwarium)
                    .HasForeignKey(d => d.Idrybka)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Akwarium_Rybka");
            });

            modelBuilder.Entity<Ryb2Biotop>(entity =>
            {
                entity.HasKey(e => new { e.Idrybka, e.Idbiotop });

                entity.Property(e => e.Idrybka).HasColumnName("IDRybka");

                entity.Property(e => e.Idbiotop).HasColumnName("IDBiotop");

                entity.HasOne(d => d.IdbiotopNavigation)
                    .WithMany(p => p.Ryb2Biotop)
                    .HasForeignKey(d => d.Idbiotop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Biotop_Biotop");

                entity.HasOne(d => d.IdrybkaNavigation)
                    .WithMany(p => p.Ryb2Biotop)
                    .HasForeignKey(d => d.Idrybka)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Biotop_Rybka");
            });

            modelBuilder.Entity<Ryb2Pokarm>(entity =>
            {
                entity.HasKey(e => new { e.Idrybka, e.Idpokarm });

                entity.Property(e => e.Idrybka).HasColumnName("IDRybka");

                entity.Property(e => e.Idpokarm).HasColumnName("IDPokarm");

                entity.HasOne(d => d.IdpokarmNavigation)
                    .WithMany(p => p.Ryb2Pokarm)
                    .HasForeignKey(d => d.Idpokarm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Pokarm_Pokarm");

                entity.HasOne(d => d.IdrybkaNavigation)
                    .WithMany(p => p.Ryb2Pokarm)
                    .HasForeignKey(d => d.Idrybka)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Pokarm_Rybka");
            });

            modelBuilder.Entity<Ryb2Rodzina>(entity =>
            {
                entity.HasKey(e => new { e.Idrybka, e.Idrodzina });

                entity.Property(e => e.Idrybka).HasColumnName("IDRybka");

                entity.Property(e => e.Idrodzina).HasColumnName("IDRodzina");

                entity.HasOne(d => d.IdrodzinaNavigation)
                    .WithMany(p => p.Ryb2Rodzina)
                    .HasForeignKey(d => d.Idrodzina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Rodzina_Rodzina");

                entity.HasOne(d => d.IdrybkaNavigation)
                    .WithMany(p => p.Ryb2Rodzina)
                    .HasForeignKey(d => d.Idrybka)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Rodzina_Rybka");
            });

            modelBuilder.Entity<Ryb2Rozmiar>(entity =>
            {
                entity.HasKey(e => new { e.Idrybka, e.Idrozmiar });

                entity.Property(e => e.Idrybka).HasColumnName("IDRybka");

                entity.Property(e => e.Idrozmiar).HasColumnName("IDRozmiar");

                entity.HasOne(d => d.IdrozmiarNavigation)
                    .WithMany(p => p.Ryb2Rozmiar)
                    .HasForeignKey(d => d.Idrozmiar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Rozmiar_Rozmiar");

                entity.HasOne(d => d.IdrybkaNavigation)
                    .WithMany(p => p.Ryb2Rozmiar)
                    .HasForeignKey(d => d.Idrybka)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Rozmiar_Rybka");
            });

            modelBuilder.Entity<Ryb2Rozmnazanie>(entity =>
            {
                entity.HasKey(e => new { e.Idrybka, e.Idrozmnazanie });

                entity.Property(e => e.Idrybka).HasColumnName("IDRybka");

                entity.Property(e => e.Idrozmnazanie).HasColumnName("IDRozmnazanie");

                entity.HasOne(d => d.IdrozmnazanieNavigation)
                    .WithMany(p => p.Ryb2Rozmnazanie)
                    .HasForeignKey(d => d.Idrozmnazanie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Rozmnazanie_Rozmnazanie");

                entity.HasOne(d => d.IdrybkaNavigation)
                    .WithMany(p => p.Ryb2Rozmnazanie)
                    .HasForeignKey(d => d.Idrybka)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Rozmnazanie_Rybka");
            });

            modelBuilder.Entity<Ryb2Woda>(entity =>
            {
                entity.HasKey(e => new { e.Idrybka, e.Idwoda });

                entity.Property(e => e.Idrybka).HasColumnName("IDRybka");

                entity.Property(e => e.Idwoda).HasColumnName("IDWoda");

                entity.HasOne(d => d.IdrybkaNavigation)
                    .WithMany(p => p.Ryb2Woda)
                    .HasForeignKey(d => d.Idrybka)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Woda_Rybka");

                entity.HasOne(d => d.IdwodaNavigation)
                    .WithMany(p => p.Ryb2Woda)
                    .HasForeignKey(d => d.Idwoda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Woda_Woda");
            });

            modelBuilder.Entity<Ryb2Zerowanie>(entity =>
            {
                entity.HasKey(e => new { e.Idrybka, e.Idzerowanie });

                entity.Property(e => e.Idrybka).HasColumnName("IDRybka");

                entity.Property(e => e.Idzerowanie).HasColumnName("IDZerowanie");

                entity.HasOne(d => d.IdrybkaNavigation)
                    .WithMany(p => p.Ryb2Zerowanie)
                    .HasForeignKey(d => d.Idrybka)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Zerowanie_Rybka");

                entity.HasOne(d => d.IdzerowanieNavigation)
                    .WithMany(p => p.Ryb2Zerowanie)
                    .HasForeignKey(d => d.Idzerowanie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ryb2Zerowanie_Zerowanie");
            });

            modelBuilder.Entity<Rybki>(entity =>
            {
                entity.HasKey(e => e.Idrybka);

                entity.Property(e => e.Idrybka).HasColumnName("IDRybka");

                entity.Property(e => e.AkwariumOpis).IsUnicode(false);

                entity.Property(e => e.CharakterystykaOpis).IsUnicode(false);

                entity.Property(e => e.Nazwa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NazwaLacinska)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OdzywianieOpis).IsUnicode(false);

                entity.Property(e => e.Opis).IsUnicode(false);

                entity.Property(e => e.PochodzenieOpis).IsUnicode(false);

                entity.Property(e => e.RozmiarUwagi)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RozmnazanieOpis).IsUnicode(false);

                entity.Property(e => e.Synonim)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WodapHdo).HasColumnName("WodapHDo");

                entity.Property(e => e.WodapHod).HasColumnName("WodapHOd");
            });

            modelBuilder.Entity<Woda>(entity =>
            {
                entity.HasKey(e => e.Idwoda);

                entity.Property(e => e.Idwoda).HasColumnName("IDWoda");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Woda1)
                    .IsRequired()
                    .HasColumnName("Woda")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zerowanie>(entity =>
            {
                entity.HasKey(e => e.Idzerowanie);

                entity.Property(e => e.Idzerowanie).HasColumnName("IDZerowanie");

                entity.Property(e => e.Opis)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Zerowanie1)
                    .HasColumnName("Zerowanie")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
