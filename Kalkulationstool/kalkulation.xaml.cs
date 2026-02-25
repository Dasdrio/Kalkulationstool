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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            main_window.change_paige_to_main_page();
        }
    }
}
