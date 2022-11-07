using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{
    public class MagicCardSet
    {
        public MagicCardSet()
        {
            MagicCards = new ObservableCollection<MagicCard>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual string SetID { get; set; }
        public virtual string SetName { get; set; }
        public virtual string SetType { get; set; }
        public virtual string SetURI { get; set; }
        public virtual string SetSearchURI { get; set; }
        public virtual ObservableCollection<MagicCard> MagicCards { get; set; }
    }
}