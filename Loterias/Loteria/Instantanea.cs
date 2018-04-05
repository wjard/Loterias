using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loterias.Loteria
{
    public class Instantanea: BaseLoteria
    {
        public override string ToString()
        {
            return "instantanea";
        }

        public Instantanea()
            : base()
        { }

        public Instantanea(int? concurso = null)
            :base(concurso)
        {
        }
    }
}
