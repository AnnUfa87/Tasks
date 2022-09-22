//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

byte num_1, num_2, num_3;
Console.WriteLine("Введите первое число: ");
num_1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
num_2 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
num_3 = Convert.ToByte(Console.ReadLine());

if(num_1 > num_2 && num_1 > num_3) {
    Console.WriteLine("Максимальное из трех чисел равно:" + num_1);
} 
else if(num_2 > num_1 && num_2 > num_3) {
   Console.WriteLine("Максимальное из трех чисел равно:" + num_1);
}
else if(num_3 > num_1 && num_3 > num_2) {
    Console.WriteLine("Максимальное из трех чисел равно:" + num_3);
}






