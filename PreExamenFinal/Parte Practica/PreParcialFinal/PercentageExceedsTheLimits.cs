using System;

namespace DefaultNamespace
{
    public class PercentageExceedsTheLimits : Exception
        {
            public PercentageExceedsTheLimits(string message) : base(message)
            {
                Console.WriteLine(message);
            }
    }
}