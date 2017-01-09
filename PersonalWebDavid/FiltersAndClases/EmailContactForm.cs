using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace PersonalWebDavid.Filters
{
    public static class EmailContactForm
    {
        public static string sendEmail( string _fromAddress,    string _toAdress,   
                                        string _subject,        string _fromPassword,
                                        string _message,        string _errorMessage,   
                                        string _successMessage, string _externalEmail,
                                         
                                        // Default parameters
                                        string _host = "smtp.gmail.com",
                                        int _port = 587,    int _timeOut = 20000)
        {
            string ret;
            try
            {
                // Instatiation
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = _host;
                smtpClient.Port = _port;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(_fromAddress, _fromPassword);
                smtpClient.Timeout = _timeOut;

                _subject = "Email: " + _externalEmail + " - Subject: " + _subject; 
                // Send message
                smtpClient.Send(_fromAddress, _toAdress, _subject, _message);

                // Return success message
                ret = _successMessage;
            }
            catch (Exception ex)
            {
                // Returns error message
                ret = _errorMessage;
                throw new Exception();
            }

            // if email was sent it returns a success message; otherwise, it return error message
            return ret;
        }

    }
}
