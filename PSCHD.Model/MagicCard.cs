using PSCHD.Core.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{

    public class MagicCards : List<MagicCard>
    { }

    public partial class MagicCard
    {

        public MagicCard()
        {
            ObservableCollection<ArtistId> artist_ids = new ObservableCollection<ArtistId>();
            ObservableCollection<Finish> finishes = new ObservableCollection<Finish>();
            ObservableCollection<MagicCardColor> colors = new ObservableCollection<MagicCardColor>();
            ObservableCollection<MagicCardColorIdentity> color_identity = new ObservableCollection<MagicCardColorIdentity>();
            ObservableCollection<MagicCardKeyword> keywords = new ObservableCollection<MagicCardKeyword>();
            ObservableCollection<MultiverseId> multiverse_ids = new ObservableCollection<MultiverseId>();
            ObservableCollection<ImageUris> image_uris = new ObservableCollection<ImageUris>();
            ObservableCollection<Prices> prices = new ObservableCollection<Prices>();
            ObservableCollection<RelatedUris> related_uris = new ObservableCollection<RelatedUris>();
            ObservableCollection<MagicCardGame> games = new ObservableCollection<MagicCardGame>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual string _object { get; set; }
        public virtual string string_id { get; set; }
        public virtual string oracle_id { get; set; }
        public virtual int? mtgo_id { get; set; }
        public virtual int? mtgo_foil_id { get; set; }
        public virtual int? tcgplayer_id { get; set; }
        public virtual int? cardmarket_id { get; set; }
        public virtual string name { get; set; }
        public virtual string lang { get; set; }
        public virtual string released_at { get; set; }
        public virtual string uri { get; set; }
        public virtual string scryfall_uri { get; set; }
        public virtual string layout { get; set; }
        public virtual bool highres_image { get; set; }
        public virtual string image_status { get; set; }
        public virtual string mana_cost { get; set; }
        public virtual double? cmc { get; set; }
        public virtual string type_line { get; set; }
        public virtual string oracle_text { get; set; }
        public virtual string power { get; set; }
        public virtual string toughness { get; set; }
        public virtual bool reserved { get; set; }
        public virtual bool foil { get; set; }
        public virtual bool nonfoil { get; set; }
        public virtual bool oversized { get; set; }
        public virtual bool promo { get; set; }
        public virtual bool reprint { get; set; }
        public virtual bool variation { get; set; }
        public virtual string Cardset_id { get; set; }
        public virtual string Cardset { get; set; }
        public virtual string Cardset_name { get; set; }
        public virtual string Cardset_type { get; set; }
        public virtual string Cardset_uri { get; set; }
        public virtual string Cardset_search_uri { get; set; }
        public virtual string scryfall_set_uri { get; set; }
        public virtual string rulings_uri { get; set; }
        public virtual string prints_search_uri { get; set; }
        public virtual string collector_number { get; set; }
        public virtual bool digital { get; set; }
        public virtual string rarity { get; set; }
        public virtual string flavor_text { get; set; }
        public virtual string card_back_id { get; set; }
        public virtual string artist { get; set; }
        public virtual string illustration_id { get; set; }
        public virtual string border_color { get; set; }
        public virtual string frame { get; set; }
        public virtual bool full_art { get; set; }
        public virtual bool textless { get; set; }
        public virtual bool booster { get; set; }
        public virtual bool story_spotlight { get; set; }
        public virtual int edhrec_rank { get; set; }

        public virtual ObservableCollection<CardArtistsId> CardArtistsIds { get; set; }
        public virtual ObservableCollection<CardFinish> finishes { get; set; }
        public virtual ObservableCollection<MagicCardColor> colors { get; set; }
        public virtual ObservableCollection<MagicCardColorIdentity> color_identity { get; set; }
        public virtual ObservableCollection<MagicCardKeyword> keywords { get; set; }
        public virtual ObservableCollection<MultiverseId> multiverse_ids { get; set; }
        public virtual Legalities legalities { get; set; }
        public virtual ObservableCollection<ImageUris> image_uris { get; set; }
        public virtual ObservableCollection<Prices> prices { get; set; }
        public virtual ObservableCollection<RelatedUris> related_uris { get; set; }
        public virtual ObservableCollection<MagicCardGame> games { get; set; }
        public virtual ObservableCollection<RelatedMagicCard> relatedCards { get; set; }

    }
}