/*int[] ReverseArray(int [] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}*/

//Задача которая преобразовывает десятичное число в двоичное

/*string ConvertNumber(int num)
{
    string ConNum = string.Empty;
    while(num > 0)
    {
     ConNum = num % 2 + ConNum;
     num = num/2;
    }
    return ConNum;
}
Console.WriteLine(ConvertNumber(36));*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи : 0 и 1.

/*int[] Fibonachi(int N)
{
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < N; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;

}
void ShowArray(int[] array)
{
for(int i=0;i<array.Length;i++)
   Console.Write(array[i] + " ");
Console.WriteLine();
}


ShowArray(Fibonachi(5));*/
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. (каждая сторона меньше двух других)
// A< B+C
/*bool IsTriangle(int n1, int n2, int n3)
{
    return n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2; // 1 способ решения, самый лаконичный

    //if(n1<n2+n3 && n2<n1+n3 && n3<n1+n2) return true;   2 способ
    //else return false;
}

Console.WriteLine("Impet number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Impet number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Impet number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsTriangle(n1, n2, n3));*/
