// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать массив
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
string number = Console.ReadLine();

if (number.Length <3){
    Console.WriteLine("третьей цифры нет");
}
else{
number = number.Substring(2,1);
Console.WriteLine($"{number}");
}
// } else{
//     int numberInt = int.Parse(number);
//     int numberLen = number.Length;
//     double numberDouble = Convert.ToDouble(numberLen);
//     int dividerInt1 = Convert.ToInt32(Math.Pow(Convert.ToDouble(10),numberDouble-2));
//     int dividerInt2 = Convert.ToInt32(Math.Pow(Convert.ToDouble(10),numberDouble-3));
//     Console.WriteLine($"number {(numberInt % dividerInt1) / dividerInt2}");
// }