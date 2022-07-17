using PSCHD.Core;
using PSCHD.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSCHD
{
    public static class ParseMagicCards
    {
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
            //if (rawMagicCard.prices.eur != null)
            //{
            //    result.prices.Add(new Prices
            //    {
            //        currency = "EUR",
            //        MagicCard = result,
            //        Price = decimal.TryParse(,rawMagicCard.prices.eur)
            //    });
            //}
        }
    }
}
