using static System.Console;
WriteLine("Введите размер массива");
int size = Convert.ToInt32(ReadLine());
int[] numbers =new int[size];
FillArrayRandomNumbers(numbers);
WriteLine("Вот ваш массив:");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Write($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int [] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int [] numbers)
{
    Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        Write(numbers[i] + " ");
    }
    Write("]");
    WriteLine();
}


