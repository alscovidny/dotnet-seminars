// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

if (numberInt >=1 && numberInt <=5){
    Console.WriteLine("нет");
} else if (numberInt == 6 | numberInt == 7){
    Console.WriteLine("да");
} else {
    Console.WriteLine("нет такого дня недели");
}