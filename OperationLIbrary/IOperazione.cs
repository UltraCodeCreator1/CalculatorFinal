using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLIbrary
{
    public interface IOperazione
    {
        int Somma(int n);
        int Sottrazione(int n);
        int Divisione(int n);
        int Moltiplicazione(int n);
        int XAllaseconda(int n);
        double Radicequadrata(int n);
        double Unosux(int n);
    }
}
