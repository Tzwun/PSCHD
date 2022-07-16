using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{
    public partial class ImageUris
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual string URI { get; set; }
        public virtual ImageSize ImageSize { get; set; }
        public virtual MagicCard Parent { get; set; }
    }
}