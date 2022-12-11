using DependecyInjectionExample;

Engine engine = GasolineEngine.CreateAsSingleton();
Car car = new AutoCar(engine);
car.drive();

Engine engine2 = new DieselEngine();
Car car2 = new AutoCar(engine2);
car2.drive();

Engine engine3 = new ElectricEngine();
Car car3 = new AutoCar(engine3);
car3.drive();

Console.ReadLine();