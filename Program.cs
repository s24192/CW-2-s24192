// See https://aka.ms/new-console-template for more information

using proj_1;

Kontener kon = new Kontener(50,20,50,200);
Kontener kon2 = new Kontener(50,20,50,200);
Kontenerowiec test =new Kontenerowiec("Pawełek", 100,20,40.4);
KontenerChlodniczy kon3 = new KontenerChlodniczy( 20, 20, 20, 100,"banany");

kon.printSerialNumber();
kon2.printSerialNumber();
kon3.printSerialNumber();


test.printInfo();
Console.WriteLine(kon.getMasaLadunku());
