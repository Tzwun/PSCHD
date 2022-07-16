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
                name: "MagicKeyword",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Keyword = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicKeyword", x => x.Id);
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _object = table.Column<string>(type: "TEXT", nullable: true),
                    string_id = table.Column<string>(type: "TEXT", nullable: true),
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
                    Cardset_id = table.Column<string>(type: "TEXT", nullable: true),
                    Cardset = table.Column<string>(type: "TEXT", nullable: true),
                    Cardset_name = table.Column<string>(type: "TEXT", nullable: true),
                    Cardset_type = table.Column<string>(type: "TEXT", nullable: true),
                    Cardset_uri = table.Column<string>(type: "TEXT", nullable: true),
                    Cardset_search_uri = table.Column<string>(type: "TEXT", nullable: true),
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
                    legalitiesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagiCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagiCards_Leglities_legalitiesId",
                        column: x => x.legalitiesId,
                        principalTable: "Leglities",
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
                name: "ArtistIDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    artistId = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistIDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistIDs_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Finishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    finish = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Finishes_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ImageUris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    URI = table.Column<string>(type: "TEXT", nullable: true),
                    ImageSize = table.Column<int>(type: "INTEGER", nullable: false),
                    ParentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageUris_MagiCards_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MagicCardColorIdentities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MagicColorIdentityId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
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
                        name: "FK_MagicCardColorIdentities_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MagicCardColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ColorId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
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
                        name: "FK_MagicCardColors_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MagicCardGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MagicGameId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCardGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicCardGames_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MagicCardGames_MagicGames_MagicGameId",
                        column: x => x.MagicGameId,
                        principalTable: "MagicGames",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MagicCardKeyword",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    keywordId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCardKeyword", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicCardKeyword_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MagicCardKeyword_MagicKeyword_keywordId",
                        column: x => x.keywordId,
                        principalTable: "MagicKeyword",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MultiverseIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    multiVerseId = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiverseIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiverseIds_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RelatedUris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    URI = table.Column<string>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedUris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedUris_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserMagicCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Count = table.Column<int>(type: "INTEGER", nullable: false),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCollectionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMagicCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMagicCards_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserMagicCards_MagicCollections_MagicCollectionId",
                        column: x => x.MagicCollectionId,
                        principalTable: "MagicCollections",
                        principalColumn: "Id");
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
                    datetime = table.Column<DateTime>(type: "TEXT", rowVersion: true, nullable: false),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
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
                        name: "FK_Prices_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
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

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 1, "Flying" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 2, "Enchant" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 3, "Cascade" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 4, "Scavenge" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 5, "Manifest" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 6, "Trample" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 7, "Partner" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 8, "Aftermath" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 9, "Equip" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 10, "Flanking" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 11, "Defender" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 12, "Scry" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 13, "Flashback" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 14, "Reach" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 15, "Lifelink" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 16, "First strike" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 17, "Vigilance" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 18, "Transform" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 19, "Kicker" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 20, "Menace" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 21, "Heroic" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 22, "Persist" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 23, "Ascend" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 24, "Parley" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 25, "Mill" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 26, "Imprint" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 27, "Hexproof" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 28, "Convoke" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 29, "Surveil" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 30, "Mutate" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 31, "Hellbent" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 32, "Haste" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 33, "Landcycling" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 34, "Buyback" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 35, "Ward" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 36, "Threshold" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 37, "Foretell" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 38, "Fuse" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 39, "Cumulative upkeep" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 40, "Deathtouch" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 41, "Flash" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 42, "Explore" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 43, "Suspend" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 44, "Exploit" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 45, "Megamorph" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 46, "Ferocious" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 47, "Basic landcycling" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 48, "Fight" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 49, "Double strike" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 50, "Infect" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 51, "Channel" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 52, "Bestow" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 53, "Devoid" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 54, "Protection" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 55, "Typecycling" });

            migrationBuilder.InsertData(
                table: "MagicKeyword",
                columns: new[] { "Id", "Keyword" },
                values: new object[] { 56, "Split second" });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistIDs_MagicCardId",
                table: "ArtistIDs",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Finishes_MagicCardId",
                table: "Finishes",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageUris_ParentId",
                table: "ImageUris",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_MagiCards_legalitiesId",
                table: "MagiCards",
                column: "legalitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColorIdentities_MagicCardId",
                table: "MagicCardColorIdentities",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColorIdentities_MagicColorIdentityId",
                table: "MagicCardColorIdentities",
                column: "MagicColorIdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColors_ColorId",
                table: "MagicCardColors",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColors_MagicCardId",
                table: "MagicCardColors",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardGames_MagicCardId",
                table: "MagicCardGames",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardGames_MagicGameId",
                table: "MagicCardGames",
                column: "MagicGameId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardKeyword_keywordId",
                table: "MagicCardKeyword",
                column: "keywordId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardKeyword_MagicCardId",
                table: "MagicCardKeyword",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCollections_UserId",
                table: "MagicCollections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiverseIds_MagicCardId",
                table: "MultiverseIds",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_FinishId",
                table: "Prices",
                column: "FinishId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_MagicCardId",
                table: "Prices",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedUris_MagicCardId",
                table: "RelatedUris",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMagicCards_MagicCardId",
                table: "UserMagicCards",
                column: "MagicCardId");

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
                name: "ArtistIDs");

            migrationBuilder.DropTable(
                name: "ImageUris");

            migrationBuilder.DropTable(
                name: "MagicCardColorIdentities");

            migrationBuilder.DropTable(
                name: "MagicCardColors");

            migrationBuilder.DropTable(
                name: "MagicCardGames");

            migrationBuilder.DropTable(
                name: "MagicCardKeyword");

            migrationBuilder.DropTable(
                name: "MultiverseIds");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "RelatedUris");

            migrationBuilder.DropTable(
                name: "UserMagicCards");

            migrationBuilder.DropTable(
                name: "UserSettings");

            migrationBuilder.DropTable(
                name: "Colors_Identity");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "MagicGames");

            migrationBuilder.DropTable(
                name: "MagicKeyword");

            migrationBuilder.DropTable(
                name: "Finishes");

            migrationBuilder.DropTable(
                name: "MagicCollections");

            migrationBuilder.DropTable(
                name: "MagiCards");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Leglities");
        }
    }
}
