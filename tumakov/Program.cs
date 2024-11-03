//Написать программу, которая спрашивает имя пользователя, и затем приветствует пользователя по имени. (Создать консольное приложение.)
Console.WriteLine("Vvedite vashe imya: ");
Console.WriteLine($"Zdravstvuite, {Console.ReadLine()}!");


/*Написать программу, которой на вход подается два целых числа, на выходе – результат деления одного числа на другое.
 * Предусмотреть обработку исключительной ситуации, возникающей при делении числа на ноль.*/
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
try
{
    Console.WriteLine(a / b);
}
catch(DivideByZeroException)
{
    Console.WriteLine("Na nol delit nelzya!!!");
}


/*Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.*/
using System;
class Program
{
    static void Main()
    {

        char a = Convert.ToChar(Console.ReadLine());
        char b = (char)(a + 1);
        if (b > 'z')
        {
            Console.WriteLine('a');
        }
        else if (b > 'я')
        {
            Console.WriteLine('а');
        }
        else
        {
            Console.Write(b);
        }
    }
}
/*Написать программу, которая решает квадратное уравнение. Входные данные – коэффициенты уравнения, выходные – найденные корни.*/
int a =  Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c  = Convert.ToInt32(Console.ReadLine());
int d = b * b - 4 * a * c;
if (d > 0)
{
    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine(x1);
    Console.WriteLine(x2);
}
else if (d == 0)
{
    double x = (-b) / (2 * a);
    Console.WriteLine(x);
}
else if (d < 0)
{
    Console.WriteLine("Net kornei");
}
