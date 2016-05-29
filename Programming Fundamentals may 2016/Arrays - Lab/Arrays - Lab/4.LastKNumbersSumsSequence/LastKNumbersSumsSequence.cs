using System;

class LastKNumbersSumsSequence
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var k = int.Parse(Console.ReadLine());
        var seq = new long[n];
        seq[0] = 1;
        for (int current = 1; current < n; current++)
        {
            var start = Math.Max(0, current - k);
            var end = current - 1;

            long sum = 0;
            for (int j = start; j <= end; j++)

                if (start >= 0)
                {
                        sum += seq[j];
                }

            seq[current] = sum;
        }

        for (int i = 0; i < seq.Length; i++)
        {
            if (i < seq.Length - 1)
            {
                Console.Write(seq[i] + " ");
            }
            else
            {
                Console.Write(seq[i]);
            }
        }
    }
}