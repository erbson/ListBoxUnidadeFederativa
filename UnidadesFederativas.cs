using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxEstadosBrasileiros
{
    public class UnidadesFederativas
    {
        public string sigla { get; set; }
        public string Estado { get; set; }
        public string Formatadada
        { get
            {
                return string.Format("{0} : {1}", sigla, Estado);

            }

               
            
        
    }


    }
}
