using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{
    public partial class MagicCardGame
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual MagicGame MagicGame { get; set; }
        public virtual MagicCard MagicCard { get; set; }
    }
}