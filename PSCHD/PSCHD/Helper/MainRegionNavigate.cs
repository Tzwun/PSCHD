namespace PSCHD.Helper
{
    public static class MainRegionNavigate
    {
        public static string To(string URI)
        {
            switch (URI)
            {
                case "Background":
                    return typeof(Views.BackGroundView).FullName;
                case "Benutzer":
                    return typeof(Views.UserView).FullName;
                case "AlleKarten":
                    return typeof(Views.CardsOverview).FullName;
                case "MeineKarten":
                    return typeof(Views.UserCollectionsView).FullName;
                case "Stonks":
                    return typeof(Views.StonksView).FullName;
                default:
                    return typeof(Views.BackGroundView).FullName;
            }
        }
    }
}