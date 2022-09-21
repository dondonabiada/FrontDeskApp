namespace FrontDeskApp.WinApp
{
    internal static class Program
    {
        static Form1 MainForm { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MainForm = new Form1();
            Application.Run(MainForm);
        }
    }
}