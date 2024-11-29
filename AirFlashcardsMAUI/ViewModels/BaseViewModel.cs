using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AirFlashcards
{
    /// <summary>
    /// Bazowy ViewModel z implementacją powiadamiania o zmianach.
    /// </summary>
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool isBusy;

        [ObservableProperty]
        private string? title;

        /// <summary>
        /// Ustawia wartość tytułu i zmienia status aplikacji na zajęty.
        /// </summary>
        /// <param name="message">Nowa wartość tytułu.</param>
        [RelayCommand]
        public void SetBusyWithMessage(string message)
        {
            IsBusy = true;
            Title = message;
        }

        /// <summary>
        /// Metoda do resetowania statusu zajętości.
        /// </summary>
        [RelayCommand]
        public void ResetBusy()
        {
            IsBusy = false;
            Title = "Gotowy";
        }
    }
}
