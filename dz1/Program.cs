/*1.*/
Console.WriteLine($"{Math.E:N1}");
/*2.*/
Console.WriteLine(50);
Console.WriteLine(10);
/*3.*/
Console.WriteLine(1);
Console.WriteLine(3);
Console.WriteLine(2);
Console.WriteLine(7);
/*4.*/
Console.WriteLine(Convert.ToDouble(Console.ReadLine()) + 10);
/*5.*/
Console.WriteLine(Convert.ToInt32(Console.ReadLine()) * 4);
/*6.*/
double rad = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Dlina = {2 * Math.PI * rad:N2}");
Console.WriteLine($"Ploschad = {Math.PI * rad * rad:N2}");
/*7.*/
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Cos(x));
/*8.*/
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a + b + 2 * h);
/*9.*/
Console.WriteLine("Стоимость конфет");
double sweet_cost = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Стоимость печенья");
double cookie_cost = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Стоимость яблок");
double apple_cost = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Кол-во кг конфет");
double sweet_weith = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Кол-во кг печнья");
double cookie_weith = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Кол-во кг яблок");
double apple_weith = Convert.ToDouble(Console.ReadLine());
double total_cost = sweet_cost * sweet_weith + cookie_cost * cookie_weith + apple_cost * apple_weith;
Console.WriteLine(total_cost);
/*10.*/
Console.WriteLine("Мир Труд Май");
Console.WriteLine("Мир");
Console.WriteLine("{0, 10}", "Труд");
Console.WriteLine("{0, 15}", "Май");
/*11.*/
Console.WriteLine("Введите две переменные");
try
{
    double a = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
    double b = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
    double c = a;
    a = b; b = c;
    Console.WriteLine(a);
    Console.WriteLine(b);
}
catch(ArgumentException)
{
    Console.WriteLine("Неверный ввод");
}
/*12.*/
Console.WriteLine("Выберите фигуру: (1) - треуголник, (2) - четырёхугольник, (3) - круг(окружность)");
int ch1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Площадь(1) или Периметр(2)?");
int ch2 = Convert.ToInt32(Console.ReadLine());
if (ch1 == 1)
{
    if (ch2 == 1)
    {
        Console.WriteLine("Введите сторону:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите высоту:");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("S = " + (a * h) / 2);
    }
    else if (ch2 == 2)
    {
        Console.WriteLine("Введите 3 стороны:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("P = " + (a + b + c));
    }
}
else if (ch1 == 2)
{
    if (ch2 == 1)
    {
        Console.WriteLine("Введите 2 диагонали:");
        int d1 = Convert.ToInt32(Console.ReadLine());
        int d2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите угол между ними:");
        int q = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("S = " + (d1 * d2 * Math.Sin(q)));
    }
    else if (ch2 == 2)
    {
        Console.WriteLine("Введите 4 стороны:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("P = " + (a + b + c + d));
    }
}
else if (ch1 == 3)
{
    Console.WriteLine("Введите радиус:");
    int r = Convert.ToInt32(Console.ReadLine());
    if (ch2 == 1)
        {
            Console.WriteLine("S = " + (Math.PI * r));
        }
    else if (ch2 == 2)
        {
            Console.WriteLine("P = " + (2 * Math.PI * r));
        }
}
/*13.*/
double a = Convert.ToDouble(Console.ReadLine());
Console.Write($"Вы ввели число {a}");
/*14.*/
Console.WriteLine("2 кг");
Console.Write("13 17");
/*15.*/
Random random = new Random();
Console.WriteLine(random.Next());
Console.WriteLine(random.Next());
Console.WriteLine(random.Next());
Console.WriteLine(random.Next());
/*16.*/
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
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
/*17.*/
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((a + b) / 2);
Console.WriteLine(Math.Sqrt(a * b));
/*18.*/
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("d = " + Math.Sqrt((x2 - x1) * (x2 - x1)  + (y2 - y1) * (y2 - y1)));
/*19.*/
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
/*a)*/
int p = b;
b = c;
c = a;
a = p;
/*б)*/
int p = b;
b = a;
a = c;
c = p;
/*20.*/
int n = Convert.ToInt32(Console.ReadLine());
int CHACbl = n / 3600;
int MUNYTbl = (n % 3600) / 60;
int CEKYNDbl = (n % 60);
Console.WriteLine("Сначала суток прошло: Часы: " + (CHACbl) + " Минуты: "+ (MUNYTbl) + " Секунды: "+ (CEKYNDbl));
/*21.*/
Console.WriteLine(543 / 130);
/*22.*/
string a = Console.ReadLine();
string b = a.Substring(2);
string new_a = b + a.Remove(2);
Console.WriteLine(new_a);
/*23.*/
int n = Convert.ToInt32(Console.ReadLine());
int COTHU = n / 100;
int TblCYACHU = n / 1000;
Console.WriteLine("Сотни: " + COTHU + " Тысячи: " + TblCYACHU);
/*24.*/
string a = Console.ReadLine();
string new_astr = new string (a.Reverse().ToArray());
int new_aint = int.Parse(new_astr);
Console.WriteLine(new_aint);
char[] sp = a.ToCharArray();
char x = sp[0];
sp[0] = sp[1];
sp[1] = x;
x = sp[2];
sp[2] = sp[3];
sp[3] = x;
string newstr_a = new string(sp);
int newint_a = int.Parse(newstr_a);
Console.WriteLine(newint_a);
char[] sp2 = a.ToCharArray();
char y = sp2[1];
sp2[1] = sp2[2];
sp2[2] = y;
string punkt_B = new string(sp2);
int pB = int.Parse(punkt_B);
Console.WriteLine(pB);
char[] sp3 = a.ToCharArray();
char z = sp3[0];
sp3[0] = sp3[2];
sp3[2] = z;
z = sp3[1];
sp3[1] = sp3[3];
sp3[3] = z;
string punkt_G = new string(sp3);
int pG = int.Parse(punkt_G);
Console.WriteLine(pG);
/*25.*/
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
string strn = Convert.ToString(n);
char[] charn = strn.ToCharArray();
string n1 = charn[0].ToString();
strn = strn.Remove(0, 1);
int intn = Convert.ToInt32(int.Parse(strn) * 10 + int.Parse(n1));
Console.WriteLine("x = " + intn);
/*26.*/
Console.Write("h = ");
int h = int.Parse(Console.ReadLine());
Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("s = ");
int s = int.Parse(Console.ReadLine());
int[] ch = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];
if (h < 12)
{
    double ugol = h * 30 + m * 0.5;
    Console.WriteLine(ugol);
}
else
{
    double ugol = ch[h] * 30 + m * 0.5;
    Console.WriteLine(ugol);
}
/*27.*/
double y = Convert.ToDouble(Console.ReadLine());
int rad = Convert.ToInt32(y * 180);
int chas = rad / 30;
if (rad >= 30)
{
    while (rad >= 30)
    {
        rad -= 30;
    }
}
int strelka = rad * 12;
int minuta = strelka / 6;
Console.WriteLine($"Угол минутной стрелки: {strelka}, кол-во часов: {chas}, минут: {minuta}");
/*28.*/
int pervoe = Convert.ToInt32(Console.ReadLine());
int vtoroe = Convert.ToInt32(Console.ReadLine());
int tretie = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((Math.Min(Math.Min(Math.Abs(pervoe), Math.Abs(vtoroe)), Math.Abs(tretie))));
/*29.*/
int pervoe = Convert.ToInt32(Console.ReadLine());
int vtoroe = Convert.ToInt32(Console.ReadLine());
int tretie = Convert.ToInt32(Console.ReadLine());
int[] pvt = [pervoe, vtoroe, tretie];
int ma = Math.Max(Math.Max(vtoroe, tretie), pervoe);
int mi = Math.Min(Math.Min(vtoroe, tretie), pervoe);
Console.WriteLine(ma + mi);
/*30.*/
int chislo = Convert.ToInt32(Console.ReadLine());
int k = 1;
if (chislo == 1 | chislo == 0)
{
    Console.WriteLine(1);
}
else
{
    for (int i = 1; i < chislo; ++i) 
    {
        if (chislo % i == 0)
        {
            k += 1;
        }
    }
    Console.WriteLine(k);
}
/*31.*/
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
for (int x = -100; x <= 100; ++x)
{
    if (a * x * x * x + b * x * x + c * x + d == 0)
    {
        Console.WriteLine("x = " + x);
    }
}
/*32.*/
int a1 = Convert.ToInt32(Console.ReadLine());
int a2 = Convert.ToInt32(Console.ReadLine());
int n  = Convert.ToInt32(Console.ReadLine());
int an = a1 + (n - 1) * (a2 - a1);
Console.WriteLine(an);
/*33.*/
Console.WriteLine("Пенсионер(1) или студент(2)");
int status = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Трудоустроен(1) или нет(2)");
int trud = Convert.ToInt32(Console.ReadLine());
if (status == 1 | (status == 2 & trud == 2))
{

    Console.WriteLine("Одобрен");
}
else if (status == 2 & trud == 1 | status == 12)
{
    Console.WriteLine("Отказано");
}
/*34.*/
Console.WriteLine("Введите ваше имя: ");
string imya = Console.ReadLine();
Console.WriteLine(imya);
Console.WriteLine($"{imya}, здравствуйте");
/*35.*/
string priv = Console.ReadLine();
Console.WriteLine("Назови своё имя");
string imya = Console.ReadLine();
Console.WriteLine("привет, " + imya);
Console.ReadLine();
Console.WriteLine("Да");
Console.ReadLine();
Console.Write("Нет");
await Task.Delay(5000);
Random color = new Random();
Console.ForegroundColor = (ConsoleColor)color.Next(0, 10);
Console.Write(" но могу показать");
/*36.*/
Random rnd = new Random();
int[] shtr = [rnd.Next(0,9),rnd.Next(0, 9),rnd.Next(0, 9),rnd.Next(0, 9),rnd.Next(0, 9),rnd.Next(0, 9),rnd.Next(0, 9),rnd.Next(0, 9),rnd.Next(0, 9),rnd.Next(0, 9),rnd.Next(0, 9),rnd.Next(0, 9)];
int ean = shtr[0] + shtr[2] + shtr[4] + shtr[6] + shtr[8] + shtr[10] + (shtr[1] + shtr[3] + shtr[5] + shtr[7] + shtr[9] + shtr[11]) * 3;
int a = (ean / 10 + 1) * 10;
int ean13 = a - ean;
if (ean13 == 10)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(ean13);
}
/*b)*/
int a1 = Convert.ToInt32(Console.ReadLine());
int a2 = Convert.ToInt32(Console.ReadLine());
int a3 = Convert.ToInt32(Console.ReadLine());
int a4 = Convert.ToInt32(Console.ReadLine());
int a5 = Convert.ToInt32(Console.ReadLine());
int a6 = Convert.ToInt32(Console.ReadLine());
int a7 = Convert.ToInt32(Console.ReadLine());
int a8 = Convert.ToInt32(Console.ReadLine());
int a9 = Convert.ToInt32(Console.ReadLine());
int a10 = Convert.ToInt32(Console.ReadLine());
int a11 = Convert.ToInt32(Console.ReadLine());
int a12 = Convert.ToInt32(Console.ReadLine());
int ean1 = a1 + a3 + a5 + a7 + a9 + a11;
int ean2 = a2 + a4 + a6 + a8 + a10 + a12;
int ean = ean1 + ean2 * 3;
int a = (ean / 10 + 1) * 10;
int ean13 = a - ean;
if (ean13 == 10)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(ean13);
}