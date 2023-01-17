int Max(int arg1, int arg2, int agr3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (agr3 > result) result = agr3;
    return result;
}
//               0  1  2   3  4  5   6  7  8
int [] array = {13,51,23,233,55,27,235,24,23};

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);
