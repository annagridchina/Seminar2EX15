// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6, 7 - выходной.
// НО дня с индексом 0 или 12 не существует.
// 6 -> да
// 7 -> да
// 1 -> нет// 


Console.WriteLine("Start");

Console.Write("введите число дня недели: ");

int day =  int.Parse(Console.ReadLine());

if (day > 0 && day < 6)
{
    Console.WriteLine("рабочий день");
}
else if (day > 5 && day < 8)
{
    Console.WriteLine("выходной день");
}
else
{
     Console.WriteLine("такого дня нет");
}
 Console.WriteLine("END");