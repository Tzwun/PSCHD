using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSCHD.DB.Migrations
{
    public partial class V0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArtistIDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    artistId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistIDs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    magicColor = table.Column<char>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors_Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    magicColorIdentity = table.Column<char>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors_Identity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Finishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    finish = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Keyword = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leglities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    standard = table.Column<int>(type: "INTEGER", nullable: false),
                    future = table.Column<int>(type: "INTEGER", nullable: false),
                    historic = table.Column<int>(type: "INTEGER", nullable: false),
                    gladiator = table.Column<int>(type: "INTEGER", nullable: false),
                    pioneer = table.Column<int>(type: "INTEGER", nullable: false),
                    modern = table.Column<int>(type: "INTEGER", nullable: false),
                    legacy = table.Column<int>(type: "INTEGER", nullable: false),
                    pauper = table.Column<int>(type: "INTEGER", nullable: false),
                    vintage = table.Column<int>(type: "INTEGER", nullable: false),
                    penny = table.Column<int>(type: "INTEGER", nullable: false),
                    commander = table.Column<int>(type: "INTEGER", nullable: false),
                    brawl = table.Column<int>(type: "INTEGER", nullable: false),
                    historicbrawl = table.Column<int>(type: "INTEGER", nullable: false),
                    alchemy = table.Column<int>(type: "INTEGER", nullable: false),
                    paupercommander = table.Column<int>(type: "INTEGER", nullable: false),
                    duel = table.Column<int>(type: "INTEGER", nullable: false),
                    oldschool = table.Column<int>(type: "INTEGER", nullable: false),
                    premodern = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leglities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MagicCardSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SetID = table.Column<string>(type: "TEXT", nullable: true),
                    SetName = table.Column<string>(type: "TEXT", nullable: true),
                    SetType = table.Column<string>(type: "TEXT", nullable: true),
                    SetURI = table.Column<string>(type: "TEXT", nullable: true),
                    SetSearchURI = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCardSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MagicGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    magicGame = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicGames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Salt = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MagiCards",
                columns: table => new
                {
                    string_id = table.Column<string>(type: "TEXT", nullable: false),
                    oracle_id = table.Column<string>(type: "TEXT", nullable: true),
                    mtgo_id = table.Column<int>(type: "INTEGER", nullable: true),
                    mtgo_foil_id = table.Column<int>(type: "INTEGER", nullable: true),
                    tcgplayer_id = table.Column<int>(type: "INTEGER", nullable: true),
                    cardmarket_id = table.Column<int>(type: "INTEGER", nullable: true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    lang = table.Column<string>(type: "TEXT", nullable: true),
                    released_at = table.Column<string>(type: "TEXT", nullable: true),
                    uri = table.Column<string>(type: "TEXT", nullable: true),
                    scryfall_uri = table.Column<string>(type: "TEXT", nullable: true),
                    layout = table.Column<string>(type: "TEXT", nullable: true),
                    highres_image = table.Column<bool>(type: "INTEGER", nullable: false),
                    image_status = table.Column<string>(type: "TEXT", nullable: true),
                    mana_cost = table.Column<string>(type: "TEXT", nullable: true),
                    cmc = table.Column<double>(type: "REAL", nullable: true),
                    type_line = table.Column<string>(type: "TEXT", nullable: true),
                    oracle_text = table.Column<string>(type: "TEXT", nullable: true),
                    power = table.Column<string>(type: "TEXT", nullable: true),
                    toughness = table.Column<string>(type: "TEXT", nullable: true),
                    reserved = table.Column<bool>(type: "INTEGER", nullable: false),
                    foil = table.Column<bool>(type: "INTEGER", nullable: false),
                    nonfoil = table.Column<bool>(type: "INTEGER", nullable: false),
                    oversized = table.Column<bool>(type: "INTEGER", nullable: false),
                    promo = table.Column<bool>(type: "INTEGER", nullable: false),
                    reprint = table.Column<bool>(type: "INTEGER", nullable: false),
                    variation = table.Column<bool>(type: "INTEGER", nullable: false),
                    scryfall_set_uri = table.Column<string>(type: "TEXT", nullable: true),
                    rulings_uri = table.Column<string>(type: "TEXT", nullable: true),
                    prints_search_uri = table.Column<string>(type: "TEXT", nullable: true),
                    collector_number = table.Column<string>(type: "TEXT", nullable: true),
                    digital = table.Column<bool>(type: "INTEGER", nullable: false),
                    rarity = table.Column<string>(type: "TEXT", nullable: true),
                    flavor_text = table.Column<string>(type: "TEXT", nullable: true),
                    card_back_id = table.Column<string>(type: "TEXT", nullable: true),
                    artist = table.Column<string>(type: "TEXT", nullable: true),
                    illustration_id = table.Column<string>(type: "TEXT", nullable: true),
                    border_color = table.Column<string>(type: "TEXT", nullable: true),
                    frame = table.Column<string>(type: "TEXT", nullable: true),
                    full_art = table.Column<bool>(type: "INTEGER", nullable: false),
                    textless = table.Column<bool>(type: "INTEGER", nullable: false),
                    booster = table.Column<bool>(type: "INTEGER", nullable: false),
                    story_spotlight = table.Column<bool>(type: "INTEGER", nullable: false),
                    edhrec_rank = table.Column<int>(type: "INTEGER", nullable: false),
                    MagicCardSetId = table.Column<int>(type: "INTEGER", nullable: true),
                    legalitiesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagiCards", x => x.string_id);
                    table.ForeignKey(
                        name: "FK_MagiCards_Leglities_legalitiesId",
                        column: x => x.legalitiesId,
                        principalTable: "Leglities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MagiCards_MagicCardSets_MagicCardSetId",
                        column: x => x.MagicCardSetId,
                        principalTable: "MagicCardSets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MagicCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicCollections_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vlue = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    SettingId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSettings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserSettings_UserSettings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "UserSettings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CardArtistsId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArtistIdId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardstring_id = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardArtistsId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardArtistsId_ArtistIDs_ArtistIdId",
                        column: x => x.ArtistIdId,
                        principalTable: "ArtistIDs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardArtistsId_MagiCards_MagicCardstring_id",
                        column: x => x.MagicCardstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                });

            migrationBuilder.CreateTable(
                name: "CardFinishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FinishId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardstring_id = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardFinishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardFinishes_Finishes_FinishId",
                        column: x => x.FinishId,
                        principalTable: "Finishes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardFinishes_MagiCards_MagicCardstring_id",
                        column: x => x.MagicCardstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                });

            migrationBuilder.CreateTable(
                name: "ImageUris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    URI = table.Column<string>(type: "TEXT", nullable: true),
                    ImageSize = table.Column<int>(type: "INTEGER", nullable: false),
                    Parentstring_id = table.Column<string>(type: "TEXT", nullable: true),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageUris_MagiCards_Parentstring_id",
                        column: x => x.Parentstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                });

            migrationBuilder.CreateTable(
                name: "MagicCardColorIdentities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MagicColorIdentityId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardstring_id = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCardColorIdentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicCardColorIdentities_Colors_Identity_MagicColorIdentityId",
                        column: x => x.MagicColorIdentityId,
                        principalTable: "Colors_Identity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MagicCardColorIdentities_MagiCards_MagicCardstring_id",
                        column: x => x.MagicCardstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                });

            migrationBuilder.CreateTable(
                name: "MagicCardColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ColorId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardstring_id = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCardColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicCardColors_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MagicCardColors_MagiCards_MagicCardstring_id",
                        column: x => x.MagicCardstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                });

            migrationBuilder.CreateTable(
                name: "MagicCardGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MagicGameId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardstring_id = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCardGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicCardGames_MagiCards_MagicCardstring_id",
                        column: x => x.MagicCardstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                    table.ForeignKey(
                        name: "FK_MagicCardGames_MagicGames_MagicGameId",
                        column: x => x.MagicGameId,
                        principalTable: "MagicGames",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MagicCardKeywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    keywordId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardstring_id = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCardKeywords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicCardKeywords_Keywords_keywordId",
                        column: x => x.keywordId,
                        principalTable: "Keywords",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MagicCardKeywords_MagiCards_MagicCardstring_id",
                        column: x => x.MagicCardstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                });

            migrationBuilder.CreateTable(
                name: "MultiverseIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    multiVerseId = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardstring_id = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiverseIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiverseIds_MagiCards_MagicCardstring_id",
                        column: x => x.MagicCardstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    currency = table.Column<string>(type: "TEXT", nullable: true),
                    FinishId = table.Column<int>(type: "INTEGER", nullable: true),
                    datetime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MagicCardstring_id = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prices_Finishes_FinishId",
                        column: x => x.FinishId,
                        principalTable: "Finishes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Prices_MagiCards_MagicCardstring_id",
                        column: x => x.MagicCardstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                });

            migrationBuilder.CreateTable(
                name: "RelatedMagicCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    relatedCardID = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardstring_id = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedMagicCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedMagicCard_MagiCards_MagicCardstring_id",
                        column: x => x.MagicCardstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                });

            migrationBuilder.CreateTable(
                name: "RelatedUris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    URI = table.Column<string>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardstring_id = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedUris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedUris_MagiCards_MagicCardstring_id",
                        column: x => x.MagicCardstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                });

            migrationBuilder.CreateTable(
                name: "UserMagicCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Count = table.Column<int>(type: "INTEGER", nullable: false),
                    MagicCardstring_id = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCollectionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMagicCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMagicCards_MagiCards_MagicCardstring_id",
                        column: x => x.MagicCardstring_id,
                        principalTable: "MagiCards",
                        principalColumn: "string_id");
                    table.ForeignKey(
                        name: "FK_UserMagicCards_MagicCollections_MagicCollectionId",
                        column: x => x.MagicCollectionId,
                        principalTable: "MagicCollections",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 1, 'A' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 2, 'B' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 3, 'C' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 4, 'D' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 5, 'E' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 6, 'F' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 7, 'G' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 8, 'H' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 9, 'I' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 10, 'J' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 11, 'K' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 12, 'L' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 13, 'M' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 14, 'N' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 15, 'O' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 16, 'P' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 17, 'Q' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 18, 'R' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 19, 'S' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 20, 'T' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 21, 'U' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 22, 'V' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 23, 'W' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 24, 'X' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 25, 'Y' });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "magicColor" },
                values: new object[] { 26, 'Z' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 1, 'A' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 2, 'B' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 3, 'C' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 4, 'D' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 5, 'E' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 6, 'F' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 7, 'G' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 8, 'H' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 9, 'I' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 10, 'J' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 11, 'K' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 12, 'L' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 13, 'M' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 14, 'N' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 15, 'O' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 16, 'P' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 17, 'Q' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 18, 'R' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 19, 'S' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 20, 'T' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 21, 'U' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 22, 'V' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 23, 'W' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 24, 'X' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 25, 'Y' });

            migrationBuilder.InsertData(
                table: "Colors_Identity",
                columns: new[] { "Id", "magicColorIdentity" },
                values: new object[] { 26, 'Z' });

            migrationBuilder.InsertData(
                table: "Finishes",
                columns: new[] { "Id", "finish" },
                values: new object[] { 1, "nonfoil" });

            migrationBuilder.InsertData(
                table: "Finishes",
                columns: new[] { "Id", "finish" },
                values: new object[] { 2, "foil" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 1, "Flying" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 2, "Enchant" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 3, "Cascade" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 4, "Scavenge" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 5, "Manifest" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 6, "Trample" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 7, "Partner" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 8, "Aftermath" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 9, "Equip" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 10, "Flanking" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 11, "Defender" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 12, "Scry" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 13, "Flashback" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 14, "Reach" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 15, "Lifelink" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 16, "First strike" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 17, "Vigilance" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 18, "Transform" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 19, "Kicker" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 20, "Menace" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 21, "Heroic" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 22, "Persist" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 23, "Ascend" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 24, "Parley" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 25, "Mill" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 26, "Imprint" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 27, "Hexproof" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 28, "Convoke" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 29, "Surveil" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 30, "Mutate" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 31, "Hellbent" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 32, "Haste" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 33, "Landcycling" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 34, "Buyback" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 35, "Ward" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 36, "Threshold" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 37, "Foretell" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 38, "Fuse" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 39, "Cumulative upkeep" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 40, "Deathtouch" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 41, "Flash" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 42, "Explore" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 43, "Suspend" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 44, "Exploit" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 45, "Megamorph" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 46, "Ferocious" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 47, "Basic landcycling" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 48, "Fight" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 49, "Double strike" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 50, "Infect" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 51, "Channel" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 52, "Bestow" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 53, "Devoid" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 54, "Protection" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 55, "Typecycling" });

            migrationBuilder.InsertData(
                table: "Keywords",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 56, "Split second" });

            migrationBuilder.InsertData(
                table: "MagicGames",
                columns: new[] { "Id", "magicGame" },
                values: new object[] { 1, "paper" });

            migrationBuilder.InsertData(
                table: "MagicGames",
                columns: new[] { "Id", "magicGame" },
                values: new object[] { 2, "arena" });

            migrationBuilder.InsertData(
                table: "MagicGames",
                columns: new[] { "Id", "magicGame" },
                values: new object[] { 3, "mtgo" });

            migrationBuilder.CreateIndex(
                name: "IX_CardArtistsId_ArtistIdId",
                table: "CardArtistsId",
                column: "ArtistIdId");

            migrationBuilder.CreateIndex(
                name: "IX_CardArtistsId_MagicCardstring_id",
                table: "CardArtistsId",
                column: "MagicCardstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_CardFinishes_FinishId",
                table: "CardFinishes",
                column: "FinishId");

            migrationBuilder.CreateIndex(
                name: "IX_CardFinishes_MagicCardstring_id",
                table: "CardFinishes",
                column: "MagicCardstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_ImageUris_Parentstring_id",
                table: "ImageUris",
                column: "Parentstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_MagiCards_legalitiesId",
                table: "MagiCards",
                column: "legalitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_MagiCards_MagicCardSetId",
                table: "MagiCards",
                column: "MagicCardSetId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColorIdentities_MagicCardstring_id",
                table: "MagicCardColorIdentities",
                column: "MagicCardstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColorIdentities_MagicColorIdentityId",
                table: "MagicCardColorIdentities",
                column: "MagicColorIdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColors_ColorId",
                table: "MagicCardColors",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColors_MagicCardstring_id",
                table: "MagicCardColors",
                column: "MagicCardstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardGames_MagicCardstring_id",
                table: "MagicCardGames",
                column: "MagicCardstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardGames_MagicGameId",
                table: "MagicCardGames",
                column: "MagicGameId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardKeywords_keywordId",
                table: "MagicCardKeywords",
                column: "keywordId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardKeywords_MagicCardstring_id",
                table: "MagicCardKeywords",
                column: "MagicCardstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCollections_UserId",
                table: "MagicCollections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiverseIds_MagicCardstring_id",
                table: "MultiverseIds",
                column: "MagicCardstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_FinishId",
                table: "Prices",
                column: "FinishId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_MagicCardstring_id",
                table: "Prices",
                column: "MagicCardstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedMagicCard_MagicCardstring_id",
                table: "RelatedMagicCard",
                column: "MagicCardstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedUris_MagicCardstring_id",
                table: "RelatedUris",
                column: "MagicCardstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserMagicCards_MagicCardstring_id",
                table: "UserMagicCards",
                column: "MagicCardstring_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserMagicCards_MagicCollectionId",
                table: "UserMagicCards",
                column: "MagicCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSettings_SettingId",
                table: "UserSettings",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSettings_UserId",
                table: "UserSettings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppSettings");

            migrationBuilder.DropTable(
                name: "CardArtistsId");

            migrationBuilder.DropTable(
                name: "CardFinishes");

            migrationBuilder.DropTable(
                name: "ImageUris");

            migrationBuilder.DropTable(
                name: "MagicCardColorIdentities");

            migrationBuilder.DropTable(
                name: "MagicCardColors");

            migrationBuilder.DropTable(
                name: "MagicCardGames");

            migrationBuilder.DropTable(
                name: "MagicCardKeywords");

            migrationBuilder.DropTable(
                name: "MultiverseIds");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "RelatedMagicCard");

            migrationBuilder.DropTable(
                name: "RelatedUris");

            migrationBuilder.DropTable(
                name: "UserMagicCards");

            migrationBuilder.DropTable(
                name: "UserSettings");

            migrationBuilder.DropTable(
                name: "ArtistIDs");

            migrationBuilder.DropTable(
                name: "Colors_Identity");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "MagicGames");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropTable(
                name: "Finishes");

            migrationBuilder.DropTable(
                name: "MagiCards");

            migrationBuilder.DropTable(
                name: "MagicCollections");

            migrationBuilder.DropTable(
                name: "Leglities");

            migrationBuilder.DropTable(
                name: "MagicCardSets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
