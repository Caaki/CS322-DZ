// See https://aka.ms/new-console-template for more information
using CS322_DZ06;


List<String> predmeti = new List<String> { "CS101", "CS202","IT331"};

Osoba student  = new Student("Neko", "Nekic", "1234567890123",9.5,2);
Osoba profesor= new Profesor("Profa", "Profic", "1234567890123",10000000,predmeti);

Console.WriteLine(student.ispisOsobe());
Console.WriteLine("\n\n\n");
Console.WriteLine(profesor.ispisOsobe());

