/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int GetNumber (string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine (message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода, вы ввели не число. Повторите ввод:");
        }
    }
    return result;
}
int NSum (int M, int N)
{
    int sum =N;
    if (N!=M) sum= sum + NSum (M,N-1);
      
    return sum;
    
}

int M=  GetNumber ("Введите M");
int N=  GetNumber ("Введите N");
if (M>N) 
{
int pocket = M;
M=N;
N= pocket;    
}
Console.WriteLine ();
Console.WriteLine ($"Суммма натуральных чисел между {M} И {N} равна {NSum(M,N)}");
