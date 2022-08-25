// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int M = InputNumbers("Введите M: ");
int N = InputNumbers("Введите N: ");
int temp = M;

if (M > N) 
{
  M = N; 
  N = temp;
}

PrintSumm(M, N, temp=0);

void PrintSumm(int M, int N, int sum)
{
  sum = sum + N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов= {sum} ");
    return;
  }
  PrintSumm(M, N - 1, sum);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
