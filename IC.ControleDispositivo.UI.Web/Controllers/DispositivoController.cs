using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IC.ControleDispositivo.Modelo;
using IC.ControleDispositivo.Repository;

namespace IC.ControleDispositivo.UI.Web.Controllers
{
    public class DispositivoController : Controller
    {

        private DispositivoREP banco = new DispositivoREP();

        private void CarregarAgencia(){
            var conexao = new AgenciaREP();
            ViewBag.Agencia = new SelectList(
              conexao.Listar(),
              "CodigoAgencia",
              "NomeAgencia"
              );
        }
        private void CarregarUnidade() {
            var conexao = new UnidadeREP();
            ViewBag.Unidade = new SelectList(
              conexao.Listar(),
              "CodigoUnidade",
              "NomeUnidade"
              );
        }
        private void CarregarFabricante() {
            var conexao = new FabricanteREP();
            ViewBag.Fabricante = new SelectList(
              conexao.Listar(),
              "CodigoFabricante",
              "NomeFabricante"
              );
        }
        public IList<UnidadeMOD> CarregarUnidadePelaAgencia(Int32 codAgencia){
            var conexao = new UnidadeREP();
            return ViewBag.Unidade = new SelectList(
                conexao.BuscarUnidadePelaAgencia(codAgencia),
                "CodigoUnidade",
                "NomeUnidade");
        }

        private void CarregarModeloDispositivo() {
            var conexao = new ModeloDispositivoREP();
            ViewBag.ModeloDispositivo = new SelectList(
              conexao.Listar(),
              "CodigoModeloDispositivo",
              "NomeModeloDispositivo"
              );
        }
        private void CarregarSituacao() {
            var conexao = new SituacaoREP();
            ViewBag.Situacao = new SelectList(
              conexao.Listar(),
              "CodigoSituacao",
              "NomeSituacao"
              );
        }
        private void CarregarFirmware() {
            var conexao = new FirmwareREP();
            ViewBag.Firmware = new SelectList(
              conexao.Listar(),
              "CodigoFirmware",
              "NomeFirmware"
              );
        }
        private void CarregarSimCard() {
            var conexao = new SimCardREP();
            ViewBag.SimCard = new SelectList(
              conexao.Listar(),
              "CodigoSimCard",
              "NumeroSimCard"
              );
        }
            //
        // GET: /Dispositivo/
        public ActionResult Cadastro()
        {
            CarregarAgencia();
            CarregarUnidade();
            CarregarFabricante();
            CarregarModeloDispositivo();
            CarregarSituacao();
            CarregarFirmware();
            CarregarSimCard();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(DispositivoMOD dadosTela)
        {
            banco.Cadastrar(dadosTela);
            TempData.Add("Sucesso", "Cadastrado com Sucesso!");
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            var dispositivos = banco.Listar();            
            return View(dispositivos);
        }
	}
}