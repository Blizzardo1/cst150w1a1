using System.Reflection;
using System.Windows.Forms;

namespace CST_150_Milestone
{
    internal static class Program
    {

        internal static readonly string StartupPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        internal static readonly string DbPath = Path.Combine(StartupPath, "Students.db");

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
