using DesafioPOO.Models;

Iphone iphone1 = new Iphone("123","10","IMEI1234",64,false,100);

Nokia nokia1 = new Nokia("1234","5100","IMEI2345",5,false,99);

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Whatsapp");
iphone1.Desligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Instagram");

Console.WriteLine("-------------------------------------------");
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Whatsapp");
nokia1.Desligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Instagram");
