
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
string a;
Console.WriteLine("Введите пятизначное число");
a=Console.ReadLine();
string palindrom(string collection)
{
int length=collection.Length;
int index=0;
if (length != 5) Console.WriteLine("введено не пятизначное число");
if (collection[index]==collection[length-1]&&collection[index+1]==collection[length-2]) Console.WriteLine("число является палиндромом");
else Console.WriteLine("Число не является палиндромом");
return collection;
};
a=palindrom(a);


//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату X первой точки: ");
int x1=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y первой точки: ");
int y1=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z первой точки: ");
int z1=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X второй точки: ");
int x2=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y второй точки: ");
int y2=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z второй точки: ");
int z2=int.Parse(Console.ReadLine()!);
double distance (int x1, int y1, int z1,
int x2, int y2, int z2) 
{
double dist=Math.Pow((Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)),0.5);
Console.WriteLine("Расстояние между двумя точками: "+dist);
return dist;
};
double dist12=distance (x1,y1,z1,x2,y2,z2);

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int N=int.Parse(Console.ReadLine()!);
string CubeMatrix (int Number)
{
    string result="";
    for (int i=1; i <= Number; i++) 
    {
       Console.Write($"{(int)Math.Pow(i,3)}, ");
    }
     return result;
}
CubeMatrix(N);
