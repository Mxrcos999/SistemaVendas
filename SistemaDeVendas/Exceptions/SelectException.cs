using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas.Exceptions
{
    public class SelectException : Exception
    {
        public SelectException(string message) : base(message) { }

    }
}
