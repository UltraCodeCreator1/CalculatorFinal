using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLIbrary
{
    public class Operazione : IOperazione
    {
        int _risultato { get; set; }
        bool _check { get; set; }
        public Operazione(bool check)
        {
            _check = check;
        }
        public int Divisione(int n)
        {
            if (_check == false)
            {
                _risultato = n;
                _check = true;
            }
            else
                _risultato = _risultato / n;
            return _risultato;
        }

        public int Moltiplicazione(int n)
        {
            if (_check == false)
            {
                _risultato = n;
                _check = true;
            }
            else
                _risultato = _risultato * n;
            return _risultato;
        }

        public int Somma(int n)
        {
            if (_check == false)
            {
                _risultato = n;
                _check = true;
            }
            else
                _risultato = _risultato + n;
            return _risultato;
        }

        public int Sottrazione(int n)
        {
            if (_check == false)
            {
                _risultato = n;
                _check = true;
            }
            else
                _risultato = _risultato - n;
            return _risultato;
        }

        public int XAllaseconda(int n)
        {
            return n * n;
        }

        public double Radicequadrata(int n)
        {
            return Math.Sqrt(n);
        }

        public double Unosux(int n)
        {
            return 1 / n;
        }
    }
}
