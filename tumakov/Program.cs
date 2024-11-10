using System;
class Program
{
    static void Main()
    {
        //Написать программу, которая спрашивает имя пользователя, и затем приветствует пользователя по имени.
        Console.WriteLine("Введите ваше имя: ");
        Console.WriteLine($"Здравствуйте, {Console.ReadLine()}!");
        /*Написать программу, которой на вход подается два целых числа, на выходе – результат деления одного числа на другое.
        Предусмотреть обработку исключительной ситуации, возникающей при делении числа на ноль.*/
        Console.WriteLine("Введите 2 целых числа:");
        try
        {
            int chislo1 = Convert.ToInt32(Console.ReadLine());
            int chislo2 = Convert.ToInt32(Console.ReadLine());
            if (chislo2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            else
            {
                Console.WriteLine(chislo1 / (double)chislo2);
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.*/
        Console.WriteLine("Введите букву:");
        char bukva1 = Convert.ToChar(Console.ReadLine());
        char bukva2 = (char)(bukva1 + 1);
        if ('a' > bukva1 | 'a' > bukva2)
        {
            Console.WriteLine("Неверный ввод");
        }
        else
        {
            if (bukva2 > 'z')
            {
                Console.WriteLine('a');
            }
            else if (bukva2 > 'я')
            {
                Console.WriteLine('а');
            }
            else
            {
                Console.Write(bukva2);
            }
        }
        /*Написать программу, которая решает квадратное уравнение. Входные данные – коэффициенты уравнения, выходные – найденные корни.*/
        Console.WriteLine("Введите коэфициенты уравнения:");
        try
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int discr = b * b - 4 * a * c;
            if (discr > 0)
            {
                double x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discr)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (discr == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("x = " + x);
            }
            else if (discr < 0)
            {
                Console.WriteLine("Нет корней");
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}