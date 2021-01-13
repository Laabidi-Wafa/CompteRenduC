using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InscriptionPage : ContentPage
    {
        public InscriptionPage()
        {
            InitializeComponent();
        }

        private async void Inscription(object sender, EventArgs e)
        {
            statusMessage.Text = "";
            await App.UserRepository.AddNewUser(newUserEmail.Text, newUserPW.Text);
            statusMessage.Text = App.UserRepository.StatusMessage;


        }
    }
}