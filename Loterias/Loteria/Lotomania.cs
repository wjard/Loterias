using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loterias.Loteria
{
    public class Lotomania: BaseLoteria
    {
        public override string ToString()
        {
            return "lotomania";
        }

        public Lotomania()
            : base()
        { }

        public Lotomania(int? concurso = null)
            :base(concurso)
        {
        }
    }
}
