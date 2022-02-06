// показать большее и меньшее число из 2х

int numberA = 9;
int numberB = 7;
int min = Math.Min(numberA, numberB);
int max = Math.Max(numberA, numberB);
Console.WriteLine(string.Format("min:{0} max:{1}", min, max));