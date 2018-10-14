using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLIbrary
{
    public interface IOperazione
    {
        double Calcolo(double n, string segno);
        double XAllaseconda(double n);
        double Radicequadrata(double n);
        double Unosux(double n);
    }
}
