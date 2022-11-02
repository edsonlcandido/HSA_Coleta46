using Common.Models;
using System;
using System.Collections.Generic;
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

        public void enviarEmailColetaAdicionada(ColetaModel coleta, int id)
        {
            this._emailDestinatario = "edsonluizcandido+adminColeta@gmail.com";
            this._emailTitulo = $"#{id} Nova coleta inserida para {coleta.dataNecessaria.ToShortDateString()} {coleta.dataNecessaria.ToShortTimeString()}";
            this._emailMensagem = 
$@"Olá,
Nova coleta inserida para {coleta.dataNecessaria.ToShortDateString()} {coleta.dataNecessaria.ToShortTimeString()}, material a ser coletado:
{coleta.materialDescricao}

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
            this._emailTitulo = $"#{coleta.id} Sua coleta de {coleta.materialDescricao} foi concluída com sucesso";
            this._emailMensagem =
$@"Olá,
Sua coleta solicitada para {coleta.dataNecessaria.ToShortDateString()} {coleta.dataNecessaria.ToShortTimeString()} foi finalizada com sucesso, descrição do material:
{coleta.materialDescricao}

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
            this._emailTitulo = $"#{coleta.id} Sua coleta de {coleta.materialDescricao} teve algum problema";
            this._emailMensagem =
$@"Olá,
Sua coleta solicitada para {coleta.dataNecessaria.ToShortDateString()} {coleta.dataNecessaria.ToShortTimeString()} não foi possivel, problema ocorrido:
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
