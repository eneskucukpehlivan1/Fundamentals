using SolidPrinciples.DependencyInversion;
using SolidPrinciples.InterfaceSegregation;
using SolidPrinciples.LiskovsSubstitution;
using SolidPrinciples.SingleResponsibility;

Console.WriteLine("Solid için Örnek:");
SendMail sendMail = new SendMail();
sendMail.SendMailWithGmail(false);
sendMail.SendMailWithGmail(true);
Console.WriteLine("----------------------");
Console.WriteLine("Open/Closed için Örnek:");
Logger logger = new Logger(new DBLog());
logger.Log();
Logger logger2 = new Logger(new XmlLog());
logger2.Log();
Console.WriteLine("----------------------");
Console.WriteLine("Liskov's Substitution için Örnek:");
HpPrinter hpPrinter = new HpPrinter();
CanonPrinter canonPrinter = new CanonPrinter();
hpPrinter.Print();
canonPrinter.Print();
canonPrinter.Scan();
Console.WriteLine("----------------------");
Console.WriteLine("Interface Segregation için Örnek:");
Manager manager = Manager.CreateAsSingleton();
Robot robot = Robot.CreateAsSingleton();
Worker worker = Worker.CreateAsSingleton();
manager.Eat();
manager.Work();
robot.Work();
worker.Eat();
worker.GetSalary();
worker.Work();
Console.WriteLine("----------------------");
Console.WriteLine("Dependency Inversion için Örnek:");
logger.Log();
logger2.Log();

Console.ReadLine();


