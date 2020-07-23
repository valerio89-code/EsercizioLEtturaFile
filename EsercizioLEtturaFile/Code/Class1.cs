using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioLEtturaFile.Code
{
    abstract class Class1
    {
        public abstract void Metodo2();
        private protected string Metodo1()
        {
            return "si, posso contenere metodi non astratti!!";
        }
    }

    interface ITest
    {
        void M1();
    }
}
