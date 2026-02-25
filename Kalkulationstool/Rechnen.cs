using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulationstool
{
    public class Rechnen
    {
        private double listeneinkaufspreis;
        private double lieferrabatt;
        private double zieleinkaufspreis;
        private double lieferskonto;
        private double bareinkaufspreis;
        private double bezugskosten;
        private double bezugspreis;
        private double handlungskostenzuschlag;
        private double selbskosten;
        private double gewinnzuschlag;
        private double barverkaufspreis;
        private double kundenskonto_und_vertreterprovision;
        private double zielverkaufspreis;
        private double kundenrabatt;
        private double nettoverkaufspreis;
        private double umsatzsteuer;
        private double bruttoverkaufspreis;

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
        public Rechnen(double listeneinkaufspreis, double lieferrabatt, double lieferskonto, double bezugskosten, double handlungskostenzuschlag, double gewinnzuschlag, double kundenskonto, double vertreterprovision, double kundenrabatt, double umsatzsteuer, double bruttoverkaufspreis)
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
            
            lieferrabatt = Math.Round(dezimal_basis_100(lieferrabatt) * listeneinkaufspreis, 2);
            zieleinkaufspreis = listeneinkaufspreis - lieferrabatt;
            lieferskonto = Math.Round(dezimal_basis_100(lieferskonto) * zieleinkaufspreis, 2);
            bareinkaufspreis = zieleinkaufspreis - lieferskonto;
            bezugspreis = bareinkaufspreis + bezugskosten;
            handlungskostenzuschlag = Math.Round(dezimal_basis_100(handlungskostenzuschlag) * bezugspreis, 2);
            selbskosten = handlungskostenzuschlag + bezugspreis;
            if (dif) return;
            gewinnzuschlag = Math.Round(dezimal_basis_100(gewinnzuschlag) * selbskosten, 2);
            barverkaufspreis = selbskosten + gewinnzuschlag;
            zieleinkaufspreis = Math.Round(barverkaufspreis / dezimal(kundenskonto_und_vertreterprovision), 2);
            kundenskonto_und_vertreterprovision = zieleinkaufspreis - barverkaufspreis;
            nettoverkaufspreis = Math.Round(zielverkaufspreis / dezimal(kundenrabatt), 2);
            kundenrabatt = nettoverkaufspreis - zielverkaufspreis;
            bruttoverkaufspreis = Math.Round(nettoverkaufspreis / dezimal(umsatzsteuer), 2);
            umsatzsteuer = bruttoverkaufspreis - nettoverkaufspreis;
        }
        public void rueckwaertzkalkulation(Boolean dif)
        {
            umsatzsteuer = Math.Round(dezimal_basis_100(umsatzsteuer) * bruttoverkaufspreis, 2);
            nettoverkaufspreis = bruttoverkaufspreis - umsatzsteuer;
            kundenrabatt = Math.Round(dezimal_basis_100(kundenrabatt) * nettoverkaufspreis, 2);
            zielverkaufspreis = nettoverkaufspreis - kundenrabatt;
            kundenskonto_und_vertreterprovision = Math.Round(dezimal_basis_100(kundenskonto_und_vertreterprovision) * zielverkaufspreis, 2);
            barverkaufspreis = zielverkaufspreis - kundenskonto_und_vertreterprovision;
            if (dif) return;
            selbskosten = Math.Round(barverkaufspreis / dezimal(gewinnzuschlag), 2);
            gewinnzuschlag = barverkaufspreis - selbskosten;
            bezugspreis = Math.Round(selbskosten / dezimal(gewinnzuschlag), 2);
            handlungskostenzuschlag = selbskosten - bezugspreis;
            bareinkaufspreis = bezugspreis - bezugskosten;
            zieleinkaufspreis = Math.Round(bareinkaufspreis / dezimal(lieferskonto), 2);
            lieferskonto = zieleinkaufspreis - bareinkaufspreis;
            listeneinkaufspreis = Math.Round(zieleinkaufspreis / dezimal(lieferrabatt), 2);
            lieferrabatt = listeneinkaufspreis - zieleinkaufspreis;
        }
        public void differenzkalkulation()
        {
            vorwaertskalkulation(true);
            rueckwaertzkalkulation(true);
            gewinnzuschlag = barverkaufspreis - selbskosten;
        }

        private double dezimal_basis_100(double prozent)
        {
            return prozent / 100;
        }
        private double dezimal(double prozent)
        {
            return (100 - prozent) / 100;
        }
    }
}
