namespace ApocalypticFarmer
{
#if WINDOWS
    internal static class Program
    {
        #region Publics
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main(string[] args)
        {
            using(Game1 game = new Game1())
            {
                game.Run();
            }
        }
        #endregion
    }
#endif
}