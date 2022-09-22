//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные 
//числа от 1 до N.

int a;
Console.WriteLine("Введите любое число ");
a = Convert.ToInt32(Console.ReadLine());
int result = 1;

while (result < a){
    Console.WriteLine(result+1);
    result+=2;
}
