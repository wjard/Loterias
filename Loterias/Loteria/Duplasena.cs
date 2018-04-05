using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loterias.Loteria
{
    public class Duplasena: BaseLoteria
    {
        public override string ToString()
        {
            return "duplasena";
        }

        public Duplasena()
            : base()
        { }

        public Duplasena(int? concurso = null)
            :base(concurso)
        {
        }
    }
}
