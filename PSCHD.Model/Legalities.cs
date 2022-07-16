using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{
    public partial class Legalities
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual Legality standard { get; set; }
        public virtual Legality future { get; set; }
        public virtual Legality historic { get; set; }
        public virtual Legality gladiator { get; set; }
        public virtual Legality pioneer { get; set; }
        public virtual Legality modern { get; set; }
        public virtual Legality legacy { get; set; }
        public virtual Legality pauper { get; set; }
        public virtual Legality vintage { get; set; }
        public virtual Legality penny { get; set; }
        public virtual Legality commander { get; set; }
        public virtual Legality brawl { get; set; }
        public virtual Legality historicbrawl { get; set; }
        public virtual Legality alchemy { get; set; }
        public virtual Legality paupercommander { get; set; }
        public virtual Legality duel { get; set; }
        public virtual Legality oldschool { get; set; }
        public virtual Legality premodern { get; set; }
    }
}