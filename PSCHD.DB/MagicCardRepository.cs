using Microsoft.EntityFrameworkCore;
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

        public bool IsCardAlreadyAvailable(string stringId)
        {
            return context.MagiCards.Any(e => e.string_id == stringId);
        }
        public MagicCardRepository()
        {
            context = new PSCHD_Context();
        }

        public void SaveNewCard(MagicCard magicCard)
        {
            if (magicCard != null)
            {
                context.MagiCards.Add(magicCard);
                context.SaveChanges();
            }
        }

        public List<MagicCard> GetAllCards()
        {
            return context.MagiCards.Include(e => e.image_uris).ToList();
        }

        public Task<List<MagicCard>> GetAllCardsAsync()
        {
            return context.MagiCards.Include(e => e.image_uris).ToListAsync();
        }

        public List<Finish> GetAvailableFinishes()
        {
            return context.Finishes.ToList();
        }

        public ArtistId RetrieveArtistId(string artistId)
        {
            return context.ArtistIDs.SingleOrDefault(e => e.artistId == artistId);
        }

        public MagicKeyword RetrieveKeyword(string keyword)
        {
            return context.Keywords.SingleOrDefault(e => e.Keyword == keyword);
        }

        public MagicColorIdentity RetrieveColorIdentity(char colorIdentity)
        {
            return context.Colors_Identity.SingleOrDefault(e => e.magicColorIdentity == colorIdentity);
        }

        public MagicColor RetrieveColor(char magicColor)
        {
            return context.Colors.SingleOrDefault(e => e.magicColor == magicColor);
        }

        public Finish RetrieveFinish(string finish)
        {
            return context.Finishes.SingleOrDefault(e => e.finish == finish);
        }

        public MagicGame RetrieveGame(string game)
        {
            return context.MagicGames.SingleOrDefault(e => e.magicGame == game);
        }
    }
}
