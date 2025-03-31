// See https://aka.ms/new-console-template for more information

using proj_1;

Kontener kon = new Kontener(50,20,50,200);
Kontener kon2 = new Kontener(50,20,50,200);
KontenerNaGaz asd = new KontenerNaGaz(20,20,20,20);
Kontenerowiec test =new Kontenerowiec("Pawełek", 100,20,40.4);
KontenerChlodniczy kon3 = new KontenerChlodniczy( 20, 20, 20, 100,"banany");


test.addKontener(kon3);
test.addKontener(kon);
test.addKontener(kon2);
test.addKontener(asd);

kon.printSerialNumber();
kon2.printSerialNumber();
kon3.printSerialNumber();


test.printInfo();