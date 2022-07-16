using PSCHD.Core;
using PSCHD.Core.Mvvm;
using PSCHD.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PSCHD.Design
{
    public class CardsOverviewDesign : ViewModelBase
    {
        public ObservableCollection<MagicCard> MagicCards
        {
            get { return LoadMagicCards(); }
        }

        public ObservableCollection<MagicCard> LoadMagicCards()
        {
            ObservableCollection<MagicCard> local = new ObservableCollection<MagicCard>();
            //local.Add(new MagicCard()
            //{
            //    multiverse_ids = new List<int>() { 1 },
            //    name = "Test Title",
            //    flavor_text = "Testflavor_text Lorem Ipsum and so fourth",
            //    lang = "en",
            //    image_uris = new ImageUris()
            //    {
            //        normal = "https://c1.scryfall.com/file/scryfall-cards/large/front/0/0/0000579f-7b35-4ed3-b44c-db2a538066fe.jpg?1562894979"
            //    }
            //});
            //local.Add(new MagicCard()
            //{
            //    multiverse_ids = new List<int>() { 2 },
            //    name = "Test Title",
            //    flavor_text = "Testflavor_text Lorem Ipsum and so fourth",
            //    lang = "es",
            //    image_uris = new ImageUris()
            //    {
            //        normal = "https://c1.scryfall.com/file/scryfall-cards/large/front/0/0/0000579f-7b35-4ed3-b44c-db2a538066fe.jpg?1562894979"
            //    }
            //});
            //local.Add(new MagicCard()
            //{
            //    multiverse_ids = new List<int>() { 3 },
            //    name = "Test Title",
            //    flavor_text = "Testflavor_text Lorem Ipsum and so fourth",
            //    lang = "fr",
            //    image_uris = new ImageUris()
            //    {
            //        normal = "https://c1.scryfall.com/file/scryfall-cards/large/front/0/0/0000579f-7b35-4ed3-b44c-db2a538066fe.jpg?1562894979"
            //    }
            //});
            //local.Add(new MagicCard()
            //{
            //    multiverse_ids = new List<int>() { 4 },
            //    name = "Test Title",
            //    flavor_text = "Testflavor_text Lorem Ipsum and so fourth",
            //    lang = "de",
            //    image_uris = new ImageUris()
            //    {
            //        normal = "https://c1.scryfall.com/file/scryfall-cards/large/front/0/0/0000579f-7b35-4ed3-b44c-db2a538066fe.jpg?1562894979"
            //    }
            //});
            //local.Add(new MagicCard()
            //{
            //    multiverse_ids = new List<int>() { 5 },
            //    name = "Test Title",
            //    flavor_text = "Testflavor_text Lorem Ipsum and so fourth",
            //    lang = "en",
            //    image_uris = new ImageUris()
            //    {
            //        normal = "https://c1.scryfall.com/file/scryfall-cards/large/front/0/0/0000579f-7b35-4ed3-b44c-db2a538066fe.jpg?1562894979"
            //    }
            //});
            //local.Add(new MagicCard()
            //{
            //    multiverse_ids = new List<int>() { 6 },
            //    name = "Test Title",
            //    flavor_text = "Testflavor_text Lorem Ipsum and so fourth",
            //    lang = "de",
            //    image_uris = new ObservableCollection<ImageUris>(new ImageUris
            //    {
            //         URI = "https://c1.scryfall.com/file/scryfall-cards/large/front/0/0/0000579f-7b35-4ed3-b44c-db2a538066fe.jpg?1562894979"
            //    }
            //}));
            return local;
        }
    }
}
