int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(data);
    Console.ResetColor();
}

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int getAtoDegreeB (int numberA, int numberB)
{
    int degree = 1;
    if (numberB >= 2)
    {
        for (int i = 1; i <= numberB; i++)
    {
        degree = degree * numberA;
    }
    }
    if (numberB == 0) 
    {
        degree = 1;
    }
    if (numberB == 1) 
    {
        degree = numberA;
    }
    return degree;
}

int A = getUserData("Введите число A");
int B = getUserData("Введите число B");
int degree = getAtoDegreeB(A, B);
showData($"A в степени B = ",degree);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
int sumOfDigitsInNumber (int number)
{
    int numberLength = Convert.ToString(number).Length;
    int sum = 0;
    for (int i = 0; i <= numberLength; i++)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}
int C = getUserData("Введите число");
int SumOfDigitsInC = sumOfDigitsInNumber(C);
showData($"Сумма всех цифр в числе = ",SumOfDigitsInC);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arrayDisplay (int lenArray)
{
int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
}
return randomArray;
}

void beautifullDisplayArray(int[] array)
{
  int count = array.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(array[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

int D = getUserData("Введите длину массива");
int[] arrayDisplayD = arrayDisplay(D);
beautifullDisplayArray(arrayDisplayD);
