using DesafioPOO.Models;

Nokia nokia = new Nokia("123abc", "nokia1", "1av24ac", 8);
Console.WriteLine("Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("");

Iphone iphone = new Iphone("321cba", "iphone1", "123zvnn12", 8);
Console.WriteLine("Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");