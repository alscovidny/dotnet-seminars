// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число 1: ");
string strNum_1 = Console.ReadLine();
int num_1 = int.Parse(strNum_1);

Console.WriteLine("Введите число 2: ");
string strNum_2 = Console.ReadLine();
int num_2 = int.Parse(strNum_2);

if (num_1 > num_2){
    Console.WriteLine($"max = {num_1}");
}
else{
    Console.WriteLine($"max = {num_2}");
}