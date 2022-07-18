using Newtonsoft.Json.Linq;
using PSCHD.Core;
using PSCHD.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Globalization;
using PSCHD.DB;

namespace PSCHD
{
    public static class ParseMagicCards
    {
        private static MagicCardRepository _repository;
        private static MagicCard _card;
        public static MagicCard Parse(RawMagicCard rawMagicCard)
        {
            MagicCard result = new MagicCard
            {
                string_id = rawMagicCard.id,
                oracle_id = rawMagicCard.oracle_id,
                mtgo_id = rawMagicCard.mtgo_id,
                mtgo_foil_id = rawMagicCard.mtgo_foil_id,
                tcgplayer_id = rawMagicCard.tcgplayer_id,
                cardmarket_id = rawMagicCard.cardmarket_id,
                name = rawMagicCard.name,
                lang = rawMagicCard.lang,
                released_at = rawMagicCard.released_at,
                uri = rawMagicCard.uri,
                scryfall_set_uri = rawMagicCard.scryfall_set_uri,
                scryfall_uri = rawMagicCard.scryfall_uri,
                layout = rawMagicCard.layout,
                highres_image = rawMagicCard.highres_image,
                image_status = rawMagicCard.image_status,
                mana_cost = rawMagicCard.mana_cost,
                cmc = rawMagicCard.cmc,
                type_line = rawMagicCard.type_line,
                oracle_text = rawMagicCard.oracle_text,
                power = rawMagicCard.power,
                toughness = rawMagicCard.toughness,
                reserved = rawMagicCard.reserved,
                foil = rawMagicCard.foil,
                nonfoil = rawMagicCard.nonfoil,
                oversized = rawMagicCard.oversized,
                promo = rawMagicCard.promo,
                reprint = rawMagicCard.reprint,
                variation = rawMagicCard.variation,
                Cardset_id = "",
                Cardset_name = "",
                Cardset = "",
                Cardset_type = rawMagicCard.set_type,
                Cardset_uri = "",
                Cardset_search_uri = rawMagicCard.set_search_uri,
                rulings_uri = rawMagicCard.rulings_uri,
                prints_search_uri = rawMagicCard.prints_search_uri,
                collector_number = rawMagicCard.collector_number,
                digital = rawMagicCard.digital,
                rarity = rawMagicCard.rarity,
                flavor_text = rawMagicCard.flavor_text,
                card_back_id = rawMagicCard.card_back_id,
                artist = rawMagicCard.artist,
                illustration_id = rawMagicCard.illustration_id,
                border_color = rawMagicCard.border_color,
                frame = rawMagicCard.frame,
                full_art = rawMagicCard.full_art,
                textless = rawMagicCard.textless,
                booster = rawMagicCard.booster,
                story_spotlight = rawMagicCard.story_spotlight,
                edhrec_rank = rawMagicCard.edhrec_rank
            };

            return result;
        }

        public static MagicCard Parse(JObject obj, MagicCardRepository repository)
        {
            _repository = repository;
            _card = new MagicCard();

            foreach (var item in obj.Properties())
            {
                switch (item.Name)
                {
                    case "id":
                        _card.string_id = obj.Value<string>("id");
                        break;
                    case "oracle_id":
                        _card.oracle_id = obj.Value<string>("oracle_id");
                        break;
                    case "mtgo_id":
                        _card.mtgo_id = obj.Value<int?>("mtgo_id");
                        break;
                    case "mtgo_foil_id":
                        _card.mtgo_foil_id = obj.Value<int?>("mtgo_foil_id");
                        break;
                    case "tcgplayer_id":
                        _card.tcgplayer_id = obj.Value<int?>("tcgplayer_id");
                        break;
                    case "cardmarket_id":
                        _card.cardmarket_id = obj.Value<int?>("cardmarket_id");
                        break;
                    case "name":
                        _card.name = obj.Value<string>("name");
                        break;
                    case "lang":
                        _card.lang = obj.Value<string>("lang");
                        break;
                    case "released_at":
                        _card.released_at = obj.Value<string>("released_at");
                        break;
                    case "uri":
                        _card.uri = obj.Value<string>("uri");
                        break;
                    case "scryfall_set_uri":
                        _card.scryfall_set_uri = obj.Value<string>("scryfall_set_uri");
                        break;
                    case "scryfall_uri":
                        _card.scryfall_uri = obj.Value<string>("scryfall_uri");
                        break;
                    case "layout":
                        _card.layout = obj.Value<string>("layout");
                        break;
                    case "highres_image":
                        _card.highres_image = obj.Value<bool>("highres_image");
                        break;
                    case "image_status":
                        _card.image_status = obj.Value<string>("image_status");
                        break;
                    case "mana_cost":
                        _card.mana_cost = obj.Value<string>("mana_cost");
                        break;
                    case "cmc":
                        _card.cmc = obj.Value<double?>("cmc");
                        break;
                    case "type_line":
                        _card.type_line = obj.Value<string>("type_line");
                        break;
                    case "oracle_text":
                        _card.oracle_text = obj.Value<string>("oracle_text");
                        break;
                    case "power":
                        _card.power = obj.Value<string>("power");
                        break;
                    case "toughness":
                        _card.toughness = obj.Value<string>("toughness");
                        break;
                    case "reserved":
                        _card.reserved = obj.Value<bool>("reserved");
                        break;
                    case "foil":
                        _card.foil = obj.Value<bool>("foil");
                        break;
                    case "nonfoil":
                        _card.nonfoil = obj.Value<bool>("nonfoil");
                        break;
                    case "oversized":
                        _card.oversized = obj.Value<bool>("oversized");
                        break;
                    case "promo":
                        _card.promo = obj.Value<bool>("promo");
                        break;
                    case "reprint":
                        _card.reprint = obj.Value<bool>("reprint");
                        break;
                    case "variation":
                        _card.variation = obj.Value<bool>("variation");
                        break;
                    case "set_id":
                        _card.Cardset_id = obj.Value<string>("set_id");
                        break;
                    case "set_name":
                        _card.Cardset_name = obj.Value<string>("set_name");
                        break;
                    case "set":
                        _card.Cardset = obj.Value<string>("set");
                        break;
                    case "set_type":
                        _card.Cardset_type = obj.Value<string>("set_type");
                        break;
                    case "set_uri":
                        _card.Cardset_uri = obj.Value<string>("set_uri");
                        break;
                    case "set_search_uri":
                        _card.Cardset_search_uri = obj.Value<string>("set_search_uri");
                        break;
                    case "rulings_uri":
                        _card.rulings_uri = obj.Value<string>("rulings_uri");
                        break;
                    case "prints_search_uri":
                        _card.prints_search_uri = obj.Value<string>("prints_search_uri");
                        break;
                    case "collector_number":
                        _card.collector_number = obj.Value<string>("collector_number");
                        break;
                    case "digital":
                        _card.digital = obj.Value<bool>("digital");
                        break;
                    case "rarity":
                        _card.rarity = obj.Value<string>("rarity");
                        break;
                    case "flavor_text":
                        _card.flavor_text = obj.Value<string>("flavor_text");
                        break;
                    case "card_back_id":
                        _card.card_back_id = obj.Value<string>("card_back_id");
                        break;
                    case "artist":
                        _card.artist = obj.Value<string>("artist");
                        break;
                    case "illustration_id":
                        _card.illustration_id = obj.Value<string>("illustration_id");
                        break;
                    case "border_color":
                        _card.border_color = obj.Value<string>("border_color");
                        break;
                    case "frame":
                        _card.frame = obj.Value<string>("frame");
                        break;
                    case "full_art":
                        _card.full_art = obj.Value<bool>("full_art");
                        break;
                    case "textless":
                        _card.textless = obj.Value<bool>("textless");
                        break;
                    case "booster":
                        _card.booster = obj.Value<bool>("booster");
                        break;
                    case "story_spotlight":
                        _card.story_spotlight = obj.Value<bool>("story_spotlight");
                        break;
                    case "edhrec_rank":
                        _card.edhrec_rank = obj.Value<int>("edhrec_rank");
                        break;
                    case "prices":
                        _card.prices = retrievePrices(item, obj);
                        break;
                    case "legalities":
                        _card.legalities = retrieveLegalities(item, obj);
                        break;
                    case "games":
                        _card.games = retrieveGames(item, obj);
                        break;
                    case "finishes":
                        _card.finishes = retrieveFinishes(item, obj);
                        break;
                    case "related_uris":
                        _card.related_uris = retrieveRelatedUris(item, obj);
                        break;
                    case "colors":
                        _card.colors = retrieveColors(item, obj);
                        break;
                    case "color_identity":
                        _card.color_identity = retrieveColorIdentity(item, obj);
                        break;
                    case "keywords":
                        _card.keywords = retrieveKeywords(item, obj);
                        break;
                    case "artist_ids":
                        _card.CardArtistsIds = retrieveArtistIds(item, obj);
                        break;
                    case "multiverse_ids":
                        _card.multiverse_ids = retrieveMultiverseIds(item, obj);
                        break;
                    case "image_uris":
                        _card.image_uris = retrieveImageUris(item, obj);
                        break;
                    case "all_parts": // Related Cards
                        _card.relatedCards = retrieveRelatedCards(item, obj);
                        break;
                    default:
                        break;
                }
            }

            return _card;
        }

        private static ObservableCollection<RelatedMagicCard> retrieveRelatedCards(JProperty prop, JObject obj)
        {
            var result = new ObservableCollection<RelatedMagicCard>();

            var finishes = _repository.GetAvailableFinishes();

            foreach (var item in obj["all_parts"])
            {
                result.Add(new RelatedMagicCard { relatedCardID = item["id"].Value<string>() });
            }

            return result;
        }

        private static ObservableCollection<ImageUris> retrieveImageUris(JProperty prop, JObject obj)
        {
            var result = new ObservableCollection<ImageUris>();

            foreach (JProperty item in obj["image_uris"])
            {
                if (item.Name == "small" && item.First.Value<string>() != null)
                {
                    result.Add(new ImageUris
                    {
                        ImageSize = ImageSize.small,
                        URI = item.First.Value<string>(),
                        Parent = _card
                    });
                }
                if (item.Name == "art_crop" && item.First.Value<string>() != null)
                {
                    result.Add(new ImageUris
                    {
                        ImageSize = ImageSize.art_crop,
                        URI = item.First.Value<string>(),
                        Parent = _card
                    });
                }
                if (item.Name == "border_crop" && item.First.Value<string>() != null)
                {
                    result.Add(new ImageUris
                    {
                        ImageSize = ImageSize.border_crop,
                        URI = item.First.Value<string>(),
                        Parent = _card
                    });
                }
                if (item.Name == "large" && item.First.Value<string>() != null)
                {
                    result.Add(new ImageUris
                    {
                        ImageSize = ImageSize.large,
                        URI = item.First.Value<string>(),
                        Parent = _card
                    });
                }
                if (item.Name == "png" && item.First.Value<string>() != null)
                {
                    result.Add(new ImageUris
                    {
                        ImageSize = ImageSize.png,
                        URI = item.First.Value<string>(),
                        Parent = _card
                    });
                }
                if (item.Name == "normal" && item.First.Value<string>() != null)
                {
                    result.Add(new ImageUris
                    {
                        ImageSize = ImageSize.normal,
                        URI = item.First.Value<string>(),
                        Parent = _card
                    });
                }
            }
            return result;
        }

        private static ObservableCollection<MultiverseId> retrieveMultiverseIds(JProperty prop, JObject obj)
        {
            var result = new ObservableCollection<MultiverseId>();

            foreach (var item in obj["multiverse_ids"].Values<int>())
            {
                result.Add(new MultiverseId
                {
                    multiVerseId = item.ToString(),
                    MagicCard = _card
                });
            }
            return result;
        }

        private static ObservableCollection<CardArtistsId> retrieveArtistIds(JProperty prop, JObject obj)
        {
            var result = new ObservableCollection<CardArtistsId>();
            foreach (var item in obj["artist_ids"].Values<string>())
            {
                if (item != null)
                {
                    ArtistId artistId = _repository.RetrieveArtistId(item);
                    if (artistId == null)
                    {
                        artistId = new ArtistId { artistId = item };
                    }

                    result.Add(new CardArtistsId
                    {
                        ArtistId = artistId,
                        MagicCard = _card
                    });
                }
            }
            return result;
        }

        private static ObservableCollection<MagicCardKeyword> retrieveKeywords(JProperty prop, JObject obj)
        {
            var result = new ObservableCollection<MagicCardKeyword>();
            foreach (var item in obj["keywords"].Values<string>())
            {
                if (item != null)
                {
                    MagicKeyword magicKeyword = _repository.RetrieveKeyword(item);
                    if (magicKeyword == null)
                    {
                        magicKeyword = new MagicKeyword { Keyword = item };
                    }

                    result.Add(new MagicCardKeyword
                    {
                        keyword = magicKeyword,
                        MagicCard = _card
                    });
                }
            }
            return result;
        }

        private static ObservableCollection<MagicCardColorIdentity> retrieveColorIdentity(JProperty prop, JObject obj)
        {
            var result = new ObservableCollection<MagicCardColorIdentity>();

            foreach (var item in obj["color_identity"].Values<char>())
            {
                MagicColorIdentity magicColorIdentity = _repository.RetrieveColorIdentity(item);

                result.Add(new MagicCardColorIdentity
                {
                    MagicColorIdentity = magicColorIdentity,
                    MagicCard = _card
                });
            }
            return result;
        }

        private static ObservableCollection<MagicCardColor> retrieveColors(JProperty prop, JObject obj)
        {
            var result = new ObservableCollection<MagicCardColor>();

            foreach (var item in obj["colors"].Values<char>())
            {
                MagicColor magicColor = _repository.RetrieveColor(item);

                result.Add(new MagicCardColor
                {
                    Color = magicColor,
                    MagicCard = _card
                });
            }

            return result;
        }

        private static ObservableCollection<RelatedUris> retrieveRelatedUris(JProperty prop, JObject obj)
        {
            var result = new ObservableCollection<RelatedUris>();

            foreach (JProperty item in obj["related_uris"])
            {
                if (item.First.Value<string>() != null)
                {
                    result.Add(new RelatedUris
                    {
                        Source = item.Name,
                        URI = item.First.Value<string>(),
                        MagicCard = _card
                    });
                }
            }
            return result;
        }

        private static ObservableCollection<CardFinish> retrieveFinishes(JProperty prop, JObject obj)
        {
            var result = new ObservableCollection<CardFinish>();

            foreach (var item in obj["finishes"].Values<string>())
            {
                if (item != null)
                {
                    Finish cardFinish = _repository.RetrieveFinish(item);
                    if (cardFinish == null)
                    {
                        cardFinish = new Finish { finish = item };
                    }

                    result.Add(new CardFinish
                    {
                        Finish = cardFinish,
                        MagicCard = _card
                    });
                }
            }
            return result;
        }

        private static ObservableCollection<MagicCardGame> retrieveGames(JProperty prop, JObject obj)
        {
            var result = new ObservableCollection<MagicCardGame>();
            foreach (var item in obj["games"].Values<string>())
            {
                if (item != null)
                {
                    MagicGame magicGame = _repository.RetrieveGame(item);
                    if (magicGame == null)
                    {
                        magicGame = new MagicGame { magicGame = item };
                    }

                    result.Add(new MagicCardGame
                    {
                        MagicGame = magicGame,
                        MagicCard = _card
                    });
                }
            }
            return result;
        }

        private static Legalities retrieveLegalities(JProperty prop, JObject obj)
        {
            var result = new Legalities();

            foreach (JProperty item in obj["legalities"])
            {
                if (item.Name == "pauper" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.pauper = Legality.not_legal;
                    }
                    else
                    {
                        result.pauper = Legality.legal;
                    }
                }

                if (item.Name == "legacy" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.legacy = Legality.not_legal;
                    }
                    else
                    {
                        result.legacy = Legality.legal;
                    }
                }

                if (item.Name == "premodern" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.premodern = Legality.not_legal;
                    }
                    else
                    {
                        result.premodern = Legality.legal;
                    }
                }

                if (item.Name == "commander" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.commander = Legality.not_legal;
                    }
                    else
                    {
                        result.commander = Legality.legal;
                    }
                }

                if (item.Name == "paupercommander" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.paupercommander = Legality.not_legal;
                    }
                    else
                    {
                        result.paupercommander = Legality.legal;
                    }
                }

                if (item.Name == "duel" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.duel = Legality.not_legal;
                    }
                    else
                    {
                        result.duel = Legality.legal;
                    }
                }

                if (item.Name == "alchemy" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.alchemy = Legality.not_legal;
                    }
                    else
                    {
                        result.alchemy = Legality.legal;
                    }
                }

                if (item.Name == "brawl" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.brawl = Legality.not_legal;
                    }
                    else
                    {
                        result.brawl = Legality.legal;
                    }
                }

                if (item.Name == "future" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.future = Legality.not_legal;
                    }
                    else
                    {
                        result.future = Legality.legal;
                    }
                }

                if (item.Name == "gladiator" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.gladiator = Legality.not_legal;
                    }
                    else
                    {
                        result.gladiator = Legality.legal;
                    }
                }

                if (item.Name == "historic" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.historic = Legality.not_legal;
                    }
                    else
                    {
                        result.historic = Legality.legal;
                    }
                }

                if (item.Name == "historicbrawl" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.historicbrawl = Legality.not_legal;
                    }
                    else
                    {
                        result.historicbrawl = Legality.legal;
                    }
                }

                if (item.Name == "oldschool" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.oldschool = Legality.not_legal;
                    }
                    else
                    {
                        result.oldschool = Legality.legal;
                    }
                }

                if (item.Name == "penny" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.penny = Legality.not_legal;
                    }
                    else
                    {
                        result.penny = Legality.legal;
                    }
                }

                if (item.Name == "pioneer" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.pioneer = Legality.not_legal;
                    }
                    else
                    {
                        result.pioneer = Legality.legal;
                    }
                }

                if (item.Name == "vintage" && item.First.Value<string>() != null)
                {
                    if (item.First.Value<string>() == Legality.not_legal.ToString())
                    {
                        result.vintage = Legality.not_legal;
                    }
                    else
                    {
                        result.vintage = Legality.legal;
                    }
                }
            }
            return result;
        }

        private static ObservableCollection<Prices> retrievePrices(JProperty prop, JObject obj)
        {
            var finishes = _repository.GetAvailableFinishes();
            var result = new ObservableCollection<Prices>();

            foreach (JProperty item in obj[prop.Name])
            {
                if (item.Name == "usd" && item.First.Value<string>() != null)
                {
                    result.Add(new Prices
                    {
                        currency = "usd",
                        Price = decimal.Parse(item.First.Value<string>(), CultureInfo.InvariantCulture),
                        datetime = DateTime.UtcNow,
                        MagicCard = _card,
                        Finish = finishes.Single(e => e.Id == 1)
                    });
                }
                if (item.Name == "usd_foil" && item.First.Value<string>() != null)
                {
                    result.Add(new Prices
                    {
                        currency = "usd",
                        Price = decimal.Parse(item.First.Value<string>(), CultureInfo.InvariantCulture),
                        datetime = DateTime.UtcNow,
                        MagicCard = _card,
                        Finish = finishes.Single(e => e.Id == 2)
                    });
                }
                if (item.Name == "eur" && item.First.Value<string>() != null)
                {
                    result.Add(new Prices
                    {
                        currency = "eur",
                        Price = decimal.Parse(item.First.Value<string>(), CultureInfo.InvariantCulture),
                        datetime = DateTime.UtcNow,
                        MagicCard = _card,
                        Finish = finishes.Single(e => e.Id == 1)
                    });
                }
                if (item.Name == "eur_foil" && item.First.Value<string>() != null)
                {
                    result.Add(new Prices
                    {
                        currency = "eur",
                        Price = decimal.Parse(item.First.Value<string>(), CultureInfo.InvariantCulture),
                        datetime = DateTime.UtcNow,
                        MagicCard = _card,
                        Finish = finishes.Single(e => e.Id == 2)
                    });
                }
            }
            return result;
        }
    }
}
