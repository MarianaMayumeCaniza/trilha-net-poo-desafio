using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone cel1 = new Nokia("123456", "Nokia XP", "1111111111", 64);
cel1.Ligar();
cel1.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone cel2 = new Iphone("987654", "Iphone 3", "2222222222", 128);
cel2.ReceberLigacao();
cel2.InstalarAplicativo("Facetime");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone cel3 = new Nokia("234567", "Nokia 3310", "3333333333", 32);
cel3.Ligar();
cel3.InstalarAplicativo("Snake");
cel3.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone cel4 = new Iphone("876543", "Iphone 11", "4444444444", 256);
cel4.InstalarAplicativo("Apple Music");
