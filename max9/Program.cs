Console.WriteLine("This program print max of 9 numbers, entered in program.");

int maxi (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int num1 = 5;
int num2 = 9;
int num3 = 2;
int num4 = 4;
int num5 = 8;
int num6 = 7;
int num7 = 19;
int num8 = 877;
int num9 = 89;

int max1 = maxi(num1, num2, num3);
int max2 = maxi(num4, num5, num6);
int max3 = maxi(num8, num7, num9);
int max = maxi(max1, max2, max3);

/* if (num2 > max) max = num2;
if (num3 > max) max = num3;
if (num4 > max) max = num4;
if (num5 > max) max = num5;
if (num6 > max) max = num6;
if (num7 > max) max = num7;
if (num8 > max) max = num8;
if (num9 > max) max = num9; */

Console.WriteLine(max);