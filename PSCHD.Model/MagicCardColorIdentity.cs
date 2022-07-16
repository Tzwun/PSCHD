using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{
    public class MagicCardColorIdentity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        public virtual MagicColorIdentity MagicColorIdentity { get; set; }

        public virtual MagicCard MagicCard { get; set; }
    }
}