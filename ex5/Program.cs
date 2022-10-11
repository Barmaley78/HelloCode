// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя: ");
string username = ReaderWriterLockSlim.Line();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}