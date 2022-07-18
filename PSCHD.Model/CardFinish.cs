using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{
    public partial class CardFinish
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual Finish Finish { get; set; }
        public virtual MagicCard MagicCard { get; set; }
    }
}