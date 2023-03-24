/*
Написать программу,которя из имеющегося массива строк формирует массив из строк,длинна которого меньше,либо рравна 3 символа.
*/

int []array=new int[3];
Random rand=new Random();
for (int i = 0; i < array.Length; i++)
{
  array[i]=rand.Next(1,10);  
}

void FillArray(int[]arr)
{
  Random rand=new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i]= rand.Next(1,3);
  }  
}

void PrintArray(int[]arr)
{
    Console.WriteLine("[" +string.Join(", ", array) + "]");
}

 int[]arr=new int[3];
 FillArray(array);
 PrintArray(array);

