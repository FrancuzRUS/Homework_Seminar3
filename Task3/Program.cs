// 3. Найти сумму чисел от 1 до А

Console.Write("Введите A: "); 
int A = int.Parse(Console.ReadLine());

int Sum = 0;
int i = 0;

for (i = 1; i <= A;  i ++) Sum = Sum+i ; 

Console.WriteLine($"Сумма чисел равна {Sum}");
    

