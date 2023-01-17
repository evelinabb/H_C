int a1 = 10;
int b1 = 12;
int c1 = 43;
int a2 = 24;
int b2 = 18;
int c2 = 42;
int a3 = 13;
int b3 = 34;
int c3 = 653;

int max = a1;

if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);