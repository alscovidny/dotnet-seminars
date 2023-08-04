// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1 ");
string strNum_1 = Console.ReadLine();

Console.WriteLine("Введите число 2 ");
string strNum_2 = Console.ReadLine();

Console.WriteLine("Введите число 3 ");
string strNum_3 = Console.ReadLine();

int a = int.Parse(strNum_1);
int b = int.Parse(strNum_2);
int c = int.Parse(strNum_3);

if (a >= b && a >= c){
    Console.WriteLine($"max = {a}");
}
else if (b >= a && b >= c){
    Console.WriteLine($"max = {b}");
}
else if (c >=a && c >= b){
    Console.WriteLine($"max = {c}");
}