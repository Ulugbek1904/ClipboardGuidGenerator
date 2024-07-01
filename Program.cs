using System;

namespace ClipboardGuidGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProg = true;
            while (continueProg)
            {
                string stringGuid =
                    Guid.NewGuid().ToString();

                Console.WriteLine(stringGuid);
                Console.WriteLine(DateTimeOffset.Now);

                TextCopy.ClipboardService.SetText($"" +
                    $"{stringGuid},{DateTimeOffset.Now.ToString()}");

                Console.WriteLine("Copied!");
                Console.WriteLine("Do you " +
                    "want to run again?  yes(y) or any word");

                string input =
                    Console.ReadLine().ToLower();

                continueProg = input == "yes"
                    || input == "y";
            }
            Console.ReadLine();
        }
    }
}
