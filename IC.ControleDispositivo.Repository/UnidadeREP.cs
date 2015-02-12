using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IC.ControleDispositivo.DataAccess;
using IC.ControleDispositivo.Modelo;

namespace IC.ControleDispositivo.Repository
{
    public class UnidadeREP
    {
        public List<UnidadeMOD> Listar()
        {
            using (var conexao = new DISPCONTROLEntities())
            {
                return conexao.TB_UNIDADE.ToList().ConvertAll(tabela =>
                    new UnidadeMOD
                    {
                        CodigoUnidade = tabela.CODIGO_UNIDADE,
                        CodigoAgencia = tabela.CODIGO_AGENCIA,
                        NomeUnidade = tabela.NM_UNIDADE
                    });
            }
        }

        public List<UnidadeMOD> BucarUnidade(Int32 codigoUnidade)
        {
            using (var conexao = new DISPCONTROLEntities())
            {
                return conexao.TB_UNIDADE.ToList().ConvertAll(tabela => new UnidadeMOD
                {
                    CodigoUnidade = codigoUnidade,
                    NomeUnidade = tabela.NM_UNIDADE
                });
            }
        }

        public IList<UnidadeMOD> BuscarUnidadePelaAgencia(Int32 codigoAgencia)
        {
            using (var conexao = new DISPCONTROLEntities())
            {
                return conexao.TB_UNIDADE.ToList().ConvertAll(tabela => new UnidadeMOD
                {
                    CodigoAgencia = codigoAgencia,
                    NomeUnidade = tabela.NM_UNIDADE
                });
            }
        }
    }
}
