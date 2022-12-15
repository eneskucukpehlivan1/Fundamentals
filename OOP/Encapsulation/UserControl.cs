using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class UserControl
    {
        private string _userName;
        private string _password;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                bool isOk = true;
                for(int i = 0; i<value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        isOk = false;
                        break;
                    }
                }
                if(isOk)
                {
                    _userName = value;
                }
                else
                {
                    throw new ArgumentException("Kullanıcı Adı Harf Dışında Karakter İçeremez");
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
