

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

double A, B,Max;

Max = 0;
A = -9;
B = -3;

if (A < B)
          {
          Max = B;
          }
else
    {
    Max = A;
    }
System.Console.WriteLine(Max);


    //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

{
double a, b, c, max;
a = 9;
b = 3;
c = 2;
max = 0;
if (a < b)
 {
          if (b < c)
{
  max = c;
  }
else
    {
    max = b;
    }
}
else
{
if (a < c)
 {
 max = c;
 }
else
   {
     max = a;
   }
}
 Console.WriteLine(max);
}

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
// mod 
// div

int g;

g = 5;

if (g % g == (double) g / g)
 {
  System.Console.WriteLine("Yes");
 }
else
  {
   System.Console.WriteLine("No");
  }


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int n;
int index;
        
n = 5;
index = 0;
  while (index < n)
 { 
  if (index % 2 == 0)
  {
  index = index + 1;
  }
else
  {
  index = index + 1;
  Console.WriteLine(index);
  }
}
