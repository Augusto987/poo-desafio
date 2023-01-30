using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123123321", modelo: "Modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "93223293", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
