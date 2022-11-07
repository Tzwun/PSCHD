using Microsoft.EntityFrameworkCore;
using PSCHD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace PSCHD.DB
{
    public class MagicCardRepository : IDisposable
    {
        PSCHD_Context context;
        private static object locker = new object();

        private int ThreadID;
        private Thread currentThread;
        private readonly int i;

        public List<string> getAllInsertedIDs()
        {
            return context.MagiCards.Select(f => f.string_id).ToList();
        }

        public bool IsCardAlreadyAvailable(string stringId)
        {
            return context.MagiCards.Any(e => e.string_id == stringId);
        }
        public MagicCardRepository(int i)
        {
            context = new PSCHD_Context();
            ThreadID = Thread.CurrentThread.ManagedThreadId;
            this.i = i;
        }

        public MagicCardRepository(int i, Thread currentThread) : this(i)
        {
            this.currentThread = currentThread;
        }

        public async Task<List<string>> GetAllLanguagesAsync()
        {
            return await context.MagiCards.Select(e => e.lang).Distinct().ToListAsync();
        }

        public bool SaveNewCard(MagicCard magicCard)
        {
            bool result = false;
            if (magicCard != null)
            {
                lock (locker)
                {
                    if (!IsCardAlreadyAvailable(magicCard.string_id))
                    {
                        context.MagiCards.Add(magicCard);
                        var temp = context.SaveChanges();
                        if (temp != 0)
                        {
                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        public void SaveNewCards(List<MagicCard> cards)
        {

            foreach (MagicCard item in cards)
            {
                if (item != null)
                {
                    context.MagiCards.Add(item);
                }
            }
            context.SaveChanges();
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

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }

        public void DisposeAndCreate()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
            context = new PSCHD_Context();
        }
    }
}
