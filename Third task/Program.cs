//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число: ");
int a;
a = Convert.ToInt32(Console.ReadLine());
int even = a / 2;

if(even % 2 == 0){
    Console.Write("Число {0} является четным:", a);
} else {
    Console.Write("Число {0} не является четным:", a);
}



