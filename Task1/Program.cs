//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
System.Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b= Convert.ToInt32(Console.ReadLine());
int expon = a;
for (int i = 1; i < b; i++)
{
    expon = expon*a;
}
System.Console.WriteLine("expon =" + expon);