// 4. Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число А:");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число B:");
int B = int.Parse(Console.ReadLine());

int C = 1;
int i = 1;

for (i = 1; i <= B; i++) C = A*C; 
Console.WriteLine($"Число А в степени В = {C}");


