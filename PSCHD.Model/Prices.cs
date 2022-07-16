using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{
    public partial class Prices
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public decimal Price { get; set; }
        public virtual string currency { get; set; }
        public virtual Finish Finish { get; set; }
        public virtual DateTime datetime { get; set; }
        public virtual MagicCard Parent { get; set; }
    }
}