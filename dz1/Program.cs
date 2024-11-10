using System;
class Program
{
    static void Main()
    {
        /*1.*/
        Console.WriteLine("1.");
        Console.WriteLine($"e = {Math.E:N1}");
        /*2.*/
        Console.WriteLine("2.");
        Console.WriteLine(50);
        Console.WriteLine(10);
        /*3.*/
        Console.WriteLine("3.");
        Console.WriteLine(1);
        Console.WriteLine(3);
        Console.WriteLine(2);
        Console.WriteLine(7);
        /*4.*/
        Console.WriteLine("4.");
        Console.WriteLine("Введите число:");
        try
        {
            Console.WriteLine(Convert.ToDouble(Console.ReadLine()) + 10);
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*5.*/
        Console.WriteLine("5.");
        Console.WriteLine("Введите сторону квадрата:");
        try
        {
            Console.WriteLine(Convert.ToDouble(Console.ReadLine()) * 4);
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*6.*/
        Console.WriteLine("6.");
        Console.WriteLine("Введите радиус:");
        try
        {
            double rad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Длина = {2 * Math.PI * rad:N2}");
            Console.WriteLine($"Площадь = {Math.PI * rad * rad:N2}");
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*7.*/
        Console.WriteLine("7.");
        Console.WriteLine("Введите угол:");
        try
        {
            int ugol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Cos(ugol));
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*8.*/
        Console.WriteLine("8.");
        Console.WriteLine("Введите основания и высоту:");
        try
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Периметр = " + (a + b + 2 * h));
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*9.*/
        Console.WriteLine("9.");
        try
        {
            Console.WriteLine("Стоимость конфет:");
            double sweet_cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Стоимость печенья:");
            double cookie_cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Стоимость яблок:");
            double apple_cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Кол-во кг конфет:");
            double sweet_weith = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Кол-во кг печнья:");
            double cookie_weith = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Кол-во кг яблок:");
            double apple_weith = Convert.ToDouble(Console.ReadLine());
            double total_cost = sweet_cost * sweet_weith + cookie_cost * cookie_weith + apple_cost * apple_weith;
            Console.WriteLine("Стоимость всей покупки:" + total_cost);
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*10.*/
        Console.WriteLine("10.");
        Console.WriteLine("Мир Труд Май");
        Console.WriteLine("Мир");
        Console.WriteLine("{0, 10}", "Труд");
        Console.WriteLine("{0, 15}", "Май");
        /*11.*/
        Console.WriteLine("11.");
        Console.WriteLine("Введите две переменные:");
        try
        {
            double first_perem = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            double second_perem = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            double promezhut_perem = first_perem;
            first_perem = second_perem; second_perem = promezhut_perem;
            Console.WriteLine(first_perem);
            Console.WriteLine(second_perem);
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*12.*/
        Console.WriteLine("12.");
        Console.WriteLine("Выберите фигуру: (1) - треуголник, (2) - четырёхугольник, (3) - круг(окружность)");
        try
        {
            int ch1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь(1) или Периметр(2)?");
            int ch2 = Convert.ToInt32(Console.ReadLine());
            if (ch1 == 1)
            {
                if (ch2 == 1)
                {
                    Console.WriteLine("Введите сторону:");
                    int storona_treug = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите высоту:");
                    int vysota_treug = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Площадь = " + (storona_treug * vysota_treug) / 2.0);
                }
                else if (ch2 == 2)
                {
                    Console.WriteLine("Введите 3 стороны:");
                    int storona_treug1 = Convert.ToInt32(Console.ReadLine());
                    int storona_treug2 = Convert.ToInt32(Console.ReadLine());
                    int storona_treug3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Периметр = " + (storona_treug1 + storona_treug2 + storona_treug3));
                }
            }
            else if (ch1 == 2)
            {
                if (ch2 == 1)
                {
                    Console.WriteLine("Введите 2 диагонали:");
                    int diagonal1 = Convert.ToInt32(Console.ReadLine());
                    int diagonal2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите угол между ними:");
                    int alpha = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Плошадь = " + (diagonal1 * diagonal2 * Math.Sin(alpha)));
                }
                else if (ch2 == 2)
                {
                    Console.WriteLine("Введите 4 стороны:");
                    int storona1 = Convert.ToInt32(Console.ReadLine());
                    int storona2 = Convert.ToInt32(Console.ReadLine());
                    int storona3 = Convert.ToInt32(Console.ReadLine());
                    int storona4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Периметр = " + (storona1 + storona2 + storona3 + storona4));
                }
            }
            else if (ch1 == 3)
            {
                Console.WriteLine("Введите радиус:");
                int radius = Convert.ToInt32(Console.ReadLine());
                if (ch2 == 1)
                {
                    Console.WriteLine("Площадь = " + (Math.PI * radius));
                }
                else if (ch2 == 2)
                {
                    Console.WriteLine("Периметр = " + (2 * Math.PI * radius));
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*13.*/
        Console.WriteLine("13.");
        Console.WriteLine("Введите число:");
        try
        {
            double chislo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {chislo}");
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*14.*/
        Console.WriteLine("14.");
        Console.WriteLine("2 кг");
        Console.WriteLine("13 17");
        /*15.*/
        Console.WriteLine("15.");
        Random random = new Random();
        Console.WriteLine(random.Next());
        Console.WriteLine(random.Next());
        Console.WriteLine(random.Next());
        Console.WriteLine(random.Next());
        /*16.*/
        Console.WriteLine("16.");
        Console.WriteLine("Введите коэфициенты квадратного уравнения:");
        try
        {
            int koef1 = Convert.ToInt32(Console.ReadLine());
            int koef2 = Convert.ToInt32(Console.ReadLine());
            int koef3 = Convert.ToInt32(Console.ReadLine());
            int discriminant = koef2 * koef2 - 4 * koef1 * koef3;
            if (discriminant > 0)
            {
                double x1 = (-koef2 + Math.Sqrt(discriminant)) / (2 * koef1);
                double x2 = (-koef2 - Math.Sqrt(discriminant)) / (2 * koef1);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (discriminant == 0)
            {
                double x1 = (-koef2) / (2 * koef1);
                Console.WriteLine("x = " + x1);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("Нет корней");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*17.*/
        Console.WriteLine("17.");
        Console.WriteLine("Введите 2 целых числа:");
        try
        {
            int chislo1 = Convert.ToInt32(Console.ReadLine());
            int chislo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое = " + (chislo1 + chislo2) / 2.0);
            Console.WriteLine("Среднее геометрическое = " + Math.Sqrt(chislo1 * chislo2));
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*18.*/
        Console.WriteLine("18.");
        Console.WriteLine("Введите координаты 2 точек:");
        try
        {
            int kordx1 = Convert.ToInt32(Console.ReadLine());
            int kordy1 = Convert.ToInt32(Console.ReadLine());
            int kordx2 = Convert.ToInt32(Console.ReadLine());
            int kordy2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d = " + Math.Sqrt((kordx2 - kordx1) * (kordx2 - kordx1) + (kordy2 - kordy1) * (kordy2 - kordy1)));
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*19.*/
        Console.WriteLine("19.");
        Console.WriteLine("Введиту 3 переменные:");
        try
        {
            int _a = Convert.ToInt32(Console.ReadLine());
            int _b = Convert.ToInt32(Console.ReadLine());
            int _c = Convert.ToInt32(Console.ReadLine());

            /*a)*/
            Console.WriteLine("а)");
            int _p = _b;
            _b = _c;
            _c = _a;
            _a = _p;
            /*б)*/
            Console.WriteLine("Введиту 3 переменные:");
            int a_ = Convert.ToInt32(Console.ReadLine());
            int b_ = Convert.ToInt32(Console.ReadLine());
            int c_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("б)");
            _p = b_;
            b_ = a_;
            a_ = c_;
            c_ = b_;
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*20.*/
        Console.WriteLine("20.");
        Console.WriteLine("Введите количество секунд:");
        try
        {
            int sec_s_nach_sut = Convert.ToInt32(Console.ReadLine());
            int CHACbl = sec_s_nach_sut / 3600;
            int MUNYTbl = (sec_s_nach_sut % 3600) / 60;
            int CEKYNDbl = (sec_s_nach_sut % 60);
            Console.WriteLine("Сначала суток прошло: Часы: " + (CHACbl) + " Минуты: " + (MUNYTbl) + " Секунды: " + (CEKYNDbl));
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*21.*/
        Console.WriteLine("21.");
        Console.WriteLine(543 / 130);
        /*22.*/
        Console.WriteLine("22.");
        Console.WriteLine("Введите трёхзначное число:");
        try
        {
            string old_chislo = Console.ReadLine();
            if (old_chislo.Length == 3)
            {
                string last_right = old_chislo.Substring(2);
                string new_chslo = last_right + old_chislo.Remove(2);
                Console.WriteLine("Полученное число = " + new_chslo);
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*23.*/
        Console.WriteLine("23.");
        Console.WriteLine("Введите натуральное число:");
        try
        {
            int natural_ch = Convert.ToInt32(Console.ReadLine());
            if (natural_ch > 0)
            {
                int COTHU = natural_ch / 100;
                int TblCYACHU = natural_ch / 1000;
                Console.WriteLine("Сотни: " + COTHU + " Тысячи: " + TblCYACHU);
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*24.*/
        Console.WriteLine("24.");
        Console.WriteLine("Введите четырёхзначное число:");
        try
        {
            string chislo4 = Console.ReadLine();
            if (chislo4.Length == 4)
            {
                string new_chislo4str = new string(chislo4.Reverse().ToArray());
                int new_chislo4int = int.Parse(new_chislo4str);
                Console.WriteLine(new_chislo4int);
                Console.WriteLine("б)");
                char[] spisok = chislo4.ToCharArray();
                char first_cifra = spisok[0];
                spisok[0] = spisok[1];
                spisok[1] = first_cifra;
                first_cifra = spisok[2];
                spisok[2] = spisok[3];
                spisok[3] = first_cifra;
                string newstr_chislo4 = new string(spisok);
                int newint_chislo4 = int.Parse(newstr_chislo4);
                Console.WriteLine(newint_chislo4);
                Console.WriteLine("в)");
                char[] spisok2 = chislo4.ToCharArray();
                char y = spisok2[1];
                spisok2[1] = spisok2[2];
                spisok2[2] = y;
                string punkt_B = new string(spisok2);
                int pB = int.Parse(punkt_B);
                Console.WriteLine(pB);
                Console.WriteLine("г)");
                char[] spisok3 = chislo4.ToCharArray();
                char z = spisok3[0];
                spisok3[0] = spisok3[2];
                spisok3[2] = z;
                z = spisok3[1];
                spisok3[1] = spisok3[3];
                spisok3[3] = z;
                string punkt_G = new string(spisok3);
                int pG = int.Parse(punkt_G);
                Console.WriteLine(pG);
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*25.*/
        Console.WriteLine("25.");
        Console.Write("Введите n = ");
        try
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 100 & n <= 999)
            {
                string strn = Convert.ToString(n);
                char[] charn = strn.ToCharArray();
                string n1 = charn[0].ToString();
                strn = strn.Remove(0, 1);
                int intn = Convert.ToInt32(int.Parse(strn) * 10 + int.Parse(n1));
                Console.WriteLine("x = " + intn);
            }
            else
            {
                Console.WriteLine("Невреный ввод");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*26.*/
        Console.WriteLine("26.");
        Console.WriteLine("Введите количество часов, минут, секунд:");
        try
        {
            Console.Write("h = ");
            int chas = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("s = ");
            int sec = int.Parse(Console.ReadLine());
            if (chas >= 0 & chas <= 23 & min >= 0 & min <= 59 & sec >= 0 & sec <= 59)
            {
                int[] ch = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];
                if (chas < 12)
                {
                    double _ugol = chas * 30 + min * 0.5;
                    Console.WriteLine(_ugol);
                }
                else
                {
                    double _ugol = ch[chas] * 30 + min * 0.5;
                    Console.WriteLine(_ugol);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*27.*/
        Console.WriteLine("27.");
        Console.WriteLine("Введите угол в радианах:");
        try
        {
            double ugol_y = Convert.ToDouble(Console.ReadLine());
            if (ugol_y >= 0 & ugol_y <= 2)
            {
                int radian = Convert.ToInt32(ugol_y * 180);
                int chasy = radian / 30;
                if (radian >= 30)
                {
                    while (radian >= 30)
                    {
                        radian -= 30;
                    }
                }
                int strelka = radian * 12;
                int minuta = strelka / 6;
                Console.WriteLine($"Угол минутной стрелки: {strelka}, кол-во часов: {chasy}, минут: {minuta}");
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*28.*/
        Console.WriteLine("28.");
        Console.WriteLine("Введите 3 числа:");
        try
        {
            double pervoe = Convert.ToDouble(Console.ReadLine());
            double vtoroe = Convert.ToDouble(Console.ReadLine());
            double tretie = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((Math.Min(Math.Min(Math.Abs(pervoe), Math.Abs(vtoroe)), Math.Abs(tretie))));
        }
        catch(FormatException)
{
            Console.WriteLine("Неверный ввод");
        }
        /*29.*/
        Console.WriteLine("29.");
        Console.WriteLine("Введите 3 числа:");
        try
        {
            int _pervoe = Convert.ToInt32(Console.ReadLine());
            int _vtoroe = Convert.ToInt32(Console.ReadLine());
            int _tretie = Convert.ToInt32(Console.ReadLine());
            int[] pvt = [_pervoe, _vtoroe, _tretie];
            int ma = Math.Max(Math.Max(_vtoroe, _tretie), _pervoe);
            int mi = Math.Min(Math.Min(_vtoroe, _tretie), _pervoe);
            Console.WriteLine(ma + mi);
        }
        catch
        {
            Console.WriteLine("Неверный ввод");
        }
        /*30.*/
        Console.WriteLine("30.");
        Console.WriteLine("Введите натуральное число:");
        try
        {
            int nat_chislo = Convert.ToInt32(Console.ReadLine());
            if (nat_chislo > 0)
            {
                int k = 1;
                if (nat_chislo == 1 | nat_chislo == 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    for (int i = 1; i < nat_chislo; ++i)
                    {
                        if (nat_chislo % i == 0)
                        {
                            k += 1;
                        }
                    }
                    Console.WriteLine(k);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*31.*/
        Console.WriteLine("31.");
        Console.WriteLine("Введите 4 числа:");
        try
        {
            int perv = Convert.ToInt32(Console.ReadLine());
            int vtor = Convert.ToInt32(Console.ReadLine());
            int tret = Convert.ToInt32(Console.ReadLine());
            int chetv = Convert.ToInt32(Console.ReadLine());
            for (int w = -100; w <= 100; ++w)
            {
                if (perv * w * w * w + vtor * w * w + tret * w + chetv == 0)
                {
                    Console.WriteLine("x = " + w);
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*32.*/
        Console.WriteLine("32.");
        Console.WriteLine("Введите 1 и 2 элемменты арифмитической прогрессии:");
        try
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер элемента:");
            int nomer = Convert.ToInt32(Console.ReadLine());
            int otv = a1 + (nomer - 1) * (a2 - a1);
            Console.WriteLine(otv);
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*33.*/
        Console.WriteLine("33.");
        Console.WriteLine("Пенсионер(1) или студент(2)");
        try
        {
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
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*34.*/
        Console.WriteLine("34.");
        Console.WriteLine("Введите ваше имя: ");
        string imya = Console.ReadLine();
        Console.WriteLine(imya);
        Console.WriteLine("б)");
        Console.WriteLine($"{imya}, здравствуйте");
        /*35.*/
        Console.WriteLine("35.");
        try
        {
            string priv = Console.ReadLine();
            if (priv.ToLower() == "привет")
            {
                Console.WriteLine("Назови своё имя");
                string _imya = Console.ReadLine();
                Console.WriteLine("привет, " + _imya);
                string[] vopros1 = Console.ReadLine().ToLower().Split(" ");
                if (vopros1.Contains("знаешь") & vopros1.Contains("комнате"))
                {
                    Console.WriteLine("Да");
                    string[] vopros2 = Console.ReadLine().ToLower().Split(" ");
                    if (vopros2.Contains("рассказать"))
                    {
                        Console.Write("Нет");
                        Task.Delay(5000).Wait();
                        Random color = new Random();
                        Console.ForegroundColor = (ConsoleColor)color.Next(0, 10);
                        Console.WriteLine(" но могу показать");

                    }
                }
            }
            Console.ResetColor();
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        /*36.*/
        Console.WriteLine("36.");
        Random rnd = new Random();
        int[] shtr = [rnd.Next(0, 9), rnd.Next(0, 9), rnd.Next(0, 9), rnd.Next(0, 9), rnd.Next(0, 9), rnd.Next(0, 9), rnd.Next(0, 9), rnd.Next(0, 9), rnd.Next(0, 9), rnd.Next(0, 9), rnd.Next(0, 9), rnd.Next(0, 9)];
        int ean = shtr[0] + shtr[2] + shtr[4] + shtr[6] + shtr[8] + shtr[10] + (shtr[1] + shtr[3] + shtr[5] + shtr[7] + shtr[9] + shtr[11]) * 3;
        int _ean = (ean / 10 + 1) * 10;
        int ean13 = _ean - ean;
        if (ean13 == 10)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(ean13);
        }
        /*b)*/
        try
        {
            char[] ean_b = Console.ReadLine().ToCharArray();
            if (ean_b.Length != 12)
            {
                int chet = 0; int nechet = 0;
                for (int i = 0; i < ean_b.Length; ++i)
                {
                    if (i % 2 == 0)
                    {
                        nechet += (int)(ean_b[i] - '0');
                    }
                    else
                    {
                        chet += (int)(ean_b[i] - '0') * 3;
                    }
                }
                int _ean13 = ((chet + nechet) / 10 + 1) * 10;
                int ean13_b = _ean13 - (chet + nechet);
                Console.WriteLine(ean13_b);
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}