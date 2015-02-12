using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IC.ControleDispositivo.DataAccess;
using IC.ControleDispositivo.Modelo;

namespace IC.ControleDispositivo.Repository {
    public class ModeloDispositivoREP {
        public List<ModeloDispositivoMOD> Listar() {
            using (var conexao = new DISPCONTROLEntities()) {
                return conexao.TB_MODELO_DISPOSITIVO.ToList().ConvertAll(tabela =>
                    new ModeloDispositivoMOD {
                        CodigoModeloDispositivo = tabela.CODIGO_MODELO,
                        CodigoFabricante = tabela.CODIGO_FABRICANTE_DISPOSITIVO,
                        NomeModeloDispositivo = tabela.NM_MODELO_DISPOSITIVO,
                        NumeroSimCards = tabela.NR_SIMCARDS
                    });
            }
        }
    }
}
