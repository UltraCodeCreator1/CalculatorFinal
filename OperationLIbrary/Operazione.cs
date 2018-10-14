using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLIbrary
{
    public class Operazione : IOperazione
    {
        double Risultato { get; set; }
        bool Check { get; set; }
        public Operazione()
        {
            Check = false;
        }
        public double Divisione(double n)
        {
            if (Check == false)
            {
                Risultato = n;
                Check = true;
            }
            else
                Risultato = Risultato / n;
            return Risultato;
        }

        public double Moltiplicazione(double n)
        {
            if (Check == false)
            {
                Risultato = n;
                Check = true;
            }
            else
                Risultato = Risultato * n;
            return Risultato;
        }

        public double Somma(double n)
        {
            if (Check == false)
            {
                Risultato = n;
                Check = true;
            }
            else
                Risultato = Risultato + n;
            return Risultato;
        }

        public double Sottrazione(double n)
        {
            if (Check == false)
            {
                Risultato = n;
                Check = true;
            }
            else
                Risultato = Risultato - n;
            return Risultato;
        }

        public double XAllaseconda(double n)
        {
            return n * n;
        }

        public double Radicequadrata(double n)
        {
            return Math.Sqrt(n);
        }

        public double Unosux(double n)
        {
            return 1 / n;
        }
    }
}
