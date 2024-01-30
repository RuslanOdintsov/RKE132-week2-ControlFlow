Console.WriteLine("Hello, Master");
//Rakendus küsib kasutajal valida enda sugu m/f
//Rakendus küsib kasutajal sisestada enda perekonnanime
//Lähtudes valikutest, rakendus tervitab kasutajat järgmiselt:
//Welcome, Mr.(kasutaja perekonnanimi)/Welcome, Ms.(kasutaja perekonnanimi)

Console.WriteLine("Please enter your gender here (m/f):");
char userGender = Char.Parse(Console.ReadLine()); //loeb andmeid maha string formaadis
Console.WriteLine("Please enter your lastname here:");
string userLastname = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastname}");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastname}");
}
else
{
    Console.WriteLine($"Welcome, unknown gender {userLastname}");
}
//else
//{
//Console.WriteLine("Welcome")
//}