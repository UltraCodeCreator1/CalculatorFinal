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

        public double Calcolo(double n, string segno)
        {
            if (Check == false)
            {
                Risultato = n;
                Check = true;
            }
            else
            {
                switch(segno)
                {
                    case "+":
                        Risultato = Risultato + n;
                        break;
                    case "-":
                        Risultato = Risultato - n;
                        break;
                    case "/":
                        Risultato = Risultato / n;
                        break;
                    case "*":
                        Risultato = Risultato * n;
                        break;
                }
            }
            return Risultato;
        }
    }
}
