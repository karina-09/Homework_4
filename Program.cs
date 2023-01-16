Console.Clear();

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵)   2, 4 -> 16     

/*System.Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = A;

    for (int i = 2; i <= B; i++)
    {
        result *= A;
    }
    System.Console.WriteLine($"Число {A} возведенное в сепень {B} равно {result}");*/
    


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11     82 -> 10    9012 -> 12

/*Console.WriteLine ("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.Write($"Сумма цифр в числе {number} равна {getSum(number)}");


int getSum(int number)
    {
        while (number != 0) 
        {
            sum = sum + number % 10;
            number = number/10;
        }
        return sum;
    }*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//(числа берете любые)

/*int[] Array = GetArray(8); 
Console.Write($"[{String.Join(";", Array)}]"); 

int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        Array[i] = new Random().Next(0, 101);
    } 
    return Array; 
}*/


