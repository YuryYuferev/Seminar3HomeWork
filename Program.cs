/*
// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет      12821 -> да    23432 -> да

void CheckPalindromicNumber(int number)
{
    if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;
            if(division1 == remainder1)
            {
                int number1 = number;
                number1 = number1 / 10;
                int division2 = (number1 / 100) % 10;
                int remainder2 = number1 % 10;
                if(division2 == remainder2)
                    Console.WriteLine($"{number} Число палиндромное ");
            }
            else 
            Console.WriteLine($"{number} Число не палиндромное "); 
            }
    else
    {
    Console.WriteLine($"ОШИБКА:{number} - не является пятизначным");
    }
}
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);
*/
/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(double X1, double Y1, double Z1, double X2, double Y2, double Z2);
{
    double resPointX = X1 - X2;
    double resPointY = Y1 - Y2;
    double resPointZ = Z1 - Z2;
    double result = Math.Sqrt(resPointX * resPointX + resPointY * resPointY + resPointZ * resPointZ);
    return result;
}
Console.WriteLine("Введите координату x1: ");
double pointX1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x2: ");
double pointX2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
double pointY1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
double pointY2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
double pointZ1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
double pointZ2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Результат: {Distance(pointX1, pointX2, pointY1, pointY2, pointZ1, pointZ2)} ");
*/
/*
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Table(int number);
{
    int index = 1;
    while (index <= number)
    {
        double result = Math.Pow(index,3);
        Console.Write(result+ " ");
        index++;
    }
}
Console.Write("Введите число: ");
int res = Convert.ToInt32(Console.ReadLine());
Table(res);
*/

