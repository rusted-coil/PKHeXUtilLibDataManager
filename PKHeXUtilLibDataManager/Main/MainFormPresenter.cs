namespace PKHeXUtilLibDataManager.Main
{
    internal class MainFormPresenter : IDisposable
    {
        readonly MainForm m_MainForm;

        public MainFormPresenter()
        {
            m_MainForm = new MainForm();
        }

        public void Run()
        {
            Application.Run(m_MainForm);
        }

        public void Dispose() 
        {            
        }
    }
}
