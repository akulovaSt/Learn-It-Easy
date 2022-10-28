using LearnItEasy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnItEasy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        //LoginViewModel _viewModel;
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        //protected override void OnAppearing()
        //{
        //base.OnAppearing();
        //_viewModel.OnAppearing();
        //}

        Button toAboutPageBtn = new Button
        {
            Text = "Log In",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };       

        private async void ToAboutPage(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new AboutPage());

        }
    }
}