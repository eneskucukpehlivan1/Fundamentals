using System;
namespace SolidPrinciples.SingleResponsibility
{
	public class MailAdressValidator
	{
		public bool IsMailAdressValid(bool value)
		{
			if (value)
				return true;
			else
				return false;
		}
	}
}

