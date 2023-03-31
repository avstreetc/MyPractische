using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] values = { 3, 70, 54 };

        CancellationTokenSource cts = new CancellationTokenSource();
        ParallelOptions options = new ParallelOptions { CancellationToken = cts.Token };

        int sum = 0;
        int product = 1;

        try
        {
            Parallel.ForEach(
                values,
                options,
                (n) =>
                {
                    if (options.CancellationToken.IsCancellationRequested)
                    {
                        throw new OperationCanceledException(options.CancellationToken);
                    }

                    sum += n;
                    product *= n;
                });
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Выполнение было прервано.");
        }

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product}");
    }
}
