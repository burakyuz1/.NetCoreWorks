using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSProblem
{
    public class DeveKusu : Kus
    {
        public override string Uc()
        {
            throw new NotImplementedException("Deve kuşu uçamaz!");
        }

        public override string ToString()
        {
            return "Deve Kuşu";
        }
    }
}
