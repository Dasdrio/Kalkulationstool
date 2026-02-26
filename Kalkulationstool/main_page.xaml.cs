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
    /// Interaktionslogik für main_page.xaml
    /// </summary>
    public partial class main_page : Page
    {
        MainWindow main_window;
        public main_page(MainWindow main_window)
        {
            InitializeComponent();
            this.main_window = main_window;
        }
        private void vorwaerts_Click(object sender, RoutedEventArgs e)
        {
            main_window.change_paige_to_vorwaerts();
        }

        private void rueckwaerts_Click(object sender, RoutedEventArgs e)
        {
            main_window.change_paige_to_rueckwaerts();
        }

        private void differenz_Click(object sender, RoutedEventArgs e)
        {
            main_window.change_paige_to_differenz();
        }
    }
}
