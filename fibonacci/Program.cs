// // 
// // 0, 1, 1, 2, 3, 5, 8, 13, 21...

// int result = Fibonacci(5); // 5
// Console.WriteLine(result); // 5

// static int Fibonacci(int n)
// {
//     int n1 = 0;
//     int n2 = 1;
//     int sum;

//     for (int i = 2; i < n; i++)
//     {
//         sum = n1 + n2;
//         n1 = n2;
//         n2 = sum;
//     }

//     return n == 0 ? n1 : n2;
// }

int result = Fibonacci(5);
Console.WriteLine(result);
Console.WriteLine("This message is readable by the end user.");
// Trace.WriteLine("This is a trace message when tracing the app.");
// Debug.WriteLine("This is a debug message just for developers.");

static int Fibonacci(int n)
{
    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }
    

    return n == 0 ? n1 : n2;
}
