using System;
namespace SolidPrinciples.SingleResponsibility
{
	public class SendMail
	{
		private MailAdressValidator _validator = new MailAdressValidator();
		public void SendMailWithGmail(bool value)
		{
			if (!_validator.IsMailAdressValid(value))
				Console.WriteLine("Adres doğru biçimde değil.");
			else
				Console.WriteLine("Mail gönderildi.");
		}
	}
}

