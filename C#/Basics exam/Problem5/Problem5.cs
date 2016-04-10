using System;

class Problem5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string line = Console.ReadLine();
        int bit = 0;
        int result = 0;

        while (line != "end")
        {
            string[] parameters = line.Split();
            string spice =parameters[0];
            int step = int.Parse(parameters[1]);

            if (spice == "salt")
            {
                for (int i = 0; i < 65; i++)
                {
                    int nRightStep = n >> step;
                    bit = nRightStep & 1;

                    if (bit == 1)
                    {
                        int mask = ~(1 << step);
                        result = n & mask;
                    }
                    step += step;
                }             


            }
            //else if (spice == "pepper")
            //{

            //}

            line = Console.ReadLine();
        }
        Console.WriteLine(result);
    }
}