// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
string strNum = Console.ReadLine();
int N = int.Parse(strNum);

string numbers = "  ";
// int i = 0;
if (N >= 2){
    numbers = "2";
}

for (int i = 2; i < N-1; i+=2){
    numbers = numbers + $", {i+2}";
}
Console.WriteLine($"{numbers}");
