// Домашняя работа3.
//Задача1.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrom (int number)
{
if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10 && number / 100 % 10 == number % 1000 /100)
    return true;

    else

    return false;

}
Console.WriteLine("Введите питизначное число: ");
int num =Convert.ToInt32(Console.ReadLine());
if (num  < 0)
    num = Math.Abs(num);
bool result = Palindrom (num); 
Console.WriteLine(result);
*/
// Задача 2.Напишите программу.которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double xa, double xb, double ya,double yb, double za, double zb)

{
    double kv1 = Math.Pow((xb - xa),2);
    double kv2 = Math.Pow((yb - ya),2);
    double kv3 = Math.Pow((zb - za),2);
    double sqrt = Math.Sqrt(kv1 + kv2 + kv3);
    return sqrt;
}
Console.WriteLine("Введите первую А координату: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую А координату: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третью А координату: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первую B координату: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую B координату: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третью B координату: ");
double zb = Convert.ToDouble(Console.ReadLine());

double result = Distance(xa, xb,ya, yb, za, zb);
Console.WriteLine(result);

*/
  //Задача 3.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int number)
{
    int num = 1;
    while (num <= number)
    {
        Console.Write(Math.Pow(num,3));
        if (num == number)Console.Write(".");
        else
            Console.Write(",");
            num++;
    }
}
Console.WriteLine("Введите любое число: ");
int result = Convert.ToInt32(Console.ReadLine());
Cube(result);
  



