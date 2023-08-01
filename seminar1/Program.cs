// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число 1 ");
string strNum_1 = Console.ReadLine();

Console.WriteLine("Введите число 2 ");
string strNum_2 = Console.ReadLine();

int num1 = int.Parse(strNum_1);
int num2 = int.Parse(strNum_2);

if (num1 == num2 * num2){
    Console.WriteLine($"правильно {num1} = {num2} * {num2}");
}
else{
    Console.WriteLine("не квадрат одно другому");
}
// int square = num * num;
// Console.WriteLine($"square {square}");