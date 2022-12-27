// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("введите трехзначное число: ");
int a1= int.Parse(Console.ReadLine()!);
string str1=Convert.ToString(a1);
Console.WriteLine(str1[1]);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Console.Clear();
Console.Write("Введите число: ");
int a2=int.Parse(Console.ReadLine()!);
string str2=Convert.ToString(a2);
int length=str2.Length;
if (length>2) Console.WriteLine(str2[2]);
else Console.WriteLine("У числа нет третьей цифры");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//Console.Clear();
Console.WriteLine("Введите цифру обозначающую день недели (где 1 - понедельник, 7 - воскресенье): ");
int a=int.Parse(Console.ReadLine()!);
if (a<=7) 
{
if (a==6||a==7) Console.WriteLine("день недели является выходным");
    else 
    {
        Console.WriteLine("день недели является будним");
    };
}
else  Console.WriteLine("дня недели не существует");

