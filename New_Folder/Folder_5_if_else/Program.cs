Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "anna")
{
    Console.WriteLine("Uraa, Anna!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}