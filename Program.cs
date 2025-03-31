// See https://aka.ms/new-console-template for more information

using proj_1;

Kontener kon = new Kontener(50,20,50,20);
Kontener kon2 = new Kontener(50,20,50,20);
Kontener kon3 = new Kontener(50,20,50,20);
Kontener kon4 = new Kontener(50,20,50,20);
Kontener kon5 = new Kontener(50,20,50,20);
Kontener kon6 = new Kontener(50,20,50,20);
KontenerNaGaz asd = new KontenerNaGaz(20,20,20,20);
Kontenerowiec test =new Kontenerowiec("Pawełek", 40,20,50);
KontenerChlodniczy kon12 = new KontenerChlodniczy( 20, 20, 20, 100,"banany");


test.addKontener(kon12);
test.addKontener(kon);
test.addKontener(kon2);
test.addKontener(kon3);
test.addKontener(kon4);
test.addKontener(kon5);
test.addKontener(kon6);


test.printInfo();

test.removeKontener("asd-0");

test.printInfo();