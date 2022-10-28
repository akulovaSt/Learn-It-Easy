using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using LearnItEasy.Models;

namespace LearnItEasy.ViewModels
{
    internal class ScheduleViewModel : BaseViewModel
    {
        public ScheduleViewModel()
        {
            Title = "Расписание";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
