using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia(numero: "1111-1111", modelo: "Modelo Nokia1", imei: "121212", memoria: 32);
nokia.infoSmartphone();
nokia.Ligar();
nokia.InstalarAplicativo("\"Waze\"");

Console.WriteLine("\n");

Console.WriteLine("IPhone: ");
Smartphone iphone = new Iphone(numero: "2222-2222", modelo: "Iphone wxy", imei: "232323", memoria: 128);
iphone.infoSmartphone();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("\"dio\"");

 