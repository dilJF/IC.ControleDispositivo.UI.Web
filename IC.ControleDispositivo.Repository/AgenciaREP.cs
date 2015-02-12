using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IC.ControleDispositivo.DataAccess;
using IC.ControleDispositivo.Modelo;

namespace IC.ControleDispositivo.Repository {
    public class AgenciaREP {
        public List<AgenciaMOD> Listar() {
            using(var conexao = new DISPCONTROLEntities()){
                return conexao.TB_AGENCIA.ToList().ConvertAll(tabela =>
                    new AgenciaMOD {
                        CodigoAgencia = tabela.CODIGO_AGENCIA,
                        NomeAgencia = tabela.NM_AGENCIA
                    });
            }
        }
    }
}
