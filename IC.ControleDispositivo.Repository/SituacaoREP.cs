using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IC.ControleDispositivo.DataAccess;
using IC.ControleDispositivo.Modelo;

namespace IC.ControleDispositivo.Repository {
    public class SituacaoREP {
        public List<SituacaoMOD> Listar() {
            using (var conexao = new DISPCONTROLEntities()) {
                return conexao.TB_SITUACAO.ToList().ConvertAll(tabela =>
                    new SituacaoMOD {
                        CodigoSituacao = tabela.CODIGO_SITUACAO,
                        NomeSituacao = tabela.NM_SITUACAO
                    });
            }
        }
    }
}
