using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace T3H_Cap03_P1.Controllers
{
    public class ArquivosController : Controller
    {
        public ActionResult Foto()
        {
            // Mapeamento do arquivo a retornar

            var Arq = Server.MapPath("/Arqs/Imagem.jpg");

            // Arquivo a retornar + MimeType

            return base.File(Arq, "image/jpeg");
        }

        public ActionResult Documento()
        {
            // Mapeamento do arquivo a retornar

            var Arq = Server.MapPath("/Arqs/apostila.pdf");

            // Arquivo a retornar + MimeType

            return base.File(Arq, "application/pdf");
        }

        public string Alunos()
        {
            // Mapeamento para o arquivo 

            string Caminho = Server.MapPath("/Arqs/dados.xml");

            // Carga do arquivo

            XmlDocument Doc = new XmlDocument();
            Doc.Load(Caminho);

            // Posicionar no Node correto

            XmlNodeList Lista = Doc.GetElementsByTagName("aluno");

            string sNomes = "";

            // Varredura dos nomes dentro dos Nodes

            foreach (XmlNode Item in Lista)
            {
                sNomes += Item["nome"].InnerText + " - ";
            }

            return sNomes;
        }

    }
}