// Напишите программу, которая задаёт массив из 8 элементов 
// случайными числами (до 1000) и выводит их на экран.
void printArray(int[] array)
{
  for (int i = 0; i < array.Length; i++ )
    {
      System.Console.Write(array[i]+"  ");
    }
}
int [] array = new int[8];

for (int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(0,1001);
}
printArray(array);