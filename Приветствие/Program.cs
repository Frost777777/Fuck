Console.Write("Введите своё имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "лидия")
{
    Console.WriteLine("Я тебя обожаю, моя кроха!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
