using System.Windows;

namespace FormularzXaml
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImie.Text) ||
                string.IsNullOrWhiteSpace(txtNazwisko.Text) ||
                string.IsNullOrWhiteSpace(txtWiek.Text) ||
                (rbKobieta.IsChecked != true && rbMezczyzna.IsChecked != true) ||
                dpDataUrodzenia.SelectedDate == null ||
                string.IsNullOrWhiteSpace(txtInformacje.Text))
            {
                lblKomunikat.Content = "Uzupełnij wszystkie pola formularza.";
                return;
            }

            lblKomunikat.Content = "Wszystkie pola zostały poprawnie uzupełnione.";
        }
    }
}