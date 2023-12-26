using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "122755", modelo: "Modelo 1", imei: "123789456", memoria: 64);
nokia.Apresetar();
nokia.Ligar();
nokia.InstalarAplicativo(nomeApp: "Instagram");


Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "125527", modelo: "Modelo 2", imei: "456123789", memoria: 128);
iphone.Apresetar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp: "You Tube");