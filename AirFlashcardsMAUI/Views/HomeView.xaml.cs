namespace AirFlashcards
{
    public partial class MainPage : ContentPage
    {
        private readonly HomeViewModel _viewModel;
        public MainPage(HomeViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = _viewModel = viewModel;
        }
    }
}