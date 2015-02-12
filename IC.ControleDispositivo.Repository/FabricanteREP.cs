using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IC.ControleDispositivo.DataAccess;
using IC.ControleDispositivo.Modelo;

namespace IC.ControleDispositivo.Repository {
    public class FabricanteREP {
        public List<FabricanteMOD> Listar() {
            using (var conexao = new DISPCONTROLEntities()) {
                return conexao.TB_FABRICANTE_DISPOSITIVO.ToList().ConvertAll(tabela =>
                    new FabricanteMOD {
                        CodigoFabricante = tabela.CODIGO_FABRICANTE,
                        NomeFabricante = tabela.NM_FABRICANTE_DISPOSITIVO,
                    });
            }
        }
    }
}
