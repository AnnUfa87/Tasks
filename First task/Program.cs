//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;

if(b > a)  max = b;
Console.WriteLine("мы нашли наибольшее из двух чисел: " + max); 

if(a < b) min = a;
Console.WriteLine("мы нашли наименьшее из двух чисел: " + min); 



