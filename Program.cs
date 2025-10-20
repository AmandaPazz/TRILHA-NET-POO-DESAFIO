using DesafioPOO.Models;


//Teste Iphone
Console.WriteLine("\n****************** \nTeste do Iphone");

//testando 2 maneira diferentes de fazer a instância
Smartphone iphone1 = new Iphone("(99)99910-0111", "17 PRO MAX", "111111", 64);
Iphone iphone2 = new Iphone("(99)99910-0222", "16 PRO MAX", "222222", 128);

iphone1.Ligar();
iphone1.ReceberLigacao();
Console.WriteLine($"Número do iphone 1 é {iphone1.Numero}");
iphone2.Ligar();
iphone2.ReceberLigacao();
Console.WriteLine($"Número do iphone 2 é {iphone2.Numero}");

//Fazendo troca de tipos e testando a classe nokia
Console.WriteLine("\n****************** \nTestando troca de tipos e testando a classe Nokia");
Smartphone celular = new Iphone("(99)99910-0111", "17 PRO MAX", "111111", 64);
celular = new Nokia("(99)99910-333", "3110", "111111", 8);
Console.WriteLine($"Número do celular nokia é {celular.Numero}");
celular.Ligar();
celular.ReceberLigacao();
celular.InstalarAplicativo("WhatsApp");
Console.WriteLine($"Número do celular nokia é {celular.Numero}");

//Teste do método InstalarAplicativo
Console.WriteLine("\n****************** \nTestando InstalarAplicativo");
iphone1.InstalarAplicativo("Instagram");
iphone2.InstalarAplicativo("TikTok");
celular.InstalarAplicativo("Facebook");