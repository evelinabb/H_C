﻿int Max(int arg1, int arg2, int agr3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (agr3 > result) result = agr3;
    return result;
}

int a1 = 10;
int b1 = 12;
int c1 = 43;
int a2 = 24;
int b2 = 18;
int c2 = 42;
int a3 = 13;
int b3 = 34;
int c3 = 653;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);

//int max = Max(max1, max2, max3);

int max = Max (
        Max (a1, b1, c1),  
        Max (a2, b2, c2),
        Max (a3, b3, c3));

Console.WriteLine(max);