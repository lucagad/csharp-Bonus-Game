
// CALCOLO FATTORIALE DI UN NUMERO

Console.WriteLine(fattoriale(5));

int fattoriale(int n)
{
    if (n == 1) return 1;

    else
    {
        return n = n * fattoriale(n - 1);
    }
}