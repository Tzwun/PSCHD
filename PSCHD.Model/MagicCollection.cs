using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{
    public class MagicCollection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual ObservableCollection<UserMagicCard> UserMagicCards { get; set; }

        public virtual User User { get; set; }
    }
}