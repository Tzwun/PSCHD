using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSCHD.Model
{
    public partial class User
    {
        public User()
        {
            ObservableCollection<UserSetting> Settings = new ObservableCollection<UserSetting>();
            ObservableCollection<MagicCollection> Collections = new ObservableCollection<MagicCollection>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Password { get; set; }

        public virtual string Salt { get; set; }

        public virtual ObservableCollection<UserSetting> Settings { get; set; }

        public virtual ObservableCollection<MagicCollection> Collections { get; set; }
    }
}
