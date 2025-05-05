namespace GameLauncher
{
    internal static class Program
    {
        /// <summary>
        ///  A game launcher created with the intention of mimicking an emulator for a console that does not exist.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FantaSYS());
        }
    }
}