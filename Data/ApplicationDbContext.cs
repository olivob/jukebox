using Jukebox.Models;
using Microsoft.EntityFrameworkCore;

namespace Jukebox.Data
{
    // need to add db context to startup 
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<UserAlbum> UserAlbums { get; set; }

        public DbSet<UserFavoriteSong> UserFavoriteSongs { get; set; }

        public DbSet<Friendship> Friendships { get; set; }

        public DbSet<UserProfileAlbum> UserProfileAlbums { get; set; }

        public DbSet<Shelf> Shelves { get; set; }

        public DbSet<ShelfSong> ShelfSongs { get; set; }

        public DbSet<SongOfTheDay> SongOfTheDays { get; set; }

        public DbSet<SongOfTheDayComment> SongOfTheDayComments { get; set; }

        public DbSet<SongOfTheDayLike> SongOfTheDayLikes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserAlbum>()
                .HasKey(ua => new { ua.UserId, ua.AlbumId });
            modelBuilder.Entity<UserAlbum>()
                .HasOne(ua => ua.User)
                .WithMany(u => u.UserAlbums)
                .HasForeignKey(ua => ua.UserId);
            modelBuilder.Entity<UserAlbum>()
                .HasOne(ua => ua.Album)
                .WithMany(a => a.UserAlbums)
                .HasForeignKey(ua => ua.AlbumId);

            // // Configure User-Favorite-Song relationship
            // modelBuilder.Entity<UserFavoriteSong>()
            //     .HasKey(ufs => new { ufs.UserAlbumId, ufs.SongId });
            // modelBuilder.Entity<UserFavoriteSong>()
            //     .HasOne(ufs => ufs.UserAlbum)
            //     .WithMany(ua => ua.UserFavoriteSongs)
            //     .HasForeignKey(ufs => ufs.UserAlbumId);
            // modelBuilder.Entity<UserFavoriteSong>()
            //     .HasOne(ufs => ufs.Song)
            //     .WithMany(s => s.UserFavoriteSongs)
            //     .HasForeignKey(ufs => ufs.SongId);

            // Configure User-Favorite-Album relationship
            // modelBuilder.Entity<UserProfileAlbum>()
            //     .HasKey(u => new { u.UserId, u.AlbumId });
            // modelBuilder.Entity<UserProfileAlbum>()
            //     .HasOne(u => u.User)
            //     .WithMany(u => u.UserProfileAlbums)
            //     .HasForeignKey(u => u.UserId);
            // modelBuilder.Entity<UserProfileAlbum>()
            //     .HasOne(u => u.Album)
            //     .WithMany(a => a.UserProfileAlbums)
            //     .HasForeignKey(u => u.AlbumId);

            // Configure Song-Of-The-Day relationships
            modelBuilder.Entity<SongOfTheDay>()
                .HasOne(s => s.User)
                .WithMany(u => u.SongOfTheDays)
                .HasForeignKey(s => s.UserId);
            modelBuilder.Entity<SongOfTheDay>()
                .HasOne(s => s.Song)
                .WithMany(s => s.SongOfTheDays)
                .HasForeignKey(s => s.SongId);

            modelBuilder.Entity<SongOfTheDayLike>()
                .HasOne(sdl => sdl.SongOfTheDay)
                .WithMany(s => s.SongOfTheDayLikes)
                .HasForeignKey(sdl => sdl.SongOfTheDayId);
            modelBuilder.Entity<SongOfTheDayLike>()
                .HasOne(sdl => sdl.User)
                .WithMany(u => u.SongOfTheDayLikes)
                .HasForeignKey(sdl => sdl.UserId);

            modelBuilder.Entity<SongOfTheDayComment>()
                .HasOne(sdc => sdc.SongOfTheDay)
                .WithMany(s => s.SongOfTheDayComments)
                .HasForeignKey(sdc => sdc.SongOfTheDayId);
            modelBuilder.Entity<SongOfTheDayComment>()
                .HasOne(sdc => sdc.User)
                .WithMany(u => u.SongOfTheDayComments)
                .HasForeignKey(sdc => sdc.UserId);

            // Configure Shelf-Song relationship
            modelBuilder.Entity<ShelfSong>()
                .HasKey(ss => new { ss.ShelfId, ss.SongId });
            modelBuilder.Entity<ShelfSong>()
                .HasOne(ss => ss.Shelf)
                .WithMany(s => s.ShelfSongs)
                .HasForeignKey(ss => ss.ShelfId);
            modelBuilder.Entity<ShelfSong>()
                .HasOne(ss => ss.Song)
                .WithMany(s => s.ShelfSongs)
                .HasForeignKey(ss => ss.SongId);
        }
    }

}