// Написать программу, которая определяет сумму отрицательных элементов в массиве.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int [size];
    for(int i=0; i<size;i++)
    {
        array[i]=new Random().Next(minValue,maxValue+1);
    }
    return array;
}

int Sumnegative (int[] array)
{
    int sum=0;
     for(int i=0;i<array.Length;i++)
     {
        if (array[i]<0)
        sum+=array[i];
     }
     return sum;
}
void ShowArray(int[] array)

{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
        Console.WriteLine();
    }
}
Console.Write("Input a Length array");
int Length=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a minimal value");
int min=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a maximal value");
int max=Convert.ToInt32(Console.ReadLine());

int [] newArray=CreateRandomArray(Length,min, max);
ShowArray(CreateRandomArray(Length,min, max));
int result=Sumnegative(newArray);

Console.WriteLine("Sum of negatives of this array is "+result);
*/
//Написать программу, заменяющую положительные элементы массива на отрицательные и наоборот.
/*int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int [size];
    for(int i=0; i<size;i++)
    {
        array[i]=new Random().Next(minValue,maxValue+1);
    }
    return array;
}
void PrintArray(int[] array)

{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
        Console.WriteLine();
    }
}
int[] ConvertArray(int[] array)
{
    for(int i=0; i <array.Length; i++)
    array[i]=-array[i];
    return array;
}
Console.Write("Input a Length array");
int Length=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a minimal value");
int min=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a maximal value");
int max=Convert.ToInt32(Console.ReadLine());

int [] array=CreateRandomArray(size: Length,minValue:min,maxValue: max);
PrintArray(array);
int[] newArray=ConvertArray(array);
PrintArray(newArray);
*/

//Написать программу, определяющую, присутствует ли заданное число в массиве.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int [size];
    for(int i=0; i<size;i++)
    {
        array[i]=new Random().Next(minValue,maxValue+1);
    }
    return array;
}
void ShowArray(int[] array)

{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
        Console.WriteLine();
    }
}

void Checking (int[] array, int el)
{
    int count=0;
    for (int i=0; i<array.Length;i++ )
    {
        if(array[i]==el)
Console.WriteLine($"элемент равный {el} есть он равен{array[i]}. Индекс{i} ");
count+=1;
if(count==0)
Console.WriteLine("искомого эллемента нет");
    }
}
*/
/*
bool Checking (int[] array, int el)
{   for (int i=0; i<array.Length;i++ )
        if(array[i]==el)return true;
    return false;   
  
}
*/   
/*
Console.Write("Input a Length array");
int Length=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a minimal value");
int min=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a maximal value");
int max=Convert.ToInt32(Console.ReadLine());

int [] newArray=CreateRandomArray(Length,min, max);
ShowArray(newArray);
Checking(newArray,4);
*/
//Задать массив из n элементов, определить кол-во элементов, принадлежащих отрезку [a,b].
/*int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int [size];
    for(int i=0; i<size;i++)
    {
        array[i]=new Random().Next(minValue,maxValue+1);
    }
    return array;
}
void ShowArray(int[] array)


{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
        Console.WriteLine();
  
}
int Check(int[] array, int min, int max)
{
    int count=0;
    for (int i=0; i<array.Length;i++ )
    {
        if(array[i]>=min && array[i]<=max)
    {count+=1;           
    }
        }
return count;
}
Console.Write("Input a Length array");
int Length=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a minimal value");
int minimal=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a maximal value");
int maximal=Convert.ToInt32(Console.ReadLine());

int [] array=CreateRandomArray(Length,minimal, maximal);
ShowArray(array);
int count=Check(array,2,5);
Console.WriteLine($"количество элементов в данном интервале {count}");
*/