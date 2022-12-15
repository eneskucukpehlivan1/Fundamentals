using OOP.Encapsulation;
using OOP.Inheritance;

Console.WriteLine("Encapsulation Example:");

UserControl user = new UserControl();
user.UserName = "enesk";
user.Password = "123456";

Console.WriteLine("Kullanici Adi: {0} - Şifre: {1}", user.UserName, user.Password);
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Inheritance Example:");
Manager manager = new Manager();
//Workerdan inherit edilen üyeler
manager.WorkerNo = 1;
manager.WorkerName = "Enes Küçükpehlivan";
manager.WorkerSalary = 15000;
//Yönetici sınıfında tanımlanan üye
manager.DepartmentProfit = 150000;

//Workerdan inherit edilen üyeler
Personel personel = new Personel();
personel.WorkerNo = 2;
personel.WorkerName = "Enes Küçükpehlivan";
personel.WorkerSalary = 10000;
//Personel sınıfında tanımlanan üye
personel.SalesCount = 10;
Console.WriteLine("Yönetici No: {0} Adı: {1} Maaşı: {2}, Departman Karı: {3}", manager.WorkerNo.ToString(), manager.WorkerName.ToString(), manager.WorkerSalary.ToString(), manager.DepartmentProfit.ToString());
Console.WriteLine("Personel No: {0} Adı: {1} Maaşı: {2}, Satış Sayısı: {3}", personel.WorkerNo.ToString(), personel.WorkerName.ToString(), personel.WorkerSalary.ToString(), personel.SalesCount.ToString());
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Polymorphism Example:");
Manager2 manager2 = new Manager2();
//Workerdan inherit edilen üyeler
manager2.WorkerNo = 1;
manager2.WorkerName = "Enes Küçükpehlivan";
manager2.WorkerSalary = 15000;
//Yönetici sınıfında tanımlanan üye
manager2.DepartmentProfit = 150000;
Console.WriteLine("Yönetici No: {0} Adı: {1} Maaşı: {2}, Departman Karı: {3}", manager.WorkerNo.ToString(), manager.WorkerName.ToString(), manager.WorkerSalary.ToString(), manager.DepartmentProfit.ToString());
double raise = 2000;
manager2.Raise(raise);
Console.WriteLine("Zam Miktarı: {0} Zamlı Maaş: {1}", raise, manager2.WorkerSalary);
Console.WriteLine("--------------------------------------------------------------");



Console.ReadKey();