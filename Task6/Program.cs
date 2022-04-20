// изначально считал что нужно до сотых, но можно кол-во вывести до 10 без сотых 
// и будет выводится последняя цифра.
int n = 716;
int i1 = 100;
int i2 = 10;
int result = 0;
int result1 = 0;

while (i1 < n)
{
    i1 = i1 + 100;
    result = result + 100;
}
int a = n - result;

while (i2 < a)
{
    i2 = i2 + 10;
    result1 = result1 + 10;

}
int b = a - result1;
Console.WriteLine(b);

