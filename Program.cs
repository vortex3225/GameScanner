namespace GameScanner
{
    internal static class Program
    {
        public static string APP_VERSION = "0.0.1";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(main_form);
        }
        public static Form main_form = new MainForm();
    }
}