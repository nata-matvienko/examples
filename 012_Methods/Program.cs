﻿// вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
// вызов в виде: Method1();


//Вид2
void Method2(String msg) //вывод какого то количества аргументов
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4);
// Method21(msg: "текст", count: 4);
// Method21(count: 4, msg: "текст");



// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
// Console.WriteLine(Year);


// Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result +text;       // правая кнопка->переименовать
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

