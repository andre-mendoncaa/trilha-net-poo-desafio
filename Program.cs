using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("946335330", "K3", "350511111111-1", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("11946335330", "Iphone 15", "18181818181818", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");

// TODO: Realizar os testes com as classes Nokia e Iphone