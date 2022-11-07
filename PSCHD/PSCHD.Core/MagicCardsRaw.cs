using Newtonsoft.Json;
using System.Collections.Generic;

namespace PSCHD.Core
{
    public class RawMagicCards : List<RawMagicCard>
    { }

    public class RawImageUris
    {
        public string small { get; set; }
        public string normal { get; set; }
        public string large { get; set; }
        public string png { get; set; }
        public string art_crop { get; set; }
        public string border_crop { get; set; }
    }

    public class RawLegalities
    {
        public string standard { get; set; }
        public string future { get; set; }
        public string historic { get; set; }
        public string gladiator { get; set; }
        public string pioneer { get; set; }
        public string modern { get; set; }
        public string legacy { get; set; }
        public string pauper { get; set; }
        public string vintage { get; set; }
        public string penny { get; set; }
        public string commander { get; set; }
        public string brawl { get; set; }
        public string historicbrawl { get; set; }
        public string alchemy { get; set; }
        public string paupercommander { get; set; }
        public string duel { get; set; }
        public string oldschool { get; set; }
        public string premodern { get; set; }
    }

    public class RawPrices
    {
        public string usd { get; set; }
        public string usd_foil { get; set; }
        public object usd_etched { get; set; }
        public string eur { get; set; }
        public string eur_foil { get; set; }
        public string tix { get; set; }
    }

    public class RawRelatedUris
    {
        public string gatherer { get; set; }
        public string tcgplayer_infinite_articles { get; set; }
        public string tcgplayer_infinite_decks { get; set; }
        public string edhrec { get; set; }
        public string mtgtop8 { get; set; }
    }

    public class RawMagicCard
    {
        public string @object { get; set; }
        public string id { get; set; }
        public string oracle_id { get; set; }
        public List<int> multiverse_ids { get; set; }
        public int mtgo_id { get; set; }
        public int mtgo_foil_id { get; set; }
        public int tcgplayer_id { get; set; }
        public int cardmarket_id { get; set; }
        public string name { get; set; }
        public string lang { get; set; }
        public string released_at { get; set; }
        public string uri { get; set; }
        public string scryfall_uri { get; set; }
        public string layout { get; set; }
        public bool highres_image { get; set; }
        public string image_status { get; set; }

        public RawImageUris image_uris { get; set; }

        public string mana_cost { get; set; }
        public double cmc { get; set; }
        public string type_line { get; set; }
        public string oracle_text { get; set; }
        public string power { get; set; }
        public string toughness { get; set; }

        public List<string> colors { get; set; }

        public List<string> color_identity { get; set; }

        public List<object> keywords { get; set; }

        public RawLegalities legalities { get; set; }

        public List<string> games { get; set; }

        public bool reserved { get; set; }
        public bool foil { get; set; }
        public bool nonfoil { get; set; }

        public List<string> finishes { get; set; }

        public bool oversized { get; set; }
        public bool promo { get; set; }
        public bool reprint { get; set; }
        public bool variation { get; set; }

        [JsonProperty("set_id")]
        public string CardSet_id { get; set; }
        [JsonProperty("set")]
        public string CardSet { get; set; }
        [JsonProperty("set_name")]
        public string CardSet_name { get; set; }
        [JsonProperty("set_type")]
        public string CardSet_type { get; set; }
        [JsonProperty("set_uri")]
        public string CardSet_uri { get; set; }
        [JsonProperty("set_search_uri")]
        public string CardSet_search_uri { get; set; }

        public string scryfall_set_uri { get; set; }
        public string rulings_uri { get; set; }
        public string prints_search_uri { get; set; }
        public string collector_number { get; set; }
        public bool digital { get; set; }
        public string rarity { get; set; }
        public string flavor_text { get; set; }
        public string card_back_id { get; set; }

        public string artist { get; set; }

        public List<string> artist_ids { get; set; }

        public string illustration_id { get; set; }
        public string border_color { get; set; }
        public string frame { get; set; }
        public bool full_art { get; set; }
        public bool textless { get; set; }
        public bool booster { get; set; }
        public bool story_spotlight { get; set; }
        public int edhrec_rank { get; set; }

        public RawPrices prices { get; set; }

        public RawRelatedUris related_uris { get; set; }
    }
}
