namespace CarReportSystem {
    internal static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Database.Initialize();
            Application.Run(new Form1());
        }
    }
}