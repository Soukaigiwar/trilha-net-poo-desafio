using DesafioPOO.Models;

Console.Clear();

Iphone iphone1 = new Iphone("11-99999-7777", "17", "333333333333333333", 512);

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Safari");

Console.WriteLine();

Nokia nokia1 = new Nokia("11-99999-7777", "3200","222222222222222222", 4);
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Jogo da Cobrinha");
