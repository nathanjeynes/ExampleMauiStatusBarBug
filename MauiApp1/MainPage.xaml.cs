namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
#if IOS || ANDROID

            //try
            //{
            //    CommunityToolkit.Maui.Core.Platform.StatusBar.SetColor(Color.FromArgb("#282828"));
            //}
            //catch (Exception)
            //{


            //}


#endif
        }
    }
}
