/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
int GetNumber (string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine (message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            if (result >= 0)
            break;
            else 
            Console.WriteLine("Ошибка ввода, вы ввели отрицательное число. Повторите ввод:");
        }
        else
        {
            Console.WriteLine("Ошибка ввода, вы ввели не число. Повторите ввод:");
        }
    }
    return result;
}
double Akkerman (double M, double N)
{
    double A;
    if (M==0)  A =N +1;
    else
    {
      if (N==0) A =  Akkerman (M-1,1);   
      else A = Akkerman (M-1, Akkerman(M,N-1));
    }
    return A;
    
}

double M=  GetNumber ("Введите M");
double N=  GetNumber ("Введите N");

Console.WriteLine ();
Console.WriteLine ($"Функция Аккермана для {M} И {N} равна {Akkerman(M,N)}");


