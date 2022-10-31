Console.WriteLine("This program print max of 9 numbers, entered in program.");

int maxi (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

/* int num1 = 5;
int num2 = 9;
int num3 = 6666;
int num4 = 4;
int num5 = 8;
int num6 = 7;          replace with an array
int num7 = 19;
int num8 = 877;
int num9 = 89; */

int[] array = {5, 9, 6666, 4, 8, 7, 19, 877, 89};

/* int max = maxi(
        maxi(num1, num2, num3), 
        maxi(num4, num5, num6),      replace with array
        maxi(num7, num8, num9)
); */

int max = maxi(maxi(array[0], array[1], array[2]), maxi(array[3], array[4], array[5]), maxi(array[6], array[7], array[8]));

Console.WriteLine(max);