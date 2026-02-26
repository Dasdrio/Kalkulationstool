using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaktionslogik für kalkulation.xaml
    /// </summary>
    public partial class kalkulation : Page
    {
        MainWindow main_window;
        Rechnen rechnung;
        public kalkulation(MainWindow main_window, Rechnen rechnung)
        {
            this.rechnung = rechnung;
            this.main_window = main_window;
            InitializeComponent();
            show_results();
            write_to_database();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            main_window.change_paige_to_main_page();
        }
        private void show_results()
        {
            this.Listeneinkaufspreis.Text = Math.Round(rechnung.get_listeneinkaufspreis(), 2).ToString();
            this.Lieferrabatt.Text = Math.Round(rechnung.get_lieferrabatt(), 2).ToString();
            this.Zieleinkaufspreis.Text = Math.Round(rechnung.get_zieleinkaufspreis(), 2).ToString();
            this.Lieferskonto.Text = Math.Round(rechnung.get_lieferskonto(), 2).ToString();
            this.Bareinkauspreis.Text = Math.Round(rechnung.get_bareinkaufspreis(), 2).ToString();
            this.Bezugskosten.Text = Math.Round(rechnung.get_bezugskosten(), 2).ToString();
            this.Bezugspreis.Text = Math.Round(rechnung.get_bezugspreis(), 2).ToString();
            this.Handlungskostenzuschlag.Text = Math.Round(rechnung.get_handlungskostenzuschlag(), 2).ToString();
            this.Selbstkosten.Text = Math.Round(rechnung.get_selbskosten(), 2).ToString();
            this.Gewinnzuschlag.Text = Math.Round(rechnung.get_gewinnzuschlag(), 2).ToString();
            this.Barverkaufspreis.Text = Math.Round(rechnung.get_barverkaufspreis(), 2).ToString();
            this.skonto_und_provision.Text = Math.Round(rechnung.get_kundenskonto_und_vertreterprovision(), 2).ToString();
            this.Zielverkaufspreis.Text = Math.Round(rechnung.get_zielverkaufspreis(), 2).ToString();
            this.Kundenrabatt.Text = Math.Round(rechnung.get_kundenrabatt(), 2).ToString();
            this.Nettoverkaufspreis.Text = Math.Round(rechnung.get_nettoverkaufspreis(), 2).ToString();
            this.Umsatzsteuer.Text = Math.Round(rechnung.get_umsatzsteuer(), 2).ToString();
            this.Bruttoverkaufspreis.Text = Math.Round(rechnung.get_bruttoverkaufspreis(), 2).ToString();
        }
        private void write_to_database()
        {

        }
    }
}
