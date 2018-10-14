using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLIbrary
{
    public interface IOperazione
    {
        double Somma(double n);
        double Sottrazione(double n);
        double Divisione(double n);
        double Moltiplicazione(double n);
        double XAllaseconda(double n);
        double Radicequadrata(double n);
        double Unosux(double n);
    }
}
