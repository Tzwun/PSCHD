using Microsoft.EntityFrameworkCore;
using PSCHD.Model;
using System;

namespace PSCHD.DB
{
    public class PSCHD_Context : DbContext
    {
        private string DbPath;

        public PSCHD_Context()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            path = path + "/PSCHD";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            DbPath = System.IO.Path.Join(path, "PSCHD_Test.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MagicColor>().HasData(
                new MagicColor { Id = 1, magicColor = 'A' },
                new MagicColor { Id = 2, magicColor = 'B' },
                new MagicColor { Id = 3, magicColor = 'C' },
                new MagicColor { Id = 4, magicColor = 'D' },
                new MagicColor { Id = 5, magicColor = 'E' },
                new MagicColor { Id = 6, magicColor = 'F' },
                new MagicColor { Id = 7, magicColor = 'G' },
                new MagicColor { Id = 8, magicColor = 'H' },
                new MagicColor { Id = 9, magicColor = 'I' },
                new MagicColor { Id = 10, magicColor = 'J' },
                new MagicColor { Id = 11, magicColor = 'K' },
                new MagicColor { Id = 12, magicColor = 'L' },
                new MagicColor { Id = 13, magicColor = 'M' },
                new MagicColor { Id = 14, magicColor = 'N' },
                new MagicColor { Id = 15, magicColor = 'O' },
                new MagicColor { Id = 16, magicColor = 'P' },
                new MagicColor { Id = 17, magicColor = 'Q' },
                new MagicColor { Id = 18, magicColor = 'R' },
                new MagicColor { Id = 19, magicColor = 'S' },
                new MagicColor { Id = 20, magicColor = 'T' },
                new MagicColor { Id = 21, magicColor = 'U' },
                new MagicColor { Id = 22, magicColor = 'V' },
                new MagicColor { Id = 23, magicColor = 'W' },
                new MagicColor { Id = 24, magicColor = 'X' },
                new MagicColor { Id = 25, magicColor = 'Y' },
                new MagicColor { Id = 26, magicColor = 'Z' });

            modelBuilder.Entity<MagicColorIdentity>().HasData(
                new MagicColorIdentity { Id = 1, magicColorIdentity = 'A' },
                new MagicColorIdentity { Id = 2, magicColorIdentity = 'B' },
                new MagicColorIdentity { Id = 3, magicColorIdentity = 'C' },
                new MagicColorIdentity { Id = 4, magicColorIdentity = 'D' },
                new MagicColorIdentity { Id = 5, magicColorIdentity = 'E' },
                new MagicColorIdentity { Id = 6, magicColorIdentity = 'F' },
                new MagicColorIdentity { Id = 7, magicColorIdentity = 'G' },
                new MagicColorIdentity { Id = 8, magicColorIdentity = 'H' },
                new MagicColorIdentity { Id = 9, magicColorIdentity = 'I' },
                new MagicColorIdentity { Id = 10, magicColorIdentity = 'J' },
                new MagicColorIdentity { Id = 11, magicColorIdentity = 'K' },
                new MagicColorIdentity { Id = 12, magicColorIdentity = 'L' },
                new MagicColorIdentity { Id = 13, magicColorIdentity = 'M' },
                new MagicColorIdentity { Id = 14, magicColorIdentity = 'N' },
                new MagicColorIdentity { Id = 15, magicColorIdentity = 'O' },
                new MagicColorIdentity { Id = 16, magicColorIdentity = 'P' },
                new MagicColorIdentity { Id = 17, magicColorIdentity = 'Q' },
                new MagicColorIdentity { Id = 18, magicColorIdentity = 'R' },
                new MagicColorIdentity { Id = 19, magicColorIdentity = 'S' },
                new MagicColorIdentity { Id = 20, magicColorIdentity = 'T' },
                new MagicColorIdentity { Id = 21, magicColorIdentity = 'U' },
                new MagicColorIdentity { Id = 22, magicColorIdentity = 'V' },
                new MagicColorIdentity { Id = 23, magicColorIdentity = 'W' },
                new MagicColorIdentity { Id = 24, magicColorIdentity = 'X' },
                new MagicColorIdentity { Id = 25, magicColorIdentity = 'Y' },
                new MagicColorIdentity { Id = 26, magicColorIdentity = 'Z' });

            modelBuilder.Entity<MagicKeyword>().HasData(
                new MagicKeyword { Id = 1, Keyword = "Flying" },
                new MagicKeyword { Id = 2, Keyword = "Enchant" },
                new MagicKeyword { Id = 3, Keyword = "Cascade" },
                new MagicKeyword { Id = 4, Keyword = "Scavenge" },
                new MagicKeyword { Id = 5, Keyword = "Manifest" },
                new MagicKeyword { Id = 6, Keyword = "Trample" },
                new MagicKeyword { Id = 7, Keyword = "Partner" },
                new MagicKeyword { Id = 8, Keyword = "Aftermath" },
                new MagicKeyword { Id = 9, Keyword = "Equip" },
                new MagicKeyword { Id = 10, Keyword = "Flanking" },
                new MagicKeyword { Id = 11, Keyword = "Defender" },
                new MagicKeyword { Id = 12, Keyword = "Scry" },
                new MagicKeyword { Id = 13, Keyword = "Flashback" },
                new MagicKeyword { Id = 14, Keyword = "Reach" },
                new MagicKeyword { Id = 15, Keyword = "Lifelink" },
                new MagicKeyword { Id = 16, Keyword = "First strike" },
                new MagicKeyword { Id = 17, Keyword = "Vigilance" },
                new MagicKeyword { Id = 18, Keyword = "Transform" },
                new MagicKeyword { Id = 19, Keyword = "Kicker" },
                new MagicKeyword { Id = 20, Keyword = "Menace" },
                new MagicKeyword { Id = 21, Keyword = "Heroic" },
                new MagicKeyword { Id = 22, Keyword = "Persist" },
                new MagicKeyword { Id = 23, Keyword = "Ascend" },
                new MagicKeyword { Id = 24, Keyword = "Parley" },
                new MagicKeyword { Id = 25, Keyword = "Mill" },
                new MagicKeyword { Id = 26, Keyword = "Imprint" },
                new MagicKeyword { Id = 27, Keyword = "Hexproof" },
                new MagicKeyword { Id = 28, Keyword = "Convoke" },
                new MagicKeyword { Id = 29, Keyword = "Surveil" },
                new MagicKeyword { Id = 30, Keyword = "Mutate" },
                new MagicKeyword { Id = 31, Keyword = "Hellbent" },
                new MagicKeyword { Id = 32, Keyword = "Haste" },
                new MagicKeyword { Id = 33, Keyword = "Landcycling" },
                new MagicKeyword { Id = 34, Keyword = "Buyback" },
                new MagicKeyword { Id = 35, Keyword = "Ward" },
                new MagicKeyword { Id = 36, Keyword = "Threshold" },
                new MagicKeyword { Id = 37, Keyword = "Foretell" },
                new MagicKeyword { Id = 38, Keyword = "Fuse" },
                new MagicKeyword { Id = 39, Keyword = "Cumulative upkeep" },
                new MagicKeyword { Id = 40, Keyword = "Deathtouch" },
                new MagicKeyword { Id = 41, Keyword = "Flash" },
                new MagicKeyword { Id = 42, Keyword = "Explore" },
                new MagicKeyword { Id = 43, Keyword = "Suspend" },
                new MagicKeyword { Id = 44, Keyword = "Exploit" },
                new MagicKeyword { Id = 45, Keyword = "Megamorph" },
                new MagicKeyword { Id = 46, Keyword = "Ferocious" },
                new MagicKeyword { Id = 47, Keyword = "Basic landcycling" },
                new MagicKeyword { Id = 48, Keyword = "Fight" },
                new MagicKeyword { Id = 49, Keyword = "Double strike" },
                new MagicKeyword { Id = 50, Keyword = "Infect" },
                new MagicKeyword { Id = 51, Keyword = "Channel" },
                new MagicKeyword { Id = 52, Keyword = "Bestow" },
                new MagicKeyword { Id = 53, Keyword = "Devoid" },
                new MagicKeyword { Id = 54, Keyword = "Protection" },
                new MagicKeyword { Id = 55, Keyword = "Typecycling" },
                new MagicKeyword { Id = 56, Keyword = "Split second" });

            modelBuilder.Entity<MagicGame>().HasData(
                new MagicGame { Id = 1, magicGame = "paper" },
                new MagicGame { Id = 2, magicGame = "arena" },
                new MagicGame { Id = 3, magicGame = "mtgo" });

            modelBuilder.Entity<Finish>().HasData(
                new Finish { Id = 1, finish = "nonfoil" },
                new Finish { Id = 2, finish = "foil" }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}").EnableThreadSafetyChecks(false);
        }

        public DbSet<MagicCard> MagiCards { get; set; }
        public DbSet<Legalities> Leglities { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<RelatedUris> RelatedUris { get; set; }
        public DbSet<ImageUris> ImageUris { get; set; }
        public DbSet<ArtistId> ArtistIDs { get; set; }
        public DbSet<MagicGame> MagicGames { get; set; }
        public DbSet<Finish> Finishes { get; set; }
        public DbSet<MagicColor> Colors { get; set; }
        public DbSet<MagicColorIdentity> Colors_Identity { get; set; }
        public DbSet<MultiverseId> MultiverseIds { get; set; }
        public DbSet<MagicKeyword> Keywords { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMagicCard> UserMagicCards { get; set; }
        public DbSet<UserSetting> UserSettings { get; set; }
        public DbSet<AppSetting> AppSettings { get; set; }
        public DbSet<MagicCollection> MagicCollections { get; set; }
        public DbSet<MagicCardColor> MagicCardColors { get; set; }
        public DbSet<MagicCardColorIdentity> MagicCardColorIdentities { get; set; }
        public DbSet<MagicCardKeyword> MagicCardKeywords { get; set; }
        public DbSet<MagicCardGame> MagicCardGames { get; set; }
        public DbSet<CardFinish> CardFinishes { get; set; }
        public DbSet<CardArtistsId> CardArtistsId { get; set; }
        public DbSet<MagicCardSet> MagicCardSets { get; set; }
    }
}
