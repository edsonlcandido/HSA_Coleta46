using Common.Models;
using Common.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Common.Controllers
{
    public class EmailController : IEmailController
    {
        string _emailDestinatario { 
            get { return string.Join(";", destinatarios.Select(d => d.email)); } 
        }
        string _emailTitulo;
        string _emailMensagem;

        public EmailController()
        {
            destinatarios = new List<EmailModel>();
        }

        public List<EmailModel> destinatarios { 
            get;
            set;
        }

        public void enviarEmailColetaAdicionada(ColetaModel coleta)
        {
            destinatarios.AddRange(EmailRepository.listar().ToList());
            destinatarios.Add(new EmailModel() { email = coleta.solicitante });
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
            destinatarios.Add(new EmailModel() { email = coleta.solicitante });
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
            destinatarios.Add(new EmailModel() { email = coleta.solicitante });
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
