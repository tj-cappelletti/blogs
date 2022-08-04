using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumExample
{
    namespace WithFlagAttribute
    {
        namespace Correct
        {
            [Flags]
            public enum DaysOfTheWeek
            {
                Sunday = 1,
                Monday = 1 << 1,
                Tuesday = 1 << 2,
                Wednesday = 1 << 3,
                Thursday = 1 << 4,
                Friday = 1 << 5,
                Saturday = 1 << 6,
            }
        }

        namespace Incorrect
        {
            [Flags]
            public enum DaysOfTheWeek
            {
                Sunday = 1,
                Monday = 2,
                Tuesday = 3,
                Wednesday = 4,
                Thursday = 5,
                Friday = 6,
                Saturday = 7,
            }
        }
    }

    namespace WithOutFlagsAttribute
    {
        namespace Correct
        {
            public enum DaysOfTheWeek
            {
                Sunday = 1,
                Monday = 1 << 1,
                Tuesday = 1 << 2,
                Wednesday = 1 << 3,
                Thursday = 1 << 4,
                Friday = 1 << 5,
                Saturday = 1 << 6,
            }
        }

        namespace Incorrect
        {
            public enum DaysOfTheWeek
            {
                Sunday = 1,
                Monday = 2,
                Tuesday = 3,
                Wednesday = 4,
                Thursday = 5,
                Friday = 6,
                Saturday = 7,
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            #region Decleration and Setup
            WithFlagAttribute.Correct.DaysOfTheWeek correctWithFlags;
            WithFlagAttribute.Incorrect.DaysOfTheWeek incorrectWithFlags;
            WithOutFlagsAttribute.Correct.DaysOfTheWeek correctWithOutFlags;
            WithOutFlagsAttribute.Incorrect.DaysOfTheWeek incorrectWithOutFlags;

            Console.WriteLine("Adding Monday, Wednesday, and Friday to the enumerators...");
            Console.WriteLine();
            Console.WriteLine("correctWithFlags = Monday | Tuesday | Wednesday;");
            Console.WriteLine();
            Console.WriteLine("incorrectWithFlags = Monday | Tuesday | Wednesday;");
            Console.WriteLine();
            Console.WriteLine("correctWithOutFlags = Monday | Tuesday | Wednesday;");
            Console.WriteLine();
            Console.WriteLine("incorrectWithOutFlags = Monday | Tuesday | Wednesday;");
            Console.WriteLine();

            correctWithFlags = WithFlagAttribute.Correct.DaysOfTheWeek.Monday | WithFlagAttribute.Correct.DaysOfTheWeek.Tuesday | WithFlagAttribute.Correct.DaysOfTheWeek.Wednesday;
            incorrectWithFlags = WithFlagAttribute.Incorrect.DaysOfTheWeek.Monday | WithFlagAttribute.Incorrect.DaysOfTheWeek.Tuesday | WithFlagAttribute.Incorrect.DaysOfTheWeek.Wednesday;
            correctWithOutFlags = WithOutFlagsAttribute.Correct.DaysOfTheWeek.Monday | WithOutFlagsAttribute.Correct.DaysOfTheWeek.Tuesday | WithOutFlagsAttribute.Correct.DaysOfTheWeek.Wednesday;
            incorrectWithOutFlags = WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Monday | WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Tuesday | WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Wednesday;
            #endregion

            #region Checking correctWithFlags
            Console.WriteLine("Checking correctWithFlags:");
            if ((correctWithFlags & WithFlagAttribute.Correct.DaysOfTheWeek.Sunday) == WithFlagAttribute.Correct.DaysOfTheWeek.Sunday)
                Console.WriteLine("\tContains Sunday!");
            else
                Console.WriteLine("\tDoes not contain Sunday!");
            if ((correctWithFlags & WithFlagAttribute.Correct.DaysOfTheWeek.Monday) == WithFlagAttribute.Correct.DaysOfTheWeek.Monday)
                Console.WriteLine("\tContains Monday!");
            else
                Console.WriteLine("\tDoes not contain Monday!");
            if ((correctWithFlags & WithFlagAttribute.Correct.DaysOfTheWeek.Tuesday) == WithFlagAttribute.Correct.DaysOfTheWeek.Tuesday)
                Console.WriteLine("\tContains Tuesday!");
            else
                Console.WriteLine("\tDoes not contain Tuesday!");
            if ((correctWithFlags & WithFlagAttribute.Correct.DaysOfTheWeek.Wednesday) == WithFlagAttribute.Correct.DaysOfTheWeek.Wednesday)
                Console.WriteLine("\tContains Wednesday!");
            else
                Console.WriteLine("\tDoes not contain Wednesday!");
            if ((correctWithFlags & WithFlagAttribute.Correct.DaysOfTheWeek.Thursday) == WithFlagAttribute.Correct.DaysOfTheWeek.Thursday)
                Console.WriteLine("\tContains Thursday!");
            else
                Console.WriteLine("\tDoes not contain Thursday!");
            if ((correctWithFlags & WithFlagAttribute.Correct.DaysOfTheWeek.Friday) == WithFlagAttribute.Correct.DaysOfTheWeek.Friday)
                Console.WriteLine("\tContains Friday!");
            else
                Console.WriteLine("\tDoes not contain Friday!");
            if ((correctWithFlags & WithFlagAttribute.Correct.DaysOfTheWeek.Saturday) == WithFlagAttribute.Correct.DaysOfTheWeek.Saturday)
                Console.WriteLine("\tContains Saturday!");
            else
                Console.WriteLine("\tDoes not contain Saturday!");
            #endregion

            Console.WriteLine();

            #region Checking incorrectWithFlags
            Console.WriteLine("Checking incorrectWithFlags:");
            if ((incorrectWithFlags & WithFlagAttribute.Incorrect.DaysOfTheWeek.Sunday) == WithFlagAttribute.Incorrect.DaysOfTheWeek.Sunday)
                Console.WriteLine("\tContains Sunday!");
            else
                Console.WriteLine("\tDoes not contain Sunday!");
            if ((incorrectWithFlags & WithFlagAttribute.Incorrect.DaysOfTheWeek.Monday) == WithFlagAttribute.Incorrect.DaysOfTheWeek.Monday)
                Console.WriteLine("\tContains Monday!");
            else
                Console.WriteLine("\tDoes not contain Monday!");
            if ((incorrectWithFlags & WithFlagAttribute.Incorrect.DaysOfTheWeek.Tuesday) == WithFlagAttribute.Incorrect.DaysOfTheWeek.Tuesday)
                Console.WriteLine("\tContains Tuesday!");
            else
                Console.WriteLine("\tDoes not contain Tuesday!");
            if ((incorrectWithFlags & WithFlagAttribute.Incorrect.DaysOfTheWeek.Wednesday) == WithFlagAttribute.Incorrect.DaysOfTheWeek.Wednesday)
                Console.WriteLine("\tContains Wednesday!");
            else
                Console.WriteLine("\tDoes not contain Wednesday!");
            if ((incorrectWithFlags & WithFlagAttribute.Incorrect.DaysOfTheWeek.Thursday) == WithFlagAttribute.Incorrect.DaysOfTheWeek.Thursday)
                Console.WriteLine("\tContains Thursday!");
            else
                Console.WriteLine("\tDoes not contain Thursday!");
            if ((incorrectWithFlags & WithFlagAttribute.Incorrect.DaysOfTheWeek.Friday) == WithFlagAttribute.Incorrect.DaysOfTheWeek.Friday)
                Console.WriteLine("\tContains Friday!");
            else
                Console.WriteLine("\tDoes not contain Friday!");
            if ((incorrectWithFlags & WithFlagAttribute.Incorrect.DaysOfTheWeek.Saturday) == WithFlagAttribute.Incorrect.DaysOfTheWeek.Saturday)
                Console.WriteLine("\tContains Saturday!");
            else
                Console.WriteLine("\tDoes not contain Saturday!");
            #endregion

            Console.WriteLine();

            #region Checking correctWithOutFlags
            Console.WriteLine("Checking correctWithOutFlags:");
            if ((correctWithOutFlags & WithOutFlagsAttribute.Correct.DaysOfTheWeek.Sunday) == WithOutFlagsAttribute.Correct.DaysOfTheWeek.Sunday)
                Console.WriteLine("\tContains Sunday!");
            else
                Console.WriteLine("\tDoes not contain Sunday!");
            if ((correctWithOutFlags & WithOutFlagsAttribute.Correct.DaysOfTheWeek.Monday) == WithOutFlagsAttribute.Correct.DaysOfTheWeek.Monday)
                Console.WriteLine("\tContains Monday!");
            else
                Console.WriteLine("\tDoes not contain Monday!");
            if ((correctWithOutFlags & WithOutFlagsAttribute.Correct.DaysOfTheWeek.Tuesday) == WithOutFlagsAttribute.Correct.DaysOfTheWeek.Tuesday)
                Console.WriteLine("\tContains Tuesday!");
            else
                Console.WriteLine("\tDoes not contain Tuesday!");
            if ((correctWithOutFlags & WithOutFlagsAttribute.Correct.DaysOfTheWeek.Wednesday) == WithOutFlagsAttribute.Correct.DaysOfTheWeek.Wednesday)
                Console.WriteLine("\tContains Wednesday!");
            else
                Console.WriteLine("\tDoes not contain Wednesday!");
            if ((correctWithOutFlags & WithOutFlagsAttribute.Correct.DaysOfTheWeek.Thursday) == WithOutFlagsAttribute.Correct.DaysOfTheWeek.Thursday)
                Console.WriteLine("\tContains Thursday!");
            else
                Console.WriteLine("\tDoes not contain Thursday!");
            if ((correctWithOutFlags & WithOutFlagsAttribute.Correct.DaysOfTheWeek.Friday) == WithOutFlagsAttribute.Correct.DaysOfTheWeek.Friday)
                Console.WriteLine("\tContains Sunday!");
            else
                Console.WriteLine("\tDoes not contain Friday!");
            if ((correctWithOutFlags & WithOutFlagsAttribute.Correct.DaysOfTheWeek.Saturday) == WithOutFlagsAttribute.Correct.DaysOfTheWeek.Saturday)
                Console.WriteLine("\tContains Saturday!");
            else
                Console.WriteLine("\tDoes not contain Saturday!");
            #endregion

            Console.WriteLine();

            #region Checking incorrectWithOutFlags
            Console.WriteLine("Checking incorrectWithOutFlags:");
            if ((incorrectWithOutFlags & WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Sunday) == WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Sunday)
                Console.WriteLine("\tContains Sunday!");
            else
                Console.WriteLine("\tDoes not contain Sunday!");
            if ((incorrectWithOutFlags & WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Monday) == WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Monday)
                Console.WriteLine("\tContains Monday!");
            else
                Console.WriteLine("\tDoes not contain Monday!");
            if ((incorrectWithOutFlags & WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Tuesday) == WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Tuesday)
                Console.WriteLine("\tContains Tuesday!");
            else
                Console.WriteLine("\tDoes not contain Tuesday!");
            if ((incorrectWithOutFlags & WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Wednesday) == WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Wednesday)
                Console.WriteLine("\tContains Wednesday!");
            else
                Console.WriteLine("\tDoes not contain Wednesday!");
            if ((incorrectWithOutFlags & WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Thursday) == WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Thursday)
                Console.WriteLine("\tContains Thursday!");
            else
                Console.WriteLine("\tDoes not contain Thursday!");
            if ((incorrectWithOutFlags & WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Friday) == WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Friday)
                Console.WriteLine("\tContains Friday!");
            else
                Console.WriteLine("\tDoes not contain Friday!");
            if ((incorrectWithOutFlags & WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Saturday) == WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Saturday)
                Console.WriteLine("\tContains Saturday!");
            else
                Console.WriteLine("\tDoes not contain Saturday!");
            #endregion

            Console.WriteLine();

            CheckUsingHasFlag(correctWithFlags, incorrectWithFlags, correctWithOutFlags, incorrectWithOutFlags);

            Console.ReadKey();
        }

        private static void CheckUsingHasFlag(WithFlagAttribute.Correct.DaysOfTheWeek correctWithFlags, WithFlagAttribute.Incorrect.DaysOfTheWeek incorrectWithFlags, WithOutFlagsAttribute.Correct.DaysOfTheWeek correctWithOutFlags, WithOutFlagsAttribute.Incorrect.DaysOfTheWeek incorrectWithOutFlags)
        {
            #region Checking correctWithFlags using HasFlag
            Console.WriteLine("Checking correctWithFlags using HasFlag:");
            if ((correctWithFlags.HasFlag(WithFlagAttribute.Correct.DaysOfTheWeek.Sunday)))
                Console.WriteLine("\tContains Sunday!");
            else
                Console.WriteLine("\tDoes not contain Sunday!");
            if ((correctWithFlags.HasFlag(WithFlagAttribute.Correct.DaysOfTheWeek.Monday)))
                Console.WriteLine("\tContains Monday!");
            else
                Console.WriteLine("\tDoes not contain Monday!");
            if ((correctWithFlags.HasFlag(WithFlagAttribute.Correct.DaysOfTheWeek.Tuesday)))
                Console.WriteLine("\tContains Tuesday!");
            else
                Console.WriteLine("\tDoes not contain Tuesday!");
            if ((correctWithFlags.HasFlag(WithFlagAttribute.Correct.DaysOfTheWeek.Wednesday)))
                Console.WriteLine("\tContains Wednesday!");
            else
                Console.WriteLine("\tDoes not contain Wednesday!");
            if ((correctWithFlags.HasFlag(WithFlagAttribute.Correct.DaysOfTheWeek.Thursday)))
                Console.WriteLine("\tContains Thursday!");
            else
                Console.WriteLine("\tDoes not contain Thursday!");
            if ((correctWithFlags.HasFlag(WithFlagAttribute.Correct.DaysOfTheWeek.Friday)))
                Console.WriteLine("\tContains Friday!");
            else
                Console.WriteLine("\tDoes not contain Friday!");
            if ((correctWithFlags.HasFlag(WithFlagAttribute.Correct.DaysOfTheWeek.Saturday)))
                Console.WriteLine("\tContains Saturday!");
            else
                Console.WriteLine("\tDoes not contain Saturday!");
            #endregion

            Console.WriteLine();

            #region Checking incorrectWithFlags using HasFlag
            Console.WriteLine("Checking incorrectWithFlags using HasFlag:");
            if ((incorrectWithFlags.HasFlag(WithFlagAttribute.Incorrect.DaysOfTheWeek.Sunday)))
                Console.WriteLine("\tContains Sunday!");
            else
                Console.WriteLine("\tDoes not contain Sunday!");
            if ((incorrectWithFlags.HasFlag(WithFlagAttribute.Incorrect.DaysOfTheWeek.Monday)))
                Console.WriteLine("\tContains Monday!");
            else
                Console.WriteLine("\tDoes not contain Monday!");
            if ((incorrectWithFlags.HasFlag(WithFlagAttribute.Incorrect.DaysOfTheWeek.Tuesday)))
                Console.WriteLine("\tContains Tuesday!");
            else
                Console.WriteLine("\tDoes not contain Tuesday!");
            if ((incorrectWithFlags.HasFlag(WithFlagAttribute.Incorrect.DaysOfTheWeek.Wednesday)))
                Console.WriteLine("\tContains Wednesday!");
            else
                Console.WriteLine("\tDoes not contain Wednesday!");
            if ((incorrectWithFlags.HasFlag(WithFlagAttribute.Incorrect.DaysOfTheWeek.Thursday)))
                Console.WriteLine("\tContains Thursday!");
            else
                Console.WriteLine("\tDoes not contain Thursday!");
            if ((incorrectWithFlags.HasFlag(WithFlagAttribute.Incorrect.DaysOfTheWeek.Friday)))
                Console.WriteLine("\tContains Friday!");
            else
                Console.WriteLine("\tDoes not contain Friday!");
            if ((incorrectWithFlags.HasFlag(WithFlagAttribute.Incorrect.DaysOfTheWeek.Saturday)))
                Console.WriteLine("\tContains Saturday!");
            else
                Console.WriteLine("\tDoes not contain Saturday!");
            #endregion

            Console.WriteLine();

            #region Checking correctWithOutFlags using HasFlag
            Console.WriteLine("Checking correctWithOutFlags using HasFlag:");
            if ((correctWithOutFlags.HasFlag(WithOutFlagsAttribute.Correct.DaysOfTheWeek.Sunday)))
                Console.WriteLine("\tContains Sunday!");
            else
                Console.WriteLine("\tDoes not contain Sunday!");
            if ((correctWithOutFlags.HasFlag(WithOutFlagsAttribute.Correct.DaysOfTheWeek.Monday)))
                Console.WriteLine("\tContains Monday!");
            else
                Console.WriteLine("\tDoes not contain Monday!");
            if ((correctWithOutFlags.HasFlag(WithOutFlagsAttribute.Correct.DaysOfTheWeek.Tuesday)))
                Console.WriteLine("\tContains Tuesday!");
            else
                Console.WriteLine("\tDoes not contain Tuesday!");
            if ((correctWithOutFlags.HasFlag(WithOutFlagsAttribute.Correct.DaysOfTheWeek.Wednesday)))
                Console.WriteLine("\tContains Wednesday!");
            else
                Console.WriteLine("\tDoes not contain Wednesday!");
            if ((correctWithOutFlags.HasFlag(WithOutFlagsAttribute.Correct.DaysOfTheWeek.Thursday)))
                Console.WriteLine("\tContains Thursday!");
            else
                Console.WriteLine("\tDoes not contain Thursday!");
            if ((correctWithOutFlags.HasFlag(WithOutFlagsAttribute.Correct.DaysOfTheWeek.Friday)))
                Console.WriteLine("\tContains Sunday!");
            else
                Console.WriteLine("\tDoes not contain Friday!");
            if ((correctWithOutFlags.HasFlag(WithOutFlagsAttribute.Correct.DaysOfTheWeek.Saturday)))
                Console.WriteLine("\tContains Saturday!");
            else
                Console.WriteLine("\tDoes not contain Saturday!");
            #endregion

            Console.WriteLine();

            #region Checking incorrectWithOutFlags using HasFlag
            Console.WriteLine("Checking incorrectWithOutFlags using HasFlag:");
            if ((incorrectWithOutFlags.HasFlag(WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Sunday)))
                Console.WriteLine("\tContains Sunday!");
            else
                Console.WriteLine("\tDoes not contain Sunday!");
            if ((incorrectWithOutFlags.HasFlag(WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Monday)))
                Console.WriteLine("\tContains Monday!");
            else
                Console.WriteLine("\tDoes not contain Monday!");
            if ((incorrectWithOutFlags.HasFlag(WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Tuesday)))
                Console.WriteLine("\tContains Tuesday!");
            else
                Console.WriteLine("\tDoes not contain Tuesday!");
            if ((incorrectWithOutFlags.HasFlag(WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Wednesday)))
                Console.WriteLine("\tContains Wednesday!");
            else
                Console.WriteLine("\tDoes not contain Wednesday!");
            if ((incorrectWithOutFlags.HasFlag(WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Thursday)))
                Console.WriteLine("\tContains Thursday!");
            else
                Console.WriteLine("\tDoes not contain Thursday!");
            if ((incorrectWithOutFlags.HasFlag(WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Friday)))
                Console.WriteLine("\tContains Friday!");
            else
                Console.WriteLine("\tDoes not contain Friday!");
            if ((incorrectWithOutFlags.HasFlag(WithOutFlagsAttribute.Incorrect.DaysOfTheWeek.Saturday)))
                Console.WriteLine("\tContains Saturday!");
            else
                Console.WriteLine("\tDoes not contain Saturday!");
            #endregion

            Console.WriteLine();
        }
    }
}
