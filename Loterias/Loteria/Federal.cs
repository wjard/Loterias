using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loterias.Loteria
{
    public class Federal: BaseLoteria
    {
        public override string ToString()
        {
            return "federal";
        }

        public Federal()
            : base()
        { }

        public Federal(int? concurso = null)
            :base(concurso)
        {
        }
    }
}
