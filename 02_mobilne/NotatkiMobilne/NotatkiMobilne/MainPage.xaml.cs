using System.Collections.ObjectModel;

namespace NotatkiMobilne
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Notes { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Notes = new ObservableCollection<string>
            {
                "Kupić mleko i chleb",
                "Przygotować projekt z MAUI",
                "Wizyta u dentysty - godz. 16:00"
            };

            NotesListView.ItemsSource = Notes;
        }
        private void OnAddNoteClicked(object sender, EventArgs e)
        {
            string newNoteText = NoteEntry.Text;

            if (!string.IsNullOrWhiteSpace(newNoteText))
            {
                Notes.Add(newNoteText.Trim());
                NoteEntry.Text = string.Empty;
            }
        }
    }
}