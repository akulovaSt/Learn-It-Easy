using LearnItEasy.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LearnItEasy.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}