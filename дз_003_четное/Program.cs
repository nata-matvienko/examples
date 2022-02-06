// является ли число четным

int number = new Random().Next(1,1000);
Console.WriteLine(number);
int ostatok = number / 2;
if(ostatok == 0)
Console.WriteLine("четное");
else
Console.WriteLine("нечетное");
