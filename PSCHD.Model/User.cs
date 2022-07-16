using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{
    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Password { get; set; } // Verschlüsselt auf Datenbank etc.

        public virtual string Salt { get; set; }

        public virtual ObservableCollection<UserSetting> Settings { get; set; }

        public virtual ObservableCollection<MagicCollection> Collections { get; set; }
    }
}
