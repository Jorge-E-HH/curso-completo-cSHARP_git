using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP3.Errors
{
    public class BeerNotFountException
    {
        public BeerNotFountException() : base() { }
        public BeerNotFountException(string message): base(message) { }
        public BeerNotFountException(string message, Exception inner) : base(message, inner) { }
    }
}
