using System;

namespace _06.Notifications
{
    class Program
    {
        static void Main()
        {
            var operation = Console.ReadLine();
            var message = Console.ReadLine();
            int code = int.Parse(Console.ReadLine());

            ShowSuccsess(operation, message);
            ShowError(operation, code);
        }

        private static void ShowError(string operation, int code)
        {
            var reason = String.Empty;
            Console.WriteLine($"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: {reason}.");
            if (code>0)
            {
                reason= " Invalid Client Data";
            }
            else if (code<0)
            {
                reason = "Internal System Failure";
            }
        }

        static void ShowSuccsess(string  operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}\n==============================\n.Message: {message}.");
        }
    }
}
