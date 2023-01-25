using Common.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Common.Controllers
{
    public class EmailController : IEmail
    {
        string _emailDestinatario;
        string _emailTitulo;
        string _emailMensagem;
        public EmailController()
        {
            
        }

        public void enviarEmailColetaAdicionada(ColetaModel coleta)
        {
            this._emailDestinatario = File.ReadAllText("email.db") + ";" + coleta.solicitante;
            this._emailTitulo = $"#{coleta.id} COLETA {coleta.localColeta} X {coleta.localEntrega} - {coleta.dataNecessaria.ToShortDateString()} - {coleta.CC_Projeto}".ToUpper();
            this._emailMensagem = 
$@"Olá,

Nova coleta inserida para {coleta.dataNecessaria.ToShortDateString()} {coleta.periodoColeta}.

Material: {coleta.materialDescricao}

Atenciosamente.";
           // Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MailItem email = new Outlook.Application().CreateItem(Outlook.OlItemType.olMailItem);
            email.To = this._emailDestinatario;
            email.Subject = this._emailTitulo;
            email.Body = this._emailMensagem;
            email.Send();
        }

        public void enviarEmailColetaConcluida(ColetaModel coleta)
        {
            this._emailDestinatario = coleta.solicitante;
            this._emailTitulo = $"#{coleta.id} COLETA {coleta.localColeta} X {coleta.localEntrega} - {coleta.dataNecessaria.ToShortDateString()} - {coleta.CC_Projeto} - CONCLUÍDA".ToUpper();
            this._emailMensagem =
$@"Olá,
Sua coleta solicitada para {coleta.dataNecessaria.ToShortDateString()} foi finalizada com sucesso, descrição do material:

Material: {coleta.materialDescricao}

O material foi coletado em {coleta.dataColeta.ToShortDateString()}

Atenciosamente.";
            // Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MailItem email = new Outlook.Application().CreateItem(Outlook.OlItemType.olMailItem);
            email.To = this._emailDestinatario;
            email.Subject = this._emailTitulo;
            email.Body = this._emailMensagem;
            email.Send();
        }

        public void enviarEmailColetaFalhou(ColetaModel coleta)
        {
            this._emailDestinatario = coleta.solicitante;
            this._emailTitulo = $"#{coleta.id} COLETA {coleta.localColeta} X {coleta.localEntrega} - {coleta.dataNecessaria.ToShortDateString()} - {coleta.CC_Projeto} - NÃO REALIZADA".ToUpper();
            this._emailMensagem =
$@"Olá,

Sua coleta solicitada para {coleta.dataNecessaria.ToShortDateString()} não foi possivel, problema ocorrido:

{coleta.motivoFalha}

Atenciosamente.";
            // Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MailItem email = new Outlook.Application().CreateItem(Outlook.OlItemType.olMailItem);
            email.To = this._emailDestinatario;
            email.Subject = this._emailTitulo;
            email.Body = this._emailMensagem;
            email.Send();
        }
    }
}
