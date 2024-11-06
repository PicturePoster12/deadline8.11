/*1. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.*/
/*Console.WriteLine($"{Math.E:N1}");
/*2. Вывести на экран числа 50 и 10 одно под другим.*/
/*Console.WriteLine(50);
Console.WriteLine(10);
/*3. Составить программу вывода на экран «столбиком» четырех любых чисел.*/
/*Console.WriteLine(1);
Console.WriteLine(3);
Console.WriteLine(2);
Console.WriteLine(7);
/*4. Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.*/
/*Console.WriteLine(Convert.ToDouble(Console.ReadLine()) + 10);
/*5. Дана сторона квадрата. Найти его периметр.*/
/*Console.WriteLine(Convert.ToInt32(Console.ReadLine()) * 4);
/*6. Дан радиус окружности. Найти длину окружности и площадь круга.*/
/*double rad = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Dlina = {2 * Math.PI * rad:N2}");
Console.WriteLine($"Ploschad = {Math.PI * rad * rad:N2}");
/*7. Найти значение y=cos(x)
/*int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Cos(x));
/*8. Даны основания и высота равнобедренной трапеции. Найти ее периметр.*/
/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a + b + 2 * h);
/*9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.*/
/*10. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"(кавычки не нужны).*/
/*Console.WriteLine("Мир Труд Май");
Console.WriteLine("Мир");
Console.WriteLine("{0, 10}", "Труд");
Console.WriteLine("{0, 15}", "Май");
/*11. Программа просит пользователя ввести 2 числовые переменные. А после она меняет их местами и выводит результат на экран. Но, так как пользователь может
ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести, например, букву или строку, а так же учесть, что число может быть дробным, и для
выделения её дробной части одни используют точку, другие – запятую.*/
/*Console.WriteLine("Введите две переменные");
try
{
    double a = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
    double b = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
    Console.WriteLine(b);
    Console.WriteLine(a);
}
catch(ArgumentException)
{
    Console.WriteLine("Неверный ввод");
}
/*12. Программа для подсчета периметра и площади фигур (треугольник, четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
будет считать – площадь или периметр. Задаётся все необходимые значения, а на основе полученных результатов, программа должна подсчитать,
какими могли бы быть периметры или площади остальных фигур.*/
/*Console.WriteLine("Выберите фигуру: (1) - треуголник, (2) - четырёхугольник, (3) - круг(окружность)");
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
/*13. Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому
числу должно предшествовать сообщение «Вы ввели число».*/
/*double a = Convert.ToDouble(Console.ReadLine());
Console.Write($"Вы ввели число {a}");
/*14. Составить программу вывода на экран следующей информации:
2 кг
13 17*/
/*Console.WriteLine("2 кг");
Console.Write("13 17");
/*15. Составить программу вывода на экран «столбиком» четырех случайных чисел.*/
/*Random random = new Random();
Console.WriteLine(random.Next());
Console.WriteLine(random.Next());
Console.WriteLine(random.Next());
Console.WriteLine(random.Next());
/*16. Найти корни квадратного уравнения(коэффициента задаются пользователем с клавиатуры)*/
/*int a = Convert.ToInt32(Console.ReadLine());
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
/*17. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.*/
/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((a + b) / 2);
Console.WriteLine(Math.Sqrt(a * b));
/*18. Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.*/
/*int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("d = " + Math.Sqrt((x2 - x1) * (x2 - x1)  + (y2 - y1) * (y2 - y1)));
/*19. Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам:
а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
б) b присвоить значение а, с присвоить значение b, а присвоить значение с.*/
/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
/*a)*/
/*int p = b;
b = c;
c = a;
a = p;
/*б)*/
/*int p = b;
b = a;
a = c;
c = p;
/*20. С начала суток прошло n секунд. Определить:
а) сколько полных часов прошло с начала суток;
б) сколько полных минут прошло с начала очередного часа;
в) сколько полных секунд прошло с начала очередной минуты.*/
/*int n = Convert.ToInt32(Console.ReadLine());
int CHACbl = n / 3600;
int MUNYTbl = (n % 3600) / 60;
int CEKYNDbl = (n % 60);
Console.WriteLine("Сначала суток прошло: Часы: " + (CHACbl) + " Минуты: "+ (MUNYTbl) + " Секунды: "+ (CEKYNDbl));
/*21. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?*/
/*Console.WriteLine(543 / 130);
/*22. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.*/
/*string a = Console.ReadLine();
string b = a.Substring(2);
string new_a = b + a.Remove(2);
Console.WriteLine(new_a);
/*23. Дано натуральное число n (n > 999). Найти:
а) число сотен в нем;
б) число тысяч в нем.*/
/*int n = Convert.ToInt32(Console.ReadLine());
int COTHU = n / 100;
int TblCYACHU = n / 1000;
Console.WriteLine("Сотни: " + COTHU + " Тысячи: " + TblCYACHU);
/*24. Дано четырехзначное число. Найти:
а) число, полученное при прочтении его цифр справа налево;
б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
в) число, образуемое при перестановке второй и третьей цифр заданного числа.
Например, из числа 5084 получить 5804;
г) число, образуемое при перестановке двух первых и двух последних цифр
заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.*/
/*using System.Linq;
string a = Console.ReadLine();
string new_astr = new string (a.ToCharArray().Reverse().ToArray());
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
/*25. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x, то получилось
число n. Найти число x. Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом число десятков в n не равно нулю.*/
/*Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
string strn = Convert.ToString(n);
char[] charn = strn.ToCharArray();
string n1 = charn[0].ToString();
strn = strn.Remove(0, 1);
int intn = Convert.ToInt32(int.Parse(strn) * 10 + int.Parse(n1));
Console.WriteLine("x = " + intn);
/*26. Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент времени: «h часов, m минут, s секунд».
Определить угол (в градусах) между положением часовой стрелки в начале суток и в указанный момент времени.*/
/*Console.Write("h = ");
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
/*27. Часовая стрелка образует угол y с лучом, проходящим через центр и через точку, соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2 .
 * Определить значение угла для минутной стрелки, а также количество полных часов и полных минут.*/
/*double y = Convert.ToDouble(Console.ReadLine());
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
/*28. Создать программу, которая будет выводить на экран меньшее по модулю из трёх введённых пользователем вещественных чисел*/
/*int pervoe = Convert.ToInt32(Console.ReadLine());
int vtoroe = Convert.ToInt32(Console.ReadLine());
int tretie = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((Math.Min(Math.Min(Math.Abs(pervoe), Math.Abs(vtoroe)), Math.Abs(tretie))));
/*29. Найти сумму большего и меньшего из трёх заданных чисел*/
/*int pervoe = Convert.ToInt32(Console.ReadLine());
int vtoroe = Convert.ToInt32(Console.ReadLine());
int tretie = Convert.ToInt32(Console.ReadLine());
int[] pvt = [pervoe, vtoroe, tretie];
int ma = Math.Max(Math.Max(vtoroe, tretie), pervoe);
int mi = Math.Min(Math.Min(vtoroe, tretie), pervoe);
Console.WriteLine(ma + mi);
/*30. Подсчитать общее количество делителей натурального числа*/
/*int chislo = Convert.ToInt32(Console.ReadLine());
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
/*31. Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
уравнений вида A*X3 + B*X2 + C*X + D = 0. На факультативе по математике Васе задали решить около ста уравнений как раз такого вида. Но, к сожалению, Вася
забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что все корни уравнений – целые числа и находятся на отрезке [-100, 100]. Поэтому у Васи
есть шанс найти их методом перебора, но для этого ему придется затратить уйму времени, т.к. возможно необходимо будет осуществить перебор нескольких тысяч
значений. Помогите Васе написать программу, которая поможет ему найти корни кубических уравнений!*/
/*int a = Convert.ToInt32(Console.ReadLine());
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
/*32. Заданы первый и второй элементы арифметической прогрессии. Требуется написать программу, которая вычислит элемент прогрессии по ее номеру.*/
/*int a1 = Convert.ToInt32(Console.ReadLine());
int a2 = Convert.ToInt32(Console.ReadLine());
int n  = Convert.ToInt32(Console.ReadLine());
int an = a1 + (n - 1) * (a2 - a1);
Console.WriteLine(an);
/*33. Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если трудоустроен не получаю кредит. 
Ну а если я, и пенсионер и студент,(трудоустройство тут не имеет значения) то не должен получить.
Необходимо вводить строки, содержащие информацию о том, студент, пенсионер или кто-то ещё. Вывести информацию: дадут кредит или нет.*/



/*34. Составить программу, которая:
а) запрашивает имя человека и повторяет его на экране;
б) запрашивает имя человека и повторяет его на экране с приветствием.*/
/*Console.WriteLine("Введите ваше имя: ");
string imya = Console.ReadLine();
Console.WriteLine(imya);
Console.WriteLine($"{imya}, здравствуйте");
/*35. Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь здоровается с консолью. Консоль спрашивает, как зовут пользователя.
Пользователь называет имя. Консоль пишет: привет, <имя пользователя>. После этого пользователь спрашивает, знает ли консоль что-то о тайной комнате.
Консоль отвечает «Да». После этого пользователь спрашивает, может ли рассказать. Консоль отвечает «Нет».
Спустя 5 секунд консоль дополняет «но могу показать». Консоль меняет цвет на любой случайный цвет.*/



/*36. Вычислить контрольную цифру штрихкода(EAN13). a. 12 цифр определяются случайным образом. b. 12 цифр вводит пользователь*/
/*Random rnd = new Random();
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
b*/
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