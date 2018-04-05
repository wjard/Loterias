using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loterias.Loteria
{
    public class Lotogol: BaseLoteria
    {
        public override string ToString()
        {
            return "lotogol";
        }

        public Lotogol()
            : base()
        { }

        public Lotogol(int? concurso = null)
            :base(concurso)
        {
        }
    }
}
