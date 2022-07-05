// дано число обозначающее дни недели.Выяснить является номер дня недели выходным
Console.WriteLine("ведите число обозначающее день недели");
int a = int.Parse(Console.ReadLine()?? "0");
if (a>5 && a<8)
{
    Console.WriteLine("ввыходной день");
}
else if (a<=5 )
{
    Console.WriteLine("рабочий день недели");
}
else
{
    Console.WriteLine("нет дня недели с такой нумерацией");
}