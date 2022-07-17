using PSCHD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSCHD.DB
{
    public class MagicCardRepository
    {
        PSCHD_Context context;

        public MagicCardRepository()
        {
            context = new PSCHD_Context();
        }

        public void SaveNewCard(MagicCard magicCard)
        {
            context.MagiCards.Add(magicCard);
            context.SaveChanges();
        }
    }
}
