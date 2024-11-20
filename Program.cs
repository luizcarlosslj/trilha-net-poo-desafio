using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Criando Smatphone Nokia");
Nokia n = new Nokia("231", "2200b", "asd*", 32);
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("DioApp");

Console.WriteLine("---------------------------");

Console.WriteLine("Criando Smatphone Iphone");
Iphone p = new Iphone("456", "I14x", "$#%", 512);
p.Ligar();
p.ReceberLigacao();
p.InstalarAplicativo("Icloud");

