using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AirFlashcards
{
    /// <summary>
    /// Bazowy ViewModel z implementacją powiadamiania o zmianach.
    /// </summary>
    public partial class HomeViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string? _name = string.Empty;

        /// <summary>
        /// Ustawia wartość tytułu i zmienia status aplikacji na zajęty.
        /// </summary>
        /// <param name="message">Nowa wartość tytułu.</param>
        [RelayCommand]
        public void SetName(string? name)
        {
            _name = name;
        }
    }
}
