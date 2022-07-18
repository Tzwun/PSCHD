using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{
    public partial class CardArtistsId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public ArtistId ArtistId { get; set; }
        public MagicCard MagicCard { get; set; }
    }
}