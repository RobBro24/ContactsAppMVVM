using ContactsAppMVVM.Models.ViewModels;
using ContactsAppMVVM.Models;

namespace ContactsAppMVVM.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
    }

    private void Lv_ItemSelected(object sender, ItemTappedEventArgs e)
    {
        var contact = e.Item as Models.Contact;
        var contactViewModel = new ContatcsDetailsPageViewModel { Contact = contact };
        var contactDetail = new ContactsDetailsPage();
        contactDetail.BindingContext = contactViewModel;
        Navigation.PushAsync(contactDetail);

    }
}
