using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmupark
{
    class Auto
    {
        private string szin, tipus;
        private double uzemAnyag, fogyaszt, km, megthetetoKm;
        public Auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.uzemAnyag = 0;
            this.km = 0;
            this.megthetetoKm = 0;
        }
        private void Megteheto()
        {
            megthetetoKm = (uzemAnyag / fogyaszt) * 100;
        }
        public void Tankol(double mennyit)
        {
            uzemAnyag += mennyit;
            Megteheto();
        }
        public void Megy(double km)
        {
            this.km += km;
            uzemAnyag -= (km * fogyaszt / 100);
            Megteheto();
        }
        public void Allapot()
        {
            Console.WriteLine($"Típus: {tipus} \nSzín: {szin} \nKilométeróra: {km} \nÜzemanyag: {uzemAnyag} l \nMegtehető km: {megthetetoKm}");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
        }

    }
}
