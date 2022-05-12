namespace ContactBook_PTDN_Project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseManager.InitializeDatabase();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindowForm());
        }
    }
}