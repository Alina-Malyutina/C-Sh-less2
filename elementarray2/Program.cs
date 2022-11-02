void FillArray(int [] collection1)
{
    int length1 = collection1.Length;
    int index1 = 0;
    while(index1<length1)
    {
        collection1 [index1] = new Random().Next(1,10);
        index1++;
    }
}

void PrintArray (int [] collection2)
{
    int length2 = collection2.Length;
    int index2 = 0;
    while (index2<length2)
    {
        Console.WriteLine(collection2[index2]);
        index2++;
    }
}

int IndexOf( int [] collection1, int find)
{
    int length1 = collection1.Length;
    int index1 = 0;
    int findindex = -1;

    while (index1 < length1)
    {
        if (collection1[index1] == find)
        {
            findindex = collection1[index1];
            break;
        }
        index1++;
    }
    return findindex;
}


int [] array = new int [10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 6);
Console.WriteLine(pos);