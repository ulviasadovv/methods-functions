//Task 1
int sum(int num1, int num2)
{
    int result = num1 + num2;
    return result;
};

Console.WriteLine(sum(2, 5));



//Task 2
static int CircleArea(int r)
{
    int result = 3 * (r * r);
    return result;
};


static int RectangleArea(int a, int b)
{
    int result = a * b;
    return result;
};


static int CirInTriArea(int a, int b, int c, int r)
{
    int p = (a + b + c) / 2;
    int result = p * r;
    return result;
};

Console.WriteLine(CircleArea(5));
Console.WriteLine(RectangleArea(3, 8));
Console.WriteLine(CirInTriArea(1, 2, 5, 3));



//Task 3
int allSum(int a)
{
    int result = 0;
    int sum = 0;
    while (sum < a)
    {
        result++;


        if ((sum += result) <= a)
        {
            continue;
        }
        else
        {
            break;
        }
    };
    return sum;
};

Console.WriteLine(allSum(11));