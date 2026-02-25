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
    /// Interaktionslogik für vorwaerts.xaml
    /// </summary>
    public partial class vorwaerts : Page
    {
        MainWindow main_window;
        public vorwaerts(MainWindow main_window)
        {
            this.main_window = main_window;
            InitializeComponent();
        }

        private void Rechnung_Click(object sender, RoutedEventArgs e)
        {
            main_window.change_paige_to_kalkulation();
        }

    }
}
