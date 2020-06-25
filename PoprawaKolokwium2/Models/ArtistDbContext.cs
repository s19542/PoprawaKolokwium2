using Microsoft.EntityFrameworkCore;


namespace PoprawaKolokwium2.Models
{
    public class ArtistDbContext : DbContext
    {
        public DbSet<Organiser> Organisers { get; set; }
        public DbSet<EventOrganiser> EventOrganisers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<ArtistEvent> ArtistEvents { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public ArtistDbContext()
        {

        }

        public ArtistDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Organiser>(opt =>
            {
                opt.HasKey(p => p.IdOrganiser);
                opt.Property(p => p.IdOrganiser)
                .ValueGeneratedOnAdd();

                opt.Property(p => p.Name)
                .HasMaxLength(30)
                .IsRequired();
            });

            modelBuilder.Entity<EventOrganiser>(opt =>
            {
                opt.HasKey(p => p.IdEvent);
                opt.Property(p => p.IdEvent);

                opt.HasKey(p => p.IdOrganiser);
                opt.Property(p => p.IdOrganiser);

                opt.HasOne(p => p.Event)
                .WithMany(p => p.EventOrganisers)
                .HasForeignKey(p => p.IdEvent);

                opt.HasOne(p => p.Organiser)
                .WithMany(p => p.EventOrganisers)
                .HasForeignKey(p => p.IdOrganiser);
            });

            modelBuilder.Entity<Event>(opt =>
            {
                opt.HasKey(p => p.IdEvent);
                opt.Property(p => p.IdEvent)
                .ValueGeneratedOnAdd();

                opt.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            });

            modelBuilder.Entity<ArtistEvent>(opt =>
            {
                opt.HasKey(p => p.IdEvent);
                opt.Property(p => p.IdEvent);

                opt.HasKey(p => p.IdArtist);
                opt.Property(p => p.IdArtist);

                opt.HasOne(p => p.Event)
                .WithMany(p => p.ArtistEvents) 
                .HasForeignKey(p => p.IdEvent);

                opt.HasOne(p => p.Artist)
                .WithMany(p => p.ArtistEvents)
                .HasForeignKey(p => p.IdArtist);
            });


            modelBuilder.Entity<Artist>(opt =>
            {
                opt.HasKey(p => p.IdArtist);
                opt.Property(p => p.IdArtist)
                .ValueGeneratedOnAdd();

                opt.Property(p => p.Nickname)
                .HasMaxLength(30)
                .IsRequired();
            });

        }
    }
}
