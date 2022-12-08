// Домашняя работа3.
//Задача1.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palindrom (int number)
{
if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10 && number / 100 % 10 == number & 1000 /100)
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
