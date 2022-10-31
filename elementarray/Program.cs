Console.WriteLine("This program check, is your number in array, if it is true, show element of array, that equal to your number.");

int find = 3;
int [] array = {5,7,4,7,4,5,3,3,4,67,46,25,75,7433,64,77,44};
int index = 0;
int size = array.Length;

while(index < size)
{
    if(array[index] == find)
    {
        Console.WriteLine($"{find} is {index} element of array");
        break;
    }
    index++;
}
