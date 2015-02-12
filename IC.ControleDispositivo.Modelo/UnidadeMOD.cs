using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.ControleDispositivo.Modelo {
    public class UnidadeMOD {
        public Int32 CodigoUnidade { get; set; }

        public Int32 CodigoAgencia { get; set; }

        public String NomeUnidade { get; set; }
    }
}
