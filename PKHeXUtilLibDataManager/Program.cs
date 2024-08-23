using PKHeXUtilLibDataManager.Main;

namespace PKHeXUtilLibDataManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            using (var presenter = new MainFormPresenter())
            {
                presenter.Run();
            }
        }
    }
}