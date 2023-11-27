using System;

        int[] sophia = { 90, 86, 87, 98, 100 };


        int sophiaSum = 1;


        foreach (int sum in sophia)

        {
            Console.WriteLine(sum);
            sophiaSum += sophia[sum];

        }

        Console.WriteLine(sophiaSum);
 











 