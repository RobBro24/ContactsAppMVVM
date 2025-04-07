using ContactsAppMVVM.Models.ViewModels;
using ContactsAppMVVM.Views;
namespace ContactsAppMVVM
{
    public partial class MainPage : ContentPage
    {
        private ContactsPageViewModel contactsPageViewModel;

        public MainPage()
        {
            InitializeComponent();
            contactsPageViewModel = new ContactsPageViewModel();
            BindingContext = contactsPageViewModel;
        }

        private void ViewClicked(object sender, EventArgs e)
        {
            var contactList = new ContactsPage();
            contactList.BindingContext = contactsPageViewModel;
            Navigation.PushAsync(contactList);
        }
    }

}
