using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("-----------TESTE NOKIA-----------");
Smartphone nokia = new Nokia("N0K123", "MODEL NOK123", "1111111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("FACEBOOK");

System.Console.WriteLine("\n");
System.Console.WriteLine("-----------TESTE IPHONE-----------");
Smartphone iphone = new Iphone("I123", "MODEL IO123", "242424242", 64);
nokia.Ligar();
nokia.InstalarAplicativo("SIGNAL");