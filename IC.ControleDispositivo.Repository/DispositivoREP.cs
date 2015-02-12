using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IC.ControleDispositivo.DataAccess;
using IC.ControleDispositivo.Modelo;

namespace IC.ControleDispositivo.Repository
{
    public class DispositivoREP
    {

        public void Cadastrar(DispositivoMOD dadosTela)
        {
            using (var conexao = new DISPCONTROLEntities())
            {
                var novoDispositivo = new TB_DISPOSITIVO();

                novoDispositivo.CODIGO_FABRICANTE = dadosTela.Fabricante.CodigoFabricante;
                novoDispositivo.CODIGO_FIRMWARE = dadosTela.Firmware.CodigoFirmware;
                novoDispositivo.CODIGO_MODELO = dadosTela.Modelo.CodigoModeloDispositivo;
                novoDispositivo.CODIGO_SIMCARD_PRIMARIO = dadosTela.SimCardPrimario.CodigoSimCard;
                novoDispositivo.CODIGO_SIMCARD_SECUNDARIO = dadosTela.SimCardSecundario.CodigoSimCard;
                novoDispositivo.CODIGO_SITUACAO = dadosTela.Situacao.CodigoSituacao;
                novoDispositivo.CODIGO_UNIDADE = dadosTela.Unidade.CodigoUnidade;
                novoDispositivo.CODIGO_AGENCIA = dadosTela.Agencia.CodigoAgencia;
                novoDispositivo.NR_IMEI = dadosTela.NumeroImei;

                conexao.TB_DISPOSITIVO.Add(novoDispositivo);
                conexao.SaveChanges();
            }
        }

        public List<DispositivoMOD> Listar()
        {
            using (var conexao = new DISPCONTROLEntities())
            {
                return conexao.TB_DISPOSITIVO.ToList().ConvertAll
                    (registro =>
                    {
                        return new DispositivoMOD {
                            CodigoDispositivo = registro.CODIGO_DISPOSITIVO,
                            Fabricante = new FabricanteMOD {
                                CodigoFabricante = registro.CODIGO_FABRICANTE,
                                NomeFabricante = registro.TB_FABRICANTE_DISPOSITIVO.NM_FABRICANTE_DISPOSITIVO
                            },
                            Firmware = new FirmwareMOD {
                                CodigoFirmware = registro.CODIGO_FIRMWARE,
                                NomeFirmware = registro.TB_FIRMWARE.NM_FIRMWARE,
                                DataCriacao = registro.TB_FIRMWARE.DT_CRIACAO
                            },
                            Modelo = new ModeloDispositivoMOD {
                                CodigoModeloDispositivo = registro.CODIGO_MODELO,
                                CodigoFabricante = registro.CODIGO_FABRICANTE,
                                NomeModeloDispositivo = registro.TB_MODELO_DISPOSITIVO.NM_MODELO_DISPOSITIVO,
                                NumeroSimCards = registro.TB_MODELO_DISPOSITIVO.NR_SIMCARDS
                            },
                            SimCardPrimario = new SimCardMOD {
                                CodigoSimCard = (Int32)registro.CODIGO_SIMCARD_PRIMARIO,
                                CodigoOperadora = registro.TB_SIMCARD.CODIGO_OPERADORA,
                                CodigoAgencia = registro.TB_AGENCIA.CODIGO_AGENCIA,
                                NumeroCCID = registro.TB_SIMCARD.NR_CCID,
                                NumeroSimCard = registro.TB_SIMCARD.NR_SIMCARD
                            },
                            SimCardSecundario = new SimCardMOD {
                                CodigoSimCard = (Int32)registro.CODIGO_SIMCARD_SECUNDARIO,
                                CodigoOperadora = registro.TB_SIMCARD1.CODIGO_OPERADORA,
                                CodigoAgencia = registro.TB_AGENCIA.CODIGO_AGENCIA,
                                NumeroCCID = registro.TB_SIMCARD1.NR_CCID,
                                NumeroSimCard = registro.TB_SIMCARD1.NR_SIMCARD
                            },
                            Situacao = new SituacaoMOD {
                                CodigoSituacao = registro.CODIGO_SITUACAO,
                                NomeSituacao = registro.TB_SITUACAO.NM_SITUACAO
                            },
                            Unidade = new UnidadeMOD {
                                CodigoUnidade = registro.CODIGO_UNIDADE,
                                CodigoAgencia = registro.CODIGO_AGENCIA,
                                NomeUnidade = registro.TB_UNIDADE.NM_UNIDADE
                            },
                            Agencia = new AgenciaMOD {
                                CodigoAgencia = registro.CODIGO_AGENCIA,
                                NomeAgencia = registro.TB_AGENCIA.NM_AGENCIA
                            },
                            NumeroImei = registro.NR_IMEI
                        };
                    });
            }
        }
    }
}
