// вывести квадрат числа

//выводим на консоль сообщение
Console.Write("Введите число->");

string numberStr = Console.Readline();

int number = int.Parse(numberStr);

Console.WriteLine($"квадрат числа: {number * number}");