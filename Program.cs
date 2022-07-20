/*
// 1. Напишите программу, которая принимает на вход число (A) и выдает сумму чисел от 1 до A.

int sum(int A)
{
    int result = 0;
    if(A >= 1)
    {
        for(int i = 1; i <= A; i++)
        {
            result = result + i;
        }
        return result;
    }
    else return 0;
}
Console.Write("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum number: " + sum(num));


// 2. Программа, которая принимает на вход число и выдает количество цифр в числе.

int NumCout(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
Console.Write("Imput number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество цифр в числе: " + NumCout(number));


// 3. Прогрмма, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int productNumbers(int num)
{
    int count = 1;
    if(num < 1) return 0;
    else
    {
        for(int i = 1; i <= num; i++)
        {
            count = count * i;
        }
        return count;
    }
}
Console.Write("Imput number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Произведение чисел = " + productNumbers(number));


// 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке/ и не случайном.

int [] CreateRandomArray(int size, int min, int max)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Imput " + "element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
int[] myRandomArray = CreateRandomArray(5, 0, 1);
ShowArray(myRandomArray);

Console.WriteLine();

int[] myArray = CreateArray(5);
ShowArray(myArray);




// Домашнее задание

// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DegreeNumber(int numberA, int numberB)

{
    int result = 1;
    for(int i=1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

 Console.Write("Input number A: ");
 int numberA = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input number B: ");
 int numberB = Convert.ToInt32(Console.ReadLine());

 int degreeNumber = DegreeNumber(numberA, numberB);
 Console.WriteLine("{0}, {1} -> {2}", numberA, numberB, degreeNumber);


// 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sum(int number)
{
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        number = number / 10;
    }
    return result;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum = sum(number);
Console.WriteLine("Sum numbers: " + Sum);
*/

// 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateRandomArray(int size, int min, int max)
{
    Console.Write("[");
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
        Console.Write("]");
}

int[] myRandomArray = CreateRandomArray(8, 0, 9);
ShowArray(myRandomArray);

Console.WriteLine();
