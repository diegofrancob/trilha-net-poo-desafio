using DesafioPOO.Models;

Console.WriteLine("TESTES");
Console.WriteLine("");

var iphone = new Iphone(numero: "11999999999", modelo: "iPhone 16", imei: "123456789", memoria: 512);

Console.WriteLine($"Testando {iphone.GetType().Name}");

iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();

Console.WriteLine("");

var nokia = new Nokia(numero: "1188888888888", modelo: "Nokia C21", imei: "987654321", memoria: 128);

Console.WriteLine($"Testando {nokia.GetType().Name}");

nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao();