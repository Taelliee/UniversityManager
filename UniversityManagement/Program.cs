using UniversityManagement.models;

namespace UniversityManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            UniversityFile.LoadUniPeopleFromFile();
            UniversityFile.LoadUniversitySubjectsFromFile();
            UniversityFile.LoadGradesFromFile();

            Application.Run(new MainForm());
        }
    }
}