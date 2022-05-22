//5. Подсчитать сумму цифр в числе

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

int Sum = 0; 

while (N >= 1)
{
    Sum = Sum + N%10;
    N = (N-N%10)/10;
}
 Console.WriteLine ($"Сумма цифр в числе равна  {Sum}");




