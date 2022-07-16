﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PSCHD.DB;

#nullable disable

namespace PSCHD.DB.Migrations
{
    [DbContext(typeof(PSCHD_Context))]
    [Migration("20220716141339_V1")]
    partial class V1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("PSCHD.Model.AppSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AppSettings");
                });

            modelBuilder.Entity("PSCHD.Model.ArtistId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MagicCardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("artistId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MagicCardId");

                    b.ToTable("ArtistIDs");
                });

            modelBuilder.Entity("PSCHD.Model.Finish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MagicCardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("finish")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MagicCardId");

                    b.ToTable("Finishes");
                });

            modelBuilder.Entity("PSCHD.Model.ImageUris", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ImageSize")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("URI")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("ImageUris");
                });

            modelBuilder.Entity("PSCHD.Model.Legalities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("alchemy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("brawl")
                        .HasColumnType("INTEGER");

                    b.Property<int>("commander")
                        .HasColumnType("INTEGER");

                    b.Property<int>("duel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("future")
                        .HasColumnType("INTEGER");

                    b.Property<int>("gladiator")
                        .HasColumnType("INTEGER");

                    b.Property<int>("historic")
                        .HasColumnType("INTEGER");

                    b.Property<int>("historicbrawl")
                        .HasColumnType("INTEGER");

                    b.Property<int>("legacy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("modern")
                        .HasColumnType("INTEGER");

                    b.Property<int>("oldschool")
                        .HasColumnType("INTEGER");

                    b.Property<int>("pauper")
                        .HasColumnType("INTEGER");

                    b.Property<int>("paupercommander")
                        .HasColumnType("INTEGER");

                    b.Property<int>("penny")
                        .HasColumnType("INTEGER");

                    b.Property<int>("pioneer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("premodern")
                        .HasColumnType("INTEGER");

                    b.Property<int>("standard")
                        .HasColumnType("INTEGER");

                    b.Property<int>("vintage")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Leglities");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cardset")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cardset_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cardset_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cardset_search_uri")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cardset_type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cardset_uri")
                        .HasColumnType("TEXT");

                    b.Property<string>("_object")
                        .HasColumnType("TEXT");

                    b.Property<string>("artist")
                        .HasColumnType("TEXT");

                    b.Property<bool>("booster")
                        .HasColumnType("INTEGER");

                    b.Property<string>("border_color")
                        .HasColumnType("TEXT");

                    b.Property<string>("card_back_id")
                        .HasColumnType("TEXT");

                    b.Property<int?>("cardmarket_id")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("cmc")
                        .HasColumnType("REAL");

                    b.Property<string>("collector_number")
                        .HasColumnType("TEXT");

                    b.Property<bool>("digital")
                        .HasColumnType("INTEGER");

                    b.Property<int>("edhrec_rank")
                        .HasColumnType("INTEGER");

                    b.Property<string>("flavor_text")
                        .HasColumnType("TEXT");

                    b.Property<bool>("foil")
                        .HasColumnType("INTEGER");

                    b.Property<string>("frame")
                        .HasColumnType("TEXT");

                    b.Property<bool>("full_art")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("highres_image")
                        .HasColumnType("INTEGER");

                    b.Property<string>("illustration_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("image_status")
                        .HasColumnType("TEXT");

                    b.Property<string>("lang")
                        .HasColumnType("TEXT");

                    b.Property<string>("layout")
                        .HasColumnType("TEXT");

                    b.Property<int?>("legalitiesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("mana_cost")
                        .HasColumnType("TEXT");

                    b.Property<int?>("mtgo_foil_id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("mtgo_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<bool>("nonfoil")
                        .HasColumnType("INTEGER");

                    b.Property<string>("oracle_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("oracle_text")
                        .HasColumnType("TEXT");

                    b.Property<bool>("oversized")
                        .HasColumnType("INTEGER");

                    b.Property<string>("power")
                        .HasColumnType("TEXT");

                    b.Property<string>("prints_search_uri")
                        .HasColumnType("TEXT");

                    b.Property<bool>("promo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("rarity")
                        .HasColumnType("TEXT");

                    b.Property<string>("released_at")
                        .HasColumnType("TEXT");

                    b.Property<bool>("reprint")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("reserved")
                        .HasColumnType("INTEGER");

                    b.Property<string>("rulings_uri")
                        .HasColumnType("TEXT");

                    b.Property<string>("scryfall_set_uri")
                        .HasColumnType("TEXT");

                    b.Property<string>("scryfall_uri")
                        .HasColumnType("TEXT");

                    b.Property<bool>("story_spotlight")
                        .HasColumnType("INTEGER");

                    b.Property<string>("string_id")
                        .HasColumnType("TEXT");

                    b.Property<int?>("tcgplayer_id")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("textless")
                        .HasColumnType("INTEGER");

                    b.Property<string>("toughness")
                        .HasColumnType("TEXT");

                    b.Property<string>("type_line")
                        .HasColumnType("TEXT");

                    b.Property<string>("uri")
                        .HasColumnType("TEXT");

                    b.Property<bool>("variation")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("legalitiesId");

                    b.ToTable("MagiCards");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCardColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MagicCardId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("MagicCardId");

                    b.ToTable("MagicCardColors");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCardColorIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MagicCardId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MagicColorIdentityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MagicCardId");

                    b.HasIndex("MagicColorIdentityId");

                    b.ToTable("MagicCardColorIdentities");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCardKeyword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MagicCardId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("keywordId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MagicCardId");

                    b.HasIndex("keywordId");

                    b.ToTable("MagicCardKeyword");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MagicCollections");
                });

            modelBuilder.Entity("PSCHD.Model.MagicColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<char>("magicColor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("PSCHD.Model.MagicColorIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<char>("magicColorIdentity")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colors_Identity");
                });

            modelBuilder.Entity("PSCHD.Model.MagicGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MagicCardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("magicGame")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MagicCardId");

                    b.ToTable("MagicGames");
                });

            modelBuilder.Entity("PSCHD.Model.MagicKeyword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Keyword")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MagicKeyword");
                });

            modelBuilder.Entity("PSCHD.Model.MultiverseId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("multiVerseId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("MultiverseIds");
                });

            modelBuilder.Entity("PSCHD.Model.Prices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FinishId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("currency")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("datetime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FinishId");

                    b.HasIndex("ParentId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("PSCHD.Model.RelatedUris", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.Property<string>("URI")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("RelatedUris");
                });

            modelBuilder.Entity("PSCHD.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Salt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PSCHD.Model.UserMagicCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MagicCardId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MagicCollectionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MagicCardId");

                    b.HasIndex("MagicCollectionId");

                    b.ToTable("UserMagicCards");
                });

            modelBuilder.Entity("PSCHD.Model.UserSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SettingId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Vlue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SettingId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("PSCHD.Model.ArtistId", b =>
                {
                    b.HasOne("PSCHD.Model.MagicCard", null)
                        .WithMany("artist_ids")
                        .HasForeignKey("MagicCardId");
                });

            modelBuilder.Entity("PSCHD.Model.Finish", b =>
                {
                    b.HasOne("PSCHD.Model.MagicCard", null)
                        .WithMany("finishes")
                        .HasForeignKey("MagicCardId");
                });

            modelBuilder.Entity("PSCHD.Model.ImageUris", b =>
                {
                    b.HasOne("PSCHD.Model.MagicCard", "Parent")
                        .WithMany("image_uris")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCard", b =>
                {
                    b.HasOne("PSCHD.Model.Legalities", "legalities")
                        .WithMany()
                        .HasForeignKey("legalitiesId");

                    b.Navigation("legalities");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCardColor", b =>
                {
                    b.HasOne("PSCHD.Model.MagicColor", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("PSCHD.Model.MagicCard", "MagicCard")
                        .WithMany("colors")
                        .HasForeignKey("MagicCardId");

                    b.Navigation("Color");

                    b.Navigation("MagicCard");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCardColorIdentity", b =>
                {
                    b.HasOne("PSCHD.Model.MagicCard", "MagicCard")
                        .WithMany("color_identity")
                        .HasForeignKey("MagicCardId");

                    b.HasOne("PSCHD.Model.MagicColorIdentity", "MagicColorIdentity")
                        .WithMany()
                        .HasForeignKey("MagicColorIdentityId");

                    b.Navigation("MagicCard");

                    b.Navigation("MagicColorIdentity");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCardKeyword", b =>
                {
                    b.HasOne("PSCHD.Model.MagicCard", "MagicCard")
                        .WithMany("keywords")
                        .HasForeignKey("MagicCardId");

                    b.HasOne("PSCHD.Model.MagicKeyword", "keyword")
                        .WithMany()
                        .HasForeignKey("keywordId");

                    b.Navigation("MagicCard");

                    b.Navigation("keyword");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCollection", b =>
                {
                    b.HasOne("PSCHD.Model.User", "User")
                        .WithMany("Collections")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PSCHD.Model.MagicGame", b =>
                {
                    b.HasOne("PSCHD.Model.MagicCard", null)
                        .WithMany("games")
                        .HasForeignKey("MagicCardId");
                });

            modelBuilder.Entity("PSCHD.Model.MultiverseId", b =>
                {
                    b.HasOne("PSCHD.Model.MagicCard", "Parent")
                        .WithMany("multiverse_ids")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("PSCHD.Model.Prices", b =>
                {
                    b.HasOne("PSCHD.Model.Finish", "Finish")
                        .WithMany()
                        .HasForeignKey("FinishId");

                    b.HasOne("PSCHD.Model.MagicCard", "Parent")
                        .WithMany("prices")
                        .HasForeignKey("ParentId");

                    b.Navigation("Finish");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("PSCHD.Model.RelatedUris", b =>
                {
                    b.HasOne("PSCHD.Model.MagicCard", "Parent")
                        .WithMany("related_uris")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("PSCHD.Model.UserMagicCard", b =>
                {
                    b.HasOne("PSCHD.Model.MagicCard", "MagicCard")
                        .WithMany()
                        .HasForeignKey("MagicCardId");

                    b.HasOne("PSCHD.Model.MagicCollection", null)
                        .WithMany("UserMagicCards")
                        .HasForeignKey("MagicCollectionId");

                    b.Navigation("MagicCard");
                });

            modelBuilder.Entity("PSCHD.Model.UserSetting", b =>
                {
                    b.HasOne("PSCHD.Model.UserSetting", "Setting")
                        .WithMany()
                        .HasForeignKey("SettingId");

                    b.HasOne("PSCHD.Model.User", "User")
                        .WithMany("Settings")
                        .HasForeignKey("UserId");

                    b.Navigation("Setting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCard", b =>
                {
                    b.Navigation("artist_ids");

                    b.Navigation("color_identity");

                    b.Navigation("colors");

                    b.Navigation("finishes");

                    b.Navigation("games");

                    b.Navigation("image_uris");

                    b.Navigation("keywords");

                    b.Navigation("multiverse_ids");

                    b.Navigation("prices");

                    b.Navigation("related_uris");
                });

            modelBuilder.Entity("PSCHD.Model.MagicCollection", b =>
                {
                    b.Navigation("UserMagicCards");
                });

            modelBuilder.Entity("PSCHD.Model.User", b =>
                {
                    b.Navigation("Collections");

                    b.Navigation("Settings");
                });
#pragma warning restore 612, 618
        }
    }
}
