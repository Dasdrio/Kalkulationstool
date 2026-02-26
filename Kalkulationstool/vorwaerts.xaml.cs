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
            bool apply = true;
            TextBox[] textboxen = new TextBox[] {TB_listeneinkaufspreis, TB_lieferrabatt, TB_lieferskonto, TB_bezugskosten, TB_Handlungskosten, TB_gewinn, TB_Kundenskonto, TB_Provision, TB_Kundenrabatt, TB_steuer};
            List<decimal> values = new List<decimal>();
            foreach (TextBox textBox in textboxen)
            {
                if (textBox.Text.Length == 0)
                {
                    apply = false;
                    break;
                }
                else
                {
                    try
                    {
                        values.Add(decimal.Parse(textBox.Text));
                    }
                    catch (Exception ex)
                    {
                        apply = false;
                        break;
                    }
                }
            }
            if (apply)
            {
                Rechnen rechnung = new Rechnen(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], 0);
                rechnung.vorwaertskalkulation(false);
                main_window.change_paige_to_kalkulation(rechnung);
            }
            else MainWindow.show_error_message();
        }

    }
}
