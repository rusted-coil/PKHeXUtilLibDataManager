using FormRx.Extensions;
using PKHeXUtilForms.Pokemon.NameParser;
using System.Reactive.Disposables;

namespace PKHeXUtilLibDataManager.Main
{
    internal class MainFormPresenter : IDisposable
    {
        readonly CompositeDisposable m_Disposables = new CompositeDisposable();
        readonly MainForm m_MainForm;

        public MainFormPresenter()
        {
            m_MainForm = new MainForm();
            m_MainForm.OpenNameParserDataEditButton.Clicked.Subscribe(_ => OpenNameParserDataEditor()).AddTo(m_Disposables);
        }

        public void Run()
        {
            Application.Run(m_MainForm);
        }

        public void Dispose() 
        {            
            m_Disposables.Dispose();
        }

        void OpenNameParserDataEditor()
        {
            NameParserFormService.OpenNameParserDataEditor();
        }
    }
}
