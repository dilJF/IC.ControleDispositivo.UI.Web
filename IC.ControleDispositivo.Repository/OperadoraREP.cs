using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IC.ControleDispositivo.DataAccess;
using IC.ControleDispositivo.Modelo;

namespace IC.ControleDispositivo.Repository {
    public class OperadoraREP {
        public List<OperadoraMOD> Listar() {
            using (var conexao = new DISPCONTROLEntities()) {
                return conexao.TB_OPERADORA.ToList().ConvertAll(tabela =>
                    new OperadoraMOD {
                        CodigoOperadora = tabela.CODIGO_OPERADORA,
                        NomeOperadora = tabela.NM_OPERADORA
                    });
            }
        }
    }
}
