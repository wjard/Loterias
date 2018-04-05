using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loterias.Loteria
{
    public class Loteca: BaseLoteria
    {
        public override string ToString()
        {
            return "loteca";
        }

        public Loteca()
            : base()
        { }

        public Loteca(int? concurso = null)
            :base(concurso)
        {
        }
    }
}
