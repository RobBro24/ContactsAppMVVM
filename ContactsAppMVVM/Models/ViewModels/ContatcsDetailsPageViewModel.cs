using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ContactsAppMVVM.Models.ViewModels
{
    partial class ContatcsDetailsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Contact? contact;

        [RelayCommand]
        private void BackToAdd()
        {
            if (App.Current.MainPage is NavigationPage navigationPage)
            {
                // Assuming you want to navigate to a new page, you need to pass a Page object to PushAsync
                navigationPage.Navigation.PushAsync(new MainPage());
            }
        }
    }
}
