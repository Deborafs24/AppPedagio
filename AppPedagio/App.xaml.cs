using AppPedagio.Helpers;

namespace AppPedagio
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData
                        ), "banco_sqlite_compras.db3"
                    );

                    _db = new SQLiteDatabaseHelper(path);
                } // Fecha if verificando de _db é null

                return _db;
            } // Fecha método get
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
