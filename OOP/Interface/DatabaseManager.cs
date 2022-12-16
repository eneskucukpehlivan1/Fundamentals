using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    class DatabaseManager
    {
        private IDatabase database;
        private string mark = new string('-', 6);
        public DatabaseManager(IDatabase database)
        {
            this.database = database;
        }
        public void loginDB()
        {
            string userName, password;
            Console.Write("{0}\n< Veri Tabanı Bağlantısı >\n{1}\n-> Kullanıcı adını girin: ", mark, mark);
            userName = Console.ReadLine();
            Console.Write("-> Kullanıcı şifresini girin: ");
            password = Console.ReadLine();
            Console.WriteLine(mark);
            if (database.login(userName, password) == 1)
                menu();
            else
                Console.WriteLine("-> Bağlantı bilgilerini yanlış girdiniz, sistem kapatılıyor.\n{0}", mark);

        }
        private void closeDB()
        {
            database.close();
        }
        private void addValue(string value)
        {
            database.addValue(value);
        }
        private void deleteValue()
        {
            database.deleteValue();
        }
        private void getValue()
        {
            database.getValue();
        }

        private void menu()
        {
            string value;
            int v;
            Console.WriteLine("< Veri Tabanı İşlemleri >\n{0}", mark);
            Console.WriteLine("[1] - Veri Ekle\n[2] - Veri Sil\n[3] - Veri Getir\n[4] - Bağlantıyı Kes\n{0}", mark);
            Console.Write("-> Yapmak istediğiniz işlem: ");
            v = Convert.ToInt32(Console.ReadLine());
            switch (v)
            {
                case 1:
                    Console.Write("{0}\n-> Eklemek istediğiniz veri: ", mark);
                    value = Console.ReadLine();
                    addValue(value);
                    Console.WriteLine(mark);
                    Console.Clear();
                    menu();
                    break;
                case 2:
                    Console.Clear();
                    deleteValue();
                    menu();
                    break;
                case 3:
                    Console.Clear();
                    getValue();
                    menu();
                    break;
                case 4:
                    closeDB();
                    break;
            }
        }
    }
}
