int n = 918;
int i1 = 100;
int i2 = 10;
int result = 0;
int result1 = 0;
int result2 = 0;
int result3 = 0;

while (i1 < n)
{
    i1 = i1 + 100;
    result = result + 100;
    result1 = result - 100;
}
int a = n - result;

while (i2 < a)
{
    i2 = i2 + 10;
    result2 = result2 + 10;
    result3 = result3 - 10;

}
int b = a - result2;
Console.WriteLine(b);

