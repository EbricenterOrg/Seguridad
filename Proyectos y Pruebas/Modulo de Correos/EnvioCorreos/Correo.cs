using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioCorreos
{
    public class Correo
    {
        private static string sPara;
        private static string sAsunto;
        private static string sMensaje;
        private static string sCorreoEnviar;
        private static string sPathArchivo;
        private static string sTipoCliente;
        private static string sCorreoRemitente;
        private static string sPassCorreoRemitente;
        private static string sMensajeAceptado;
        private static int iNumCliente;
        private MailMessage mmCorreo;
        private Attachment atcData;


        public string Para { get { return sPara; } set { sPara = value; } }

        public string Remitente { get { return sCorreoEnviar; } set { sCorreoEnviar = value; } }

        public string Asunto { get { return sAsunto; } set { sAsunto = value; } }

        public string Mensaje { get { return sMensaje; } set { sMensaje = value; } }

        public string PathArchivo { get { return sPathArchivo; } set { sPathArchivo = value; } }

        public string TipoCliente { get { return sTipoCliente; } set { sTipoCliente = value; } }

        public int PuertoCliente { get { return iNumCliente; } set { iNumCliente = value; } }

        public string Credencial { get { return sCorreoRemitente; } set { sCorreoRemitente = value; } }

        public string PassCredencial { get { return sPassCorreoRemitente; } set { sPassCorreoRemitente = value; } }

        public string MensajeAceptacion { get { return sMensajeAceptado; } set { sMensajeAceptado = value; } }
        public void vEnviarCorreo()
        {
            try
            {
                mmCorreo = new MailMessage();
                mmCorreo.To.Add(new MailAddress(sPara));
                mmCorreo.From = new MailAddress(sCorreoEnviar);
                mmCorreo.Subject = sAsunto;
                mmCorreo.Body = sMensaje;
                mmCorreo.IsBodyHtml = false;

                if (PathArchivo == String.Empty)
                {
                    atcData = new Attachment(PathArchivo, MediaTypeNames.Application.Octet);
                    mmCorreo.Attachments.Add(atcData);
                }

                SmtpClient smtCliente = new SmtpClient(TipoCliente, iNumCliente);
                using (smtCliente)
                {
                    smtCliente.Credentials = new System.Net.NetworkCredential(sCorreoRemitente, sPassCorreoRemitente);
                    smtCliente.EnableSsl = true;
                    smtCliente.Send(mmCorreo);
                }
                MessageBox.Show(sMensajeAceptado);
            }
            catch
            {
                MessageBox.Show("Error al enviar el correo");
            }
        }
    }
}
