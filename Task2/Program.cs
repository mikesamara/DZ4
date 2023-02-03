//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (a >= 0){
    // sum = sum + a%10;      
    // a=a/10; 
    //System.Console.WriteLine(a);
    //НЕ ЗНАЮ ЧТО В ИТОГЕ ОСТАВИТЬ.
}
else{
    a = -1*a;
}
while (a > 0)
{
    sum = sum + a%10;      //System.Console.WriteLine(sum);
    a=a/10;               //System.Console.WriteLine(a);
}
System.Console.WriteLine(sum);