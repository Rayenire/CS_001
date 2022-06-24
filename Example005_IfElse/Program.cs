Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "алёна")
{
    Console.WriteLine("Ура, это же АЛЁНА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}