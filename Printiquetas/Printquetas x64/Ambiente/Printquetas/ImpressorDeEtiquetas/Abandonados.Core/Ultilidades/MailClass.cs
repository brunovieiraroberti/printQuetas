using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace Abandonados.Ultilidades
{
	public class MailClass
	{
		MailMessage objMailMessage = new MailMessage();

		private static string DEFAULT_FROM = "";
		private static string DEFAULT_SMTP_SERVER = "smtp.live.com";
		private static string DEFAULT_SMTP_LOGIN = "bv_roberti@hotmail.com";
		private static string DEFAULT_SMTP_PASS = "";
		private static int DEFAULT_SMTP_PORT = 0;

		private string _sEmailFrom;
		private string _sNameFrom;
		private string _sEmailTo;
		private string _sNameTo;
		private string _sSubject;
		protected string _sBody;

		private string _sSMTPServer;
		private string _sSMTPLogin;
		private string _sSMTPPass;
		private int _iSMTPPort;

		private void Initialize()
		{
			_sEmailFrom = MailClass.DEFAULT_SMTP_LOGIN;
			_sNameFrom = MailClass.DEFAULT_SMTP_LOGIN;
			_sSMTPServer = MailClass.DEFAULT_SMTP_SERVER;
			_sSMTPLogin = MailClass.DEFAULT_SMTP_LOGIN;
			_sSMTPPass = MailClass.DEFAULT_SMTP_PASS;
			_iSMTPPort = MailClass.DEFAULT_SMTP_PORT;
		}

		protected ICredentialsByHost GetCredential(string sLogin, string sSenha)
		{
			 return new NetworkCredential(sLogin, sSenha);
		}

		public void SendMail()
		{
			Initialize();
			CreateEmailMessage();
			Send();
		}

		protected void Send()
		{
			SmtpClient objSmtp = new SmtpClient();

			objSmtp.EnableSsl = true;
			objSmtp.Host = _sSMTPServer;
			objSmtp.Credentials = GetCredential(DEFAULT_SMTP_LOGIN, DEFAULT_SMTP_PASS);
			objSmtp.Send(objMailMessage);

		}

		protected MailMessage CreateEmailMessage()
		{
			objMailMessage.Sender = FormatEmailAddress(MailClass.DEFAULT_FROM);
			objMailMessage.From = FormatEmailAddress(MailClass.DEFAULT_FROM);
			objMailMessage.To.Add(FormatEmailAddress(_sEmailTo));
			objMailMessage.Subject = _sSubject;
			objMailMessage.Body = _sBody;

			return objMailMessage;
		}

		private MailAddress FormatEmailAddress(string sEmailAddress)
		{
			string sEmail = sEmailAddress;
			int iPosition = sEmail.IndexOf("<");
			string sName = "";

			if (iPosition >= 0)
			{
				sName = sEmail.Substring(0, iPosition);

				sEmail = sEmail.Remove(0, iPosition + 1);
			}

			sEmail = sEmail.Replace(">", "");

			if (sName.Trim().Length > 0)
				return new MailAddress(sEmail.Trim(), sName.Trim(), Encoding.GetEncoding("utf-8"));
			else
				return new MailAddress(sEmail.Trim(), "", Encoding.GetEncoding("utf-8"));
		}

		public string EmailFrom
		{
			get { return _sEmailFrom; }
			set { _sEmailFrom = value; }
		}

		public string NameFrom
		{
			get { return _sNameFrom; }
			set { _sNameFrom = value; }
		}

		public string EmailTo
		{
			get { return _sEmailTo; }
			set { _sEmailTo = value; }
		}

		public string NameTo
		{
			get { return _sNameTo; }
			set { _sNameTo = value; }
		}

		public string Subject
		{
			get { return _sSubject; }
			set { _sSubject = value; }
		}

		public virtual string Body
		{
			get { return _sBody; }
			set { _sBody = value; }
		}
	}
}
