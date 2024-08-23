using FormRx.Button;

namespace PKHeXUtilLibDataManager.Main
{
    public partial class MainForm : Form, IMainForm
    {
        public IButton OpenNameParserDataEditButton { get; }

        public MainForm()
        {
            InitializeComponent();

            OpenNameParserDataEditButton = ButtonFactory.CreateButton(m_OpenNameParserDataEditButton);
        }
    }
}
