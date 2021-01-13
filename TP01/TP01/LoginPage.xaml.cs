using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            List<User> users = await App.UserRepository.GetUserAsync();
            foreach(var user in users)
            {
                Console.WriteLine($"{user.ID} - {user.Email} - {user.Password}");
                if (user.Email.ToString() == UserEmail.Text)
                {
                    if (user.Password.ToString() == UserPW.Text)
                    {
                        await Navigation.PushAsync(new NavPage());
                    }
                    else statusMsg.Text = "Password Incorrect";
                }

                else statusMsg.Text = "Utilisateur non trouvé";
            }
            
        }
    }
}