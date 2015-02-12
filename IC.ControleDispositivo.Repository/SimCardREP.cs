using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IC.ControleDispositivo.DataAccess;
using IC.ControleDispositivo.Modelo;

namespace IC.ControleDispositivo.Repository {
    public class SimCardREP {
        public List<SimCardMOD> Listar() {
            using (var conexao = new DISPCONTROLEntities()) {
                return conexao.TB_SIMCARD.ToList().ConvertAll(tabela =>
                    new SimCardMOD {
                        CodigoSimCard = tabela.CODIGO_SIMCARD,
                        CodigoAgencia = tabela.CODIGO_AGENCIA,
                        NumeroCCID = tabela.NR_CCID,
                        NumeroSimCard = tabela.NR_SIMCARD
                    });
            }
        }
    }
}
