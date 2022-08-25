// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

int M = InputNumbers("Введите M: ");
int N = InputNumbers("Введите N: ");

PrintNumber(M, N);

void PrintNumber(int M, int N)
{
Console.WriteLine($"N={N}, M={M}");
if (M>N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
