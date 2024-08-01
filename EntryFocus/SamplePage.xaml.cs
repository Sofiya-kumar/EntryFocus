namespace EntryFocus;

public partial class SamplePage : ContentPage
{
	public SamplePage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}