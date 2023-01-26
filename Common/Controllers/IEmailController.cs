using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Controllers
{
    public  interface IEmailController
    {
        void enviarEmailColetaAdicionada(ColetaModel coleta);
        void enviarEmailColetaConcluida(ColetaModel coleta);
        void enviarEmailColetaFalhou(ColetaModel coleta);
        List<EmailModel> destinatarios { get; set; }
    }
}
