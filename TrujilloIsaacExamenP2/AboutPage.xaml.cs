namespace TrujilloIsaacExamenP2;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
    private async void InfoButton_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Informaci�n de m�", "Mi nombre es [Isaac Trujillo]", "Cerrar");
    }

    private void GitHubButton_Clicked(object sender, EventArgs e)
    {
        var githubUrl = "https://github.com/Altermanns/TrujilloIsaacExamenP2.git";
        Launcher.Default.OpenAsync(githubUrl);
    }

    private void FavoriteSongButton_Clicked(object sender, EventArgs e)
    {
        var songUrl = "https://www.youtube.com/watch?v=Jy1D6caG8nU";
        Launcher.Default.OpenAsync(songUrl);
    }
}