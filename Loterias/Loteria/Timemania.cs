using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loterias.Loteria
{
    public class Timemania: BaseLoteria
    {
        public override string ToString()
        {
            return "timemania";
        }

        public Timemania()
            : base()
        { }

        public Timemania(int? concurso = null)
            :base(concurso)
        {
        }
    }
}
