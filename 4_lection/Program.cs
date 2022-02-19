// Двойные массивы

/*
string[,] table = new string[2,5];
table[1,2] = "слово";
for (int rows=0; rows<2;rows++)
{
    for (int colums = 0; colums<5; colums++)
    {
        Console.WriteLine($"-{table[rows,colums]}-");
    }
}
*/

/*
int[,] image = new int[3,4];
for (int i=0; i<3; i++)
{
    for (int j=0; j<4; j++)
    {
        Console.WriteLine($"{image[i,j]}");
    }
}                                         */

/*
int[,] image = new int[3,4];
for (int i=0; i<3; i++)
{
    for (int j=0; j<4; j++)
    {
        Console.Write($"{image[i,j]} ");
    }
Console.WriteLine();
}                                       */

/* в итоге получаем метод 

int[,] image = new int[3,4];
for (int i=0; i<image.GetLength(0); i++)
{
    for (int j=0; j<image.GetLength(1); j++)
    {
        Console.Write($"{image[i,j]} ");
    }
Console.WriteLine();
}                                        */

// метод, который буде печатать двумерную матрицу и заполнять ее числами

/*
void PrintArray(int[,] image)
{
    for (int i=0; i<image.GetLength(0); i++)
    {
        for (int j=0; j<image.GetLength(1); j++)
        {
         Console.Write($"{image[i,j]} ");
        }
    Console.WriteLine();
    }      
}
void FillArray(int[,] image)
{
    for (int i=0; i<image.GetLength(0); i++)
    {
        for (int j=0; j<image.GetLength(1); j++)
        {
            image[i,j] = new Random().Next(1,10); //[1;10]
        }
    }
}
int[,] image = new int[3,4];
PrintArray(image);
FillArray(image);
Console.WriteLine(); // для разграничения заполненного массива
PrintArray(image);          */

// закрашивание картинки

/*int[,] pic = new int[,];
// здесь куча ноликов и единичек, которые показывают картинку
void PrintImage(int[,] image)
{
    for (int i=0; i<image.GetLength(0); i++)
    {
        for (int j=0; j<image.GetLength(1); j++)
        {
         //Console.Write($"{image[i,j]} ");
         if(BadImageFormatException[i,j] == 0) Console.Write($" ");
         else Console.Write($"+");
        }
    Console.WriteLine();
    }      
}
/*   void FillArray(int[,] image)
{
    for (int i=0; i<image.GetLength(0); i++)
    {
        for (int j=0; j<image.GetLength(1); j++)
        {
            image[i,j] = new Random().Next(1,10); //[1;10]
        }
    }
}
int[,] image = new int[3,4];
PrintArray(image);
FillArray(image);
Console.WriteLine(); // для разграничения заполненного массива
PrintArray(image);    */

/*void FillImage(int row, in)   //метод, закрашивающий нашу картинку c указанием 
                              //строки и пикселя с которого мы начнем закрашивать
{
    if( pic[row, col]==0)
    {
        pic[row, col]=1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}          

PrintImage(pic);
FillImage (13,13);  //указываем точку, которая должна быть внутри изображения
PrintImage(pic);
                        */

// ФАКТОРИАЛ

/*
int Factorial(int n)
{
    if (n==1) return 1;             // 1!=1  0!=1
    else return n * Factorial(n-1);
}
Console.WriteLine(Factorial(3)); //1*2*3=6    */

// ФИБОНАЧИ
/* 
 int Fibonacci(int n)
 {
     if(n==1 || n==2) return 1;
     else return Fibonacci(n-1) + Fibonacci(n-2);
 }
 for (int i=1; i<10; i++)
 {
     Console.WriteLine(Fibonacci(i));
 }                            */

 double Fibonacci(int n)
 {
     if(n==1 || n==2) return 1;
     else return Fibonacci(n-1) + Fibonacci(n-2);
 }
 for (int i=1; i<40; i++)
 {
     Console.WriteLine(Fibonacci(i));
 }