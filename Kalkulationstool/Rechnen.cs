using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulationstool
{
    public class Rechnen
    {
        private decimal listeneinkaufspreis;
        private decimal lieferrabatt;
        private decimal zieleinkaufspreis;
        private decimal lieferskonto;
        private decimal bareinkaufspreis;
        private decimal bezugskosten;
        private decimal bezugspreis;
        private decimal handlungskostenzuschlag;
        private decimal selbskosten;
        private decimal gewinnzuschlag;
        private decimal barverkaufspreis;
        private decimal kundenskonto_und_vertreterprovision;
        private decimal zielverkaufspreis;
        private decimal kundenrabatt;
        private decimal nettoverkaufspreis;
        private decimal umsatzsteuer;
        private decimal bruttoverkaufspreis;

        /// <summary>
        /// Creates the object with every of its attributes. Set an attribute to 0 for no value
        /// </summary>
        /// <param name="listeneinkaufspreis"></param>
        /// <param name="lieferrabatt"></param>
        /// <param name="lieferskonto"></param>
        /// <param name="bezugskosten"></param>
        /// <param name="handlungskostenzuschlag"></param>
        /// <param name="gewinnzuschlag"></param>
        /// <param name="kundenskonto"></param>
        /// <param name="vertreterprovision"></param>
        /// <param name="kundenrabatt"></param>
        /// <param name="umsatzsteuer"></param>
        /// <param name="bruttoverkaufspreis"></param>
        public Rechnen(decimal listeneinkaufspreis, decimal lieferrabatt, decimal lieferskonto, decimal bezugskosten, decimal handlungskostenzuschlag, decimal gewinnzuschlag, decimal kundenskonto, decimal vertreterprovision, decimal kundenrabatt, decimal umsatzsteuer, decimal bruttoverkaufspreis)
        {
            this.listeneinkaufspreis = listeneinkaufspreis;
            this.lieferrabatt = lieferrabatt;
            this.zieleinkaufspreis = 0;
            this.lieferskonto = lieferskonto;
            this.bareinkaufspreis = 0;
            this.bezugskosten = bezugskosten;
            this.bezugspreis = 0;
            this.handlungskostenzuschlag = handlungskostenzuschlag;
            this.selbskosten = 0;
            this.gewinnzuschlag = gewinnzuschlag;
            this.barverkaufspreis = 0;
            this.kundenskonto_und_vertreterprovision = kundenskonto + vertreterprovision;
            this.zielverkaufspreis = 0;
            this.kundenrabatt = kundenrabatt;
            this.nettoverkaufspreis = 0;
            this.umsatzsteuer = umsatzsteuer;
            this.bruttoverkaufspreis = bruttoverkaufspreis;
        }
        
        public void vorwaertskalkulation(Boolean dif)
        {
            
            lieferrabatt = dezimal_basis_100(lieferrabatt) * listeneinkaufspreis;
            zieleinkaufspreis = listeneinkaufspreis - lieferrabatt;
            lieferskonto =dezimal_basis_100(lieferskonto) * zieleinkaufspreis;
            bareinkaufspreis = zieleinkaufspreis - lieferskonto;
            bezugspreis = bareinkaufspreis + bezugskosten;
            handlungskostenzuschlag = dezimal_basis_100(handlungskostenzuschlag) * bezugspreis;
            selbskosten = handlungskostenzuschlag + bezugspreis;
            if (dif) return;
            gewinnzuschlag = dezimal_basis_100(gewinnzuschlag) * selbskosten;
            barverkaufspreis = selbskosten + gewinnzuschlag;
            zielverkaufspreis = barverkaufspreis / dezimal(kundenskonto_und_vertreterprovision);
            kundenskonto_und_vertreterprovision = zielverkaufspreis - barverkaufspreis;
            nettoverkaufspreis = zielverkaufspreis / dezimal(kundenrabatt);
            kundenrabatt = nettoverkaufspreis - zielverkaufspreis;
            umsatzsteuer = dezimal_basis_100(umsatzsteuer) * nettoverkaufspreis;
            bruttoverkaufspreis = nettoverkaufspreis + umsatzsteuer;
        }
        public void rueckwaertzkalkulation(Boolean dif)
        {
            nettoverkaufspreis = bruttoverkaufspreis / dezimal_basis_groesser_100(umsatzsteuer);
            umsatzsteuer = bruttoverkaufspreis - nettoverkaufspreis;
            kundenrabatt = dezimal_basis_100(kundenrabatt) * nettoverkaufspreis;
            zielverkaufspreis = nettoverkaufspreis - kundenrabatt;
            kundenskonto_und_vertreterprovision = dezimal_basis_100(kundenskonto_und_vertreterprovision) * zielverkaufspreis;
            barverkaufspreis = zielverkaufspreis - kundenskonto_und_vertreterprovision;
            if (dif) return;
            selbskosten = barverkaufspreis / dezimal_basis_groesser_100(gewinnzuschlag);
            gewinnzuschlag = barverkaufspreis - selbskosten;
            bezugspreis = selbskosten / dezimal_basis_groesser_100(handlungskostenzuschlag);
            handlungskostenzuschlag = selbskosten - bezugspreis;
            bareinkaufspreis = bezugspreis - bezugskosten;
            zieleinkaufspreis = bareinkaufspreis / dezimal(lieferskonto);
            lieferskonto = zieleinkaufspreis - bareinkaufspreis;
            listeneinkaufspreis = zieleinkaufspreis / dezimal(lieferrabatt);
            lieferrabatt = listeneinkaufspreis - zieleinkaufspreis;
        }
        public void differenzkalkulation()
        {
            vorwaertskalkulation(true);
            rueckwaertzkalkulation(true);
            gewinnzuschlag = barverkaufspreis - selbskosten;
        }

        private decimal dezimal_basis_100(decimal prozent)
        {
            return prozent / 100;
        }
        private decimal dezimal(decimal prozent)
        {
            return (100 - prozent) / 100;
        }
        private decimal dezimal_basis_groesser_100(decimal prozent)
        {
            return 1 + prozent / 100;
        }
        public decimal get_listeneinkaufspreis()
        {
            return listeneinkaufspreis;
        }
        public decimal get_lieferrabatt()
        {
            return lieferrabatt;
        }
        public decimal get_zieleinkaufspreis()
        {
            return zieleinkaufspreis;
        }
        public decimal get_lieferskonto()
        {
            return lieferskonto;
        }
        public decimal get_bareinkaufspreis()
        {
            return bareinkaufspreis;
        }
        public decimal get_bezugskosten()
        {
            return bezugskosten;
        }
        public decimal get_bezugspreis()
        {
            return bezugspreis;
        }
        public decimal get_handlungskostenzuschlag()
        {
            return handlungskostenzuschlag;
        }
        public decimal get_selbskosten()
        {
            return selbskosten;
        }
        public decimal get_gewinnzuschlag()
        {
            return gewinnzuschlag;
        }
        public decimal get_barverkaufspreis()
        {
            return barverkaufspreis;
        }
        public decimal get_kundenskonto_und_vertreterprovision()
        {
            return kundenskonto_und_vertreterprovision;
        }
        public decimal get_zielverkaufspreis()
        {
            return zielverkaufspreis;
        }
        public decimal get_kundenrabatt()
        {
            return kundenrabatt;
        }
        public decimal get_nettoverkaufspreis()
        {
            return nettoverkaufspreis;
        }
        public decimal get_umsatzsteuer()
        {
            return umsatzsteuer;
        }
        public decimal get_bruttoverkaufspreis()
        {
            return bruttoverkaufspreis;
        }
    }
}
