using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IC.ControleDispositivo.DataAccess;
using IC.ControleDispositivo.Modelo;

namespace IC.ControleDispositivo.Repository {
    public class FirmwareREP {
        public List<FirmwareMOD> Listar() {
            using (var conexao = new DISPCONTROLEntities()) {
                return conexao.TB_FIRMWARE.ToList().ConvertAll(tabela =>
                    new FirmwareMOD {
                        CodigoFirmware = tabela.CODIGO_FIRMWARE,
                        NomeFirmware = tabela.NM_FIRMWARE,
                        DataCriacao = tabela.DT_CRIACAO
                    });
            }
        }
    }
}
