using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.ControleDispositivo.Modelo
{
    public class DispositivoMOD
    {
        public DispositivoMOD() {
            Agencia = new AgenciaMOD();
            Unidade = new UnidadeMOD();
            Fabricante = new FabricanteMOD();
            Modelo = new ModeloDispositivoMOD();
            Situacao = new SituacaoMOD();
            Firmware = new FirmwareMOD();
            SimCardPrimario = new SimCardMOD();
            SimCardSecundario = new SimCardMOD();
        }
        public Int32 CodigoDispositivo { get; set; }

        [Display(Name = "Fabricante")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public FabricanteMOD Fabricante { get; set; }

        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public ModeloDispositivoMOD Modelo { get; set; }

        [Display(Name = "Firmware")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public FirmwareMOD Firmware { get; set; }

        [Display(Name = "IMEI")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public String NumeroImei { get; set; }

        [Display(Name = "SimCard 1")]
        public SimCardMOD SimCardPrimario { get; set; }

        [Display(Name = "SimCard 2")]
        public SimCardMOD SimCardSecundario { get; set; }

        [Display(Name = "Situação")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public SituacaoMOD Situacao { get; set; }

        [Display(Name = "Agência")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public AgenciaMOD Agencia { get; set; }

        [Display(Name = "Unidade")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public UnidadeMOD Unidade { get; set; }
    }
}
