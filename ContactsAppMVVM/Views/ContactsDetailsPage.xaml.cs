namespace ContactsAppMVVM.Views;

public partial class ContactsDetailsPage : ContentPage
{
	public ContactsDetailsPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Handle the button click event here
        // For example, you can navigate back to the previous page
        Navigation.PopAsync();

    }
}