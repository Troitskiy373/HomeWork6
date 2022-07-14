//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


/*void Numbers(int m)
{
    int counter = 0;
    for(int i = 0; i<m;i++)
    
    {
        
        Console.WriteLine($"Введи число {i+1}: ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        if(numbers>0)counter++;
        
    }
    Console.WriteLine($"Чисел больше нуля :  {counter}");
}

Console.Write("Введи число М(количество чисел): \n");
int m = Convert.ToInt32(Console.ReadLine());
Numbers(m);*/



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


Console.Write("К1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("К2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

int x1 = b2 - b1;
int x2 = k1 - k2;
int x = x1 / x2;
int y1 = k1 * x + b1;
int y2 = k2 * x + b2;

Convert.ToInt32(Console.ReadLine());
Console.Write(x, y1, y2); // Здесь поплыл, не знаю как исправить








