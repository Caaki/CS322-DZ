// See https://aka.ms/new-console-template for more information

/*
1. Napisati program u jeziku C# koji poziva funkciju koja vraća rezultat stepenovanja
parametra.
Funkciji prosleđujemo vrednost promenljive koja treba biti dignuta na određeni stepen, kao i
vrednost stepena(ove vrednosti korisnik unosi preko tastature). Treba proveriti da vrednost
parametra koji treba biti stepenovan (x) bude razilticod nule, a vrednost stepena(n) veća ili
jednaka nuli. U suprotnom prikazati grkeus .
2. Napraviti klasu Posetioc koja ima od podataka Ime, Prezime i broj ulaznice. Zatim napraviti
pomoćnu klasu koja ima metodu koja vraća reč od 8 random slova pri čemu je prvo slovo
veliko
a ostala su mala, i metodu koja vraća slučajni ceo broj u intervalu od 1 do 200. Obratiti paznju
na prava pristupa osobinama/varijablama klase, i kreirati potrebne getere i setere.
U pokretackoj klasi kreirati dve instance klase Posetioc i svaku od njih napuniti random
podacima koristeći pomoćnu klasu. Prikazati rezultat rada. 


 */

using CS322_DZ05;

Console.Write("Uneiste broj koji zelite da stepenujete: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a <= 0){
    Console.Write("Broj mora biti veci od 0: ");
    a = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Uneiste stepen: ");
int b = Convert.ToInt32(Console.ReadLine());

while (b < 0){
    Console.Write("Stepen borja mora biti veci ili jednak 0: ");
    b = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine(UtilClass.square(2, 3));


Posetioc p1= new Posetioc(UtilClass.randomName(),UtilClass.randomName(),UtilClass.randomNumber());
Posetioc p2= new Posetioc(UtilClass.randomName(),UtilClass.randomName(),UtilClass.randomNumber());

Console.WriteLine("Posetion p1: " + p1.Ime + "  " + p1.Prezime + " " + p1.BrojUlazinice);
Console.WriteLine("Posetion p2: " + p2.Ime + "  " + p2.Prezime + " " + p2.BrojUlazinice);

