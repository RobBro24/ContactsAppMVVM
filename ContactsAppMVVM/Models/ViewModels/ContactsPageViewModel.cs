using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ContactsAppMVVM.Models.ViewModels
{
    partial class ContactsPageViewModel:ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Contact> contacts = [];

        [ObservableProperty]
        private Contact contact = new();

        [RelayCommand]
        private void AddContact() 
        {
            Contacts.Add(Contact);
            Contact = new();

        }
    }
}
