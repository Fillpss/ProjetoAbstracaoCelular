using DesafioPOO.Models;

Nokia nokia = new Nokia("1234", "Lumia 630", "5678", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Iphone iphone = new Iphone("0223", "Iphone 8", "1423", 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");