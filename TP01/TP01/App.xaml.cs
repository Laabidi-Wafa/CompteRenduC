using System;
using System.IO;
using System.Diagnostics;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TP01.Repositories;

namespace TP01
{
    public partial class App : Application

    {
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "database.db3");
        public static UserRepository UserRepository { get; private set; }
        public App()

        {
            InitializeComponent();
            UserRepository = new UserRepository(dbPath);
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
