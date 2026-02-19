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

        public void change_paige_to_kalkulation()
        {
            kalkulation page = new kalkulation(this);
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
    }
}