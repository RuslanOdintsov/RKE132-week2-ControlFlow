//Rakendus küsib kasutajal sisestada enda vanus
//Kui kasutaja vanus on väiksem kui 18, siis konsoolis kuvatakse:
//"You are too young to use tor browser"
//Muul juhul
//Konsoolis kuvatakse "welcome to tor browser"
//int-number

Console.WriteLine("You are entering Tor Browser. To use this browser you have to be at least 18 years old. Please enter your age:");
string userAge = Console.ReadLine();
int userAgeNum = 0;

//int userAge = Int32.Parse(Console.ReadLine());  //"13"-heap 13-stack
//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if (userAgeNum >= 18)
    {
        Console.WriteLine("Welcome to Tor Browser");
    }
    else
    {
        Console.WriteLine("You don't have permission to use Tor Browser, because you are too young >:D");
    }
}
else
{
    Console.WriteLine("Couldn't read your age");
}