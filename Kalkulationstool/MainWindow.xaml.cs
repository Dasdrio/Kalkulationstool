using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kalkulationstool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            change_paige_to_main_page();
        }

        public void change_paige_to_kalkulation(Rechnen rechnung)
        {
            kalkulation page = new kalkulation(this, rechnung);
            this.Content = page;
        }
        public void change_paige_to_main_page()
        {
            main_page page = new main_page(this);
            this.Content = page;
        }
        public void change_paige_to_vorwaerts()
        {
            vorwaerts page = new vorwaerts(this);
            this.Content = page;
        }

        public void change_paige_to_rueckwaerts()
        {
            rueckwaerts page = new rueckwaerts(this);
            this.Content = page;
        }

        public void change_paige_to_differenz()
        {
            differenz page = new differenz(this);
            this.Content = page;
        }

        public static void show_error_message()
        {
            String message_box_text = "Es wurde in eine oder mehreren Eingabefeldern kein gültiger Wert gefunden!\nnur Zahlenwerte sind erlaubt 0 eintragen für nicht vorhandene Werte";
            String caption = "Eingabe Fehler";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxImage icon = MessageBoxImage.Error;
            MessageBoxResult result;

            result = MessageBox.Show(message_box_text, caption, button, icon, MessageBoxResult.Yes);
        }
    }
}